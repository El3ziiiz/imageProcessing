<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        RGB = New Button()
        TextBox1 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(101, 266)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1180, 622)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1317, 404)
        Button1.Name = "Button1"
        Button1.Size = New Size(284, 122)
        Button1.TabIndex = 1
        Button1.Text = "loadImage"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' RGB
        ' 
        RGB.Location = New Point(1317, 587)
        RGB.Name = "RGB"
        RGB.Size = New Size(284, 122)
        RGB.TabIndex = 2
        RGB.Text = "RGB"
        RGB.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(669, 178)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(546, 39)
        TextBox1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(2028, 1084)
        Controls.Add(TextBox1)
        Controls.Add(RGB)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RGB As Button
    Friend WithEvents TextBox1 As TextBox

End Class
