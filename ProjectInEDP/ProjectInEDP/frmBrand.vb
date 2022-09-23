Public Class frmBrand
    Dim strQuery = "Select *from tbl_brand"
    Private Sub frmbrand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbConnection()
        displayRecords(strQuery, DGBrand)
        buttonsStatus()
        clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_brand values(@id,@title)"
        Dim val() = {"@id", "@title"}
        Dim value() =
            {txtID.Text.ToString,
             txtBrand.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGBrand)
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_brand set brand_title=@title where brand_id=" & txtID.Text & ""
        Dim val() = {"@id", "@title"}
        Dim value() =
            {txtID.Text.ToString,
             txtBrand.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGBrand)
        buttonsStatus()
        clear()
    End Sub

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtID.Text = ""
        txtBrand.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub DGbrand_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGBrand.CellClick
        Try
            Dim i = e.RowIndex
            With DGBrand
                txtID.Text = .Item("brand_id", i).Value
                txtBrand.Text = .Item("brand_title", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from tbl_brand where brand_title like '%" & txtSearch.Text & "%' or brand_id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGBrand)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlProduct.DoubleClick
        clear()
        buttonsStatus()
    End Sub


End Class