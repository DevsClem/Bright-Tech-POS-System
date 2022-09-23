Public Class frmPayment
    Dim strQuery = "Select *from tbl_payment"
    Private Sub frmpayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        displayRecords(strQuery, DGPayment)
        buttonsStatus()
        clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_payment values(@id,@title)"
        Dim val() = {"@id", "@title"}
        Dim value() =
            {txtID.Text.ToString,
             txtPayment.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGPayment)
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_payment set payment_method=@title where payment_id=" & txtID.Text & ""
        Dim val() = {"@id", "@title"}
        Dim value() =
            {txtID.Text.ToString,
             txtPayment.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGPayment)
        buttonsStatus()
        clear()
    End Sub

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtID.Text = ""
        txtPayment.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub DGpayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGPayment.CellClick
        Try
            Dim i = e.RowIndex
            With DGPayment
                txtID.Text = .Item("payment_id", i).Value
                txtPayment.Text = .Item("payment_method", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from tbl_payment where payment_method like '%" & txtSearch.Text & "%' or payment_id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGPayment)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlProduct.DoubleClick
        clear()
        buttonsStatus()
    End Sub


End Class