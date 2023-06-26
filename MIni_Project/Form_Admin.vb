Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form_Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_User.Click
        Btn_Logout.Region = New Region(New Rectangle(0, 0, Btn_Logout.Width, Btn_Logout.Height))
    End Sub
End Class