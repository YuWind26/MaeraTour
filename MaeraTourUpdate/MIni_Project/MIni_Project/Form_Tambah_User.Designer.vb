<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Tambah_User
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
        BtnAddUser = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Text_Username = New TextBox()
        Text_Email = New TextBox()
        Text_Password = New TextBox()
        Btn_Hide_Regis = New Button()
        cbRole = New ComboBox()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 25)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 1
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnAddUser
        ' 
        BtnAddUser.BackColor = Color.Red
        BtnAddUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddUser.ForeColor = Color.White
        BtnAddUser.Location = New Point(653, 25)
        BtnAddUser.Name = "BtnAddUser"
        BtnAddUser.Size = New Size(135, 45)
        BtnAddUser.TabIndex = 2
        BtnAddUser.Text = "Tambah "
        BtnAddUser.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(103, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 31)
        Label1.TabIndex = 3
        Label1.Text = "Role"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(103, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(117, 31)
        Label2.TabIndex = 4
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(103, 258)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 31)
        Label3.TabIndex = 5
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(103, 365)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 31)
        Label4.TabIndex = 6
        Label4.Text = "Pasword"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(292, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(200, 41)
        Label5.TabIndex = 7
        Label5.Text = "Tambah User"
        ' 
        ' Text_Username
        ' 
        Text_Username.Location = New Point(103, 193)
        Text_Username.Multiline = True
        Text_Username.Name = "Text_Username"
        Text_Username.Size = New Size(612, 45)
        Text_Username.TabIndex = 9
        ' 
        ' Text_Email
        ' 
        Text_Email.Location = New Point(103, 292)
        Text_Email.Multiline = True
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(612, 51)
        Text_Email.TabIndex = 10
        ' 
        ' Text_Password
        ' 
        Text_Password.Location = New Point(103, 399)
        Text_Password.Multiline = True
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(355, 52)
        Text_Password.TabIndex = 11
        ' 
        ' Btn_Hide_Regis
        ' 
        Btn_Hide_Regis.BackColor = Color.White
        Btn_Hide_Regis.Location = New Point(478, 399)
        Btn_Hide_Regis.Name = "Btn_Hide_Regis"
        Btn_Hide_Regis.Size = New Size(89, 52)
        Btn_Hide_Regis.TabIndex = 12
        Btn_Hide_Regis.Text = "Hide"
        Btn_Hide_Regis.UseVisualStyleBackColor = False
        ' 
        ' cbRole
        ' 
        cbRole.FormattingEnabled = True
        cbRole.Location = New Point(167, 98)
        cbRole.Name = "cbRole"
        cbRole.Size = New Size(151, 28)
        cbRole.TabIndex = 13
        ' 
        ' Form_Tambah_User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 478)
        Controls.Add(cbRole)
        Controls.Add(Btn_Hide_Regis)
        Controls.Add(Text_Password)
        Controls.Add(Text_Email)
        Controls.Add(Text_Username)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAddUser)
        Controls.Add(btnBack)
        Name = "Form_Tambah_User"
        Text = "Form_Tambah_Karyawan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Text_Username As TextBox
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Btn_Hide_Regis As Button
    Friend WithEvents cbRole As ComboBox
End Class
