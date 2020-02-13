Public Class Impostazioni

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String = My.Application.Info.DirectoryPath & "\Impostazioni.ini"
        My.Computer.FileSystem.WriteAllText(file, StabilimentoTextBox.Text & "/" & _
        IvaTextBox.Text & "/" & _
        PrezzoTextBox.Text & "/" & _
        NFatturaTextBox.Text & "/" & _
        NOperazioneGiornaliera.Text & "/" & _
        NUAnagrafica.Text & "/" & _
        NURegistro.Text & "/" & _
        My.Computer.Clock.LocalTime.Day.ToString("00") & "-" & _
        My.Computer.Clock.LocalTime.Month.ToString("00") & "-" & _
        My.Computer.Clock.LocalTime.Year.ToString("0000") & "/" & _
        PercentualeTextBox.Text & "/" & _
        Sansa.Text & "/" & Acque.Text & "/" & _
        PrecedenteFatturaTextBox.Text & "/" & PrecedenteOpTextBox.Text & "/" & BordoTextbox.Text & "/" & _
IvaSansaTextBox.Text & "/" & PrezzoSansaTextBox.Text & "/" & NCClienteTextbox.Text & "/" & GiacenzaInizialeTextBox.Text, False)

        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Checkbox fatture acceso", MsgBoxStyle.Information, "Info")
        Fattura.Caricato_CheckBox.AutoCheck = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Checkbox fatture spento", MsgBoxStyle.Information, "Info")
        Fattura.Caricato_CheckBox.AutoCheck = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Checkbox clienti spento", MsgBoxStyle.Information, "Info")
        Clienti.CaricatoCheckBox.AutoCheck = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Checkbox clienti acceso", MsgBoxStyle.Information, "Info")
        Clienti.CaricatoCheckBox.AutoCheck = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Cancella attivato", MsgBoxStyle.Information, "Info")
        Fattura.FattureBindingNavigator.DeleteItem.Visible = True
        Fattura.ToolStripSeparator2.Visible = True
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Cancella disattivato", MsgBoxStyle.Information, "Info")
        Fattura.FattureBindingNavigator.DeleteItem.Visible = False
        Fattura.ToolStripSeparator2.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Main.BackupDb()
    End Sub

  
End Class