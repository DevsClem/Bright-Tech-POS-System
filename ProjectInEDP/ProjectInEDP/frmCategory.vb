Public Class frmCategory
    Dim strQuery = "Select *from tbl_category"
    Private Sub frmCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.CenterScreen
        dbConnection()
        displayRecords(strQuery, DGCategory)
        buttonsStatus()
        clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim SQL = "insert into tbl_category values(@id,@title,@description)"
        Dim val() = {"@id", "@title", "@description"}
        Dim value() =
            {txtID.Text.ToString,
             txtCategory.Text.ToString,
             txtDescription.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGCategory)
        buttonsStatus()
        clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim SQL = "update tbl_category set category_title=@title,category_description=@description where category_id=" & txtID.Text & ""
        Dim val() = {"@id", "@title", "@description"}
        Dim value() =
            {txtID.Text.ToString,
             txtCategory.Text.ToString,
             txtDescription.Text.ToString
            }
        SQLProcess(SQL, val, value)
        displayRecords(strQuery, DGCategory)
        buttonsStatus()
        clear()
    End Sub

    Private Sub clear() ' Clear necessary textfields every after transaction is performed
        txtID.Text = ""
        txtCategory.Text = ""
        txtDescription.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
    End Sub
    Private Sub buttonsStatus() ' Enabling and disabling buttons 
        btnSave.Enabled = True
        btnUpdate.Enabled = False
    End Sub

    Private Sub DGCategory_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCategory.CellClick
        Try
            Dim i = e.RowIndex
            With DGCategory
                txtID.Text = .Item("category_id", i).Value
                txtCategory.Text = .Item("category_title", i).Value
                txtDescription.Text = .Item("category_description", i).Value
            End With
            btnUpdate.Enabled = True
            btnSave.Enabled = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        strQuery = "Select *from tbl_category where category_title like '%" & txtSearch.Text & "%' or category_id like '%" & txtSearch.Text & "%'"
        displayRecords(strQuery, DGCategory)
    End Sub

    Private Sub pnlProduct_DoubleClick(sender As Object, e As EventArgs) Handles pnlProduct.DoubleClick
        clear()
        buttonsStatus()
    End Sub


End Class