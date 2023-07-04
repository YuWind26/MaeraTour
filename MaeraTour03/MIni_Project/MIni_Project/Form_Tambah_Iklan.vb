Imports System.Data.SqlClient

Public Class Form_Tambah_Iklan
    Dim connectionString As String = "Data Source=DESKTOP-NDRD6D4;Initial Catalog=Mini_Project;User ID=sa;Password=123456; Integrated Security=True;"
    Dim conn As New SqlConnection(connectionString)
    Dim ADP As SqlDataAdapter
    Dim DS As New DataSet
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim FormBackIklan As New Form_Kelola_Iklan
        FormBackIklan.Show()
        Me.Hide()
    End Sub

    Private Sub Kosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Form_Tambah_Iklan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub BtnAddIklan_Click(sender As Object, e As EventArgs) Handles BtnAddIklan.Click
        Dim nama As String = TextBox1.Text.Trim()
        Dim qty As Integer
        Dim tipe As String = TextBox3.Text.Trim()
        Dim biaya As Integer

        If Not Integer.TryParse(TextBox2.Text.Trim(), qty) Then
            MsgBox("Qty harus berupa angka!")
            Return
        End If

        If Not Integer.TryParse(TextBox4.Text.Trim(), biaya) Then
            MsgBox("biaya harus berupa angka!")
            Return
        End If

        Dim sqlins As String = "INSERT INTO [iklan_operasional] (nama, qty, tipe, biaya) VALUES (@nama, @qty, @tipe, @biaya)"
        Try
            conn.Open()
            Dim cmdInsert As SqlCommand = New SqlCommand(sqlins, conn)
            cmdInsert.Parameters.AddWithValue("@nama", nama)
            cmdInsert.Parameters.AddWithValue("@qty", qty)
            cmdInsert.Parameters.AddWithValue("@tipe", tipe)
            cmdInsert.Parameters.AddWithValue("@biaya", biaya)
            cmdInsert.ExecuteNonQuery()
            Call Kosong()
            MsgBox("Tambah Iklan atau  Operasional berhasil!")
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            conn.Close()
        End Try
    End Sub
End Class