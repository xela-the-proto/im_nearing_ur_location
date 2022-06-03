Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim image As Bitmap
        Dim width,height As Integer
        image = BackgroundImage.FromFile("D:\xela 2.0 gun.png")
        height = image.Height
        width = image.Width
        me.Height = height
        me.Width = width
        PictureBox1.Height = height
        PictureBox1.Width = width
        PictureBox1.BackgroundImage = image
        MsgBox("u have mere seconds",MsgBoxStyle.OkOnly,"run")
        Form1.Hide()
    End Sub

    Private Sub btn_run_Click(sender As Object, e As EventArgs) Handles btn_run.Click
        end
    End Sub
End Class