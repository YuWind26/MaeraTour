Imports System.Data.SqlClient

Public Class Form_Update_Wahana
    Private selectedNama As String
    Private selectedDeskripsi As String
    Private selectedHarga As Integer

    Public Sub New(nama As String, deskripsi As String, harga As Integer)
        InitializeComponent()
        selectedNama = nama
        selectedDeskripsi = deskripsi
        selectedHarga = harga
    End Sub

    Private Sub Form_Update_Wahana_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi kontrol dengan data yang akan diperbarui
        Text_Username.Text = selectedNama
        Text_Email.Text = selectedDeskripsi
        Text_Password.Text = selectedHarga.ToString

    End Sub

    Private Sub BtnUpdateUser_Click(sender As Object, e As EventArgs) Handles BtnUpdateUser.Click
        ' Ambil data yang diperbarui dari kontrol-kontrol di form pembaruan data
        Dim updatedNama As String = Text_Username.Text
        Dim updatedDeskripsi As String = Text_Email.Text
        Dim updatedHarga As Integer = Integer.Parse(Text_Password.Text)

        ' Update data ke database
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim query As String = "UPDATE [tiket_wahana] SET [nama] = @nama, [deskripsi] = @deskripsi, [harga] = @harga WHERE [nama] = @selectedNama"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", updatedNama)
                command.Parameters.AddWithValue("@deskripsi", updatedDeskripsi)
                command.Parameters.AddWithValue("@harga", updatedHarga)
                command.Parameters.AddWithValue("@selectedNama", selectedNama)
                command.ExecuteNonQuery()
            End Using

            ' Kirim data yang diperbarui kembali ke form utama
            DialogResult = DialogResult.OK

            ' Tutup form pembaruan data
            Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Kembali ke screen login
        Dim WahanaForm As New Form_Kelola_Wahana()
        WahanaForm.Show()
        Me.Hide()
    End Sub
End Class