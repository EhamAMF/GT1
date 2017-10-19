<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Settings))
        Me.PHeaderSTR = New System.Windows.Forms.Panel()
        Me.lblHeaderSTR = New System.Windows.Forms.Label()
        Me.txtHeaderSTR = New ByteClassLibrary.MyTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFooterSTR = New ByteClassLibrary.MyTextBox()
        Me.chkIsExDateShown = New System.Windows.Forms.CheckBox()
        Me.chkIsRackShown = New System.Windows.Forms.CheckBox()
        Me.chkIsBarcodeShown = New System.Windows.Forms.CheckBox()
        Me.chkIsProductDetailsShown = New System.Windows.Forms.CheckBox()
        Me.chkIsProductCodeShown = New System.Windows.Forms.CheckBox()
        Me.chkIsPacketDefault = New System.Windows.Forms.CheckBox()
        Me.chkIsPacketSystem = New System.Windows.Forms.CheckBox()
        Me.btnSave = New ByteClassLibrary.MyButton()
        Me.bw = New System.ComponentModel.BackgroundWorker()
        Me.Picturebox1 = New System.Windows.Forms.PictureBox()
        Me.chkIsDuplicateProductInInvoice = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboInvoiceLayout = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PHeaderSTR.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PHeaderSTR
        '
        Me.PHeaderSTR.Controls.Add(Me.lblHeaderSTR)
        Me.PHeaderSTR.Controls.Add(Me.txtHeaderSTR)
        Me.PHeaderSTR.Location = New System.Drawing.Point(24, 24)
        Me.PHeaderSTR.Margin = New System.Windows.Forms.Padding(0)
        Me.PHeaderSTR.Name = "PHeaderSTR"
        Me.PHeaderSTR.Size = New System.Drawing.Size(445, 37)
        Me.PHeaderSTR.TabIndex = 201
        '
        'lblHeaderSTR
        '
        Me.lblHeaderSTR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderSTR.AutoSize = True
        Me.lblHeaderSTR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblHeaderSTR.Location = New System.Drawing.Point(320, 3)
        Me.lblHeaderSTR.Name = "lblHeaderSTR"
        Me.lblHeaderSTR.Size = New System.Drawing.Size(126, 25)
        Me.lblHeaderSTR.TabIndex = 100
        Me.lblHeaderSTR.Text = "اسم الشركة ""المحل"""
        '
        'txtHeaderSTR
        '
        Me.txtHeaderSTR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHeaderSTR.Location = New System.Drawing.Point(0, 0)
        Me.txtHeaderSTR.Name = "txtHeaderSTR"
        Me.txtHeaderSTR.Size = New System.Drawing.Size(314, 32)
        Me.txtHeaderSTR.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFooterSTR)
        Me.Panel1.Location = New System.Drawing.Point(24, 61)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 37)
        Me.Panel1.TabIndex = 202
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(320, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 25)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "عنوان هاتف"
        '
        'txtFooterSTR
        '
        Me.txtFooterSTR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFooterSTR.Location = New System.Drawing.Point(0, 0)
        Me.txtFooterSTR.Name = "txtFooterSTR"
        Me.txtFooterSTR.Size = New System.Drawing.Size(314, 32)
        Me.txtFooterSTR.TabIndex = 0
        '
        'chkIsExDateShown
        '
        Me.chkIsExDateShown.AutoSize = True
        Me.chkIsExDateShown.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsExDateShown.Location = New System.Drawing.Point(155, 406)
        Me.chkIsExDateShown.Name = "chkIsExDateShown"
        Me.chkIsExDateShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsExDateShown.Size = New System.Drawing.Size(155, 29)
        Me.chkIsExDateShown.TabIndex = 209
        Me.chkIsExDateShown.Text = "إظهار صلاحية الصنف"
        Me.chkIsExDateShown.UseVisualStyleBackColor = True
        '
        'chkIsRackShown
        '
        Me.chkIsRackShown.AutoSize = True
        Me.chkIsRackShown.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsRackShown.Location = New System.Drawing.Point(155, 371)
        Me.chkIsRackShown.Name = "chkIsRackShown"
        Me.chkIsRackShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsRackShown.Size = New System.Drawing.Size(141, 29)
        Me.chkIsRackShown.TabIndex = 208
        Me.chkIsRackShown.Text = "أظهار موقع الصنف"
        Me.chkIsRackShown.UseVisualStyleBackColor = True
        '
        'chkIsBarcodeShown
        '
        Me.chkIsBarcodeShown.AutoSize = True
        Me.chkIsBarcodeShown.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsBarcodeShown.Location = New System.Drawing.Point(155, 336)
        Me.chkIsBarcodeShown.Name = "chkIsBarcodeShown"
        Me.chkIsBarcodeShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsBarcodeShown.Size = New System.Drawing.Size(144, 29)
        Me.chkIsBarcodeShown.TabIndex = 207
        Me.chkIsBarcodeShown.Text = "أظهار باركود الصنف"
        Me.chkIsBarcodeShown.UseVisualStyleBackColor = True
        '
        'chkIsProductDetailsShown
        '
        Me.chkIsProductDetailsShown.AutoSize = True
        Me.chkIsProductDetailsShown.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsProductDetailsShown.Location = New System.Drawing.Point(155, 301)
        Me.chkIsProductDetailsShown.Name = "chkIsProductDetailsShown"
        Me.chkIsProductDetailsShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsProductDetailsShown.Size = New System.Drawing.Size(156, 29)
        Me.chkIsProductDetailsShown.TabIndex = 206
        Me.chkIsProductDetailsShown.Text = "أظهار تفاصيل الصنف"
        Me.chkIsProductDetailsShown.UseVisualStyleBackColor = True
        '
        'chkIsProductCodeShown
        '
        Me.chkIsProductCodeShown.AutoSize = True
        Me.chkIsProductCodeShown.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsProductCodeShown.Location = New System.Drawing.Point(155, 266)
        Me.chkIsProductCodeShown.Name = "chkIsProductCodeShown"
        Me.chkIsProductCodeShown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsProductCodeShown.Size = New System.Drawing.Size(129, 29)
        Me.chkIsProductCodeShown.TabIndex = 205
        Me.chkIsProductCodeShown.Text = "إظهار كود الصنف"
        Me.chkIsProductCodeShown.UseVisualStyleBackColor = True
        '
        'chkIsPacketDefault
        '
        Me.chkIsPacketDefault.AutoSize = True
        Me.chkIsPacketDefault.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsPacketDefault.Location = New System.Drawing.Point(155, 207)
        Me.chkIsPacketDefault.Name = "chkIsPacketDefault"
        Me.chkIsPacketDefault.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsPacketDefault.Size = New System.Drawing.Size(172, 29)
        Me.chkIsPacketDefault.TabIndex = 204
        Me.chkIsPacketDefault.Text = "الوضع الافتراضي صندوق"
        Me.chkIsPacketDefault.UseVisualStyleBackColor = True
        '
        'chkIsPacketSystem
        '
        Me.chkIsPacketSystem.AutoSize = True
        Me.chkIsPacketSystem.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsPacketSystem.Location = New System.Drawing.Point(155, 172)
        Me.chkIsPacketSystem.Name = "chkIsPacketSystem"
        Me.chkIsPacketSystem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsPacketSystem.Size = New System.Drawing.Size(106, 29)
        Me.chkIsPacketSystem.TabIndex = 203
        Me.chkIsPacketSystem.Text = "نظام صندوق"
        Me.chkIsPacketSystem.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(155, 532)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 38)
        Me.btnSave.TabIndex = 210
        Me.btnSave.Text = "حفظ"
        '
        'bw
        '
        Me.bw.WorkerReportsProgress = True
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(351, 532)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 211
        Me.Picturebox1.TabStop = False
        Me.Picturebox1.Visible = False
        '
        'chkIsDuplicateProductInInvoice
        '
        Me.chkIsDuplicateProductInInvoice.AutoSize = True
        Me.chkIsDuplicateProductInInvoice.ForeColor = System.Drawing.Color.RoyalBlue
        Me.chkIsDuplicateProductInInvoice.Location = New System.Drawing.Point(155, 473)
        Me.chkIsDuplicateProductInInvoice.Name = "chkIsDuplicateProductInInvoice"
        Me.chkIsDuplicateProductInInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkIsDuplicateProductInInvoice.Size = New System.Drawing.Size(170, 29)
        Me.chkIsDuplicateProductInInvoice.TabIndex = 212
        Me.chkIsDuplicateProductInInvoice.Text = "تكرار الصنف في الفاتورة"
        Me.chkIsDuplicateProductInInvoice.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboInvoiceLayout)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(24, 98)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 37)
        Me.Panel2.TabIndex = 203
        '
        'cboInvoiceLayout
        '
        Me.cboInvoiceLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboInvoiceLayout.FormattingEnabled = True
        Me.cboInvoiceLayout.Location = New System.Drawing.Point(0, 4)
        Me.cboInvoiceLayout.Name = "cboInvoiceLayout"
        Me.cboInvoiceLayout.Size = New System.Drawing.Size(314, 33)
        Me.cboInvoiceLayout.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(320, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 25)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "حجم الفاتورة"
        '
        'frm_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(493, 603)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.chkIsDuplicateProductInInvoice)
        Me.Controls.Add(Me.Picturebox1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkIsExDateShown)
        Me.Controls.Add(Me.chkIsRackShown)
        Me.Controls.Add(Me.chkIsBarcodeShown)
        Me.Controls.Add(Me.chkIsProductDetailsShown)
        Me.Controls.Add(Me.chkIsProductCodeShown)
        Me.Controls.Add(Me.chkIsPacketDefault)
        Me.Controls.Add(Me.chkIsPacketSystem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PHeaderSTR)
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_Settings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اعدادات"
        Me.PHeaderSTR.ResumeLayout(False)
        Me.PHeaderSTR.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PHeaderSTR As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderSTR As System.Windows.Forms.Label
    Friend WithEvents txtHeaderSTR As ByteClassLibrary.MyTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFooterSTR As ByteClassLibrary.MyTextBox
    Friend WithEvents chkIsExDateShown As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsRackShown As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsBarcodeShown As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsProductDetailsShown As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsProductCodeShown As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsPacketDefault As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsPacketSystem As System.Windows.Forms.CheckBox
    Friend WithEvents btnSave As ByteClassLibrary.MyButton
    Friend WithEvents bw As System.ComponentModel.BackgroundWorker
    Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox
    Friend WithEvents chkIsDuplicateProductInInvoice As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cboInvoiceLayout As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
