<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Laporan_Bulanan_Karyawan
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
        DataGridView1 = New DataGridView()
        BtnBack = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(19, 106)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(762, 308)
        DataGridView1.TabIndex = 36
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.Red
        BtnBack.ForeColor = SystemColors.Control
        BtnBack.Location = New Point(19, 37)
        BtnBack.Margin = New Padding(4, 5, 4, 5)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(126, 52)
        BtnBack.TabIndex = 35
        BtnBack.Text = "Kembali"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' Form_Laporan_Bulanan_Karyawan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(BtnBack)
        Name = "Form_Laporan_Bulanan_Karyawan"
        Text = "Form_Laporan_Bulanan_Karyawan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnBack As Button
End Class
