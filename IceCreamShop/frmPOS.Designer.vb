<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.panelProduct = New System.Windows.Forms.Panel()
        Me.cboSortby = New System.Windows.Forms.ComboBox()
        Me.lblNotify = New System.Windows.Forms.Label()
        Me.lvProducts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbsearch = New System.Windows.Forms.TextBox()
        Me.panelPurchase = New System.Windows.Forms.Panel()
        Me.lblOrno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.panelOrder = New System.Windows.Forms.Panel()
        Me.cboLocation = New System.Windows.Forms.ComboBox()
        Me.cboEmployee = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvorder = New System.Windows.Forms.ListView()
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelProduct.SuspendLayout()
        Me.panelPurchase.SuspendLayout()
        Me.panelOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelProduct
        '
        Me.panelProduct.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelProduct.Controls.Add(Me.cboSortby)
        Me.panelProduct.Controls.Add(Me.lblNotify)
        Me.panelProduct.Controls.Add(Me.lvProducts)
        Me.panelProduct.Controls.Add(Me.Label7)
        Me.panelProduct.Controls.Add(Me.Label11)
        Me.panelProduct.Controls.Add(Me.tbsearch)
        Me.panelProduct.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.panelProduct.Location = New System.Drawing.Point(9, 45)
        Me.panelProduct.Name = "panelProduct"
        Me.panelProduct.Size = New System.Drawing.Size(563, 631)
        Me.panelProduct.TabIndex = 24
        '
        'cboSortby
        '
        Me.cboSortby.BackColor = System.Drawing.Color.White
        Me.cboSortby.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboSortby.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSortby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboSortby.FormattingEnabled = True
        Me.cboSortby.Items.AddRange(New Object() {"Name", "Category", "Stock"})
        Me.cboSortby.Location = New System.Drawing.Point(408, 580)
        Me.cboSortby.Name = "cboSortby"
        Me.cboSortby.Size = New System.Drawing.Size(136, 32)
        Me.cboSortby.TabIndex = 45
        Me.cboSortby.Text = "- Sort By -"
        '
        'lblNotify
        '
        Me.lblNotify.AutoSize = True
        Me.lblNotify.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotify.ForeColor = System.Drawing.Color.Teal
        Me.lblNotify.Location = New System.Drawing.Point(13, 591)
        Me.lblNotify.Name = "lblNotify"
        Me.lblNotify.Size = New System.Drawing.Size(15, 20)
        Me.lblNotify.TabIndex = 32
        Me.lblNotify.Text = "*"
        '
        'lvProducts
        '
        Me.lvProducts.BackColor = System.Drawing.Color.White
        Me.lvProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvProducts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lvProducts.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProducts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvProducts.FullRowSelect = True
        Me.lvProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvProducts.Location = New System.Drawing.Point(17, 125)
        Me.lvProducts.Name = "lvProducts"
        Me.lvProducts.Size = New System.Drawing.Size(527, 447)
        Me.lvProducts.TabIndex = 44
        Me.lvProducts.UseCompatibleStateImageBehavior = False
        Me.lvProducts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Type"
        Me.ColumnHeader2.Width = 90
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 90
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Stock"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Purchase Date"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Location"
        Me.ColumnHeader6.Width = 100
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Status"
        Me.ColumnHeader7.Width = 70
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 21)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "- Search Item -"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(13, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 21)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "- Item List -"
        '
        'tbsearch
        '
        Me.tbsearch.BackColor = System.Drawing.Color.White
        Me.tbsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbsearch.Font = New System.Drawing.Font("Century Gothic", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbsearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.tbsearch.Location = New System.Drawing.Point(17, 35)
        Me.tbsearch.Name = "tbsearch"
        Me.tbsearch.Size = New System.Drawing.Size(527, 50)
        Me.tbsearch.TabIndex = 40
        '
        'panelPurchase
        '
        Me.panelPurchase.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelPurchase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelPurchase.Controls.Add(Me.lblOrno)
        Me.panelPurchase.Controls.Add(Me.Label2)
        Me.panelPurchase.Controls.Add(Me.btnPurchase)
        Me.panelPurchase.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.panelPurchase.Location = New System.Drawing.Point(578, 545)
        Me.panelPurchase.Name = "panelPurchase"
        Me.panelPurchase.Size = New System.Drawing.Size(472, 131)
        Me.panelPurchase.TabIndex = 28
        '
        'lblOrno
        '
        Me.lblOrno.AutoSize = True
        Me.lblOrno.Font = New System.Drawing.Font("Century Gothic", 14.25!)
        Me.lblOrno.ForeColor = System.Drawing.Color.Teal
        Me.lblOrno.Location = New System.Drawing.Point(322, 41)
        Me.lblOrno.Name = "lblOrno"
        Me.lblOrno.Size = New System.Drawing.Size(112, 22)
        Me.lblOrno.TabIndex = 34
        Me.lblOrno.Text = "TRANS1000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(287, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 21)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Transaction Number"
        '
        'btnPurchase
        '
        Me.btnPurchase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPurchase.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurchase.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurchase.ForeColor = System.Drawing.Color.Teal
        Me.btnPurchase.Location = New System.Drawing.Point(313, 75)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(129, 50)
        Me.btnPurchase.TabIndex = 28
        Me.btnPurchase.Text = "ASSIGN"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Enabled = False
        Me.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.Crimson
        Me.btncancel.Location = New System.Drawing.Point(326, 27)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(129, 50)
        Me.btncancel.TabIndex = 39
        Me.btncancel.Text = "Cancel Transaction"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'panelOrder
        '
        Me.panelOrder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panelOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelOrder.Controls.Add(Me.cboLocation)
        Me.panelOrder.Controls.Add(Me.cboEmployee)
        Me.panelOrder.Controls.Add(Me.btncancel)
        Me.panelOrder.Controls.Add(Me.Label8)
        Me.panelOrder.Controls.Add(Me.lvorder)
        Me.panelOrder.Controls.Add(Me.Label3)
        Me.panelOrder.Controls.Add(Me.Label12)
        Me.panelOrder.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.panelOrder.Location = New System.Drawing.Point(578, 45)
        Me.panelOrder.Name = "panelOrder"
        Me.panelOrder.Size = New System.Drawing.Size(472, 494)
        Me.panelOrder.TabIndex = 29
        '
        'cboLocation
        '
        Me.cboLocation.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboLocation.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLocation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboLocation.FormattingEnabled = True
        Me.cboLocation.ItemHeight = 23
        Me.cboLocation.Location = New System.Drawing.Point(19, 120)
        Me.cboLocation.MaximumSize = New System.Drawing.Size(300, 0)
        Me.cboLocation.Name = "cboLocation"
        Me.cboLocation.Size = New System.Drawing.Size(273, 31)
        Me.cboLocation.TabIndex = 39
        '
        'cboEmployee
        '
        Me.cboEmployee.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cboEmployee.Font = New System.Drawing.Font("Century Gothic", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cboEmployee.FormattingEnabled = True
        Me.cboEmployee.ItemHeight = 23
        Me.cboEmployee.Location = New System.Drawing.Point(20, 35)
        Me.cboEmployee.MaximumSize = New System.Drawing.Size(300, 0)
        Me.cboEmployee.Name = "cboEmployee"
        Me.cboEmployee.Size = New System.Drawing.Size(273, 31)
        Me.cboEmployee.TabIndex = 39
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(15, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 21)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "- Assigned Item List -"
        '
        'lvorder
        '
        Me.lvorder.BackColor = System.Drawing.Color.White
        Me.lvorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvorder.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvorder.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvorder.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lvorder.FullRowSelect = True
        Me.lvorder.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvorder.Location = New System.Drawing.Point(19, 187)
        Me.lvorder.Name = "lvorder"
        Me.lvorder.Size = New System.Drawing.Size(436, 293)
        Me.lvorder.TabIndex = 28
        Me.lvorder.UseCompatibleStateImageBehavior = False
        Me.lvorder.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ID"
        Me.ColumnHeader8.Width = 0
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Name"
        Me.ColumnHeader9.Width = 125
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Quantity"
        Me.ColumnHeader10.Width = 125
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Serial Number"
        Me.ColumnHeader11.Width = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(16, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 21)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "- Location -"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(16, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(156, 21)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "- Employee Name -"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "POINT OF SALES"
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1014, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 27)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = " X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1058, 686)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelOrder)
        Me.Controls.Add(Me.panelPurchase)
        Me.Controls.Add(Me.panelProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ice Cream"
        Me.panelProduct.ResumeLayout(False)
        Me.panelProduct.PerformLayout()
        Me.panelPurchase.ResumeLayout(False)
        Me.panelPurchase.PerformLayout()
        Me.panelOrder.ResumeLayout(False)
        Me.panelOrder.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelProduct As System.Windows.Forms.Panel
    Friend WithEvents panelPurchase As System.Windows.Forms.Panel
    Friend WithEvents btnPurchase As System.Windows.Forms.Button
    Friend WithEvents panelOrder As System.Windows.Forms.Panel
    Friend WithEvents lvorder As System.Windows.Forms.ListView
    Friend WithEvents lblNotify As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbsearch As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lvProducts As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btncancel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboSortby As System.Windows.Forms.ComboBox
    Friend WithEvents cboEmployee As ComboBox
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Private WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents lblOrno As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents cboLocation As ComboBox
    Friend WithEvents Label3 As Label
End Class
