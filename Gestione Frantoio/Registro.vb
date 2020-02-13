Public Class Registro

    Private Sub Registro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FattureDataSet.Fatture' table. You can move, or remove it, as needed.
        Me.FattureTableAdapter.Fill(Me.FattureDataSet.Fatture)
        TextBox3.Text = FattureTableAdapter.TotaleKgOliveMolite
        TextBox5.Text = FattureTableAdapter.TotaleOlioSfuso
        Label9.Text = DataGridView1.RowCount.ToString & " righe trovate."
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim data As String = DateTimePicker1.Value.Day.ToString("00") & "/" & _
                                       DateTimePicker1.Value.Month.ToString("00") & "/" & _
                                       DateTimePicker1.Value.Year.ToString("0000")

        Try
            Me.FattureTableAdapter.FillByDay(Me.FattureDataSet.Fatture, data)




            TextBox1.Text = FattureTableAdapter.TotaleGiornalieroOlive(data)
            TextBox4.Text = (FattureTableAdapter.TotaleGiornalieroOlive(data) / 100) * Impostazioni.Sansa.Text

            TextBox2.Text = FattureTableAdapter.TotaleGiornalieroOlio(data)
            Label9.Text = DataGridView1.RowCount.ToString & " righe trovate."
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Label9.Text = DataGridView1.RowCount.ToString & " righe trovate"
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim data As String = DateTimePicker2.Value.Day.ToString("00") & "/" & _
                                            DateTimePicker2.Value.Month.ToString("00") & "/" & _
                                            DateTimePicker2.Value.Year.ToString("0000")

        Dim data2 As String = DateTimePicker3.Value.Day.ToString("00") & "/" & _
                                          DateTimePicker3.Value.Month.ToString("00") & "/" & _
                                          DateTimePicker3.Value.Year.ToString("0000")
        Try
            Me.FattureTableAdapter.FillByGiorni(Me.FattureDataSet.Fatture, data, data2)

            TextBox1.Text = FattureTableAdapter.TotaleOliveGiorni(data, data2)
            TextBox2.Text = FattureTableAdapter.TotaleOlioGiorni(data, data2)
            TextBox4.Text = (FattureTableAdapter.TotaleOliveGiorni(data, data2) / 100) * Impostazioni.Sansa.Text

            Label9.Text = DataGridView1.RowCount.ToString & " righe trovate."

        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
            Label9.Text = DataGridView1.RowCount.ToString & " righe trovate"
        End Try
    End Sub
End Class