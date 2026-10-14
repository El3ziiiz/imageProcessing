Imports System.Text
Imports System.Drawing

Public Class Form1

    Public load_img As New OpenFileDialog
    Public x As Integer, y As Integer
    Public i As Integer, j As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("1. Load Image")
        ComboBox1.Items.Add("2. Show RGB Values (TextBox)")
        ComboBox1.Items.Add("3. Grayscale")
        ComboBox1.Items.Add("4. Red Level")
        ComboBox1.Items.Add("5. Green Level")
        ComboBox1.Items.Add("6. Blue Level")
        ComboBox1.Text = "Choose an Action..."
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = -1 Then Exit Sub

        Dim choice As String = ComboBox1.SelectedItem.ToString()

        If choice = "1. Load Image" Then
            If load_img.ShowDialog() = DialogResult.OK Then
                PictureBox1.Load(load_img.FileName)
                x = PictureBox1.Image.Width
                y = PictureBox1.Image.Height
            End If
            Exit Sub
        End If

        If PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please select '1. Load Image' first!")
            Exit Sub
        End If

        If choice = "2. Show RGB Values (TextBox)" Then
            Dim colorPic As New Bitmap(PictureBox1.Image)
            Dim r, g, b As Integer
            Dim pixel As Color
            For i = 0 To x - 1
                For j = 0 To y - 1
                    pixel = colorPic.GetPixel(i, j)
                    r = pixel.R : g = pixel.G : b = pixel.B
                    TextBox1.AppendText("Red=" & r & " Green=" & g & " Blue=" & b & vbCrLf)
                Next
                Stop
            Next
            Exit Sub
        End If

        Dim color_pic As New Bitmap(PictureBox1.Image)
        Dim r_pic As New Bitmap(x, y)
        Dim g_pic As New Bitmap(x, y)
        Dim b_pic As New Bitmap(x, y)
        Dim grey_pic As New Bitmap(x, y)
        Dim pxl As Drawing.Color
        Dim redVal, greenVal, blueVal, p As Integer

        For Me.i = 0 To x - 1
            For Me.j = 0 To y - 1
                pxl = color_pic.GetPixel(i, j)
                redVal = pxl.R : greenVal = pxl.G : blueVal = pxl.B

                Select Case choice
                    Case "3. Grayscale"
                        p = CInt((redVal + greenVal + blueVal) / 3)
                        grey_pic.SetPixel(i, j, Color.FromArgb(p, p, p))

                    Case "4. Red Level"
                        r_pic.SetPixel(i, j, Color.FromArgb(redVal, 0, 0))

                    Case "5. Green Level"
                        g_pic.SetPixel(i, j, Color.FromArgb(0, greenVal, 0))

                    Case "6. Blue Level"
                        b_pic.SetPixel(i, j, Color.FromArgb(0, 0, blueVal))
                End Select
            Next
        Next

        Select Case choice
            Case "3. Grayscale"
                PictureBox2.Image = grey_pic
            Case "4. Red Level"
                PictureBox2.Image = r_pic
            Case "5. Green Level"
                PictureBox2.Image = g_pic
            Case "6. Blue Level"
                PictureBox2.Image = b_pic
        End Select

    End Sub

End Class