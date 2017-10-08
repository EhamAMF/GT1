<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProductStock
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ProductStock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PProductName = New System.Windows.Forms.Panel()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New ByteClassLibrary.MyTextBox()
        Me.PProductCode = New System.Windows.Forms.Panel()
        Me.lblProductCode = New System.Windows.Forms.Label()
        Me.txtProductCode = New ByteClassLibrary.MyTextBox()
        Me.PBarcode = New System.Windows.Forms.Panel()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtBarcode = New ByteClassLibrary.MyTextBox()
        Me.PExDate = New System.Windows.Forms.Panel()
        Me.lblExDate = New System.Windows.Forms.Label()
        Me.dtpExDate = New ByteClassLibrary.MyDateTimePicker()
        Me.PRack = New System.Windows.Forms.Panel()
        Me.lblRack = New System.Windows.Forms.Label()
        Me.txtRack = New ByteClassLibrary.MyTextBox()
        Me.PTypeID = New System.Windows.Forms.Panel()
        Me.lblTypeID = New System.Windows.Forms.Label()
        Me.cboTypeID = New ByteClassLibrary.MyGridTextBox3()
        Me.PBrandID = New System.Windows.Forms.Panel()
        Me.lblBrandID = New System.Windows.Forms.Label()
        Me.cboBrandID = New ByteClassLibrary.MyGridTextBox3()
        Me.PProductDetails = New System.Windows.Forms.Panel()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.txtProductDetails = New ByteClassLibrary.MyTextBox()
        Me.PSubAmount = New System.Windows.Forms.Panel()
        Me.lblSubAmount = New System.Windows.Forms.Label()
        Me.numSubAmount = New ByteClassLibrary.MyNumericBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PAlertAmount = New System.Windows.Forms.Panel()
        Me.numAlertAmount = New ByteClassLibrary.MyNumericBox()
        Me.lblAlertAmount = New System.Windows.Forms.Label()
        Me.PAvgUnitCostPacket = New System.Windows.Forms.Panel()
        Me.lblAvgUnitCostPacket = New System.Windows.Forms.Label()
        Me.numAvgUnitCostPacket = New ByteClassLibrary.MyNumericBox()
        Me.PAmountLeftPacket = New System.Windows.Forms.Panel()
        Me.lblAmountLeftPacket = New System.Windows.Forms.Label()
        Me.numAmountLeftPacket = New ByteClassLibrary.MyNumericBox()
        Me.PAmountLeft = New System.Windows.Forms.Panel()
        Me.lblAmountLeft = New System.Windows.Forms.Label()
        Me.numAmountLeft = New ByteClassLibrary.MyNumericBox()
        Me.PLastUnitCostPacket = New System.Windows.Forms.Panel()
        Me.lblLastUnitCostPacket = New System.Windows.Forms.Label()
        Me.numLastUnitCostPacket = New ByteClassLibrary.MyNumericBox()
        Me.PAvgUnitCost = New System.Windows.Forms.Panel()
        Me.lblAvgUnitCost = New System.Windows.Forms.Label()
        Me.numAvgUnitCost = New ByteClassLibrary.MyNumericBox()
        Me.PSellPricePacket = New System.Windows.Forms.Panel()
        Me.lblSellPricePacket = New System.Windows.Forms.Label()
        Me.numSellPricePacket = New ByteClassLibrary.MyNumericBox()
        Me.PLastUnitCost = New System.Windows.Forms.Panel()
        Me.lblLastUnitCost = New System.Windows.Forms.Label()
        Me.numLastUnitCost = New ByteClassLibrary.MyNumericBox()
        Me.PAlertAmountPacket = New System.Windows.Forms.Panel()
        Me.numAlertAmountPacket = New ByteClassLibrary.MyNumericBox()
        Me.lblAlertAmountPacket = New System.Windows.Forms.Label()
        Me.PSellPrice = New System.Windows.Forms.Panel()
        Me.lblSellPrice = New System.Windows.Forms.Label()
        Me.numSellPrice = New ByteClassLibrary.MyNumericBox()
        Me.PExpressButtons = New System.Windows.Forms.Panel()
        Me.btnExit = New ByteClassLibrary.MyButton()
        Me.btnEnter = New ByteClassLibrary.MyButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cmsDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ادارةالباركودToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.lblTitle = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PProductName.SuspendLayout()
        Me.PProductCode.SuspendLayout()
        Me.PBarcode.SuspendLayout()
        Me.PExDate.SuspendLayout()
        Me.PRack.SuspendLayout()
        Me.PTypeID.SuspendLayout()
        Me.PBrandID.SuspendLayout()
        Me.PProductDetails.SuspendLayout()
        Me.PSubAmount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PAlertAmount.SuspendLayout()
        Me.PAvgUnitCostPacket.SuspendLayout()
        Me.PAmountLeftPacket.SuspendLayout()
        Me.PAmountLeft.SuspendLayout()
        Me.PLastUnitCostPacket.SuspendLayout()
        Me.PAvgUnitCost.SuspendLayout()
        Me.PSellPricePacket.SuspendLayout()
        Me.PLastUnitCost.SuspendLayout()
        Me.PAlertAmountPacket.SuspendLayout()
        Me.PSellPrice.SuspendLayout()
        Me.PExpressButtons.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDGV.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 30)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 30)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(985, 640)
        Me.SplitContainer1.SplitterDistance = 508
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.PProductName)
        Me.FlowLayoutPanel1.Controls.Add(Me.PProductCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.PBarcode)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.PRack)
        Me.FlowLayoutPanel1.Controls.Add(Me.PTypeID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PBrandID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PProductDetails)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSubAmount)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExpressButtons)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(508, 640)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'PProductName
        '
        Me.PProductName.Controls.Add(Me.lblProductName)
        Me.PProductName.Controls.Add(Me.txtProductName)
        Me.PProductName.Location = New System.Drawing.Point(40, 10)
        Me.PProductName.Margin = New System.Windows.Forms.Padding(0)
        Me.PProductName.Name = "PProductName"
        Me.PProductName.Size = New System.Drawing.Size(468, 37)
        Me.PProductName.TabIndex = 0
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.AutoSize = True
        Me.lblProductName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductName.Location = New System.Drawing.Point(343, 3)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(71, 23)
        Me.lblProductName.TabIndex = 100
        Me.lblProductName.Text = "اسم الصنف"
        '
        'txtProductName
        '
        Me.txtProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductName.BackColor = System.Drawing.Color.White
        Me.txtProductName.ForeColor = System.Drawing.Color.Black
        Me.txtProductName.Location = New System.Drawing.Point(0, 0)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(337, 31)
        Me.txtProductName.TabIndex = 0
        '
        'PProductCode
        '
        Me.PProductCode.Controls.Add(Me.lblProductCode)
        Me.PProductCode.Controls.Add(Me.txtProductCode)
        Me.PProductCode.Location = New System.Drawing.Point(40, 47)
        Me.PProductCode.Margin = New System.Windows.Forms.Padding(0)
        Me.PProductCode.Name = "PProductCode"
        Me.PProductCode.Size = New System.Drawing.Size(468, 37)
        Me.PProductCode.TabIndex = 1
        '
        'lblProductCode
        '
        Me.lblProductCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductCode.AutoSize = True
        Me.lblProductCode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductCode.Location = New System.Drawing.Point(343, 3)
        Me.lblProductCode.Name = "lblProductCode"
        Me.lblProductCode.Size = New System.Drawing.Size(29, 23)
        Me.lblProductCode.TabIndex = 101
        Me.lblProductCode.Text = "كود"
        '
        'txtProductCode
        '
        Me.txtProductCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductCode.Location = New System.Drawing.Point(0, 0)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(337, 31)
        Me.txtProductCode.TabIndex = 0
        '
        'PBarcode
        '
        Me.PBarcode.Controls.Add(Me.lblBarcode)
        Me.PBarcode.Controls.Add(Me.txtBarcode)
        Me.PBarcode.Enabled = False
        Me.PBarcode.Location = New System.Drawing.Point(40, 84)
        Me.PBarcode.Margin = New System.Windows.Forms.Padding(0)
        Me.PBarcode.Name = "PBarcode"
        Me.PBarcode.Size = New System.Drawing.Size(468, 37)
        Me.PBarcode.TabIndex = 2
        '
        'lblBarcode
        '
        Me.lblBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBarcode.Location = New System.Drawing.Point(343, 3)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(43, 23)
        Me.lblBarcode.TabIndex = 102
        Me.lblBarcode.Text = "باركود"
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.Location = New System.Drawing.Point(0, 0)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(337, 31)
        Me.txtBarcode.TabIndex = 0
        '
        'PExDate
        '
        Me.PExDate.Controls.Add(Me.lblExDate)
        Me.PExDate.Controls.Add(Me.dtpExDate)
        Me.PExDate.Location = New System.Drawing.Point(40, 121)
        Me.PExDate.Margin = New System.Windows.Forms.Padding(0)
        Me.PExDate.Name = "PExDate"
        Me.PExDate.Size = New System.Drawing.Size(468, 37)
        Me.PExDate.TabIndex = 3
        '
        'lblExDate
        '
        Me.lblExDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExDate.AutoSize = True
        Me.lblExDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExDate.Location = New System.Drawing.Point(343, 3)
        Me.lblExDate.Name = "lblExDate"
        Me.lblExDate.Size = New System.Drawing.Size(61, 23)
        Me.lblExDate.TabIndex = 103
        Me.lblExDate.Text = "الصلاحية"
        '
        'dtpExDate
        '
        Me.dtpExDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpExDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpExDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExDate.HighlightColor = System.Drawing.Color.Empty
        Me.dtpExDate.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpExDate.IsHighLight = False
        Me.dtpExDate.Location = New System.Drawing.Point(0, 0)
        Me.dtpExDate.Name = "dtpExDate"
        Me.dtpExDate.Size = New System.Drawing.Size(337, 31)
        Me.dtpExDate.TabIndex = 0
        '
        'PRack
        '
        Me.PRack.Controls.Add(Me.lblRack)
        Me.PRack.Controls.Add(Me.txtRack)
        Me.PRack.Location = New System.Drawing.Point(40, 158)
        Me.PRack.Margin = New System.Windows.Forms.Padding(0)
        Me.PRack.Name = "PRack"
        Me.PRack.Size = New System.Drawing.Size(468, 37)
        Me.PRack.TabIndex = 4
        '
        'lblRack
        '
        Me.lblRack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRack.AutoSize = True
        Me.lblRack.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblRack.Location = New System.Drawing.Point(338, 3)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(48, 23)
        Me.lblRack.TabIndex = 104
        Me.lblRack.Text = "الموقع"
        '
        'txtRack
        '
        Me.txtRack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRack.Location = New System.Drawing.Point(0, 0)
        Me.txtRack.Name = "txtRack"
        Me.txtRack.Size = New System.Drawing.Size(337, 31)
        Me.txtRack.TabIndex = 0
        '
        'PTypeID
        '
        Me.PTypeID.Controls.Add(Me.lblTypeID)
        Me.PTypeID.Controls.Add(Me.cboTypeID)
        Me.PTypeID.Location = New System.Drawing.Point(40, 195)
        Me.PTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.PTypeID.Name = "PTypeID"
        Me.PTypeID.Size = New System.Drawing.Size(468, 37)
        Me.PTypeID.TabIndex = 5
        '
        'lblTypeID
        '
        Me.lblTypeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeID.AutoSize = True
        Me.lblTypeID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTypeID.Location = New System.Drawing.Point(343, 3)
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Size = New System.Drawing.Size(36, 23)
        Me.lblTypeID.TabIndex = 105
        Me.lblTypeID.Text = "النوع"
        '
        'cboTypeID
        '
        Me.cboTypeID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTypeID.IsDgvLocationHeightSet = False
        Me.cboTypeID.Location = New System.Drawing.Point(0, 0)
        Me.cboTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboTypeID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboTypeID.MyIsColumnHeaderVisible = False
        Me.cboTypeID.MySelectedValue = Nothing
        Me.cboTypeID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboTypeID.Name = "cboTypeID"
        Me.cboTypeID.Size = New System.Drawing.Size(337, 31)
        Me.cboTypeID.TabIndex = 0
        Me.cboTypeID.TabOnEnter = True
        '
        'PBrandID
        '
        Me.PBrandID.Controls.Add(Me.lblBrandID)
        Me.PBrandID.Controls.Add(Me.cboBrandID)
        Me.PBrandID.Location = New System.Drawing.Point(40, 232)
        Me.PBrandID.Margin = New System.Windows.Forms.Padding(0)
        Me.PBrandID.Name = "PBrandID"
        Me.PBrandID.Size = New System.Drawing.Size(468, 37)
        Me.PBrandID.TabIndex = 6
        '
        'lblBrandID
        '
        Me.lblBrandID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBrandID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBrandID.Location = New System.Drawing.Point(340, 3)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(46, 23)
        Me.lblBrandID.TabIndex = 106
        Me.lblBrandID.Text = "الماركة"
        '
        'cboBrandID
        '
        Me.cboBrandID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboBrandID.IsDgvLocationHeightSet = False
        Me.cboBrandID.Location = New System.Drawing.Point(0, 0)
        Me.cboBrandID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboBrandID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboBrandID.MyIsColumnHeaderVisible = False
        Me.cboBrandID.MySelectedValue = Nothing
        Me.cboBrandID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboBrandID.Name = "cboBrandID"
        Me.cboBrandID.Size = New System.Drawing.Size(337, 31)
        Me.cboBrandID.TabIndex = 0
        Me.cboBrandID.TabOnEnter = True
        '
        'PProductDetails
        '
        Me.PProductDetails.Controls.Add(Me.lblProductDetails)
        Me.PProductDetails.Controls.Add(Me.txtProductDetails)
        Me.PProductDetails.Location = New System.Drawing.Point(40, 269)
        Me.PProductDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PProductDetails.Name = "PProductDetails"
        Me.PProductDetails.Size = New System.Drawing.Size(468, 37)
        Me.PProductDetails.TabIndex = 7
        '
        'lblProductDetails
        '
        Me.lblProductDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductDetails.AutoSize = True
        Me.lblProductDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductDetails.Location = New System.Drawing.Point(343, 3)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(54, 23)
        Me.lblProductDetails.TabIndex = 117
        Me.lblProductDetails.Text = "تفاصيل"
        '
        'txtProductDetails
        '
        Me.txtProductDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductDetails.Location = New System.Drawing.Point(0, 0)
        Me.txtProductDetails.Name = "txtProductDetails"
        Me.txtProductDetails.Size = New System.Drawing.Size(337, 31)
        Me.txtProductDetails.TabIndex = 0
        '
        'PSubAmount
        '
        Me.PSubAmount.Controls.Add(Me.lblSubAmount)
        Me.PSubAmount.Controls.Add(Me.numSubAmount)
        Me.PSubAmount.Location = New System.Drawing.Point(40, 321)
        Me.PSubAmount.Margin = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.PSubAmount.Name = "PSubAmount"
        Me.PSubAmount.Size = New System.Drawing.Size(468, 37)
        Me.PSubAmount.TabIndex = 8
        '
        'lblSubAmount
        '
        Me.lblSubAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubAmount.AutoSize = True
        Me.lblSubAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSubAmount.Location = New System.Drawing.Point(343, 3)
        Me.lblSubAmount.Name = "lblSubAmount"
        Me.lblSubAmount.Size = New System.Drawing.Size(43, 23)
        Me.lblSubAmount.TabIndex = 108
        Me.lblSubAmount.Text = "العبوة"
        '
        'numSubAmount
        '
        Me.numSubAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numSubAmount.Location = New System.Drawing.Point(0, 0)
        Me.numSubAmount.Name = "numSubAmount"
        Me.numSubAmount.Size = New System.Drawing.Size(337, 31)
        Me.numSubAmount.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PAlertAmount)
        Me.Panel1.Controls.Add(Me.PAvgUnitCostPacket)
        Me.Panel1.Controls.Add(Me.PAmountLeftPacket)
        Me.Panel1.Controls.Add(Me.PAmountLeft)
        Me.Panel1.Controls.Add(Me.PLastUnitCostPacket)
        Me.Panel1.Controls.Add(Me.PAvgUnitCost)
        Me.Panel1.Controls.Add(Me.PSellPricePacket)
        Me.Panel1.Controls.Add(Me.PLastUnitCost)
        Me.Panel1.Controls.Add(Me.PAlertAmountPacket)
        Me.Panel1.Controls.Add(Me.PSellPrice)
        Me.Panel1.Location = New System.Drawing.Point(40, 361)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(465, 212)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(126, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 23)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "صندوق"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(324, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "قطعة"
        '
        'PAlertAmount
        '
        Me.PAlertAmount.Controls.Add(Me.numAlertAmount)
        Me.PAlertAmount.Controls.Add(Me.lblAlertAmount)
        Me.PAlertAmount.Location = New System.Drawing.Point(232, 27)
        Me.PAlertAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.PAlertAmount.Name = "PAlertAmount"
        Me.PAlertAmount.Size = New System.Drawing.Size(214, 37)
        Me.PAlertAmount.TabIndex = 1
        '
        'numAlertAmount
        '
        Me.numAlertAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAlertAmount.Location = New System.Drawing.Point(0, 0)
        Me.numAlertAmount.Name = "numAlertAmount"
        Me.numAlertAmount.Size = New System.Drawing.Size(105, 31)
        Me.numAlertAmount.TabIndex = 0
        '
        'lblAlertAmount
        '
        Me.lblAlertAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlertAmount.AutoSize = True
        Me.lblAlertAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAlertAmount.Location = New System.Drawing.Point(114, 3)
        Me.lblAlertAmount.Name = "lblAlertAmount"
        Me.lblAlertAmount.Size = New System.Drawing.Size(84, 23)
        Me.lblAlertAmount.TabIndex = 130
        Me.lblAlertAmount.Text = "الكمية الحرجة"
        '
        'PAvgUnitCostPacket
        '
        Me.PAvgUnitCostPacket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PAvgUnitCostPacket.Controls.Add(Me.lblAvgUnitCostPacket)
        Me.PAvgUnitCostPacket.Controls.Add(Me.numAvgUnitCostPacket)
        Me.PAvgUnitCostPacket.Enabled = False
        Me.PAvgUnitCostPacket.Location = New System.Drawing.Point(4, 64)
        Me.PAvgUnitCostPacket.Margin = New System.Windows.Forms.Padding(0)
        Me.PAvgUnitCostPacket.Name = "PAvgUnitCostPacket"
        Me.PAvgUnitCostPacket.Size = New System.Drawing.Size(208, 37)
        Me.PAvgUnitCostPacket.TabIndex = 2
        '
        'lblAvgUnitCostPacket
        '
        Me.lblAvgUnitCostPacket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvgUnitCostPacket.AutoSize = True
        Me.lblAvgUnitCostPacket.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAvgUnitCostPacket.Location = New System.Drawing.Point(111, 3)
        Me.lblAvgUnitCostPacket.Name = "lblAvgUnitCostPacket"
        Me.lblAvgUnitCostPacket.Size = New System.Drawing.Size(93, 23)
        Me.lblAvgUnitCostPacket.TabIndex = 113
        Me.lblAvgUnitCostPacket.Text = "متوسط التكلفة"
        '
        'numAvgUnitCostPacket
        '
        Me.numAvgUnitCostPacket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAvgUnitCostPacket.Location = New System.Drawing.Point(0, 0)
        Me.numAvgUnitCostPacket.Name = "numAvgUnitCostPacket"
        Me.numAvgUnitCostPacket.Size = New System.Drawing.Size(105, 31)
        Me.numAvgUnitCostPacket.TabIndex = 0
        Me.numAvgUnitCostPacket.TabStop = False
        '
        'PAmountLeftPacket
        '
        Me.PAmountLeftPacket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PAmountLeftPacket.Controls.Add(Me.lblAmountLeftPacket)
        Me.PAmountLeftPacket.Controls.Add(Me.numAmountLeftPacket)
        Me.PAmountLeftPacket.Location = New System.Drawing.Point(4, 101)
        Me.PAmountLeftPacket.Margin = New System.Windows.Forms.Padding(0)
        Me.PAmountLeftPacket.Name = "PAmountLeftPacket"
        Me.PAmountLeftPacket.Size = New System.Drawing.Size(208, 37)
        Me.PAmountLeftPacket.TabIndex = 4
        '
        'lblAmountLeftPacket
        '
        Me.lblAmountLeftPacket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmountLeftPacket.AutoSize = True
        Me.lblAmountLeftPacket.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAmountLeftPacket.Location = New System.Drawing.Point(111, 3)
        Me.lblAmountLeftPacket.Name = "lblAmountLeftPacket"
        Me.lblAmountLeftPacket.Size = New System.Drawing.Size(93, 23)
        Me.lblAmountLeftPacket.TabIndex = 116
        Me.lblAmountLeftPacket.Text = "الكمية المتبقية"
        '
        'numAmountLeftPacket
        '
        Me.numAmountLeftPacket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmountLeftPacket.Location = New System.Drawing.Point(0, 0)
        Me.numAmountLeftPacket.Name = "numAmountLeftPacket"
        Me.numAmountLeftPacket.Size = New System.Drawing.Size(105, 31)
        Me.numAmountLeftPacket.TabIndex = 0
        '
        'PAmountLeft
        '
        Me.PAmountLeft.Controls.Add(Me.lblAmountLeft)
        Me.PAmountLeft.Controls.Add(Me.numAmountLeft)
        Me.PAmountLeft.Location = New System.Drawing.Point(232, 101)
        Me.PAmountLeft.Margin = New System.Windows.Forms.Padding(0)
        Me.PAmountLeft.Name = "PAmountLeft"
        Me.PAmountLeft.Size = New System.Drawing.Size(214, 37)
        Me.PAmountLeft.TabIndex = 5
        '
        'lblAmountLeft
        '
        Me.lblAmountLeft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmountLeft.AutoSize = True
        Me.lblAmountLeft.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAmountLeft.Location = New System.Drawing.Point(114, 3)
        Me.lblAmountLeft.Name = "lblAmountLeft"
        Me.lblAmountLeft.Size = New System.Drawing.Size(93, 23)
        Me.lblAmountLeft.TabIndex = 112
        Me.lblAmountLeft.Text = "الكمية المتبقية"
        '
        'numAmountLeft
        '
        Me.numAmountLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmountLeft.Location = New System.Drawing.Point(0, 0)
        Me.numAmountLeft.Name = "numAmountLeft"
        Me.numAmountLeft.Size = New System.Drawing.Size(105, 31)
        Me.numAmountLeft.TabIndex = 0
        '
        'PLastUnitCostPacket
        '
        Me.PLastUnitCostPacket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PLastUnitCostPacket.Controls.Add(Me.lblLastUnitCostPacket)
        Me.PLastUnitCostPacket.Controls.Add(Me.numLastUnitCostPacket)
        Me.PLastUnitCostPacket.Location = New System.Drawing.Point(4, 138)
        Me.PLastUnitCostPacket.Margin = New System.Windows.Forms.Padding(0)
        Me.PLastUnitCostPacket.Name = "PLastUnitCostPacket"
        Me.PLastUnitCostPacket.Size = New System.Drawing.Size(208, 37)
        Me.PLastUnitCostPacket.TabIndex = 6
        '
        'lblLastUnitCostPacket
        '
        Me.lblLastUnitCostPacket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastUnitCostPacket.AutoSize = True
        Me.lblLastUnitCostPacket.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLastUnitCostPacket.Location = New System.Drawing.Point(111, 3)
        Me.lblLastUnitCostPacket.Name = "lblLastUnitCostPacket"
        Me.lblLastUnitCostPacket.Size = New System.Drawing.Size(63, 23)
        Me.lblLastUnitCostPacket.TabIndex = 114
        Me.lblLastUnitCostPacket.Text = "اخر تكلفة"
        '
        'numLastUnitCostPacket
        '
        Me.numLastUnitCostPacket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numLastUnitCostPacket.Location = New System.Drawing.Point(0, 0)
        Me.numLastUnitCostPacket.Name = "numLastUnitCostPacket"
        Me.numLastUnitCostPacket.Size = New System.Drawing.Size(105, 31)
        Me.numLastUnitCostPacket.TabIndex = 0
        '
        'PAvgUnitCost
        '
        Me.PAvgUnitCost.Controls.Add(Me.lblAvgUnitCost)
        Me.PAvgUnitCost.Controls.Add(Me.numAvgUnitCost)
        Me.PAvgUnitCost.Enabled = False
        Me.PAvgUnitCost.Location = New System.Drawing.Point(232, 64)
        Me.PAvgUnitCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PAvgUnitCost.Name = "PAvgUnitCost"
        Me.PAvgUnitCost.Size = New System.Drawing.Size(214, 37)
        Me.PAvgUnitCost.TabIndex = 3
        '
        'lblAvgUnitCost
        '
        Me.lblAvgUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvgUnitCost.AutoSize = True
        Me.lblAvgUnitCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAvgUnitCost.Location = New System.Drawing.Point(114, 3)
        Me.lblAvgUnitCost.Name = "lblAvgUnitCost"
        Me.lblAvgUnitCost.Size = New System.Drawing.Size(93, 23)
        Me.lblAvgUnitCost.TabIndex = 109
        Me.lblAvgUnitCost.Text = "متوسط التكلفة"
        '
        'numAvgUnitCost
        '
        Me.numAvgUnitCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAvgUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.numAvgUnitCost.Name = "numAvgUnitCost"
        Me.numAvgUnitCost.Size = New System.Drawing.Size(105, 31)
        Me.numAvgUnitCost.TabIndex = 0
        Me.numAvgUnitCost.TabStop = False
        '
        'PSellPricePacket
        '
        Me.PSellPricePacket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PSellPricePacket.Controls.Add(Me.lblSellPricePacket)
        Me.PSellPricePacket.Controls.Add(Me.numSellPricePacket)
        Me.PSellPricePacket.Location = New System.Drawing.Point(4, 175)
        Me.PSellPricePacket.Margin = New System.Windows.Forms.Padding(0)
        Me.PSellPricePacket.Name = "PSellPricePacket"
        Me.PSellPricePacket.Size = New System.Drawing.Size(208, 37)
        Me.PSellPricePacket.TabIndex = 9
        '
        'lblSellPricePacket
        '
        Me.lblSellPricePacket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSellPricePacket.AutoSize = True
        Me.lblSellPricePacket.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSellPricePacket.Location = New System.Drawing.Point(111, 3)
        Me.lblSellPricePacket.Name = "lblSellPricePacket"
        Me.lblSellPricePacket.Size = New System.Drawing.Size(65, 23)
        Me.lblSellPricePacket.TabIndex = 115
        Me.lblSellPricePacket.Text = "سعر البيع"
        '
        'numSellPricePacket
        '
        Me.numSellPricePacket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numSellPricePacket.Location = New System.Drawing.Point(0, 0)
        Me.numSellPricePacket.Name = "numSellPricePacket"
        Me.numSellPricePacket.Size = New System.Drawing.Size(105, 31)
        Me.numSellPricePacket.TabIndex = 0
        '
        'PLastUnitCost
        '
        Me.PLastUnitCost.Controls.Add(Me.lblLastUnitCost)
        Me.PLastUnitCost.Controls.Add(Me.numLastUnitCost)
        Me.PLastUnitCost.Location = New System.Drawing.Point(232, 138)
        Me.PLastUnitCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PLastUnitCost.Name = "PLastUnitCost"
        Me.PLastUnitCost.Size = New System.Drawing.Size(214, 37)
        Me.PLastUnitCost.TabIndex = 7
        '
        'lblLastUnitCost
        '
        Me.lblLastUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastUnitCost.AutoSize = True
        Me.lblLastUnitCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLastUnitCost.Location = New System.Drawing.Point(114, 3)
        Me.lblLastUnitCost.Name = "lblLastUnitCost"
        Me.lblLastUnitCost.Size = New System.Drawing.Size(63, 23)
        Me.lblLastUnitCost.TabIndex = 110
        Me.lblLastUnitCost.Text = "اخر تكلفة"
        '
        'numLastUnitCost
        '
        Me.numLastUnitCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numLastUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.numLastUnitCost.Name = "numLastUnitCost"
        Me.numLastUnitCost.Size = New System.Drawing.Size(105, 31)
        Me.numLastUnitCost.TabIndex = 0
        '
        'PAlertAmountPacket
        '
        Me.PAlertAmountPacket.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PAlertAmountPacket.Controls.Add(Me.numAlertAmountPacket)
        Me.PAlertAmountPacket.Controls.Add(Me.lblAlertAmountPacket)
        Me.PAlertAmountPacket.Location = New System.Drawing.Point(4, 27)
        Me.PAlertAmountPacket.Margin = New System.Windows.Forms.Padding(0)
        Me.PAlertAmountPacket.Name = "PAlertAmountPacket"
        Me.PAlertAmountPacket.Size = New System.Drawing.Size(208, 37)
        Me.PAlertAmountPacket.TabIndex = 0
        '
        'numAlertAmountPacket
        '
        Me.numAlertAmountPacket.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAlertAmountPacket.Location = New System.Drawing.Point(0, 0)
        Me.numAlertAmountPacket.Name = "numAlertAmountPacket"
        Me.numAlertAmountPacket.Size = New System.Drawing.Size(105, 31)
        Me.numAlertAmountPacket.TabIndex = 0
        '
        'lblAlertAmountPacket
        '
        Me.lblAlertAmountPacket.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlertAmountPacket.AutoSize = True
        Me.lblAlertAmountPacket.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAlertAmountPacket.Location = New System.Drawing.Point(111, 3)
        Me.lblAlertAmountPacket.Name = "lblAlertAmountPacket"
        Me.lblAlertAmountPacket.Size = New System.Drawing.Size(84, 23)
        Me.lblAlertAmountPacket.TabIndex = 120
        Me.lblAlertAmountPacket.Text = "الكمية الحرجة"
        '
        'PSellPrice
        '
        Me.PSellPrice.Controls.Add(Me.lblSellPrice)
        Me.PSellPrice.Controls.Add(Me.numSellPrice)
        Me.PSellPrice.Location = New System.Drawing.Point(232, 175)
        Me.PSellPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.PSellPrice.Name = "PSellPrice"
        Me.PSellPrice.Size = New System.Drawing.Size(214, 37)
        Me.PSellPrice.TabIndex = 8
        '
        'lblSellPrice
        '
        Me.lblSellPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSellPrice.Location = New System.Drawing.Point(114, 3)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(65, 23)
        Me.lblSellPrice.TabIndex = 111
        Me.lblSellPrice.Text = "سعر البيع"
        '
        'numSellPrice
        '
        Me.numSellPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numSellPrice.Location = New System.Drawing.Point(0, 0)
        Me.numSellPrice.Name = "numSellPrice"
        Me.numSellPrice.Size = New System.Drawing.Size(105, 31)
        Me.numSellPrice.TabIndex = 0
        '
        'PExpressButtons
        '
        Me.PExpressButtons.BackColor = System.Drawing.Color.White
        Me.PExpressButtons.Controls.Add(Me.btnExit)
        Me.PExpressButtons.Controls.Add(Me.btnEnter)
        Me.PExpressButtons.Location = New System.Drawing.Point(40, 579)
        Me.PExpressButtons.Name = "PExpressButtons"
        Me.PExpressButtons.Size = New System.Drawing.Size(465, 49)
        Me.PExpressButtons.TabIndex = 10
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.FlatAppearance.BorderSize = 0
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.Location = New System.Drawing.Point(85, 5)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(198, 39)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "ادخال"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgv, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(473, 640)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToOrderColumns = True
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.White
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.cmsDGV
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(3, 4)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersWidth = 35
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(467, 632)
        Me.dgv.TabIndex = 0
        '
        'cmsDGV
        '
        Me.cmsDGV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ادارةالباركودToolStripMenuItem})
        Me.cmsDGV.Name = "cmsDGV"
        Me.cmsDGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmsDGV.Size = New System.Drawing.Size(136, 26)
        '
        'ادارةالباركودToolStripMenuItem
        '
        Me.ادارةالباركودToolStripMenuItem.Name = "ادارةالباركودToolStripMenuItem"
        Me.ادارةالباركودToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ادارةالباركودToolStripMenuItem.Text = "ادارة الباركود"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.RightToLeft = True
        '
        'btnAdd
        '
        Me.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAdd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnAdd.Image = Global.GT1.My.Resources.Resources.add
        Me.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(34, 34)
        Me.btnAdd.Text = "إظافة"
        Me.btnAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.btnAdd.ToolTipText = "إظافة F12 "
        '
        'btnCopy
        '
        Me.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnCopy.Image = Global.GT1.My.Resources.Resources.copy
        Me.btnCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(34, 34)
        Me.btnCopy.Text = "نسخ"
        Me.btnCopy.ToolTipText = "نسخ F11"
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnEdit.Image = Global.GT1.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(34, 34)
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.ToolTipText = "تعديل F2"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnSave.Image = Global.GT1.My.Resources.Resources.save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(34, 34)
        Me.btnSave.Text = "حفظ"
        Me.btnSave.ToolTipText = "حفظ F10"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnDelete.Image = Global.GT1.My.Resources.Resources.delete
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(34, 34)
        Me.btnDelete.Text = "حدف"
        Me.btnDelete.ToolTipText = "حذف Delete"
        '
        'btnRefresh
        '
        Me.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnRefresh.Image = Global.GT1.My.Resources.Resources.refresh
        Me.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(34, 34)
        Me.btnRefresh.Text = "تحديث"
        Me.btnRefresh.ToolTipText = "تحديث F5"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(134, 42)
        Me.txtSearch.Text = "بحث"
        '
        'lblTitle
        '
        Me.lblTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(49, 39)
        Me.lblTitle.Text = "العنوان"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 39)
        Me.ToolStripLabel1.Text = "المدخلات :"
        '
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(37, 39)
        Me.lblCount.Text = "000"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnCopy, Me.btnEdit, Me.btnDelete, Me.btnRefresh, Me.btnSave, Me.lblCount, Me.txtSearch, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(985, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 42)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 42)
        '
        'frm_ProductStock
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 682)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_ProductStock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الاصناف"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PProductName.ResumeLayout(False)
        Me.PProductName.PerformLayout()
        Me.PProductCode.ResumeLayout(False)
        Me.PProductCode.PerformLayout()
        Me.PBarcode.ResumeLayout(False)
        Me.PBarcode.PerformLayout()
        Me.PExDate.ResumeLayout(False)
        Me.PExDate.PerformLayout()
        Me.PRack.ResumeLayout(False)
        Me.PRack.PerformLayout()
        Me.PTypeID.ResumeLayout(False)
        Me.PTypeID.PerformLayout()
        Me.PBrandID.ResumeLayout(False)
        Me.PBrandID.PerformLayout()
        Me.PProductDetails.ResumeLayout(False)
        Me.PProductDetails.PerformLayout()
        Me.PSubAmount.ResumeLayout(False)
        Me.PSubAmount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PAlertAmount.ResumeLayout(False)
        Me.PAlertAmount.PerformLayout()
        Me.PAvgUnitCostPacket.ResumeLayout(False)
        Me.PAvgUnitCostPacket.PerformLayout()
        Me.PAmountLeftPacket.ResumeLayout(False)
        Me.PAmountLeftPacket.PerformLayout()
        Me.PAmountLeft.ResumeLayout(False)
        Me.PAmountLeft.PerformLayout()
        Me.PLastUnitCostPacket.ResumeLayout(False)
        Me.PLastUnitCostPacket.PerformLayout()
        Me.PAvgUnitCost.ResumeLayout(False)
        Me.PAvgUnitCost.PerformLayout()
        Me.PSellPricePacket.ResumeLayout(False)
        Me.PSellPricePacket.PerformLayout()
        Me.PLastUnitCost.ResumeLayout(False)
        Me.PLastUnitCost.PerformLayout()
        Me.PAlertAmountPacket.ResumeLayout(False)
        Me.PAlertAmountPacket.PerformLayout()
        Me.PSellPrice.ResumeLayout(False)
        Me.PSellPrice.PerformLayout()
        Me.PExpressButtons.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDGV.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'xx__End sub__xx
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As ByteClassLibrary.MyTextBox
    Friend WithEvents PProductName As System.Windows.Forms.Panel
    Friend WithEvents lblProductCode As System.Windows.Forms.Label
    Friend WithEvents txtProductCode As ByteClassLibrary.MyTextBox
    Friend WithEvents PProductCode As System.Windows.Forms.Panel
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As ByteClassLibrary.MyTextBox
    Friend WithEvents PBarcode As System.Windows.Forms.Panel
    Friend WithEvents lblExDate As System.Windows.Forms.Label
    Friend WithEvents dtpExDate As ByteClassLibrary.MyDateTimePicker
    Friend WithEvents PExDate As System.Windows.Forms.Panel
    Friend WithEvents lblRack As System.Windows.Forms.Label
    Friend WithEvents txtRack As ByteClassLibrary.MyTextBox
    Friend WithEvents PRack As System.Windows.Forms.Panel
    Friend WithEvents lblTypeID As System.Windows.Forms.Label
    Friend WithEvents cboTypeID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PTypeID As System.Windows.Forms.Panel
    Friend WithEvents lblBrandID As System.Windows.Forms.Label
    Friend WithEvents cboBrandID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PBrandID As System.Windows.Forms.Panel
    Friend WithEvents lblAlertAmount As System.Windows.Forms.Label
    Friend WithEvents numAlertAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAlertAmount As System.Windows.Forms.Panel
    Friend WithEvents lblSubAmount As System.Windows.Forms.Label
    Friend WithEvents numSubAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents PSubAmount As System.Windows.Forms.Panel
    Friend WithEvents lblProductDetails As System.Windows.Forms.Label
    Friend WithEvents txtProductDetails As ByteClassLibrary.MyTextBox
    Friend WithEvents PProductDetails As System.Windows.Forms.Panel

    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents lblTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PAvgUnitCostPacket As System.Windows.Forms.Panel
    Friend WithEvents lblAvgUnitCostPacket As System.Windows.Forms.Label
    Friend WithEvents numAvgUnitCostPacket As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAmountLeftPacket As System.Windows.Forms.Panel
    Friend WithEvents lblAmountLeftPacket As System.Windows.Forms.Label
    Friend WithEvents numAmountLeftPacket As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAmountLeft As System.Windows.Forms.Panel
    Friend WithEvents lblAmountLeft As System.Windows.Forms.Label
    Friend WithEvents numAmountLeft As ByteClassLibrary.MyNumericBox
    Friend WithEvents PLastUnitCostPacket As System.Windows.Forms.Panel
    Friend WithEvents lblLastUnitCostPacket As System.Windows.Forms.Label
    Friend WithEvents numLastUnitCostPacket As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAvgUnitCost As System.Windows.Forms.Panel
    Friend WithEvents lblAvgUnitCost As System.Windows.Forms.Label
    Friend WithEvents numAvgUnitCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PSellPricePacket As System.Windows.Forms.Panel
    Friend WithEvents lblSellPricePacket As System.Windows.Forms.Label
    Friend WithEvents numSellPricePacket As ByteClassLibrary.MyNumericBox
    Friend WithEvents PLastUnitCost As System.Windows.Forms.Panel
    Friend WithEvents lblLastUnitCost As System.Windows.Forms.Label
    Friend WithEvents numLastUnitCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PSellPrice As System.Windows.Forms.Panel
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
    Friend WithEvents numSellPrice As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numAlertAmountPacket As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAlertAmountPacket As System.Windows.Forms.Panel
    Friend WithEvents lblAlertAmountPacket As System.Windows.Forms.Label
    Friend WithEvents PExpressButtons As System.Windows.Forms.Panel
    Friend WithEvents btnExit As ByteClassLibrary.MyButton
    Friend WithEvents btnEnter As ByteClassLibrary.MyButton
    Friend WithEvents cmsDGV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ادارةالباركودToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'xx_Friend WithEvents_xx



End Class
