<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sp_rpt_Stock
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sp_rpt_Stock))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PAmountType = New System.Windows.Forms.Panel()
        Me.cboAmountType = New ByteClassLibrary.MyGridTextBox3()
        Me.lblAmountType = New System.Windows.Forms.Label()
        Me.PExDate = New System.Windows.Forms.Panel()
        Me.dtpExDate = New ByteClassLibrary.MyDateTimePicker()
        Me.lblExDate = New System.Windows.Forms.Label()
        Me.PBrandID = New System.Windows.Forms.Panel()
        Me.cboBrandID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblBrandID = New System.Windows.Forms.Label()
        Me.PTypeID = New System.Windows.Forms.Panel()
        Me.cboTypeID = New ByteClassLibrary.MyGridTextBox3()
        Me.lblTypeID = New System.Windows.Forms.Label()
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
        Me.PAmountType.SuspendLayout()
        Me.PExDate.SuspendLayout()
        Me.PBrandID.SuspendLayout()
        Me.PTypeID.SuspendLayout()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowHideSearch, Me.btnView, Me.lblCount, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(779, 42)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(779, 332)
        Me.SplitContainer1.SplitterDistance = 415
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PAmountType)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.PBrandID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PTypeID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PSearch)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(415, 332)
        Me.FlowLayoutPanel1.TabIndex = 108
        '
        'PAmountType
        '
        Me.PAmountType.Controls.Add(Me.cboAmountType)
        Me.PAmountType.Controls.Add(Me.lblAmountType)
        Me.PAmountType.Location = New System.Drawing.Point(56, 10)
        Me.PAmountType.Margin = New System.Windows.Forms.Padding(0)
        Me.PAmountType.Name = "PAmountType"
        Me.PAmountType.Size = New System.Drawing.Size(359, 37)
        Me.PAmountType.TabIndex = 200
        '
        'cboAmountType
        '
        Me.cboAmountType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAmountType.IsDgvLocationHeightSet = False
        Me.cboAmountType.Location = New System.Drawing.Point(0, 0)
        Me.cboAmountType.Margin = New System.Windows.Forms.Padding(0)
        Me.cboAmountType.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboAmountType.MyIsColumnHeaderVisible = False
        Me.cboAmountType.MySelectedValue = Nothing
        Me.cboAmountType.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboAmountType.Name = "cboAmountType"
        Me.cboAmountType.Size = New System.Drawing.Size(228, 31)
        Me.cboAmountType.TabIndex = 0
        Me.cboAmountType.TabOnEnter = True
        '
        'lblAmountType
        '
        Me.lblAmountType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmountType.AutoSize = True
        Me.lblAmountType.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAmountType.Location = New System.Drawing.Point(234, 3)
        Me.lblAmountType.Name = "lblAmountType"
        Me.lblAmountType.Size = New System.Drawing.Size(44, 23)
        Me.lblAmountType.TabIndex = 100
        Me.lblAmountType.Text = "الكمية"
        '
        'PExDate
        '
        Me.PExDate.Controls.Add(Me.dtpExDate)
        Me.PExDate.Controls.Add(Me.lblExDate)
        Me.PExDate.Location = New System.Drawing.Point(56, 47)
        Me.PExDate.Margin = New System.Windows.Forms.Padding(0)
        Me.PExDate.Name = "PExDate"
        Me.PExDate.Size = New System.Drawing.Size(359, 37)
        Me.PExDate.TabIndex = 202
        '
        'dtpExDate
        '
        Me.dtpExDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpExDate.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpExDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExDate.HighlightColor = System.Drawing.Color.Empty
        Me.dtpExDate.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpExDate.IsHighLight = False
        Me.dtpExDate.Location = New System.Drawing.Point(0, 0)
        Me.dtpExDate.Name = "dtpExDate"
        Me.dtpExDate.Size = New System.Drawing.Size(228, 31)
        Me.dtpExDate.TabIndex = 2
        '
        'lblExDate
        '
        Me.lblExDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExDate.AutoSize = True
        Me.lblExDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExDate.Location = New System.Drawing.Point(234, 3)
        Me.lblExDate.Name = "lblExDate"
        Me.lblExDate.Size = New System.Drawing.Size(61, 23)
        Me.lblExDate.TabIndex = 102
        Me.lblExDate.Text = "الصلاحية"
        '
        'PBrandID
        '
        Me.PBrandID.Controls.Add(Me.cboBrandID)
        Me.PBrandID.Controls.Add(Me.lblBrandID)
        Me.PBrandID.Location = New System.Drawing.Point(56, 84)
        Me.PBrandID.Margin = New System.Windows.Forms.Padding(0)
        Me.PBrandID.Name = "PBrandID"
        Me.PBrandID.Size = New System.Drawing.Size(359, 37)
        Me.PBrandID.TabIndex = 203
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
        Me.cboBrandID.Size = New System.Drawing.Size(228, 31)
        Me.cboBrandID.TabIndex = 3
        Me.cboBrandID.TabOnEnter = True
        '
        'lblBrandID
        '
        Me.lblBrandID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBrandID.Location = New System.Drawing.Point(234, 3)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(46, 23)
        Me.lblBrandID.TabIndex = 103
        Me.lblBrandID.Text = "الماركة"
        '
        'PTypeID
        '
        Me.PTypeID.Controls.Add(Me.cboTypeID)
        Me.PTypeID.Controls.Add(Me.lblTypeID)
        Me.PTypeID.Location = New System.Drawing.Point(56, 121)
        Me.PTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.PTypeID.Name = "PTypeID"
        Me.PTypeID.Size = New System.Drawing.Size(359, 37)
        Me.PTypeID.TabIndex = 204
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
        Me.cboTypeID.Size = New System.Drawing.Size(228, 31)
        Me.cboTypeID.TabIndex = 4
        Me.cboTypeID.TabOnEnter = True
        '
        'lblTypeID
        '
        Me.lblTypeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTypeID.AutoSize = True
        Me.lblTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTypeID.Location = New System.Drawing.Point(234, 3)
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Size = New System.Drawing.Size(36, 23)
        Me.lblTypeID.TabIndex = 104
        Me.lblTypeID.Text = "النوع"
        '
        'PSearch
        '
        Me.PSearch.Controls.Add(Me.btnSearch)
        Me.PSearch.Controls.Add(Me.Picturebox1)
        Me.PSearch.Location = New System.Drawing.Point(56, 158)
        Me.PSearch.Margin = New System.Windows.Forms.Padding(0)
        Me.PSearch.Name = "PSearch"
        Me.PSearch.Size = New System.Drawing.Size(359, 37)
        Me.PSearch.TabIndex = 205
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
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "عرض"
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(0, 0)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 6
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(360, 332)
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
        Me.dgv.Size = New System.Drawing.Size(354, 326)
        Me.dgv.TabIndex = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
        '
        'frm_sp_rpt_Stock
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(779, 374)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_sp_rpt_Stock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "المخزون"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PAmountType.ResumeLayout(False)
        Me.PAmountType.PerformLayout()
        Me.PExDate.ResumeLayout(False)
        Me.PExDate.PerformLayout()
        Me.PBrandID.ResumeLayout(False)
        Me.PBrandID.PerformLayout()
        Me.PTypeID.ResumeLayout(False)
        Me.PTypeID.PerformLayout()
        Me.PSearch.ResumeLayout(False)
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub 'xx__End sub__xx
Friend WithEvents lblAmountType As System.Windows.Forms.Label
Friend WithEvents cboAmountType As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PAmountType As System.Windows.Forms.Panel
    Friend WithEvents lblExDate As System.Windows.Forms.Label
Friend WithEvents dtpExDate As ByteClassLibrary.MyDateTimePicker
Friend WithEvents PExDate As System.Windows.Forms.Panel
Friend WithEvents lblBrandID As System.Windows.Forms.Label
Friend WithEvents cboBrandID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PBrandID As System.Windows.Forms.Panel
Friend WithEvents lblTypeID As System.Windows.Forms.Label
Friend WithEvents cboTypeID As ByteClassLibrary.MyGridTextBox3
Friend WithEvents PTypeID As System.Windows.Forms.Panel
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
    'xx_Friend WithEvents_xx



End Class
