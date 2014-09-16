<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.OldPassword = New System.Windows.Forms.Label()
        Me.NewPassword = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.Label()
        Me.OldPwdTextBox = New System.Windows.Forms.TextBox()
        Me.NewPwdTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPwdTextBox = New System.Windows.Forms.TextBox()
        Me.ChangePwdButton = New System.Windows.Forms.Button()
        Me.CancelPwdChangeButton = New System.Windows.Forms.Button()
        Me.ChangePwdDS = New milestone2.group4DataSet()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.ChangePwdDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OldPassword
        '
        Me.OldPassword.AutoSize = True
        Me.OldPassword.BackColor = System.Drawing.Color.Transparent
        Me.OldPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OldPassword.Location = New System.Drawing.Point(29, 47)
        Me.OldPassword.Name = "OldPassword"
        Me.OldPassword.Size = New System.Drawing.Size(114, 18)
        Me.OldPassword.TabIndex = 0
        Me.OldPassword.Text = "Old Password"
        '
        'NewPassword
        '
        Me.NewPassword.AutoSize = True
        Me.NewPassword.BackColor = System.Drawing.Color.Transparent
        Me.NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.Location = New System.Drawing.Point(29, 97)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(121, 18)
        Me.NewPassword.TabIndex = 0
        Me.NewPassword.Text = "New Password"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.AutoSize = True
        Me.ConfirmPassword.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(29, 151)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.Size = New System.Drawing.Size(148, 18)
        Me.ConfirmPassword.TabIndex = 0
        Me.ConfirmPassword.Text = "Confirm Password"
        '
        'OldPwdTextBox
        '
        Me.OldPwdTextBox.Location = New System.Drawing.Point(244, 47)
        Me.OldPwdTextBox.Name = "OldPwdTextBox"
        Me.OldPwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OldPwdTextBox.Size = New System.Drawing.Size(193, 24)
        Me.OldPwdTextBox.TabIndex = 1
        '
        'NewPwdTextBox
        '
        Me.NewPwdTextBox.Location = New System.Drawing.Point(244, 97)
        Me.NewPwdTextBox.Name = "NewPwdTextBox"
        Me.NewPwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPwdTextBox.Size = New System.Drawing.Size(193, 24)
        Me.NewPwdTextBox.TabIndex = 2
        '
        'ConfirmPwdTextBox
        '
        Me.ConfirmPwdTextBox.Location = New System.Drawing.Point(244, 151)
        Me.ConfirmPwdTextBox.Name = "ConfirmPwdTextBox"
        Me.ConfirmPwdTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPwdTextBox.Size = New System.Drawing.Size(193, 24)
        Me.ConfirmPwdTextBox.TabIndex = 3
        '
        'ChangePwdButton
        '
        Me.HelpProvider1.SetHelpString(Me.ChangePwdButton, "Click to change password")
        Me.ChangePwdButton.Location = New System.Drawing.Point(120, 242)
        Me.ChangePwdButton.Name = "ChangePwdButton"
        Me.HelpProvider1.SetShowHelp(Me.ChangePwdButton, True)
        Me.ChangePwdButton.Size = New System.Drawing.Size(97, 27)
        Me.ChangePwdButton.TabIndex = 4
        Me.ChangePwdButton.Text = "OK"
        Me.ToolTip1.SetToolTip(Me.ChangePwdButton, "Click to change password")
        Me.ChangePwdButton.UseVisualStyleBackColor = True
        '
        'CancelPwdChangeButton
        '
        Me.HelpProvider1.SetHelpString(Me.CancelPwdChangeButton, "Click to cancel password change")
        Me.CancelPwdChangeButton.Location = New System.Drawing.Point(294, 240)
        Me.CancelPwdChangeButton.Name = "CancelPwdChangeButton"
        Me.HelpProvider1.SetShowHelp(Me.CancelPwdChangeButton, True)
        Me.CancelPwdChangeButton.Size = New System.Drawing.Size(91, 29)
        Me.CancelPwdChangeButton.TabIndex = 5
        Me.CancelPwdChangeButton.Text = "Cancel"
        Me.ToolTip1.SetToolTip(Me.CancelPwdChangeButton, "Click to cancel password change")
        Me.CancelPwdChangeButton.UseVisualStyleBackColor = True
        '
        'ChangePwdDS
        '
        Me.ChangePwdDS.DataSetName = "group4DataSet"
        Me.ChangePwdDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.OldPassword)
        Me.GroupBox1.Controls.Add(Me.CancelPwdChangeButton)
        Me.GroupBox1.Controls.Add(Me.NewPassword)
        Me.GroupBox1.Controls.Add(Me.ChangePwdButton)
        Me.GroupBox1.Controls.Add(Me.ConfirmPassword)
        Me.GroupBox1.Controls.Add(Me.ConfirmPwdTextBox)
        Me.GroupBox1.Controls.Add(Me.OldPwdTextBox)
        Me.GroupBox1.Controls.Add(Me.NewPwdTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(378, 277)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(509, 355)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Change Password"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1246, 880)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ChangePassword"
        Me.Text = "Change Password"
        CType(Me.ChangePwdDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OldPassword As System.Windows.Forms.Label
    Friend WithEvents NewPassword As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.Label
    Friend WithEvents OldPwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NewPwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmPwdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ChangePwdButton As System.Windows.Forms.Button
    Friend WithEvents CancelPwdChangeButton As System.Windows.Forms.Button
    Friend WithEvents ChangePwdDS As milestone2.group4DataSet
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
