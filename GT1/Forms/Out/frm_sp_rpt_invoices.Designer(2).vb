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
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnView = New System.Windows.Forms.ToolStripButton()
        Me.btnPrint = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lblinvoiceTypeID = New System.Windows.Forms.Label()
        Me.cboinvoiceTypeID = New ByteClassLibrary.MyComboBox()
        Me.lblInvoiceNumber = New System.Windows.Forms.Label()
        Me.numInvoiceNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblInvoiceRealNumber = New System.Windows.Forms.Label()
        Me.numInvoiceRealNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblOrgInvoiceNumber = New System.Windows.Forms.Label()
        Me.numOrgInvoiceNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblStockID = New System.Windows.Forms.Label()
        Me.cboStockID = New ByteClassLibrary.MyComboBox()
        Me.lblAgentID = New System.Windows.Forms.Label()
        Me.cboAgentID = New ByteClassLibrary.MyComboBox()
        Me.lblDistributorID = New System.Windows.Forms.Label()
        Me.cboDistributorID = New ByteClassLibrary.MyComboBox()
        Me.lblIsPaid = New System.Windows.Forms.Label()
        Me.cboIsPaid = New ByteClassLibrary.MyComboBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.cboUserID = New ByteClassLibrary.MyComboBox()
        Me.chkAllPeriod = New System.Windows.Forms.CheckBox()
        Me.lblDateFrm = New System.Windows.Forms.Label()
        Me.dtpDateFrm = New ByteClassLibrary.MyDateTimePicker()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.dtpDateTo = New ByteClassLibrary.MyDateTimePicker()
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnShowHideSearch, Me.lblCount, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1, Me.btnEdit, Me.btnDelete, Me.btnView, Me.btnPrint})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(729, 42)
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
        Me.btnEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.btnEdit.Image = Global.GT1.My.Resources.Resources.edit
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(34, 34)
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.ToolTipText = "تعديل F2"
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblinvoiceTypeID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboinvoiceTypeID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInvoiceNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numInvoiceNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblInvoiceRealNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numInvoiceRealNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblOrgInvoiceNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.numOrgInvoiceNumber)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblStockID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboStockID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblAgentID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboAgentID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDistributorID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboDistributorID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIsPaid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboIsPaid)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblUserID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboUserID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.chkAllPeriod)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDateFrm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateFrm)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpDateTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnSearch)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Picturebox1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(729, 495)
        Me.SplitContainer1.SplitterDistance = 361
        Me.SplitContainer1.TabIndex = 2
        '
        'lblinvoiceTypeID
        '
        Me.lblinvoiceTypeID.AutoSize = True
        Me.lblinvoiceTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblinvoiceTypeID.Location = New System.Drawing.Point(223, 9)
        Me.lblinvoiceTypeID.Name = "lblinvoiceTypeID"
        Me.lblinvoiceTypeID.Size = New System.Drawing.Size(74, 23)
        Me.lblinvoiceTypeID.TabIndex = 100
        Me.lblinvoiceTypeID.Text = "نوع الفاتورة"
        '
        'cboinvoiceTypeID
        '
        Me.cboinvoiceTypeID.FormattingEnabled = True
        Me.cboinvoiceTypeID.Location = New System.Drawing.Point(3, 6)
        Me.cboinvoiceTypeID.Name = "cboinvoiceTypeID"
        Me.cboinvoiceTypeID.Size = New System.Drawing.Size(216, 31)
        Me.cboinvoiceTypeID.TabIndex = 0
        Me.cboinvoiceTypeID.TabOnEnter = True
        '
        'lblInvoiceNumber
        '
        Me.lblInvoiceNumber.AutoSize = True
        Me.lblInvoiceNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceNumber.Location = New System.Drawing.Point(223, 46)
        Me.lblInvoiceNumber.Name = "lblInvoiceNumber"
        Me.lblInvoiceNumber.Size = New System.Drawing.Size(76, 23)
        Me.lblInvoiceNumber.TabIndex = 101
        Me.lblInvoiceNumber.Text = "رقم الفاتورة"
        '
        'numInvoiceNumber
        '
        Me.numInvoiceNumber.Location = New System.Drawing.Point(3, 43)
        Me.numInvoiceNumber.Name = "numInvoiceNumber"
        Me.numInvoiceNumber.Size = New System.Drawing.Size(216, 31)
        Me.numInvoiceNumber.TabIndex = 1
        '
        'lblInvoiceRealNumber
        '
        Me.lblInvoiceRealNumber.AutoSize = True
        Me.lblInvoiceRealNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceRealNumber.Location = New System.Drawing.Point(223, 83)
        Me.lblInvoiceRealNumber.Name = "lblInvoiceRealNumber"
        Me.lblInvoiceRealNumber.Size = New System.Drawing.Size(73, 23)
        Me.lblInvoiceRealNumber.TabIndex = 102
        Me.lblInvoiceRealNumber.Text = "رقم المصدر"
        '
        'numInvoiceRealNumber
        '
        Me.numInvoiceRealNumber.Location = New System.Drawing.Point(3, 80)
        Me.numInvoiceRealNumber.Name = "numInvoiceRealNumber"
        Me.numInvoiceRealNumber.Size = New System.Drawing.Size(216, 31)
        Me.numInvoiceRealNumber.TabIndex = 2
        '
        'lblOrgInvoiceNumber
        '
        Me.lblOrgInvoiceNumber.AutoSize = True
        Me.lblOrgInvoiceNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblOrgInvoiceNumber.Location = New System.Drawing.Point(223, 120)
        Me.lblOrgInvoiceNumber.Name = "lblOrgInvoiceNumber"
        Me.lblOrgInvoiceNumber.Size = New System.Drawing.Size(93, 23)
        Me.lblOrgInvoiceNumber.TabIndex = 103
        Me.lblOrgInvoiceNumber.Text = "الفاتورة الاصلية"
        '
        'numOrgInvoiceNumber
        '
        Me.numOrgInvoiceNumber.Location = New System.Drawing.Point(3, 117)
        Me.numOrgInvoiceNumber.Name = "numOrgInvoiceNumber"
        Me.numOrgInvoiceNumber.Size = New System.Drawing.Size(216, 31)
        Me.numOrgInvoiceNumber.TabIndex = 3
        '
        'lblStockID
        '
        Me.lblStockID.AutoSize = True
        Me.lblStockID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblStockID.Location = New System.Drawing.Point(223, 157)
        Me.lblStockID.Name = "lblStockID"
        Me.lblStockID.Size = New System.Drawing.Size(46, 23)
        Me.lblStockID.TabIndex = 104
        Me.lblStockID.Text = "الصنف"
        '
        'cboStockID
        '
        Me.cboStockID.FormattingEnabled = True
        Me.cboStockID.Location = New System.Drawing.Point(3, 154)
        Me.cboStockID.Name = "cboStockID"
        Me.cboStockID.Size = New System.Drawing.Size(216, 31)
        Me.cboStockID.TabIndex = 4
        Me.cboStockID.TabOnEnter = True
        '
        'lblAgentID
        '
        Me.lblAgentID.AutoSize = True
        Me.lblAgentID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAgentID.Location = New System.Drawing.Point(223, 194)
        Me.lblAgentID.Name = "lblAgentID"
        Me.lblAgentID.Size = New System.Drawing.Size(48, 23)
        Me.lblAgentID.TabIndex = 105
        Me.lblAgentID.Text = "العميل"
        '
        'cboAgentID
        '
        Me.cboAgentID.FormattingEnabled = True
        Me.cboAgentID.Location = New System.Drawing.Point(3, 191)
        Me.cboAgentID.Name = "cboAgentID"
        Me.cboAgentID.Size = New System.Drawing.Size(216, 31)
        Me.cboAgentID.TabIndex = 5
        Me.cboAgentID.TabOnEnter = True
        '
        'lblDistributorID
        '
        Me.lblDistributorID.AutoSize = True
        Me.lblDistributorID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDistributorID.Location = New System.Drawing.Point(223, 231)
        Me.lblDistributorID.Name = "lblDistributorID"
        Me.lblDistributorID.Size = New System.Drawing.Size(51, 23)
        Me.lblDistributorID.TabIndex = 106
        Me.lblDistributorID.Text = "المسوق"
        '
        'cboDistributorID
        '
        Me.cboDistributorID.FormattingEnabled = True
        Me.cboDistributorID.Location = New System.Drawing.Point(3, 228)
        Me.cboDistributorID.Name = "cboDistributorID"
        Me.cboDistributorID.Size = New System.Drawing.Size(216, 31)
        Me.cboDistributorID.TabIndex = 6
        Me.cboDistributorID.TabOnEnter = True
        '
        'lblIsPaid
        '
        Me.lblIsPaid.AutoSize = True
        Me.lblIsPaid.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblIsPaid.Location = New System.Drawing.Point(223, 268)
        Me.lblIsPaid.Name = "lblIsPaid"
        Me.lblIsPaid.Size = New System.Drawing.Size(42, 23)
        Me.lblIsPaid.TabIndex = 107
        Me.lblIsPaid.Text = "الدفع"
        '
        'cboIsPaid
        '
        Me.cboIsPaid.FormattingEnabled = True
        Me.cboIsPaid.Location = New System.Drawing.Point(3, 265)
        Me.cboIsPaid.Name = "cboIsPaid"
        Me.cboIsPaid.Size = New System.Drawing.Size(216, 31)
        Me.cboIsPaid.TabIndex = 7
        Me.cboIsPaid.TabOnEnter = True
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblUserID.Location = New System.Drawing.Point(223, 305)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 23)
        Me.lblUserID.TabIndex = 108
        Me.lblUserID.Text = "المستخدم"
        '
        'cboUserID
        '
        Me.cboUserID.FormattingEnabled = True
        Me.cboUserID.Location = New System.Drawing.Point(3, 302)
        Me.cboUserID.Name = "cboUserID"
        Me.cboUserID.Size = New System.Drawing.Size(216, 31)
        Me.cboUserID.TabIndex = 8
        Me.cboUserID.TabOnEnter = True
        '
        'chkAllPeriod
        '
        Me.chkAllPeriod.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkAllPeriod.Location = New System.Drawing.Point(3, 339)
        Me.chkAllPeriod.Name = "chkAllPeriod"
        Me.chkAllPeriod.Size = New System.Drawing.Size(216, 31)
        Me.chkAllPeriod.TabIndex = 9
        Me.chkAllPeriod.Text = "كل الفترة"
        Me.chkAllPeriod.UseVisualStyleBackColor = True
        '
        'lblDateFrm
        '
        Me.lblDateFrm.AutoSize = True
        Me.lblDateFrm.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateFrm.Location = New System.Drawing.Point(223, 379)
        Me.lblDateFrm.Name = "lblDateFrm"
        Me.lblDateFrm.Size = New System.Drawing.Size(26, 23)
        Me.lblDateFrm.TabIndex = 110
        Me.lblDateFrm.Text = "من"
        '
        'dtpDateFrm
        '
        Me.dtpDateFrm.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpDateFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateFrm.HighlightColor = System.Drawing.Color.Empty
        Me.dtpDateFrm.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpDateFrm.IsHighLight = False
        Me.dtpDateFrm.Location = New System.Drawing.Point(3, 376)
        Me.dtpDateFrm.Name = "dtpDateFrm"
        Me.dtpDateFrm.Size = New System.Drawing.Size(216, 31)
        Me.dtpDateFrm.TabIndex = 10
        '
        'lblDateTo
        '
        Me.lblDateTo.AutoSize = True
        Me.lblDateTo.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblDateTo.Location = New System.Drawing.Point(223, 416)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(25, 23)
        Me.lblDateTo.TabIndex = 111
        Me.lblDateTo.Text = "الى"
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.HighlightColor = System.Drawing.Color.Empty
        Me.dtpDateTo.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpDateTo.IsHighLight = False
        Me.dtpDateTo.Location = New System.Drawing.Point(3, 413)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(216, 31)
        Me.dtpDateTo.TabIndex = 11
        '
        'btnSearch
        '
        Me.btnSearch.BackgroundImage = CType(resources.GetObject("btnSearch.BackgroundImage"), System.Drawing.Image)
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(47, 450)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(172, 38)
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "عرض"
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(3, 450)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 13
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(364, 495)
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
        Me.dgv.Size = New System.Drawing.Size(358, 489)
        Me.dgv.TabIndex = 1
        '
        'bw1
        '
        Me.bw1.WorkerReportsProgress = True
        Me.bw1.WorkerSupportsCancellation = True
        '
        'frm_sp_rpt_invoices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(729, 537)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_sp_rpt_invoices"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "الفواتير"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

End Sub 'xx__End sub__xx
Friend WithEvents lblinvoiceTypeID As System.Windows.Forms.Label
Friend WithEvents cboinvoiceTypeID As ByteClassLibrary.MyComboBox
Friend WithEvents lblInvoiceNumber As System.Windows.Forms.Label
Friend WithEvents numInvoiceNumber As ByteClassLibrary.MyNumericBox
Friend WithEvents lblInvoiceRealNumber As System.Windows.Forms.Label
Friend WithEvents numInvoiceRealNumber As ByteClassLibrary.MyNumericBox
Friend WithEvents lblOrgInvoiceNumber As System.Windows.Forms.Label
Friend WithEvents numOrgInvoiceNumber As ByteClassLibrary.MyNumericBox
Friend WithEvents lblStockID As System.Windows.Forms.Label
Friend WithEvents cboStockID As ByteClassLibrary.MyComboBox
Friend WithEvents lblAgentID As System.Windows.Forms.Label
Friend WithEvents cboAgentID As ByteClassLibrary.MyComboBox
Friend WithEvents lblDistributorID As System.Windows.Forms.Label
Friend WithEvents cboDistributorID As ByteClassLibrary.MyComboBox
Friend WithEvents lblIsPaid As System.Windows.Forms.Label
Friend WithEvents cboIsPaid As ByteClassLibrary.MyComboBox
Friend WithEvents lblUserID As System.Windows.Forms.Label
Friend WithEvents cboUserID As ByteClassLibrary.MyComboBox
Friend WithEvents chkAllPeriod As System.Windows.Forms.CheckBox
Friend WithEvents lblDateFrm As System.Windows.Forms.Label
Friend WithEvents dtpDateFrm As ByteClassLibrary.MyDateTimePicker
Friend WithEvents lblDateTo As System.Windows.Forms.Label
Friend WithEvents dtpDateTo As ByteClassLibrary.MyDateTimePicker
Friend WithEvents btnSearch As ByteClassLibrary.MyButton
Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox

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
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    'xx_Friend WithEvents_xx



End Class
