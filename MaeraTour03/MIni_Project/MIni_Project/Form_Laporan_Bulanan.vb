Public Class Form_Laporan_Bulanan
    Private Sub Form_Laporan_Bulanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ' Kembali ke screen login
        Dim adminForm As New Form_Admin()
        adminForm.Show()
        Me.Hide()
    End Sub
End Class