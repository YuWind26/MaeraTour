<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Order_Tiket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form_Order_Tiket))
        Button1 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Button5 = New Button()
        Label6 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(24, 46)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 35)
        Button1.TabIndex = 24
        Button1.Text = "Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(243, 31)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 39)
        Label1.TabIndex = 23
        Label1.Text = "Transaksi Tiket"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(36, 174)
        Panel1.Margin = New Padding(4, 5, 4, 5)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(741, 426)
        Panel1.TabIndex = 25
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Red
        Button5.ForeColor = SystemColors.Control
        Button5.Location = New Point(292, 369)
        Button5.Margin = New Padding(4, 5, 4, 5)
        Button5.Name = "Button5"
        Button5.Size = New Size(100, 35)
        Button5.TabIndex = 27
        Button5.Text = "Pesan"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(287, 309)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(123, 25)
        Label6.TabIndex = 22
        Label6.Text = "Total Bayar :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(231, 248)
        TextBox3.Margin = New Padding(4, 5, 4, 5)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(261, 27)
        TextBox3.TabIndex = 21
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.Control
        Label5.Location = New Point(29, 245)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 25)
        Label5.TabIndex = 20
        Label5.Text = "Tanggal Booking"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(231, 178)
        TextBox1.Margin = New Padding(4, 5, 4, 5)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(261, 27)
        TextBox1.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Control
        Label4.Location = New Point(29, 175)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 25)
        Label4.TabIndex = 18
        Label4.Text = "Jumlah Pesan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Control
        Label2.Location = New Point(380, 91)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 17
        Label2.Text = "Harga :"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(21, 45)
        PictureBox2.Margin = New Padding(4, 5, 4, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(133, 77)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(220, 95)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(132, 27)
        TextBox2.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(215, 45)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 25)
        Label3.TabIndex = 14
        Label3.Text = "Tiket Masuk"
        ' 
        ' Form_Order_Tiket
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(812, 674)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form_Order_Tiket"
        Text = "Form6"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button5 As Button
End Class
