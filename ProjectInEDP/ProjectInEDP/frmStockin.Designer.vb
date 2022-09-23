<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStockin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStockin))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtProductTitle = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel17 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel16 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStockoutSearch = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtQuantity = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.DGStockinDetails = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel15 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblOutQuantity = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel19 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSupplyID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DGProducts = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnClear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtSubTotal = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtProductID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dprSupplyDate = New System.Windows.Forms.DateTimePicker()
        Me.btnAddSupplier = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSaveSupply = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.lblSupplier = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboSupplier = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGStockin = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStockinSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gbxSupplyDetails = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DGStockinDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAddSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGStockin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbxSupplyDetails.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtProductTitle.Location = New System.Drawing.Point(144, 93)
        Me.txtProductTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtProductTitle.Name = "txtProductTitle"
        Me.txtProductTitle.Size = New System.Drawing.Size(233, 28)
        Me.txtProductTitle.TabIndex = 117
        Me.txtProductTitle.TabStop = False
        Me.txtProductTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel17
        '
        Me.BunifuCustomLabel17.AutoSize = True
        Me.BunifuCustomLabel17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel17.Location = New System.Drawing.Point(18, 100)
        Me.BunifuCustomLabel17.Name = "BunifuCustomLabel17"
        Me.BunifuCustomLabel17.Size = New System.Drawing.Size(115, 21)
        Me.BunifuCustomLabel17.TabIndex = 116
        Me.BunifuCustomLabel17.Text = "Product Title: "
        '
        'BunifuCustomLabel16
        '
        Me.BunifuCustomLabel16.AutoSize = True
        Me.BunifuCustomLabel16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel16.Location = New System.Drawing.Point(653, 521)
        Me.BunifuCustomLabel16.Name = "BunifuCustomLabel16"
        Me.BunifuCustomLabel16.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel16.TabIndex = 115
        Me.BunifuCustomLabel16.Text = "Search: "
        '
        'txtStockoutSearch
        '
        Me.txtStockoutSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockoutSearch.Location = New System.Drawing.Point(745, 521)
        Me.txtStockoutSearch.Name = "txtStockoutSearch"
        Me.txtStockoutSearch.Size = New System.Drawing.Size(184, 26)
        Me.txtStockoutSearch.TabIndex = 114
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(702, 559)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(262, 29)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Stockin Details Table"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(740, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 29)
        Me.Label3.TabIndex = 112
        Me.Label3.Text = "Product Table"
        '
        'txtPrice
        '
        Me.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.HintText = ""
        Me.txtPrice.isPassword = False
        Me.txtPrice.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtPrice.LineThickness = 4
        Me.txtPrice.Location = New System.Drawing.Point(144, 210)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(233, 25)
        Me.txtPrice.TabIndex = 111
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtQuantity
        '
        Me.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.HintText = ""
        Me.txtQuantity.isPassword = False
        Me.txtQuantity.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtQuantity.LineThickness = 4
        Me.txtQuantity.Location = New System.Drawing.Point(144, 138)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(233, 38)
        Me.txtQuantity.TabIndex = 110
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'DGStockinDetails
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGStockinDetails.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGStockinDetails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGStockinDetails.BackgroundColor = System.Drawing.Color.White
        Me.DGStockinDetails.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGStockinDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGStockinDetails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGStockinDetails.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGStockinDetails.ColumnHeadersHeight = 25
        Me.DGStockinDetails.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGStockinDetails.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGStockinDetails.DoubleBuffered = True
        Me.DGStockinDetails.EnableHeadersVisualStyles = False
        Me.DGStockinDetails.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGStockinDetails.HeaderBgColor = System.Drawing.Color.RoyalBlue
        Me.DGStockinDetails.HeaderForeColor = System.Drawing.Color.White
        Me.DGStockinDetails.Location = New System.Drawing.Point(564, 591)
        Me.DGStockinDetails.MultiSelect = False
        Me.DGStockinDetails.Name = "DGStockinDetails"
        Me.DGStockinDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGStockinDetails.RowHeadersVisible = False
        Me.DGStockinDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGStockinDetails.Size = New System.Drawing.Size(569, 138)
        Me.DGStockinDetails.TabIndex = 107
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(653, 260)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel8.TabIndex = 106
        Me.BunifuCustomLabel8.Text = "Search: "
        '
        'BunifuCustomLabel15
        '
        Me.BunifuCustomLabel15.AutoSize = True
        Me.BunifuCustomLabel15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel15.Location = New System.Drawing.Point(21, 210)
        Me.BunifuCustomLabel15.Name = "BunifuCustomLabel15"
        Me.BunifuCustomLabel15.Size = New System.Drawing.Size(51, 21)
        Me.BunifuCustomLabel15.TabIndex = 105
        Me.BunifuCustomLabel15.Text = "Price:"
        '
        'lblOutQuantity
        '
        Me.lblOutQuantity.AutoSize = True
        Me.lblOutQuantity.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutQuantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblOutQuantity.Location = New System.Drawing.Point(18, 155)
        Me.lblOutQuantity.Name = "lblOutQuantity"
        Me.lblOutQuantity.Size = New System.Drawing.Size(84, 21)
        Me.lblOutQuantity.TabIndex = 104
        Me.lblOutQuantity.Text = "Quantity:"
        '
        'BunifuCustomLabel19
        '
        Me.BunifuCustomLabel19.AutoSize = True
        Me.BunifuCustomLabel19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel19.Location = New System.Drawing.Point(43, 66)
        Me.BunifuCustomLabel19.Name = "BunifuCustomLabel19"
        Me.BunifuCustomLabel19.Size = New System.Drawing.Size(35, 21)
        Me.BunifuCustomLabel19.TabIndex = 102
        Me.BunifuCustomLabel19.Text = "ID: "
        '
        'txtSupplyID
        '
        Me.txtSupplyID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSupplyID.Enabled = False
        Me.txtSupplyID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSupplyID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSupplyID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSupplyID.HintText = ""
        Me.txtSupplyID.isPassword = False
        Me.txtSupplyID.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtSupplyID.LineIdleColor = System.Drawing.Color.Silver
        Me.txtSupplyID.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtSupplyID.LineThickness = 4
        Me.txtSupplyID.Location = New System.Drawing.Point(138, 66)
        Me.txtSupplyID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSupplyID.Name = "txtSupplyID"
        Me.txtSupplyID.Size = New System.Drawing.Size(233, 28)
        Me.txtSupplyID.TabIndex = 100
        Me.txtSupplyID.TabStop = False
        Me.txtSupplyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(459, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 29)
        Me.Label2.TabIndex = 99
        Me.Label2.Text = "Stock-in Form"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(741, 258)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 26)
        Me.txtSearch.TabIndex = 95
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
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.DGProducts.Location = New System.Drawing.Point(521, 358)
        Me.DGProducts.MultiSelect = False
        Me.DGProducts.Name = "DGProducts"
        Me.DGProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGProducts.RowHeadersVisible = False
        Me.DGProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGProducts.Size = New System.Drawing.Size(649, 128)
        Me.DGProducts.TabIndex = 96
        '
        'btnClear
        '
        Me.btnClear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.BorderRadius = 0
        Me.btnClear.ButtonText = "    CLEAR"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DisabledColor = System.Drawing.Color.Gray
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClear.Iconimage = CType(resources.GetObject("btnClear.Iconimage"), System.Drawing.Image)
        Me.btnClear.Iconimage_right = Nothing
        Me.btnClear.Iconimage_right_Selected = Nothing
        Me.btnClear.Iconimage_Selected = Nothing
        Me.btnClear.IconMarginLeft = 10
        Me.btnClear.IconMarginRight = 0
        Me.btnClear.IconRightVisible = True
        Me.btnClear.IconRightZoom = 0R
        Me.btnClear.IconVisible = True
        Me.btnClear.IconZoom = 55.0R
        Me.btnClear.IsTab = True
        Me.btnClear.Location = New System.Drawing.Point(22, 372)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(6)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClear.selected = False
        Me.btnClear.Size = New System.Drawing.Size(176, 41)
        Me.btnClear.TabIndex = 98
        Me.btnClear.Text = "    CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Textcolor = System.Drawing.Color.SeaShell
        Me.btnClear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.BorderRadius = 0
        Me.btnUpdate.ButtonText = "   UPDATE"
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
        Me.btnUpdate.IconZoom = 50.0R
        Me.btnUpdate.IsTab = True
        Me.btnUpdate.Location = New System.Drawing.Point(250, 372)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(188, 41)
        Me.btnUpdate.TabIndex = 97
        Me.btnUpdate.Text = "   UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Textcolor = System.Drawing.Color.SeaShell
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.BorderRadius = 7
        Me.btnClose.ButtonText = " CLOSE"
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledColor = System.Drawing.Color.LightGray
        Me.btnClose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClose.Iconimage = CType(resources.GetObject("btnClose.Iconimage"), System.Drawing.Image)
        Me.btnClose.Iconimage_right = Nothing
        Me.btnClose.Iconimage_right_Selected = Nothing
        Me.btnClose.Iconimage_Selected = Nothing
        Me.btnClose.IconMarginLeft = 10
        Me.btnClose.IconMarginRight = 0
        Me.btnClose.IconRightVisible = True
        Me.btnClose.IconRightZoom = 0R
        Me.btnClose.IconVisible = True
        Me.btnClose.IconZoom = 60.0R
        Me.btnClose.IsTab = True
        Me.btnClose.Location = New System.Drawing.Point(763, 764)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClose.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(138, 38)
        Me.btnClose.TabIndex = 94
        Me.btnClose.Text = " CLOSE"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Textcolor = System.Drawing.Color.SeaShell
        Me.btnClose.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 274)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(86, 21)
        Me.BunifuCustomLabel1.TabIndex = 120
        Me.BunifuCustomLabel1.Text = "Sub Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSubTotal.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtSubTotal.HintText = ""
        Me.txtSubTotal.isPassword = False
        Me.txtSubTotal.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtSubTotal.LineIdleColor = System.Drawing.Color.Silver
        Me.txtSubTotal.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtSubTotal.LineThickness = 4
        Me.txtSubTotal.Location = New System.Drawing.Point(144, 267)
        Me.txtSubTotal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.Size = New System.Drawing.Size(233, 28)
        Me.txtSubTotal.TabIndex = 121
        Me.txtSubTotal.TabStop = False
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "     ADD"
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
        Me.btnAdd.IconZoom = 55.0R
        Me.btnAdd.IsTab = True
        Me.btnAdd.Location = New System.Drawing.Point(129, 321)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(176, 39)
        Me.btnAdd.TabIndex = 122
        Me.btnAdd.Text = "     ADD"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Textcolor = System.Drawing.Color.SeaShell
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(18, 40)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(101, 21)
        Me.BunifuCustomLabel2.TabIndex = 124
        Me.BunifuCustomLabel2.Text = "Product ID: "
        '
        'dprSupplyDate
        '
        Me.dprSupplyDate.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dprSupplyDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dprSupplyDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText
        Me.dprSupplyDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dprSupplyDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.dprSupplyDate.CustomFormat = "yyyy-MM-dd"
        Me.dprSupplyDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dprSupplyDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dprSupplyDate.Location = New System.Drawing.Point(138, 112)
        Me.dprSupplyDate.MaxDate = New Date(2019, 5, 14, 0, 0, 0, 0)
        Me.dprSupplyDate.Name = "dprSupplyDate"
        Me.dprSupplyDate.Size = New System.Drawing.Size(233, 26)
        Me.dprSupplyDate.TabIndex = 126
        Me.dprSupplyDate.Value = New Date(2019, 5, 11, 0, 0, 0, 0)
        '
        'btnAddSupplier
        '
        Me.btnAddSupplier.BackColor = System.Drawing.Color.White
        Me.btnAddSupplier.Image = CType(resources.GetObject("btnAddSupplier.Image"), System.Drawing.Image)
        Me.btnAddSupplier.ImageActive = CType(resources.GetObject("btnAddSupplier.ImageActive"), System.Drawing.Image)
        Me.btnAddSupplier.InitialImage = CType(resources.GetObject("btnAddSupplier.InitialImage"), System.Drawing.Image)
        Me.btnAddSupplier.Location = New System.Drawing.Point(386, 158)
        Me.btnAddSupplier.Name = "btnAddSupplier"
        Me.btnAddSupplier.Size = New System.Drawing.Size(30, 33)
        Me.btnAddSupplier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.btnAddSupplier.TabIndex = 135
        Me.btnAddSupplier.TabStop = False
        Me.btnAddSupplier.Zoom = 10
        '
        'btnSaveSupply
        '
        Me.btnSaveSupply.Activecolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSupply.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSupply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveSupply.BorderRadius = 7
        Me.btnSaveSupply.ButtonText = " SAVE"
        Me.btnSaveSupply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveSupply.DisabledColor = System.Drawing.Color.LightGray
        Me.btnSaveSupply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveSupply.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSaveSupply.Iconimage = CType(resources.GetObject("btnSaveSupply.Iconimage"), System.Drawing.Image)
        Me.btnSaveSupply.Iconimage_right = Nothing
        Me.btnSaveSupply.Iconimage_right_Selected = Nothing
        Me.btnSaveSupply.Iconimage_Selected = Nothing
        Me.btnSaveSupply.IconMarginLeft = 10
        Me.btnSaveSupply.IconMarginRight = 0
        Me.btnSaveSupply.IconRightVisible = True
        Me.btnSaveSupply.IconRightZoom = 0R
        Me.btnSaveSupply.IconVisible = True
        Me.btnSaveSupply.IconZoom = 55.0R
        Me.btnSaveSupply.IsTab = True
        Me.btnSaveSupply.Location = New System.Drawing.Point(154, 229)
        Me.btnSaveSupply.Margin = New System.Windows.Forms.Padding(6)
        Me.btnSaveSupply.Name = "btnSaveSupply"
        Me.btnSaveSupply.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSaveSupply.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnSaveSupply.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSaveSupply.selected = False
        Me.btnSaveSupply.Size = New System.Drawing.Size(151, 37)
        Me.btnSaveSupply.TabIndex = 129
        Me.btnSaveSupply.Text = " SAVE"
        Me.btnSaveSupply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveSupply.Textcolor = System.Drawing.Color.SeaShell
        Me.btnSaveSupply.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblSupplier
        '
        Me.lblSupplier.AutoSize = True
        Me.lblSupplier.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblSupplier.Location = New System.Drawing.Point(43, 170)
        Me.lblSupplier.Name = "lblSupplier"
        Me.lblSupplier.Size = New System.Drawing.Size(86, 21)
        Me.lblSupplier.TabIndex = 129
        Me.lblSupplier.Text = "Suppplier:"
        '
        'cboSupplier
        '
        Me.cboSupplier.BackColor = System.Drawing.SystemColors.Window
        Me.cboSupplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSupplier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.cboSupplier.FormattingEnabled = True
        Me.cboSupplier.Location = New System.Drawing.Point(135, 158)
        Me.cboSupplier.Name = "cboSupplier"
        Me.cboSupplier.Size = New System.Drawing.Size(233, 33)
        Me.cboSupplier.TabIndex = 128
        Me.cboSupplier.Tag = "Category"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(43, 117)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(54, 21)
        Me.BunifuCustomLabel3.TabIndex = 127
        Me.BunifuCustomLabel3.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(740, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(183, 29)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Stock-in Table"
        '
        'DGStockin
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.DGStockin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DGStockin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGStockin.BackgroundColor = System.Drawing.Color.White
        Me.DGStockin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGStockin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGStockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGStockin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DGStockin.ColumnHeadersHeight = 25
        Me.DGStockin.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle9.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGStockin.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGStockin.DoubleBuffered = True
        Me.DGStockin.EnableHeadersVisualStyles = False
        Me.DGStockin.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGStockin.HeaderBgColor = System.Drawing.Color.RoyalBlue
        Me.DGStockin.HeaderForeColor = System.Drawing.Color.White
        Me.DGStockin.Location = New System.Drawing.Point(603, 104)
        Me.DGStockin.MultiSelect = False
        Me.DGStockin.Name = "DGStockin"
        Me.DGStockin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGStockin.RowHeadersVisible = False
        Me.DGStockin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGStockin.Size = New System.Drawing.Size(425, 128)
        Me.DGStockin.TabIndex = 130
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(653, 63)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel4.TabIndex = 134
        Me.BunifuCustomLabel4.Text = "Search: "
        '
        'txtStockinSearch
        '
        Me.txtStockinSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockinSearch.Location = New System.Drawing.Point(741, 61)
        Me.txtStockinSearch.Name = "txtStockinSearch"
        Me.txtStockinSearch.Size = New System.Drawing.Size(184, 26)
        Me.txtStockinSearch.TabIndex = 133
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel19)
        Me.GroupBox1.Controls.Add(Me.dprSupplyDate)
        Me.GroupBox1.Controls.Add(Me.txtSupplyID)
        Me.GroupBox1.Controls.Add(Me.btnAddSupplier)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.cboSupplier)
        Me.GroupBox1.Controls.Add(Me.lblSupplier)
        Me.GroupBox1.Controls.Add(Me.btnSaveSupply)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 288)
        Me.GroupBox1.TabIndex = 138
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supply"
        '
        'gbxSupplyDetails
        '
        Me.gbxSupplyDetails.Controls.Add(Me.BunifuCustomLabel2)
        Me.gbxSupplyDetails.Controls.Add(Me.BunifuCustomLabel1)
        Me.gbxSupplyDetails.Controls.Add(Me.txtProductTitle)
        Me.gbxSupplyDetails.Controls.Add(Me.txtSubTotal)
        Me.gbxSupplyDetails.Controls.Add(Me.txtProductID)
        Me.gbxSupplyDetails.Controls.Add(Me.btnClear)
        Me.gbxSupplyDetails.Controls.Add(Me.lblOutQuantity)
        Me.gbxSupplyDetails.Controls.Add(Me.btnUpdate)
        Me.gbxSupplyDetails.Controls.Add(Me.BunifuCustomLabel17)
        Me.gbxSupplyDetails.Controls.Add(Me.txtPrice)
        Me.gbxSupplyDetails.Controls.Add(Me.BunifuCustomLabel15)
        Me.gbxSupplyDetails.Controls.Add(Me.txtQuantity)
        Me.gbxSupplyDetails.Controls.Add(Me.btnAdd)
        Me.gbxSupplyDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxSupplyDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.gbxSupplyDetails.Location = New System.Drawing.Point(44, 349)
        Me.gbxSupplyDetails.Name = "gbxSupplyDetails"
        Me.gbxSupplyDetails.Size = New System.Drawing.Size(447, 431)
        Me.gbxSupplyDetails.TabIndex = 139
        Me.gbxSupplyDetails.TabStop = False
        Me.gbxSupplyDetails.Text = "Supply Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(676, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 20)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Click on the table to select a product"
        '
        'frmStockin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1199, 814)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.gbxSupplyDetails)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.txtStockinSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGStockin)
        Me.Controls.Add(Me.BunifuCustomLabel16)
        Me.Controls.Add(Me.txtStockoutSearch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGStockinDetails)
        Me.Controls.Add(Me.BunifuCustomLabel8)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DGProducts)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmStockin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stockin Form"
        CType(Me.DGStockinDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGProducts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAddSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGStockin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbxSupplyDetails.ResumeLayout(False)
        Me.gbxSupplyDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtProductTitle As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel17 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel16 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtStockoutSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtQuantity As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DGStockinDetails As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel15 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblOutQuantity As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel19 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSupplyID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DGProducts As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtSubTotal As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtProductID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dprSupplyDate As DateTimePicker
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblSupplier As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents btnSaveSupply As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DGStockin As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtStockinSearch As TextBox
    Friend WithEvents btnAddSupplier As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbxSupplyDetails As GroupBox
    Friend WithEvents Label5 As Label
End Class
