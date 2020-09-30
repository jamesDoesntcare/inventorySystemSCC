Imports kitchanismo

Public Class frmPOS

    Dim id As Integer
    Dim itemID As Integer
    Dim itemType As String
    Dim itemname As String
    Dim itemprice As Double
    Dim itemstock As Integer
    Dim enterQty As Integer
    Dim subtotal As Double
    Dim enterSN As Integer

    Dim moveObject As New MoveObject
    Dim pos As Point

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        pos = moveObject.GetLocation(Me)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Me.Location = moveObject.SetLocation(pos, MousePosition)
        End If
    End Sub

    Private Sub frmOrdering_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If lvorder.Items.Count <> 0 Then
            Dim i As Integer = MsgBox("Order List will be clear, Exit anyway?", MsgBoxStyle.YesNo)
            If i = MsgBoxResult.Yes Then
                CancelTransaction()
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub frmOrdering_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'load all products in listview
        btncancel.Enabled = False
        PopulateProductsPOS(lvProducts, getSortby())
        PopulateEmployee()
        doChangeListViewColor(lvProducts)
        toggleBtnEnabbled()
        setNotif("Double click an item to add and return a products", Alert.Info)
    End Sub

    Private Sub lvProducts_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lvProducts.KeyDown
        If e.KeyCode = Keys.Enter Then
            EnterQuantity()
        End If
    End Sub

    Private Sub lvProducts_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvProducts.MouseDoubleClick
        EnterQuantity()
    End Sub

    Sub EnterQuantity()
        'assign data from listview to variables
        With lvProducts.SelectedItems(0)
            id = .SubItems(0).Text
            itemType = .SubItems(1).Text
            itemname = .SubItems(2).Text
            itemstock = .SubItems(3).Text
        End With

        If itemstock <= 0 Then
            setNotif("Out of Stock!", Alert.Warning)
            Exit Sub
        End If

        'enter qty order
        enterQty = Val(InputBox("Product name: " & itemname & vbNewLine & "Product Available Stock: " & itemstock, "Enter Quantity".ToUpper, 1))
        If enterQty = Nothing Then
            Exit Sub
        End If

        If getProductStock(itemname) < getQuantityOrder(itemname, enterQty) Or enterQty > getQuantityOrder(itemname, enterQty) Then
            setNotif("There is no enough Stock!", Alert.Warning)
            Exit Sub
        End If

        enterSN = Val(InputBox("Product name: " & id & vbNewLine & "Product Name: " & itemname, "Enter Serial Number".ToUpper, 1))
        If enterSN = Nothing Then
            setNotif("There is no enough Stock!", Alert.Warning)
        End If




        'enable button cancel transaction 
        btncancel.Enabled = True

        'compute subtotal
        subtotal = enterQty * itemprice

        'add Quantity and Subtotal in listview Order
        updateQtyListOrder(enterQty, subtotal)

        'update total, change & no of items
        'lbltotal.Text = ComputeCollumn(3)
        'lblitems.Text = ComputeCollumn(2)
        'lblchange.Text = ComputeChange(Val(tbcash.Text), lbltotal.Text)

        toggleBtnEnabbled()
        setNotif("Added " & enterQty & " " & itemname.ToUpper, Alert.Info)
    End Sub

    Private Sub lvorder_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lvorder.MouseDoubleClick
        'get require data in lvorder
        Dim qtyorder As Integer
        Dim newsubtotal As Integer

        With lvorder.SelectedItems(0)
            itemID = .SubItems(1).Text
            itemname = .SubItems(2).Text
            qtyorder = .SubItems(3).Text
        End With

        Dim enterOrder As Integer = Val(InputBox("Product name: " & itemname & vbNewLine & "", "Enter Quantity Return".ToUpper, 1))
        If enterOrder = Nothing Then
            Exit Sub
        End If

        If Val(qtyorder) < Val(enterOrder) Then
            setNotif("Quantity return is more than quantity ordered!", Alert.Warning)
            Exit Sub
        End If



        'update new subtotal
        newsubtotal = enterOrder * itemprice

        'minus Quantity and Subtotal in listview Order
        updateQtyListOrder(-enterOrder, -newsubtotal)

        'update total, change & no of items
        'lbltotal.Text = ComputeCollumn(3)
        'lblitems.Text = ComputeCollumn(2)
        'lblchange.Text = ComputeChange(Val(tbcash.Text), Val(lbltotal.Text)).ToString("N")

        toggleBtnEnabbled()
        setNotif("Returned " & enterOrder & " " & itemname.ToUpper, Alert.Info)
    End Sub

    Private Sub tbcash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            doPurchase()
        End If
    End Sub

    Private Sub tbcash_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'lblchange.Text = ComputeChange(Val(tbcash.Text), Val(lbltotal.Text)).ToString("N")
    End Sub

    Private Sub btnpay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPurchase.Click
        doPurchase()
    End Sub

    Sub toggleBtnEnabbled()
        btnPurchase.Enabled = IsEnabledBtn()
        btncancel.Enabled = IsEnabledBtn()
    End Sub

    Function IsEnabledBtn() As Boolean
        If lvorder.Items.Count = 0 Then
            Return False
        Else
            Return True
        End If
    End Function


    Sub doPurchase()
        If lvorder.Items.Count = 0 Then
            Exit Sub
        End If

        'If Val(tbcash.Text) < Val(lbltotal.Text) Then
        '    setNotif("Insufficient Cash!", Alert.Warning)
        '    Exit Sub
        'End If

        Me.Enabled = False
        Dim confirm = MsgBox("Proceed?" & vbNewLine & vbNewLine &
               "Transaction No: " & lblOrno.Text.ToUpper & vbNewLine &
               "Employee Name: " & cboEmployee.Text.ToUpper & vbNewLine _
               , MsgBoxStyle.YesNo, "SCC Inventory System")

        If confirm = MsgBoxResult.No Then
            Me.Enabled = True
            Exit Sub
        End If

        saveSales(lvorder)
        mapStock()
        PopulateProductsPOS(lvProducts, getSortby())
        doChangeListViewColor(lvProducts)
        resetOrder()
        toggleBtnEnabbled()
        setNotif("Successfully Purchased!", Alert.Success)
        Me.Enabled = True
    End Sub

    Private Sub tbsearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbsearch.TextChanged
        SearchProduct(lvProducts, tbsearch.Text, getSortby())
        doChangeListViewColor(lvProducts)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        If lvorder.Items.Count() = 0 Then
            Exit Sub
        End If
        Dim i As Integer = MsgBox("Order List will be clear, Continue anyway?", MsgBoxStyle.YesNo)
        If i = MsgBoxResult.Yes Then
            CancelTransaction()
            btncancel.Enabled = False
        End If
        toggleBtnEnabbled()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

#Region "local methods"

    Function getQuantityOrder(ByVal _itemname As String, ByVal _enterQty As Integer) As Integer
        'instantiate
        Dim indexRow As New IndexRow

        'initialize index row
        indexRow.ListView = lvorder
        indexRow.Column = 1
        indexRow.Key = _itemname

        If indexRow.hasRow Then
            Dim index As Integer = indexRow.getListIndex()
            Dim quantity As Integer = lvorder.Items(index).SubItems(2).Text
            Return quantity + _enterQty
        Else
            Return getProductStock(_itemname)
        End If
    End Function





    Sub updateQtyListOrder(ByVal _qty As Integer, ByVal _subTotal As Double)
        'instantiate
        Dim indexRow As New IndexRow

        'initialize index row
        indexRow.ListView = lvorder
        indexRow.Column = 1
        indexRow.Key = itemname

        'get index row of product by name
        Dim index = indexRow.getListIndex()

        'if product name has already in order list then update qty and subtotal else add new item to order list
        If indexRow.hasRow() Then
            'update qty and subtotal
            lvorder.Items(index).SubItems(2).Text += _qty

            'if qty = 0 then remove to list
            If lvorder.Items(index).SubItems(2).Text = 0 Then
                lvorder.Items.RemoveAt(lvorder.SelectedIndices(0))
            End If
        Else
            'add item
            With lvorder.Items.Add(id)
                .SubItems.Add(itemname)
                .SubItems.Add(enterQty)
                .SubItems.Add(enterSN)
            End With
        End If
    End Sub

    Function ComputeChange(Optional ByVal cash As Double = 0, Optional ByVal total As Double = 0) As Double
        'If cash.ToString = "" Then
        '    tbcash.ForeColor = Color.Crimson
        '    Return 0
        'End If
        'If Val(cash) < Val(total) Then
        '    tbcash.ForeColor = Color.Crimson
        '    Return 0
        'End If
        'If Val(total) = 0 Then
        '    tbcash.ForeColor = Color.Lime
        '    Return 0
        'End If
        'tbcash.ForeColor = Color.Lime
        'Return Val(cash) - Val(total)
    End Function

    Function ComputeCollumn(ByVal col As Integer) As Double
        Dim sum As Double = (From lvi In lvorder.Items _
        Let value = CDbl(DirectCast(lvi, ListViewItem).SubItems(col).Text) _
        Select value).Sum
        Return sum
    End Function

    Sub saveSales(ByVal listView As ListView)
        Dim odate As String = Format(Now, "d")
        Dim lv
        Dim ctr As Integer
        Dim iloop As Integer
        ctr = listView.Items.Count()
        If Not listView.Items.Count = 0 Then
            Do Until iloop = listView.Items.Count
                lv = listView.Items.Item(iloop)
                With lv
                    Connected()
                    sql = "INSERT into Master (master_EmpId,master_Assigned_Room,qty,master_itemId,master_SerialNo,master_userID) VALUES ('" & cboEmployee.SelectedValue.ToString() & "','" & cboLocation.SelectedValue.ToString & "'," & .subitems(2).Text & "," & .subitems(0).Text & "," & .subitems(3).Text & ",'" & userID & "')"
                    CommandDB()
                    cmd.ExecuteNonQuery()
                End With
                iloop = iloop + 1
                lv = Nothing
            Loop
        End If
    End Sub
    'Public Sub getEmployeeID()
    '    Connected()
    '    sql = "SELECT * FROM Employee WHERE [position] = '" & u & "' AND [passcode] = '" & p & "' "
    'End Sub

    Sub resetOrder()
        lvorder.Items.Clear()
        lblOrno.Text = GenerateOrderNo()
        PopulateProductsPOS(lvProducts, getSortby())
        doChangeListViewColor(lvProducts)
        'tbcustomer.Text = "WALK-IN"
        btncancel.Enabled = False
    End Sub

    Sub CancelTransaction()
        resetOrder()
        lvorder.Items.Clear()
        PopulateProductsPOS(lvProducts, getSortby())
        doChangeListViewColor(lvProducts)
    End Sub


    Sub mapStock()
        Dim ctr As Integer = 0
        While (ctr <> lvorder.Items.Count)
            Dim itemname = lvorder.Items(ctr).SubItems(0).Text
            Dim qtyorder = lvorder.Items(ctr).SubItems(2).Text
            Dim newstock = getProductStock(itemname) - qtyorder
            updateStockInDatabase(newstock, itemname)
            ctr += 1
        End While
    End Sub

    Function getSortby() As String
        Select Case cboSortby.Text.ToLower
            Case "name"
                Return "prod_name"
            Case "category"
                Return "prod_category"
            Case "stock"
                Return "prod_stock"
            Case Else
                Return "prod_category"
        End Select
    End Function

    Public Sub CopyListView(ByVal lvFrom As ListView, ByVal lvTo As ListView)
        For Each lvi As ListViewItem In lvFrom.Items
            Dim newLvi As ListViewItem = lvi.Clone()
            For Each lvsi As ListViewItem.ListViewSubItem In lvi.SubItems
                newLvi.SubItems.Add(New ListViewItem.ListViewSubItem(newLvi, lvsi.Text, lvsi.ForeColor, lvsi.BackColor, lvsi.Font))
            Next
            lvTo.Items.Add(newLvi)
        Next
    End Sub

    Sub setNotif(ByVal message As String, ByVal alrt As Alert)
        Select Case alrt
            Case Alert.Info
                lblNotify.ForeColor = Color.DodgerBlue
            Case Alert.Success
                lblNotify.ForeColor = Color.Teal
            Case Alert.Warning
                lblNotify.ForeColor = Color.Crimson
            Case Else
                lblNotify.ForeColor = Color.Teal
        End Select
        lblNotify.Text = "*" & message
    End Sub

#End Region


    Private Sub cboSortby_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSortby.SelectedIndexChanged
        PopulateProductsPOS(lvProducts, getSortby())
        doChangeListViewColor(lvProducts)
    End Sub

    Public Enum Alert
        Success
        Warning
        Info
    End Enum

End Class
