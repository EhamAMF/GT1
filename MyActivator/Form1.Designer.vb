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
        Me.numAppID = New ByteClassLibrary.MyNumericBox()
        Me.cboIsServer = New System.Windows.Forms.ComboBox()
        Me.NumFeaturea = New ByteClassLibrary.MyNumericBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'numAppID
        '
        Me.numAppID.Location = New System.Drawing.Point(89, 13)
        Me.numAppID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.numAppID.Name = "numAppID"
        Me.numAppID.Size = New System.Drawing.Size(148, 27)
        Me.numAppID.TabIndex = 0
        Me.numAppID.Text = "1"
        '
        'cboIsServer
        '
        Me.cboIsServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIsServer.FormattingEnabled = True
        Me.cboIsServer.Items.AddRange(New Object() {"True", "False"})
        Me.cboIsServer.Location = New System.Drawing.Point(89, 82)
        Me.cboIsServer.Name = "cboIsServer"
        Me.cboIsServer.Size = New System.Drawing.Size(148, 27)
        Me.cboIsServer.TabIndex = 1
        '
        'NumFeaturea
        '
        Me.NumFeaturea.Location = New System.Drawing.Point(89, 48)
        Me.NumFeaturea.Margin = New System.Windows.Forms.Padding(4)
        Me.NumFeaturea.Name = "NumFeaturea"
        Me.NumFeaturea.Size = New System.Drawing.Size(148, 27)
        Me.NumFeaturea.TabIndex = 2
        Me.NumFeaturea.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "AppID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Features"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "IsServer"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(162, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(341, 248)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumFeaturea)
        Me.Controls.Add(Me.cboIsServer)
        Me.Controls.Add(Me.numAppID)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents numAppID As ByteClassLibrary.MyNumericBox
    Friend WithEvents cboIsServer As System.Windows.Forms.ComboBox
    Friend WithEvents NumFeaturea As ByteClassLibrary.MyNumericBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
