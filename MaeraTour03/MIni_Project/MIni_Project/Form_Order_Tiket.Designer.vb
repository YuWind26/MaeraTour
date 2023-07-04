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
        Button1 = New Button()
        Label1 = New Label()
        Panel1 = New Panel()
        Button5 = New Button()
        TextBox3 = New TextBox()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label4 = New Label()
        Labelharga = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Panel1.SuspendLayout()
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
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Labelharga)
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
        ' Labelharga
        ' 
        Labelharga.AutoSize = True
        Labelharga.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Labelharga.ForeColor = SystemColors.Control
        Labelharga.Location = New Point(394, 88)
        Labelharga.Margin = New Padding(4, 0, 4, 0)
        Labelharga.Name = "Labelharga"
        Labelharga.Size = New Size(65, 25)
        Labelharga.TabIndex = 17
        Labelharga.Text = "Harga"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(34, 89)
        TextBox2.Margin = New Padding(4, 5, 4, 5)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(306, 27)
        TextBox2.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(29, 33)
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Labelharga As Label
    Friend WithEvents Button5 As Button
End Class
