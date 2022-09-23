Imports MySql.Data.MySqlClient

Module Database
    Private dbConn As MySqlConnection
    Private sqlCommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable

    Private strConn = "server=localhost; user=root; convert zero datetime=True; database="

    Public Sub dbConnection()
        Try
            dbConn = New MySqlConnection(strConn & "db_pos_project")
            'dbConn.ConnectionString = strConn
            dbConn.Open()
            'MessageBox.Show("Test connection successful")
        Catch ex As Exception
            MessageBox.Show("Error 101: dbConnection " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub dbConnection(ByVal DBName As String)
        Try
            dbConn = New MySqlConnection(strConn & DBName)
            'dbConn.ConnectionString = strConn
            dbConn.Open()
            'MessageBox.Show("Test connection successful")
        Catch ex As Exception
            MessageBox.Show("Error 101: dbConnection " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub displayRecords(ByVal SQL As String, ByVal DG As DataGridView)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt) ' da.Fill(DG.DataSource)
            DG.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error 102: displayRecords" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function displayRecords(ByVal SQL As String) As DataTable
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt) ' da.Fill(DG.DataSource)

        Catch ex As Exception
            'MessageBox.Show("Error 102: displayRecords" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return dt
    End Function

    Public Sub loadToComboBox(ByVal SQL As String, ByVal cbo As ComboBox)
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            cbo.DataSource = dt
            cbo.ValueMember = dt.Columns(0).ToString
            cbo.DisplayMember = dt.Columns(1).ToString

        Catch ex As Exception
            MessageBox.Show("Error 103: loadToComboBox" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function loadToComboBox(ByVal SQL As String) As DataTable
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

        Catch ex As Exception
            MessageBox.Show("Error 103: loadToComboBox" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return dt
    End Function

    Public Sub SQLProcess(ByVal SQL As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)
            With sqlCommand
                '.CommandText = SQL
                .CommandType = CommandType.Text
                '.Connection = dbConn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Error 104: SQLProcess" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Sub SQLProcess(ByVal SQL As String, ByVal val() As String, ByVal value() As String)
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(SQL, dbConn)

            With sqlCommand
                Dim i = 0
                For Each record In val
                    .Parameters.AddWithValue(val(i), value(i))
                    i = i + 1
                Next
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show("Error 104: SQLProcess" & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Public Function recordCount(ByVal SQL As String)
        Dim row = 0
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            row = dt.Rows.Count + 1
        Catch ex As Exception
            MessageBox.Show("Error 105: recordCount" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return row
    End Function

    Public Function isFound(ByVal SQL As String, ByVal name As String) As Boolean
        Dim value = ""
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(1)
                If value = name Then
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return found
    End Function
    Public Function isFound(ByVal SQL As String, ByVal name As String, ByVal address As String, ByVal valueItem As String, ByVal addItem As String) As Boolean
        Dim value = "", add = ""
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(valueItem) ' you can use this index specific instead value = row.Item(1)
                add = row.Item(addItem) ' you can use this index specific instead value = row.Item(1)

                If value = name And add = address Then
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return found
    End Function

    Public Function isFoundRow(ByVal SQL As String, ByVal name As String, ByVal field As String) As Boolean
        Dim value = "", add = ""
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(field) ' you can use this index specific instead value = row.Item(1)
                If value = name Then
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return found
    End Function

    Public Function getRecord(ByVal SQL As String, ByVal name As String, ByVal address As String, ByVal valueItem As String, ByVal addItem As String, ByVal retItem As String) As String
        Dim value = "", add = ""
        Dim str = "", wordReturn = ""
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(valueItem) ' you can use this index specific instead value = row.Item(1)
                add = row.Item(addItem) ' you can use this index specific instead value = row.Item(1)
                str = row.Item(retItem)

                If value = name And add = address Then
                    wordReturn = str
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return wordReturn
    End Function


    Public Function getRecordSales(ByVal SQL As String, ByVal name As String, ByVal address As String, ByVal valueItem As String, ByVal addItem As String, ByVal retItem As String) As String
        Dim value = "", add = ""
        Dim str = "", wordReturn = ""
        Try
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(valueItem) ' you can use this index specific instead value = row.Item(1)
                add = row.Item(addItem) ' you can use this index specific instead value = row.Item(1)
                str = row.Item(retItem)

                If value = name And add = address Then
                    wordReturn = str
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return wordReturn
    End Function

    Public Function checkDuplicate(ByVal SQL As String, ByVal column As String, ByVal value As String) As Boolean
        ' Function to check duplication based on an SQL invoked with specified column of a table and a value to be checked [if existing or NOT]
        Dim dup As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strVal = ""

            For Each data In dt.Rows
                strVal = data.Item(column)
                If strVal.ToLower = value.ToLower Then
                    dup = True
                    Exit For
                End If
            Next
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 108: Duplicate" & ex.Message)
        End Try
        Return dup
    End Function

    Public Function checkDuplicate(ByVal SQL As String, ByVal column1 As String, ByVal column2 As String, ByVal value As String, ByVal value2 As String) As Boolean
        ' Function to check duplication based on an SQL invoked with specified column of a table and a value to be checked [if existing or NOT]
        Dim dup As Boolean = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            Dim data As DataRow
            Dim strVal = "", strVal2 = ""

            For Each data In dt.Rows
                strVal = data.Item(column1)
                strVal2 = data.Item(column2)
                If strVal = value And strVal2 = value2 Then
                    dup = True
                    Exit For
                End If
            Next
            'MsgBox(strVal & " " & strVal2)
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 108: Duplicate" & ex.Message)
        End Try
        Return dup
    End Function
    Public Function getRecord(ByVal SQL As String, ByVal name As String, ByVal valueItem As String, ByVal retItem As String) As String
        Dim value = "", add = ""
        Dim str = "", wordReturn = ""
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(valueItem) ' you can use this index specific instead value = row.Item(1)
                str = row.Item(retItem)

                If value = name Then
                    wordReturn = str
                    Exit For
                End If
            Next
        Catch ex As Exception
        Finally
            dbConn.Close()
        End Try
        Return wordReturn
    End Function



    Public Function lastRecord(ByVal SQL As String, ByVal column As String)
        Dim row = 0
        SQL = SQL & " order by " & column & " desc"
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            row = dt.Rows(0).Item(0).ToString
        Catch ex As Exception
            MessageBox.Show("Error 107: lastRecord" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return row
    End Function

    Public Function readLastRecordString(ByVal SQL As String, ByVal column As String) As String
        ' read the last record or value through a column of a table
        Dim count = 0
        Dim value = ""
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            count = dt.Rows.Count - 1
            value = dt.Rows(count).Item(column)
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 107: lastRecord" & ex.Message)
        End Try
        Return value
    End Function



    Public Function readValue(ByVal SQL As String) As DataTable
        ' reads a specific value from your table for manipulation or use for condition
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 108: read value" & ex.Message)
        End Try
        Return dt
    End Function

    Public Function loadToListBox(ByVal SQL As String) As DataTable
        'Accepts SQLSELECT and return Datatable [row/records]
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)
            dbConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error 108: Load to ListBox & ex.Message")
        End Try
        Return dt
    End Function

    Public Function getNumber(ByVal SQL As String, ByVal name As String, ByVal field As String) As String
        Dim value = "", add = "", sum = 0.00
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(field) ' you can use this index specific instead value = row.Item(1)
                sum += CDbl(value.ToString)
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return sum
    End Function

    Public Function getAll(ByVal SQL As String) As String
        Dim pname = "", description = "", quantity = "", price = "", subtotal = "", hold = "Product Name  Description  Quantity   Price   Sub Total" & vbCrLf
        Dim found = False
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(SQL, dbConn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                pname = row.Item("Product Title") ' you can use this index specific instead value = row.Item(1)
                description = row.Item("Description")
                quantity = row.Item("Quantity")
                price = row.Item("Price")
                subtotal = row.Item("Sub total")
                hold += pname.ToString & "    " & description.ToString & "    " & quantity.ToString & "    " & price.ToString & "    " & subtotal.ToString & vbCrLf
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        Return hold
    End Function


End Module