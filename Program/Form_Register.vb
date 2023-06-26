Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class Form_Register
    Dim conn As SqlConnection = New SqlConnection("Data Source=LAPTOP-R7CIKDER\ARIFACER; " &
                "user id = sa; password=123456; Integrated Security=True; " &
                "database=Mini_Project")
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Private Sub Kosong()
        Text_Username.Text = ""
        Text_Email.Text = ""
        Text_Password.Text = ""
    End Sub
    Private Sub Link_Login_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_Login.LinkClicked
        Dim f As New Form_Login
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Register_Click(sender As Object, e As EventArgs) Handles Button_Register.Click
        Dim sqlins As String = "INSERT INTO [user] (username, email, [password]) VALUES (@username, @email, @password)"
        Try
            conn.Open()
            MsgBox("Koneksi Sukses!")
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@username", Text_Username.Text)
            cmdInsert.Parameters.AddWithValue("@email", Text_Email.Text)
            cmdInsert.Parameters.AddWithValue("@password", Text_Password.Text)
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

End Class