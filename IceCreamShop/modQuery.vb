Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports System.Configuration
Imports System.Data.SqlClient
Module modquery


    Public Sub PopulateProductsPOS(ByVal lv As ListView, ByVal orderBy As String)
        Connected()
        With lv
            .Items.Clear()
            sql = "SELECT * from Item"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("item_id"))
                    .SubItems.Add(dr("item_type"))
                    .SubItems.Add(dr("item_brand"))
                    .SubItems.Add(dr("item_stock"))
                    .SubItems.Add(dr("item_datepurchase"))
                    .SubItems.Add(dr("item_location"))
                    .SubItems.Add(dr("item_status"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateProducts(ByVal lv As ListView, ByVal orderBy As String)
        Connected()
        With lv
            .Items.Clear()
            sql = "SELECT * from Item"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("item_id"))
                    .SubItems.Add(dr("item_type"))
                    .SubItems.Add(dr("item_brand"))
                    .SubItems.Add(dr("SN"))
                    .SubItems.Add(dr("item_price"))
                    .SubItems.Add(dr("item_stock"))
                    .SubItems.Add(dr("item_datepurchase"))
                    .SubItems.Add(dr("item_location"))
                    .SubItems.Add(dr("item_status"))
                    .SubItems.Add(dr("item_supplier"))
                End With
            End While
        End With
    End Sub

    Public Sub PopulateTotalSales(ByVal lv As ListView)
        Connected()
        With lv
            .Items.Clear()
            sql = " SELECT * FROM tblsales"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("id"))
                    .SubItems.Add(dr("ORno"))
                    .SubItems.Add(dr("customer_name"))
                    .SubItems.Add(dr("prod_name"))
                    .SubItems.Add(dr("prod_price"))
                    .SubItems.Add(dr("prod_qty"))
                    .SubItems.Add(dr("prod_subtotal"))
                    .SubItems.Add(dr("date_order"))
                End With
            End While
        End With
    End Sub

    Function getTotalSales() As Double
        Connected()
        sql = " SELECT sum(prod_subtotal) FROM tblsales"
        CommandDB()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            Return dr(0)
        End While
    End Function


    Public Sub PopulateCategory(ByVal cbo As ComboBox)
        Connected()
        cbo.Items.Clear()
        sql = " SELECT distinct item_type FROM Item"
        CommandDB()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            cbo.Items.Add(dr(0))

        End While
    End Sub

    Public Sub SearchProduct(ByVal lv As ListView, ByVal search As String, Optional ByVal orderBy As String = "id")
        Connected()
        Dim result As String = ""
        Dim key As String = "'%" & search & "%'"
        sql = " SELECT * FROM item WHERE item_brand LIKE " & key & " or item_type LIKE " & key & ""
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("item_id"))
                .SubItems.Add(dr("item_type"))
                .SubItems.Add(dr("item_brand"))
                .SubItems.Add(dr("SN"))
                .SubItems.Add(dr("item_price"))
                .SubItems.Add(dr("item_stock"))
                .SubItems.Add(dr("item_datepurchase"))
                .SubItems.Add(dr("item_location"))
                .SubItems.Add(dr("item_status"))
                .SubItems.Add(dr("item_supplier"))
            End With

        End While
    End Sub
    Public Sub PopulateEmployee()
        Dim sqlconn As New OleDb.OleDbConnection
        Dim sqlquery As New OleDb.OleDbCommand
        Dim connString As String
        Dim cmdDelete As New OleDbCommand
        Dim cmdUpdate As New OleDbCommand
        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\icecream.mdb"
        sqlconn.ConnectionString = connString
        sqlquery.Connection = sqlconn
        sqlconn.Open()
        Dim adp As OleDbDataAdapter = New OleDbDataAdapter("SELECT emp_Id, emp_lastname FROM Employee", sqlconn)
        'Fill the DataTable with records from Table.
        Dim dt As DataTable = New DataTable()
        adp.Fill(dt)

        'Insert the Default Item to DataTable.
        Dim row As DataRow = dt.NewRow()
        row(0) = 0
        row(1) = "Please select"
        dt.Rows.InsertAt(row, 0)

        'Assign DataTable as DataSource.
        frmPOS.cboEmployee.DataSource = dt
        frmPOS.cboEmployee.DisplayMember = "emp_lastname"
        frmPOS.cboEmployee.ValueMember = "emp_Id"
        sqlconn.Close()
    End Sub
    Public Function IsProductExist(ByVal tbl As String, ByVal field As String, ByVal str As String) As Boolean
        Connected()
        sql = "Select COUNT(*) FROM " & tbl & " WHERE " & field & " = '" & str & "'"
        CommandDB()
        Dim rows As Integer = cmd.ExecuteScalar()
        If rows > 0 Then
            Return True
        Else
            Return False
        End If
    End Function



End Module
