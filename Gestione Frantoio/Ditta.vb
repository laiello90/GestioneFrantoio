Public Class Ditta

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String = My.Application.Info.DirectoryPath & "\SetupDitta.ini"
        My.Computer.FileSystem.WriteAllText(file, DittaTextBox.Text & ">" & _
        RagioneTextBox.Text & ">" & _
        IndirizzoTextBox.Text & ">" & _
        CittaTextBox.Text & ">" & _
        ProvTextBox.Text & ">" & _
        TelTextBox.Text & ">" & _
        CapTextBox.Text & ">" & _
        PIVATextBox.Text & ">" & _
        ADescrizioneTextBox.Text & ">" & _
        AStatoFisicoTextBox.Text & ">" & _
        ADestinazioneTextBox.Text & ">" & _
        AMezzoTextBox.Text & ">" & _
        SNomeTextBox.Text & ">" & _
        ScomuneTextBox.Text & ">" & _
        SprovinciaTextBox.Text & ">" & _
        SindirizzoTextBox.Text & ">" & _
        SpartitaivaTextBox.Text & ">" & _
        SVNomeTextBox.Text & ">" & _
        SVComuneTextBox.Text & ">" & _
        SVProvinciaTextBox.Text & ">" & _
        SVIndirizzoTextBox.Text & ">" & _
        SVPartitaIvaTextBox.Text & ">" & _
        SMezzoTextBox.Text & ">" & _
        AVNomeTextbox.Text & ">" & _
        AVComuneTextBox.Text & ">" & _
        AVProvinciaTextBox.Text & ">" & _
        AVIndirizzoTextBox.Text & ">" & _
        AVPartitaivaTextBox.Text & ">" & _
        SDNomeTextBox.Text & ">" & _
        SDComuneTextBox.Text & ">" & _
        SDProvinciaTextBox.Text & ">" & _
        SDIndirizzoTextBox.Text & ">" & _
        SDPartitaIvaTextBox.Text & ">" & _
        ADNomeTextBox.Text & ">" & _
        ADComuneTextBox.Text & ">" & _
        ADProvinciaTextBox.Text & ">" & _
        ADIndirizzoTextBox.Text & ">" & _
        ADPartitaIvaTextBox.Text & ">" & _
        SitoTextBox.Text & ">" & _
        MailTextBox.Text & ">" & _
        CodiceTextBox.Text, False)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class