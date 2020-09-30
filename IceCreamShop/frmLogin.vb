Public Class frmLogin

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connected()
    End Sub

    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        If IsUserAuthentic(cbopos.Text.ToLower, tbpcode.Text.ToLower) = True Then
            frmMain.Show()
            If cbopos.Text = "Employee" Then

                frmMain.InventoryToolStripMenuItem.Visible = False
                frmMain.POSToolStripMenuItem.Visible = False
                frmMain.ReportsToolStripMenuItem.Visible = False
                frmMain.btninventory.Visible = False
                frmMain.btnreport.Visible = False
            Else
                frmMain.InventoryToolStripMenuItem.Visible = True
                frmMain.POSToolStripMenuItem.Visible = True
                frmMain.ReportsToolStripMenuItem.Visible = True
                frmMain.btninventory.Visible = True
                frmMain.btnreport.Visible = True
            End If

            cbopos.Text = "- Select -"
            tbpcode.Text = ""
            'MsgBox("Welcome!", MsgBoxStyle.Information)a
            Me.Hide()
        Else
            MsgBox("Incorrect passcode", MsgBoxStyle.Critical)
        End If
    End Sub

    'check if user is valid
    Function IsUserAuthentic(ByVal u As String, ByVal p As String) As Boolean
        Connected()
        sql = "SELECT * FROM tbluser WHERE [position] = '" & u & "' AND [passcode] = '" & p & "' "
        cmd = New OleDb.OleDbCommand(sql, conn)
        dr = cmd.ExecuteReader()
        If (dr.Read() = True) Then
            Return True
        End If
    End Function
    'mao ni ako query para makuha ang userID sa mu gamit sa system 
    'kay gi ako apilon sa query didto sa master nig assign
    Public Sub globalvar(ByVal lv As ListView, ByVal orderBy As String, ByVal u As String, ByVal p As String)
        Connected()
        With lv
            .Items.Clear()
            sql = "SELECT * FROM tbluser WHERE [position] = '" & u & "' AND [passcode] = '" & p & "' "
            CommandDB()
            dr = cmd.ExecuteReader()
            lv.Items.Clear()
            While (dr.Read())
                With lv.Items.Add(dr("ID"))
                    .SubItems.Add(dr("position"))
                    .SubItems.Add(dr("passcode"))
                    .SubItems.Add(dr("item_stock"))
                    .SubItems.Add(dr("firstname"))
                    .SubItems.Add(dr("lastname"))
                End With
            End While

        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
