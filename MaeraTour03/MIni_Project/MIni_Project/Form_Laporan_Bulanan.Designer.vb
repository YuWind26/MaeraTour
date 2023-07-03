<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan_Bulanan
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
        BtnBack = New Button()
        SuspendLayout()
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.Red
        BtnBack.ForeColor = SystemColors.Control
        BtnBack.Location = New Point(13, 14)
        BtnBack.Margin = New Padding(4, 5, 4, 5)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(126, 52)
        BtnBack.TabIndex = 31
        BtnBack.Text = "Kembali"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Form_Laporan_Bulanan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 450)
        Controls.Add(BtnBack)
        Name = "Form_Laporan_Bulanan"
        Text = "Form_Laporan_Bulanan"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnBack As Button
End Class
