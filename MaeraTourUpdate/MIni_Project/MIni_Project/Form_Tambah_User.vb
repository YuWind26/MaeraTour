Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_Tambah_User
    Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
    Dim conn As New SqlConnection(connectionString)
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Private Sub Kosong()
        Text_Username.Text = ""
        Text_Email.Text = ""
        Text_Password.Text = ""
    End Sub
    Private Function IsValidEmail(email As String) As Boolean
        ' Validasi format email menggunakan ekspresi reguler
        Dim emailRegex As String = "^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"
        Dim match As Match = Regex.Match(email, emailRegex)
        Return match.Success
    End Function
    Private Sub Form_Tambah_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text_Password.UseSystemPasswordChar = True
        Btn_Hide_Regis.Text = "Show"
        ' Add items to the dropdown list
        cbRole.Items.Add("admin")
        cbRole.Items.Add("karyawan")
        cbRole.Items.Add("wisatawan")

        ' Set the initial selected item
        cbRole.SelectedIndex = 0
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        If String.IsNullOrWhiteSpace(Text_Username.Text) OrElse
            String.IsNullOrWhiteSpace(Text_Email.Text) OrElse
            String.IsNullOrWhiteSpace(Text_Password.Text) Then
            MsgBox("Harap lengkapi semua field sebelum melakukan registrasi.")
            Return
        End If

        Dim email As String = Text_Email.Text.Trim()
        If Not IsValidEmail(email) Then
            MsgBox("Format email tidak valid. Harap masukkan email dengan format yang sesuai.")
            Return
        End If

        If cbRole.SelectedItem Is Nothing Then
            MsgBox("Harap pilih peran (role) sebelum melakukan registrasi.")
            Return
        End If

        Dim sqlins As String = "INSERT INTO [user] (username, email, [password], role) VALUES (@username, @email, @password, @role)"
        Try
            conn.Open()
            MsgBox("Koneksi Sukses!")
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@username", Text_Username.Text)
            cmdInsert.Parameters.AddWithValue("@email", Text_Email.Text)
            cmdInsert.Parameters.AddWithValue("@password", Text_Password.Text)
            cmdInsert.Parameters.AddWithValue("@role", cbRole.SelectedItem.ToString())
            cmdInsert.ExecuteNonQuery()
            Call Kosong()
            MsgBox("Registrasi berhasil!")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
            MsgBox("Connection Closed")
        End Try

    End Sub

    Private Sub Btn_Hide_Regis_Click(sender As Object, e As EventArgs) Handles Btn_Hide_Regis.Click
        If Text_Password.UseSystemPasswordChar Then
            Text_Password.UseSystemPasswordChar = False
            Btn_Hide_Regis.Text = "Hide"
        Else
            Text_Password.UseSystemPasswordChar = True
            Btn_Hide_Regis.Text = "Show"
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim FormBack As New Form_Kelola_User
        FormBack.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Text_Username_TextChanged(sender As Object, e As EventArgs) Handles Text_Username.TextChanged
    End Sub

    Private Sub Text_Email_TextChanged(sender As Object, e As EventArgs) Handles Text_Email.TextChanged
    End Sub

    Private Sub Text_Password_TextChanged(sender As Object, e As EventArgs) Handles Text_Password.TextChanged
    End Sub

    Private Sub cbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRole.SelectedIndexChanged
    End Sub
End Class
