Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form_Kelola_Wahana
    Private Sub Form_Kelola_Wahana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            updateButtonColumn.Name = "UpdateButton"
            updateButtonColumn.HeaderText = "Update"
            updateButtonColumn.Text = "Update"
            updateButtonColumn.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(updateButtonColumn)

            ' Tambahkan tombol "Delete" pada setiap baris DataGridView
            Dim deleteButtonColumn As New DataGridViewButtonColumn()
            deleteButtonColumn.Name = "DeleteButton"
            deleteButtonColumn.HeaderText = "Delete"
            deleteButtonColumn.Text = "Delete"
            deleteButtonColumn.UseColumnTextForButtonValue = True
            DataGridView1.Columns.Add(deleteButtonColumn)

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub

    Private Sub btnTambahWahana_Click(sender As Object, e As EventArgs) Handles btnTambahWahana.Click
        ' Kembali ke screen login
        Dim tambahWahanaForm As New Form_Tambah_Wahana()
        tambahWahanaForm.Show()
        Me.Hide()
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
        If e.ColumnIndex = DataGridView1.Columns("UpdateButton").Index AndAlso e.RowIndex >= 0 Then
            ' Ambil data dari DataGridView berdasarkan baris yang diklik
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim nama As String = selectedRow.Cells("nama").Value.ToString()
            Dim deskripsi As String = selectedRow.Cells("deskripsi").Value.ToString()
            Dim harga As Integer = Integer.Parse(selectedRow.Cells("harga").Value.ToString())

            ' Buat instance dari form pembaruan data
            Dim updateForm As New Form_Update_Wahana(nama, deskripsi, harga)

            ' Tampilkan form pembaruan data sebagai dialog
            Dim result As DialogResult = updateForm.ShowDialog()

            ' Jika form pembaruan data ditutup dengan hasil OK, lakukan aksi pembaruan data
            If result = DialogResult.OK Then
                ' Lakukan update data sesuai kebutuhan
                ' ...
                ' Panggil fungsi RefreshData untuk memperbarui tampilan data pada DataGridView
                RefreshData()
            End If
        End If
        ' Cek jika tombol "Delete" diklik
        If e.ColumnIndex = DataGridView1.Columns("DeleteButton").Index AndAlso e.RowIndex >= 0 Then
            ' Konfirmasi penghapusan data
            Dim result As DialogResult = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Ambil data dari DataGridView berdasarkan baris yang diklik
                Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
                Dim nama As String = selectedRow.Cells("nama").Value.ToString()

                ' Hapus data dari database
                Dim sqlDelete As String = "DELETE FROM [tiket_wahana] WHERE [nama] = @nama"
                Try
                    connection.Open()
                    Dim cmdDelete As SqlCommand = New SqlCommand(sqlDelete, connection)
                    cmdDelete.Parameters.AddWithValue("@nama", nama)
                    cmdDelete.ExecuteNonQuery()
                    MsgBox("Data berhasil dihapus!")
                    Call RefreshData()
                Catch ex As Exception
                    MsgBox(ex.ToString())
                Finally
                    connection.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Kembali ke screen login
        Dim adminForm As New Form_Admin()
        adminForm.Show()
        Me.Hide()
    End Sub
End Class