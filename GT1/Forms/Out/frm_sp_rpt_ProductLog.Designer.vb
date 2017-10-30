<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sp_rpt_ProductLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sp_rpt_ProductLog))
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnShowHideSearch = New System.Windows.Forms.ToolStripButton()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTitle = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.اخفاءبياناتالقطعةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اخفاءبياناتالصندوقToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اظهارالكلToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PStockID = New System.Windows.Forms.Panel()
        Me.cboStockID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblStockID = New System.Windows.Forms.Label()
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
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PStockID.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowHideSearch, Me.btnView, Me.lblCount, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.btnPrint, Me.ToolStripSplitButton1, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(852, 42)
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
        'btnView
        '
        Me.btnView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnView.Image = Global.GT1.My.Resources.Resources.view
        Me.btnView.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnView.Margin = New System.Windows.Forms.Padding(4)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(34, 34)
        Me.btnView.Text = "ToolStripButton3"
        Me.btnView.ToolTipText = "عرض F8"
        Me.btnView.Visible = False
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
        'btnPrint
        '
        Me.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrint.Image = Global.GT1.My.Resources.Resources.print
        Me.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(34, 39)
        Me.btnPrint.Text = "ToolStripButton3"
        Me.btnPrint.Visible = False
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اخفاءبياناتالقطعةToolStripMenuItem, Me.اخفاءبياناتالصندوقToolStripMenuItem, Me.اظهارالكلToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.GT1.My.Resources.Resources._option
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(46, 39)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        '
        'اخفاءبياناتالقطعةToolStripMenuItem
        '
        Me.اخفاءبياناتالقطعةToolStripMenuItem.Name = "اخفاءبياناتالقطعةToolStripMenuItem"
        Me.اخفاءبياناتالقطعةToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.اخفاءبياناتالقطعةToolStripMenuItem.Text = "اخفاء بيانات القطعة"
        '
        'اخفاءبياناتالصندوقToolStripMenuItem
        '
        Me.اخفاءبياناتالصندوقToolStripMenuItem.Name = "اخفاءبياناتالصندوقToolStripMenuItem"
        Me.اخفاءبياناتالصندوقToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.اخفاءبياناتالصندوقToolStripMenuItem.Text = "اخفاء بيانات الصندوق"
        '
        'اظهارالكلToolStripMenuItem
        '
        Me.اظهارالكلToolStripMenuItem.Name = "اظهارالكلToolStripMenuItem"
        Me.اظهارالكلToolStripMenuItem.Size = New System.Drawing.Size(197, 28)
        Me.اظهارالكلToolStripMenuItem.Text = "اظهار الكل"
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
        Me.SplitContainer1.Size = New System.Drawing.Size(852, 332)
        Me.SplitContainer1.SplitterDistance = 527
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Controls.Add(Me.PStockID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PchkAllPeriod)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateFrom)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDateTo)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSearch)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(527, 332)
        Me.FlowLayoutPanel1.TabIndex = 108
        '
        'PStockID
        '
        Me.PStockID.Controls.Add(Me.cboStockID)
        Me.PStockID.Controls.Add(Me.lblStockID)
        Me.PStockID.Location = New System.Drawing.Point(58, 10)
        Me.PStockID.Margin = New System.Windows.Forms.Padding(0)
        Me.PStockID.Name = "PStockID"
        Me.PStockID.Size = New System.Drawing.Size(469, 37)
        Me.PStockID.TabIndex = 200
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
        Me.cboStockID.Size = New System.Drawing.Size(338, 31)
        Me.cboStockID.TabIndex = 0
        Me.cboStockID.TabOnEnter = True
        '
        'lblStockID
        '
        Me.lblStockID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStockID.AutoSize = True
        Me.lblStockID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStockID.Location = New System.Drawing.Point(344, 3)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(46, 23)
        Me.lblStockID.TabIndex = 100
        Me.lblStockID.Text = "الصنف"
        '
        'PchkAllPeriod
        '
        Me.PchkAllPeriod.Controls.Add(Me.chkAllPeriod)
        Me.PchkAllPeriod.Location = New System.Drawing.Point(58, 47)
        Me.PchkAllPeriod.Margin = New System.Windows.Forms.Padding(0)
        Me.PchkAllPeriod.Name = "PchkAllPeriod"
        Me.PchkAllPeriod.Size = New System.Drawing.Size(469, 37)
        Me.PchkAllPeriod.TabIndex = 201
        '
        'chkAllPeriod
        '
        Me.chkAllPeriod.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkAllPeriod.Location = New System.Drawing.Point(110, 6)
        Me.chkAllPeriod.Name = "chkAllPeriod"
        Me.chkAllPeriod.Size = New System.Drawing.Size(228, 31)
        Me.chkAllPeriod.TabIndex = 1
        Me.chkAllPeriod.Text = "كل الفترة"
        Me.chkAllPeriod.UseVisualStyleBackColor = True
        '
        'PDateFrom
        '
        Me.PDateFrom.Controls.Add(Me.dtpDateFrom)
        Me.PDateFrom.Controls.Add(Me.lblDateFrom)
        Me.PDateFrom.Location = New System.Drawing.Point(58, 84)
        Me.PDateFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateFrom.Name = "PDateFrom"
        Me.PDateFrom.Size = New System.Drawing.Size(469, 37)
        Me.PDateFrom.TabIndex = 202
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
        Me.dtpDateFrom.Size = New System.Drawing.Size(338, 31)
        Me.dtpDateFrom.TabIndex = 2
        '
        'lblDateFrom
        '
        Me.lblDateFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateFrom.Location = New System.Drawing.Point(344, 3)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(26, 23)
        Me.lblDateFrom.TabIndex = 102
        Me.lblDateFrom.Text = "من"
        '
        'PDateTo
        '
        Me.PDateTo.Controls.Add(Me.dtpDateTo)
        Me.PDateTo.Controls.Add(Me.lblDateTo)
        Me.PDateTo.Location = New System.Drawing.Point(58, 121)
        Me.PDateTo.Margin = New System.Windows.Forms.Padding(0)
        Me.PDateTo.Name = "PDateTo"
        Me.PDateTo.Size = New System.Drawing.Size(469, 37)
        Me.PDateTo.TabIndex = 203
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
        Me.dtpDateTo.Size = New System.Drawing.Size(338, 31)
        Me.dtpDateTo.TabIndex = 3
        '
        'lblDateTo
        '
        Me.lblDateTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateTo.Location = New System.Drawing.Point(344, 3)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(25, 23)
        Me.lblDateTo.TabIndex = 103
        Me.lblDateTo.Text = "الى"
        '
        'PSearch
        '
        Me.PSearch.Controls.Add(Me.btnSearch)
        Me.PSearch.Controls.Add(Me.Picturebox1)
        Me.PSearch.Location = New System.Drawing.Point(58, 158)
        Me.PSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.PSearch.Name = "PSearch"
        Me.PSearch.Size = New System.Drawing.Size(469, 37)
        Me.PSearch.TabIndex = 204
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
        Me.btnSearch.Size = New System.Drawing.Size(294, 38)
        Me.btnSearch.TabIndex = 4
        Me.btnSearch.Text = "عرض"
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(0, 0)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 5
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(321, 332)
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
        Me.dgv.Size = New System.Drawing.Size(315, 326)
        Me.dgv.TabIndex = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
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
        'frm_sp_rpt_ProductLog
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(852, 374)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_sp_rpt_ProductLog"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "حركة صنف"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PStockID.ResumeLayout(False)
        Me.PStockID.PerformLayout()
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
Friend WithEvents lblStockID As System.Windows.Forms.Label
Friend WithEvents cboStockID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PStockID As System.Windows.Forms.Panel
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
    Friend WithEvents btnView As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bw1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents اخفاءبياناتالقطعةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اخفاءبياناتالصندوقToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اظهارالكلToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    'xx_Friend WithEvents_xx



End Class
