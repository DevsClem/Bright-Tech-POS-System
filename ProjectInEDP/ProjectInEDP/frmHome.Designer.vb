<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHome))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TSTransaction = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSPet = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSSales = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.myMenu = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpSales = New System.Windows.Forms.DateTimePicker()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtEmployee = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnAddPayment = New Bunifu.Framework.UI.BunifuImageButton()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSalesID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboCustomer = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtProductSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DGSalesDetails = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSaveSales = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtCustomerContact = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel10 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAddCustomer = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSubTotal = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPrice = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel14 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtQuantity = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.BunifuCustomLabel12 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtDiscount = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.txtProductDescription = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel18 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel9 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtProductTitle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtProductID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel13 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel11 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.DGProducts = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDiscountAll = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSubTotalAll = New System.Windows.Forms.TextBox()
        Me.txtDiscountAll = New System.Windows.Forms.TextBox()
        Me.txtNetTotal = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.myMenu.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnAddPayment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGSalesDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btnAddCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TSTransaction
        '
        Me.TSTransaction.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSPet, Me.TSSales})
        Me.TSTransaction.Name = "TSTransaction"
        Me.TSTransaction.Size = New System.Drawing.Size(52, 20)
        Me.TSTransaction.Text = "Forms"
        '
        'TSPet
        '
        Me.TSPet.Name = "TSPet"
        Me.TSPet.Size = New System.Drawing.Size(143, 22)
        Me.TSPet.Text = "Admin Login"
        '
        'TSSales
        '
        Me.TSSales.Name = "TSSales"
        Me.TSSales.Size = New System.Drawing.Size(143, 22)
        Me.TSSales.Text = "Sales Record"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'myMenu
        '
        Me.myMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.myMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSTransaction, Me.LogoutToolStripMenuItem})
        Me.myMenu.Location = New System.Drawing.Point(0, 0)
        Me.myMenu.Name = "myMenu"
        Me.myMenu.Size = New System.Drawing.Size(1235, 24)
        Me.myMenu.TabIndex = 2
        Me.myMenu.Text = "File"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpSales)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.txtEmployee)
        Me.GroupBox1.Controls.Add(Me.btnAddPayment)
        Me.GroupBox1.Controls.Add(Me.cboPayment)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel19)
        Me.GroupBox1.Controls.Add(Me.txtSalesID)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 132)
        Me.GroupBox1.TabIndex = 154
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sales"
        '
        'dtpSales
        '
        Me.dtpSales.Location = New System.Drawing.Point(77, 79)
        Me.dtpSales.Name = "dtpSales"
        Me.dtpSales.Size = New System.Drawing.Size(225, 31)
        Me.dtpSales.TabIndex = 160
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(317, 87)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(94, 21)
        Me.BunifuCustomLabel6.TabIndex = 159
        Me.BunifuCustomLabel6.Text = "Employee: "
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(317, 87)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(0, 21)
        Me.BunifuCustomLabel5.TabIndex = 158
        '
        'txtEmployee
        '
        Me.txtEmployee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployee.Enabled = False
        Me.txtEmployee.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtEmployee.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtEmployee.HintText = ""
        Me.txtEmployee.isPassword = False
        Me.txtEmployee.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtEmployee.LineIdleColor = System.Drawing.Color.Silver
        Me.txtEmployee.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtEmployee.LineThickness = 4
        Me.txtEmployee.Location = New System.Drawing.Point(413, 82)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.Size = New System.Drawing.Size(179, 26)
        Me.txtEmployee.TabIndex = 157
        Me.txtEmployee.TabStop = False
        Me.txtEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAddPayment
        '
        Me.btnAddPayment.BackColor = System.Drawing.Color.White
        Me.btnAddPayment.Image = CType(resources.GetObject("btnAddPayment.Image"), System.Drawing.Image)
        Me.btnAddPayment.ImageActive = CType(resources.GetObject("btnAddPayment.ImageActive"), System.Drawing.Image)
        Me.btnAddPayment.InitialImage = CType(resources.GetObject("btnAddPayment.InitialImage"), System.Drawing.Image)
        Me.btnAddPayment.Location = New System.Drawing.Point(598, 37)
        Me.btnAddPayment.Name = "btnAddPayment"
        Me.btnAddPayment.Size = New System.Drawing.Size(28, 32)
        Me.btnAddPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAddPayment.TabIndex = 138
        Me.btnAddPayment.TabStop = False
        Me.btnAddPayment.Zoom = 10
        '
        'cboPayment
        '
        Me.cboPayment.BackColor = System.Drawing.SystemColors.Window
        Me.cboPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPayment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.Location = New System.Drawing.Point(413, 37)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(179, 32)
        Me.cboPayment.TabIndex = 136
        Me.cboPayment.Tag = "Category"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(317, 43)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(88, 21)
        Me.BunifuCustomLabel4.TabIndex = 137
        Me.BunifuCustomLabel4.Text = "Payment: "
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(19, 37)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(35, 21)
        Me.BunifuCustomLabel19.TabIndex = 102
        Me.BunifuCustomLabel19.Text = "ID: "
        '
        'txtSalesID
        '
        Me.txtSalesID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSalesID.Enabled = False
        Me.txtSalesID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSalesID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSalesID.HintText = ""
        Me.txtSalesID.isPassword = False
        Me.txtSalesID.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtSalesID.LineIdleColor = System.Drawing.Color.Silver
        Me.txtSalesID.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtSalesID.LineThickness = 4
        Me.txtSalesID.Location = New System.Drawing.Point(77, 31)
        Me.txtSalesID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesID.Name = "txtSalesID"
        Me.txtSalesID.Size = New System.Drawing.Size(225, 27)
        Me.txtSalesID.TabIndex = 100
        Me.txtSalesID.TabStop = False
        Me.txtSalesID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(18, 81)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(54, 21)
        Me.BunifuCustomLabel3.TabIndex = 127
        Me.BunifuCustomLabel3.Text = "Date:"
        '
        'cboCustomer
        '
        Me.cboCustomer.BackColor = System.Drawing.SystemColors.Window
        Me.cboCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cboCustomer.FormattingEnabled = True
        Me.cboCustomer.Location = New System.Drawing.Point(182, 27)
        Me.cboCustomer.Name = "cboCustomer"
        Me.cboCustomer.Size = New System.Drawing.Size(179, 32)
        Me.cboCustomer.TabIndex = 128
        Me.cboCustomer.Tag = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(186, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(259, 29)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Point Of Sale System"
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(748, 39)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(138, 21)
        Me.BunifuCustomLabel16.TabIndex = 149
        Me.BunifuCustomLabel16.Text = "Product Search: "
        '
        'txtProductSearch
        '
        Me.txtProductSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductSearch.Location = New System.Drawing.Point(903, 37)
        Me.txtProductSearch.Name = "txtProductSearch"
        Me.txtProductSearch.Size = New System.Drawing.Size(184, 26)
        Me.txtProductSearch.TabIndex = 148
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(525, 382)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 29)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Sales Details"
        '
        'DGSalesDetails
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGSalesDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGSalesDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGSalesDetails.BackgroundColor = System.Drawing.Color.White
        Me.DGSalesDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGSalesDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGSalesDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSalesDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGSalesDetails.ColumnHeadersHeight = 25
        Me.DGSalesDetails.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 10.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGSalesDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGSalesDetails.DoubleBuffered = True
        Me.DGSalesDetails.EnableHeadersVisualStyles = False
        Me.DGSalesDetails.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGSalesDetails.HeaderBgColor = System.Drawing.Color.RoyalBlue
        Me.DGSalesDetails.HeaderForeColor = System.Drawing.Color.White
        Me.DGSalesDetails.Location = New System.Drawing.Point(503, 420)
        Me.DGSalesDetails.MultiSelect = False
        Me.DGSalesDetails.Name = "DGSalesDetails"
        Me.DGSalesDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGSalesDetails.RowHeadersVisible = False
        Me.DGSalesDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGSalesDetails.Size = New System.Drawing.Size(579, 368)
        Me.DGSalesDetails.TabIndex = 145
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel16)
        Me.Panel1.Controls.Add(Me.txtProductSearch)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1235, 90)
        Me.Panel1.TabIndex = 156
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 57)
        Me.PictureBox1.TabIndex = 144
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSaveSales)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox2.Controls.Add(Me.txtCustomerContact)
        Me.GroupBox2.Controls.Add(Me.BunifuCustomLabel10)
        Me.GroupBox2.Controls.Add(Me.btnAddCustomer)
        Me.GroupBox2.Controls.Add(Me.cboCustomer)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(684, 108)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(442, 144)
        Me.GroupBox2.TabIndex = 157
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer"
        '
        'btnSaveSales
        '
        Me.btnSaveSales.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSales.BorderRadius = 7
        Me.btnSaveSales.ButtonText = " SAVE"
        Me.btnSaveSales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSales.DisabledColor = System.Drawing.Color.LightGray
        Me.btnSaveSales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSales.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSaveSales.Iconimage = CType(resources.GetObject("btnSaveSales.Iconimage"), System.Drawing.Image)
        Me.btnSaveSales.Iconimage_right = Nothing
        Me.btnSaveSales.Iconimage_right_Selected = Nothing
        Me.btnSaveSales.Iconimage_Selected = Nothing
        Me.btnSaveSales.IconMarginLeft = 10
        Me.btnSaveSales.IconMarginRight = 0
        Me.btnSaveSales.IconRightVisible = True
        Me.btnSaveSales.IconRightZoom = 0R
        Me.btnSaveSales.IconVisible = True
        Me.btnSaveSales.IconZoom = 30.0R
        Me.btnSaveSales.IsTab = True
        Me.btnSaveSales.Location = New System.Drawing.Point(142, 106)
        Me.btnSaveSales.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSaveSales.Name = "btnSaveSales"
        Me.btnSaveSales.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSales.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveSales.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSaveSales.selected = False
        Me.btnSaveSales.Size = New System.Drawing.Size(143, 34)
        Me.btnSaveSales.TabIndex = 160
        Me.btnSaveSales.Text = " SAVE"
        Me.btnSaveSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSales.Textcolor = System.Drawing.Color.SeaShell
        Me.btnSaveSales.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(6, 38)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(142, 21)
        Me.BunifuCustomLabel7.TabIndex = 159
        Me.BunifuCustomLabel7.Text = "Customer Name:"
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(317, 87)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(0, 21)
        Me.BunifuCustomLabel8.TabIndex = 158
        '
        'txtCustomerContact
        '
        Me.txtCustomerContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomerContact.Enabled = False
        Me.txtCustomerContact.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCustomerContact.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCustomerContact.HintText = ""
        Me.txtCustomerContact.isPassword = False
        Me.txtCustomerContact.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtCustomerContact.LineIdleColor = System.Drawing.Color.Silver
        Me.txtCustomerContact.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtCustomerContact.LineThickness = 4
        Me.txtCustomerContact.Location = New System.Drawing.Point(182, 70)
        Me.txtCustomerContact.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerContact.Name = "txtCustomerContact"
        Me.txtCustomerContact.Size = New System.Drawing.Size(179, 26)
        Me.txtCustomerContact.TabIndex = 157
        Me.txtCustomerContact.TabStop = False
        Me.txtCustomerContact.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel10
        '
        Me.BunifuCustomLabel10.AutoSize = True
        Me.BunifuCustomLabel10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel10.Location = New System.Drawing.Point(6, 70)
        Me.BunifuCustomLabel10.Name = "BunifuCustomLabel10"
        Me.BunifuCustomLabel10.Size = New System.Drawing.Size(166, 21)
        Me.BunifuCustomLabel10.TabIndex = 102
        Me.BunifuCustomLabel10.Text = "Customer Contact: "
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.BackColor = System.Drawing.Color.White
        Me.btnAddCustomer.Image = CType(resources.GetObject("btnAddCustomer.Image"), System.Drawing.Image)
        Me.btnAddCustomer.ImageActive = CType(resources.GetObject("btnAddCustomer.ImageActive"), System.Drawing.Image)
        Me.btnAddCustomer.InitialImage = CType(resources.GetObject("btnAddCustomer.InitialImage"), System.Drawing.Image)
        Me.btnAddCustomer.Location = New System.Drawing.Point(375, 27)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(28, 32)
        Me.btnAddCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAddCustomer.TabIndex = 135
        Me.btnAddCustomer.TabStop = False
        Me.btnAddCustomer.Zoom = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel15)
        Me.GroupBox3.Controls.Add(Me.txtPrice)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel14)
        Me.GroupBox3.Controls.Add(Me.txtQuantity)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel12)
        Me.GroupBox3.Controls.Add(Me.txtDiscount)
        Me.GroupBox3.Controls.Add(Me.txtProductDescription)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel18)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel9)
        Me.GroupBox3.Controls.Add(Me.txtProductTitle)
        Me.GroupBox3.Controls.Add(Me.txtProductID)
        Me.GroupBox3.Controls.Add(Me.BunifuCustomLabel13)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1190, 113)
        Me.GroupBox3.TabIndex = 156
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sales Details"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSubTotal.Location = New System.Drawing.Point(1047, 19)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(128, 35)
        Me.txtSubTotal.TabIndex = 169
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(892, 29)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(139, 20)
        Me.BunifuCustomLabel15.TabIndex = 168
        Me.BunifuCustomLabel15.Text = "Sub Total For Item:"
        '
        'txtPrice
        '
        Me.txtPrice.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.Location = New System.Drawing.Point(746, 67)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(128, 35)
        Me.txtPrice.TabIndex = 166
        '
        'BunifuCustomLabel14
        '
        Me.BunifuCustomLabel14.AutoSize = True
        Me.BunifuCustomLabel14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel14.Location = New System.Drawing.Point(645, 76)
        Me.BunifuCustomLabel14.Name = "BunifuCustomLabel14"
        Me.BunifuCustomLabel14.Size = New System.Drawing.Size(50, 20)
        Me.BunifuCustomLabel14.TabIndex = 165
        Me.BunifuCustomLabel14.Text = "Price:"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.Location = New System.Drawing.Point(746, 19)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(128, 35)
        Me.txtQuantity.TabIndex = 164
        '
        'BunifuCustomLabel12
        '
        Me.BunifuCustomLabel12.AutoSize = True
        Me.BunifuCustomLabel12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel12.Location = New System.Drawing.Point(645, 29)
        Me.BunifuCustomLabel12.Name = "BunifuCustomLabel12"
        Me.BunifuCustomLabel12.Size = New System.Drawing.Size(75, 20)
        Me.BunifuCustomLabel12.TabIndex = 163
        Me.BunifuCustomLabel12.Text = "Quantity:"
        '
        'txtDiscount
        '
        Me.txtDiscount.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDiscount.Location = New System.Drawing.Point(1047, 65)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(128, 37)
        Me.txtDiscount.TabIndex = 162
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductDescription.Enabled = False
        Me.txtProductDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductDescription.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductDescription.HintText = ""
        Me.txtProductDescription.isPassword = False
        Me.txtProductDescription.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtProductDescription.LineIdleColor = System.Drawing.Color.Silver
        Me.txtProductDescription.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtProductDescription.LineThickness = 4
        Me.txtProductDescription.Location = New System.Drawing.Point(393, 67)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(233, 28)
        Me.txtProductDescription.TabIndex = 127
        Me.txtProductDescription.TabStop = False
        Me.txtProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel18
        '
        Me.BunifuCustomLabel18.AutoSize = True
        Me.BunifuCustomLabel18.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel18.Location = New System.Drawing.Point(389, 31)
        Me.BunifuCustomLabel18.Name = "BunifuCustomLabel18"
        Me.BunifuCustomLabel18.Size = New System.Drawing.Size(105, 21)
        Me.BunifuCustomLabel18.TabIndex = 126
        Me.BunifuCustomLabel18.Text = "Description: "
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(892, 74)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(141, 20)
        Me.BunifuCustomLabel1.TabIndex = 159
        Me.BunifuCustomLabel1.Text = "Discount Per Item:"
        '
        'BunifuCustomLabel9
        '
        Me.BunifuCustomLabel9.AutoSize = True
        Me.BunifuCustomLabel9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel9.Location = New System.Drawing.Point(18, 40)
        Me.BunifuCustomLabel9.Name = "BunifuCustomLabel9"
        Me.BunifuCustomLabel9.Size = New System.Drawing.Size(101, 21)
        Me.BunifuCustomLabel9.TabIndex = 124
        Me.BunifuCustomLabel9.Text = "Product ID: "
        '
        'txtProductTitle
        '
        Me.txtProductTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductTitle.Enabled = False
        Me.txtProductTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductTitle.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductTitle.HintText = ""
        Me.txtProductTitle.isPassword = False
        Me.txtProductTitle.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtProductTitle.LineIdleColor = System.Drawing.Color.Silver
        Me.txtProductTitle.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtProductTitle.LineThickness = 4
        Me.txtProductTitle.Location = New System.Drawing.Point(141, 67)
        Me.txtProductTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(233, 28)
        Me.txtProductTitle.TabIndex = 117
        Me.txtProductTitle.TabStop = False
        Me.txtProductTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtProductID
        '
        Me.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtProductID.Enabled = False
        Me.txtProductID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtProductID.HintText = ""
        Me.txtProductID.isPassword = False
        Me.txtProductID.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtProductID.LineIdleColor = System.Drawing.Color.Silver
        Me.txtProductID.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtProductID.LineThickness = 4
        Me.txtProductID.Location = New System.Drawing.Point(144, 33)
        Me.txtProductID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(233, 28)
        Me.txtProductID.TabIndex = 125
        Me.txtProductID.TabStop = False
        Me.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel13
        '
        Me.BunifuCustomLabel13.AutoSize = True
        Me.BunifuCustomLabel13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel13.Location = New System.Drawing.Point(19, 74)
        Me.BunifuCustomLabel13.Name = "BunifuCustomLabel13"
        Me.BunifuCustomLabel13.Size = New System.Drawing.Size(115, 21)
        Me.BunifuCustomLabel13.TabIndex = 116
        Me.BunifuCustomLabel13.Text = "Product Title: "
        '
        'BunifuCustomLabel11
        '
        Me.BunifuCustomLabel11.AutoSize = True
        Me.BunifuCustomLabel11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel11.Location = New System.Drawing.Point(1088, 444)
        Me.BunifuCustomLabel11.Name = "BunifuCustomLabel11"
        Me.BunifuCustomLabel11.Size = New System.Drawing.Size(76, 20)
        Me.BunifuCustomLabel11.TabIndex = 120
        Me.BunifuCustomLabel11.Text = "Sub Total:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(1088, 624)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(76, 20)
        Me.BunifuCustomLabel2.TabIndex = 161
        Me.BunifuCustomLabel2.Text = "Net Total:"
        '
        'DGProducts
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGProducts.BackgroundColor = System.Drawing.Color.White
        Me.DGProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DGProducts.ColumnHeadersHeight = 25
        Me.DGProducts.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGProducts.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGProducts.DoubleBuffered = True
        Me.DGProducts.EnableHeadersVisualStyles = False
        Me.DGProducts.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGProducts.HeaderBgColor = System.Drawing.Color.RoyalBlue
        Me.DGProducts.HeaderForeColor = System.Drawing.Color.White
        Me.DGProducts.Location = New System.Drawing.Point(34, 420)
        Me.DGProducts.MultiSelect = False
        Me.DGProducts.Name = "DGProducts"
        Me.DGProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGProducts.RowHeadersVisible = False
        Me.DGProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProducts.Size = New System.Drawing.Size(424, 368)
        Me.DGProducts.TabIndex = 164
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(53, 377)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 29)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Products"
        '
        'lblDiscountAll
        '
        Me.lblDiscountAll.AutoSize = True
        Me.lblDiscountAll.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscountAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblDiscountAll.Location = New System.Drawing.Point(1088, 538)
        Me.lblDiscountAll.Name = "lblDiscountAll"
        Me.lblDiscountAll.Size = New System.Drawing.Size(76, 20)
        Me.lblDiscountAll.TabIndex = 169
        Me.lblDiscountAll.Text = "Discount:"
        '
        'txtSubTotalAll
        '
        Me.txtSubTotalAll.Enabled = False
        Me.txtSubTotalAll.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotalAll.Location = New System.Drawing.Point(1092, 481)
        Me.txtSubTotalAll.Name = "txtSubTotalAll"
        Me.txtSubTotalAll.Size = New System.Drawing.Size(100, 37)
        Me.txtSubTotalAll.TabIndex = 171
        '
        'txtDiscountAll
        '
        Me.txtDiscountAll.Enabled = False
        Me.txtDiscountAll.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscountAll.Location = New System.Drawing.Point(1092, 571)
        Me.txtDiscountAll.Name = "txtDiscountAll"
        Me.txtDiscountAll.Size = New System.Drawing.Size(100, 37)
        Me.txtDiscountAll.TabIndex = 172
        '
        'txtNetTotal
        '
        Me.txtNetTotal.Enabled = False
        Me.txtNetTotal.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtNetTotal.Location = New System.Drawing.Point(1092, 663)
        Me.txtNetTotal.Name = "txtNetTotal"
        Me.txtNetTotal.Size = New System.Drawing.Size(100, 37)
        Me.txtNetTotal.TabIndex = 173
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.BorderRadius = 7
        Me.btnUpdate.ButtonText = " UPDATE"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DisabledColor = System.Drawing.Color.LightGray
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdate.Iconimage = CType(resources.GetObject("btnUpdate.Iconimage"), System.Drawing.Image)
        Me.btnUpdate.Iconimage_right = Nothing
        Me.btnUpdate.Iconimage_right_Selected = Nothing
        Me.btnUpdate.Iconimage_Selected = Nothing
        Me.btnUpdate.IconMarginLeft = 10
        Me.btnUpdate.IconMarginRight = 0
        Me.btnUpdate.IconRightVisible = True
        Me.btnUpdate.IconRightZoom = 0R
        Me.btnUpdate.IconVisible = True
        Me.btnUpdate.IconZoom = 30.0R
        Me.btnUpdate.IsTab = True
        Me.btnUpdate.Location = New System.Drawing.Point(1054, 377)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(148, 34)
        Me.btnUpdate.TabIndex = 168
        Me.btnUpdate.Text = " UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Textcolor = System.Drawing.Color.SeaShell
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDelete
        '
        Me.btnDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.BorderRadius = 7
        Me.btnDelete.ButtonText = "DELETE"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledColor = System.Drawing.Color.LightGray
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelete.Iconimage = CType(resources.GetObject("btnDelete.Iconimage"), System.Drawing.Image)
        Me.btnDelete.Iconimage_right = Nothing
        Me.btnDelete.Iconimage_right_Selected = Nothing
        Me.btnDelete.Iconimage_Selected = Nothing
        Me.btnDelete.IconMarginLeft = 10
        Me.btnDelete.IconMarginRight = 0
        Me.btnDelete.IconRightVisible = True
        Me.btnDelete.IconRightZoom = 0R
        Me.btnDelete.IconVisible = True
        Me.btnDelete.IconZoom = 50.0R
        Me.btnDelete.IsTab = True
        Me.btnDelete.Location = New System.Drawing.Point(177, 379)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnDelete.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDelete.selected = False
        Me.btnDelete.Size = New System.Drawing.Size(152, 29)
        Me.btnDelete.TabIndex = 167
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Textcolor = System.Drawing.Color.SeaShell
        Me.btnDelete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 7
        Me.btnAdd.ButtonText = "  ADD"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledColor = System.Drawing.Color.LightGray
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdd.Iconimage = CType(resources.GetObject("btnAdd.Iconimage"), System.Drawing.Image)
        Me.btnAdd.Iconimage_right = Nothing
        Me.btnAdd.Iconimage_right_Selected = Nothing
        Me.btnAdd.Iconimage_Selected = Nothing
        Me.btnAdd.IconMarginLeft = 10
        Me.btnAdd.IconMarginRight = 0
        Me.btnAdd.IconRightVisible = True
        Me.btnAdd.IconRightZoom = 0R
        Me.btnAdd.IconVisible = True
        Me.btnAdd.IconZoom = 30.0R
        Me.btnAdd.IsTab = True
        Me.btnAdd.Location = New System.Drawing.Point(912, 377)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(130, 34)
        Me.btnAdd.TabIndex = 167
        Me.btnAdd.Text = "  ADD"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Textcolor = System.Drawing.Color.SeaShell
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 7
        Me.btnSave.ButtonText = " FINISH"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.LightGray
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 10
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 55.0R
        Me.btnSave.IsTab = True
        Me.btnSave.Location = New System.Drawing.Point(1092, 723)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(128, 47)
        Me.btnSave.TabIndex = 129
        Me.btnSave.Text = " FINISH"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.SeaShell
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1235, 800)
        Me.Controls.Add(Me.txtNetTotal)
        Me.Controls.Add(Me.txtDiscountAll)
        Me.Controls.Add(Me.txtSubTotalAll)
        Me.Controls.Add(Me.lblDiscountAll)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGProducts)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BunifuCustomLabel11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.myMenu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGSalesDetails)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.myMenu.ResumeLayout(False)
        Me.myMenu.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnAddPayment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGSalesDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btnAddCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TSTransaction As ToolStripMenuItem
    Friend WithEvents TSPet As ToolStripMenuItem
    Friend WithEvents TSSales As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents myMenu As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSalesID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnAddCustomer As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboCustomer As ComboBox
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtProductSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DGSalesDetails As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAddPayment As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents cboPayment As ComboBox
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtEmployee As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtCustomerContact As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel10 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtProductDescription As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel18 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel9 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtProductTitle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtProductID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel13 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel11 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPrice As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel14 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtQuantity As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel12 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtDiscount As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents DGProducts As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSaveSales As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpSales As DateTimePicker
    Friend WithEvents txtSubTotal As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblDiscountAll As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSubTotalAll As TextBox
    Friend WithEvents txtDiscountAll As TextBox
    Friend WithEvents txtNetTotal As TextBox
End Class
