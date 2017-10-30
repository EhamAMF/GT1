<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SelectStock
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cboProductsToGet = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboItem = New ByteClassLibrary.MyGridTextBox3()
        Me.ByteBtnB151 = New ByteMyPictureBox.ByteBtnB()
        Me.btnEmpty = New ByteMyPictureBox.ByteBtnB()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cboProductsToGet)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.cboItem)
        Me.Panel6.Location = New System.Drawing.Point(12, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(789, 44)
        Me.Panel6.TabIndex = 22
        '
        'cboProductsToGet
        '
        Me.cboProductsToGet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProductsToGet.FormattingEnabled = True
        Me.cboProductsToGet.Items.AddRange(New Object() {"كل الاصناف", "أصنافي", "الاصناف الموجودة"})
        Me.cboProductsToGet.Location = New System.Drawing.Point(48, 5)
        Me.cboProductsToGet.Name = "cboProductsToGet"
        Me.cboProductsToGet.Size = New System.Drawing.Size(110, 33)
        Me.cboProductsToGet.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(734, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "الصنف"
        '
        'cboItem
        '
        Me.cboItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboItem.IsDgvLocationHeightSet = False
        Me.cboItem.Location = New System.Drawing.Point(161, 5)
        Me.cboItem.Margin = New System.Windows.Forms.Padding(0)
        Me.cboItem.MyCellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.cboItem.MyIsColumnHeaderVisible = False
        Me.cboItem.MySelectedValue = Nothing
        Me.cboItem.MySelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.cboItem.Name = "cboItem"
        Me.cboItem.Size = New System.Drawing.Size(570, 32)
        Me.cboItem.TabIndex = 5
        Me.cboItem.TabOnEnter = True
        '
        'ByteBtnB151
        '
        Me.ByteBtnB151.BackColor = System.Drawing.Color.White
        Me.ByteBtnB151.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ByteBtnB151.ButtonColor = ByteMyPictureBox.ByteBtnB.BtnColor.White
        Me.ByteBtnB151.FlatAppearance.BorderSize = 0
        Me.ByteBtnB151.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ByteBtnB151.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.ByteBtnB151.Location = New System.Drawing.Point(690, 62)
        Me.ByteBtnB151.Name = "ByteBtnB151"
        Me.ByteBtnB151.Size = New System.Drawing.Size(111, 42)
        Me.ByteBtnB151.TabIndex = 23
        Me.ByteBtnB151.Text = "خروج"
        Me.ByteBtnB151.UseVisualStyleBackColor = True
        '
        'btnEmpty
        '
        Me.btnEmpty.BackColor = System.Drawing.Color.White
        Me.btnEmpty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEmpty.ButtonColor = ByteMyPictureBox.ByteBtnB.BtnColor.White
        Me.btnEmpty.FlatAppearance.BorderSize = 0
        Me.btnEmpty.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(151, Byte), Integer))
        Me.btnEmpty.Location = New System.Drawing.Point(532, 62)
        Me.btnEmpty.Name = "btnEmpty"
        Me.btnEmpty.Size = New System.Drawing.Size(152, 42)
        Me.btnEmpty.TabIndex = 24
        Me.btnEmpty.Text = "فارغ"
        Me.btnEmpty.UseVisualStyleBackColor = True
        '
        'frm_SelectStock
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(814, 128)
        Me.Controls.Add(Me.btnEmpty)
        Me.Controls.Add(Me.ByteBtnB151)
        Me.Controls.Add(Me.Panel6)
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximumSize = New System.Drawing.Size(830, 167)
        Me.MinimumSize = New System.Drawing.Size(830, 167)
        Me.Name = "frm_SelectStock"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اختيار الصنف"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cboProductsToGet As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboItem As ByteClassLibrary.MyGridTextBox3
    Friend WithEvents ByteBtnB151 As ByteMyPictureBox.ByteBtnB
    Friend WithEvents btnEmpty As ByteMyPictureBox.ByteBtnB
End Class
