Public Class frmHome
    Public Property employeeID As String
    Public Property employeeName As String
    Dim lastID
    Dim sumDiscount = 0.00, sumSubTotal = 0.00
    Dim strQuery = ""
    Dim productQuery = "Select p.product_id as 'ID',p.product_title as 'Name',c.category_title as 'Category',b.brand_title as 'Brand',p.product_price as 'Price',p.quantity as 'Quantity',p.product_description as 'Description' from tbl_product p join tbl_category c on p.category_id = c.category_id join tbl_brand b on p.brand_id=b.brand_id order by Product_id asc"
    Dim salesQuery = "Select s.sales_id as 'ID',s.sales_date as 'sales Date',e.employee_name as 'Employee Name',ss.supplier_name as 'Supplier' from tbl_sales s join tbl_admin a on s.admin_id=a.admin_id join tbl_employee e on a.employee_id=e.employee_id join tbl_supplier ss on ss.supplier_id=s.supplier_id order by s.sales_id asc"
    Dim salesDetailsQuery = "Select s.sales_id as 'Sales ID',p.product_id as 'Product ID',p.product_title as 'Product Title',p.product_description as 'Description',s.quantity as 'Quantity',p.product_price as 'Price', s.quantity*p.product_price as 'Sub Total', s.discount as 'Discount' from tbl_sales_details s join tbl_product p on s.product_id=p.product_id order by s.sales_id asc"

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        txtEmployee.Text = employeeName
        disableAll()
        buttonsStatusDetails()
        clear()
        loadToComboBox("Select *from tbl_payment", cboPayment)
        loadToComboBox("Select *from tbl_customer", cboCustomer)
    End Sub

    Private Sub enableAll()
        txtQuantity.Enabled = True
        btnAdd.Enabled = True
        btnSaveSales.Enabled = False
        DGProducts.Enabled = True
        DGSalesDetails.Enabled = True
    End Sub

    Private Sub disableAll()
        txtQuantity.Enabled = False
        txtPrice.Enabled = False
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        DGProducts.Enabled = False
        DGSalesDetails.Enabled = False
        btnSave.Enabled = False

    End Sub


    Private Sub refreshTables() ' Refresh all three tables 
        displayRecords(productQuery, DGProducts)
        displayRecords(salesDetailsQuery, DGSalesDetails)
    End Sub
    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtProductID.Text = ""
        txtProductTitle.Text = ""
        txtProductDescription.Text = ""
        txtQuantity.Text = ""
        txtPrice.Text = ""
        txtSubTotal.Text = ""
        txtDiscount.Text = ""
    End Sub

    Private Sub clearAll() ' Clear necessary textfields every after transaction is performed
        clear()
        txtSalesID.Text = ""
        dtpSales.Value = Now
        cboPayment.SelectedIndex = 0
        cboCustomer.SelectedIndex = 0
        txtCustomerContact.Text = ""
    End Sub


    Private Sub buttonsStatusDetails() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub frmAdmin_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDoubleClick
        clear()
        buttonsStatusDetails()
    End Sub

    'sales Buttons, Textfields and Datagrids

    Private Sub btnSavesales_Click(sender As Object, e As EventArgs) Handles btnSaveSales.Click
        Dim SQL = "insert into tbl_sales values(@id,@customer,@payment,@employee,now(),@net)"
        Dim val() = {"@id", "@customer", "@payment", "@employee", "@net"}
        Dim value() =
            {txtSalesID.Text.ToString,
             cboCustomer.SelectedValue.ToString,
             cboPayment.SelectedValue.ToString,
             employeeID.ToString,
             0.ToString
        }
        SQLProcess(SQL, val, value)
        txtSalesID.Text = readLastRecordString("Select *from tbl_sales", "sales_ID")
        salesDetailsQuery = "Select s.sales_id as 'Sales ID',p.product_id as 'Product ID',p.product_title as 'Product Title',p.product_description as 'Description',s.quantity as 'Quantity',p.product_price as 'Price', s.sub_total as 'Sub Total', s.discount as 'Discount' from tbl_sales_details s join tbl_product p on s.product_id=p.product_id where sales_id=" & txtSalesID.Text & ""
        refreshTables()
        enableAll()
        MessageBox.Show("Successfully Saved")

    End Sub


    Private Sub txtsalesSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged
        strQuery = "Select *from joinproducts where id like '%" & txtProductSearch.Text & "%' or 'sales date' like '%" & txtProductSearch.Text & "%'"
        displayRecords(strQuery, DGProducts)
    End Sub


    'End of sales Buttons, Textfields and Datagrids
    'Start of salesdetails


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim numQuantity = 0, SQL2 = ""
        Dim SQL = "insert into tbl_sales_details values(@id,@productID,@quantity,@subtotal,@discount)"
        Dim vals() = {"@id", "@productID", "@quantity", "@subtotal", "@discount"}

        If txtProductID.Text = "" Or txtProductTitle.Text = "" Or txtQuantity.Text = "" Or txtSubTotal.Text = "" Then
            MsgBox("Please Complete the form!")
        Else
            Dim value() =
                {txtSalesID.Text.ToString,
                txtProductID.Text.ToString(),
                txtQuantity.Text.ToString(),
                txtSubTotal.Text.ToString(),
                txtDiscount.Text.ToString()
            }
            numQuantity = Val(getRecordSales("Select *from tbl_product", txtProductID.Text, txtProductTitle.Text, "Product_ID", "Product_title", "Quantity"))
            If (Val(txtQuantity.Text) > numQuantity) Then
                MsgBox("Error: Quantity set is greater than quantity in record")
            Else
                numQuantity -= Val(txtQuantity.Text)
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(salesDetailsQuery, DGSalesDetails)
                MessageBox.Show("Successfully Added")
                txtDiscountAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "discount").ToString)
                txtSubTotalAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "sub_total").ToString)
                txtNetTotal.Text = Val(txtSubTotalAll.Text) - Val(txtDiscountAll.Text)
                clear()
            End If
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim numQuantity = 0, numUpdatedQuantity = 0, SQL2 = "", numAnswer = 0
        Dim SQL = "update tbl_sales_details set quantity=@quantity,sub_total=@subtotal,discount=@discount where sales_id=" & txtSalesID.Text & " and product_id=" & txtProductID.Text & ""
        Dim vals() = {"@id", "@productID", "@quantity", "@subtotal", "@discount"}

        If txtProductID.Text = "" Or txtProductTitle.Text = "" Or txtQuantity.Text = "" Or txtSubTotal.Text = "" Then
            MsgBox("Please Complete the form!")
        Else
            Dim value() =
                {txtSalesID.Text.ToString,
                txtProductID.Text.ToString(),
                txtQuantity.Text.ToString(),
                txtSubTotal.Text.ToString(),
                txtDiscount.Text.ToString()
            }
            numQuantity = Val(getRecordSales("Select *from tbl_product", txtProductID.Text, txtProductTitle.Text, "Product_ID", "Product_title", "Quantity"))
            numUpdatedQuantity = Val(getRecord("Select *from tbl_sales_details", txtSalesID.Text, txtProductID.Text, "Sales_ID", "Product_ID", "Quantity"))

            If (Val(txtQuantity.Text) > numQuantity) Then
                MsgBox("Error: Quantity set is greater than quantity in record")
            ElseIf Val(txtQuantity.Text) = numUpdatedQuantity Then
                SQLProcess(Sql, vals, value)
                displayRecords(salesDetailsQuery, DGSalesDetails)
                clear()
                buttonsStatusDetails()
                MessageBox.Show("Successfully Updated")
            ElseIf numUpdatedQuantity < Val(txtQuantity.Text) Then
                numQuantity -= (Val(txtQuantity.Text) - numUpdatedQuantity)
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(Sql, vals, value)
                SQLProcess(SQL2)
                displayRecords(salesDetailsQuery, DGSalesDetails)
                MessageBox.Show("Successfully Updated")
                txtDiscountAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "discount").ToString)
                txtSubTotalAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "sub_total").ToString)
                txtNetTotal.Text = Val(txtSubTotalAll.Text) - Val(txtDiscountAll.Text)
                clear()
                buttonsStatusDetails()
            ElseIf numUpdatedQuantity > Val(txtQuantity.Text) Then
                numQuantity += (numUpdatedQuantity - Val(txtQuantity.Text))
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(salesDetailsQuery, DGSalesDetails)
                txtDiscountAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "discount").ToString)
                txtSubTotalAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "sub_total").ToString)
                txtNetTotal.Text = Val(txtSubTotalAll.Text) - Val(txtDiscountAll.Text)
                clear()
                buttonsStatusDetails()
            End If
        End If
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim numQuantity = 0, SQL2 = "", numSalesQuantity
        Dim SQL = "delete from tbl_sales_details where sales_id=" & txtSalesID.Text & " and product_id=" & txtProductID.Text & ""
        Dim vals() = {"@id", "@productID", "@quantity", "@subtotal", "@discount"}
        If txtProductID.Text = "" Or txtProductTitle.Text = "" Or txtQuantity.Text = "" Or txtSubTotal.Text = "" Then
            MsgBox("Please select details to delete!")
        Else
            Dim value() =
                {txtSalesID.Text.ToString,
                txtProductID.Text.ToString(),
                txtQuantity.Text.ToString(),
                txtSubTotal.Text.ToString(),
                txtDiscount.Text.ToString()
            }
            numQuantity = Val(getRecordSales("Select *from tbl_product", txtProductID.Text, txtProductTitle.Text, "Product_ID", "Product_title", "Quantity"))
            numSalesQuantity = Val(getRecordSales("Select *from tbl_sales_details", txtSalesID.Text, txtProductID.Text, "Sales_Id", "Product_ID", "Quantity"))
            If (Val(txtQuantity.Text) <> numSalesQuantity) Then
                MsgBox("Error: Quantity Must be equal to delete")
            Else
                numQuantity += numSalesQuantity
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtProductID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(salesDetailsQuery, DGSalesDetails)
                MessageBox.Show("Successfully Removed")

                txtDiscountAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "discount").ToString)
                txtSubTotalAll.Text = CDbl(getNumber("Select *from tbl_sales_details where sales_id=" & txtSalesID.Text & "", txtSalesID.Text, "sub_total").ToString)
                txtNetTotal.Text = Val(txtSubTotalAll.Text) - Val(txtDiscountAll.Text)
                clear()
                buttonsStatusDetails()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim hold = ""
        Dim SQL = "update tbl_sales set net_total=@net where sales_id = " & txtSalesID.Text & ""
        Dim val() = {"@id", "@customer", "@payment", "@employee", "@net"}
        Dim value() =
            {txtSalesID.Text.ToString,
             cboCustomer.SelectedValue.ToString,
             cboPayment.SelectedValue.ToString,
             employeeID.ToString,
             txtNetTotal.Text.ToString
        }
        SQLProcess(SQL, val, value)
        hold = getAll(salesDetailsQuery)
        MessageBox.Show(hold & vbCrLf & cboCustomer.Text & vbCrLf & "Net Total:" & txtNetTotal.Text)
        clearAll()
        disableAll()
        refreshTables()
        btnSaveSales.Enabled = True


    End Sub

    Private Sub DGProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducts.CellClick
        Try
            Dim i = e.RowIndex
            With DGProducts
                txtProductID.Text = .Item("id", i).Value
                txtProductTitle.Text = .Item("name", i).Value
                txtProductDescription.Text = .Item("Description", i).Value
                txtPrice.Text = .Item("price", i).Value
            End With
            If checkDuplicate("Select *from tbl_sales_details", "sales_ID", "Product_ID", txtSalesID.Text, txtProductID.Text) Then
                btnUpdate.Enabled = True
                btnAdd.Enabled = False
                btnDelete.Enabled = False
            Else
                btnUpdate.Enabled = False
                btnAdd.Enabled = True
                btnDelete.Enabled = False
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DGsalesDetails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSalesDetails.CellClick
        Try
            Dim i = e.RowIndex
            With DGSalesDetails
                txtProductID.Text = .Item("Product ID", i).Value
                txtProductTitle.Text = .Item("Product Title", i).Value
                txtProductDescription.Text = .Item("Description", i).Value
                txtQuantity.Text = .Item("quantity", i).Value
                txtPrice.Text = .Item("price", i).Value
                txtDiscount.Text = .Item("discount", i).Value
            End With
            btnUpdate.Enabled = True
            btnAdd.Enabled = False
            btnDelete.Enabled = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtPrice_OnValueChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtSubTotal.Text = Val(txtQuantity.Text) * Val(txtPrice.Text)

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim asp As New frmCustomer
        asp.ShowDialog()
        loadToComboBox("Select *from tbl_customer", cboCustomer)
    End Sub

    Private Sub btnAddPayment_Click(sender As Object, e As EventArgs) Handles btnAddPayment.Click
        Dim ap As New frmPayment
        ap.ShowDialog()
        loadToComboBox("Select *from tbl_payment", cboPayment)
    End Sub

    Private Sub cboCustomer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCustomer.SelectedIndexChanged
        Dim i = getRecord("Select *from tbl_customer", cboCustomer.SelectedValue.ToString, "customer_id", "customer_Contact")
        txtCustomerContact.Text = i.ToString
    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged
        Dim discount = 00.0
        If (Val(txtQuantity.Text) >= 5) Then
            discount = Val(txtPrice.Text) * 0.2
            txtDiscount.Text = discount
            txtSubTotal.Text = (Val(txtPrice.Text) * Val(txtQuantity.Text))
        Else
            discount = Val(txtPrice.Text) * 0
            txtDiscount.Text = discount
            txtSubTotal.Text = (Val(txtPrice.Text) * Val(txtQuantity.Text))
        End If
    End Sub

    Private Sub TSSales_Click(sender As Object, e As EventArgs) Handles TSSales.Click
        Dim fal As New frmSalesRecord
        fal.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim fal As New frmLog
        fal.Show()
        Me.Hide()
        employeeID = 0
        employeeName = ""
    End Sub

    Private Sub TSPet_Click(sender As Object, e As EventArgs) Handles TSPet.Click
        Dim fal As New frmAdminLogin
        fal.Show()
        Me.Hide()
    End Sub


End Class
