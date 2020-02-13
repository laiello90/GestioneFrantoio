Public Class Istruzioni

    Private Sub Istruzioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(My.Application.Info.DirectoryPath & "\istruzioni\istruzioni.rtf")
    End Sub
End Class