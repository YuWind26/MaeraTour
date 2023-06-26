
Public Class Form_Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Link_Register_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Link_Register.LinkClicked
        Dim f As New Form_Register
        f.Show()
        Me.Hide()
    End Sub
End Class
