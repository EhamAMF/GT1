<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnCopy = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.btnRefresh = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.lblCount = New System.Windows.Forms.ToolStripLabel()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblTitle = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.PInvoiceNumber = New System.Windows.Forms.Panel()
        Me.numInvoiceNumber = New ByteClassLibrary.MyNumericBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pInvoiceRealNumber = New System.Windows.Forms.Panel()
        Me.numInvoiceRealNumber = New ByteClassLibrary.MyNumericBox()
        Me.lblInvoiceRealNumber = New System.Windows.Forms.Label()
        Me.pOrgInvoiceNumer = New System.Windows.Forms.Panel()
        Me.numOrgInvoiceNumer = New ByteClassLibrary.MyNumericBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PInvoiceDate = New System.Windows.Forms.Panel()
        Me.dtpInvoiceDate = New ByteClassLibrary.MyDateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PAgent = New System.Windows.Forms.Panel()
        Me.cboAgent = New ByteClassLibrary.MyComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PName = New System.Windows.Forms.Panel()
        Me.txtName = New ByteClassLibrary.MyTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PWareHouse = New System.Windows.Forms.Panel()
        Me.cboWareHouse = New ByteClassLibrary.MyComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PDistributor = New System.Windows.Forms.Panel()
        Me.cboDistributor = New ByteClassLibrary.MyComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNote = New ByteClassLibrary.MyTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNewProduct = New ByteClassLibrary.MyButton()
        Me.cboItem = New ByteClassLibrary.MyGridTextBox2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnPay = New ByteClassLibrary.MyButton()
        Me.btnSave2 = New ByteClassLibrary.MyButton()
        Me.pPay = New System.Windows.Forms.Panel()
        Me.cboIsPaid = New ByteClassLibrary.MyComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvTotals = New System.Windows.Forms.DataGridView()
        Me.dgvInfo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.PInvoiceNumber.SuspendLayout()
        Me.pInvoiceRealNumber.SuspendLayout()
        Me.pOrgInvoiceNumer.SuspendLayout()
        Me.PInvoiceDate.SuspendLayout()
        Me.PAgent.SuspendLayout()
        Me.PName.SuspendLayout()
        Me.PWareHouse.SuspendLayout()
        Me.PDistributor.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.pPay.SuspendLayout()
        CType(Me.dgvTotals, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAdd, Me.btnCopy, Me.btnEdit, Me.btnDelete, Me.btnRefresh, Me.btnSave, Me.lblCount, Me.txtSearch, Me.ToolStripLabel1, Me.ToolStripButton2, Me.lblTitle, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1234, 42)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'lblCount
        '
        Me.lblCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(36, 39)
        Me.lblCount.Text = "000"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.ForeColor = System.Drawing.Color.Silver
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(150, 42)
        Me.txtSearch.Text = "بحث"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(83, 39)
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
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(54, 39)
        Me.lblTitle.Text = "العنوان"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(6, 42)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 42)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1234, 608)
        Me.SplitContainer1.SplitterDistance = 352
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 110
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.pInvoiceRealNumber)
        Me.FlowLayoutPanel1.Controls.Add(Me.pOrgInvoiceNumer)
        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.PAgent)
        Me.FlowLayoutPanel1.Controls.Add(Me.PName)
        Me.FlowLayoutPanel1.Controls.Add(Me.PWareHouse)
        Me.FlowLayoutPanel1.Controls.Add(Me.PDistributor)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 8)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(321, 536)
        Me.FlowLayoutPanel1.TabIndex = 111
        '
        'PInvoiceNumber
        '
        Me.PInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PInvoiceNumber.Controls.Add(Me.numInvoiceNumber)
        Me.PInvoiceNumber.Controls.Add(Me.Label2)
        Me.PInvoiceNumber.Location = New System.Drawing.Point(1, 0)
        Me.PInvoiceNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceNumber.Name = "PInvoiceNumber"
        Me.PInvoiceNumber.Padding = New System.Windows.Forms.Padding(5)
        Me.PInvoiceNumber.Size = New System.Drawing.Size(320, 43)
        Me.PInvoiceNumber.TabIndex = 106
        '
        'numInvoiceNumber
        '
        Me.numInvoiceNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInvoiceNumber.BackColor = System.Drawing.Color.White
        Me.numInvoiceNumber.ForeColor = System.Drawing.Color.Black
        Me.numInvoiceNumber.Location = New System.Drawing.Point(5, 5)
        Me.numInvoiceNumber.Name = "numInvoiceNumber"
        Me.numInvoiceNumber.ReadOnly = True
        Me.numInvoiceNumber.Size = New System.Drawing.Size(204, 32)
        Me.numInvoiceNumber.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(215, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(83, 25)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "رقم الفاتورة"
        '
        'pInvoiceRealNumber
        '
        Me.pInvoiceRealNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pInvoiceRealNumber.Controls.Add(Me.numInvoiceRealNumber)
        Me.pInvoiceRealNumber.Controls.Add(Me.lblInvoiceRealNumber)
        Me.pInvoiceRealNumber.Location = New System.Drawing.Point(1, 43)
        Me.pInvoiceRealNumber.Margin = New System.Windows.Forms.Padding(0)
        Me.pInvoiceRealNumber.Name = "pInvoiceRealNumber"
        Me.pInvoiceRealNumber.Padding = New System.Windows.Forms.Padding(5)
        Me.pInvoiceRealNumber.Size = New System.Drawing.Size(320, 43)
        Me.pInvoiceRealNumber.TabIndex = 109
        '
        'numInvoiceRealNumber
        '
        Me.numInvoiceRealNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInvoiceRealNumber.Location = New System.Drawing.Point(5, 5)
        Me.numInvoiceRealNumber.Name = "numInvoiceRealNumber"
        Me.numInvoiceRealNumber.Size = New System.Drawing.Size(204, 32)
        Me.numInvoiceRealNumber.TabIndex = 2
        '
        'lblInvoiceRealNumber
        '
        Me.lblInvoiceRealNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceRealNumber.AutoSize = True
        Me.lblInvoiceRealNumber.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceRealNumber.Location = New System.Drawing.Point(215, 11)
        Me.lblInvoiceRealNumber.Name = "lblInvoiceRealNumber"
        Me.lblInvoiceRealNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblInvoiceRealNumber.Size = New System.Drawing.Size(78, 25)
        Me.lblInvoiceRealNumber.TabIndex = 101
        Me.lblInvoiceRealNumber.Text = "رقم المصدر"
        '
        'pOrgInvoiceNumer
        '
        Me.pOrgInvoiceNumer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pOrgInvoiceNumer.Controls.Add(Me.numOrgInvoiceNumer)
        Me.pOrgInvoiceNumer.Controls.Add(Me.Label9)
        Me.pOrgInvoiceNumer.Location = New System.Drawing.Point(1, 86)
        Me.pOrgInvoiceNumer.Margin = New System.Windows.Forms.Padding(0)
        Me.pOrgInvoiceNumer.Name = "pOrgInvoiceNumer"
        Me.pOrgInvoiceNumer.Padding = New System.Windows.Forms.Padding(5)
        Me.pOrgInvoiceNumer.Size = New System.Drawing.Size(320, 43)
        Me.pOrgInvoiceNumer.TabIndex = 111
        '
        'numOrgInvoiceNumer
        '
        Me.numOrgInvoiceNumer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numOrgInvoiceNumer.Location = New System.Drawing.Point(5, 5)
        Me.numOrgInvoiceNumer.Name = "numOrgInvoiceNumer"
        Me.numOrgInvoiceNumer.ReadOnly = True
        Me.numOrgInvoiceNumer.Size = New System.Drawing.Size(204, 32)
        Me.numOrgInvoiceNumer.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(215, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "الفاتورة الاصلية"
        '
        'PInvoiceDate
        '
        Me.PInvoiceDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PInvoiceDate.Controls.Add(Me.dtpInvoiceDate)
        Me.PInvoiceDate.Controls.Add(Me.Label3)
        Me.PInvoiceDate.Location = New System.Drawing.Point(1, 129)
        Me.PInvoiceDate.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceDate.Name = "PInvoiceDate"
        Me.PInvoiceDate.Padding = New System.Windows.Forms.Padding(5)
        Me.PInvoiceDate.Size = New System.Drawing.Size(320, 43)
        Me.PInvoiceDate.TabIndex = 115
        '
        'dtpInvoiceDate
        '
        Me.dtpInvoiceDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpInvoiceDate.BackColor = System.Drawing.Color.White
        Me.dtpInvoiceDate.CustomFormat = "yyyy-MM-dd    HH:mm"
        Me.dtpInvoiceDate.ForeColor = System.Drawing.Color.Black
        Me.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInvoiceDate.HighlightColor = System.Drawing.Color.Empty
        Me.dtpInvoiceDate.HighlightFontColor = System.Drawing.Color.Empty
        Me.dtpInvoiceDate.IsHighLight = False
        Me.dtpInvoiceDate.Location = New System.Drawing.Point(5, 5)
        Me.dtpInvoiceDate.Name = "dtpInvoiceDate"
        Me.dtpInvoiceDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpInvoiceDate.Size = New System.Drawing.Size(204, 32)
        Me.dtpInvoiceDate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(215, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "التاريخ"
        '
        'PAgent
        '
        Me.PAgent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PAgent.Controls.Add(Me.cboAgent)
        Me.PAgent.Controls.Add(Me.Label1)
        Me.PAgent.Location = New System.Drawing.Point(1, 172)
        Me.PAgent.Margin = New System.Windows.Forms.Padding(0)
        Me.PAgent.Name = "PAgent"
        Me.PAgent.Padding = New System.Windows.Forms.Padding(5)
        Me.PAgent.Size = New System.Drawing.Size(320, 43)
        Me.PAgent.TabIndex = 112
        '
        'cboAgent
        '
        Me.cboAgent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAgent.FormattingEnabled = True
        Me.cboAgent.Location = New System.Drawing.Point(5, 5)
        Me.cboAgent.Name = "cboAgent"
        Me.cboAgent.Size = New System.Drawing.Size(204, 33)
        Me.cboAgent.TabIndex = 5
        Me.cboAgent.TabOnEnter = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(215, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(54, 25)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "العميل"
        '
        'PName
        '
        Me.PName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PName.Controls.Add(Me.txtName)
        Me.PName.Controls.Add(Me.Label4)
        Me.PName.Location = New System.Drawing.Point(1, 215)
        Me.PName.Margin = New System.Windows.Forms.Padding(0)
        Me.PName.Name = "PName"
        Me.PName.Padding = New System.Windows.Forms.Padding(5)
        Me.PName.Size = New System.Drawing.Size(320, 43)
        Me.PName.TabIndex = 114
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(5, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(204, 32)
        Me.txtName.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(215, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(42, 25)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "الاسم"
        '
        'PWareHouse
        '
        Me.PWareHouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PWareHouse.Controls.Add(Me.cboWareHouse)
        Me.PWareHouse.Controls.Add(Me.Label6)
        Me.PWareHouse.Location = New System.Drawing.Point(1, 258)
        Me.PWareHouse.Margin = New System.Windows.Forms.Padding(0)
        Me.PWareHouse.Name = "PWareHouse"
        Me.PWareHouse.Padding = New System.Windows.Forms.Padding(5)
        Me.PWareHouse.Size = New System.Drawing.Size(320, 43)
        Me.PWareHouse.TabIndex = 116
        '
        'cboWareHouse
        '
        Me.cboWareHouse.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboWareHouse.FormattingEnabled = True
        Me.cboWareHouse.Location = New System.Drawing.Point(5, 5)
        Me.cboWareHouse.Name = "cboWareHouse"
        Me.cboWareHouse.Size = New System.Drawing.Size(204, 33)
        Me.cboWareHouse.TabIndex = 7
        Me.cboWareHouse.TabOnEnter = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(215, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(52, 25)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "المخزن"
        '
        'PDistributor
        '
        Me.PDistributor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PDistributor.Controls.Add(Me.cboDistributor)
        Me.PDistributor.Controls.Add(Me.Label5)
        Me.PDistributor.Location = New System.Drawing.Point(1, 301)
        Me.PDistributor.Margin = New System.Windows.Forms.Padding(0)
        Me.PDistributor.Name = "PDistributor"
        Me.PDistributor.Padding = New System.Windows.Forms.Padding(5)
        Me.PDistributor.Size = New System.Drawing.Size(320, 43)
        Me.PDistributor.TabIndex = 113
        '
        'cboDistributor
        '
        Me.cboDistributor.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboDistributor.FormattingEnabled = True
        Me.cboDistributor.Location = New System.Drawing.Point(5, 5)
        Me.cboDistributor.Name = "cboDistributor"
        Me.cboDistributor.Size = New System.Drawing.Size(204, 33)
        Me.cboDistributor.TabIndex = 8
        Me.cboDistributor.TabOnEnter = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(215, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "المسوق"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.txtNote)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(1, 344)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(320, 134)
        Me.Panel3.TabIndex = 117
        '
        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.BackColor = System.Drawing.Color.White
        Me.txtNote.ForeColor = System.Drawing.Color.Black
        Me.txtNote.Location = New System.Drawing.Point(5, 5)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.Size = New System.Drawing.Size(204, 119)
        Me.txtNote.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(215, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(58, 25)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "ملاحظة"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgv, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 214.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(879, 608)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.btnNewProduct)
        Me.Panel1.Controls.Add(Me.cboItem)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel1.Size = New System.Drawing.Size(879, 43)
        Me.Panel1.TabIndex = 111
        '
        'btnNewProduct
        '
        Me.btnNewProduct.BackgroundImage = CType(resources.GetObject("btnNewProduct.BackgroundImage"), System.Drawing.Image)
        Me.btnNewProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNewProduct.FlatAppearance.BorderSize = 0
        Me.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNewProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewProduct.Location = New System.Drawing.Point(8, 5)
        Me.btnNewProduct.Name = "btnNewProduct"
        Me.btnNewProduct.Size = New System.Drawing.Size(90, 33)
        Me.btnNewProduct.TabIndex = 103
        Me.btnNewProduct.Text = "صنف جديد"
        Me.btnNewProduct.UseVisualStyleBackColor = True
        '
        'cboItem
        '
        Me.cboItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItem.IsDgvLocationHeightSet = False
        Me.cboItem.Location = New System.Drawing.Point(104, 5)
        Me.cboItem.Margin = New System.Windows.Forms.Padding(0)
        Me.cboItem.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboItem.MyIsColumnHeaderVisible = False
        Me.cboItem.MySelectedValue = Nothing
        Me.cboItem.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboItem.Name = "cboItem"
        Me.cboItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cboItem.Size = New System.Drawing.Size(664, 32)
        Me.cboItem.TabIndex = 10
        Me.cboItem.TabOnEnter = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(774, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(97, 25)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "الصنف\الخدمة"
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(3, 46)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.RowHeadersWidth = 35
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv.Size = New System.Drawing.Size(873, 345)
        Me.dgv.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel4.Controls.Add(Me.pPay)
        Me.Panel4.Controls.Add(Me.dgvTotals)
        Me.Panel4.Controls.Add(Me.dgvInfo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 397)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(873, 208)
        Me.Panel4.TabIndex = 112
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnPay)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnSave2)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(6, 49)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(125, 96)
        Me.FlowLayoutPanel2.TabIndex = 120
        '
        'btnPay
        '
        Me.btnPay.BackgroundImage = CType(resources.GetObject("btnPay.BackgroundImage"), System.Drawing.Image)
        Me.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPay.FlatAppearance.BorderSize = 0
        Me.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPay.Location = New System.Drawing.Point(2, 3)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(120, 40)
        Me.btnPay.TabIndex = 118
        Me.btnPay.Text = "قبض"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnSave2
        '
        Me.btnSave2.BackgroundImage = CType(resources.GetObject("btnSave2.BackgroundImage"), System.Drawing.Image)
        Me.btnSave2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave2.FlatAppearance.BorderSize = 0
        Me.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave2.Location = New System.Drawing.Point(2, 49)
        Me.btnSave2.Name = "btnSave2"
        Me.btnSave2.Size = New System.Drawing.Size(120, 40)
        Me.btnSave2.TabIndex = 119
        Me.btnSave2.Text = "حفظ"
        Me.btnSave2.UseVisualStyleBackColor = True
        '
        'pPay
        '
        Me.pPay.Controls.Add(Me.cboIsPaid)
        Me.pPay.Controls.Add(Me.Label7)
        Me.pPay.Location = New System.Drawing.Point(6, 3)
        Me.pPay.Margin = New System.Windows.Forms.Padding(0)
        Me.pPay.Name = "pPay"
        Me.pPay.Padding = New System.Windows.Forms.Padding(5)
        Me.pPay.Size = New System.Drawing.Size(191, 43)
        Me.pPay.TabIndex = 117
        '
        'cboIsPaid
        '
        Me.cboIsPaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboIsPaid.FormattingEnabled = True
        Me.cboIsPaid.Location = New System.Drawing.Point(5, 5)
        Me.cboIsPaid.Name = "cboIsPaid"
        Me.cboIsPaid.Size = New System.Drawing.Size(120, 33)
        Me.cboIsPaid.TabIndex = 102
        Me.cboIsPaid.TabOnEnter = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(131, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(45, 25)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "الدفع"
        '
        'dgvTotals
        '
        Me.dgvTotals.AllowUserToAddRows = False
        Me.dgvTotals.AllowUserToDeleteRows = False
        Me.dgvTotals.AllowUserToOrderColumns = True
        Me.dgvTotals.AllowUserToResizeRows = False
        Me.dgvTotals.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotals.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTotals.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvTotals.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotals.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvTotals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotals.ColumnHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotals.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTotals.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTotals.Location = New System.Drawing.Point(200, 3)
        Me.dgvTotals.Name = "dgvTotals"
        Me.dgvTotals.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvTotals.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTotals.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTotals.RowHeadersVisible = False
        Me.dgvTotals.RowHeadersWidth = 35
        Me.dgvTotals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvTotals.Size = New System.Drawing.Size(272, 196)
        Me.dgvTotals.TabIndex = 114
        '
        'dgvInfo
        '
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.AllowUserToDeleteRows = False
        Me.dgvInfo.AllowUserToOrderColumns = True
        Me.dgvInfo.AllowUserToResizeRows = False
        Me.dgvInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvInfo.BackgroundColor = System.Drawing.Color.White
        Me.dgvInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInfo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.ColumnHeadersVisible = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.RoyalBlue
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvInfo.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvInfo.Enabled = False
        Me.dgvInfo.GridColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvInfo.Location = New System.Drawing.Point(464, 3)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInfo.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvInfo.RowHeadersVisible = False
        Me.dgvInfo.RowHeadersWidth = 35
        Me.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInfo.Size = New System.Drawing.Size(406, 202)
        Me.dgvInfo.TabIndex = 113
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Column3"
        Me.Column3.Name = "Column3"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmInvoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1234, 650)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "frmInvoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "frmInvoice"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.PInvoiceNumber.ResumeLayout(False)
        Me.PInvoiceNumber.PerformLayout()
        Me.pInvoiceRealNumber.ResumeLayout(False)
        Me.pInvoiceRealNumber.PerformLayout()
        Me.pOrgInvoiceNumer.ResumeLayout(False)
        Me.pOrgInvoiceNumer.PerformLayout()
        Me.PInvoiceDate.ResumeLayout(False)
        Me.PInvoiceDate.PerformLayout()
        Me.PAgent.ResumeLayout(False)
        Me.PAgent.PerformLayout()
        Me.PName.ResumeLayout(False)
        Me.PName.PerformLayout()
        Me.PWareHouse.ResumeLayout(False)
        Me.PWareHouse.PerformLayout()
        Me.PDistributor.ResumeLayout(False)
        Me.PDistributor.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.pPay.ResumeLayout(False)
        Me.pPay.PerformLayout()
        CType(Me.dgvTotals, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCopy As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblCount As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTitle As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboItem As ByteClassLibrary.MyGridTextBox2
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents PInvoiceNumber As System.Windows.Forms.Panel
    Friend WithEvents numInvoiceNumber As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pInvoiceRealNumber As System.Windows.Forms.Panel
    Friend WithEvents numInvoiceRealNumber As ByteClassLibrary.MyNumericBox
    Friend WithEvents lblInvoiceRealNumber As System.Windows.Forms.Label
    Friend WithEvents pOrgInvoiceNumer As System.Windows.Forms.Panel
    Friend WithEvents numOrgInvoiceNumer As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PInvoiceDate As System.Windows.Forms.Panel
    Friend WithEvents dtpInvoiceDate As ByteClassLibrary.MyDateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PAgent As System.Windows.Forms.Panel
    Friend WithEvents cboAgent As ByteClassLibrary.MyComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PName As System.Windows.Forms.Panel
    Friend WithEvents txtName As ByteClassLibrary.MyTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PWareHouse As System.Windows.Forms.Panel
    Friend WithEvents cboWareHouse As ByteClassLibrary.MyComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PDistributor As System.Windows.Forms.Panel
    Friend WithEvents cboDistributor As ByteClassLibrary.MyComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtNote As ByteClassLibrary.MyTextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents dgvInfo As System.Windows.Forms.DataGridView
    Friend WithEvents dgvTotals As System.Windows.Forms.DataGridView
    Friend WithEvents btnNewProduct As ByteClassLibrary.MyButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnSave2 As ByteClassLibrary.MyButton
    Friend WithEvents btnPay As ByteClassLibrary.MyButton
    Friend WithEvents pPay As System.Windows.Forms.Panel
    Friend WithEvents cboIsPaid As ByteClassLibrary.MyComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
End Class
