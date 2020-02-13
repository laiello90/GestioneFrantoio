Imports System.Data.OleDb

Public Class Clienti

    'salvataggio dati
    Private Sub ClientiBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientiBindingNavigatorSaveItem.Click
        Try
            Dim id As Integer = IdTextBox.Text
            If id < 0 = True Then
                id = id * (-1)
                IdTextBox.Text = id
            End If
            Me.Validate()
            Me.ClientiBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ClientiDataSet)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'caricamento form
    Private Sub Clienti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClientiDataSet.Clienti' table. You can move, or remove it, as needed.
        Me.ClientiTableAdapter.Fill(Me.ClientiDataSet.Clienti)
        lettura_scrittura()
    End Sub

    'ricerca per cognome
    Private Sub FillByCognomeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByCognomeToolStripButton.Click
        Try
            Me.ClientiTableAdapter.FillByCognome(Me.ClientiDataSet.Clienti, CognomeToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub CognomeToolStripTextBox_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CognomeToolStripTextBox.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Try
                Me.ClientiTableAdapter.FillByCognome(Me.ClientiDataSet.Clienti, CognomeToolStripTextBox.Text)
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    'controllo cuaa
    Private Function controllo_cuaa()
        If PartitaIvaTextBox.Text.Length = 16 Then
            Return CheckCodiceFiscale(PartitaIvaTextBox.Text)
        Else
            If PartitaIvaTextBox.Text.Length = 11 Then
                Return controllo_piva(PartitaIvaTextBox.Text)

            Else
                MsgBox("Errore. Lunghezza C.Fiscale o P.Iva errata.")
                Return 0
            End If
        End If
    End Function

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        controllo_cuaa()
    End Sub

    'controllo codice fiscale
    Public Function CheckCodiceFiscale(ByVal codicefiscale As String) ' As String
        'CheckCodiceFiscale = "Errata"
        Dim risultato As Integer
        Const caratteri As Integer = 16
        If codicefiscale & "" = "" Then Return 0
        If Not Len(codicefiscale) = caratteri Then Return 0
        Const listaControllo As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim listaPari() As Object = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}
        Dim listaDispari() As Object = {1, 0, 5, 7, 9, 13, 15, 17, 19, 21, 2, 4, 18, 20, 11, 3, 6, 8, 12, 14, 16, 10, 22, 25, 24, 23}
        codicefiscale = UCase(codicefiscale)
        Dim k As Integer
        Dim x As Integer
        Dim cCodice(15) As String
        For k = 0 To 14
            cCodice(k) = Mid(codicefiscale, k + 1, 1)
        Next
        Dim somma As Long
        somma = 0
        Dim i As Integer
        i = 0
        While i < 15
            Dim s As String
            s = cCodice(i)
            x = InStr(1, "0123456789", s)
            If Not (x <= 0) Then
                s = Mid(listaControllo, x, 1)
            End If
            x = InStr(1, listaControllo, s, vbTextCompare)
            If (i Mod 2) = 0 Then
                x = listaDispari(x - 1)
            Else
                x = listaPari(x - 1)
            End If
            somma = somma + x
            i = i + 1
        End While
        x = somma Mod 26 + 1
        If Mid(listaControllo, x, 1) = codicefiscale.Substring(codicefiscale.Length - 1) Then
            MsgBox("Codice Fiscale corretto.", MsgBoxStyle.Information, "Info")
            risultato = 1
            Return risultato
        Else
            MsgBox("Codice Fiscale errato.", MsgBoxStyle.Critical, "Info")
            risultato = 0
            Return risultato
        End If
    End Function

    'controllo partita iva
    Private Function controllo_piva(ByVal piva As String)
        Dim x As Integer = 0
        Dim u As String = ""
        Dim p As Integer
        Dim y As Integer = 0
        Dim z = 0
        Dim t
        Dim t2

        u = piva.Remove(1)
        x = x + u
        u = piva.Remove(0, 2)
        x = x + u.Remove(1)
        u = piva.Remove(0, 4)
        x = x + u.Remove(1)
        u = piva.Remove(0, 6)
        x = x + u.Remove(1)
        u = piva.Remove(0, 8)
        x = x + u.Remove(1)
        u = piva.Remove(0, 10)
        x = x + u




        u = piva.Remove(0, 1)
        p = u.Remove(1)
        If p >= 5 Then
            z = z + 1
        End If
        y = y + (p * 2)

        u = piva.Remove(0, 3)
        p = u.Remove(1)
        If p >= 5 Then
            z = z + 1
        End If
        y = y + (p * 2)

        u = piva.Remove(0, 5)
        p = u.Remove(1)
        If p >= 5 Then
            z = z + 1
        End If
        y = y + (p * 2)

        u = piva.Remove(0, 7)
        p = u.Remove(1)
        If p >= 5 Then
            z = z + 1
        End If
        y = y + (p * 2)

        u = piva.Remove(0, 9)
        p = u.Remove(1)
        If p >= 5 Then
            z = z + 1
        End If
        y = y + (p * 2)


        t = (x + y + z)
        t2 = t Mod 10

        If t2 = 0 Then
            MsgBox("Partita IVA corretta", MsgBoxStyle.Information, "Partita IVA corretta")
            Return 1
        Else
            MsgBox("Partita IVA errata", MsgBoxStyle.Critical, "Partita IVA errata")
            Return 0
        End If
    End Function

    'inserimento nella fattura
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click

        If Fattura.Caricato_CheckBox.CheckState = CheckState.Checked Then
            MsgBox("Non è possibile caricare il cliente, poichè la fattura è in sola lettura", MsgBoxStyle.Critical)
            Return
        End If


        If CaricatoCheckBox.CheckState = CheckState.Checked Then
        Else
            MsgBox("Caricare il cliente al SIAN prima di inserirlo nella fattura.", MsgBoxStyle.Critical, "Errore")
            Return
        End If

        If PrivacyCheckBox.CheckState <> CheckState.Checked Then
            MsgBox("Fare firmare l'informativa della privacy al cliente prima di inserirlo nella fattura.", MsgBoxStyle.Critical, "Errore")
            Return
        End If

        Fattura.CUAA_ClienteTextBox.Text = PartitaIvaTextBox.Text
        Fattura.Denominazione_ClienteTextBox.Text = CognomeTextBox.Text & " " & NomeTextBox.Text
        If NumeroTextBox.Text = "" Then
            Fattura.IndirizzoTextBox.Text = ViaTextBox.Text
        Else
            Fattura.IndirizzoTextBox.Text = ViaTextBox.Text & " N. " & NumeroTextBox.Text
        End If

        Fattura.ProvinciaTextBox.Text = ProvinciaComboBox.Text
        Fattura.CittàTextBox.Text = CittàComboBox.Text
        Fattura.CAPTextBox.Text = CapTextBox.Text
        Fattura.CodiceTextBox.Text = CodiceTextBox.Text
        Fattura.NomeTextBox.Text = NomeTextBox.Text
        Fattura.CognomeTextBox.Text = CognomeTextBox.Text
        Fattura.PECTextBox.Text = PECTextBox.Text
        If CodiceFatturazioneTextBox.Text.Replace(" ", "").Length = 0 Then
            Fattura.CodiceFattTextBox.Text = "0000000"
        Else
            Fattura.CodiceFattTextBox.Text = CodiceFatturazioneTextBox.Text
        End If
        Me.Close()
    End Sub

    'Caricamento anagrafica sul file da spedire al sian
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click



        'funzione di controllo prima di caricare su file.
        If controllo_cliente() = 0 Then
            MsgBox("Record non valido, ricontrollare i dati.", MsgBoxStyle.Critical, "Errore")
            Return
        End If

        If CodiceTextBox.Text = "" Or CodiceTextBox.BackColor = Color.Red Then
            MsgBox("Inserire un codice cliente valido.", MsgBoxStyle.Critical, "Errore")
            Return
        End If


        '
        If controllo_cuaa() = 0 Then
            MsgBox("C.F./P. Iva del cliente non corretta.", MsgBoxStyle.Critical, "Errore")
            Return
        End If

        'verifica che non è gia stato caricato.
        If CaricatoCheckBox.CheckState = CheckState.Checked Then
            MsgBox("Il cliente è gia stato caricato su file", MsgBoxStyle.Critical, "Errore")
        Else
            Dim checked As Integer = 0
            Try
                CaricatoCheckBox.CheckState = CheckState.Checked

                Dim id As Integer = IdTextBox.Text
                If id < 0 = True Then
                    id = id * (-1)
                    IdTextBox.Text = id
                End If

                Me.Validate()
                Me.ClientiBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.ClientiDataSet)

                Try
                    'stringa principale
                    Dim Contatto As New String(" ", 361)

                    'stato ditta
                    Dim CUAA As New String(" ", 16)
                    CUAA = CUAA.Insert(0, Ditta.PIVATextBox.Text)
                    Contatto = Contatto.Insert(0, CUAA)
                    Contatto = Contatto.Insert(16, ";IT;")

                    'cuaa cliente
                    Dim CUAAcliente As New String(" ", 16)
                    CUAAcliente = CUAAcliente.Insert(0, PartitaIvaTextBox.Text)
                    Contatto = Contatto.Insert(20, CUAAcliente)
                    Contatto = Contatto.Insert(36, ";")

                    'cuaa cliente
                    Dim CodCliente As Integer = CodiceTextBox.Text
                    Contatto = Contatto.Insert(37, CodCliente.ToString("0000000000"))
                    Contatto = Contatto.Insert(47, ";")

                    'denominazione cliente
                    Dim DenominazioneCliente As New String(" ", 150)
                    DenominazioneCliente = DenominazioneCliente.Insert(0, CognomeTextBox.Text & " " & NomeTextBox.Text)
                    Contatto = Contatto.Insert(48, DenominazioneCliente)
                    Contatto = Contatto.Insert(198, ";")

                    'indirizzo
                    If NumeroTextBox.Text = "" Then
                        Dim Indirizzo As New String(" ", 150)
                        Indirizzo = Indirizzo.Insert(0, ViaTextBox.Text)
                        Contatto = Contatto.Insert(199, Indirizzo)
                        Contatto = Contatto.Insert(349, ";  ;")
                    Else
                        Dim Indirizzo As New String(" ", 150)
                        Indirizzo = Indirizzo.Insert(0, ViaTextBox.Text & " N. " & NumeroTextBox.Text)
                        Contatto = Contatto.Insert(199, Indirizzo)
                        Contatto = Contatto.Insert(349, ";  ;")
                    End If

                    'descrizione nazione non IT / NON USATO
                    ' Dim descrnazione As New String(" ", 150)
                    'Contatto = Contatto.Insert(345, descrnazione)
                    'Contatto = Contatto.Insert(495, ";")

                    'comune
                    'Dim Comune As New String(" ", 150)
                    'Comune = Comune.Insert(0, CittàComboBox.Text)
                    'Contatto = Contatto.Insert(496, Comune)
                    'Contatto = Contatto.Insert(646, ";  ;")

                    'istat e fine stringa
                    Contatto = Contatto.Insert(353, IstatProvinciaTextBox.Text.ToString & ";" & IstatComuneTextBox.Text.ToString & ";")

                    'eliminazione spazi finali
                    Contatto = Contatto.Remove(361)

                    'lettura da impostazioni del numero file anagrafica
                    Dim NAnagraficaUpload As Integer = Impostazioni.NUAnagrafica.Text

                    'costruzione nome del file di upload
                    Dim nomefileupload As String = Ditta.PIVATextBox.Text & "_" & My.Computer.Clock.LocalTime.Year.ToString("0000") & _
                                                                My.Computer.Clock.LocalTime.Month.ToString("00") & _
                                                                My.Computer.Clock.LocalTime.Day.ToString("00") & "_" & _
                                                                NAnagraficaUpload.ToString("00000") & "_ANAGFCTO.txt"

                    'scrittura file

                    My.Computer.FileSystem.WriteAllText(nomefileupload, Contatto & vbCrLf, True, System.Text.Encoding.ASCII)
                    checked = 1

                    MsgBox("Anagrafica caricata correttamente sul file.", MsgBoxStyle.Information, "Info")
                    Impostazioni.NCClienteTextbox.Text = Impostazioni.NCClienteTextbox.Text + 1
                    lettura_scrittura()
                Catch ex As System.Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
                    If checked = 0 Then
                        CaricatoCheckBox.CheckState = CheckState.Unchecked
                    Else
                        MsgBox("L'anagrafica è stata comunque caricata su file, controllare il file di upload.")
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\log.txt", "Anagrafica " & BindingNavigatorPositionItem.Text & " " & My.Computer.Clock.LocalTime.ToString & " " & ex.Message.ToString & vbCrLf, False)
                    End If
                End Try
            Catch ex As System.Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
                CaricatoCheckBox.CheckState = CheckState.Unchecked
            End Try


        End If
    End Sub

    'controllo cliente prima del caricamento su file
    Private Function controllo_cliente()
        Try
            If PartitaIvaTextBox.Text.Length = 11 Then
            Else
                If PartitaIvaTextBox.Text.Length = 16 Then
                Else
                    MsgBox("La dimensione P.Iva o C.F. non valida.", MsgBoxStyle.Critical, "Errore")
                    Return 0
                End If
            End If

            If NomeTextBox.Text.Length = 0 Then
                MsgBox("Inserire il nome.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If CognomeTextBox.Text.Length = 0 Then
                MsgBox("Inserire il cognome.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If CittàComboBox.Text.Length = 0 Then
                MsgBox("Inserire il comune di residenza.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If ProvinciaComboBox.Text.Length = 0 Then
                MsgBox("Inserire la provincia.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            If CodiceTextBox.Text.Length = 0 Then
                MsgBox("Inserire il codice cliente.", MsgBoxStyle.Critical, "Errore")
                Return 0
            End If

            'If IndirizzoTextBox.Text.Length = 0 Then
            'MsgBox("Inserire l'indirizzo.", MsgBoxStyle.Critical, "Errore")
            'Return 0
            'End If

            '  If CAPTextBox.Text.Length = 0 Then
            'MsgBox("Inserire il C.A.P.", MsgBoxStyle.Critical, "Errore")
            'Return 0
            'End If

            If IstatComuneTextBox.Text.Length = 0 Then
                MsgBox("Inserire il codice istat del comune.", MsgBoxStyle.Critical, "Errore")
                Return 0
            Else
                If IstatComuneTextBox.Text.Length < 3 Then
                    MsgBox("il codice istat deve essere di 3 numeri.", MsgBoxStyle.Critical, "Errore")
                    Return 0
                Else
                    If IstatComuneTextBox.Text.Length > 3 Then
                        MsgBox("il codice istat deve essere di 3 numeri.", MsgBoxStyle.Critical, "Errore")
                        Return 0
                    End If
                End If
            End If

            If IstatProvinciaTextBox.Text.Length = 0 Then
                MsgBox("Inserire il codice istat della provincia.", MsgBoxStyle.Critical, "Errore")
                Return 0
            Else
                If IstatProvinciaTextBox.Text.Length < 3 Then
                    MsgBox("il codice istat deve essere di 3 numeri.", MsgBoxStyle.Critical, "Errore")
                    Return 0
                Else
                    If IstatProvinciaTextBox.Text.Length > 3 Then
                        MsgBox("il codice istat deve essere di 3 numeri.", MsgBoxStyle.Critical, "Errore")
                        Return 0
                    End If
                End If
            End If
            Return 1
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Return 0
        End Try
    End Function


    'sola lettura?
    Private Sub lettura_scrittura()
        If CaricatoCheckBox.CheckState = CheckState.Checked Then
            Label1.Text = "Il cliente è gia stato caricato sul file di upload per il SIAN, non sarà possibile modificarlo."
            CognomeTextBox.ReadOnly = True
            NomeTextBox.ReadOnly = True
            ViaTextBox.ReadOnly = True
            NumeroTextBox.ReadOnly = True
            CapTextBox.ReadOnly = True
            CittàComboBox.Enabled = False
            ProvinciaComboBox.Enabled = False
            PartitaIvaTextBox.ReadOnly = True
            IstatComuneTextBox.ReadOnly = True
            IstatProvinciaTextBox.ReadOnly = True
            Button3.Enabled = False
            CodiceTextBox.ReadOnly = True

        Else
            Label1.Text = ""
            CognomeTextBox.ReadOnly = False
            NomeTextBox.ReadOnly = False
            ViaTextBox.ReadOnly = False
            NumeroTextBox.ReadOnly = False
            CapTextBox.ReadOnly = False
            CittàComboBox.Enabled = True
            ProvinciaComboBox.Enabled = True
            PartitaIvaTextBox.ReadOnly = False
            IstatComuneTextBox.ReadOnly = False
            IstatProvinciaTextBox.ReadOnly = False
            Button3.Enabled = True
            CodiceTextBox.ReadOnly = False

        End If
        If CodiceTextBox.Text = "" Then
        Else
            Try
                If (Me.ClientiTableAdapter.CheckCodice(CodiceTextBox.Text) > 0 And (CaricatoCheckBox.CheckState = CheckState.Indeterminate Or CaricatoCheckBox.CheckState = CheckState.Unchecked)) Then
                    CodiceTextBox.BackColor = Color.Red
                Else
                    CodiceTextBox.BackColor = Color.White
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ClientiBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientiBindingSource.PositionChanged
        lettura_scrittura()
    End Sub

    Private Sub CittàComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CittàComboBox.SelectedIndexChanged

        Dim comune As Integer = CittàComboBox.SelectedItem("IstatComune")
        IstatComuneTextBox.Text = comune.ToString("000")
        Dim provincia As Integer = CittàComboBox.SelectedItem("IstatProvincia")
        IstatProvinciaTextBox.Text = provincia.ToString("000")

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            CodiceTextBox.Text = Impostazioni.NCClienteTextbox.Text
            Dim cn As New Data.OleDb.OleDbConnection
            Dim constr As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = " & Application.StartupPath & _
                    "\comuni.mdb;"
            cn.ConnectionString = constr
            Dim cmd As New OleDbCommand("select C.Città, C.IstatProvincia, C.IstatComune from Comuni C, Province P where P.Provincia = '" & ProvinciaComboBox.Text & "' and P.IstatProvincia = C.IstatProvincia", cn)
            cn.Open()
            Dim dr As OleDbDataReader
            Dim comuni As New Data.DataSet
            comuni.Tables.Add("Comuni")
            comuni.Tables("Comuni").Columns.Add("Città")
            comuni.Tables("Comuni").Columns.Add("IstatProvincia")
            comuni.Tables("Comuni").Columns.Add("IstatComune")
            Dim citta(2) As String
            dr = cmd.ExecuteReader



            While dr.Read()

                'MsgBox(dr(0).ToString)
                citta(0) = dr(0).ToString
                citta(1) = dr(1).ToString
                citta(2) = dr(2).ToString
                comuni.Tables("Comuni").Rows.Add(citta)
            End While

            CittàComboBox.DataSource = comuni.Tables("Comuni")
            CittàComboBox.DisplayMember = "Città"
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    
    Private Sub CodiceTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CodiceTextBox.TextChanged
        If CodiceTextBox.Text = "" Then
        Else

            Try
                If (Me.ClientiTableAdapter.CheckCodice(CodiceTextBox.Text) > 0 And (CaricatoCheckBox.CheckState = CheckState.Indeterminate Or CaricatoCheckBox.CheckState = CheckState.Unchecked)) Then
                    CodiceTextBox.BackColor = Color.Red
                Else
                    CodiceTextBox.BackColor = Color.White
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

 
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim psi As New ProcessStartInfo

        psi.UseShellExecute = True
        psi.Verb = "print"
        '
        psi.WindowStyle = ProcessWindowStyle.Hidden
        'psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString() ' Here specify printer name

        psi.FileName = My.Application.Info.DirectoryPath & "\privacy.rtf" ' Here specify a document to be printed
        Process.Start(psi)
        PrivacyCheckBox.Checked = True
    End Sub


End Class