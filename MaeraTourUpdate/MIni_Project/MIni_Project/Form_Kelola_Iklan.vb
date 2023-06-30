Public Class Form_Kelola_Iklan
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim FormBackAdmin As New Form_Admin
        FormBackAdmin.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Iklan_Click(sender As Object, e As EventArgs) Handles Btn_Iklan.Click
        Dim FormTambahIklan As New Form_Tambah_Iklan
        FormTambahIklan.Show()
        Me.Hide()
    End Sub
End Class