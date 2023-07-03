Imports System.Data.SqlClient

Public Class Form_Tambah_Gaji

    Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
    Dim conn As New SqlConnection(connectionString)
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet

    Private Sub Form_Tambah_Gaji_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim nama As String = TextBox1.Text.Trim()
        Dim email As String = TextBox2.Text.Trim()
        Dim role As String = TextBox3.Text.Trim()
        Dim gaji As Integer

        If Not Integer.TryParse(TextBox4.Text.Trim(), gaji) Then
            MsgBox("Gaji harus berupa angka!")
            Return
        End If

        Dim sqlins As String = "INSERT INTO [gaji] (nama, email, role, gaji) VALUES (@nama, @email, @role, @gaji)"
        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@nama", nama)
            cmdInsert.Parameters.AddWithValue("@email", email)
            cmdInsert.Parameters.AddWithValue("@role", role)
            cmdInsert.Parameters.AddWithValue("@gaji", gaji)
            cmdInsert.ExecuteNonQuery()
            Call Kosong()
            MsgBox("Tambah Gaji berhasil!")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Kembali ke screen login
        Dim transaksiGajiForm As New Form_Transaksi_Gaji()
        transaksiGajiForm.Show()
        Me.Hide()
    End Sub
End Class