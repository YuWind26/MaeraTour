Imports System.Data.SqlClient

Public Class Form_Laporan_Bulanan_Karyawan
    Private Sub Form_Laporan_Bulanan_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (ganti connection string dengan yang sesuai)
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Buka koneksi
            connection.Open()

            ' Query SELECT untuk mendapatkan data pengguna dari database
            Dim query As String = "SELECT nama, deskripsi, harga, qty_order, date_booking FROM order_tiket_wahana"
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
            DataGridView1.Columns("deskripsi").Width = 150

            ' Set lebar kolom harga
            DataGridView1.Columns("harga").Width = 150

            ' Set lebar kolom harga
            DataGridView1.Columns("qty_order").Width = 150

            ' Set lebar kolom harga
            DataGridView1.Columns("date_booking").Width = 150

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ' Kembali ke screen login
        Dim karyawanForm As New Form_Karyawan()
        karyawanForm.Show()
        Me.Hide()
    End Sub
End Class