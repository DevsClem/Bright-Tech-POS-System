Public Class frmLog
    Dim strQueryt = ""
    Dim wrapper As New Simple3Des()
    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If isFound("Select *from tbl_Employee", txtEmployee.Text, wrapper.EncryptData(txtPassword.Text), "Employee_id", "Employee_Password") Then
            MessageBox.Show("Log-in successful")
            Dim fh As New frmHome
            fh.employeeID = txtEmployee.Text
            fh.employeeName = getRecord("Select *from tbl_Employee", txtEmployee.Text, txtPassword.Text, "Employee_id", "Employee_contact", "Employee_Name")
            fh.Show()
            Me.Hide()
        Else
            MessageBox.Show("Log-in failed")
        End If

    End Sub

    Private Sub txtPassword_OnValueChanged(sender As Object, e As EventArgs) Handles txtPassword.OnValueChanged
        txtPassword.isPassword = True
    End Sub
End Class