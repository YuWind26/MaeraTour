<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Wisatawan
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
        Btn_Tempat_Wisata = New Button()
        Label1 = New Label()
        Btn_Logout = New Button()
        SuspendLayout()
        ' 
        ' Btn_Tempat_Wisata
        ' 
        Btn_Tempat_Wisata.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Btn_Tempat_Wisata.FlatAppearance.BorderSize = 0
        Btn_Tempat_Wisata.FlatStyle = FlatStyle.Flat
        Btn_Tempat_Wisata.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Tempat_Wisata.ForeColor = Color.White
        Btn_Tempat_Wisata.Location = New Point(315, 185)
        Btn_Tempat_Wisata.Name = "Btn_Tempat_Wisata"
        Btn_Tempat_Wisata.Size = New Size(170, 80)
        Btn_Tempat_Wisata.TabIndex = 2
        Btn_Tempat_Wisata.Text = "Tempat Wisata"
        Btn_Tempat_Wisata.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(265, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 67)
        Label1.TabIndex = 6
        Label1.Text = "MaeraTour"
        ' 
        ' Btn_Logout
        ' 
        Btn_Logout.BackColor = Color.FromArgb(CByte(229), CByte(25), CByte(25))
        Btn_Logout.FlatAppearance.BorderSize = 0
        Btn_Logout.FlatStyle = FlatStyle.Flat
        Btn_Logout.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Logout.ForeColor = Color.White
        Btn_Logout.Location = New Point(638, 30)
        Btn_Logout.Name = "Btn_Logout"
        Btn_Logout.Size = New Size(150, 50)
        Btn_Logout.TabIndex = 7
        Btn_Logout.Text = "Logout"
        Btn_Logout.UseVisualStyleBackColor = False
        ' 
        ' Form_Wisatawan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_Logout)
        Controls.Add(Label1)
        Controls.Add(Btn_Tempat_Wisata)
        Name = "Form_Wisatawan"
        Text = "Form_Wisatawan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Btn_Tempat_Wisata As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Logout As Button
End Class
