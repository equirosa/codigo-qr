Public Class FormQR
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles BotonGenerar.Click
        Dim generator As GeneradorQR.CreatorQR = New GeneradorQR.CreatorQR
        PictureBox1.Image = generator.GenerarCodigo(TextoCodigo.Text)
    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles TextoCodigo.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BotonCaptura_Click(sender As Object, e As EventArgs) Handles BotonCaptura.Click
        Dim view As WebcamCapturer.Core.WebcamCapturePresenter
        Dim lector As GeneradorQR.CreatorQR = New GeneradorQR.CreatorQR
        TextoCodigo.Text = lector.LeerCodigo()
    End Sub

    Private Sub FormQR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class