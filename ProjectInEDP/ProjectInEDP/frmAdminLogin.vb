Public Class frmAdminLogin
    Dim strQueryt = ""
    Dim wrapper As New Simple3Des()

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isFound("Select *from tbl_admin", txtAdmin.Text, txtPassword.Text, "Username", "Password") Then
            MessageBox.Show("Log-in successful")
            Dim ap As New frmAdminOnly
            ap.adminID = getRecord("Select *from tbl_admin", txtAdmin.Text, txtPassword.Text, "Username", "Password", "Admin_id")
            ap.Show()
            Me.Hide()
        Else
            MessageBox.Show("Log-in failed")
        End If

    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub
End Class