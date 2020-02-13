Imports Microsoft.Win32

Public Class Main
    'apertura forms
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Fattura.MdiParent = Me
        Fattura.Show()
        Fattura.WindowState = FormWindowState.Maximized


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Clienti.Show()
    End Sub

    Private Sub ClientiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientiToolStripMenuItem.Click
        Clienti.Show()
    End Sub

    Private Sub SetupDittaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetupDittaToolStripMenuItem.Click
        Ditta.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Sansa.MdiParent = Me
        Sansa.Show()
        Sansa.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Acque.MdiParent = Me
        Acque.Show()
        Acque.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Registro.MdiParent = Me
        Registro.Show()
        Registro.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Impostazioni.Show()
    End Sub

    Private Sub InformazioniToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformazioniToolStripMenuItem.Click
        Informazioni.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Istruzioni.Show()
    End Sub

    'chiusura programma
    Private Sub Main_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        SalvaImpostazioni()
    End Sub

    'chiusura programma da menù
    Private Sub EsciToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EsciToolStripMenuItem.Click
        SalvaImpostazioni()
        End
    End Sub

    'salvataggio impostazioni
    Private Sub SalvaImpostazioni()
        Try
            Dim file As String = My.Application.Info.DirectoryPath & "\Impostazioni.ini"
            My.Computer.FileSystem.WriteAllText(file, Impostazioni.StabilimentoTextBox.Text & "/" & _
            Impostazioni.IvaTextBox.Text & "/" & _
            Impostazioni.PrezzoTextBox.Text & "/" & _
            Impostazioni.NFatturaTextBox.Text & "/" & _
            Impostazioni.NOperazioneGiornaliera.Text & "/" & _
            Impostazioni.NUAnagrafica.Text & "/" & _
            Impostazioni.NURegistro.Text & "/" & _
            My.Computer.Clock.LocalTime.Day.ToString("00") & "-" & _
            My.Computer.Clock.LocalTime.Month.ToString("00") & "-" & _
            My.Computer.Clock.LocalTime.Year.ToString("0000") & "/" & _
            Impostazioni.PercentualeTextBox.Text & "/" & _
            Impostazioni.Sansa.Text & "/" & Impostazioni.Acque.Text & "/" & _
            Impostazioni.PrecedenteFatturaTextBox.Text & "/" & Impostazioni.PrecedenteOpTextBox.Text & "/" & Impostazioni.BordoTextbox.Text & "/" & _
            Impostazioni.IvaSansaTextBox.Text & "/" & Impostazioni.PrezzoSansaTextBox.Text & "/" & Impostazioni.NCClienteTextbox.Text & "/" & Impostazioni.GiacenzaInizialeTextBox.Text, False)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    'caricamento form e caricamento impostazioni
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BackupDb()
        Try

            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\SetupFattura.ini") = True Then
                Dim infofattura As String() = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\SetupFattura.ini").Split(">")
                ImpostazioniFattura.IdPaeseTrasmittente.Text = infofattura(0)
                ImpostazioniFattura.CodiceTrasmittenteTextBox.Text = infofattura(1)
                ImpostazioniFattura.IdPaeseDittaTextBox.Text = infofattura(2)
                ImpostazioniFattura.IdCodiceDittaTextbox.Text = infofattura(3)
                ImpostazioniFattura.CodiceFiscaleDittaTextbox.Text = infofattura(4)
                ImpostazioniFattura.DenominazioneDittaTextBox.Text = infofattura(5)
                ImpostazioniFattura.RegimeFiscaleTextBox.Text = infofattura(6)
                ImpostazioniFattura.IndirizzoTextBox.Text = infofattura(7)
                ImpostazioniFattura.CAPTextBox.Text = infofattura(8)
                ImpostazioniFattura.ComuneTextBox.Text = infofattura(9)
                ImpostazioniFattura.NazioneDittaTextBox.Text = infofattura(10)
                ImpostazioniFattura.ProvinciaTextBox.Text = infofattura(11)
                ImpostazioniFattura.UfficioREATextBox.Text = infofattura(12)
                ImpostazioniFattura.NumeroREATextBox.Text = infofattura(13)
                ImpostazioniFattura.LiquidazioneTextBox.Text = infofattura(14)
                ImpostazioniFattura.TelefonoTextBox.Text = infofattura(15)
                ImpostazioniFattura.SezionaleTextBox.Text = infofattura(16)
                ImpostazioniFattura.EmailTextBox.Text = infofattura(17)

            End If



            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\Impostazioni.ini") = True Then
                Dim info As String() = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\Impostazioni.ini").Split("/")

                Impostazioni.StabilimentoTextBox.Text = info(0)
                Impostazioni.IvaTextBox.Text = info(1)
                Impostazioni.PrezzoTextBox.Text = info(2)
                Impostazioni.NFatturaTextBox.Text = info(3)
                Impostazioni.NOperazioneGiornaliera.Text = info(4)
                Impostazioni.NUAnagrafica.Text = info(5)
                Impostazioni.NURegistro.Text = info(6)
                Impostazioni.PercentualeTextBox.Text = info(8)
                Impostazioni.Sansa.Text = info(9)
                Impostazioni.Acque.Text = info(10)
                Impostazioni.PrecedenteFatturaTextBox.Text = info(11)
                Impostazioni.PrecedenteOpTextBox.Text = info(12)
                Impostazioni.BordoTextbox.Text = info(13)
                Impostazioni.IvaSansaTextBox.Text = info(14)
                Impostazioni.PrezzoSansaTextBox.Text = info(15)
                Impostazioni.NCClienteTextbox.Text = info(16)
                Impostazioni.GiacenzaInizialeTextBox.Text = info(17)
                If info(7) = My.Computer.Clock.LocalTime.Day.ToString("00") & "-" &
                            My.Computer.Clock.LocalTime.Month.ToString("00") & "-" &
                                My.Computer.Clock.LocalTime.Year.ToString("0000") Then
                Else
                    Impostazioni.NOperazioneGiornaliera.Text = 1
                    Impostazioni.PrecedenteOpTextBox.Text = 0
                    'Impostazioni.NUAnagrafica.Text = Impostazioni.NUAnagrafica.Text + 1
                    'Impostazioni.NURegistro.Text = Impostazioni.NURegistro.Text + 1
                    SalvaImpostazioni()
                End If
            End If

            'caricamento impostazioni ditta per fatture e scarico acque
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\SetupDitta.ini") = True Then
                Dim infoditta As String() = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath & "\SetupDitta.ini").Split(">")
                Ditta.DittaTextBox.Text = infoditta(0)
                Ditta.RagioneTextBox.Text = infoditta(1)
                Ditta.IndirizzoTextBox.Text = infoditta(2)
                Ditta.CittaTextBox.Text = infoditta(3)
                Ditta.ProvTextBox.Text = infoditta(4)
                Ditta.TelTextBox.Text = infoditta(5)
                Ditta.CapTextBox.Text = infoditta(6)
                Ditta.PIVATextBox.Text = infoditta(7)
                Ditta.ADescrizioneTextBox.Text = infoditta(8)
                Ditta.AStatoFisicoTextBox.Text = infoditta(9)
                Ditta.ADestinazioneTextBox.Text = infoditta(10)
                Ditta.AMezzoTextBox.Text = infoditta(11)
                Ditta.SNomeTextBox.Text = infoditta(12)
                Ditta.ScomuneTextBox.Text = infoditta(13)
                Ditta.SprovinciaTextBox.Text = infoditta(14)
                Ditta.SindirizzoTextBox.Text = infoditta(15)
                Ditta.SpartitaivaTextBox.Text = infoditta(16)
                Ditta.SVNomeTextBox.Text = infoditta(17)
                Ditta.SVComuneTextBox.Text = infoditta(18)
                Ditta.SVProvinciaTextBox.Text = infoditta(19)
                Ditta.SVIndirizzoTextBox.Text = infoditta(20)
                Ditta.SVPartitaIvaTextBox.Text = infoditta(21)
                Ditta.SMezzoTextBox.Text = infoditta(22)
                Ditta.AVNomeTextbox.Text = infoditta(23)
                Ditta.AVComuneTextBox.Text = infoditta(24)
                Ditta.AVProvinciaTextBox.Text = infoditta(25)
                Ditta.AVIndirizzoTextBox.Text = infoditta(26)
                Ditta.AVPartitaivaTextBox.Text = infoditta(27)
                Ditta.SDNomeTextBox.Text = infoditta(28)
                Ditta.SDComuneTextBox.Text = infoditta(29)
                Ditta.SDProvinciaTextBox.Text = infoditta(30)
                Ditta.SDIndirizzoTextBox.Text = infoditta(31)
                Ditta.SDPartitaIvaTextBox.Text = infoditta(32)
                Ditta.ADNomeTextBox.Text = infoditta(33)
                Ditta.ADComuneTextBox.Text = infoditta(34)
                Ditta.ADProvinciaTextBox.Text = infoditta(35)
                Ditta.ADIndirizzoTextBox.Text = infoditta(36)
                Ditta.ADPartitaIvaTextBox.Text = infoditta(37)
                Ditta.SitoTextBox.Text = infoditta(38)
                Ditta.MailTextBox.Text = infoditta(39)
                Ditta.CodiceTextBox.Text = infoditta(40)
            End If
        Catch er As Exception
            MsgBox(er.Message.ToString, MsgBoxStyle.Critical, "Errore")
        End Try

    End Sub

    'backup database
    Public Sub BackupDb()
        If My.Computer.FileSystem.DirectoryExists(My.Application.Info.DirectoryPath & "\Backup") = False Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\Backup")
        End If

        My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\Clienti.mdb", My.Application.Info.DirectoryPath & "\Backup\Clienti.mdb", True)
        My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\Fatture.mdb", My.Application.Info.DirectoryPath & "\Backup\Fatture.mdb", True)
    End Sub

    'stampa


    'preparazione documenti da stampare
    Private Sub StampaFattura_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles StampaFattura.PrintPage
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
        Dim f6 As New System.Drawing.Font(Me.Font.FontFamily, 10.5)
        Dim f7 As New System.Drawing.Font(Fattura.Denominazione_ClienteTextBox.Font.FontFamily, 12.5)
        Dim provincia As String

        Select Case Fattura.ProvinciaTextBox.Text
            Case "AGRIGENTO-AG", "AGRIGENTO"
                provincia = "(AG)"
            Case "CALTANISSETTA-CL", "CALTANISSETTA"
                provincia = "(CL)"
            Case "CATANIA-CT", "CATANIA"
                provincia = "(CT)"
            Case "ENNA-EN", "ENNA"
                provincia = "(EN)"
            Case "MESSINA-ME", "MESSINA"
                provincia = "(ME)"
            Case "PALERMO-PA", "PALERMO"
                provincia = "(PA)"
            Case "RAGUSA-RG", "RAGUSA"
                provincia = "(RG)"
            Case "SIRACUSA-SR", "SIRACUSA"
                provincia = "(SR)"
            Case "TRAPANI-TP", "TRAPANI"
                provincia = "(TP)"

            Case Else
                provincia = "(" & Fattura.ProvinciaTextBox.Text & ")"


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
        e.Graphics.DrawString("Cliente", f4, Brushes.Black, 15, 225)
        e.Graphics.DrawString(Fattura.Denominazione_ClienteTextBox.Text, f5, Brushes.Black, 40, 255)
        e.Graphics.DrawString(Fattura.IndirizzoTextBox.Text, f5, Brushes.Black, 40, 280)
        e.Graphics.DrawString("C.A.P. " & Fattura.CAPTextBox.Text & " Comune: " & Fattura.CittàTextBox.Text & " " & provincia, f5, Brushes.Black, 40, 305)
        If Fattura.CUAA_ClienteTextBox.Text.Length > 11 Then
            e.Graphics.DrawString("Codice Fiscale: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        Else
            e.Graphics.DrawString("Partita IVA: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        End If
        Dim codfatt As String = Fattura.CodiceFattTextBox.Text.Replace(" ", "")

        e.Graphics.DrawString("Codice Destinatario: " & codfatt, f5, Brushes.Black, 40, 355)

        If Fattura.PECTextBox.Text.Replace(" ", "").Length > 1 Then
            e.Graphics.DrawString("Casella PEC: " & Fattura.PECTextBox.Text, f5, Brushes.Black, 40, 380)
        End If

        'fattura
        e.Graphics.DrawLine(Pens.Black, 15, 430, 785, 430)
        e.Graphics.DrawString("Fattura", f4, Brushes.Black, 375, 435)

        e.Graphics.DrawString("Numero:", f6, Brushes.Black, 70, 480)
        Dim nfattura As String = Fattura.Numero_FatturaTextBox.Text
        e.Graphics.DrawString(ImpostazioniFattura.SezionaleTextBox.Text & "/" & nfattura, f7, Brushes.Black, 135, 480)

        Dim data As String = Fattura.Data_OperazioneTextBox.Text

        e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 480)
        e.Graphics.DrawString(data, f7, Brushes.Black, 310, 480)

        e.Graphics.DrawString("Molitura di olive", f6, Brushes.Black, 25, 570)
        e.Graphics.DrawString("al Kg. conto terzi:", f6, Brushes.Black, 26, 585)
        e.Graphics.DrawString(Fattura.Kg_di_oliveTextBox.Text & " Kg.", f7, Brushes.Black, 145, 578) '

        e.Graphics.DrawString("Prezzo al Kg. Euro.", f6, Brushes.Black, 240, 575)
        e.Graphics.DrawString(Fattura.Prezzo_al_KGTextBox.Text, f7, Brushes.Black, 370, 575)

        e.Graphics.DrawString("Totale Molitura Euro.", f6, Brushes.Black, 650, 535, l)
        e.Graphics.DrawString(Fattura.TotaleTextBox.Text, f7, Brushes.Black, 720, 535, l)

        e.Graphics.DrawString("------------------------", f6, Brushes.Black, 630, 555)

        e.Graphics.DrawString("Imponibile Euro.", f6, Brushes.Black, 650, 575, l)
        e.Graphics.DrawString(Fattura.TotaleTextBox.Text, f7, Brushes.Black, 720, 575, l)

        e.Graphics.DrawString("Iva %", f6, Brushes.Black, 550, 595, l)
        e.Graphics.DrawString(Fattura.IvaTextBox.Text, f7, Brushes.Black, 568, 595, l)

        e.Graphics.DrawString("Totale Euro.", f6, Brushes.Black, 650, 595, l)
        e.Graphics.DrawString(Fattura.TotaleIvaTextBox.Text, f7, Brushes.Black, 720, 595, l)

        e.Graphics.DrawString("==============", f6, Brushes.Black, 630, 610)

        e.Graphics.DrawString("Totale Euro.", f6, Brushes.Black, 650, 635, l)
        e.Graphics.DrawString(Fattura.TotaleTotTextBox.Text, f7, Brushes.Black, 720, 635, l)

        e.Graphics.DrawString("Il D.lgs. n. 196 del 30 giugno 2003 (Codice in materia di protezione dei dati personali) prevede la tutela delle" & vbCrLf & _
                              "persone e di altri soggetti rispetto al trattamento dei dati personali. Conformemente alla normativa sopra citata," & vbCrLf & _
                              "il trattamento dei dati personali dei clienti di questa ditta, sarà improntato ai principi di correttezza,liceità " & vbCrLf & _
                              "e trasparenza e di tutela della riservatezza e dei diritti di ogni cliente.", f6, Brushes.Black, 25, 720)
        e.Graphics.DrawString("Copia analogica della fattura elettronica inviata al SdI, è possibile trovare la fattura elettronica presso la vostra" & vbCrLf &
                              "area riservata all'interno del sito web dell'Agenzia delle Entrate.", f6, Brushes.Black, 25, 795)

    End Sub

    Private Sub StampaAutofattura_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles StampaAutofattura.PrintPage

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
        Dim f6 As New System.Drawing.Font(Me.Font.FontFamily, 10.5)
        Dim f7 As New System.Drawing.Font(Fattura.Denominazione_ClienteTextBox.Font.FontFamily, 12.5)
        Dim provincia As String

        Select Case Fattura.ProvinciaTextBox.Text
            Case "AGRIGENTO-AG", "AGRIGENTO"
                provincia = "(AG)"
            Case "CALTANISSETTA-CL", "CALTANISSETTA"
                provincia = "(CL)"
            Case "CATANIA-CT", "CATANIA"
                provincia = "(CT)"
            Case "ENNA-EN", "ENNA"
                provincia = "(EN)"
            Case "MESSINA-ME", "MESSINA"
                provincia = "(ME)"
            Case "PALERMO-PA", "PALERMO"
                provincia = "(PA)"
            Case "RAGUSA-RG", "RAGUSA"
                provincia = "(RG)"
            Case "SIRACUSA-SR", "SIRACUSA"
                provincia = "(SR)"
            Case "TRAPANI-TP", "TRAPANI"
                provincia = "(TP)"

            Case Else
                provincia = "(" & Fattura.ProvinciaTextBox.Text & ")"


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
        e.Graphics.DrawString("Cliente", f4, Brushes.Black, 15, 225)
        e.Graphics.DrawString(Fattura.Denominazione_ClienteTextBox.Text, f5, Brushes.Black, 40, 255)
        e.Graphics.DrawString(Fattura.IndirizzoTextBox.Text, f5, Brushes.Black, 40, 280)
        e.Graphics.DrawString("C.A.P. " & Fattura.CAPTextBox.Text & " Comune: " & Fattura.CittàTextBox.Text & " " & provincia, f5, Brushes.Black, 40, 305)
        If Fattura.CUAA_ClienteTextBox.Text.Length > 11 Then
            e.Graphics.DrawString("Codice Fiscale: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        Else
            e.Graphics.DrawString("Partita IVA: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        End If
        Dim codfatt As String = Fattura.CodiceFattTextBox.Text.Replace(" ", "")

        e.Graphics.DrawString("Codice Destinatario: " & codfatt, f5, Brushes.Black, 40, 355)

        If Fattura.PECTextBox.Text.Replace(" ", "").Length > 1 Then
            e.Graphics.DrawString("Casella PEC: " & Fattura.PECTextBox.Text, f5, Brushes.Black, 40, 380)
        End If

        'fattura
        e.Graphics.DrawLine(Pens.Black, 15, 430, 785, 430)
        e.Graphics.DrawString("AutoFattura & Ricevuta di acquisto", f4, Brushes.Black, 250, 435) '375

        e.Graphics.DrawString("Numero:", f6, Brushes.Black, 70, 480)
        Dim nfattura As Integer = Fattura.Numero_FatturaTextBox.Text
        e.Graphics.DrawString(nfattura.ToString("000000"), f7, Brushes.Black, 135, 480)

        Dim data As String = Fattura.Data_OperazioneTextBox.Text

        e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 480)
        e.Graphics.DrawString(data, f7, Brushes.Black, 310, 480)

        e.Graphics.DrawString("Sansa Prodotta Kg.", f6, Brushes.Black, 25, 575)
        e.Graphics.DrawString(Fattura.KgSansaTextBox.Text, f7, Brushes.Black, 155, 575) '150

        e.Graphics.DrawString("Prezzo al Kg. Euro.", f6, Brushes.Black, 240, 575)
        e.Graphics.DrawString(Fattura.Prezzo_al_KG_SansaTextBox.Text, f7, Brushes.Black, 370, 575)

        e.Graphics.DrawString("Totale Sansa Euro.", f6, Brushes.Black, 650, 535, l)
        e.Graphics.DrawString(Fattura.TotSansaTextBox.Text, f7, Brushes.Black, 720, 535, l)

        e.Graphics.DrawString("------------------------", f6, Brushes.Black, 630, 555)

        e.Graphics.DrawString("Imponibile Euro.", f6, Brushes.Black, 650, 575, l)
        e.Graphics.DrawString(Fattura.TotSansaTextBox.Text, f7, Brushes.Black, 720, 575, l)

        e.Graphics.DrawString("Iva %", f6, Brushes.Black, 550, 595, l)
        e.Graphics.DrawString(Fattura.Iva_SansaTextBox.Text, f7, Brushes.Black, 568, 595, l)

        e.Graphics.DrawString("Totale Euro.", f6, Brushes.Black, 650, 595, l)
        e.Graphics.DrawString(Fattura.TotIvaSansaTextBox.Text, f7, Brushes.Black, 720, 595, l)

        e.Graphics.DrawString("==============", f6, Brushes.Black, 630, 610)

        e.Graphics.DrawString("Totale Euro.", f6, Brushes.Black, 650, 635, l)
        e.Graphics.DrawString(Fattura.TotaleSansaTextBox.Text, f7, Brushes.Black, 720, 635, l)



        'e.Graphics.DrawString("Firma del cliente________________________", f7, Brushes.Black, 785, 750, l)
        e.Graphics.DrawString("Autofattura emessa dal concessionario per acquisti di prodotti agricoli in quanto la ditta venditrice dichiara di essere" & vbCrLf & "esente dalla fatturazione ai sensi DE. ART.34 3° COMMA-LEGGE 26/10/72- N° 633 e successive modifiche.", f6, Brushes.Black, 25, 720)
        e.Graphics.DrawString("Il sottoscritto dichiara di non essere imprenditore e di non possedere Partita Iva.", f6, Brushes.Black, 25, 780)


        e.Graphics.DrawString("Firma del cliente________________________", f7, Brushes.Black, 785, 830, l)
    End Sub

    Private Sub StampaDDT_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles StampaDDT.PrintPage
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
        Dim f6 As New System.Drawing.Font(Me.Font.FontFamily, 10.5)
        Dim f7 As New System.Drawing.Font(Fattura.Denominazione_ClienteTextBox.Font.FontFamily, 12.5)
        Dim provincia As String

        Select Case Fattura.ProvinciaTextBox.Text
            Case "AGRIGENTO-AG", "AGRIGENTO"
                provincia = "(AG)"
            Case "CALTANISSETTA-CL", "CALTANISSETTA"
                provincia = "(CL)"
            Case "CATANIA-CT", "CATANIA"
                provincia = "(CT)"
            Case "ENNA-EN", "ENNA"
                provincia = "(EN)"
            Case "MESSINA-ME", "MESSINA"
                provincia = "(ME)"
            Case "PALERMO-PA", "PALERMO"
                provincia = "(PA)"
            Case "RAGUSA-RG", "RAGUSA"
                provincia = "(RG)"
            Case "SIRACUSA-SR", "SIRACUSA"
                provincia = "(SR)"
            Case "TRAPANI-TP", "TRAPANI"
                provincia = "(TP)"

            Case Else
                provincia = "(" & Fattura.ProvinciaTextBox.Text & ")"


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
        e.Graphics.DrawString("Cliente", f4, Brushes.Black, 15, 225)
        e.Graphics.DrawString(Fattura.Denominazione_ClienteTextBox.Text, f5, Brushes.Black, 40, 255)
        e.Graphics.DrawString(Fattura.IndirizzoTextBox.Text, f5, Brushes.Black, 40, 280)
        e.Graphics.DrawString("C.A.P. " & Fattura.CAPTextBox.Text & " Comune: " & Fattura.CittàTextBox.Text & " " & provincia, f5, Brushes.Black, 40, 305)
        If Fattura.CUAA_ClienteTextBox.Text.Length > 11 Then
            e.Graphics.DrawString("Codice Fiscale: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        Else
            e.Graphics.DrawString("Partita IVA: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        End If
        Dim codfatt As String = Fattura.CodiceFattTextBox.Text.Replace(" ", "")

        e.Graphics.DrawString("Codice Destinatario: " & codfatt, f5, Brushes.Black, 40, 355)

        If Fattura.PECTextBox.Text.Replace(" ", "").Length > 1 Then
            e.Graphics.DrawString("Casella PEC: " & Fattura.PECTextBox.Text, f5, Brushes.Black, 40, 380)
        End If

        'fattura
        e.Graphics.DrawLine(Pens.Black, 15, 430, 785, 430)
        e.Graphics.DrawString("Documento di trasporto", f4, Brushes.Black, 270, 435) '375

        e.Graphics.DrawString("Numero:", f6, Brushes.Black, 70, 480)
        Dim nfattura As Integer = Fattura.Numero_FatturaTextBox.Text
        e.Graphics.DrawString(nfattura.ToString("000000"), f7, Brushes.Black, 135, 480)

        Dim data As String = Fattura.Data_OperazioneTextBox.Text

        e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 480)
        e.Graphics.DrawString(data, f7, Brushes.Black, 310, 480)

        e.Graphics.DrawString("Olio extra vergine di oliva" & vbCrLf & "Prodotto in Italia" & vbCrLf & "Kg.", f6, Brushes.Black, 80, 575)
        e.Graphics.DrawString(Fattura.Olio_SfusoTextBox.Text, f7, Brushes.Black, 110, 607)

        e.Graphics.DrawString("Resa: " & Fattura.Percentuale_MolituraTextBox.Text & "%", f6, Brushes.Black, 350, 630)

        e.Graphics.DrawString("Aspetto esteriore beni: a vista", f6, Brushes.Black, 350, 575)

        e.Graphics.DrawString("Trasporto a cura del destinatario", f6, Brushes.Black, 450, 480)
    End Sub

    Private Sub StampaBollaCarico_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles StampaBollaCarico.PrintPage
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
        Dim f6 As New System.Drawing.Font(Me.Font.FontFamily, 10.5)
        Dim f7 As New System.Drawing.Font(Fattura.Denominazione_ClienteTextBox.Font.FontFamily, 12.5)
        Dim provincia As String

        Select Case Fattura.ProvinciaTextBox.Text
            Case "AGRIGENTO-AG", "AGRIGENTO"
                provincia = "(AG)"
            Case "CALTANISSETTA-CL", "CALTANISSETTA"
                provincia = "(CL)"
            Case "CATANIA-CT", "CATANIA"
                provincia = "(CT)"
            Case "ENNA-EN", "ENNA"
                provincia = "(EN)"
            Case "MESSINA-ME", "MESSINA"
                provincia = "(ME)"
            Case "PALERMO-PA", "PALERMO"
                provincia = "(PA)"
            Case "RAGUSA-RG", "RAGUSA"
                provincia = "(RG)"
            Case "SIRACUSA-SR", "SIRACUSA"
                provincia = "(SR)"
            Case "TRAPANI-TP", "TRAPANI"
                provincia = "(TP)"

            Case Else
                provincia = "(" & Fattura.ProvinciaTextBox.Text & ")"


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
        e.Graphics.DrawString("Cliente", f4, Brushes.Black, 15, 225)
        e.Graphics.DrawString(Fattura.Denominazione_ClienteTextBox.Text, f5, Brushes.Black, 40, 255)
        e.Graphics.DrawString(Fattura.IndirizzoTextBox.Text, f5, Brushes.Black, 40, 280)
        e.Graphics.DrawString("C.A.P. " & Fattura.CAPTextBox.Text & " Comune: " & Fattura.CittàTextBox.Text & " " & provincia, f5, Brushes.Black, 40, 305)
        If Fattura.CUAA_ClienteTextBox.Text.Length > 11 Then
            e.Graphics.DrawString("Codice Fiscale: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        Else
            e.Graphics.DrawString("Partita IVA: " & Fattura.CUAA_ClienteTextBox.Text, f5, Brushes.Black, 40, 330)
        End If
        Dim codfatt As String = Fattura.CodiceFattTextBox.Text.Replace(" ", "")

        e.Graphics.DrawString("Codice Destinatario: " & codfatt, f5, Brushes.Black, 40, 355)

        If Fattura.PECTextBox.Text.Replace(" ", "").Length > 1 Then
            e.Graphics.DrawString("Casella PEC: " & Fattura.PECTextBox.Text, f5, Brushes.Black, 40, 380)
        End If

        'fattura
        e.Graphics.DrawLine(Pens.Black, 15, 430, 785, 430)
        e.Graphics.DrawString("Bolla di entrata olive", f4, Brushes.Black, 270, 435) '375

        e.Graphics.DrawString("Numero:", f6, Brushes.Black, 70, 480)
        Dim nfattura As Integer = Fattura.Numero_FatturaTextBox.Text
        e.Graphics.DrawString(nfattura.ToString("000000"), f7, Brushes.Black, 135, 480)

        Dim data As String = Fattura.Data_OperazioneTextBox.Text

        e.Graphics.DrawString("Data:", f6, Brushes.Black, 270, 480)
        e.Graphics.DrawString(data, f7, Brushes.Black, 310, 480)

        e.Graphics.DrawString("Olive raccolte in Italia Kg.", f6, Brushes.Black, 80, 575)
        e.Graphics.DrawString(Fattura.Kg_di_oliveTextBox.Text, f7, Brushes.Black, 250, 575)
    End Sub



    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
        Else
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Panel2.Visible = False
        StampaBollaCarico.Print()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Panel2.Visible = False
        StampaFattura.Print()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Panel2.Visible = False
        StampaAutofattura.Print()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Panel2.Visible = False
        StampaDDT.Print()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Panel2.Visible = False



        StampaAutofattura.Print()
        StampaFattura.Print()
        StampaDDT.Print()
        StampaBollaCarico.Print()
        StampaFattura.Print()
        StampaDDT.Print()
    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        RegistroCaricoScarico.Show()
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Dim psi As New ProcessStartInfo

        psi.UseShellExecute = True
        psi.Verb = "print"
        '
        psi.WindowStyle = ProcessWindowStyle.Hidden
        'psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString() ' Here specify printer name

        psi.FileName = My.Application.Info.DirectoryPath & "\privacy.rtf" ' Here specify a document to be printed
        Process.Start(psi)
    End Sub

    Private Sub SetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetupToolStripMenuItem.Click
        ImpostazioniFattura.Show()
    End Sub
End Class
