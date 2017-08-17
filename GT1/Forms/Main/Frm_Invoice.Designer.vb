Imports System.Windows.Forms.VisualStyles.VisualStyleElement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Invoice
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
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Invoice))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnPreviosInvoice = New System.Windows.Forms.ToolStripButton()
        Me.btnNextInvoice = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblTotal = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.btnView = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCreateSellInvoce = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgvInfo = New ByteDGV
        Me.Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Disc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Pbenterbig1 = New ByteMyPictureBox.pbenterbig()
        Me.Pb91 = New ByteMyPictureBox.pb9()
        Me.Pb81 = New ByteMyPictureBox.pb8()
        Me.Pb71 = New ByteMyPictureBox.pb7()
        Me.Pb61 = New ByteMyPictureBox.pb6()
        Me.Pb51 = New ByteMyPictureBox.pb5()
        Me.Pb41 = New ByteMyPictureBox.pb4()
        Me.Pb31 = New ByteMyPictureBox.pb3()
        Me.Pb21 = New ByteMyPictureBox.pb2()
        Me.Pb11 = New ByteMyPictureBox.pb1()
        Me.Pbdot1 = New ByteMyPictureBox.pbdot()
        Me.Pbc1 = New ByteMyPictureBox.pbc()
        Me.Pb01 = New ByteMyPictureBox.pb0()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvTotal2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cboPayment = New System.Windows.Forms.ComboBox()
        Me.dgvTotal = New System.Windows.Forms.DataGridView()
        Me.Caption = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Value = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.cmsDGV = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ادارةالباركودToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.cboItemType = New System.Windows.Forms.ComboBox()
        Me.cboItem = New ByteClassLibrary.MyGridTextBox3()

        Me.ToolStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Pbenterbig1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb81, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbdot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbc1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pb01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvTotal2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDGV.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(70, 70)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnPreviosInvoice, Me.btnNextInvoice, Me.btnSave, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.lblTotal, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1008, 86)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 23
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNew.Image = Global.GT1.My.Resources.Resources.add
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Margin = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(74, 74)
        Me.btnNew.Text = "فاتورة جديدة"
        Me.btnNew.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'btnPreviosInvoice
        '
        Me.btnPreviosInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPreviosInvoice.Image = Global.GT1.My.Resources.Resources.Prev
        Me.btnPreviosInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPreviosInvoice.Margin = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.btnPreviosInvoice.Name = "btnPreviosInvoice"
        Me.btnPreviosInvoice.Size = New System.Drawing.Size(74, 74)
        Me.btnPreviosInvoice.Text = "الفاتورةالسابقة"
        Me.btnPreviosInvoice.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'btnNextInvoice
        '
        Me.btnNextInvoice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNextInvoice.Image = Global.GT1.My.Resources.Resources._next
        Me.btnNextInvoice.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNextInvoice.Margin = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.btnNextInvoice.Name = "btnNextInvoice"
        Me.btnNextInvoice.Size = New System.Drawing.Size(74, 74)
        Me.btnNextInvoice.Text = "الفاتورة التالية"
        Me.btnNextInvoice.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSave.Image = Global.GT1.My.Resources.Resources.save
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 0, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 74)
        Me.btnSave.Text = "حفظ"
        Me.btnSave.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 86)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Aljazeera", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(107, 83)
        Me.ToolStripLabel1.Text = "الاجمالي :"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(145, 83)
        Me.lblTotal.Text = "88.75"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 86)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnView, Me.btnPrint, Me.btnReturn, Me.btnPay, Me.btnCreateSellInvoce, Me.btnDelete})
        Me.ToolStripButton1.Font = New System.Drawing.Font("Aljazeera", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.GT1.My.Resources.Resources._option
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(83, 83)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'btnView
        '
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(229, 34)
        Me.btnView.Text = "عرض"
        '
        'btnPrint
        '
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(229, 34)
        Me.btnPrint.Text = "طباعة"
        '
        'btnReturn
        '
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(229, 34)
        Me.btnReturn.Text = "استرجاع"
        '
        'btnPay
        '
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(229, 34)
        Me.btnPay.Text = "سداد"
        '
        'btnCreateSellInvoce
        '
        Me.btnCreateSellInvoce.Name = "btnCreateSellInvoce"
        Me.btnCreateSellInvoce.Size = New System.Drawing.Size(229, 34)
        Me.btnCreateSellInvoce.Text = "انشاء فاتورة مبيعات"
        '
        'btnDelete
        '
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(229, 34)
        Me.btnDelete.Text = "حدف"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 86)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 625)
        Me.TableLayoutPanel1.TabIndex = 24
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 44)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel3)
        Me.SplitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer1.Size = New System.Drawing.Size(1002, 578)
        Me.SplitContainer1.SplitterDistance = 342
        Me.SplitContainer1.SplitterWidth = 10
        Me.SplitContainer1.TabIndex = 21
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.dgvInfo, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(342, 578)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'dgvInfo
        '
        Me.dgvInfo.AllowUserToAddRows = False
        Me.dgvInfo.AllowUserToDeleteRows = False
        Me.dgvInfo.AllowUserToResizeRows = False
        Me.dgvInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInfo.BackgroundColor = System.Drawing.Color.White
        Me.dgvInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInfo.ColumnHeadersVisible = False
        Me.dgvInfo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Title, Me.Disc})
        Me.dgvInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInfo.Location = New System.Drawing.Point(3, 3)
        Me.dgvInfo.Name = "dgvInfo"
        Me.dgvInfo.RowHeadersVisible = False
        Me.dgvInfo.RowTemplate.Height = 33
        Me.dgvInfo.Size = New System.Drawing.Size(336, 271)
        Me.dgvInfo.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Title.HeaderText = "Title"
        Me.Title.Name = "Title"
        Me.Title.ReadOnly = True
        Me.Title.Width = 5
        '
        'Disc
        '
        Me.Disc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Disc.HeaderText = "Disc"
        Me.Disc.Name = "Disc"
        '
        'Panel4
        '
        Me.Panel4.AutoSize = True
        Me.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel4.Controls.Add(Me.Pbenterbig1)
        Me.Panel4.Controls.Add(Me.Pb91)
        Me.Panel4.Controls.Add(Me.Pb81)
        Me.Panel4.Controls.Add(Me.Pb71)
        Me.Panel4.Controls.Add(Me.Pb61)
        Me.Panel4.Controls.Add(Me.Pb51)
        Me.Panel4.Controls.Add(Me.Pb41)
        Me.Panel4.Controls.Add(Me.Pb31)
        Me.Panel4.Controls.Add(Me.Pb21)
        Me.Panel4.Controls.Add(Me.Pb11)
        Me.Panel4.Controls.Add(Me.Pbdot1)
        Me.Panel4.Controls.Add(Me.Pbc1)
        Me.Panel4.Controls.Add(Me.Pb01)
        Me.Panel4.Location = New System.Drawing.Point(4, 277)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel4.Size = New System.Drawing.Size(338, 298)
        Me.Panel4.TabIndex = 23
        '
        'Pbenterbig1
        '
        Me.Pbenterbig1.BackColor = System.Drawing.Color.White
        Me.Pbenterbig1.BackgroundImage = CType(resources.GetObject("Pbenterbig1.BackgroundImage"), System.Drawing.Image)
        Me.Pbenterbig1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbenterbig1.Location = New System.Drawing.Point(258, 0)
        Me.Pbenterbig1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 0)
        Me.Pbenterbig1.Name = "Pbenterbig1"
        Me.Pbenterbig1.Size = New System.Drawing.Size(80, 298)
        Me.Pbenterbig1.TabIndex = 12
        Me.Pbenterbig1.TabStop = False
        '
        'Pb91
        '
        Me.Pb91.BackColor = System.Drawing.Color.White
        Me.Pb91.BackgroundImage = CType(resources.GetObject("Pb91.BackgroundImage"), System.Drawing.Image)
        Me.Pb91.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb91.Location = New System.Drawing.Point(172, 0)
        Me.Pb91.Name = "Pb91"
        Me.Pb91.Size = New System.Drawing.Size(80, 70)
        Me.Pb91.TabIndex = 11
        Me.Pb91.TabStop = False
        '
        'Pb81
        '
        Me.Pb81.BackColor = System.Drawing.Color.White
        Me.Pb81.BackgroundImage = CType(resources.GetObject("Pb81.BackgroundImage"), System.Drawing.Image)
        Me.Pb81.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb81.Location = New System.Drawing.Point(86, 0)
        Me.Pb81.Name = "Pb81"
        Me.Pb81.Size = New System.Drawing.Size(80, 70)
        Me.Pb81.TabIndex = 10
        Me.Pb81.TabStop = False
        '
        'Pb71
        '
        Me.Pb71.BackColor = System.Drawing.Color.White
        Me.Pb71.BackgroundImage = CType(resources.GetObject("Pb71.BackgroundImage"), System.Drawing.Image)
        Me.Pb71.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb71.Location = New System.Drawing.Point(0, 0)
        Me.Pb71.Name = "Pb71"
        Me.Pb71.Size = New System.Drawing.Size(80, 70)
        Me.Pb71.TabIndex = 9
        Me.Pb71.TabStop = False
        '
        'Pb61
        '
        Me.Pb61.BackColor = System.Drawing.Color.White
        Me.Pb61.BackgroundImage = CType(resources.GetObject("Pb61.BackgroundImage"), System.Drawing.Image)
        Me.Pb61.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb61.Location = New System.Drawing.Point(172, 76)
        Me.Pb61.Name = "Pb61"
        Me.Pb61.Size = New System.Drawing.Size(80, 70)
        Me.Pb61.TabIndex = 8
        Me.Pb61.TabStop = False
        '
        'Pb51
        '
        Me.Pb51.BackColor = System.Drawing.Color.White
        Me.Pb51.BackgroundImage = CType(resources.GetObject("Pb51.BackgroundImage"), System.Drawing.Image)
        Me.Pb51.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb51.Location = New System.Drawing.Point(86, 76)
        Me.Pb51.Name = "Pb51"
        Me.Pb51.Size = New System.Drawing.Size(80, 70)
        Me.Pb51.TabIndex = 7
        Me.Pb51.TabStop = False
        '
        'Pb41
        '
        Me.Pb41.BackColor = System.Drawing.Color.White
        Me.Pb41.BackgroundImage = CType(resources.GetObject("Pb41.BackgroundImage"), System.Drawing.Image)
        Me.Pb41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb41.Location = New System.Drawing.Point(0, 76)
        Me.Pb41.Name = "Pb41"
        Me.Pb41.Size = New System.Drawing.Size(80, 70)
        Me.Pb41.TabIndex = 6
        Me.Pb41.TabStop = False
        '
        'Pb31
        '
        Me.Pb31.BackColor = System.Drawing.Color.White
        Me.Pb31.BackgroundImage = CType(resources.GetObject("Pb31.BackgroundImage"), System.Drawing.Image)
        Me.Pb31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb31.Location = New System.Drawing.Point(172, 152)
        Me.Pb31.Name = "Pb31"
        Me.Pb31.Size = New System.Drawing.Size(80, 70)
        Me.Pb31.TabIndex = 5
        Me.Pb31.TabStop = False
        '
        'Pb21
        '
        Me.Pb21.BackColor = System.Drawing.Color.White
        Me.Pb21.BackgroundImage = CType(resources.GetObject("Pb21.BackgroundImage"), System.Drawing.Image)
        Me.Pb21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb21.Location = New System.Drawing.Point(86, 152)
        Me.Pb21.Name = "Pb21"
        Me.Pb21.Size = New System.Drawing.Size(80, 70)
        Me.Pb21.TabIndex = 4
        Me.Pb21.TabStop = False
        '
        'Pb11
        '
        Me.Pb11.BackColor = System.Drawing.Color.White
        Me.Pb11.BackgroundImage = CType(resources.GetObject("Pb11.BackgroundImage"), System.Drawing.Image)
        Me.Pb11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb11.Location = New System.Drawing.Point(0, 152)
        Me.Pb11.Name = "Pb11"
        Me.Pb11.Size = New System.Drawing.Size(80, 70)
        Me.Pb11.TabIndex = 3
        Me.Pb11.TabStop = False
        '
        'Pbdot1
        '
        Me.Pbdot1.BackColor = System.Drawing.Color.White
        Me.Pbdot1.BackgroundImage = CType(resources.GetObject("Pbdot1.BackgroundImage"), System.Drawing.Image)
        Me.Pbdot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbdot1.Location = New System.Drawing.Point(172, 228)
        Me.Pbdot1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Pbdot1.Name = "Pbdot1"
        Me.Pbdot1.Size = New System.Drawing.Size(80, 70)
        Me.Pbdot1.TabIndex = 2
        Me.Pbdot1.TabStop = False
        '
        'Pbc1
        '
        Me.Pbc1.BackColor = System.Drawing.Color.White
        Me.Pbc1.BackgroundImage = CType(resources.GetObject("Pbc1.BackgroundImage"), System.Drawing.Image)
        Me.Pbc1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pbc1.Location = New System.Drawing.Point(0, 228)
        Me.Pbc1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Pbc1.Name = "Pbc1"
        Me.Pbc1.Size = New System.Drawing.Size(80, 70)
        Me.Pbc1.TabIndex = 1
        Me.Pbc1.TabStop = False
        '
        'Pb01
        '
        Me.Pb01.BackColor = System.Drawing.Color.White
        Me.Pb01.BackgroundImage = CType(resources.GetObject("Pb01.BackgroundImage"), System.Drawing.Image)
        Me.Pb01.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pb01.Location = New System.Drawing.Point(86, 228)
        Me.Pb01.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.Pb01.Name = "Pb01"
        Me.Pb01.Size = New System.Drawing.Size(80, 70)
        Me.Pb01.TabIndex = 0
        Me.Pb01.TabStop = False
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 344.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.dgvInvoice, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.51834!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(650, 578)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvTotal2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.dgvTotal)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 440)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 135)
        Me.Panel1.TabIndex = 0
        '
        'dgvTotal2
        '
        Me.dgvTotal2.AllowUserToAddRows = False
        Me.dgvTotal2.AllowUserToDeleteRows = False
        Me.dgvTotal2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTotal2.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotal2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTotal2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal2.ColumnHeadersVisible = False
        Me.dgvTotal2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dgvTotal2.Location = New System.Drawing.Point(86, 1)
        Me.dgvTotal2.MultiSelect = False
        Me.dgvTotal2.Name = "dgvTotal2"
        Me.dgvTotal2.RowHeadersVisible = False
        Me.dgvTotal2.Size = New System.Drawing.Size(226, 132)
        Me.dgvTotal2.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.DataGridViewTextBoxColumn1.HeaderText = "Caption"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Value"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(81, 157)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cboPayment)
        Me.Panel3.Location = New System.Drawing.Point(6, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(75, 38)
        Me.Panel3.TabIndex = 0
        '
        'cboPayment
        '
        Me.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPayment.FormattingEnabled = True
        Me.cboPayment.ItemHeight = 25
        Me.cboPayment.Items.AddRange(New Object() {"نقدي", "آجل"})
        Me.cboPayment.Location = New System.Drawing.Point(5, 3)
        Me.cboPayment.Name = "cboPayment"
        Me.cboPayment.Size = New System.Drawing.Size(70, 33)
        Me.cboPayment.TabIndex = 2
        '
        'dgvTotal
        '
        Me.dgvTotal.AllowUserToAddRows = False
        Me.dgvTotal.AllowUserToDeleteRows = False
        Me.dgvTotal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTotal.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotal.ColumnHeadersVisible = False
        Me.dgvTotal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Caption, Me.Value})
        Me.dgvTotal.Location = New System.Drawing.Point(317, 1)
        Me.dgvTotal.MultiSelect = False
        Me.dgvTotal.Name = "dgvTotal"
        Me.dgvTotal.RowHeadersVisible = False
        Me.dgvTotal.Size = New System.Drawing.Size(293, 132)
        Me.dgvTotal.TabIndex = 0
        '
        'Caption
        '
        Me.Caption.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.Caption.HeaderText = "Caption"
        Me.Caption.Name = "Caption"
        Me.Caption.Width = 5
        '
        'Value
        '
        Me.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Value.HeaderText = "Value"
        Me.Value.Name = "Value"
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AllowUserToAddRows = False
        Me.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvInvoice.BackgroundColor = System.Drawing.Color.White
        Me.dgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.ContextMenuStrip = Me.cmsDGV
        Me.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvInvoice.Location = New System.Drawing.Point(3, 3)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.RowHeadersVisible = False
        Me.dgvInvoice.Size = New System.Drawing.Size(644, 431)
        Me.dgvInvoice.TabIndex = 1
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddItem)
        Me.Panel2.Controls.Add(Me.cboItem)
        Me.Panel2.Controls.Add(Me.cboItemType)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1002, 35)
        Me.Panel2.TabIndex = 22
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(3, 0)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(43, 32)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "+"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'cboItemType
        '
        Me.cboItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboItemType.FormattingEnabled = True
        Me.cboItemType.Location = New System.Drawing.Point(52, 0)
        Me.cboItemType.Name = "cboItemType"
        Me.cboItemType.Size = New System.Drawing.Size(121, 33)
        Me.cboItemType.TabIndex = 2
        '
        'cboItem
        '
        Me.cboItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItem.IsDgvLocationHeightSet = False
        Me.cboItem.Location = New System.Drawing.Point(176, 0)
        Me.cboItem.Margin = New System.Windows.Forms.Padding(0)
        Me.cboItem.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboItem.MyIsColumnHeaderVisible = False
        Me.cboItem.MySelectedValue = Nothing
        Me.cboItem.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(740, 32)
        Me.cboItem.TabIndex = 3
        Me.cboItem.TabOnEnter = True
        '
        'Frm_Invoice
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1008, 711)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "Frm_Invoice"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.dgvInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Pbenterbig1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb81, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbdot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbc1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pb01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvTotal2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDGV.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPreviosInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNextInvoice As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblTotal As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgvInfo As ByteDGV
    Friend WithEvents Title As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Disc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvTotal As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboItemType As System.Windows.Forms.ComboBox
    Friend WithEvents cboPayment As System.Windows.Forms.ComboBox
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Caption As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Value As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cboItem As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents dgvInvoice As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents btnView As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPrint As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCreateSellInvoce As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReturn As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmsDGV As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ادارةالباركودToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents dgvTotal2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Pbenterbig1 As ByteMyPictureBox.pbenterbig
    Friend WithEvents Pb91 As ByteMyPictureBox.pb9
    Friend WithEvents Pb81 As ByteMyPictureBox.pb8
    Friend WithEvents Pb71 As ByteMyPictureBox.pb7
    Friend WithEvents Pb61 As ByteMyPictureBox.pb6
    Friend WithEvents Pb51 As ByteMyPictureBox.pb5
    Friend WithEvents Pb41 As ByteMyPictureBox.pb4
    Friend WithEvents Pb31 As ByteMyPictureBox.pb3
    Friend WithEvents Pb21 As ByteMyPictureBox.pb2
    Friend WithEvents Pb11 As ByteMyPictureBox.pb1
    Friend WithEvents Pbdot1 As ByteMyPictureBox.pbdot
    Friend WithEvents Pbc1 As ByteMyPictureBox.pbc
    Friend WithEvents Pb01 As ByteMyPictureBox.pb0

End Class
