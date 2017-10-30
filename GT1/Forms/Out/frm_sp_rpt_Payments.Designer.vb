<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sp_rpt_Payments
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sp_rpt_Payments))
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
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PTreasuryNumber = New System.Windows.Forms.Panel()
        Me.lblTreasuryNumber = New System.Windows.Forms.Label()
        Me.PAccountID = New System.Windows.Forms.Panel()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.PMoneyDirectionID = New System.Windows.Forms.Panel()
        Me.lblMoneyDirectionID = New System.Windows.Forms.Label()
        Me.PchkAllPeriod = New System.Windows.Forms.Panel()
        Me.chkAllPeriod = New System.Windows.Forms.CheckBox()
        Me.PDateFrom = New System.Windows.Forms.Panel()
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.PDateTo = New System.Windows.Forms.Panel()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.PSearch = New System.Windows.Forms.Panel()
        Me.Picturebox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.bw1 = New System.ComponentModel.BackgroundWorker()
        Me.btnview = New System.Windows.Forms.ToolStripButton()
        Me.numTreasuryNumber = New ByteClassLibrary.MyNumericBox()
        Me.cboAccountID = New ByteClassLibrary.MyGridTextBox3()
        Me.cboMoneyDirectionID = New ByteClassLibrary.MyGridTextBox3()
        Me.dtpDateFrom = New ByteClassLibrary.MyDateTimePicker()
        Me.dtpDateTo = New ByteClassLibrary.MyDateTimePicker()
        Me.btnSearch = New ByteClassLibrary.MyButton()
        Me.btnprint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PTreasuryNumber.SuspendLayout()
        Me.PAccountID.SuspendLayout()
        Me.PMoneyDirectionID.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowHideSearch, Me.lblCount, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.btnEdit, Me.btnDelete, Me.ToolStripSeparator4, Me.btnview, Me.btnprint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(901, 42)
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
        Me.btnEdit.Text = "ToolStripButton4"
        '
        'btnDelete
        '
        Me.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnDelete.Image = Global.GT1.My.Resources.Resources.delete
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(34, 39)
        Me.btnDelete.Text = "ToolStripButton3"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(901, 414)
        Me.SplitContainer1.SplitterDistance = 373
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PTreasuryNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.PAccountID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PMoneyDirectionID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PchkAllPeriod)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateFrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateTo)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSearch)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(373, 414)
        Me.FlowLayoutPanel1.TabIndex = 108
        '
        'PTreasuryNumber
        '
        Me.PTreasuryNumber.Controls.Add(Me.numTreasuryNumber)
        Me.PTreasuryNumber.Controls.Add(Me.lblTreasuryNumber)
        Me.PTreasuryNumber.Location = New System.Drawing.Point(14, 10)
        Me.PTreasuryNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.PTreasuryNumber.Name = "PTreasuryNumber"
        Me.PTreasuryNumber.Size = New System.Drawing.Size(359, 37)
        Me.PTreasuryNumber.TabIndex = 200
        '
        'lblTreasuryNumber
        '
        Me.lblTreasuryNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTreasuryNumber.AutoSize = True
        Me.lblTreasuryNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTreasuryNumber.Location = New System.Drawing.Point(234, 3)
        Me.lblTreasuryNumber.Name = "lblTreasuryNumber"
        Me.lblTreasuryNumber.Size = New System.Drawing.Size(74, 23)
        Me.lblTreasuryNumber.TabIndex = 100
        Me.lblTreasuryNumber.Text = "رقم الايصال"
        '
        'PAccountID
        '
        Me.PAccountID.Controls.Add(Me.cboAccountID)
        Me.PAccountID.Controls.Add(Me.lblAccountID)
        Me.PAccountID.Location = New System.Drawing.Point(14, 47)
        Me.PAccountID.Margin = New System.Windows.Forms.Padding(0)
        Me.PAccountID.Name = "PAccountID"
        Me.PAccountID.Size = New System.Drawing.Size(359, 37)
        Me.PAccountID.TabIndex = 201
        '
        'lblAccountID
        '
        Me.lblAccountID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAccountID.Location = New System.Drawing.Point(234, 3)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(49, 23)
        Me.lblAccountID.TabIndex = 101
        Me.lblAccountID.Text = "الحساب"
        '
        'PMoneyDirectionID
        '
        Me.PMoneyDirectionID.Controls.Add(Me.cboMoneyDirectionID)
        Me.PMoneyDirectionID.Controls.Add(Me.lblMoneyDirectionID)
        Me.PMoneyDirectionID.Location = New System.Drawing.Point(14, 84)
        Me.PMoneyDirectionID.Margin = New System.Windows.Forms.Padding(0)
        Me.PMoneyDirectionID.Name = "PMoneyDirectionID"
        Me.PMoneyDirectionID.Size = New System.Drawing.Size(359, 37)
        Me.PMoneyDirectionID.TabIndex = 202
        '
        'lblMoneyDirectionID
        '
        Me.lblMoneyDirectionID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoneyDirectionID.AutoSize = True
        Me.lblMoneyDirectionID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblMoneyDirectionID.Location = New System.Drawing.Point(234, 3)
        Me.lblMoneyDirectionID.Name = "lblMoneyDirectionID"
        Me.lblMoneyDirectionID.Size = New System.Drawing.Size(54, 23)
        Me.lblMoneyDirectionID.TabIndex = 102
        Me.lblMoneyDirectionID.Text = "المعاملة"
        '
        'PchkAllPeriod
        '
        Me.PchkAllPeriod.Controls.Add(Me.chkAllPeriod)
        Me.PchkAllPeriod.Location = New System.Drawing.Point(14, 121)
        Me.PchkAllPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.PchkAllPeriod.Name = "PchkAllPeriod"
        Me.PchkAllPeriod.Size = New System.Drawing.Size(359, 37)
        Me.PchkAllPeriod.TabIndex = 203
        '
        'chkAllPeriod
        '
        Me.chkAllPeriod.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkAllPeriod.Location = New System.Drawing.Point(0, 0)
        Me.chkAllPeriod.Name = "chkAllPeriod"
        Me.chkAllPeriod.Size = New System.Drawing.Size(228, 31)
        Me.chkAllPeriod.TabIndex = 3
        Me.chkAllPeriod.Text = "كل الفترة"
        Me.chkAllPeriod.UseVisualStyleBackColor = True
        '
        'PDateFrom
        '
        Me.PDateFrom.Controls.Add(Me.dtpDateFrom)
        Me.PDateFrom.Controls.Add(Me.lblDateFrom)
        Me.PDateFrom.Location = New System.Drawing.Point(14, 158)
        Me.PDateFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateFrom.Name = "PDateFrom"
        Me.PDateFrom.Size = New System.Drawing.Size(359, 37)
        Me.PDateFrom.TabIndex = 204
        '
        'lblDateFrom
        '
        Me.lblDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateFrom.Location = New System.Drawing.Point(234, 3)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(26, 23)
        Me.lblDateFrom.TabIndex = 104
        Me.lblDateFrom.Text = "من"
        '
        'PDateTo
        '
        Me.PDateTo.Controls.Add(Me.dtpDateTo)
        Me.PDateTo.Controls.Add(Me.lblDateTo)
        Me.PDateTo.Location = New System.Drawing.Point(14, 195)
        Me.PDateTo.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateTo.Name = "PDateTo"
        Me.PDateTo.Size = New System.Drawing.Size(359, 37)
        Me.PDateTo.TabIndex = 205
        '
        'lblDateTo
        '
        Me.lblDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateTo.Location = New System.Drawing.Point(234, 3)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(25, 23)
        Me.lblDateTo.TabIndex = 105
        Me.lblDateTo.Text = "الى"
        '
        'PSearch
        '
        Me.PSearch.Controls.Add(Me.btnSearch)
        Me.PSearch.Controls.Add(Me.Picturebox1)
        Me.PSearch.Location = New System.Drawing.Point(14, 232)
        Me.PSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.PSearch.Name = "PSearch"
        Me.PSearch.Size = New System.Drawing.Size(359, 37)
        Me.PSearch.TabIndex = 206
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(0, 0)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 7
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(524, 414)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(3, 3)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.RowHeadersWidth = 35
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(518, 408)
        Me.dgv.TabIndex = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
        '
        'btnview
        '
        Me.btnview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnview.Image = Global.GT1.My.Resources.Resources.view
        Me.btnview.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(34, 39)
        Me.btnview.Text = "ToolStripButton3"
        '
        'numTreasuryNumber
        '
        Me.numTreasuryNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numTreasuryNumber.Location = New System.Drawing.Point(0, 0)
        Me.numTreasuryNumber.Name = "numTreasuryNumber"
        Me.numTreasuryNumber.Size = New System.Drawing.Size(228, 31)
        Me.numTreasuryNumber.TabIndex = 0
        '
        'cboAccountID
        '
        Me.cboAccountID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAccountID.IsDgvLocationHeightSet = False
        Me.cboAccountID.Location = New System.Drawing.Point(0, 0)
        Me.cboAccountID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAccountID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboAccountID.MyIsColumnHeaderVisible = False
        Me.cboAccountID.MySelectedValue = Nothing
        Me.cboAccountID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboAccountID.Name = "cboAccountID"
        Me.cboAccountID.Size = New System.Drawing.Size(228, 31)
        Me.cboAccountID.TabIndex = 1
        Me.cboAccountID.TabOnEnter = True
        '
        'cboMoneyDirectionID
        '
        Me.cboMoneyDirectionID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboMoneyDirectionID.IsDgvLocationHeightSet = False
        Me.cboMoneyDirectionID.Location = New System.Drawing.Point(0, 0)
        Me.cboMoneyDirectionID.Margin = New System.Windows.Forms.Padding(0)
        Me.cboMoneyDirectionID.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboMoneyDirectionID.MyIsColumnHeaderVisible = False
        Me.cboMoneyDirectionID.MySelectedValue = Nothing
        Me.cboMoneyDirectionID.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboMoneyDirectionID.Name = "cboMoneyDirectionID"
        Me.cboMoneyDirectionID.Size = New System.Drawing.Size(228, 31)
        Me.cboMoneyDirectionID.TabIndex = 2
        Me.cboMoneyDirectionID.TabOnEnter = True
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
        Me.dtpDateFrom.Size = New System.Drawing.Size(228, 31)
        Me.dtpDateFrom.TabIndex = 4
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
        Me.dtpDateTo.Size = New System.Drawing.Size(228, 31)
        Me.dtpDateTo.TabIndex = 5
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
        Me.btnSearch.Size = New System.Drawing.Size(184, 38)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "عرض"
        '
        'btnprint
        '
        Me.btnprint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnprint.Image = Global.GT1.My.Resources.Resources.print
        Me.btnprint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(34, 39)
        Me.btnprint.Text = "ToolStripButton3"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Margin = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 42)
        '
        'frm_sp_rpt_Payments
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(901, 456)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_sp_rpt_Payments"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الايصالات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PTreasuryNumber.ResumeLayout(False)
        Me.PTreasuryNumber.PerformLayout()
        Me.PAccountID.ResumeLayout(False)
        Me.PAccountID.PerformLayout()
        Me.PMoneyDirectionID.ResumeLayout(False)
        Me.PMoneyDirectionID.PerformLayout()
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
    Friend WithEvents lblTreasuryNumber As System.Windows.Forms.Label
    Friend WithEvents numTreasuryNumber As ByteClassLibrary.MyNumericBox
    Friend WithEvents PTreasuryNumber As System.Windows.Forms.Panel
    Friend WithEvents lblAccountID As System.Windows.Forms.Label
    Friend WithEvents cboAccountID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PAccountID As System.Windows.Forms.Panel
    Friend WithEvents lblMoneyDirectionID As System.Windows.Forms.Label
    Friend WithEvents cboMoneyDirectionID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PMoneyDirectionID As System.Windows.Forms.Panel
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
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnview As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnprint As System.Windows.Forms.ToolStripButton
    'xx_Friend WithEvents_xx



End Class
