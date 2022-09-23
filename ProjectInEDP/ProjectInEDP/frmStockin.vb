Public Class frmStockin
    Public Property adminID As String
    Dim lastID
    Dim strQuery = ""
    Dim productQuery = "Select p.product_id as 'ID',p.product_title as 'Name',c.category_title as 'Category',b.brand_title as 'Brand',p.product_price as 'Price',p.quantity as 'Quantity',p.product_description as 'Description' from tbl_product p join tbl_category c on p.category_id = c.category_id join tbl_brand b on p.brand_id=b.brand_id order by Product_id asc"
    Dim stockinQuery = "Select s.supply_id as 'ID',s.supply_date as 'Supply Date',e.employee_name as 'Employee Name',ss.supplier_name as 'Supplier' from tbl_supply s join tbl_admin a on s.admin_id=a.admin_id join tbl_employee e on a.employee_id=e.employee_id join tbl_supplier ss on ss.supplier_id=s.supplier_id order by s.supply_id asc"
    Dim stockinDetailsQuery = "Select s.supply_id as 'Supply ID',p.product_id as 'Product ID',p.product_title as 'Product Title',s.quantity as 'Quantity',s.price as 'Price', s.quantity*s.price as 'Sub Total' from tbl_supply_details s join tbl_product p on s.product_id=p.product_id order by s.supply_id asc"

    Private Sub frmStockin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtQuantity.Enabled = False
        txtPrice.Enabled = False
        btnAdd.Enabled = False
        btnClear.Enabled = False
        btnUpdate.Enabled = False
        DGProducts.Enabled = False
        DGStockinDetails.Enabled = False
        btnClose.Enabled = False
        dbConnection()
        loadToComboBox("Select *from tbl_supplier", cboSupplier)
        refreshTables()
        buttonsStatusDetails()
        clear()
    End Sub

    Private Sub enableAll()
        txtQuantity.Enabled = True
        txtPrice.Enabled = True
        btnAdd.Enabled = True
        btnClear.Enabled = True
        btnSaveSupply.Enabled = False
        DGProducts.Enabled = True
        DGStockinDetails.Enabled = True
    End Sub
    Private Sub refreshTables() ' Refresh all three tables 
        displayRecords(stockinQuery, DGStockin)
        displayRecords(productQuery, DGProducts)
        displayRecords(stockinDetailsQuery, DGStockinDetails)
    End Sub
    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtProductID.Text = ""
        txtProductTitle.Text = ""
        txtQuantity.Text = ""
        txtPrice.Text = ""
        txtSubTotal.Text = ""
    End Sub

    Private Sub buttonsStatusDetails() ' Enabling and disabling buttons 
        btnClose.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub frmAdmin_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDoubleClick
        clear()
        buttonsStatusDetails()
    End Sub

    'Supply Buttons, Textfields and Datagrids

    Private Sub btnSaveSupply_Click(sender As Object, e As EventArgs) Handles btnSaveSupply.Click
        Dim SQL = "insert into tbl_supply values(@id,@date,@adminID,@supplier)"
        Dim val() = {"@id", "@date", "@adminID", "@supplier"}
        Dim value() =
            {txtSupplyID.Text.ToString,
             dprSupplyDate.Text.ToString,
             adminID.ToString,'adminID.ToString,
        cboSupplier.SelectedValue.ToString}
        SQLProcess(SQL, val, value)
        txtSupplyID.Text = readLastRecordString("Select *from tbl_supply", "Supply_ID")
        stockinDetailsQuery = "Select s.supply_id as 'Supply ID',p.product_id as 'Product ID',p.product_title as 'Product Title',s.quantity as 'Quantity',s.price as 'Price', s.quantity*s.price as 'Sub Total' from tbl_supply_details s join tbl_product p on s.product_id=p.product_id where supply_id=" & txtSupplyID.Text & ""
        refreshTables()
        enableAll()
        MessageBox.Show("Successfully Saved")

    End Sub


    Private Sub txtStockinSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStockinSearch.TextChanged
        strQuery = "Select *from joinstockin where id like '%" & txtSearch.Text & "%' or 'supply date' like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGStockin)
    End Sub


    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim asp As New frmSupplier
        asp.ShowDialog()
        loadToComboBox("Select *from tbl_supplier", cboSupplier)
    End Sub

    'End of Supply Buttons, Textfields and Datagrids
    'Start of supplydetails


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim numQuantity = 0, SQL2 = ""
        Dim SQL = "insert into tbl_supply_details values(@id,@productID,@quantity,@price)"
        Dim vals() = {"@id", "@productID", "@quantity", "@price"}

        If txtProductID.Text = "" Or txtProductTitle.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please Complete the form!")
        Else
            Dim value() =
           {txtSupplyID.Text.ToString,
            txtProductID.Text.ToString,
            txtQuantity.Text.ToString,
            txtPrice.Text.ToString}
            SQLProcess(SQL, vals, value)
            numQuantity = Val(getRecord("Select *from tbl_product", txtProductID.Text, txtProductTitle.Text, "Product_ID", "Product_title", "Quantity"))
            numQuantity += Val(txtQuantity.Text)
            SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
            SQLProcess(SQL2)
            buttonsStatusDetails()
            clear()
            refreshTables()
            MessageBox.Show("Successfully Added")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim numQuantity = 0, numUpdatedQuantity = 0, SQL2 = "", numAnswer = 0
        Dim SQL = "update tbl_supply_details set quantity=@quantity,price=@price where supply_id=" & txtSupplyID.Text & " and product_id=" & txtProductID.Text & ""
        Dim vals() = {"@id", "@productID", "@quantity", "@price"}

        If txtProductID.Text = "" Or txtProductTitle.Text = "" Or txtPrice.Text = "" Or txtQuantity.Text = "" Then
            MessageBox.Show("Please Complete the form!")
        Else
            numQuantity = Val(getRecord("Select *from tbl_product", txtProductID.Text, txtProductTitle.Text, "Product_ID", "Product_title", "Quantity"))
            numUpdatedQuantity = Val(getRecord("Select *from tbl_supply_details", txtSupplyID.Text, txtProductID.Text, "Supply_ID", "Product_ID", "Quantity"))
            Dim value() =
           {txtSupplyID.Text.ToString,
            txtProductID.Text.ToString,
            txtQuantity.Text.ToString,
            txtPrice.Text.ToString}
            If Val(txtQuantity.Text) = numUpdatedQuantity Then
                SQLProcess(SQL, vals, value)
                refreshTables()
                clear()
                buttonsStatusDetails()
                MessageBox.Show("Successfully Updated")
            ElseIf numUpdatedQuantity < Val(txtQuantity.Text) Then
                numQuantity += (Val(txtQuantity.Text) - numUpdatedQuantity)
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                refreshTables()
                clear()
                buttonsStatusDetails()
                MessageBox.Show("Successfully Updated")
            ElseIf numUpdatedQuantity > Val(txtQuantity.Text) Then
                numQuantity -= (numUpdatedQuantity - Val(txtQuantity.Text))
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                refreshTables()
                clear()
                buttonsStatusDetails()
                MessageBox.Show("Successfully Updated")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        Dim SQL = "delete from tbl_supply_details where supply_id=" & txtSupplyID.Text & "and product_id=" & txtProductID.Text & ""
        SQLProcess(SQL)
        displayRecords(productQuery, DGStockin)
        buttonsStatusDetails()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub DGProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducts.CellClick
        Try
            Dim i = e.RowIndex
            With DGProducts
                txtProductID.Text = .Item("id", i).Value
                txtProductTitle.Text = .Item("name", i).Value
            End With
            If checkDuplicate("Select *from tbl_supply_details", "Supply_ID", "Product_ID", txtSupplyID.Text, txtProductID.Text) Then
                btnUpdate.Enabled = True
                btnAdd.Enabled = False
            Else
                btnUpdate.Enabled = False
                btnAdd.Enabled = True
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DGStockinDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGStockinDetails.CellClick
        Try
            Dim i = e.RowIndex
            With DGStockinDetails
                txtProductID.Text = .Item("Product id", i).Value
                txtProductTitle.Text = .Item("Product title", i).Value
                txtQuantity.Text = .Item("quantity", i).Value
                txtPrice.Text = .Item("price", i).Value
            End With
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPrice_OnValueChanged(sender As Object, e As EventArgs) Handles txtPrice.OnValueChanged
        txtSubTotal.Text = Val(txtQuantity.Text) * Val(txtPrice.Text)

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub gbxSupplyDetails_DoubleClick(sender As Object, e As EventArgs) Handles gbxSupplyDetails.DoubleClick
        buttonsStatusDetails()
        clear()
    End Sub



    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub


End Class
