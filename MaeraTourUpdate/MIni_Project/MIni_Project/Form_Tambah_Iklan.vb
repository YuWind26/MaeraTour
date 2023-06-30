Public Class Form_Tambah_Iklan
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim FormBackIklan As New Form_Kelola_Iklan
        FormBackIklan.Show()
        Me.Hide()
    End Sub
End Class