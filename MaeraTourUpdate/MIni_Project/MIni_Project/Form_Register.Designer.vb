<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Register
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
        GroupBox1 = New GroupBox()
        Btn_Hide_Regis = New Button()
        Text_Username = New TextBox()
        Label6 = New Label()
        Button_Register = New Button()
        Link_Login = New LinkLabel()
        Label4 = New Label()
        Text_Password = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Text_Email = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(242), CByte(238), CByte(238))
        GroupBox1.Controls.Add(Btn_Hide_Regis)
        GroupBox1.Controls.Add(Text_Username)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Button_Register)
        GroupBox1.Controls.Add(Link_Login)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Text_Password)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Text_Email)
        GroupBox1.Location = New Point(155, 51)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(425, 524)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        ' 
        ' Btn_Hide_Regis
        ' 
        Btn_Hide_Regis.Location = New Point(300, 343)
        Btn_Hide_Regis.Name = "Btn_Hide_Regis"
        Btn_Hide_Regis.Size = New Size(62, 43)
        Btn_Hide_Regis.TabIndex = 11
        Btn_Hide_Regis.Text = "Hide"
        Btn_Hide_Regis.UseVisualStyleBackColor = True
        ' 
        ' Text_Username
        ' 
        Text_Username.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Username.Location = New Point(80, 139)
        Text_Username.Name = "Text_Username"
        Text_Username.Size = New Size(282, 43)
        Text_Username.TabIndex = 10
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(80, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 37)
        Label6.TabIndex = 9
        Label6.Text = "Username"
        ' 
        ' Button_Register
        ' 
        Button_Register.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Button_Register.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Button_Register.ForeColor = Color.White
        Button_Register.Location = New Point(-17, 451)
        Button_Register.Name = "Button_Register"
        Button_Register.Size = New Size(452, 87)
        Button_Register.TabIndex = 7
        Button_Register.Text = "Register"
        Button_Register.UseVisualStyleBackColor = False
        ' 
        ' Link_Login
        ' 
        Link_Login.AutoSize = True
        Link_Login.Cursor = Cursors.Hand
        Link_Login.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Link_Login.Location = New Point(282, 405)
        Link_Login.Name = "Link_Login"
        Link_Login.Size = New Size(61, 28)
        Link_Login.TabIndex = 6
        Link_Login.TabStop = True
        Link_Login.Text = "Login"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(97, 405)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 28)
        Label4.TabIndex = 5
        Label4.Text = "Belum Punya Akun ?"
        ' 
        ' Text_Password
        ' 
        Text_Password.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Password.Location = New Point(80, 343)
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(214, 43)
        Text_Password.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(80, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(128, 37)
        Label3.TabIndex = 3
        Label3.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(80, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 37)
        Label2.TabIndex = 2
        Label2.Text = "Email"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(108, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 54)
        Label1.TabIndex = 1
        Label1.Text = "MaeraTour"
        ' 
        ' Text_Email
        ' 
        Text_Email.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Text_Email.Location = New Point(80, 236)
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(282, 43)
        Text_Email.TabIndex = 0
        ' 
        ' Form_Register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 613)
        Controls.Add(GroupBox1)
        Name = "Form_Register"
        Text = "Form_Register"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Text_Username As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button_Register As Button
    Friend WithEvents Link_Login As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Btn_Hide As Button
    Friend WithEvents Btn_Hide_Regis As Button
End Class
