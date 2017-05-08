<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MyComboBox1 = New ByteClassLibrary.MyComboBox()
        Me.MyComboBox2 = New ByteClassLibrary.MyComboBox()
        Me.pRevPer = New System.Windows.Forms.Panel()
        Me.numRevPer = New ByteClassLibrary.MyNumericBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.pRev = New System.Windows.Forms.Panel()
        Me.numRev = New ByteClassLibrary.MyNumericBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pFinal = New System.Windows.Forms.Panel()
        Me.numFinal = New ByteClassLibrary.MyNumericBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pDiscount = New System.Windows.Forms.Panel()
        Me.numDiscount = New ByteClassLibrary.MyNumericBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pTotal = New System.Windows.Forms.Panel()
        Me.numTotal = New ByteClassLibrary.MyNumericBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MyButton1 = New ByteClassLibrary.MyButton()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pRevPer.SuspendLayout()
        Me.pRev.SuspendLayout()
        Me.pFinal.SuspendLayout()
        Me.pDiscount.SuspendLayout()
        Me.pTotal.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Location = New System.Drawing.Point(31, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 141)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.MyComboBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.MyComboBox2)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(68, 31)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(333, 84)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'MyComboBox1
        '
        Me.MyComboBox1.FormattingEnabled = True
        Me.MyComboBox1.Location = New System.Drawing.Point(3, 3)
        Me.MyComboBox1.Name = "MyComboBox1"
        Me.MyComboBox1.Size = New System.Drawing.Size(277, 21)
        Me.MyComboBox1.TabIndex = 0
        Me.MyComboBox1.TabOnEnter = True
        '
        'MyComboBox2
        '
        Me.MyComboBox2.FormattingEnabled = True
        Me.MyComboBox2.Location = New System.Drawing.Point(3, 30)
        Me.MyComboBox2.Name = "MyComboBox2"
        Me.MyComboBox2.Size = New System.Drawing.Size(277, 21)
        Me.MyComboBox2.TabIndex = 1
        Me.MyComboBox2.TabOnEnter = True
        '
        'pRevPer
        '
        Me.pRevPer.Controls.Add(Me.numRevPer)
        Me.pRevPer.Controls.Add(Me.Label15)
        Me.pRevPer.Location = New System.Drawing.Point(31, 239)
        Me.pRevPer.Margin = New System.Windows.Forms.Padding(0)
        Me.pRevPer.Name = "pRevPer"
        Me.pRevPer.Padding = New System.Windows.Forms.Padding(5)
        Me.pRevPer.Size = New System.Drawing.Size(164, 43)
        Me.pRevPer.TabIndex = 117
        '
        'numRevPer
        '
        Me.numRevPer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numRevPer.BackColor = System.Drawing.Color.White
        Me.numRevPer.ForeColor = System.Drawing.Color.Black
        Me.numRevPer.Location = New System.Drawing.Point(8, 5)
        Me.numRevPer.Name = "numRevPer"
        Me.numRevPer.Size = New System.Drawing.Size(104, 20)
        Me.numRevPer.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(118, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(26, 13)
        Me.Label15.TabIndex = 101
        Me.Label15.Text = "+%"
        '
        'pRev
        '
        Me.pRev.Controls.Add(Me.numRev)
        Me.pRev.Controls.Add(Me.Label16)
        Me.pRev.Location = New System.Drawing.Point(31, 196)
        Me.pRev.Margin = New System.Windows.Forms.Padding(0)
        Me.pRev.Name = "pRev"
        Me.pRev.Padding = New System.Windows.Forms.Padding(5)
        Me.pRev.Size = New System.Drawing.Size(164, 43)
        Me.pRev.TabIndex = 116
        '
        'numRev
        '
        Me.numRev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numRev.BackColor = System.Drawing.Color.White
        Me.numRev.ForeColor = System.Drawing.Color.Black
        Me.numRev.Location = New System.Drawing.Point(8, 3)
        Me.numRev.Name = "numRev"
        Me.numRev.Size = New System.Drawing.Size(104, 20)
        Me.numRev.TabIndex = 108
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(118, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(15, 13)
        Me.Label16.TabIndex = 101
        Me.Label16.Text = "+"
        '
        'pFinal
        '
        Me.pFinal.Controls.Add(Me.numFinal)
        Me.pFinal.Controls.Add(Me.Label13)
        Me.pFinal.Location = New System.Drawing.Point(195, 282)
        Me.pFinal.Margin = New System.Windows.Forms.Padding(0)
        Me.pFinal.Name = "pFinal"
        Me.pFinal.Padding = New System.Windows.Forms.Padding(5)
        Me.pFinal.Size = New System.Drawing.Size(268, 43)
        Me.pFinal.TabIndex = 115
        '
        'numFinal
        '
        Me.numFinal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numFinal.BackColor = System.Drawing.Color.White
        Me.numFinal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numFinal.ForeColor = System.Drawing.Color.Black
        Me.numFinal.Location = New System.Drawing.Point(5, 5)
        Me.numFinal.Name = "numFinal"
        Me.numFinal.Size = New System.Drawing.Size(166, 32)
        Me.numFinal.TabIndex = 108
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(177, 11)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 101
        Me.Label13.Text = "النهائي"
        '
        'pDiscount
        '
        Me.pDiscount.Controls.Add(Me.numDiscount)
        Me.pDiscount.Controls.Add(Me.Label12)
        Me.pDiscount.Location = New System.Drawing.Point(195, 239)
        Me.pDiscount.Margin = New System.Windows.Forms.Padding(0)
        Me.pDiscount.Name = "pDiscount"
        Me.pDiscount.Padding = New System.Windows.Forms.Padding(5)
        Me.pDiscount.Size = New System.Drawing.Size(268, 43)
        Me.pDiscount.TabIndex = 114
        '
        'numDiscount
        '
        Me.numDiscount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numDiscount.BackColor = System.Drawing.Color.White
        Me.numDiscount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numDiscount.ForeColor = System.Drawing.Color.Black
        Me.numDiscount.Location = New System.Drawing.Point(5, 5)
        Me.numDiscount.Name = "numDiscount"
        Me.numDiscount.Size = New System.Drawing.Size(166, 32)
        Me.numDiscount.TabIndex = 108
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(177, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 101
        Me.Label12.Text = "خصم"
        '
        'pTotal
        '
        Me.pTotal.Controls.Add(Me.numTotal)
        Me.pTotal.Controls.Add(Me.Label11)
        Me.pTotal.Location = New System.Drawing.Point(195, 196)
        Me.pTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.pTotal.Name = "pTotal"
        Me.pTotal.Padding = New System.Windows.Forms.Padding(5)
        Me.pTotal.Size = New System.Drawing.Size(268, 43)
        Me.pTotal.TabIndex = 113
        '
        'numTotal
        '
        Me.numTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.numTotal.BackColor = System.Drawing.Color.White
        Me.numTotal.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numTotal.ForeColor = System.Drawing.Color.Black
        Me.numTotal.Location = New System.Drawing.Point(5, 5)
        Me.numTotal.Name = "numTotal"
        Me.numTotal.Size = New System.Drawing.Size(166, 32)
        Me.numTotal.TabIndex = 108
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(177, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(48, 13)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "الاجمالي"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.PictureBox1.Location = New System.Drawing.Point(62, 318)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.TabIndex = 119
        Me.PictureBox1.TabStop = False
        '
        'MyButton1
        '
        Me.MyButton1.BackgroundImage = CType(resources.GetObject("MyButton1.BackgroundImage"), System.Drawing.Image)
        Me.MyButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MyButton1.FlatAppearance.BorderSize = 0
        Me.MyButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MyButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MyButton1.Location = New System.Drawing.Point(200, 328)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(166, 40)
        Me.MyButton1.TabIndex = 118
        Me.MyButton1.Text = "حفظ"
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 427)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.pRevPer)
        Me.Controls.Add(Me.pRev)
        Me.Controls.Add(Me.pFinal)
        Me.Controls.Add(Me.pDiscount)
        Me.Controls.Add(Me.pTotal)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pRevPer.ResumeLayout(False)
        Me.pRevPer.PerformLayout()
        Me.pRev.ResumeLayout(False)
        Me.pRev.PerformLayout()
        Me.pFinal.ResumeLayout(False)
        Me.pFinal.PerformLayout()
        Me.pDiscount.ResumeLayout(False)
        Me.pDiscount.PerformLayout()
        Me.pTotal.ResumeLayout(False)
        Me.pTotal.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents MyComboBox1 As ByteClassLibrary.MyComboBox
    Friend WithEvents MyComboBox2 As ByteClassLibrary.MyComboBox
    Friend WithEvents MyButton1 As ByteClassLibrary.MyButton
    Friend WithEvents pRevPer As System.Windows.Forms.Panel
    Friend WithEvents numRevPer As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents pRev As System.Windows.Forms.Panel
    Friend WithEvents numRev As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents pFinal As System.Windows.Forms.Panel
    Friend WithEvents numFinal As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pDiscount As System.Windows.Forms.Panel
    Friend WithEvents numDiscount As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pTotal As System.Windows.Forms.Panel
    Friend WithEvents numTotal As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
