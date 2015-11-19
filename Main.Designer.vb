<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.gbTo43 = New System.Windows.Forms.GroupBox()
        Me.tbResultTo43 = New System.Windows.Forms.TextBox()
        Me.lbResultTo43 = New System.Windows.Forms.Label()
        Me.btConvTo43 = New System.Windows.Forms.Button()
        Me.lbHeightTo43 = New System.Windows.Forms.Label()
        Me.lbWidthTo43 = New System.Windows.Forms.Label()
        Me.tbHeightTo43 = New System.Windows.Forms.TextBox()
        Me.tbWidthTo43 = New System.Windows.Forms.TextBox()
        Me.radWidth = New System.Windows.Forms.RadioButton()
        Me.radHeight = New System.Windows.Forms.RadioButton()
        Me.lbConstant = New System.Windows.Forms.Label()
        Me.btClear = New System.Windows.Forms.Button()
        Me.tbResultTo169 = New System.Windows.Forms.TextBox()
        Me.lbResultTo169 = New System.Windows.Forms.Label()
        Me.lbHeightTo169 = New System.Windows.Forms.Label()
        Me.lbWidthTo169 = New System.Windows.Forms.Label()
        Me.tbHeightTo169 = New System.Windows.Forms.TextBox()
        Me.tbWidthTo169 = New System.Windows.Forms.TextBox()
        Me.gbTo169 = New System.Windows.Forms.GroupBox()
        Me.btConvTo169 = New System.Windows.Forms.Button()
        Me.lbVersion = New System.Windows.Forms.Label()
        Me.gbTo43.SuspendLayout()
        Me.gbTo169.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(148, 5)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(121, 15)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Resolution Converter"
        '
        'gbTo43
        '
        Me.gbTo43.Controls.Add(Me.tbResultTo43)
        Me.gbTo43.Controls.Add(Me.lbResultTo43)
        Me.gbTo43.Controls.Add(Me.btConvTo43)
        Me.gbTo43.Controls.Add(Me.lbHeightTo43)
        Me.gbTo43.Controls.Add(Me.lbWidthTo43)
        Me.gbTo43.Controls.Add(Me.tbHeightTo43)
        Me.gbTo43.Controls.Add(Me.tbWidthTo43)
        Me.gbTo43.Location = New System.Drawing.Point(9, 25)
        Me.gbTo43.Name = "gbTo43"
        Me.gbTo43.Size = New System.Drawing.Size(196, 115)
        Me.gbTo43.TabIndex = 1
        Me.gbTo43.TabStop = False
        Me.gbTo43.Text = "Convert to 4:3"
        '
        'tbResultTo43
        '
        Me.tbResultTo43.Location = New System.Drawing.Point(50, 88)
        Me.tbResultTo43.Name = "tbResultTo43"
        Me.tbResultTo43.ReadOnly = True
        Me.tbResultTo43.Size = New System.Drawing.Size(140, 20)
        Me.tbResultTo43.TabIndex = 8
        '
        'lbResultTo43
        '
        Me.lbResultTo43.AutoSize = True
        Me.lbResultTo43.Location = New System.Drawing.Point(7, 91)
        Me.lbResultTo43.Name = "lbResultTo43"
        Me.lbResultTo43.Size = New System.Drawing.Size(40, 13)
        Me.lbResultTo43.TabIndex = 7
        Me.lbResultTo43.Text = "Result:"
        '
        'btConvTo43
        '
        Me.btConvTo43.Location = New System.Drawing.Point(9, 62)
        Me.btConvTo43.Name = "btConvTo43"
        Me.btConvTo43.Size = New System.Drawing.Size(181, 23)
        Me.btConvTo43.TabIndex = 6
        Me.btConvTo43.Text = "Convert Resolution To 4:3"
        Me.btConvTo43.UseVisualStyleBackColor = True
        '
        'lbHeightTo43
        '
        Me.lbHeightTo43.AutoSize = True
        Me.lbHeightTo43.Location = New System.Drawing.Point(6, 42)
        Me.lbHeightTo43.Name = "lbHeightTo43"
        Me.lbHeightTo43.Size = New System.Drawing.Size(41, 13)
        Me.lbHeightTo43.TabIndex = 5
        Me.lbHeightTo43.Text = "Height:"
        '
        'lbWidthTo43
        '
        Me.lbWidthTo43.AutoSize = True
        Me.lbWidthTo43.Location = New System.Drawing.Point(6, 16)
        Me.lbWidthTo43.Name = "lbWidthTo43"
        Me.lbWidthTo43.Size = New System.Drawing.Size(38, 13)
        Me.lbWidthTo43.TabIndex = 4
        Me.lbWidthTo43.Text = "Width:"
        '
        'tbHeightTo43
        '
        Me.tbHeightTo43.Location = New System.Drawing.Point(50, 39)
        Me.tbHeightTo43.Name = "tbHeightTo43"
        Me.tbHeightTo43.Size = New System.Drawing.Size(140, 20)
        Me.tbHeightTo43.TabIndex = 3
        '
        'tbWidthTo43
        '
        Me.tbWidthTo43.Location = New System.Drawing.Point(50, 13)
        Me.tbWidthTo43.Name = "tbWidthTo43"
        Me.tbWidthTo43.Size = New System.Drawing.Size(140, 20)
        Me.tbWidthTo43.TabIndex = 2
        '
        'radWidth
        '
        Me.radWidth.AutoSize = True
        Me.radWidth.Location = New System.Drawing.Point(191, 170)
        Me.radWidth.Name = "radWidth"
        Me.radWidth.Size = New System.Drawing.Size(126, 17)
        Me.radWidth.TabIndex = 2
        Me.radWidth.Text = "Keep Width Constant"
        Me.radWidth.UseVisualStyleBackColor = True
        '
        'radHeight
        '
        Me.radHeight.AutoSize = True
        Me.radHeight.Checked = True
        Me.radHeight.Location = New System.Drawing.Point(191, 185)
        Me.radHeight.Name = "radHeight"
        Me.radHeight.Size = New System.Drawing.Size(129, 17)
        Me.radHeight.TabIndex = 3
        Me.radHeight.TabStop = True
        Me.radHeight.Text = "Keep Height Constant"
        Me.radHeight.UseVisualStyleBackColor = True
        '
        'lbConstant
        '
        Me.lbConstant.AutoSize = True
        Me.lbConstant.Location = New System.Drawing.Point(117, 172)
        Me.lbConstant.Name = "lbConstant"
        Me.lbConstant.Size = New System.Drawing.Size(74, 13)
        Me.lbConstant.TabIndex = 4
        Me.lbConstant.Text = "Constant Axis:"
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(169, 145)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(75, 23)
        Me.btClear.TabIndex = 5
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'tbResultTo169
        '
        Me.tbResultTo169.Location = New System.Drawing.Point(50, 88)
        Me.tbResultTo169.Name = "tbResultTo169"
        Me.tbResultTo169.ReadOnly = True
        Me.tbResultTo169.Size = New System.Drawing.Size(140, 20)
        Me.tbResultTo169.TabIndex = 8
        '
        'lbResultTo169
        '
        Me.lbResultTo169.AutoSize = True
        Me.lbResultTo169.Location = New System.Drawing.Point(7, 91)
        Me.lbResultTo169.Name = "lbResultTo169"
        Me.lbResultTo169.Size = New System.Drawing.Size(40, 13)
        Me.lbResultTo169.TabIndex = 7
        Me.lbResultTo169.Text = "Result:"
        '
        'lbHeightTo169
        '
        Me.lbHeightTo169.AutoSize = True
        Me.lbHeightTo169.Location = New System.Drawing.Point(6, 42)
        Me.lbHeightTo169.Name = "lbHeightTo169"
        Me.lbHeightTo169.Size = New System.Drawing.Size(41, 13)
        Me.lbHeightTo169.TabIndex = 5
        Me.lbHeightTo169.Text = "Height:"
        '
        'lbWidthTo169
        '
        Me.lbWidthTo169.AutoSize = True
        Me.lbWidthTo169.Location = New System.Drawing.Point(6, 16)
        Me.lbWidthTo169.Name = "lbWidthTo169"
        Me.lbWidthTo169.Size = New System.Drawing.Size(38, 13)
        Me.lbWidthTo169.TabIndex = 4
        Me.lbWidthTo169.Text = "Width:"
        '
        'tbHeightTo169
        '
        Me.tbHeightTo169.Location = New System.Drawing.Point(50, 39)
        Me.tbHeightTo169.Name = "tbHeightTo169"
        Me.tbHeightTo169.Size = New System.Drawing.Size(140, 20)
        Me.tbHeightTo169.TabIndex = 3
        '
        'tbWidthTo169
        '
        Me.tbWidthTo169.Location = New System.Drawing.Point(50, 13)
        Me.tbWidthTo169.Name = "tbWidthTo169"
        Me.tbWidthTo169.Size = New System.Drawing.Size(140, 20)
        Me.tbWidthTo169.TabIndex = 2
        '
        'gbTo169
        '
        Me.gbTo169.Controls.Add(Me.tbResultTo169)
        Me.gbTo169.Controls.Add(Me.lbResultTo169)
        Me.gbTo169.Controls.Add(Me.btConvTo169)
        Me.gbTo169.Controls.Add(Me.lbHeightTo169)
        Me.gbTo169.Controls.Add(Me.lbWidthTo169)
        Me.gbTo169.Controls.Add(Me.tbHeightTo169)
        Me.gbTo169.Controls.Add(Me.tbWidthTo169)
        Me.gbTo169.Location = New System.Drawing.Point(211, 25)
        Me.gbTo169.Name = "gbTo169"
        Me.gbTo169.Size = New System.Drawing.Size(196, 115)
        Me.gbTo169.TabIndex = 6
        Me.gbTo169.TabStop = False
        Me.gbTo169.Text = "Convert to 16:9"
        '
        'btConvTo169
        '
        Me.btConvTo169.Location = New System.Drawing.Point(9, 62)
        Me.btConvTo169.Name = "btConvTo169"
        Me.btConvTo169.Size = New System.Drawing.Size(181, 23)
        Me.btConvTo169.TabIndex = 6
        Me.btConvTo169.Text = "Convert Resolution To 16:9"
        Me.btConvTo169.UseVisualStyleBackColor = True
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Location = New System.Drawing.Point(376, 3)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(38, 13)
        Me.lbVersion.TabIndex = 7
        Me.lbVersion.Text = "V1.0.0"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 206)
        Me.Controls.Add(Me.lbVersion)
        Me.Controls.Add(Me.gbTo169)
        Me.Controls.Add(Me.btClear)
        Me.Controls.Add(Me.lbConstant)
        Me.Controls.Add(Me.radHeight)
        Me.Controls.Add(Me.radWidth)
        Me.Controls.Add(Me.gbTo43)
        Me.Controls.Add(Me.lbTitle)
        Me.MinimumSize = New System.Drawing.Size(433, 245)
        Me.Name = "Main"
        Me.Text = "Resolution Converter"
        Me.gbTo43.ResumeLayout(False)
        Me.gbTo43.PerformLayout()
        Me.gbTo169.ResumeLayout(False)
        Me.gbTo169.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbTitle As System.Windows.Forms.Label
    Friend WithEvents gbTo43 As System.Windows.Forms.GroupBox
    Friend WithEvents tbResultTo43 As System.Windows.Forms.TextBox
    Friend WithEvents lbResultTo43 As System.Windows.Forms.Label
    Friend WithEvents btConvTo43 As System.Windows.Forms.Button
    Friend WithEvents lbHeightTo43 As System.Windows.Forms.Label
    Friend WithEvents lbWidthTo43 As System.Windows.Forms.Label
    Friend WithEvents tbHeightTo43 As System.Windows.Forms.TextBox
    Friend WithEvents tbWidthTo43 As System.Windows.Forms.TextBox
    Friend WithEvents radWidth As System.Windows.Forms.RadioButton
    Friend WithEvents radHeight As System.Windows.Forms.RadioButton
    Friend WithEvents lbConstant As System.Windows.Forms.Label
    Friend WithEvents btClear As System.Windows.Forms.Button
    Friend WithEvents tbResultTo169 As System.Windows.Forms.TextBox
    Friend WithEvents lbResultTo169 As System.Windows.Forms.Label
    Friend WithEvents lbHeightTo169 As System.Windows.Forms.Label
    Friend WithEvents lbWidthTo169 As System.Windows.Forms.Label
    Friend WithEvents tbHeightTo169 As System.Windows.Forms.TextBox
    Friend WithEvents tbWidthTo169 As System.Windows.Forms.TextBox
    Friend WithEvents gbTo169 As System.Windows.Forms.GroupBox
    Friend WithEvents btConvTo169 As System.Windows.Forms.Button
    Friend WithEvents lbVersion As System.Windows.Forms.Label

End Class
