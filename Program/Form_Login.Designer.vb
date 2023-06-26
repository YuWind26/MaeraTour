<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        Button_Login = New Button()
        Link_Register = New LinkLabel()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox1 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(242), CByte(238), CByte(238))
        GroupBox1.Controls.Add(Button_Login)
        GroupBox1.Controls.Add(Link_Register)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(152, 53)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(396, 424)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Button_Login
        ' 
        Button_Login.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Button_Login.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Login.ForeColor = Color.White
        Button_Login.Location = New Point(-6, 346)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(411, 88)
        Button_Login.TabIndex = 7
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = False
        ' 
        ' Link_Register
        ' 
        Link_Register.AutoSize = True
        Link_Register.Cursor = Cursors.Hand
        Link_Register.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Link_Register.Location = New Point(253, 301)
        Link_Register.Name = "Link_Register"
        Link_Register.Size = New Size(66, 28)
        Link_Register.TabIndex = 6
        Link_Register.TabStop = True
        Link_Register.Text = "Daftar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(70, 301)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 28)
        Label4.TabIndex = 5
        Label4.Text = "Belum Punya Akun ?"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(70, 239)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 43)
        TextBox2.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(70, 188)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 37)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(70, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 37)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(90, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 54)
        Label1.TabIndex = 1
        Label1.Text = "MaeraTour"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(70, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 43)
        TextBox1.TabIndex = 0
        ' 
        ' Form_Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(697, 507)
        Controls.Add(GroupBox1)
        Name = "Form_Login"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Link_Register As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_Login As Button
End Class
