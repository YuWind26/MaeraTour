﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kelola_Wahana
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
        btnTambahWahana = New Button()
        Button1 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTambahWahana
        ' 
        btnTambahWahana.BackColor = Color.Red
        btnTambahWahana.ForeColor = SystemColors.Control
        btnTambahWahana.Location = New Point(668, 67)
        btnTambahWahana.Margin = New Padding(4, 5, 4, 5)
        btnTambahWahana.Name = "btnTambahWahana"
        btnTambahWahana.Size = New Size(100, 35)
        btnTambahWahana.TabIndex = 31
        btnTambahWahana.Text = "Tambah"
        btnTambahWahana.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(27, 67)
        Button1.Margin = New Padding(4, 5, 4, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(100, 35)
        Button1.TabIndex = 30
        Button1.Text = "Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Control
        Label1.Location = New Point(333, 63)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 39)
        Label1.TabIndex = 29
        Label1.Text = "Wahana"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(56, 164)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(673, 287)
        DataGridView1.TabIndex = 32
        ' 
        ' Form_Kelola_Wahana
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(0), CByte(64))
        ClientSize = New Size(800, 791)
        Controls.Add(DataGridView1)
        Controls.Add(btnTambahWahana)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form_Kelola_Wahana"
        Text = "Form_Kelola_Wahana"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTambahWahana As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
