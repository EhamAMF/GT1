<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Activation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Activation))
        Me.PHeaderSTR = New System.Windows.Forms.Panel()
        Me.lblHeaderSTR = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New ByteClassLibrary.MyTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLicense = New ByteClassLibrary.MyTextBox()
        Me.Picturebox1 = New System.Windows.Forms.PictureBox()
        Me.btnActivate = New ByteClassLibrary.MyButton()
        Me.bk1 = New System.ComponentModel.BackgroundWorker()
        Me.PHeaderSTR.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PHeaderSTR
        '
        Me.PHeaderSTR.Controls.Add(Me.lblHeaderSTR)
        Me.PHeaderSTR.Controls.Add(Me.txtPhoneNumber)
        Me.PHeaderSTR.Location = New System.Drawing.Point(9, 9)
        Me.PHeaderSTR.Margin = New System.Windows.Forms.Padding(0)
        Me.PHeaderSTR.Name = "PHeaderSTR"
        Me.PHeaderSTR.Size = New System.Drawing.Size(445, 37)
        Me.PHeaderSTR.TabIndex = 203
        '
        'lblHeaderSTR
        '
        Me.lblHeaderSTR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderSTR.AutoSize = True
        Me.lblHeaderSTR.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblHeaderSTR.Location = New System.Drawing.Point(297, 3)
        Me.lblHeaderSTR.Name = "lblHeaderSTR"
        Me.lblHeaderSTR.Size = New System.Drawing.Size(76, 25)
        Me.lblHeaderSTR.TabIndex = 100
        Me.lblHeaderSTR.Text = "رقم الهاتف"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPhoneNumber.Location = New System.Drawing.Point(0, 0)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPhoneNumber.Size = New System.Drawing.Size(285, 32)
        Me.txtPhoneNumber.TabIndex = 0
        Me.txtPhoneNumber.Text = "09"
        Me.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtLicense)
        Me.Panel2.Location = New System.Drawing.Point(9, 46)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 37)
        Me.Panel2.TabIndex = 205
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(297, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 25)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "الرمز"
        '
        'txtLicense
        '
        Me.txtLicense.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLicense.Location = New System.Drawing.Point(0, 0)
        Me.txtLicense.Name = "txtLicense"
        Me.txtLicense.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtLicense.Size = New System.Drawing.Size(285, 32)
        Me.txtLicense.TabIndex = 0
        Me.txtLicense.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtLicense.UseSystemPasswordChar = True
        '
        'Picturebox1
        '
        Me.Picturebox1.Image = Global.GT1.My.Resources.Resources.Loading
        Me.Picturebox1.Location = New System.Drawing.Point(365, 97)
        Me.Picturebox1.Name = "Picturebox1"
        Me.Picturebox1.Size = New System.Drawing.Size(38, 38)
        Me.Picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picturebox1.TabIndex = 213
        Me.Picturebox1.TabStop = False
        Me.Picturebox1.Visible = False
        '
        'btnActivate
        '
        Me.btnActivate.BackgroundImage = CType(resources.GetObject("btnActivate.BackgroundImage"), System.Drawing.Image)
        Me.btnActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActivate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActivate.Location = New System.Drawing.Point(169, 97)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(190, 38)
        Me.btnActivate.TabIndex = 212
        Me.btnActivate.Text = "تفعيل"
        '
        'bk1
        '
        Me.bk1.WorkerReportsProgress = True
        Me.bk1.WorkerSupportsCancellation = True
        '
        'frm_Activation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(473, 157)
        Me.Controls.Add(Me.Picturebox1)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PHeaderSTR)
        Me.Font = New System.Drawing.Font("Aljazeera", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "frm_Activation"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "تفعيل"
        Me.PHeaderSTR.ResumeLayout(False)
        Me.PHeaderSTR.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PHeaderSTR As System.Windows.Forms.Panel
    Friend WithEvents lblHeaderSTR As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As ByteClassLibrary.MyTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLicense As ByteClassLibrary.MyTextBox
    Friend WithEvents Picturebox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnActivate As ByteClassLibrary.MyButton
    Friend WithEvents bk1 As System.ComponentModel.BackgroundWorker
End Class
