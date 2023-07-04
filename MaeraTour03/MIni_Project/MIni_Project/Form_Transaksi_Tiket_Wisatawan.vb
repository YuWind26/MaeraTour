Imports System.Data.SqlClient

Public Class Form_Transaksi_Tiket_Wisatawan
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim ButtonBack As New Form_Wisatawan
        ButtonBack.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Transaksi_Tiket_Wisatawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (ganti connection string dengan yang sesuai)
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Buka koneksi
            connection.Open()

            ' Query SELECT untuk mendapatkan data pengguna dari database
            Dim query As String = "SELECT [nama], [deskripsi], [harga] FROM [tiket_wahana]"
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

            ' Tambahkan tombol "Update" pada setiap baris DataGridView
            Dim updateButtonColumn As New DataGridViewButtonColumn()
            updateButtonColumn.Name = "pesanButton"
            updateButtonColumn.HeaderText = "Pesan"
            updateButtonColumn.Text = "Pesan"
            updateButtonColumn.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(updateButtonColumn)

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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)
        ' Cek jika tombol "Update" diklik
        If e.ColumnIndex = DataGridView1.Columns("pesanButton").Index AndAlso e.RowIndex >= 0 Then
            ' Ambil data dari DataGridView berdasarkan baris yang diklik
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim nama As String = selectedRow.Cells("nama").Value.ToString()
            Dim deskripsi As String = selectedRow.Cells("deskripsi").Value.ToString()
            Dim harga As Integer = Integer.Parse(selectedRow.Cells("harga").Value.ToString())

            ' Buat instance dari form pembaruan data
            Dim updateForm As New Form_Order_Tiket(nama, deskripsi, harga)

            ' Tampilkan form pembaruan data sebagai dialog
            Dim result As DialogResult = updateForm.ShowDialog()

            Me.Hide()

            ' Jika form pembaruan data ditutup dengan hasil OK, lakukan aksi pembaruan data
            If result = DialogResult.OK Then
                ' Lakukan update data sesuai kebutuhan
                ' ...
                ' Panggil fungsi RefreshData untuk memperbarui tampilan data pada DataGridView
                RefreshData()
            End If
        End If
    End Sub
End Class