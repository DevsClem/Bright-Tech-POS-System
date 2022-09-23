Public Class frmSupplier
    Dim strQuery = "Select supplier_id as 'ID', supplier_name as 'Name', supplier_contact as 'Contact', supplier_address as 'Address', supplier_email as 'Email' from tbl_supplier"
    Private Sub frmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConnection()
        displayRecords(strQuery, DGSupplier)
        buttonsStatus()
        clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_Supplier values(@id,@name,@contact,@address,@email)"
        Dim val() = {"@id", "@name", "@contact", "@address", "@email"}
        Dim value() =
            {txtID.Text.ToString,
             txtSupplier.Text.ToString,
             txtContact.Text.ToString,
             txtAddresss.Text.ToString,
             txtEmail.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGSupplier)
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_supplier set supplier_name=@name,supplier_contact=@contact,supplier_address=@address,supplier_email=@email where Supplier_id=" & txtID.Text & ""
        Dim val() = {"@id", "@name", "@contact", "@address", "@email"}
        Dim value() =
            {txtID.Text.ToString,
             txtSupplier.Text.ToString,
             txtContact.Text.ToString,
             txtAddresss.Text.ToString,
             txtEmail.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGSupplier)
        buttonsStatus()
        clear()
    End Sub

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtID.Text = ""
        txtSupplier.Text = ""
        txtContact.Text = ""
        txtAddresss.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub DGSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSupplier.CellClick
        Try
            Dim i = e.RowIndex
            With DGSupplier
                txtID.Text = .Item("name", i).Value
                txtSupplier.Text = .Item("name", i).Value
                txtContact.Text = .Item("contact", i).Value
                txtAddresss.Text = .Item("address", i).Value
                txtEmail.Text = .Item("email", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from tbl_Supplier where Supplier_name like '%" & txtSearch.Text & "%' or Supplier_id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGSupplier)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlSupplier.DoubleClick
        clear()
        buttonsStatus()
    End Sub


End Class