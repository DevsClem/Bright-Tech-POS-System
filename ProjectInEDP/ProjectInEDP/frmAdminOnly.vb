Public Class frmAdminOnly
    Public Property adminID As String
    Dim strQuery = ""
    Dim productQuery = "Select p.product_id as 'ID',p.product_title as 'Name',c.category_title as 'Category',b.brand_title as 'Brand',p.product_price as 'Price',p.quantity as 'Quantity',p.product_description as 'Description' from tbl_product p join tbl_category c on p.category_id = c.category_id join tbl_brand b on p.brand_id=b.brand_id order by Product_id asc"
    Dim stockOutQuery = "Select s.stockout_id as 'ID', s.stockout_Date as 'Date',p.product_id as 'Product ID',p.product_title as 'Product Name', e.employee_name as 'Employee Name' , s.quantity as 'Quantity', s.remarks as 'Remarks' from tbl_stockout s join tbl_admin a on s.admin_id = a.admin_id join tbl_employee e on e.employee_id=e.employee_id join tbl_product p on s.product_id=p.product_id order by s.stockout_id asc"
    Dim employeeQuery = "Select e.employee_id as 'Employee ID', e.employee_name as 'Name', e.employee_contact as 'Contact', g.gender_title as 'Gender', e.employee_birthdate as 'Birthdate', e.employee_address as 'Address' from tbl_employee e join tbl_gender g on e.gender_id = g.gender_id"
    'Dim stockinQuery = "Select s.supply_id as 'ID',s.supply_date as 'Supply Date',e.employee_name as 'Employee Name',ss.supplier_name as 'Supplier' from tbl_supply s join tbl_admin a on s.admin_id=a.admin_id join tbl_employee e on a.employee_id=e.employee_id join tbl_supplier ss on ss.supplier_id=s.supplier_id order by s.supply_id asc"
    Dim wrapper As New Simple3Des()
    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConnection()

        txtProductID.Enabled = False
        loadToComboBox("Select *from tbl_category", cboCategory) 'Product panel category combobox
        loadToComboBox("Select *from tbl_brand", cboBrand)  'Product panel brand combobox
        loadToComboBox("Select *from tbl_gender", cboEmpGender) 'Employee panel gender combobox
        'loadToComboBox("Select *from tbl_Supplier", cboSupplier) 'Stockin panel gender combobox
        refreshPanels()
    End Sub

    'Panel Buttons for changing panels
    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        pnlEmployee.Visible = False
        pnlProduct.Visible = True
        pnlStockout.Visible = False
        buttonsStatus()
        clear()
        buttonsStatusEmployee()
        clearEmployee()
        refreshPanels()
    End Sub
    Private Sub btnEmployee_Click(sender As Object, e As EventArgs) Handles btnEmployee.Click
        pnlEmployee.Visible = True
        pnlProduct.Visible = False
        pnlStockout.Visible = False

        refreshButtonsFields()
        refreshPanels()
    End Sub

    Private Sub btnStockout_Click(sender As Object, e As EventArgs) Handles btnStockout.Click
        pnlEmployee.Visible = False
        pnlProduct.Visible = False
        pnlStockout.Visible = True
        buttonsStatus()
        clear()
        buttonsStatusEmployee()
        clearEmployee()
    End Sub

    Private Sub btnStockin_Click(sender As Object, e As EventArgs) Handles btnStockin.Click
        Dim fsn As New frmStockin
        fsn.adminID = Me.adminID
        fsn.Show()
        refreshButtonsFields()
        refreshPanels()
    End Sub

    Private Sub refreshPanels()
        displayRecords(productQuery, DGProducts) 'Product panel product datagrid
        displayRecords(employeeQuery, DGEmployee) 'Employee panel employeee datagrid
        displayRecords(productQuery, DGProductOut) 'Stockout panel product for stockout datagrid
        displayRecords(stockOutQuery, DGStockout) 'Stockout panel product for stockout datagrid
        'displayRecords(stockinQuery, DGStockin) 'Stockin panel datagrid
    End Sub

    Private Sub refreshButtonsFields()
        clear()
        buttonsStatus()
        clearEmployee()
        buttonsStatusEmployee()
        clearStockout()
        buttonsStatusStockout()


    End Sub


    'Start of Product Panel

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtProductID.Text = ""
        txtProductName.Text = ""
        cboCategory.SelectedIndex = 0
        cboBrand.SelectedIndex = 0
        txtProductPrice.Text = ""
        txtProductQuantity.Text = ""
        txtProductDescription.Text = ""
    End Sub

    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub frmAdmin_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDoubleClick
        clear()
        buttonsStatus()
    End Sub

    Private Sub txtProductSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged, txtProductSearch.TextChanged
        strQuery = "Select *from joinproducts where name like '%" & txtProductSearch.Text & "%' or id like '%" & txtProductSearch.Text & "%'"
        displayRecords(strQuery, DGProducts)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlProduct.DoubleClick
        clear()
        buttonsStatus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_product values(@id,@name,@category,@brand,@price,@quantity,@description)"
        Dim val() = {"@id", "@name", "@category", "@brand", "@price", "@quantity", "@description"}
        Dim value() =
            {txtProductID.Text.ToString,
             txtProductName.Text.ToString,
             cboCategory.SelectedValue.ToString,
             cboBrand.SelectedValue.ToString,
             txtProductPrice.Text.ToString,
             txtProductQuantity.Text.ToString,
             txtProductDescription.Text.ToString}
        SQLProcess(SQL, val, value)
        displayRecords(productQuery, DGProducts)
        MessageBox.Show("Successfully Saved")
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_product set product_title=@name,category_id=@category,brand_id=@brand,product_price=@price,quantity=@quantity,product_description=@description where product_id=" & txtProductID.Text & ""
        Dim val() = {"@id", "@name", "@category", "@brand", "@price", "@quantity", "@description"}
        Dim value() =
            {txtProductID.Text.ToString,
             txtProductName.Text.ToString,
             cboCategory.SelectedValue.ToString,
             cboBrand.SelectedValue.ToString,
             txtProductPrice.Text.ToString,
             txtProductQuantity.Text.ToString,
             txtProductDescription.Text.ToString}
        SQLProcess(SQL, val, value)
        displayRecords(productQuery, DGProducts)
        buttonsStatus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub

    Private Sub DGProducts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProducts.CellClick
        Try
            Dim i = e.RowIndex
            With DGProducts
                txtProductID.Text = .Item("id", i).Value
                txtProductName.Text = .Item("name", i).Value
                cboCategory.Text = .Item("category", i).Value
                cboBrand.Text = .Item("brand", i).Value
                txtProductPrice.Text = .Item("price", i).Value
                txtProductQuantity.Text = .Item("Quantity", i).Value
                txtProductDescription.Text = .Item("description", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
            txtProductQuantity.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddCategory_Click(sender As Object, e As EventArgs) Handles btnAddCategory.Click
        Dim cat As New frmCategory
        cat.ShowDialog()
        loadToComboBox("Select *from tbl_category", cboCategory)
    End Sub

    Private Sub btnAddBrand_Click(sender As Object, e As EventArgs) Handles btnAddBrand.Click
        Dim br As New frmBrand
        br.ShowDialog()
        'Dim vals = "safe"
        ' Dim row = CInt(recordCount("Select status_id from tbl_status"))
        'Dim SQL = "insert into tbl_status values(" & row & ",'" & vals & "')"
        'SQLProcess(SQL)
        ' Dim SQL2 = "insert into tbl_pet_status values(" & row & ")"
        'SQLProcess(SQL2)
        loadToComboBox("Select *from tbl_brand", cboBrand)
    End Sub


    'End of Product Panel
    'Start of Employee Panel

    Private Sub clearEmployee() ' Clear employee Textfields
        txtEmpID.Text = ""
        txtEmpName.Text = ""
        txtEmpContact.Text = ""
        cboEmpGender.SelectedIndex = 0
        'dprEmpBirthDate.Value = Now
        txtEmpAddress.Text = ""
    End Sub

    Private Sub buttonsStatusEmployee() 'Return employee buttons to normal state
        btnEmpSave.Enabled = True
        btnEmpUpdate.Enabled = False
    End Sub

    Private Sub pnlEmployee_DoubleClick(sender As Object, e As EventArgs) Handles pnlEmployee.DoubleClick
        clearEmployee()
        buttonsStatusEmployee()
    End Sub

    Private Sub btnEmpSave_Click(sender As Object, e As EventArgs) Handles btnEmpSave.Click
        Dim SQL = "insert into tbl_Employee values(@id,@name,@contact,@gender,@birthdate,@address,@password)"
        Dim val() = {"@id", "@name", "@contact", "@gender", "@birthdate", "@address", "@password"}
        Dim value() =
            {txtEmpID.Text.ToString,
             txtEmpName.Text.ToString,
             txtEmpContact.Text.ToString,
             cboEmpGender.SelectedValue.ToString,
             dprEmpBirthDate.Text.ToString,
             txtEmpAddress.Text.ToString,
             wrapper.EncryptData(txtPassword.Text.ToString)
        }
        SQLProcess(SQL, val, value)
        displayRecords(employeeQuery, DGEmployee)
        clearEmployee()
        buttonsStatusEmployee()
    End Sub

    Private Sub btnEmpClear_Click(sender As Object, e As EventArgs) Handles btnEmpClear.Click
        clearEmployee()
        buttonsStatusEmployee()
    End Sub

    Private Sub btnEmpUpdate_Click(sender As Object, e As EventArgs) Handles btnEmpUpdate.Click
        Dim SQL = "update tbl_employee set employee_name=@name,employee_contact=@contact,gender_id=@gender,employee_birthdate=@birthdate,employee_address=@address where employee_id=" & txtEmpID.Text & ""
        Dim val() = {"@id", "@name", "@contact", "@gender", "@birthdate", "@address"}
        Dim value() =
        {txtEmpID.Text.ToString,
         txtEmpName.Text.ToString,
         txtEmpContact.Text.ToString,
         cboEmpGender.SelectedValue.ToString,
         dprEmpBirthDate.Text.ToString,
         txtEmpAddress.Text.ToString}
        SQLProcess(SQL, val, value)
        displayRecords(employeeQuery, DGEmployee)
        clearEmployee()
        buttonsStatusEmployee()
        MessageBox.Show("Successfully Saved")
    End Sub

    Private Sub DGEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGEmployee.CellClick
        Try
            Dim i = e.RowIndex
            With DGEmployee
                txtEmpID.Text = .Item("Employee ID", i).Value
                txtEmpName.Text = .Item("name", i).Value
                txtEmpContact.Text = .Item("contact", i).Value
                cboEmpGender.Text = .Item("gender", i).Value
                dprEmpBirthDate.Text = .Item("birthdate", i).Value
                txtEmpAddress.Text = .Item("address", i).Value

            End With
            btnEmpUpdate.Enabled = True
            btnEmpSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    'End of Employee Panel

    Private Sub clearStockout() ' Clear employee Textfields
        txtOutID.Text = ""
        'dprStockoutDate.Value = Now()
        txtOutProdID.Text = ""
        txtOutProduct.Text = ""
        txtOutQuantity.Text = ""
        txtOutRemarks.Text = ""
    End Sub

    Private Sub buttonsStatusStockout() 'Return employee buttons to normal state
        btnOutSave.Enabled = True
        btnOutUpdate.Enabled = False
    End Sub

    Private Sub pnlStockout_DoubleClick(sender As Object, e As EventArgs) Handles pnlStockout.DoubleClick
        clearStockout()
        buttonsStatusStockout()
    End Sub

    Private Sub btnOutSave_Click(sender As Object, e As EventArgs) Handles btnOutSave.Click
        Dim numQuantity = 0, SQL2 = ""
        Dim SQL = "insert into tbl_stockout values(@id,@date,@adminID,@productID,@quantity,@remarks)"
        Dim vals() = {"@id", "@date", "@adminID", "@productID", "@quantity", "@remarks"}


        If txtOutProdID.Text = "" Or txtOutProduct.Text = "" Or txtOutQuantity.Text = "" Or txtOutRemarks.Text = "" Then
            MsgBox("Please Complete the form!")
        Else
            Dim value() =
                {txtOutID.Text.ToString,
                dprStockoutDate.Text.ToString(),
                adminID.ToString,
                txtOutProdID.Text.ToString(),
                txtOutQuantity.Text.ToString(),
                txtOutRemarks.Text.ToString()}
            numQuantity = Val(getRecord("Select *from tbl_product", txtOutProdID.Text, txtOutProduct.Text, "Product_ID", "Product_title", "Quantity"))
            If (Val(txtOutQuantity.Text) > numQuantity) Then
                MsgBox("Error: Quantity set is greater than quantity in record")
            Else
                numQuantity -= Val(txtOutQuantity.Text)
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtOutProdID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(stockOutQuery, DGStockout)
                displayRecords(productQuery, DGProducts)
                displayRecords(productQuery, DGProductOut)
                clearStockout()
                buttonsStatusStockout()
                MessageBox.Show("Successfully Saved")
            End If
        End If
    End Sub

    Private Sub btnOutClear_Click(sender As Object, e As EventArgs) Handles btnOutClear.Click
        clearStockout()
        buttonsStatusStockout()

    End Sub

    Private Sub btnOutUpdate_Click(sender As Object, e As EventArgs) Handles btnOutUpdate.Click
        Dim numQuantity = 0, numUpdatedQuantity = 0, SQL2 = "", numAnswer = 0
        Dim SQL = "update tbl_stockout set stockout_date=@date,product_id=@productID,quantity=@quantity,remarks=@remarks where stockout_id=" & txtOutID.Text & ""
        Dim vals() = {"@id", "@date", "@adminID", "@productID", "@quantity", "@remarks"}

        If txtOutProdID.Text = "" Or txtOutProduct.Text = "" Or txtOutQuantity.Text = "" Or txtOutRemarks.Text = "" Then
            MsgBox("Please Complete the form!")
        Else
            numQuantity = Val(getRecord("Select *from tbl_product", txtOutProdID.Text, txtOutProduct.Text, "Product_ID", "Product_title", "Quantity"))
            numUpdatedQuantity = Val(getRecord("Select *from tbl_stockout", txtOutID.Text, "Stockout_ID", "Quantity"))
            MsgBox(numUpdatedQuantity.ToString)
            Dim value() =
                {txtOutID.Text.ToString,
                dprStockoutDate.Text.ToString(),
                adminID.ToString,
                txtOutProdID.Text.ToString(),
                txtOutQuantity.Text.ToString(),
                txtOutRemarks.Text.ToString()}

            If (Val(txtOutQuantity.Text) > numQuantity) Then
                MsgBox("Error: Quantity set is greater than quantity in record")
            ElseIf Val(txtOutQuantity.Text) = numUpdatedQuantity Then
                SQLProcess(SQL, vals, value)
                displayRecords(stockOutQuery, DGStockout)
                displayRecords(productQuery, DGProductOut)
                clearStockout()
                buttonsStatusStockout()
                MessageBox.Show("Successfully Saved")
            ElseIf numUpdatedQuantity < Val(txtOutQuantity.Text) Then
                numQuantity -= (Val(txtOutQuantity.Text) - numUpdatedQuantity)
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtOutProdID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(stockOutQuery, DGStockout)
                displayRecords(productQuery, DGProductOut)
                clearStockout()
                buttonsStatusStockout()
                MessageBox.Show("Successfully Saved")
            ElseIf numUpdatedQuantity > Val(txtOutQuantity.Text) Then
                numQuantity += (numUpdatedQuantity - Val(txtOutQuantity.Text))
                SQL2 = "update tbl_product set Quantity=" & numQuantity & " where product_id = " & txtOutProdID.Text & ""
                SQLProcess(SQL, vals, value)
                SQLProcess(SQL2)
                displayRecords(stockOutQuery, DGStockout)
                displayRecords(productQuery, DGProductOut)
                clearStockout()
                buttonsStatusStockout()
                MessageBox.Show("Successfully Saved")
            End If
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from joinproducts where name like '%" & txtSearch.Text & "%' or id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGProductOut)
    End Sub

    Private Sub txtStockoutSearch_TextChanged(sender As Object, e As EventArgs) Handles txtStockoutSearch.TextChanged
        strQuery = "Select *from joinstockout where 'product name' like '%" & txtStockoutSearch.Text & "%' or id like '%" & txtStockoutSearch.Text & "%'"
        displayRecords(strQuery, DGStockout)
    End Sub

    Private Sub DGProductOut_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGProductOut.CellClick
        Try
            Dim i = e.RowIndex
            With DGProductOut
                txtOutProdID.Text = .Item("id", i).Value
                txtOutProduct.Text = .Item("name", i).Value
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub DGStockout_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGStockout.CellClick
        Try
            Dim i = e.RowIndex
            With DGStockout
                txtOutID.Text = .Item("id", i).Value
                dprEmpBirthDate.Text = .Item("date", i).Value
                txtOutProdID.Text = .Item("Product ID", i).Value
                txtOutProduct.Text = .Item("Product Name", i).Value
                txtOutQuantity.Text = .Item("Quantity", i).Value
                txtOutRemarks.Text = .Item("Remarks", i).Value
            End With
            btnOutUpdate.Enabled = True
            btnOutSave.Enabled = False

        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim home As New frmHome
        home.employeeID = adminID
        home.employeeName = getRecord("Select *from tbl_Employee", home.employeeID, "Employee_id", "Employee_Name")
        home.Show()
        Me.Hide()
    End Sub




    'End of StockoutPanel Panel


End Class
