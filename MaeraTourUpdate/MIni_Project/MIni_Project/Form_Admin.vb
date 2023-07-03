Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form_Admin
    Private Sub Btn_User_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        Btn_Logout.Region = New Region(New Rectangle(0, 0, Btn_Logout.Width, Btn_Logout.Height))

        ' Kembali ke screen login
        Dim kelolaUserForm As New Form_Kelola_User()
        kelolaUserForm.Show()
        Me.Hide()

    End Sub

    Private Sub Btn_Logout_Click(sender As Object, e As EventArgs) Handles Btn_Logout.Click
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
        ' Kembali ke screen login
        Dim kelolaWahanaForm As New Form_Kelola_Wahana()
        kelolaWahanaForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Iklan_Click(sender As Object, e As EventArgs) Handles Btn_Iklan.Click
        Dim loginIklan As New Form_Kelola_Iklan
        loginIklan.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Gaji_Click(sender As Object, e As EventArgs) Handles Btn_Gaji.Click
        Dim gajiForm As New Form_Transaksi_Gaji
        gajiForm.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Laporan_Click(sender As Object, e As EventArgs) Handles Btn_Laporan.Click
        Dim laporanBulananForm As New Form_Laporan_Bulanan
        laporanBulananForm.Show()
        Me.Hide()
    End Sub
End Class