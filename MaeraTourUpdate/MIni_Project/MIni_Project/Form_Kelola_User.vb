Imports System.Data.SqlClient

Public Class Form_Kelola_User
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim formAdmin As New Form_Admin()
        formAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Kelola_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Koneksi ke database (ganti connection string dengan yang sesuai)
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
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

            ' Set lebar kolom username
            DataGridView1.Columns("username").Width = 150

            ' Set lebar kolom email
            DataGridView1.Columns("email").Width = 150

            ' Set lebar kolom role
            DataGridView1.Columns("role").Width = 150


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

    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        Dim TambahUserKaryawan As New Form_Tambah_User
        TambahUserKaryawan.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Cek apakah tombol yang diklik adalah tombol "Delete"
        If e.ColumnIndex = DataGridView1.Columns("DeleteButton").Index AndAlso e.RowIndex >= 0 Then
            ' Dapatkan nilai email dari baris yang diklik
            Dim email As String = DataGridView1.Rows(e.RowIndex).Cells("email").Value.ToString()

            ' Konfirmasi penghapusan dengan messagebox
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus pengguna dengan email: " & email & "?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Koneksi ke database (ganti connection string dengan yang sesuai)
                Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
                Dim connection As New SqlConnection(connectionString)

                Try
                    ' Buka koneksi
                    connection.Open()

                    ' Hapus data dari database berdasarkan email
                    Dim deleteQuery As String = "DELETE FROM [user] WHERE [email] = @Email"
                    Dim deleteCommand As New SqlCommand(deleteQuery, connection)
                    deleteCommand.Parameters.AddWithValue("@Email", email)
                    deleteCommand.ExecuteNonQuery()

                    ' Refresh DataGridView
                    Dim query As String = "SELECT [username], [email], [role] FROM [user]"
                    Dim command As New SqlCommand(query, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataSet As New DataSet()

                    ' Isi DataSet dengan data dari database menggunakan SqlDataAdapter
                    adapter.Fill(dataSet)

                    ' Set DataGridView.DataSource dengan DataSet.Tables[0] (tabel pertama dalam DataSet)
                    DataGridView1.DataSource = dataSet.Tables(0)

                Catch ex As Exception
                    MsgBox("Terjadi kesalahan saat menghapus data: " & ex.Message)
                Finally
                    ' Tutup koneksi
                    connection.Close()
                End Try
            End If
        End If
    End Sub
End Class