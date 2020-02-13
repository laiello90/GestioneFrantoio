Public Class Sansa

    'salvataggio dati
    Private Sub SansaBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SansaBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.SansaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'caricamento form
    Private Sub Sansa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FattureDataSet.Sansa' table. You can move, or remove it, as needed.
        Me.SansaTableAdapter.Fill(Me.FattureDataSet.Sansa)
        Me.SansaBindingSource.MoveLast()
        totale_sansa()
    End Sub

    'query per la sansa
    Private Sub totale_sansa()
        Try
            Dim sansa As Double = Impostazioni.Sansa.Text
            If Fattura.FattureTableAdapter.GetData.Rows.Count = 0 Then
                TextBox1.Text = 0
            Else
                TextBox1.Text = (Fattura.FattureTableAdapter.TotaleKgOliveMolite / 100) * sansa
            End If

            If SansaTableAdapter.GetData.Count = 0 Then
                TextBox2.Text = 0
            Else
                TextBox2.Text = SansaTableAdapter.SansaInviata
            End If
            Dim sansaIniziale As Double = Impostazioni.GiacenzaInizialeTextBox.Text
            Dim sansaprodotta As Double = TextBox1.Text
            Dim sansascaricata As Double = TextBox2.Text
            Dim superisansa As Double = SansaTableAdapter.SuperiSansa.GetValueOrDefault(0)
            TextBox4.Text = Impostazioni.GiacenzaInizialeTextBox.Text
            TextBox5.Text = superisansa
            TextBox3.Text = sansaprodotta - sansascaricata + sansaIniziale + superisansa
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        totale_sansa()
    End Sub

    'cambio data
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                               DateTimePicker1.Value.Month.ToString("00") & "/" & _
                               DateTimePicker1.Value.Year.ToString("0000")
        DataTextBox.Text = data
    End Sub

    'inserimento data con i kg
    Private Sub KgTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KgTextBox.TextChanged

        If DataTextBox.Text = "" Then
            DateTimePicker1.Value = Today
            Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                               DateTimePicker1.Value.Month.ToString("00") & "/" & _
                             DateTimePicker1.Value.Year.ToString("0000")
            DataTextBox.Text = data
        End If
        If Numero_OperazioneTextBox.Text = "" Then
            Numero_OperazioneTextBox.Text = Impostazioni.NOperazioneGiornaliera.Text
        End If

        If CausaleComboBox.Text = "G3" Then
            If DenominazioneTextBox.Text = "" Then
                DenominazioneTextBox.Text = Ditta.SNomeTextBox.Text
            End If

            If ComuneTextBox.Text = "" Then
                ComuneTextBox.Text = Ditta.ScomuneTextBox.Text
            End If

            If ProvinciaTextBox.Text = "" Then
                ProvinciaTextBox.Text = Ditta.SprovinciaTextBox.Text
            End If

            If IndirizzoTextBox.Text = "" Then
                IndirizzoTextBox.Text = Ditta.SindirizzoTextBox.Text
            End If

            If CF_o_PivaTextBox.Text = "" Then
                CF_o_PivaTextBox.Text = Ditta.SpartitaivaTextBox.Text
            End If
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


        e.Graphics.DrawString("Documento di trasporto", f4, Brushes.Black, 40, 225) '15
        e.Graphics.DrawString(" DPR n. 472 del 14/08/96", f7, Brushes.Black, 40, 250)
        e.Graphics.DrawString("Numero " & Me.Riferimento_DocumentoTextBox.Text & " del " & Me.DataTextBox.Text, f7, Brushes.Black, 40, 305)

        e.Graphics.DrawString("Luogo di destinazione:" & vbCrLf & Ditta.SDNomeTextBox.Text & vbCrLf & Ditta.SDIndirizzoTextBox.Text & vbCrLf & Ditta.SDComuneTextBox.Text & " (" & Ditta.SDProvinciaTextBox.Text & ")" & vbCrLf & "P.Iva: " & Ditta.SDPartitaIvaTextBox.Text, f7, Brushes.Black, 40, 355)

        e.Graphics.DrawString("Destinatario:" & vbCrLf & Ditta.SNomeTextBox.Text & vbCrLf & Ditta.SindirizzoTextBox.Text & vbCrLf & Ditta.ScomuneTextBox.Text & " (" & Ditta.SprovinciaTextBox.Text & ")" & vbCrLf & "P.Iva: " & Ditta.SpartitaivaTextBox.Text, f7, Brushes.Black, 500, 355)


        e.Graphics.DrawString("Descrizione dei beni:" & vbCrLf & "Sansa vergine d'oliva", f7, Brushes.Black, 40, 470)

        e.Graphics.DrawString("Peso stabilito alla consegna Kg. __________", f7, Brushes.Black, 40, 520)

        e.Graphics.DrawString("Aspetto esteriore dei beni: Rinfusa", f7, Brushes.Black, 40, 595)



        'e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 440)


        'e.Graphics.DrawString("Sansa Prodotta Kg.", f6, Brushes.Black, 25, 535)
        'e.Graphics.DrawString(Fattura.KgSansaTextBox.Text, f7, Brushes.Black, 155, 535) '150

        'e.Graphics.DrawString("Prezzo al Kg. Euro.", f6, Brushes.Black, 240, 535)
        'e.Graphics.DrawString(Fattura.Prezzo_al_KG_SansaTextBox.Text, f7, Brushes.Black, 370, 535)


        'e.Graphics.DrawString("Firma del cliente________________________", f7, Brushes.Black, 785, 750, l)
        e.Graphics.DrawString("Vettore:" & vbCrLf & Ditta.SVNomeTextBox.Text & vbCrLf & Ditta.SVIndirizzoTextBox.Text & vbCrLf & Ditta.SVComuneTextBox.Text & " (" & Ditta.SVProvinciaTextBox.Text & ")" & vbCrLf & "P.Iva: " & Ditta.SVPartitaIvaTextBox.Text, f7, Brushes.Black, 40, 640)
        'e.Graphics.DrawString("Il sottoscritto dichiara di non essere imprenditore e di non possedere Partita Iva.", f6, Brushes.Black, 25, 780)

        e.Graphics.DrawString("Targa mezzo: " & Ditta.SMezzoTextBox.Text, f7, Brushes.Black, 40, 750)


        e.Graphics.DrawString("Cognome e nome del conducente: _______________________________  Firma: ___________________", f7, Brushes.Black, 40, 790)

        e.Graphics.DrawString("Data e ora di partenza: _____________________", f7, Brushes.Black, 40, 830)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        StampaBolla.Print()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click

        Try
            'carico
            CaricatoCheckBox.CheckState = CheckState.Checked
            Me.Validate()
            Me.SansaBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)

            If CausaleComboBox.Text = "G3" Then
                Try



                    Dim carico As New String(" ", 877)



                    'cuaa azienda
                    Dim CUAA As New String(" ", 16)
                    CUAA = CUAA.Insert(0, Ditta.PIVATextBox.Text)
                    carico = carico.Insert(0, CUAA)
                    carico = carico.Insert(16, ";")



                    'id stabilimento
                    Dim IDstabilimento As New String(" ", 10)
                    IDstabilimento = IDstabilimento.Insert(0, Impostazioni.StabilimentoTextBox.Text.ToString)
                    carico = carico.Insert(17, IDstabilimento)
                    carico = carico.Insert(27, ";")



                    'numero operazione giornaliera
                    Dim OpGiornaliera As Integer = Numero_OperazioneTextBox.Text
                    OpGiornaliera = (OpGiornaliera)
                    carico = carico.Insert(28, OpGiornaliera.ToString("0000000000"))
                    carico = carico.Insert(38, ";")


                    'data
                    carico = carico.Insert(39, DataTextBox.Text.Replace("/", ""))
                    carico = carico.Insert(47, ";")



                    'numero doc giustificativo e data (niente in caso di carico e scarico)


                    Dim numerofattura As New String(" ", 10)
                    numerofattura = numerofattura.Insert(0, Riferimento_DocumentoTextBox.Text.ToString)
                    If numerofattura.Length > 10 Then
                        numerofattura = numerofattura.Remove(10)
                    End If
                    carico = carico.Insert(48, numerofattura & ";" & DataTextBox.Text.Replace("/", ""))
                    carico = carico.Insert(67, ";")


                    'codice operazione & cuaa cliente/committente ()

                    Dim cuaaOlivicoltore As Integer
                    'modifiche
                    cuaaOlivicoltore = Ditta.CodiceTextBox.Text

                    carico = carico.Insert(68, "G3        ;" & cuaaOlivicoltore.ToString("0000000000") & ";0000000000;")

                    'quantitativo giornaliero olive (campo n. 10)

                    carico = carico.Insert(101, "0000000000000;0000000000000;")



                    'campi n. 12,13,14,15,16
                    carico = carico.Insert(129, "          ;          ;0000000000;00;00;")

                    'campo n. 17
                    carico = carico.Insert(168, "00;")

                    'campo 18 descr origine specifica,19 fine op, 20 fine op,21,22,23,24,25,26,27
                    Dim DescrOrigineOliveSpecifica As New String(" ", 80)

                    Dim sansa As Double = KgTextBox.Text
                    carico = carico.Insert(171, DescrOrigineOliveSpecifica & ";00;" & DescrOrigineOliveSpecifica & ";0000000000000;" & sansa.ToString("0000000000.000").Remove(10, 1) & ";0000000000000;0000000000000;0000000000000;0000000000000;0000000000000;")


                    'campo 28
                    carico = carico.Insert(434, "                    ;")

                    'note
                    Dim note As New String(" ", 300)
                    carico = carico.Insert(455, note)
                    carico = carico.Insert(755, ";")


                    'flag
                    carico = carico.Insert(756, " ; ; ; ; ; ; ; ; ; ; ;")


                    'data invio e tipo record
                    carico = carico.Insert(778, "                 ;                 ;0000;          ;          ;0000000000000;        ;          ;I;")
                    carico = carico.Remove(877)

                    'lettura da impostazioni del numero file registro
                    Dim NRegistroUpload As Integer = Impostazioni.NURegistro.Text

                    Dim nomefileupload As String = Ditta.PIVATextBox.Text & "_" & My.Computer.Clock.LocalTime.Year.ToString("0000") & _
                                                                My.Computer.Clock.LocalTime.Month.ToString("00") & _
                                                                My.Computer.Clock.LocalTime.Day.ToString("00") & "_" & _
                                                                NRegistroUpload.ToString("00000") & "_OPERREGI.txt"

                    'scrittura su file
                    My.Computer.FileSystem.WriteAllText(nomefileupload, carico & vbCrLf, True, System.Text.Encoding.ASCII)

                    MsgBox("Operazione G3 scarico sansa correttamente sul file." & vbCrLf & "Si ricorda che è necessario caricare il file al SIAN entro oggi.", MsgBoxStyle.Information, "Info")
                    Impostazioni.NOperazioneGiornaliera.Text = Impostazioni.NOperazioneGiornaliera.Text + 1


                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)

                End Try
            ElseIf CausaleComboBox.Text = "G7" Then
                Try



                    Dim carico As New String(" ", 877)



                    'cuaa azienda
                    Dim CUAA As New String(" ", 16)
                    CUAA = CUAA.Insert(0, Ditta.PIVATextBox.Text)
                    carico = carico.Insert(0, CUAA)
                    carico = carico.Insert(16, ";")



                    'id stabilimento
                    Dim IDstabilimento As New String(" ", 10)
                    IDstabilimento = IDstabilimento.Insert(0, Impostazioni.StabilimentoTextBox.Text.ToString)
                    carico = carico.Insert(17, IDstabilimento)
                    carico = carico.Insert(27, ";")



                    'numero operazione giornaliera
                    Dim OpGiornaliera As Integer = Numero_OperazioneTextBox.Text
                    OpGiornaliera = (OpGiornaliera)
                    carico = carico.Insert(28, OpGiornaliera.ToString("0000000000"))
                    carico = carico.Insert(38, ";")


                    'data
                    carico = carico.Insert(39, DataTextBox.Text.Replace("/", ""))
                    carico = carico.Insert(47, ";")



                    'numero doc giustificativo e data (niente in caso di carico e scarico)


                    Dim numerofattura As New String(" ", 10)
                    'numerofattura = numerofattura.Insert(0, Riferimento_DocumentoTextBox.Text.ToString)
                    If numerofattura.Length > 10 Then
                        numerofattura = numerofattura.Remove(10)
                    End If
                    carico = carico.Insert(48, numerofattura & ";        ")
                    carico = carico.Insert(67, ";")


                    'codice operazione & cuaa cliente/committente ()

                    Dim cuaaOlivicoltore As Integer
                    'modifiche
                    cuaaOlivicoltore = Ditta.CodiceTextBox.Text

                    carico = carico.Insert(68, "G7        ;" & "0000000000" & ";0000000000;")

                    'quantitativo giornaliero olive (campo n. 10)

                    carico = carico.Insert(101, "0000000000000;0000000000000;")



                    'campi n. 12,13,14,15,16
                    carico = carico.Insert(129, "          ;          ;0000000000;00;00;")

                    'campo n. 17
                    carico = carico.Insert(168, "00;")

                    'campo 18 descr origine specifica,19 fine op, 20 fine op,21,22,23,24,25,26,27
                    Dim DescrOrigineOliveSpecifica As New String(" ", 80)

                    Dim sansa As Double = KgTextBox.Text
                    carico = carico.Insert(171, DescrOrigineOliveSpecifica & ";00;" & DescrOrigineOliveSpecifica & ";" & sansa.ToString("0000000000.000").Remove(10, 1) & ";0000000000000" & ";0000000000000;0000000000000;0000000000000;0000000000000;0000000000000;")


                    'campo 28
                    carico = carico.Insert(434, "                    ;")

                    'note
                    Dim note As New String(" ", 300)
                    carico = carico.Insert(455, note)
                    carico = carico.Insert(755, ";")


                    'flag
                    carico = carico.Insert(756, " ; ; ; ; ; ; ; ; ; ; ;")


                    'data invio e tipo record
                    carico = carico.Insert(778, "                 ;                 ;0000;          ;          ;0000000000000;        ;          ;I;")
                    carico = carico.Remove(877)

                    'lettura da impostazioni del numero file registro
                    Dim NRegistroUpload As Integer = Impostazioni.NURegistro.Text

                    Dim nomefileupload As String = Ditta.PIVATextBox.Text & "_" & My.Computer.Clock.LocalTime.Year.ToString("0000") & _
                                                                My.Computer.Clock.LocalTime.Month.ToString("00") & _
                                                                My.Computer.Clock.LocalTime.Day.ToString("00") & "_" & _
                                                                NRegistroUpload.ToString("00000") & "_OPERREGI.txt"

                    'scrittura su file
                    My.Computer.FileSystem.WriteAllText(nomefileupload, carico & vbCrLf, True, System.Text.Encoding.ASCII)

                    MsgBox("Operazione G7 superi di sansa correttamente sul file." & vbCrLf & "Si ricorda che è necessario caricare il file al SIAN entro oggi.", MsgBoxStyle.Information, "Info")
                    Impostazioni.NOperazioneGiornaliera.Text = Impostazioni.NOperazioneGiornaliera.Text + 1


                Catch ex As System.Exception
                    System.Windows.Forms.MessageBox.Show(ex.Message)

                End Try
            End If


        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            CaricatoCheckBox.CheckState = CheckState.Unchecked
        End Try
    End Sub

   
End Class