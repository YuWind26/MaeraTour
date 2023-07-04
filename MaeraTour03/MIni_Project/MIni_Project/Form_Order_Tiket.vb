Imports System.Data.SqlClient
Public Class Form_Order_Tiket
    Private selectedNama As String
    Private selectedDeskripsi As String
    Private selectedHarga As Integer

    Public Sub New(nama As String, deskripsi As String, harga As Integer)
        InitializeComponent()
        selectedNama = nama
        selectedDeskripsi = deskripsi
        selectedHarga = harga
    End Sub

    Private Sub Form_Order_Tiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi kontrol dengan data yang akan diperbarui
        Label3.Text = selectedNama
        TextBox2.Text = selectedDeskripsi
        Labelharga.Text = selectedHarga.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Ambil data yang diperbarui dari kontrol-kontrol di form pembaruan data
        Dim updatedNama As String = Label3.Text
        Dim updatedDeskripsi As String = TextBox2.Text
        Dim updatedHarga As Integer = Integer.Parse(Labelharga.Text)
        Dim updateQtyTicket As String = TextBox1.Text
        Dim updateDateBook As String = TextBox3.Text

        ' Update data ke database
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim query As String = "INSERT INTO [order_tiket_wahana] (nama, deskripsi, harga, qty_order, date_booking) VALUES (@nama, @deskripsi, @harga, @qtyOrder, @dateBooking)"

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@nama", updatedNama)
                command.Parameters.AddWithValue("@deskripsi", updatedDeskripsi)
                command.Parameters.AddWithValue("@harga", updatedHarga)
                command.Parameters.AddWithValue("@qtyOrder", updateQtyTicket)
                command.Parameters.AddWithValue("@dateBooking", updateDateBook)
                command.ExecuteNonQuery()
            End Using

            ' Kirim data yang diperbarui kembali ke form utama
            DialogResult = DialogResult.OK

            ' Kembali ke screen login
            Dim invoiceTiketForm As New Form_Invoice_Tiket()
            invoiceTiketForm.Show()
            Me.Hide()

            ' Tutup form pembaruan data
            Close()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub
End Class