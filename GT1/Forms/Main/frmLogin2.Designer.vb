<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin2))
        Me.TbUserName = New ByteClassLibrary.MyTextBox()
        Me.TbPassword = New ByteClassLibrary.MyTextBox()
        Me.BEnter = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbUserName
        '
        Me.TbUserName.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.TbUserName.ForeColor = System.Drawing.Color.Blue
        Me.TbUserName.Location = New System.Drawing.Point(24, 96)
        Me.TbUserName.Name = "TbUserName"
        Me.TbUserName.Size = New System.Drawing.Size(199, 31)
        Me.TbUserName.TabIndex = 1
        '
        'TbPassword
        '
        Me.TbPassword.ForeColor = System.Drawing.Color.Blue
        Me.TbPassword.Location = New System.Drawing.Point(24, 133)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.Size = New System.Drawing.Size(199, 31)
        Me.TbPassword.TabIndex = 2
        Me.TbPassword.UseSystemPasswordChar = True
        '
        'BEnter
        '
        Me.BEnter.BackColor = System.Drawing.Color.White
        Me.BEnter.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BEnter.ForeColor = System.Drawing.Color.Blue
        Me.BEnter.Location = New System.Drawing.Point(105, 170)
        Me.BEnter.Name = "BEnter"
        Me.BEnter.Size = New System.Drawing.Size(75, 30)
        Me.BEnter.TabIndex = 4
        Me.BEnter.Text = "دخول"
        Me.BEnter.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(229, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "المستخدم"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(229, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "كلمة المرور"
        '
        'BExit
        '
        Me.BExit.BackColor = System.Drawing.Color.White
        Me.BExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BExit.ForeColor = System.Drawing.Color.Blue
        Me.BExit.Location = New System.Drawing.Point(24, 170)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(75, 30)
        Me.BExit.TabIndex = 7
        Me.BExit.Text = "خروج"
        Me.BExit.UseVisualStyleBackColor = False
        '
        'frmLogin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = My.Resources.Resources.byteStartUp
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 247)
        Me.Controls.Add(Me.BExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BEnter)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbUserName)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Aljazeera", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmLogin2"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmLogin2"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbUserName As ByteClassLibrary.MyTextBox
    Friend WithEvents TbPassword As ByteClassLibrary.MyTextBox
    Friend WithEvents BEnter As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BExit As System.Windows.Forms.Button
End Class
