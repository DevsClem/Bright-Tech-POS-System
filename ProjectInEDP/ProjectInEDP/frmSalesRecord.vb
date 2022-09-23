Public Class frmSalesRecord
    Dim salesQuery = "Select s.sales_id as 'ID',c.customer_name as 'Customer',p.payment_method as 'Payment Method', e.employee_name as 'Employee Name',s.sales_date as 'Date Time', s.net_total as 'Net Total' from tbl_sales s join tbl_customer c on s.customer_id=c.customer_id join tbl_payment p on s.payment_id=p.payment_id join tbl_employee e on s.employee_id=e.employee_id order by sales_id asc"
    Dim salesDetailsQuery = "Select s.sales_id as 'Sales ID',p.product_id as 'Product ID',p.product_title as 'Product Title',p.product_description as 'Description',s.quantity as 'Quantity',p.product_price as 'Price', s.quantity*p.product_price as 'Sub Total', s.discount as 'Discount' from tbl_sales_details s join tbl_product p on s.product_id=p.product_id order by s.sales_id asc"
    Private Sub frmSalesRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        refreshTables()
    End Sub

    Private Sub refreshTables() ' Refresh all three tables 
        displayRecords(salesQuery, DGSales)
        displayRecords(salesDetailsQuery, DGSalesDetails)
    End Sub

    Private Sub DGSales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGSales.CellClick
        Dim id = ""
        Try
            Dim i = e.RowIndex
            With DGSales
                id = .Item("id", i).Value
            End With
            salesDetailsQuery = "Select s.sales_id as 'Sales ID',p.product_id as 'Product ID',p.product_title as 'Product Title',p.product_description as 'Description',s.quantity as 'Quantity',p.product_price as 'Price', s.sub_total as 'Sub Total', s.discount as 'Discount' from tbl_sales_details s join tbl_product p on s.product_id=p.product_id where sales_id=" & id & ""
            displayRecords(salesDetailsQuery, DGSalesDetails)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtProductSearch_TextChanged(sender As Object, e As EventArgs) Handles txtProductSearch.TextChanged
        Dim strQuery = "Select *from joinsales where id like '%" & txtProductSearch.Text & "%' or 'sales date' like '%" & txtProductSearch.Text & "%'"
        displayRecords(strQuery, DGSales)
    End Sub

    Private Sub frmSalesRecord_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        dbConnection()
        salesDetailsQuery = "Select s.sales_id as 'Sales ID',p.product_id as 'Product ID',p.product_title as 'Product Title',p.product_description as 'Description',s.quantity as 'Quantity',p.product_price as 'Price', s.quantity*p.product_price as 'Sub Total', s.discount as 'Discount' from tbl_sales_details s join tbl_product p on s.product_id=p.product_id order by s.sales_id asc"
        refreshTables()
    End Sub
End Class