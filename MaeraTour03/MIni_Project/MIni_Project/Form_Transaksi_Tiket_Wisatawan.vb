Public Class Form_Transaksi_Tiket_Wisatawan
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim ButtonBack As New Form_Wisatawan
        ButtonBack.Show()
        Me.Hide()
    End Sub
End Class