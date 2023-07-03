<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Karyawan
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
        Label1 = New Label()
        Btn_Logout = New Button()
        Btn_Iklan = New Button()
        Btn_Laporan = New Button()
        Btn_Tiket = New Button()
        Btn_Tempat_Wisata = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(243, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(284, 67)
        Label1.TabIndex = 7
        Label1.Text = "MaeraTour"
        ' 
        ' Btn_Logout
        ' 
        Btn_Logout.BackColor = Color.FromArgb(CByte(229), CByte(25), CByte(25))
        Btn_Logout.FlatAppearance.BorderSize = 0
        Btn_Logout.FlatStyle = FlatStyle.Flat
        Btn_Logout.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Logout.ForeColor = Color.White
        Btn_Logout.Location = New Point(638, 12)
        Btn_Logout.Name = "Btn_Logout"
        Btn_Logout.Size = New Size(150, 50)
        Btn_Logout.TabIndex = 8
        Btn_Logout.Text = "Logout"
        Btn_Logout.UseVisualStyleBackColor = False
        ' 
        ' Btn_Iklan
        ' 
        Btn_Iklan.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Btn_Iklan.FlatAppearance.BorderSize = 0
        Btn_Iklan.FlatStyle = FlatStyle.Flat
        Btn_Iklan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Iklan.ForeColor = Color.White
        Btn_Iklan.Location = New Point(180, 235)
        Btn_Iklan.Name = "Btn_Iklan"
        Btn_Iklan.Size = New Size(170, 80)
        Btn_Iklan.TabIndex = 12
        Btn_Iklan.Text = "Iklan dan Operasional"
        Btn_Iklan.UseVisualStyleBackColor = False
        ' 
        ' Btn_Laporan
        ' 
        Btn_Laporan.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Btn_Laporan.FlatAppearance.BorderSize = 0
        Btn_Laporan.FlatStyle = FlatStyle.Flat
        Btn_Laporan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Laporan.ForeColor = Color.White
        Btn_Laporan.Location = New Point(455, 117)
        Btn_Laporan.Name = "Btn_Laporan"
        Btn_Laporan.Size = New Size(170, 80)
        Btn_Laporan.TabIndex = 11
        Btn_Laporan.Text = "Laporan Bulanan"
        Btn_Laporan.UseVisualStyleBackColor = False
        ' 
        ' Btn_Tiket
        ' 
        Btn_Tiket.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Btn_Tiket.FlatAppearance.BorderSize = 0
        Btn_Tiket.FlatStyle = FlatStyle.Flat
        Btn_Tiket.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Tiket.ForeColor = Color.White
        Btn_Tiket.Location = New Point(455, 235)
        Btn_Tiket.Name = "Btn_Tiket"
        Btn_Tiket.Size = New Size(170, 80)
        Btn_Tiket.TabIndex = 10
        Btn_Tiket.Text = "Tiket"
        Btn_Tiket.UseVisualStyleBackColor = False
        ' 
        ' Btn_Tempat_Wisata
        ' 
        Btn_Tempat_Wisata.BackColor = Color.FromArgb(CByte(68), CByte(71), CByte(101))
        Btn_Tempat_Wisata.FlatAppearance.BorderSize = 0
        Btn_Tempat_Wisata.FlatStyle = FlatStyle.Flat
        Btn_Tempat_Wisata.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Tempat_Wisata.ForeColor = Color.White
        Btn_Tempat_Wisata.Location = New Point(180, 117)
        Btn_Tempat_Wisata.Name = "Btn_Tempat_Wisata"
        Btn_Tempat_Wisata.Size = New Size(170, 80)
        Btn_Tempat_Wisata.TabIndex = 9
        Btn_Tempat_Wisata.Text = "Tempat Wisata"
        Btn_Tempat_Wisata.UseVisualStyleBackColor = False
        ' 
        ' Form_Karyawan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(Btn_Iklan)
        Controls.Add(Btn_Laporan)
        Controls.Add(Btn_Tiket)
        Controls.Add(Btn_Tempat_Wisata)
        Controls.Add(Btn_Logout)
        Controls.Add(Label1)
        Name = "Form_Karyawan"
        Text = "Form_Karyawan"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Logout As Button
    Friend WithEvents Btn_Iklan As Button
    Friend WithEvents Btn_Laporan As Button
    Friend WithEvents Btn_Tiket As Button
    Friend WithEvents Btn_Tempat_Wisata As Button
End Class
