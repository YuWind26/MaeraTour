Imports System.Data.SqlClient

Public Class Form_Kelola_User
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim formAdmin As New Form_Admin()
        formAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick


    End Sub

    Private Sub Form_Kelola_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (ganti connection string dengan yang sesuai)
        Dim connectionString As String = "Data Source=LAPTOP-R7CIKDER\ARIFACER;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Buka koneksi
            connection.Open()

            ' Query SELECT untuk mendapatkan data pengguna dari database
            Dim query As String = "SELECT [username], [email], [role] FROM [user]"
            Dim command As New SqlCommand(query, connection)

            ' Buat SqlDataAdapter untuk mengambil data dari database
            Dim adapter As New SqlDataAdapter(command)

            ' Buat DataSet untuk menampung data dari database
            Dim dataSet As New DataSet()

            ' Isi DataSet dengan data dari database menggunakan SqlDataAdapter
            adapter.Fill(dataSet)

            ' Set DataGridView.DataSource dengan DataSet.Tables[0] (tabel pertama dalam DataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub

    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        Dim TambahUserKaryawan As New Form_Tambah_Karyawan
        TambahUserKaryawan.Show()
        Me.Hide()
    End Sub
End Class