Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Public load_img As New OpenFileDialog
    Public x As Integer, y As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If load_img.ShowDialog() = DialogResult.OK Then
            PictureBox1.Load(load_img.FileName)
        End If
        x = PictureBox1.Width
        y = PictureBox1.Height

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles RGB.Click
        Dim colorPic As New Bitmap(PictureBox1.Image)
        Dim r, g, b As Integer
        Dim pixel As Drawing.Color
        For i = 0 To x - 1
            For j = 0 To y - 1
                pixel = colorPic.GetPixel(i, j)
                r = pixel.R : g = pixel.G : b = pixel.B
                TextBox1.AppendText("Red=" & r & " Green=" & g & " Blue=" & b)

            Next

        Next
    End Sub
End Class
