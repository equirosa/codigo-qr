Public Class FormQR
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles BotonGenerar.Click
        Dim generator As GeneradorQR.CreatorQR = New GeneradorQR.CreatorQR
        PictureBox1.Image = generator.GenerarCodigo(TextoCodigo.Text)
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles TextoCodigo.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class