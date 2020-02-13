Public Class RegistroCaricoScarico

    Dim pos As Integer = 0
    Dim current As Integer = 1
    Dim last As Integer = 0
    Dim pages As Integer = 0


    Private Sub RegistroCaricoScarico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'FattureDataSet.Fatture'. È possibile spostarla o rimuoverla se necessario.
        DataGridView1.DataSource = FattureTableAdapter.GetDataByRegistro


        '    DataGridView1.Columns.Item(4).Name = "Numero Fattura"
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        current = 1
        pos = 0
        pages = ((DataGridView1.RowCount - 1) / 24)
        last = DataGridView1.RowCount - 1
        If (pages * 24) < (DataGridView1.RowCount - 1) Then
            pages = pages + 1
        End If
        For i As Integer = 1 To pages
            Stampa.Print()
            current = current + 1

        Next
    End Sub

    Private Sub Stampa_QueryPageSettings(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.QueryPageSettingsEventArgs) Handles Stampa.QueryPageSettings
        Stampa.DefaultPageSettings.Landscape = True
        e.PageSettings.Landscape = True

    End Sub

    Private Sub Stampa_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Stampa.PrintPage

        Dim f7 As New System.Drawing.Font(Me.Font.FontFamily, 7.0)

        e.Graphics.DrawString(Ditta.DittaTextBox.Text, f7, Brushes.Black, 18, 10)
        e.Graphics.DrawString(Ditta.RagioneTextBox.Text, f7, Brushes.Black, 18, 25)
        e.Graphics.DrawString(Ditta.IndirizzoTextBox.Text, f7, Brushes.Black, 18, 40)
        e.Graphics.DrawString(Ditta.CapTextBox.Text & " " & Ditta.CittaTextBox.Text & " (" & Ditta.ProvTextBox.Text & ") " & "TEL." & Ditta.TelTextBox.Text, f7, Brushes.Black, 18, 55)
        If Ditta.SitoTextBox.Text = "" Then
            e.Graphics.DrawString("P.IVA " & Ditta.PIVATextBox.Text, f7, Brushes.Black, 18, 70)
        Else
            e.Graphics.DrawString("P.IVA " & Ditta.PIVATextBox.Text & " Sito Web: " & Ditta.SitoTextBox.Text, f7, Brushes.Black, 18, 85)
        End If

        If Ditta.MailTextBox.Text = "" Then

        Else
            e.Graphics.DrawString("E-Mail: " & Ditta.MailTextBox.Text, f7, Brushes.Black, 18, 100)
        End If

        e.Graphics.DrawString("Registro di carico e scarico Pag. " & current, f7, Brushes.Black, 18, 110)

        For i As Integer = 0 To 9
            '      
            If i > 0 Then
                e.Graphics.DrawString(DataGridView1.Columns(i).HeaderText, f7, Brushes.Black, (20 + (i * 120)) - (150 - DataGridView1.Columns(i - 1).Width), 130)
            Else
                e.Graphics.DrawString(DataGridView1.Columns(i).HeaderText, f7, Brushes.Black, (20), 130)
            End If
        Next

        'COLONNE MAX 24 PER PAGINA...
        For i As Integer = 0 To 23
            If pos = last Then
                Return
            End If
            For j As Integer = 0 To 9

                If j > 0 Then
                    e.Graphics.DrawString(DataGridView1.Item(j, pos).Value.ToString, f7, Brushes.Black, (20 + (j * 120)) - (150 - DataGridView1.Columns(j - 1).Width), 145 + (i * 25))

                Else
                    e.Graphics.DrawString(DataGridView1.Item(j, pos).Value.ToString, f7, Brushes.Black, 20, 145 + (i * 25))

                End If

            Next


            pos = pos + 1
        Next
    End Sub

    Private Sub FattureBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FattureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)

    End Sub

    Private Sub FattureBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FattureBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FattureDataSet)

    End Sub
End Class