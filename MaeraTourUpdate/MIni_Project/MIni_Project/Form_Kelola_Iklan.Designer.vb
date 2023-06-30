<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kelola_Iklan
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
        Btn_Iklan = New Button()
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Btn_Iklan
        ' 
        Btn_Iklan.BackColor = Color.Red
        Btn_Iklan.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_Iklan.ForeColor = Color.White
        Btn_Iklan.Location = New Point(653, 12)
        Btn_Iklan.Name = "Btn_Iklan"
        Btn_Iklan.Size = New Size(135, 45)
        Btn_Iklan.TabIndex = 2
        Btn_Iklan.Text = "Tambah"
        Btn_Iklan.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 12)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 3
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(38, 82)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(723, 331)
        DataGridView1.TabIndex = 4
        ' 
        ' Form_Kelola_Iklan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(Btn_Iklan)
        Name = "Form_Kelola_Iklan"
        Text = "Form_Kelola_Iklan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Btn_Iklan As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
