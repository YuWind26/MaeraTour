Imports System.Data.SqlClient

Public Class Form_Invoice_Tiket
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form_Invoice_Tiket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Update data ke database
        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim query As String = "SELECT nama, deskripsi, harga, qty_order, date_booking FROM order_tiket_wahana"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    reader.Read()
                    Label3.Text = reader.GetString(0)
                    TextBox2.Text = reader.GetString(1)
                    TextBox1.Text = reader.GetInt32(2).ToString()
                    TextBox3.Text = reader.GetInt32(3).ToString()
                    TextBox5.Text = reader.GetString(4)
                End If
                TextBox4.Text = (Convert.ToDecimal(TextBox1.Text) * Convert.ToInt32(TextBox3.Text)).ToString()
                reader.Close()
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Kembali ke screen login
        Dim transaksiTiketWisatawanForm As New Form_Transaksi_Tiket_Wisatawan()
        transaksiTiketWisatawanForm.Show()
        Me.Hide()
    End Sub
End Class