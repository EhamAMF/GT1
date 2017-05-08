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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ProductStock))
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PProductName = New System.Windows.Forms.Panel()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.PExDate = New System.Windows.Forms.Panel()
        Me.lblExDate = New System.Windows.Forms.Label()
        Me.PBarcode = New System.Windows.Forms.Panel()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.PProductDetails = New System.Windows.Forms.Panel()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.PTypeID = New System.Windows.Forms.Panel()
        Me.lblTypeID = New System.Windows.Forms.Label()
        Me.PBrandID = New System.Windows.Forms.Panel()
        Me.lblBrandID = New System.Windows.Forms.Label()
        Me.PRack = New System.Windows.Forms.Panel()
        Me.lblRack = New System.Windows.Forms.Label()
        Me.PAlertAmount = New System.Windows.Forms.Panel()
        Me.lblAlertAmount = New System.Windows.Forms.Label()
        Me.PAvgUnitCost = New System.Windows.Forms.Panel()
        Me.lblAvgUnitCost = New System.Windows.Forms.Label()
        Me.PSubAmount = New System.Windows.Forms.Panel()
        Me.lblSubAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PPacketCost = New System.Windows.Forms.Panel()
        Me.lblPacketLastCost = New System.Windows.Forms.Label()
        Me.PPacketAmount = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pAmount = New System.Windows.Forms.Panel()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Pbtn = New System.Windows.Forms.Panel()
        Me.PLastUnitCost = New System.Windows.Forms.Panel()
        Me.lblLastUnitCost = New System.Windows.Forms.Label()
        Me.PSellPrice = New System.Windows.Forms.Panel()
        Me.lblSellPrice = New System.Windows.Forms.Label()
        Me.PPacketSellPrice = New System.Windows.Forms.Panel()
        Me.lblPacketSellPrice = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
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
        Me.txtProductName = New ByteClassLibrary.MyTextBox()
        Me.dtpExDate = New ByteClassLibrary.MyDateTimePicker()
        Me.txtBarcode = New ByteClassLibrary.MyTextBox()
        Me.txtProductDetails = New ByteClassLibrary.MyTextBox()
        Me.cboTypeID = New ByteClassLibrary.MyGridTextBox3()
        Me.cboBrandID = New ByteClassLibrary.MyGridTextBox3()
        Me.txtRack = New ByteClassLibrary.MyTextBox()
        Me.numAlertAmount = New ByteClassLibrary.MyNumericBox()
        Me.numAvgUnitCost = New ByteClassLibrary.MyNumericBox()
        Me.numSubAmount = New ByteClassLibrary.MyNumericBox()
        Me.numPacketCost = New ByteClassLibrary.MyNumericBox()
        Me.numPacketAmount = New ByteClassLibrary.MyNumericBox()
        Me.numAmount = New ByteClassLibrary.MyNumericBox()
        Me.btnSave2 = New ByteClassLibrary.MyButton()
        Me.btnExit = New ByteClassLibrary.MyButton()
        Me.numLastUnitCost = New ByteClassLibrary.MyNumericBox()
        Me.numSellPrice = New ByteClassLibrary.MyNumericBox()
        Me.numPacketSellPrice = New ByteClassLibrary.MyNumericBox()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PProductName.SuspendLayout()
        Me.PExDate.SuspendLayout()
        Me.PBarcode.SuspendLayout()
        Me.PProductDetails.SuspendLayout()
        Me.PTypeID.SuspendLayout()
        Me.PBrandID.SuspendLayout()
        Me.PRack.SuspendLayout()
        Me.PAlertAmount.SuspendLayout()
        Me.PAvgUnitCost.SuspendLayout()
        Me.PSubAmount.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PPacketCost.SuspendLayout()
        Me.PPacketAmount.SuspendLayout()
        Me.pAmount.SuspendLayout()
        Me.Pbtn.SuspendLayout()
        Me.PLastUnitCost.SuspendLayout()
        Me.PSellPrice.SuspendLayout()
        Me.PPacketSellPrice.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.IsSplitterFixed = True
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
        Me.SplitContainer1.Size = New System.Drawing.Size(820, 568)
        Me.SplitContainer1.SplitterDistance = 415
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.PProductName)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.PBarcode)
        Me.FlowLayoutPanel1.Controls.Add(Me.PProductDetails)
        Me.FlowLayoutPanel1.Controls.Add(Me.PTypeID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PBrandID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PRack)
        Me.FlowLayoutPanel1.Controls.Add(Me.PAlertAmount)
        Me.FlowLayoutPanel1.Controls.Add(Me.PAvgUnitCost)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSubAmount)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(415, 568)
        Me.FlowLayoutPanel1.TabIndex = 107
        '
        'PProductName
        '
        Me.PProductName.Controls.Add(Me.lblProductName)
        Me.PProductName.Controls.Add(Me.txtProductName)
        Me.PProductName.Location = New System.Drawing.Point(26, 10)
        Me.PProductName.Margin = New System.Windows.Forms.Padding(0)
        Me.PProductName.Name = "PProductName"
        Me.PProductName.Size = New System.Drawing.Size(389, 37)
        Me.PProductName.TabIndex = 0
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.AutoSize = True
        Me.lblProductName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductName.Location = New System.Drawing.Point(264, 3)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(46, 23)
        Me.lblProductName.TabIndex = 103
        Me.lblProductName.Text = "الصنف"
        '
        'PExDate
        '
        Me.PExDate.Controls.Add(Me.lblExDate)
        Me.PExDate.Controls.Add(Me.dtpExDate)
        Me.PExDate.Location = New System.Drawing.Point(26, 47)
        Me.PExDate.Margin = New System.Windows.Forms.Padding(0)
        Me.PExDate.Name = "PExDate"
        Me.PExDate.Size = New System.Drawing.Size(389, 37)
        Me.PExDate.TabIndex = 1
        '
        'lblExDate
        '
        Me.lblExDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExDate.AutoSize = True
        Me.lblExDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExDate.Location = New System.Drawing.Point(264, 3)
        Me.lblExDate.Name = "lblExDate"
        Me.lblExDate.Size = New System.Drawing.Size(61, 23)
        Me.lblExDate.TabIndex = 104
        Me.lblExDate.Text = "الصلاحية"
        '
        'PBarcode
        '
        Me.PBarcode.Controls.Add(Me.lblBarcode)
        Me.PBarcode.Controls.Add(Me.txtBarcode)
        Me.PBarcode.Enabled = False
        Me.PBarcode.Location = New System.Drawing.Point(26, 84)
        Me.PBarcode.Margin = New System.Windows.Forms.Padding(0)
        Me.PBarcode.Name = "PBarcode"
        Me.PBarcode.Size = New System.Drawing.Size(389, 37)
        Me.PBarcode.TabIndex = 2
        '
        'lblBarcode
        '
        Me.lblBarcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBarcode.Location = New System.Drawing.Point(264, 3)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(43, 23)
        Me.lblBarcode.TabIndex = 100
        Me.lblBarcode.Text = "باركود"
        '
        'PProductDetails
        '
        Me.PProductDetails.Controls.Add(Me.lblProductDetails)
        Me.PProductDetails.Controls.Add(Me.txtProductDetails)
        Me.PProductDetails.Location = New System.Drawing.Point(26, 121)
        Me.PProductDetails.Margin = New System.Windows.Forms.Padding(0)
        Me.PProductDetails.Name = "PProductDetails"
        Me.PProductDetails.Size = New System.Drawing.Size(389, 37)
        Me.PProductDetails.TabIndex = 3
        '
        'lblProductDetails
        '
        Me.lblProductDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductDetails.AutoSize = True
        Me.lblProductDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductDetails.Location = New System.Drawing.Point(264, 3)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(61, 23)
        Me.lblProductDetails.TabIndex = 106
        Me.lblProductDetails.Text = "التفاصيل"
        '
        'PTypeID
        '
        Me.PTypeID.Controls.Add(Me.lblTypeID)
        Me.PTypeID.Controls.Add(Me.cboTypeID)
        Me.PTypeID.Location = New System.Drawing.Point(26, 158)
        Me.PTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.PTypeID.Name = "PTypeID"
        Me.PTypeID.Size = New System.Drawing.Size(389, 37)
        Me.PTypeID.TabIndex = 4
        '
        'lblTypeID
        '
        Me.lblTypeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeID.AutoSize = True
        Me.lblTypeID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTypeID.Location = New System.Drawing.Point(264, 3)
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Size = New System.Drawing.Size(36, 23)
        Me.lblTypeID.TabIndex = 101
        Me.lblTypeID.Text = "النوع"
        '
        'PBrandID
        '
        Me.PBrandID.Controls.Add(Me.lblBrandID)
        Me.PBrandID.Controls.Add(Me.cboBrandID)
        Me.PBrandID.Location = New System.Drawing.Point(26, 195)
        Me.PBrandID.Margin = New System.Windows.Forms.Padding(0)
        Me.PBrandID.Name = "PBrandID"
        Me.PBrandID.Size = New System.Drawing.Size(389, 37)
        Me.PBrandID.TabIndex = 5
        '
        'lblBrandID
        '
        Me.lblBrandID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBrandID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBrandID.Location = New System.Drawing.Point(264, 3)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(46, 23)
        Me.lblBrandID.TabIndex = 102
        Me.lblBrandID.Text = "الماركة"
        '
        'PRack
        '
        Me.PRack.Controls.Add(Me.lblRack)
        Me.PRack.Controls.Add(Me.txtRack)
        Me.PRack.Location = New System.Drawing.Point(26, 232)
        Me.PRack.Margin = New System.Windows.Forms.Padding(0)
        Me.PRack.Name = "PRack"
        Me.PRack.Size = New System.Drawing.Size(389, 37)
        Me.PRack.TabIndex = 6
        '
        'lblRack
        '
        Me.lblRack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRack.AutoSize = True
        Me.lblRack.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblRack.Location = New System.Drawing.Point(264, 3)
        Me.lblRack.Name = "lblRack"
        Me.lblRack.Size = New System.Drawing.Size(34, 23)
        Me.lblRack.TabIndex = 105
        Me.lblRack.Text = "الرف"
        '
        'PAlertAmount
        '
        Me.PAlertAmount.Controls.Add(Me.lblAlertAmount)
        Me.PAlertAmount.Controls.Add(Me.numAlertAmount)
        Me.PAlertAmount.Location = New System.Drawing.Point(26, 269)
        Me.PAlertAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.PAlertAmount.Name = "PAlertAmount"
        Me.PAlertAmount.Size = New System.Drawing.Size(389, 37)
        Me.PAlertAmount.TabIndex = 7
        '
        'lblAlertAmount
        '
        Me.lblAlertAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAlertAmount.AutoSize = True
        Me.lblAlertAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAlertAmount.Location = New System.Drawing.Point(264, 3)
        Me.lblAlertAmount.Name = "lblAlertAmount"
        Me.lblAlertAmount.Size = New System.Drawing.Size(84, 23)
        Me.lblAlertAmount.TabIndex = 112
        Me.lblAlertAmount.Text = "الكمية الحرجة"
        '
        'PAvgUnitCost
        '
        Me.PAvgUnitCost.Controls.Add(Me.lblAvgUnitCost)
        Me.PAvgUnitCost.Controls.Add(Me.numAvgUnitCost)
        Me.PAvgUnitCost.Enabled = False
        Me.PAvgUnitCost.Location = New System.Drawing.Point(26, 306)
        Me.PAvgUnitCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PAvgUnitCost.Name = "PAvgUnitCost"
        Me.PAvgUnitCost.Size = New System.Drawing.Size(389, 37)
        Me.PAvgUnitCost.TabIndex = 8
        '
        'lblAvgUnitCost
        '
        Me.lblAvgUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvgUnitCost.AutoSize = True
        Me.lblAvgUnitCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAvgUnitCost.Location = New System.Drawing.Point(264, 3)
        Me.lblAvgUnitCost.Name = "lblAvgUnitCost"
        Me.lblAvgUnitCost.Size = New System.Drawing.Size(93, 23)
        Me.lblAvgUnitCost.TabIndex = 108
        Me.lblAvgUnitCost.Text = "متوسط التكلفة"
        '
        'PSubAmount
        '
        Me.PSubAmount.Controls.Add(Me.lblSubAmount)
        Me.PSubAmount.Controls.Add(Me.numSubAmount)
        Me.PSubAmount.Location = New System.Drawing.Point(26, 343)
        Me.PSubAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.PSubAmount.Name = "PSubAmount"
        Me.PSubAmount.Size = New System.Drawing.Size(389, 37)
        Me.PSubAmount.TabIndex = 9
        '
        'lblSubAmount
        '
        Me.lblSubAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubAmount.AutoSize = True
        Me.lblSubAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSubAmount.Location = New System.Drawing.Point(264, 3)
        Me.lblSubAmount.Name = "lblSubAmount"
        Me.lblSubAmount.Size = New System.Drawing.Size(43, 23)
        Me.lblSubAmount.TabIndex = 110
        Me.lblSubAmount.Text = "العبوة"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PPacketCost)
        Me.Panel1.Controls.Add(Me.PPacketAmount)
        Me.Panel1.Controls.Add(Me.pAmount)
        Me.Panel1.Controls.Add(Me.Pbtn)
        Me.Panel1.Controls.Add(Me.PLastUnitCost)
        Me.Panel1.Controls.Add(Me.PSellPrice)
        Me.Panel1.Controls.Add(Me.PPacketSellPrice)
        Me.Panel1.Location = New System.Drawing.Point(26, 383)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 178)
        Me.Panel1.TabIndex = 214
        '
        'PPacketCost
        '
        Me.PPacketCost.Controls.Add(Me.lblPacketLastCost)
        Me.PPacketCost.Controls.Add(Me.numPacketCost)
        Me.PPacketCost.Location = New System.Drawing.Point(0, 49)
        Me.PPacketCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PPacketCost.Name = "PPacketCost"
        Me.PPacketCost.Size = New System.Drawing.Size(193, 37)
        Me.PPacketCost.TabIndex = 1
        '
        'lblPacketLastCost
        '
        Me.lblPacketLastCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPacketLastCost.AutoSize = True
        Me.lblPacketLastCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPacketLastCost.Location = New System.Drawing.Point(98, 3)
        Me.lblPacketLastCost.Name = "lblPacketLastCost"
        Me.lblPacketLastCost.Size = New System.Drawing.Size(92, 23)
        Me.lblPacketLastCost.TabIndex = 107
        Me.lblPacketLastCost.Text = "تكلفة الصندوق"
        '
        'PPacketAmount
        '
        Me.PPacketAmount.Controls.Add(Me.Label1)
        Me.PPacketAmount.Controls.Add(Me.numPacketAmount)
        Me.PPacketAmount.Location = New System.Drawing.Point(0, 12)
        Me.PPacketAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.PPacketAmount.Name = "PPacketAmount"
        Me.PPacketAmount.Size = New System.Drawing.Size(193, 37)
        Me.PPacketAmount.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(110, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "كمية صندوق"
        '
        'pAmount
        '
        Me.pAmount.Controls.Add(Me.lblAmount)
        Me.pAmount.Controls.Add(Me.numAmount)
        Me.pAmount.Location = New System.Drawing.Point(202, 12)
        Me.pAmount.Margin = New System.Windows.Forms.Padding(0)
        Me.pAmount.Name = "pAmount"
        Me.pAmount.Size = New System.Drawing.Size(178, 37)
        Me.pAmount.TabIndex = 213
        '
        'lblAmount
        '
        Me.lblAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmount.AutoSize = True
        Me.lblAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAmount.Location = New System.Drawing.Point(111, 3)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(44, 23)
        Me.lblAmount.TabIndex = 107
        Me.lblAmount.Text = "الكمية"
        '
        'Pbtn
        '
        Me.Pbtn.Controls.Add(Me.btnSave2)
        Me.Pbtn.Controls.Add(Me.btnExit)
        Me.Pbtn.Location = New System.Drawing.Point(0, 123)
        Me.Pbtn.Margin = New System.Windows.Forms.Padding(0)
        Me.Pbtn.Name = "Pbtn"
        Me.Pbtn.Size = New System.Drawing.Size(233, 50)
        Me.Pbtn.TabIndex = 5
        '
        'PLastUnitCost
        '
        Me.PLastUnitCost.Controls.Add(Me.lblLastUnitCost)
        Me.PLastUnitCost.Controls.Add(Me.numLastUnitCost)
        Me.PLastUnitCost.Location = New System.Drawing.Point(202, 49)
        Me.PLastUnitCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PLastUnitCost.Name = "PLastUnitCost"
        Me.PLastUnitCost.Size = New System.Drawing.Size(178, 37)
        Me.PLastUnitCost.TabIndex = 2
        '
        'lblLastUnitCost
        '
        Me.lblLastUnitCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastUnitCost.AutoSize = True
        Me.lblLastUnitCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblLastUnitCost.Location = New System.Drawing.Point(110, 8)
        Me.lblLastUnitCost.Name = "lblLastUnitCost"
        Me.lblLastUnitCost.Size = New System.Drawing.Size(42, 23)
        Me.lblLastUnitCost.TabIndex = 107
        Me.lblLastUnitCost.Text = "تكلفة"
        '
        'PSellPrice
        '
        Me.PSellPrice.Controls.Add(Me.lblSellPrice)
        Me.PSellPrice.Controls.Add(Me.numSellPrice)
        Me.PSellPrice.Location = New System.Drawing.Point(202, 86)
        Me.PSellPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.PSellPrice.Name = "PSellPrice"
        Me.PSellPrice.Size = New System.Drawing.Size(178, 37)
        Me.PSellPrice.TabIndex = 3
        '
        'lblSellPrice
        '
        Me.lblSellPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSellPrice.Location = New System.Drawing.Point(110, 3)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(65, 23)
        Me.lblSellPrice.TabIndex = 109
        Me.lblSellPrice.Text = "سعر البيع"
        '
        'PPacketSellPrice
        '
        Me.PPacketSellPrice.Controls.Add(Me.lblPacketSellPrice)
        Me.PPacketSellPrice.Controls.Add(Me.numPacketSellPrice)
        Me.PPacketSellPrice.Location = New System.Drawing.Point(0, 86)
        Me.PPacketSellPrice.Margin = New System.Windows.Forms.Padding(0)
        Me.PPacketSellPrice.Name = "PPacketSellPrice"
        Me.PPacketSellPrice.Size = New System.Drawing.Size(193, 37)
        Me.PPacketSellPrice.TabIndex = 4
        '
        'lblPacketSellPrice
        '
        Me.lblPacketSellPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPacketSellPrice.AutoSize = True
        Me.lblPacketSellPrice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPacketSellPrice.Location = New System.Drawing.Point(109, 6)
        Me.lblPacketSellPrice.Name = "lblPacketSellPrice"
        Me.lblPacketSellPrice.Size = New System.Drawing.Size(81, 23)
        Me.lblPacketSellPrice.TabIndex = 111
        Me.lblPacketSellPrice.Text = "بيع الصندوق"
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(401, 568)
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
        Me.dgv.Size = New System.Drawing.Size(395, 560)
        Me.dgv.TabIndex = 0
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnCopy, Me.btnEdit, Me.btnDelete, Me.btnRefresh, Me.btnSave, Me.lblCount, Me.txtSearch, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.ToolStripButton3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(820, 42)
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
        'txtProductName
        '
        Me.txtProductName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductName.Location = New System.Drawing.Point(0, 0)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(258, 31)
        Me.txtProductName.TabIndex = 3
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
        Me.dtpExDate.Size = New System.Drawing.Size(258, 31)
        Me.dtpExDate.TabIndex = 4
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.Location = New System.Drawing.Point(0, 0)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(258, 31)
        Me.txtBarcode.TabIndex = 0
        '
        'txtProductDetails
        '
        Me.txtProductDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProductDetails.Location = New System.Drawing.Point(0, 0)
        Me.txtProductDetails.Name = "txtProductDetails"
        Me.txtProductDetails.Size = New System.Drawing.Size(258, 31)
        Me.txtProductDetails.TabIndex = 6
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
        Me.cboTypeID.Size = New System.Drawing.Size(258, 31)
        Me.cboTypeID.TabIndex = 1
        Me.cboTypeID.TabOnEnter = True
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
        Me.cboBrandID.Size = New System.Drawing.Size(258, 31)
        Me.cboBrandID.TabIndex = 2
        Me.cboBrandID.TabOnEnter = True
        '
        'txtRack
        '
        Me.txtRack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRack.Location = New System.Drawing.Point(0, 0)
        Me.txtRack.Name = "txtRack"
        Me.txtRack.Size = New System.Drawing.Size(258, 31)
        Me.txtRack.TabIndex = 5
        '
        'numAlertAmount
        '
        Me.numAlertAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAlertAmount.Location = New System.Drawing.Point(0, 0)
        Me.numAlertAmount.Name = "numAlertAmount"
        Me.numAlertAmount.Size = New System.Drawing.Size(258, 31)
        Me.numAlertAmount.TabIndex = 13
        '
        'numAvgUnitCost
        '
        Me.numAvgUnitCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAvgUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.numAvgUnitCost.Name = "numAvgUnitCost"
        Me.numAvgUnitCost.Size = New System.Drawing.Size(258, 31)
        Me.numAvgUnitCost.TabIndex = 9
        '
        'numSubAmount
        '
        Me.numSubAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numSubAmount.Location = New System.Drawing.Point(0, 0)
        Me.numSubAmount.Name = "numSubAmount"
        Me.numSubAmount.Size = New System.Drawing.Size(258, 31)
        Me.numSubAmount.TabIndex = 11
        '
        'numPacketCost
        '
        Me.numPacketCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPacketCost.Location = New System.Drawing.Point(0, 0)
        Me.numPacketCost.Name = "numPacketCost"
        Me.numPacketCost.Size = New System.Drawing.Size(97, 31)
        Me.numPacketCost.TabIndex = 7
        '
        'numPacketAmount
        '
        Me.numPacketAmount.AcceptsReturn = True
        Me.numPacketAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPacketAmount.Location = New System.Drawing.Point(0, 0)
        Me.numPacketAmount.Name = "numPacketAmount"
        Me.numPacketAmount.Size = New System.Drawing.Size(97, 31)
        Me.numPacketAmount.TabIndex = 8
        '
        'numAmount
        '
        Me.numAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numAmount.Location = New System.Drawing.Point(0, 0)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(104, 31)
        Me.numAmount.TabIndex = 8
        '
        'btnSave2
        '
        Me.btnSave2.BackgroundImage = CType(resources.GetObject("btnSave2.BackgroundImage"), System.Drawing.Image)
        Me.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave2.FlatAppearance.BorderSize = 0
        Me.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave2.Location = New System.Drawing.Point(103, 3)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(125, 43)
        Me.btnSave2.TabIndex = 14
        Me.btnSave2.Text = "حفظ"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(3, 3)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(94, 43)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "خروج"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'numLastUnitCost
        '
        Me.numLastUnitCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numLastUnitCost.Location = New System.Drawing.Point(0, 0)
        Me.numLastUnitCost.Name = "numLastUnitCost"
        Me.numLastUnitCost.Size = New System.Drawing.Size(104, 31)
        Me.numLastUnitCost.TabIndex = 0
        '
        'numSellPrice
        '
        Me.numSellPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numSellPrice.Location = New System.Drawing.Point(3, 0)
        Me.numSellPrice.Name = "numSellPrice"
        Me.numSellPrice.Size = New System.Drawing.Size(101, 31)
        Me.numSellPrice.TabIndex = 10
        '
        'numPacketSellPrice
        '
        Me.numPacketSellPrice.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numPacketSellPrice.Location = New System.Drawing.Point(0, 0)
        Me.numPacketSellPrice.Name = "numPacketSellPrice"
        Me.numPacketSellPrice.Size = New System.Drawing.Size(97, 31)
        Me.numPacketSellPrice.TabIndex = 12
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(34, 39)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(34, 39)
        Me.ToolStripButton4.Text = "ToolStripButton4"
        '
        'frm_ProductStock
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(820, 610)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_ProductStock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "ادارة الاصناف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PProductName.ResumeLayout(False)
        Me.PProductName.PerformLayout()
        Me.PExDate.ResumeLayout(False)
        Me.PExDate.PerformLayout()
        Me.PBarcode.ResumeLayout(False)
        Me.PBarcode.PerformLayout()
        Me.PProductDetails.ResumeLayout(False)
        Me.PProductDetails.PerformLayout()
        Me.PTypeID.ResumeLayout(False)
        Me.PTypeID.PerformLayout()
        Me.PBrandID.ResumeLayout(False)
        Me.PBrandID.PerformLayout()
        Me.PRack.ResumeLayout(False)
        Me.PRack.PerformLayout()
        Me.PAlertAmount.ResumeLayout(False)
        Me.PAlertAmount.PerformLayout()
        Me.PAvgUnitCost.ResumeLayout(False)
        Me.PAvgUnitCost.PerformLayout()
        Me.PSubAmount.ResumeLayout(False)
        Me.PSubAmount.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.PPacketCost.ResumeLayout(False)
        Me.PPacketCost.PerformLayout()
        Me.PPacketAmount.ResumeLayout(False)
        Me.PPacketAmount.PerformLayout()
        Me.pAmount.ResumeLayout(False)
        Me.pAmount.PerformLayout()
        Me.Pbtn.ResumeLayout(False)
        Me.PLastUnitCost.ResumeLayout(False)
        Me.PLastUnitCost.PerformLayout()
        Me.PSellPrice.ResumeLayout(False)
        Me.PSellPrice.PerformLayout()
        Me.PPacketSellPrice.ResumeLayout(False)
        Me.PPacketSellPrice.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'xx__End sub__xx
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As ByteClassLibrary.MyTextBox
    Friend WithEvents PBarcode As System.Windows.Forms.Panel
    Friend WithEvents lblTypeID As System.Windows.Forms.Label
    Friend WithEvents cboTypeID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PTypeID As System.Windows.Forms.Panel
    Friend WithEvents lblBrandID As System.Windows.Forms.Label
    Friend WithEvents cboBrandID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PBrandID As System.Windows.Forms.Panel
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As ByteClassLibrary.MyTextBox
    Friend WithEvents PProductName As System.Windows.Forms.Panel
    Friend WithEvents lblExDate As System.Windows.Forms.Label
    Friend WithEvents dtpExDate As ByteClassLibrary.MyDateTimePicker
    Friend WithEvents PExDate As System.Windows.Forms.Panel
    Friend WithEvents lblRack As System.Windows.Forms.Label
    Friend WithEvents txtRack As ByteClassLibrary.MyTextBox
    Friend WithEvents PRack As System.Windows.Forms.Panel
    Friend WithEvents lblProductDetails As System.Windows.Forms.Label
    Friend WithEvents txtProductDetails As ByteClassLibrary.MyTextBox
    Friend WithEvents PProductDetails As System.Windows.Forms.Panel
    Friend WithEvents lblLastUnitCost As System.Windows.Forms.Label
    Friend WithEvents numLastUnitCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PLastUnitCost As System.Windows.Forms.Panel
    Friend WithEvents lblAvgUnitCost As System.Windows.Forms.Label
    Friend WithEvents numAvgUnitCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAvgUnitCost As System.Windows.Forms.Panel
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
    Friend WithEvents numSellPrice As ByteClassLibrary.MyNumericBox
    Friend WithEvents PSellPrice As System.Windows.Forms.Panel
    Friend WithEvents lblSubAmount As System.Windows.Forms.Label
    Friend WithEvents numSubAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents PSubAmount As System.Windows.Forms.Panel
    Friend WithEvents lblPacketSellPrice As System.Windows.Forms.Label
    Friend WithEvents PPacketSellPrice As System.Windows.Forms.Panel
    Friend WithEvents lblAlertAmount As System.Windows.Forms.Label
    Friend WithEvents numAlertAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents PAlertAmount As System.Windows.Forms.Panel

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
    Friend WithEvents pAmount As System.Windows.Forms.Panel
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents numAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents Pbtn As System.Windows.Forms.Panel
    Friend WithEvents btnSave2 As ByteClassLibrary.MyButton
    Friend WithEvents btnExit As ByteClassLibrary.MyButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PPacketCost As System.Windows.Forms.Panel
    Friend WithEvents lblPacketLastCost As System.Windows.Forms.Label
    Friend WithEvents numPacketCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PPacketAmount As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numPacketAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents numPacketSellPrice As ByteClassLibrary.MyNumericBox
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    'xx_Friend WithEvents_xx



End Class
