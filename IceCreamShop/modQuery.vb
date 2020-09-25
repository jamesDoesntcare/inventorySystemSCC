Module modquery

    Public Sub PopulateProducts(ByVal lv As ListView, ByVal orderBy As String)
        Connected()
        With lv
            .Items.Clear()
            sql = "SELECT * FROM Item"
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("Item_ID"))
                    .SubItems.Add(dr("Item_Brand"))
                    .SubItems.Add(dr("Item_Type"))
                    .SubItems.Add(dr("Item_price"))
                    .SubItems.Add(dr("Item_Date Purchased"))
                    .SubItems.Add(dr("Item_Quantity"))
                    .SubItems.Add(dr("Item_Unit Price"))
                    .SubItems.Add(dr("Item_Supplier"))
                    .SubItems.Add(dr("Item_Location"))
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
        sql = " SELECT distinct item_type FROM item"
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
        sql = " SELECT * FROM item WHERE item_brand LIKE " & key & " or item_type LIKE " & key & " order by " & orderBy & ""
        CommandDB()
        dr = cmd.ExecuteReader()
        lv.Items.Clear()
        While (dr.Read())
            With lv.Items.Add(dr("item_id"))
                .SubItems.Add(dr("item_brand"))
                .SubItems.Add(dr("item_datepurchase"))
                .SubItems.Add(dr("item_quantity"))
                .SubItems.Add(dr("item_supplier"))
                .SubItems.Add(dr("item_type"))
                .SubItems.Add(dr("item_userID"))
                .SubItems.Add(dr("item_location"))
                .SubItems.Add(dr("item_status"))
            End With

        End While
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
