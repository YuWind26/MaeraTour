<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kelola_User
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
        Btn_User = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Red
        btnBack.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBack.ForeColor = Color.White
        btnBack.Location = New Point(12, 18)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(132, 46)
        btnBack.TabIndex = 0
        btnBack.Text = "Kembali"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Btn_User
        ' 
        Btn_User.BackColor = Color.Red
        Btn_User.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Btn_User.ForeColor = Color.White
        Btn_User.Location = New Point(642, 18)
        Btn_User.Name = "Btn_User"
        Btn_User.Size = New Size(135, 45)
        Btn_User.TabIndex = 1
        Btn_User.Text = "Tambah User"
        Btn_User.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(250, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(296, 46)
        Label1.TabIndex = 2
        Label1.Text = "User Management"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(47, 101)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(673, 287)
        DataGridView1.TabIndex = 3
        ' 
        ' Form_Kelola_User
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(32), CByte(40), CByte(70))
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Btn_User)
        Controls.Add(btnBack)
        Name = "Form_Kelola_User"
        Text = "Form_Kelola_User"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Btn_User As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
