<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Expense
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
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
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
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Size = New System.Drawing.Size(681, 384)
        Me.SplitContainer1.SplitterDistance = 415
        Me.SplitContainer1.TabIndex = 2
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(415, 384)
        Me.FlowLayoutPanel1.TabIndex = 107
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(262, 384)
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
        Me.dgv.Size = New System.Drawing.Size(256, 376)
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
        Me.btnAdd.Image = My.Resources.Resources.add
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
        Me.btnCopy.Image = My.Resources.Resources.copy
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
        Me.btnEdit.Image = My.Resources.Resources.edit
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
        Me.btnSave.Image = My.Resources.Resources.save
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
        Me.btnDelete.Image = My.Resources.Resources.delete
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
        Me.btnRefresh.Image = My.Resources.Resources.refresh
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
        Me.ToolStrip1.Size = New System.Drawing.Size(681, 42)
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
        'frm_Expense
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(681, 426)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_Expense"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "المصروفات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

        Me.lblInvoiceID = New System.Windows.Forms.Label()
        Me.numInvoiceID = New ByteClassLibrary.MyNumericBox()
        Me.PInvoiceID = New System.Windows.Forms.Panel()
        Me.PInvoiceID.SuspendLayout()
        Me.lblExpenseTypeID = New System.Windows.Forms.Label()
        Me.cboExpenseTypeID = New ByteClassLibrary.MyGridTextBox3()
        Me.PExpenseTypeID = New System.Windows.Forms.Panel()
        Me.PExpenseTypeID.SuspendLayout()
        Me.lblExpenseCost = New System.Windows.Forms.Label()
        Me.numExpenseCost = New ByteClassLibrary.MyNumericBox()
        Me.PExpenseCost = New System.Windows.Forms.Panel()
        Me.PExpenseCost.SuspendLayout()
        Me.lblExpenseDate = New System.Windows.Forms.Label()
        Me.dtpExpenseDate = New ByteClassLibrary.MyDateTimePicker()
        Me.PExpenseDate = New System.Windows.Forms.Panel()
        Me.PExpenseDate.SuspendLayout()
        Me.lblNote = New System.Windows.Forms.Label()
        Me.txtNote = New ByteClassLibrary.MyTextBox()
        Me.PNote = New System.Windows.Forms.Panel()
        Me.PNote.SuspendLayout()

        'lblInvoiceID
        '

        Me.lblInvoiceID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInvoiceID.AutoSize = True
        Me.lblInvoiceID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblInvoiceID.Location = New System.Drawing.Point(234, 3)
        Me.lblInvoiceID.Name = "lblInvoiceID"
        Me.lblInvoiceID.TabIndex = 100
        Me.lblInvoiceID.Text = "رقم الفاتورة"


        'numInvoiceID
        '
        Me.numInvoiceID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numInvoiceID.Size = New System.Drawing.Size(228, 31)
        Me.numInvoiceID.Location = New System.Drawing.Point(0, 0)
        Me.numInvoiceID.Name = "numInvoiceID"
        Me.numInvoiceID.TabIndex = 0


        'PInvoiceID
        '
        Me.PInvoiceID.Location = New System.Drawing.Point(56, 10)
        Me.PInvoiceID.Margin = New System.Windows.Forms.Padding(0)
        Me.PInvoiceID.Name = "PInvoiceID"
        Me.PInvoiceID.Size = New System.Drawing.Size(359, 37)

        Me.PInvoiceID.Location = New System.Drawing.Point(56, 10)
        Me.PInvoiceID.TabIndex = 200

        Me.PInvoiceID.Controls.Add(Me.lblInvoiceID)
        Me.PInvoiceID.Controls.Add(Me.numInvoiceID)

        'lblExpenseTypeID
        '

        Me.lblExpenseTypeID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpenseTypeID.AutoSize = True
        Me.lblExpenseTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExpenseTypeID.Location = New System.Drawing.Point(234, 3)
        Me.lblExpenseTypeID.Name = "lblExpenseTypeID"
        Me.lblExpenseTypeID.TabIndex = 101
        Me.lblExpenseTypeID.Text = "البند"
        Me.lblExpenseTypeID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblExpenseTypeID.ForeColor = System.Drawing.Color.RoyalBlue


        'cboExpenseTypeID
        '
        Me.cboExpenseTypeID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)

        Me.cboExpenseTypeID.Size = New System.Drawing.Size(228, 31)
        Me.cboExpenseTypeID.TabOnEnter = True
        Me.cboExpenseTypeID.Location = New System.Drawing.Point(0, 0)
        Me.cboExpenseTypeID.Name = "cboExpenseTypeID"
        Me.cboExpenseTypeID.TabIndex = 1


        'PExpenseTypeID
        '
        Me.PExpenseTypeID.Location = New System.Drawing.Point(56, 10)
        Me.PExpenseTypeID.Margin = New System.Windows.Forms.Padding(0)
        Me.PExpenseTypeID.Name = "PExpenseTypeID"
        Me.PExpenseTypeID.Size = New System.Drawing.Size(359, 37)

        Me.PExpenseTypeID.Location = New System.Drawing.Point(56, 47)
        Me.PExpenseTypeID.TabIndex = 201

        Me.PExpenseTypeID.Controls.Add(Me.lblExpenseTypeID)
        Me.PExpenseTypeID.Controls.Add(Me.cboExpenseTypeID)

        'lblExpenseCost
        '

        Me.lblExpenseCost.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpenseCost.AutoSize = True
        Me.lblExpenseCost.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExpenseCost.Location = New System.Drawing.Point(234, 3)
        Me.lblExpenseCost.Name = "lblExpenseCost"
        Me.lblExpenseCost.TabIndex = 102
        Me.lblExpenseCost.Text = "القيمة"


        'numExpenseCost
        '
        Me.numExpenseCost.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numExpenseCost.Size = New System.Drawing.Size(228, 31)
        Me.numExpenseCost.Location = New System.Drawing.Point(0, 0)
        Me.numExpenseCost.Name = "numExpenseCost"
        Me.numExpenseCost.TabIndex = 2


        'PExpenseCost
        '
        Me.PExpenseCost.Location = New System.Drawing.Point(56, 10)
        Me.PExpenseCost.Margin = New System.Windows.Forms.Padding(0)
        Me.PExpenseCost.Name = "PExpenseCost"
        Me.PExpenseCost.Size = New System.Drawing.Size(359, 37)

        Me.PExpenseCost.Location = New System.Drawing.Point(56, 84)
        Me.PExpenseCost.TabIndex = 202

        Me.PExpenseCost.Controls.Add(Me.lblExpenseCost)
        Me.PExpenseCost.Controls.Add(Me.numExpenseCost)

        'lblExpenseDate
        '

        Me.lblExpenseDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblExpenseDate.AutoSize = True
        Me.lblExpenseDate.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblExpenseDate.Location = New System.Drawing.Point(234, 3)
        Me.lblExpenseDate.Name = "lblExpenseDate"
        Me.lblExpenseDate.TabIndex = 103
        Me.lblExpenseDate.Text = "التاريخ"


        'dtpExpenseDate
        '
        Me.dtpExpenseDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpExpenseDate.CustomFormat = "yyyy-MM-dd        HH:mm "
        Me.dtpExpenseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpenseDate.Size = New System.Drawing.Size(228, 31)
        Me.dtpExpenseDate.Location = New System.Drawing.Point(0, 0)
        Me.dtpExpenseDate.Name = "dtpExpenseDate"
        Me.dtpExpenseDate.TabIndex = 3


        'PExpenseDate
        '
        Me.PExpenseDate.Location = New System.Drawing.Point(56, 10)
        Me.PExpenseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.PExpenseDate.Name = "PExpenseDate"
        Me.PExpenseDate.Size = New System.Drawing.Size(359, 37)

        Me.PExpenseDate.Location = New System.Drawing.Point(56, 121)
        Me.PExpenseDate.TabIndex = 203

        Me.PExpenseDate.Controls.Add(Me.lblExpenseDate)
        Me.PExpenseDate.Controls.Add(Me.dtpExpenseDate)

        'lblNote
        '

        Me.lblNote.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNote.AutoSize = True
        Me.lblNote.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblNote.Location = New System.Drawing.Point(234, 3)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.TabIndex = 104
        Me.lblNote.Text = "ملاحظة"


        'txtNote
        '
        Me.txtNote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNote.Size = New System.Drawing.Size(228, 31)
        Me.txtNote.Location = New System.Drawing.Point(0, 0)
        Me.txtNote.Name = "txtNote"
        Me.txtNote.TabIndex = 4


        'PNote
        '
        Me.PNote.Location = New System.Drawing.Point(56, 10)
        Me.PNote.Margin = New System.Windows.Forms.Padding(0)
        Me.PNote.Name = "PNote"
        Me.PNote.Size = New System.Drawing.Size(359, 37)

        Me.PNote.Location = New System.Drawing.Point(56, 158)
        Me.PNote.TabIndex = 204

        Me.PNote.Controls.Add(Me.lblNote)
        Me.PNote.Controls.Add(Me.txtNote)


        Me.FlowLayoutPanel1.Controls.Add(Me.PInvoiceID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExpenseTypeID)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExpenseCost)
        Me.FlowLayoutPanel1.Controls.Add(Me.PExpenseDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.PNote)

        Me.PInvoiceID.ResumeLayout(False)
        Me.PInvoiceID.PerformLayout()
        Me.PExpenseTypeID.ResumeLayout(False)
        Me.PExpenseTypeID.PerformLayout()
        Me.PExpenseCost.ResumeLayout(False)
        Me.PExpenseCost.PerformLayout()
        Me.PExpenseDate.ResumeLayout(False)
        Me.PExpenseDate.PerformLayout()
        Me.PNote.ResumeLayout(False)
        Me.PNote.PerformLayout()

    End Sub 'xx__End sub__xx
    Friend WithEvents lblInvoiceID As System.Windows.Forms.Label
    Friend WithEvents numInvoiceID As ByteClassLibrary.MyNumericBox
    Friend WithEvents PInvoiceID As System.Windows.Forms.Panel
    Friend WithEvents lblExpenseTypeID As System.Windows.Forms.Label
    Friend WithEvents cboExpenseTypeID As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents PExpenseTypeID As System.Windows.Forms.Panel
    Friend WithEvents lblExpenseCost As System.Windows.Forms.Label
    Friend WithEvents numExpenseCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents PExpenseCost As System.Windows.Forms.Panel
    Friend WithEvents lblExpenseDate As System.Windows.Forms.Label
    Friend WithEvents dtpExpenseDate As ByteClassLibrary.MyDateTimePicker
    Friend WithEvents PExpenseDate As System.Windows.Forms.Panel
    Friend WithEvents lblNote As System.Windows.Forms.Label
    Friend WithEvents txtNote As ByteClassLibrary.MyTextBox
    Friend WithEvents PNote As System.Windows.Forms.Panel

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
    'xx_Friend WithEvents_xx



End Class
