Public Class ImpostazioniFattura
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String = My.Application.Info.DirectoryPath & "\SetupFattura.ini"
        My.Computer.FileSystem.WriteAllText(file, IdPaeseTrasmittente.Text & ">" &
            CodiceTrasmittenteTextBox.Text & ">" &
            IdPaeseDittaTextBox.Text & ">" &
            IdCodiceDittaTextbox.Text & ">" &
            CodiceFiscaleDittaTextbox.Text & ">" &
            DenominazioneDittaTextBox.Text & ">" &
            RegimeFiscaleTextBox.Text & ">" &
            IndirizzoTextBox.Text & ">" &
            CAPTextBox.Text & ">" &
            ComuneTextBox.Text & ">" &
            NazioneDittaTextBox.Text & ">" &
            ProvinciaTextBox.Text & ">" &
            UfficioREATextBox.Text & ">" &
            NumeroREATextBox.Text & ">" &
            LiquidazioneTextBox.Text & ">" &
            TelefonoTextBox.Text & ">" &
              SezionaleTextBox.Text & ">" &
        EmailTextBox.Text, False)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub


End Class