<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Transaksi_Tiket_Wisatawan
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
        btnBack = New Button()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(220, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 67)
        Label1.TabIndex = 7
        Label1.Text = "Transaksi Tiket"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(23, 37)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 25
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(60, 124)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(673, 287)
        DataGridView1.TabIndex = 33
        ' 
        ' Form_Transaksi_Tiket_Wisatawan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Name = "Form_Transaksi_Tiket_Wisatawan"
        Text = "Form_Transaksi_Tiket_Wisatawan"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
