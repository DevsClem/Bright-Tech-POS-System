Public Class frmCustomer
    Dim strQuery = "Select c.customer_id as 'ID', c.customer_name as 'Customer Name', c.customer_contact 'Contact', g.gender_title as 'Gender', c.customer_address as 'Address' from tbl_customer c join tbl_gender g on c.gender_id=g.gender_id order by customer_id asc"
    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConnection()
        displayRecords(strQuery, DGCustomer)
        loadToComboBox("Select *from tbl_gender", cboGender)
        buttonsStatus()
        clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_customer values(@id,@title,@contact,@gender,@address)"
        Dim val() = {"@id", "@title", "@contact", "@gender", "@address"}
        Dim value() =
            {txtID.Text.ToString,
             txtCustomer.Text.ToString,
             txtContact.Text.ToString,
             cboGender.SelectedValue.ToString,
             txtAddress.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGCustomer)
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_customer set customer_name=@title,customer_contact=@contact,gender_id=@gender,customer_address=@address where customer_id=" & txtID.Text & ""
        Dim val() = {"@id", "@title", "@contact", "@gender", "@address"}
        Dim value() =
            {txtID.Text.ToString,
             txtCustomer.Text.ToString,
             txtContact.Text.ToString,
             cboGender.SelectedValue.ToString,
             txtAddress.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGCustomer)
        buttonsStatus()
        clear()
    End Sub

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtID.Text = ""
        txtCustomer.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub DGcustomer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCustomer.CellClick
        Try
            Dim i = e.RowIndex
            With DGCustomer
                txtID.Text = .Item("id", i).Value
                txtCustomer.Text = .Item("customer name", i).Value
                txtContact.Text = .Item("contact", i).Value
                cboGender.Text = .Item("gender", i).Value
                txtAddress.Text = .Item("address", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from joincustomer where customer_name like '%" & txtSearch.Text & "%' or customer_id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGcustomer)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlProduct.DoubleClick
        clear()
        buttonsStatus()
    End Sub


End Class