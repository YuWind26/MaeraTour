
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form_Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_Password.UseSystemPasswordChar = True
        Btn_Hide_Regis.Text = "Show"
    End Sub

    Private Sub Link_Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_Register.LinkClicked
        Dim f As New Form_Register
        f.Show()
        Me.Hide()
    End Sub

    Private Function IsValidEmail(email As String) As Boolean
        ' Validasi format email menggunakan ekspresi reguler
        Dim emailRegex As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Dim match As Match = Regex.Match(email, emailRegex)
        Return match.Success
    End Function

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click

        If String.IsNullOrWhiteSpace(Text_Email.Text) OrElse
       String.IsNullOrWhiteSpace(Text_Password.Text) Then
            MsgBox("Harap lengkapi semua field sebelum melakukan registrasi.")
            Return
        End If

        Dim email As String = Text_Email.Text.Trim()
        If Not IsValidEmail(email) Then
            MsgBox("Format email tidak valid. Harap masukkan email dengan format yang sesuai.")
            Return
        End If

        Dim password As String = Text_Password.Text

        ' Koneksi ke database (ganti connection string dengan yang sesuai)

        Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
        Dim connection As New SqlConnection(connectionString)

        Try
            ' Buka koneksi
            connection.Open()

            ' Query SELECT untuk mendapatkan informasi pengguna berdasarkan email dan password
            Dim query As String = "SELECT role FROM [user] WHERE email = @email AND password = @password"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@email", email)
            command.Parameters.AddWithValue("@password", password)

            ' Eksekusi perintah dan baca hasil
            Dim role As String = Convert.ToString(command.ExecuteScalar())
            If Not String.IsNullOrEmpty(role) Then
                ' Cek peran (role) pengguna
                Select Case role
                    Case "admin"
                        ' Jika peran adalah "admin", buka Form_Admin
                        Dim formAdmin As New Form_Admin()
                        formAdmin.Show()
                        Me.Hide()
                    Case "karyawan"
                        ' Jika peran adalah "karyawan", buka Form_Karyawan
                        Dim formKaryawan As New Form_Karyawan()
                        formKaryawan.Show()
                        Me.Hide()
                    Case "wisatawan"
                        ' Jika peran adalah "wisatawan", buka Form_Wisatawan
                        Dim formWisatawan As New Form_Wisatawan()
                        formWisatawan.Show()
                        Me.Hide()
                    Case Else
                        ' Jika peran tidak dikenali, tampilkan pesan kesalahan
                        MsgBox("Peran pengguna tidak valid!")
                End Select
            Else
                ' Jika tidak ada hasil yang cocok, tampilkan pesan kesalahan
                MsgBox("Email atau password salah!")
            End If
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message)
        Finally
            ' Tutup koneksi
            connection.Close()
        End Try
    End Sub



    Private Sub Btn_Hide_Regis_Click(sender As Object, e As EventArgs) Handles Btn_Hide_Regis.Click
        If Text_Password.UseSystemPasswordChar Then
            Text_Password.UseSystemPasswordChar = False
            Btn_Hide.Text = "Hide"
        Else
            Text_Password.UseSystemPasswordChar = True
            Btn_Hide.Text = "Show"
        End If
    End Sub
End Class
