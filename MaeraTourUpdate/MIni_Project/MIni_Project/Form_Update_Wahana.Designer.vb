<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Update_Wahana
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
        Text_Password = New TextBox()
        Text_Email = New TextBox()
        Text_Username = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        BtnUpdateUser = New Button()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' Text_Password
        ' 
        Text_Password.Location = New Point(96, 257)
        Text_Password.Multiline = True
        Text_Password.Name = "Text_Password"
        Text_Password.Size = New Size(612, 52)
        Text_Password.TabIndex = 32
        ' 
        ' Text_Email
        ' 
        Text_Email.Location = New Point(96, 359)
        Text_Email.Multiline = True
        Text_Email.Name = "Text_Email"
        Text_Email.Size = New Size(612, 120)
        Text_Email.TabIndex = 31
        ' 
        ' Text_Username
        ' 
        Text_Username.Location = New Point(96, 168)
        Text_Username.Multiline = True
        Text_Username.Name = "Text_Username"
        Text_Username.Size = New Size(612, 45)
        Text_Username.TabIndex = 30
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(267, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(243, 41)
        Label5.TabIndex = 29
        Label5.Text = "Update Wahana"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(96, 223)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 31)
        Label4.TabIndex = 28
        Label4.Text = "Harga"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(96, 325)
        Label3.Name = "Label3"
        Label3.Size = New Size(107, 31)
        Label3.TabIndex = 27
        Label3.Text = "Deskripsi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(96, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 31)
        Label2.TabIndex = 26
        Label2.Text = "Nama"
        ' 
        ' BtnUpdateUser
        ' 
        BtnUpdateUser.BackColor = Color.Red
        BtnUpdateUser.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUpdateUser.ForeColor = Color.White
        BtnUpdateUser.Location = New Point(653, 69)
        BtnUpdateUser.Name = "BtnUpdateUser"
        BtnUpdateUser.Size = New Size(135, 45)
        BtnUpdateUser.TabIndex = 25
        BtnUpdateUser.Text = "Update"
        BtnUpdateUser.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 69)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 24
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Form_Update_Wahana
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 549)
        Controls.Add(Text_Password)
        Controls.Add(Text_Email)
        Controls.Add(Text_Username)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(BtnUpdateUser)
        Controls.Add(btnBack)
        Name = "Form_Update_Wahana"
        Text = "Form_Update_Wahana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Text_Password As TextBox
    Friend WithEvents Text_Email As TextBox
    Friend WithEvents Text_Username As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpdateUser As Button
    Friend WithEvents btnBack As Button
End Class
