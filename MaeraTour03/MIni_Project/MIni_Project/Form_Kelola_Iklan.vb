Imports System.Data.SqlClient

Public Class Form_Kelola_Iklan
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim FormBackAdmin As New Form_Admin
        FormBackAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Iklan_Click(sender As Object, e As EventArgs) Handles Btn_Iklan.Click
        Dim FormTambahIklan As New Form_Tambah_Iklan
        FormTambahIklan.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Kelola_Iklan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (ganti connection string dengan yang sesuai)
        Dim connectionString As String = "Data Source=LAPTOP-R7CIKDER\ARIFACER;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Buka koneksi
            connection.Open()

            ' Query SELECT untuk mendapatkan data pengguna dari database
            Dim query As String = "SELECT [nama], [qty], [tipe], [biaya] FROM [iklan_operasional]"
            Dim command As New SqlCommand(query, connection)

            ' Buat SqlDataAdapter untuk mengambil data dari database
            Dim adapter As New SqlDataAdapter(command)

            ' Buat DataSet untuk menampung data dari database
            Dim dataSet As New DataSet()

            ' Isi DataSet dengan data dari database menggunakan SqlDataAdapter
            adapter.Fill(dataSet)

            ' Set DataGridView.DataSource dengan DataSet.Tables[0] (tabel pertama dalam DataSet)
            DataGridView1.DataSource = dataSet.Tables(0)

            ' Set lebar kolom nama
            DataGridView1.Columns("nama").Width = 150

            ' Set lebar kolom deskripsi
            DataGridView1.Columns("qty").Width = 150

            ' Set lebar kolom harga
            DataGridView1.Columns("tipe").Width = 150

            ' Set lebar kolom harga
            DataGridView1.Columns("biaya").Width = 150

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub

    Private Sub RefreshData()
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        ' Query SELECT untuk mendapatkan data pengguna dari database
        Dim query As String = "SELECT [nama], [deskripsi], [harga] FROM [tiket_wahana]"
        Dim command As New SqlCommand(query, connection)
        Dim adapter As New SqlDataAdapter(command)
        Dim dataSet As New DataSet()

        ' Isi DataSet dengan data dari database menggunakan SqlDataAdapter
        adapter.Fill(dataSet)

        ' Set DataGridView.DataSource dengan DataSet.Tables[0] (tabel pertama dalam DataSet)
        DataGridView1.DataSource = dataSet.Tables(0)
    End Sub
End Class