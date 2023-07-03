Public Class Form_Wisatawan

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
        Btn_Logout.Region = New Region(New Rectangle(0, 0, Btn_Logout.Width, Btn_Logout.Height))
        ' Tampilkan dialog konfirmasi logout
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Periksa hasil dialog konfirmasi
        If result = DialogResult.Yes Then

            ' Kembali ke screen login
            Dim loginForm As New Form_Login()
            loginForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Btn_Tempat_Wisata_Click(sender As Object, e As EventArgs) Handles Btn_Tempat_Wisata.Click
        Dim TiketWisata As New Form_Transaksi_Tiket_Wisatawan()
        TiketWisata.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Wisatawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class