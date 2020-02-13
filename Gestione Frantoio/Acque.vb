Public Class Acque

    'salvataggio dati
    Private Sub AcqueBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcqueBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.AcqueBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'caricamento form
    Private Sub Acque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FattureDataSet.Acque' table. You can move, or remove it, as needed.
        Me.AcqueTableAdapter.Fill(Me.FattureDataSet.Acque)
        Me.AcqueBindingSource.MoveLast()
        totale_acqua()
    End Sub

    'query acqua
    Private Sub totale_acqua()
        Try
            Dim acque As Double = Impostazioni.Acque.Text

            If Fattura.FattureTableAdapter.GetData.Rows.Count = 0 Then
                TextBox1.Text = 0
            Else
                TextBox1.Text = (Fattura.FattureTableAdapter.TotaleKgOliveMolite / 100) * acque
            End If

            If AcqueTableAdapter.GetData.Count = 0 Then
                TextBox2.Text = 0
            Else
                TextBox2.Text = AcqueTableAdapter.AcqueScaricate
            End If

            Dim acqueprodotte As Double = TextBox1.Text
            Dim acquescaricate As Double = TextBox2.Text

            TextBox3.Text = acqueprodotte - acquescaricate

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        totale_acqua()
    End Sub

    'inserimento data
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                            DateTimePicker1.Value.Month.ToString("00") & "/" & _
                            DateTimePicker1.Value.Year.ToString("0000")
        DataTextBox.Text = data
    End Sub

    'inserimento dati costanti da ditta
    Private Sub KgAcqueTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KgAcqueTextBox.TextChanged

        'autoinserimento della data se non è gia stata impostata
        If DataTextBox.Text = "" Then
            DateTimePicker1.Value = Today
            Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                               DateTimePicker1.Value.Month.ToString("00") & "/" & _
                             DateTimePicker1.Value.Year.ToString("0000")
            DataTextBox.Text = data
        End If


        If DenominazioneTextBox.Text = "" Then
            DenominazioneTextBox.Text = Ditta.DittaTextBox.Text
        End If

        If IndirizzoTextBox.Text = "" Then
            IndirizzoTextBox.Text = Ditta.IndirizzoTextBox.Text
        End If

        If CittàTextBox.Text = "" Then
            CittàTextBox.Text = Ditta.CittaTextBox.Text
        End If

        If ProvinciaTextBox.Text = "" Then
            ProvinciaTextBox.Text = Ditta.ProvTextBox.Text
        End If

        If Targa_MezzoTextBox.Text = "" Then
            Targa_MezzoTextBox.Text = Ditta.AMezzoTextBox.Text
        End If

        If DescrizioneTextBox.Text = "" Then
            DescrizioneTextBox.Text = Ditta.ADescrizioneTextBox.Text
        End If

        If Stato_FisicoTextBox.Text = "" Then
            Stato_FisicoTextBox.Text = Ditta.AStatoFisicoTextBox.Text
        End If

        If DestinazioneTextBox.Text = "" Then
            DestinazioneTextBox.Text = Ditta.ADestinazioneTextBox.Text
        End If

    End Sub

    Private Sub StampaBolla_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles StampaBolla.PrintPage
     Dim bordo As Integer
        If Impostazioni.BordoTextbox.Text = "" Then
            bordo = 785
        Else
            bordo = Impostazioni.BordoTextbox.Text
        End If
        e.Graphics.DrawRectangle(Pens.Black, 15, 15, bordo, 185)

        Dim l As New System.Drawing.StringFormat
        l.Alignment = StringAlignment.Far

        'font
        Dim f1 As New System.Drawing.Font(Me.Font.FontFamily, 30.1)
        Dim f2 As New System.Drawing.Font(Me.Font.FontFamily, 19.8)
        Dim f3 As New System.Drawing.Font(Me.Font.FontFamily, 16.5)
        Dim f4 As New System.Drawing.Font(Me.Font.FontFamily, 15.5)
        Dim f5 As New System.Drawing.Font(Me.Font.FontFamily, 14.5)
        Dim f7 As New System.Drawing.Font(Me.Font.FontFamily, 10.5)
        Dim f6 As New System.Drawing.Font(Fattura.Denominazione_ClienteTextBox.Font.FontFamily, 12.5)
        Dim provincia As String

        Select Case Fattura.ProvinciaTextBox.Text
            Case "AGRIGENTO"
                provincia = "(AG)"
            Case "CALTANISSETTA"
                provincia = "(CL)"
            Case "CATANIA"
                provincia = "(CT)"
            Case "ENNA"
                provincia = "(EN)"
            Case "MESSINA"
                provincia = "(ME)"
            Case "PALERMO"
                provincia = "(PA)"
            Case "RAGUSA"
                provincia = "(RG)"
            Case "SIRACUSA"
                provincia = "(SR)"
            Case "TRAPANI"
                provincia = "(TP)"

            Case Else
                If Fattura.ProvinciaTextBox.Text.Length > 2 Then
                    provincia = "(PROVINCIA DI " & Fattura.ProvinciaTextBox.Text & ")"
                Else
                    provincia = "(" & Fattura.ProvinciaTextBox.Text & ")"
                End If

        End Select

        'intestazione
        e.Graphics.DrawString(Ditta.DittaTextBox.Text, f1, Brushes.Black, 18, 14)
        e.Graphics.DrawString(Ditta.RagioneTextBox.Text, f2, Brushes.Black, 18, 58)
        e.Graphics.DrawString(Ditta.IndirizzoTextBox.Text, f3, Brushes.Black, 18, 90)
        e.Graphics.DrawString(Ditta.CapTextBox.Text & " " & Ditta.CittaTextBox.Text & " (" & Ditta.ProvTextBox.Text & ") " & "TEL." & Ditta.TelTextBox.Text, f3, Brushes.Black, 18, 112)
        If Ditta.SitoTextBox.Text = "" Then
            e.Graphics.DrawString("P.IVA " & Ditta.PIVATextBox.Text, f3, Brushes.Black, 18, 135)
        Else
            e.Graphics.DrawString("P.IVA " & Ditta.PIVATextBox.Text & " Sito Web: " & Ditta.SitoTextBox.Text, f3, Brushes.Black, 18, 135)
        End If

        If Ditta.MailTextBox.Text = "" Then

        Else
            e.Graphics.DrawString("E-Mail: " & Ditta.MailTextBox.Text, f3, Brushes.Black, 18, 158)
        End If

        'cliente
        e.Graphics.DrawString("Documento di trasporto", f4, Brushes.Black, 40, 225) '15
        e.Graphics.DrawString(" DPR n. 472 del 14/08/96", f7, Brushes.Black, 40, 250)
        e.Graphics.DrawString("Numero " & Me.BollaTextBox.Text & " del " & Me.DataTextBox.Text, f7, Brushes.Black, 40, 305)

        e.Graphics.DrawString("Luogo di destinazione:" & vbCrLf & Ditta.ADNomeTextBox.Text & vbCrLf & Ditta.ADIndirizzoTextBox.Text & vbCrLf & Ditta.ADComuneTextBox.Text & " (" & Ditta.ADProvinciaTextBox.Text & ")" & vbCrLf & "P.Iva: " & Ditta.ADPartitaIvaTextBox.Text, f7, Brushes.Black, 40, 355)


        e.Graphics.DrawString("Causale di trasporto:" & vbCrLf & "Spandimento - Utilizzazione agronomica", f7, Brushes.Black, 40, 470)
        'fattura
        'e.Graphics.DrawLine(Pens.Black, 15, 390, 785, 390)
        e.Graphics.DrawString("Descrizione dei beni:", f7, Brushes.Black, 40, 530) '375

        e.Graphics.DrawString("LT. " & Me.KgAcqueTextBox.Text & " di acque di vegetazione", f7, Brushes.Black, 40, 550)
        e.Graphics.DrawString("N. colli: 1 Peso Kg. " & Me.KgAcqueTextBox.Text, f7, Brushes.Black, 40, 595)



        'e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 440)


        'e.Graphics.DrawString("Sansa Prodotta Kg.", f6, Brushes.Black, 25, 535)
        'e.Graphics.DrawString(Fattura.KgSansaTextBox.Text, f7, Brushes.Black, 155, 535) '150

        'e.Graphics.DrawString("Prezzo al Kg. Euro.", f6, Brushes.Black, 240, 535)
        'e.Graphics.DrawString(Fattura.Prezzo_al_KG_SansaTextBox.Text, f7, Brushes.Black, 370, 535)


        'e.Graphics.DrawString("Firma del cliente________________________", f7, Brushes.Black, 785, 750, l)
        e.Graphics.DrawString("Vettore:" & vbCrLf & Ditta.AVNomeTextbox.Text & vbCrLf & Ditta.AVIndirizzoTextBox.Text & vbCrLf & Ditta.AVComuneTextBox.Text & " (" & Ditta.AVProvinciaTextBox.Text & ")" & vbCrLf & "P.Iva: " & Ditta.AVPartitaivaTextBox.Text, f7, Brushes.Black, 40, 640)
        'e.Graphics.DrawString("Il sottoscritto dichiara di non essere imprenditore e di non possedere Partita Iva.", f6, Brushes.Black, 25, 780)

        e.Graphics.DrawString("Targa mezzo: " & Me.Targa_MezzoTextBox.Text, f7, Brushes.Black, 40, 750)


        e.Graphics.DrawString("Cognome e nome del conducente: _______________________________  Firma: ___________________", f7, Brushes.Black, 40, 790)

        e.Graphics.DrawString("Data e ora di partenza: _____________________", f7, Brushes.Black, 40, 830)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        StampaBolla.Print()
    End Sub
End Class