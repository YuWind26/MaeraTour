Imports System.Data.SqlClient

Public Class Form_Tambah_Wahana

    Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
    Dim conn As New SqlConnection(connectionString)
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Private Sub Form_Tambah_Wahana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Kosong()
        Text_Username.Text = ""
        Text_Email.Text = ""
        Text_Password.Text = ""
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        Dim nama As String = Text_Username.Text.Trim()
        Dim deskripsi As String = Text_Email.Text.Trim()
        Dim harga As Integer

        If Not Integer.TryParse(Text_Password.Text.Trim(), harga) Then
            MsgBox("Harga harus berupa angka!")
            Return
        End If

        Dim sqlins As String = "INSERT INTO [tiket_wahana] (nama, deskripsi, harga) VALUES (@nama, @deskripsi, @harga)"
        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@nama", nama)
            cmdInsert.Parameters.AddWithValue("@deskripsi", deskripsi)
            cmdInsert.Parameters.AddWithValue("@harga", harga)
            cmdInsert.ExecuteNonQuery()
            Call Kosong()
            MsgBox("Tambah Wahana berhasil!")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        ' Kembali ke screen login
        Dim kelolaWahanaForm As New Form_Kelola_Wahana()
        kelolaWahanaForm.Show()
        Me.Hide()
    End Sub
End Class