Module SalesModule
    Sub updateStockInDatabase(ByVal newStock As Integer, ByVal prodname As String)
        Connected()
        sql = "UPDATE Item SET item_stock = " & newStock & " where item_brand = '" & prodname & "'"
        CommandDB()
        cmd.ExecuteNonQuery()
    End Sub

    Public Function getProductStock(ByVal prodname) As Integer
        Connected()
        Dim stock As Integer
        sql = "SELECT item_stock FROM Item where item_brand = '" & prodname & "'"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                stock = dr.Item(0)
            Loop
        End If
        Return stock
    End Function

    Public Function GenerateOrderNo() As String
        Connected()
        Dim str As String = ""
        sql = "SELECT Max(ORno) FROM tblsales"
        CommandDB()
        dr = cmd.ExecuteReader()
        If dr.HasRows Then
            Do While dr.Read()
                str = dr.Item(0).ToString.Substring(2) + 1
            Loop
        End If
        Return "OR" & str
    End Function
End Module
