<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tambah_Iklan
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
        btnBack = New Button()
        BtnAddIklan = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 4
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnAddIklan
        ' 
        BtnAddIklan.BackColor = Color.Red
        BtnAddIklan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddIklan.ForeColor = Color.White
        BtnAddIklan.Location = New Point(653, 12)
        BtnAddIklan.Name = "BtnAddIklan"
        BtnAddIklan.Size = New Size(135, 45)
        BtnAddIklan.TabIndex = 5
        BtnAddIklan.Text = "Tambah"
        BtnAddIklan.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(208, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 46)
        Label1.TabIndex = 6
        Label1.Text = "Tambah Iklan Operasional"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(82, 75)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 32)
        Label2.TabIndex = 7
        Label2.Text = "Nama"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(82, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 32)
        Label3.TabIndex = 8
        Label3.Text = "Qty"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(82, 295)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 32)
        Label4.TabIndex = 9
        Label4.Text = "Tipe"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(82, 412)
        Label5.Name = "Label5"
        Label5.Size = New Size(123, 31)
        Label5.TabIndex = 10
        Label5.Text = "Total Biaya"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(82, 121)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(427, 57)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(82, 227)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(427, 65)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(82, 340)
        TextBox3.Multiline = True
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(427, 59)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(82, 455)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(427, 67)
        TextBox4.TabIndex = 14
        ' 
        ' Form_Tambah_Iklan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 542)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAddIklan)
        Controls.Add(btnBack)
        Name = "Form_Tambah_Iklan"
        Text = "Form_Tambah_Iklan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents BtnAddIklan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
