<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ProductExpress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ProductExpress))
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.txtBarcode = New ByteClassLibrary.MyTextBox()
        Me.lblTypeID = New System.Windows.Forms.Label()
        Me.cboTypeID = New ByteClassLibrary.MyComboBox()
        Me.lblBrandID = New System.Windows.Forms.Label()
        Me.cboBrandID = New ByteClassLibrary.MyComboBox()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductName = New ByteClassLibrary.MyTextBox()
        Me.lblProductDetails = New System.Windows.Forms.Label()
        Me.txtProductDetails = New ByteClassLibrary.MyTextBox()
        Me.lblSellPrice = New System.Windows.Forms.Label()
        Me.numSellPrice = New ByteClassLibrary.MyNumericBox()
        Me.lblSubAmount = New System.Windows.Forms.Label()
        Me.numSubAmount = New ByteClassLibrary.MyNumericBox()
        Me.lblPacketSellPrice = New System.Windows.Forms.Label()
        Me.numPacketSellPrice = New ByteClassLibrary.MyNumericBox()
        Me.lblAlertAmount = New System.Windows.Forms.Label()
        Me.numAlertAmount = New ByteClassLibrary.MyNumericBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numUnitCost = New ByteClassLibrary.MyNumericBox()
        Me.btnEnter = New ByteClassLibrary.MyButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numAmount = New ByteClassLibrary.MyNumericBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBarcode.Location = New System.Drawing.Point(73, 15)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(48, 25)
        Me.lblBarcode.TabIndex = 118
        Me.lblBarcode.Text = "باركود"
        '
        'txtBarcode
        '
        Me.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBarcode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtBarcode.Location = New System.Drawing.Point(129, 12)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.ReadOnly = True
        Me.txtBarcode.Size = New System.Drawing.Size(261, 25)
        Me.txtBarcode.TabIndex = 109
        Me.txtBarcode.TabStop = False
        '
        'lblTypeID
        '
        Me.lblTypeID.AutoSize = True
        Me.lblTypeID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTypeID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblTypeID.Location = New System.Drawing.Point(82, 53)
        Me.lblTypeID.Name = "lblTypeID"
        Me.lblTypeID.Size = New System.Drawing.Size(41, 25)
        Me.lblTypeID.TabIndex = 119
        Me.lblTypeID.Text = "النوع"
        '
        'cboTypeID
        '
        Me.cboTypeID.FormattingEnabled = True
        Me.cboTypeID.Location = New System.Drawing.Point(129, 50)
        Me.cboTypeID.Name = "cboTypeID"
        Me.cboTypeID.Size = New System.Drawing.Size(261, 33)
        Me.cboTypeID.TabIndex = 1
        Me.cboTypeID.TabOnEnter = True
        '
        'lblBrandID
        '
        Me.lblBrandID.AutoSize = True
        Me.lblBrandID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblBrandID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblBrandID.Location = New System.Drawing.Point(72, 92)
        Me.lblBrandID.Name = "lblBrandID"
        Me.lblBrandID.Size = New System.Drawing.Size(51, 25)
        Me.lblBrandID.TabIndex = 120
        Me.lblBrandID.Text = "الماركة"
        '
        'cboBrandID
        '
        Me.cboBrandID.FormattingEnabled = True
        Me.cboBrandID.Location = New System.Drawing.Point(129, 89)
        Me.cboBrandID.Name = "cboBrandID"
        Me.cboBrandID.Size = New System.Drawing.Size(261, 33)
        Me.cboBrandID.TabIndex = 2
        Me.cboBrandID.TabOnEnter = True
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductName.Location = New System.Drawing.Point(79, 131)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(42, 25)
        Me.lblProductName.TabIndex = 121
        Me.lblProductName.Text = "الاسم"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(129, 128)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(261, 32)
        Me.txtProductName.TabIndex = 3
        '
        'lblProductDetails
        '
        Me.lblProductDetails.AutoSize = True
        Me.lblProductDetails.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblProductDetails.Location = New System.Drawing.Point(55, 169)
        Me.lblProductDetails.Name = "lblProductDetails"
        Me.lblProductDetails.Size = New System.Drawing.Size(68, 25)
        Me.lblProductDetails.TabIndex = 122
        Me.lblProductDetails.Text = "التفاصيل"
        '
        'txtProductDetails
        '
        Me.txtProductDetails.Location = New System.Drawing.Point(129, 166)
        Me.txtProductDetails.Multiline = True
        Me.txtProductDetails.Name = "txtProductDetails"
        Me.txtProductDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProductDetails.Size = New System.Drawing.Size(261, 72)
        Me.txtProductDetails.TabIndex = 4
        '
        'lblSellPrice
        '
        Me.lblSellPrice.AutoSize = True
        Me.lblSellPrice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSellPrice.Location = New System.Drawing.Point(50, 382)
        Me.lblSellPrice.Name = "lblSellPrice"
        Me.lblSellPrice.Size = New System.Drawing.Size(71, 25)
        Me.lblSellPrice.TabIndex = 123
        Me.lblSellPrice.Text = "سعر البيع"
        '
        'numSellPrice
        '
        Me.numSellPrice.Location = New System.Drawing.Point(129, 379)
        Me.numSellPrice.Name = "numSellPrice"
        Me.numSellPrice.Size = New System.Drawing.Size(261, 32)
        Me.numSellPrice.TabIndex = 8
        '
        'lblSubAmount
        '
        Me.lblSubAmount.AutoSize = True
        Me.lblSubAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblSubAmount.Location = New System.Drawing.Point(10, 420)
        Me.lblSubAmount.Name = "lblSubAmount"
        Me.lblSubAmount.Size = New System.Drawing.Size(111, 25)
        Me.lblSubAmount.TabIndex = 124
        Me.lblSubAmount.Text = "عبوة لكل صندوق"
        '
        'numSubAmount
        '
        Me.numSubAmount.Location = New System.Drawing.Point(129, 417)
        Me.numSubAmount.Name = "numSubAmount"
        Me.numSubAmount.Size = New System.Drawing.Size(261, 32)
        Me.numSubAmount.TabIndex = 9
        '
        'lblPacketSellPrice
        '
        Me.lblPacketSellPrice.AutoSize = True
        Me.lblPacketSellPrice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblPacketSellPrice.Location = New System.Drawing.Point(30, 458)
        Me.lblPacketSellPrice.Name = "lblPacketSellPrice"
        Me.lblPacketSellPrice.Size = New System.Drawing.Size(91, 25)
        Me.lblPacketSellPrice.TabIndex = 125
        Me.lblPacketSellPrice.Text = "سعر الصندوق"
        '
        'numPacketSellPrice
        '
        Me.numPacketSellPrice.Location = New System.Drawing.Point(129, 455)
        Me.numPacketSellPrice.Name = "numPacketSellPrice"
        Me.numPacketSellPrice.Size = New System.Drawing.Size(261, 32)
        Me.numPacketSellPrice.TabIndex = 10
        '
        'lblAlertAmount
        '
        Me.lblAlertAmount.AutoSize = True
        Me.lblAlertAmount.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblAlertAmount.Location = New System.Drawing.Point(30, 247)
        Me.lblAlertAmount.Name = "lblAlertAmount"
        Me.lblAlertAmount.Size = New System.Drawing.Size(93, 25)
        Me.lblAlertAmount.TabIndex = 126
        Me.lblAlertAmount.Text = "الكمية الحرجة"
        '
        'numAlertAmount
        '
        Me.numAlertAmount.Location = New System.Drawing.Point(129, 244)
        Me.numAlertAmount.Name = "numAlertAmount"
        Me.numAlertAmount.Size = New System.Drawing.Size(261, 32)
        Me.numAlertAmount.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(26, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "تكلفة القطعة"
        '
        'numUnitCost
        '
        Me.numUnitCost.Location = New System.Drawing.Point(129, 303)
        Me.numUnitCost.Name = "numUnitCost"
        Me.numUnitCost.Size = New System.Drawing.Size(261, 32)
        Me.numUnitCost.TabIndex = 6
        '
        'btnEnter
        '
        Me.btnEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnEnter.BackgroundImage = CType(resources.GetObject("btnEnter.BackgroundImage"), System.Drawing.Image)
        Me.btnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnter.FlatAppearance.BorderSize = 0
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnter.Location = New System.Drawing.Point(253, 493)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(137, 34)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "إدخال"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(71, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 25)
        Me.Label2.TabIndex = 130
        Me.Label2.Text = "الكمية"
        '
        'numAmount
        '
        Me.numAmount.Location = New System.Drawing.Point(129, 341)
        Me.numAmount.Name = "numAmount"
        Me.numAmount.Size = New System.Drawing.Size(261, 32)
        Me.numAmount.TabIndex = 7
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frm_ProductExpress
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(427, 552)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numAmount)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numUnitCost)
        Me.Controls.Add(Me.lblBarcode)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.lblTypeID)
        Me.Controls.Add(Me.cboTypeID)
        Me.Controls.Add(Me.lblBrandID)
        Me.Controls.Add(Me.cboBrandID)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.lblProductDetails)
        Me.Controls.Add(Me.txtProductDetails)
        Me.Controls.Add(Me.lblSellPrice)
        Me.Controls.Add(Me.numSellPrice)
        Me.Controls.Add(Me.lblSubAmount)
        Me.Controls.Add(Me.numSubAmount)
        Me.Controls.Add(Me.lblPacketSellPrice)
        Me.Controls.Add(Me.numPacketSellPrice)
        Me.Controls.Add(Me.lblAlertAmount)
        Me.Controls.Add(Me.numAlertAmount)
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ProductExpress"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_ProductExpress"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBarcode As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As ByteClassLibrary.MyTextBox
    Friend WithEvents lblTypeID As System.Windows.Forms.Label
    Friend WithEvents cboTypeID As ByteClassLibrary.MyComboBox
    Friend WithEvents lblBrandID As System.Windows.Forms.Label
    Friend WithEvents cboBrandID As ByteClassLibrary.MyComboBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As ByteClassLibrary.MyTextBox
    Friend WithEvents lblProductDetails As System.Windows.Forms.Label
    Friend WithEvents txtProductDetails As ByteClassLibrary.MyTextBox
    Friend WithEvents lblSellPrice As System.Windows.Forms.Label
    Friend WithEvents numSellPrice As ByteClassLibrary.MyNumericBox
    Friend WithEvents lblSubAmount As System.Windows.Forms.Label
    Friend WithEvents numSubAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents lblPacketSellPrice As System.Windows.Forms.Label
    Friend WithEvents numPacketSellPrice As ByteClassLibrary.MyNumericBox
    Friend WithEvents lblAlertAmount As System.Windows.Forms.Label
    Friend WithEvents numAlertAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numUnitCost As ByteClassLibrary.MyNumericBox
    Friend WithEvents btnEnter As ByteClassLibrary.MyButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numAmount As ByteClassLibrary.MyNumericBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
