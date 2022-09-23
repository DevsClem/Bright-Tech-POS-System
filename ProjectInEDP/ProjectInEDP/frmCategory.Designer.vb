<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategory))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClear = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtID = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtCategory = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtDescription = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlProduct = New System.Windows.Forms.Panel()
        Me.DGCategory = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.pnlProduct.SuspendLayout()
        CType(Me.DGCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 7
        Me.btnSave.ButtonText = " SAVE"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.LightGray
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
        Me.btnSave.IconZoom = 65.0R
        Me.btnSave.IsTab = True
        Me.btnSave.Location = New System.Drawing.Point(25, 214)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(138, 38)
        Me.btnSave.TabIndex = 42
        Me.btnSave.Text = " SAVE"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.SeaShell
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(496, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(184, 26)
        Me.txtSearch.TabIndex = 43
        '
        'btnUpdate
        '
        Me.btnUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdate.BorderRadius = 7
        Me.btnUpdate.ButtonText = " UPDATE"
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdate.DisabledColor = System.Drawing.Color.LightGray
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
        Me.btnUpdate.IconZoom = 60.0R
        Me.btnUpdate.IsTab = True
        Me.btnUpdate.Location = New System.Drawing.Point(225, 258)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnUpdate.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdate.selected = False
        Me.btnUpdate.Size = New System.Drawing.Size(149, 38)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = " UPDATE"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Textcolor = System.Drawing.Color.SeaShell
        Me.btnUpdate.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClear
        '
        Me.btnClear.Activecolor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.BorderRadius = 7
        Me.btnClear.ButtonText = " CLEAR"
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DisabledColor = System.Drawing.Color.Gray
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
        Me.btnClear.IconZoom = 60.0R
        Me.btnClear.IsTab = True
        Me.btnClear.Location = New System.Drawing.Point(25, 258)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnClear.OnHovercolor = System.Drawing.Color.CornflowerBlue
        Me.btnClear.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClear.selected = False
        Me.btnClear.Size = New System.Drawing.Size(138, 38)
        Me.btnClear.TabIndex = 49
        Me.btnClear.Text = " CLEAR"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.Textcolor = System.Drawing.Color.SeaShell
        Me.btnClear.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(128, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(171, 29)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Add Category"
        '
        'txtID
        '
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtID.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtID.HintText = ""
        Me.txtID.isPassword = False
        Me.txtID.LineFocusedColor = System.Drawing.Color.Silver
        Me.txtID.LineIdleColor = System.Drawing.Color.Silver
        Me.txtID.LineMouseHoverColor = System.Drawing.Color.Silver
        Me.txtID.LineThickness = 4
        Me.txtID.Location = New System.Drawing.Point(133, 68)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(233, 28)
        Me.txtID.TabIndex = 67
        Me.txtID.TabStop = False
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtCategory
        '
        Me.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCategory.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCategory.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCategory.HintText = ""
        Me.txtCategory.isPassword = False
        Me.txtCategory.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCategory.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCategory.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtCategory.LineThickness = 4
        Me.txtCategory.Location = New System.Drawing.Point(133, 104)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(233, 38)
        Me.txtCategory.TabIndex = 68
        Me.txtCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDescription
        '
        Me.txtDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDescription.HintForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDescription.HintText = ""
        Me.txtDescription.isPassword = False
        Me.txtDescription.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDescription.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDescription.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.txtDescription.LineThickness = 4
        Me.txtDescription.Location = New System.Drawing.Point(133, 150)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(231, 38)
        Me.txtDescription.TabIndex = 73
        Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(21, 75)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(35, 21)
        Me.BunifuCustomLabel1.TabIndex = 74
        Me.BunifuCustomLabel1.Text = "ID: "
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(19, 121)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(62, 21)
        Me.BunifuCustomLabel2.TabIndex = 75
        Me.BunifuCustomLabel2.Text = "Name:"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(21, 167)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(101, 21)
        Me.BunifuCustomLabel5.TabIndex = 78
        Me.BunifuCustomLabel5.Text = "Description:"
        '
        'pnlProduct
        '
        Me.pnlProduct.BackColor = System.Drawing.Color.White
        Me.pnlProduct.Controls.Add(Me.DGCategory)
        Me.pnlProduct.Controls.Add(Me.BunifuCustomLabel6)
        Me.pnlProduct.Controls.Add(Me.BunifuCustomLabel5)
        Me.pnlProduct.Controls.Add(Me.BunifuCustomLabel2)
        Me.pnlProduct.Controls.Add(Me.BunifuCustomLabel1)
        Me.pnlProduct.Controls.Add(Me.txtDescription)
        Me.pnlProduct.Controls.Add(Me.txtCategory)
        Me.pnlProduct.Controls.Add(Me.txtID)
        Me.pnlProduct.Controls.Add(Me.Label8)
        Me.pnlProduct.Controls.Add(Me.btnClear)
        Me.pnlProduct.Controls.Add(Me.btnUpdate)
        Me.pnlProduct.Controls.Add(Me.txtSearch)
        Me.pnlProduct.Controls.Add(Me.btnSave)
        Me.pnlProduct.Location = New System.Drawing.Point(2, 1)
        Me.pnlProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlProduct.Name = "pnlProduct"
        Me.pnlProduct.Size = New System.Drawing.Size(885, 321)
        Me.pnlProduct.TabIndex = 48
        '
        'DGCategory
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DGCategory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCategory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders
        Me.DGCategory.BackgroundColor = System.Drawing.Color.White
        Me.DGCategory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCategory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCategory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGCategory.ColumnHeadersHeight = 25
        Me.DGCategory.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCategory.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGCategory.DoubleBuffered = True
        Me.DGCategory.EnableHeadersVisualStyles = False
        Me.DGCategory.GridColor = System.Drawing.Color.RoyalBlue
        Me.DGCategory.HeaderBgColor = System.Drawing.Color.RoyalBlue
        Me.DGCategory.HeaderForeColor = System.Drawing.Color.White
        Me.DGCategory.Location = New System.Drawing.Point(396, 49)
        Me.DGCategory.MultiSelect = False
        Me.DGCategory.Name = "DGCategory"
        Me.DGCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCategory.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGCategory.RowHeadersVisible = False
        Me.DGCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGCategory.Size = New System.Drawing.Size(466, 247)
        Me.DGCategory.TabIndex = 81
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(416, 10)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(72, 21)
        Me.BunifuCustomLabel6.TabIndex = 80
        Me.BunifuCustomLabel6.Text = "Search: "
        '
        'frmCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 323)
        Me.Controls.Add(Me.pnlProduct)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Category"
        Me.pnlProduct.ResumeLayout(False)
        Me.pnlProduct.PerformLayout()
        CType(Me.DGCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClear As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label8 As Label
    Friend WithEvents txtID As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtCategory As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtDescription As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnlProduct As Panel
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents DGCategory As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
