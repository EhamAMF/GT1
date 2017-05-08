<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sp_rpt_invoices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sp_rpt_invoices))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnShowHideSearch = New System.Windows.Forms.ToolStripButton()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTitle = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PInvoiceTypeID = New System.Windows.Forms.Panel()
        Me.cboInvoiceTypeID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblInvoiceTypeID = New System.Windows.Forms.Label()
        Me.PInvoiceNumber = New System.Windows.Forms.Panel()
        Me.numInvoiceNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblInvoiceNumber = New System.Windows.Forms.Label()
        Me.PStockID = New System.Windows.Forms.Panel()
        Me.cboStockID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.PInvoiceRealNumber = New System.Windows.Forms.Panel()
        Me.txtInvoiceRealNumber = New ByteClassLibrary.MyTextBox()
        Me.lblInvoiceRealNumber = New System.Windows.Forms.Label()
        Me.PorgInvoiceNumber = New System.Windows.Forms.Panel()
        Me.numorgInvoiceNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblorgInvoiceNumber = New System.Windows.Forms.Label()
        Me.PAgentID = New System.Windows.Forms.Panel()
        Me.cboAgentID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblAgentID = New System.Windows.Forms.Label()
        Me.PUserID = New System.Windows.Forms.Panel()
        Me.cboUserID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.PchkAllPeriod = New System.Windows.Forms.Panel()
        Me.chkAllPeriod = New System.Windows.Forms.CheckBox()
        Me.PDateFrom = New System.Windows.Forms.Panel()
        Me.dtpDateFrom = New ByteClassLibrary.MyDateTimePicker()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.PDateTo = New System.Windows.Forms.Panel()
        Me.dtpDateTo = New ByteClassLibrary.MyDateTimePicker()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.PSearch = New System.Windows.Forms.Panel()
        Me.btnSearch = New ByteClassLibrary.MyButton()
        Me.Picturebox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bw1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PInvoiceTypeID.SuspendLayout()
        Me.PInvoiceNumber.SuspendLayout()
        Me.PStockID.SuspendLayout()
        Me.PInvoiceRealNumber.SuspendLayout()
        Me.PorgInvoiceNumber.SuspendLayout()
        Me.PAgentID.SuspendLayout()
        Me.PUserID.SuspendLayout()
        Me.PchkAllPeriod.SuspendLayout()
        Me.PDateFrom.SuspendLayout()
        Me.PDateTo.SuspendLayout()
        Me.PSearch.SuspendLayout()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowHideSearch, Me.lblCount, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.btnEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(913, 42)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnShowHideSearch
        '
        Me.btnShowHideSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnShowHideSearch.Image = Global.GT1.My.Resources.Resources.SHR
        Me.btnShowHideSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnShowHideSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowHideSearch.Name = "btnShowHideSearch"
        Me.btnShowHideSearch.Size = New System.Drawing.Size(34, 34)
        Me.btnShowHideSearch.Text = "ToolStripButton1"
        Me.btnShowHideSearch.ToolTipText = "F7"
        '
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(37, 39)
        Me.lblCount.Text = "000"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(67, 39)
        Me.ToolStripLabel1.Text = "المدخلات :"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(6, 42)
        '
        'lblTitle
        '
        Me.lblTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(49, 39)
        Me.lblTitle.Text = "العنوان"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 42)
        '
        'btnEdit
        '
        Me.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEdit.Image = Global.GT1.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(34, 39)
        Me.btnEdit.Text = "ToolStripButton3"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(913, 561)
        Me.SplitContainer1.SplitterDistance = 529
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceTypeID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.PStockID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceRealNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.PorgInvoiceNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.PAgentID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PUserID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PchkAllPeriod)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateFrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateTo)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSearch)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(529, 561)
        Me.FlowLayoutPanel1.TabIndex = 108
        '
        'PInvoiceTypeID
        '
        Me.PInvoiceTypeID.Controls.Add(Me.cboInvoiceTypeID)
        Me.PInvoiceTypeID.Controls.Add(Me.lblInvoiceTypeID)
        Me.PInvoiceTypeID.Location = New System.Drawing.Point(15, 10)
        Me.PInvoiceTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceTypeID.Name = "PInvoiceTypeID"
        Me.PInvoiceTypeID.Size = New System.Drawing.Size(514, 37)
        Me.PInvoiceTypeID.TabIndex = 200
        '
        'cboInvoiceTypeID
        '
        Me.cboInvoiceTypeID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboInvoiceTypeID.IsDgvLocationHeightSet = False
        Me.cboInvoiceTypeID.Location = New System.Drawing.Point(0, 0)
        Me.cboInvoiceTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboInvoiceTypeID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboInvoiceTypeID.MyIsColumnHeaderVisible = False
        Me.cboInvoiceTypeID.MySelectedValue = Nothing
        Me.cboInvoiceTypeID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboInvoiceTypeID.Name = "cboInvoiceTypeID"
        Me.cboInvoiceTypeID.Size = New System.Drawing.Size(383, 31)
        Me.cboInvoiceTypeID.TabIndex = 0
        Me.cboInvoiceTypeID.TabOnEnter = True
        '
        'lblInvoiceTypeID
        '
        Me.lblInvoiceTypeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceTypeID.AutoSize = True
        Me.lblInvoiceTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceTypeID.Location = New System.Drawing.Point(389, 3)
        Me.lblInvoiceTypeID.Name = "lblInvoiceTypeID"
        Me.lblInvoiceTypeID.Size = New System.Drawing.Size(74, 23)
        Me.lblInvoiceTypeID.TabIndex = 100
        Me.lblInvoiceTypeID.Text = "نوع الفاتورة"
        '
        'PInvoiceNumber
        '
        Me.PInvoiceNumber.Controls.Add(Me.numInvoiceNumber)
        Me.PInvoiceNumber.Controls.Add(Me.lblInvoiceNumber)
        Me.PInvoiceNumber.Location = New System.Drawing.Point(15, 47)
        Me.PInvoiceNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceNumber.Name = "PInvoiceNumber"
        Me.PInvoiceNumber.Size = New System.Drawing.Size(514, 37)
        Me.PInvoiceNumber.TabIndex = 201
        '
        'numInvoiceNumber
        '
        Me.numInvoiceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInvoiceNumber.Location = New System.Drawing.Point(0, 0)
        Me.numInvoiceNumber.Name = "numInvoiceNumber"
        Me.numInvoiceNumber.Size = New System.Drawing.Size(383, 31)
        Me.numInvoiceNumber.TabIndex = 1
        '
        'lblInvoiceNumber
        '
        Me.lblInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceNumber.AutoSize = True
        Me.lblInvoiceNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceNumber.Location = New System.Drawing.Point(389, 3)
        Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
        Me.lblInvoiceNumber.Size = New System.Drawing.Size(76, 23)
        Me.lblInvoiceNumber.TabIndex = 101
        Me.lblInvoiceNumber.Text = "رقم الفاتورة"
        '
        'PStockID
        '
        Me.PStockID.Controls.Add(Me.cboStockID)
        Me.PStockID.Controls.Add(Me.lblStockID)
        Me.PStockID.Location = New System.Drawing.Point(15, 84)
        Me.PStockID.Margin = New System.Windows.Forms.Padding(0)
        Me.PStockID.Name = "PStockID"
        Me.PStockID.Size = New System.Drawing.Size(514, 37)
        Me.PStockID.TabIndex = 202
        '
        'cboStockID
        '
        Me.cboStockID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboStockID.IsDgvLocationHeightSet = False
        Me.cboStockID.Location = New System.Drawing.Point(0, 0)
        Me.cboStockID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboStockID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboStockID.MyIsColumnHeaderVisible = False
        Me.cboStockID.MySelectedValue = Nothing
        Me.cboStockID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboStockID.Name = "cboStockID"
        Me.cboStockID.Size = New System.Drawing.Size(383, 31)
        Me.cboStockID.TabIndex = 2
        Me.cboStockID.TabOnEnter = True
        '
        'lblStockID
        '
        Me.lblStockID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockID.AutoSize = True
        Me.lblStockID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStockID.Location = New System.Drawing.Point(389, 3)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(109, 23)
        Me.lblStockID.TabIndex = 102
        Me.lblStockID.Text = "تحتوي على الصنف"
        '
        'PInvoiceRealNumber
        '
        Me.PInvoiceRealNumber.Controls.Add(Me.txtInvoiceRealNumber)
        Me.PInvoiceRealNumber.Controls.Add(Me.lblInvoiceRealNumber)
        Me.PInvoiceRealNumber.Location = New System.Drawing.Point(15, 121)
        Me.PInvoiceRealNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceRealNumber.Name = "PInvoiceRealNumber"
        Me.PInvoiceRealNumber.Size = New System.Drawing.Size(514, 37)
        Me.PInvoiceRealNumber.TabIndex = 203
        '
        'txtInvoiceRealNumber
        '
        Me.txtInvoiceRealNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtInvoiceRealNumber.Location = New System.Drawing.Point(0, 0)
        Me.txtInvoiceRealNumber.Name = "txtInvoiceRealNumber"
        Me.txtInvoiceRealNumber.Size = New System.Drawing.Size(383, 31)
        Me.txtInvoiceRealNumber.TabIndex = 3
        '
        'lblInvoiceRealNumber
        '
        Me.lblInvoiceRealNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceRealNumber.AutoSize = True
        Me.lblInvoiceRealNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceRealNumber.Location = New System.Drawing.Point(389, 3)
        Me.lblInvoiceRealNumber.Name = "lblInvoiceRealNumber"
        Me.lblInvoiceRealNumber.Size = New System.Drawing.Size(73, 23)
        Me.lblInvoiceRealNumber.TabIndex = 103
        Me.lblInvoiceRealNumber.Text = "رقم المصدر"
        '
        'PorgInvoiceNumber
        '
        Me.PorgInvoiceNumber.Controls.Add(Me.numorgInvoiceNumber)
        Me.PorgInvoiceNumber.Controls.Add(Me.lblorgInvoiceNumber)
        Me.PorgInvoiceNumber.Location = New System.Drawing.Point(15, 158)
        Me.PorgInvoiceNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.PorgInvoiceNumber.Name = "PorgInvoiceNumber"
        Me.PorgInvoiceNumber.Size = New System.Drawing.Size(514, 37)
        Me.PorgInvoiceNumber.TabIndex = 204
        '
        'numorgInvoiceNumber
        '
        Me.numorgInvoiceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numorgInvoiceNumber.Location = New System.Drawing.Point(0, 0)
        Me.numorgInvoiceNumber.Name = "numorgInvoiceNumber"
        Me.numorgInvoiceNumber.Size = New System.Drawing.Size(383, 31)
        Me.numorgInvoiceNumber.TabIndex = 4
        '
        'lblorgInvoiceNumber
        '
        Me.lblorgInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblorgInvoiceNumber.AutoSize = True
        Me.lblorgInvoiceNumber.Font = New System.Drawing.Font("Aljazeera", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblorgInvoiceNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblorgInvoiceNumber.Location = New System.Drawing.Point(389, 3)
        Me.lblorgInvoiceNumber.Name = "lblorgInvoiceNumber"
        Me.lblorgInvoiceNumber.Size = New System.Drawing.Size(123, 19)
        Me.lblorgInvoiceNumber.TabIndex = 104
        Me.lblorgInvoiceNumber.Text = "مسترجعة عن فاتورة رقم"
        '
        'PAgentID
        '
        Me.PAgentID.Controls.Add(Me.cboAgentID)
        Me.PAgentID.Controls.Add(Me.lblAgentID)
        Me.PAgentID.Location = New System.Drawing.Point(15, 195)
        Me.PAgentID.Margin = New System.Windows.Forms.Padding(0)
        Me.PAgentID.Name = "PAgentID"
        Me.PAgentID.Size = New System.Drawing.Size(514, 37)
        Me.PAgentID.TabIndex = 205
        '
        'cboAgentID
        '
        Me.cboAgentID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAgentID.IsDgvLocationHeightSet = False
        Me.cboAgentID.Location = New System.Drawing.Point(0, 0)
        Me.cboAgentID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAgentID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboAgentID.MyIsColumnHeaderVisible = False
        Me.cboAgentID.MySelectedValue = Nothing
        Me.cboAgentID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboAgentID.Name = "cboAgentID"
        Me.cboAgentID.Size = New System.Drawing.Size(383, 31)
        Me.cboAgentID.TabIndex = 5
        Me.cboAgentID.TabOnEnter = True
        '
        'lblAgentID
        '
        Me.lblAgentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAgentID.AutoSize = True
        Me.lblAgentID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAgentID.Location = New System.Drawing.Point(389, 3)
        Me.lblAgentID.Name = "lblAgentID"
        Me.lblAgentID.Size = New System.Drawing.Size(48, 23)
        Me.lblAgentID.TabIndex = 105
        Me.lblAgentID.Text = "العميل"
        '
        'PUserID
        '
        Me.PUserID.Controls.Add(Me.cboUserID)
        Me.PUserID.Controls.Add(Me.lblUserID)
        Me.PUserID.Location = New System.Drawing.Point(15, 232)
        Me.PUserID.Margin = New System.Windows.Forms.Padding(0)
        Me.PUserID.Name = "PUserID"
        Me.PUserID.Size = New System.Drawing.Size(514, 37)
        Me.PUserID.TabIndex = 206
        '
        'cboUserID
        '
        Me.cboUserID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboUserID.IsDgvLocationHeightSet = False
        Me.cboUserID.Location = New System.Drawing.Point(0, 0)
        Me.cboUserID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboUserID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboUserID.MyIsColumnHeaderVisible = False
        Me.cboUserID.MySelectedValue = Nothing
        Me.cboUserID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboUserID.Name = "cboUserID"
        Me.cboUserID.Size = New System.Drawing.Size(383, 31)
        Me.cboUserID.TabIndex = 6
        Me.cboUserID.TabOnEnter = True
        '
        'lblUserID
        '
        Me.lblUserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUserID.Location = New System.Drawing.Point(389, 3)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 23)
        Me.lblUserID.TabIndex = 106
        Me.lblUserID.Text = "المستخدم"
        '
        'PchkAllPeriod
        '
        Me.PchkAllPeriod.Controls.Add(Me.chkAllPeriod)
        Me.PchkAllPeriod.Location = New System.Drawing.Point(15, 269)
        Me.PchkAllPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.PchkAllPeriod.Name = "PchkAllPeriod"
        Me.PchkAllPeriod.Size = New System.Drawing.Size(514, 37)
        Me.PchkAllPeriod.TabIndex = 207
        '
        'chkAllPeriod
        '
        Me.chkAllPeriod.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkAllPeriod.Location = New System.Drawing.Point(155, 3)
        Me.chkAllPeriod.Name = "chkAllPeriod"
        Me.chkAllPeriod.Size = New System.Drawing.Size(228, 31)
        Me.chkAllPeriod.TabIndex = 7
        Me.chkAllPeriod.Text = "كل الفترة"
        Me.chkAllPeriod.UseVisualStyleBackColor = True
        '
        'PDateFrom
        '
        Me.PDateFrom.Controls.Add(Me.dtpDateFrom)
        Me.PDateFrom.Controls.Add(Me.lblDateFrom)
        Me.PDateFrom.Location = New System.Drawing.Point(15, 306)
        Me.PDateFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateFrom.Name = "PDateFrom"
        Me.PDateFrom.Size = New System.Drawing.Size(514, 37)
        Me.PDateFrom.TabIndex = 208
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateFrom.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrom.HighlightColor = System.Drawing.Color.Empty
        Me.dtpDateFrom.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpDateFrom.IsHighLight = False
        Me.dtpDateFrom.Location = New System.Drawing.Point(0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(383, 31)
        Me.dtpDateFrom.TabIndex = 8
        '
        'lblDateFrom
        '
        Me.lblDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateFrom.Location = New System.Drawing.Point(389, 3)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(26, 23)
        Me.lblDateFrom.TabIndex = 108
        Me.lblDateFrom.Text = "من"
        '
        'PDateTo
        '
        Me.PDateTo.Controls.Add(Me.dtpDateTo)
        Me.PDateTo.Controls.Add(Me.lblDateTo)
        Me.PDateTo.Location = New System.Drawing.Point(15, 343)
        Me.PDateTo.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateTo.Name = "PDateTo"
        Me.PDateTo.Size = New System.Drawing.Size(514, 37)
        Me.PDateTo.TabIndex = 209
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDateTo.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.HighlightColor = System.Drawing.Color.Empty
        Me.dtpDateTo.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpDateTo.IsHighLight = False
        Me.dtpDateTo.Location = New System.Drawing.Point(0, 0)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(383, 31)
        Me.dtpDateTo.TabIndex = 9
        '
        'lblDateTo
        '
        Me.lblDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateTo.Location = New System.Drawing.Point(389, 3)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(25, 23)
        Me.lblDateTo.TabIndex = 109
        Me.lblDateTo.Text = "الى"
        '
        'PSearch
        '
        Me.PSearch.Controls.Add(Me.btnSearch)
        Me.PSearch.Controls.Add(Me.Picturebox1)
        Me.PSearch.Location = New System.Drawing.Point(15, 380)
        Me.PSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.PSearch.Name = "PSearch"
        Me.PSearch.Size = New System.Drawing.Size(514, 37)
        Me.PSearch.TabIndex = 210
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(44, 0)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(339, 38)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.Text = "عرض"
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(0, 0)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 11
        Me.Picturebox1.TabStop = False
        Me.Picturebox1.Visible = False
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(380, 561)
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
        Me.dgv.Location = New System.Drawing.Point(3, 3)
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
        Me.dgv.Size = New System.Drawing.Size(374, 555)
        Me.dgv.TabIndex = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
        '
        'frm_sp_rpt_invoices
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(913, 603)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_sp_rpt_invoices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "بحث عن فواتير"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PInvoiceTypeID.ResumeLayout(False)
        Me.PInvoiceTypeID.PerformLayout()
        Me.PInvoiceNumber.ResumeLayout(False)
        Me.PInvoiceNumber.PerformLayout()
        Me.PStockID.ResumeLayout(False)
        Me.PStockID.PerformLayout()
        Me.PInvoiceRealNumber.ResumeLayout(False)
        Me.PInvoiceRealNumber.PerformLayout()
        Me.PorgInvoiceNumber.ResumeLayout(False)
        Me.PorgInvoiceNumber.PerformLayout()
        Me.PAgentID.ResumeLayout(False)
        Me.PAgentID.PerformLayout()
        Me.PUserID.ResumeLayout(False)
        Me.PUserID.PerformLayout()
        Me.PchkAllPeriod.ResumeLayout(False)
        Me.PDateFrom.ResumeLayout(False)
        Me.PDateFrom.PerformLayout()
        Me.PDateTo.ResumeLayout(False)
        Me.PDateTo.PerformLayout()
        Me.PSearch.ResumeLayout(False)
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'xx__End sub__xx
Friend WithEvents lblInvoiceTypeID As System.Windows.Forms.Label
Friend WithEvents cboInvoiceTypeID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PInvoiceTypeID As System.Windows.Forms.Panel
Friend WithEvents lblInvoiceNumber As System.Windows.Forms.Label
Friend WithEvents numInvoiceNumber As ByteClassLibrary.MyNumericBox
Friend WithEvents PInvoiceNumber As System.Windows.Forms.Panel
Friend WithEvents lblStockID As System.Windows.Forms.Label
Friend WithEvents cboStockID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PStockID As System.Windows.Forms.Panel
Friend WithEvents lblInvoiceRealNumber As System.Windows.Forms.Label
Friend WithEvents txtInvoiceRealNumber As ByteClassLibrary.MyTextBox
Friend WithEvents PInvoiceRealNumber As System.Windows.Forms.Panel
Friend WithEvents lblorgInvoiceNumber As System.Windows.Forms.Label
Friend WithEvents numorgInvoiceNumber As ByteClassLibrary.MyNumericBox
Friend WithEvents PorgInvoiceNumber As System.Windows.Forms.Panel
Friend WithEvents lblAgentID As System.Windows.Forms.Label
Friend WithEvents cboAgentID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PAgentID As System.Windows.Forms.Panel
Friend WithEvents lblUserID As System.Windows.Forms.Label
Friend WithEvents cboUserID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PUserID As System.Windows.Forms.Panel
Friend WithEvents chkAllPeriod As System.Windows.Forms.CheckBox
Friend WithEvents PchkAllPeriod As System.Windows.Forms.Panel
Friend WithEvents lblDateFrom As System.Windows.Forms.Label
Friend WithEvents dtpDateFrom As ByteClassLibrary.MyDateTimePicker
Friend WithEvents PDateFrom As System.Windows.Forms.Panel
Friend WithEvents lblDateTo As System.Windows.Forms.Label
Friend WithEvents dtpDateTo As ByteClassLibrary.MyDateTimePicker
Friend WithEvents PDateTo As System.Windows.Forms.Panel
Friend WithEvents btnSearch As ByteClassLibrary.MyButton
Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox
Friend WithEvents PSearch As System.Windows.Forms.Panel

    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnShowHideSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    'xx_Friend WithEvents_xx



End Class
