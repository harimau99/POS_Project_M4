<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Email))
        Me.TbToCustomer = New System.Windows.Forms.TextBox()
        Me.BSCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.Group4DataSet1 = New milestone2.group4DataSet()
        Me.LblTo = New System.Windows.Forms.Label()
        Me.TbSubject = New System.Windows.Forms.TextBox()
        Me.LblSubject = New System.Windows.Forms.Label()
        Me.LblMessageBody = New System.Windows.Forms.Label()
        Me.TbBody = New System.Windows.Forms.TextBox()
        Me.BtnAttach = New System.Windows.Forms.Button()
        Me.LblAttach = New System.Windows.Forms.Label()
        Me.ListBoxAttach = New System.Windows.Forms.ListBox()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CustomerCombo = New System.Windows.Forms.ComboBox()
        Me.TACustomer = New milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter()
        Me.TASupplier = New milestone2.group4DataSetTableAdapters.SupplierTableAdapter()
        Me.BSSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.SupplierCombo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbToSupplier = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbToCustomer
        '
        Me.TbToCustomer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Email_Address", True))
        Me.TbToCustomer.Location = New System.Drawing.Point(170, 229)
        Me.TbToCustomer.Name = "TbToCustomer"
        Me.TbToCustomer.Size = New System.Drawing.Size(344, 20)
        Me.TbToCustomer.TabIndex = 21
        Me.TbToCustomer.Visible = False
        '
        'BSCustomer
        '
        Me.BSCustomer.DataMember = "CustomerTb"
        Me.BSCustomer.DataSource = Me.Group4DataSet1
        '
        'Group4DataSet1
        '
        Me.Group4DataSet1.DataSetName = "group4DataSet"
        Me.Group4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblTo
        '
        Me.LblTo.AutoSize = True
        Me.LblTo.BackColor = System.Drawing.Color.Transparent
        Me.LblTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTo.Location = New System.Drawing.Point(13, 186)
        Me.LblTo.Name = "LblTo"
        Me.LblTo.Size = New System.Drawing.Size(99, 18)
        Me.LblTo.TabIndex = 20
        Me.LblTo.Text = "To Address:"
        '
        'TbSubject
        '
        Me.TbSubject.Location = New System.Drawing.Point(170, 347)
        Me.TbSubject.Name = "TbSubject"
        Me.TbSubject.Size = New System.Drawing.Size(344, 20)
        Me.TbSubject.TabIndex = 19
        '
        'LblSubject
        '
        Me.LblSubject.AutoSize = True
        Me.LblSubject.BackColor = System.Drawing.Color.Transparent
        Me.LblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubject.Location = New System.Drawing.Point(78, 346)
        Me.LblSubject.Name = "LblSubject"
        Me.LblSubject.Size = New System.Drawing.Size(64, 18)
        Me.LblSubject.TabIndex = 18
        Me.LblSubject.Text = "Subject"
        '
        'LblMessageBody
        '
        Me.LblMessageBody.AutoSize = True
        Me.LblMessageBody.BackColor = System.Drawing.Color.Transparent
        Me.LblMessageBody.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMessageBody.Location = New System.Drawing.Point(78, 414)
        Me.LblMessageBody.Name = "LblMessageBody"
        Me.LblMessageBody.Size = New System.Drawing.Size(76, 18)
        Me.LblMessageBody.TabIndex = 17
        Me.LblMessageBody.Text = "Message"
        '
        'TbBody
        '
        Me.TbBody.Location = New System.Drawing.Point(170, 414)
        Me.TbBody.Multiline = True
        Me.TbBody.Name = "TbBody"
        Me.TbBody.Size = New System.Drawing.Size(746, 243)
        Me.TbBody.TabIndex = 16
        '
        'BtnAttach
        '
        Me.BtnAttach.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.BtnAttach, "Click to add an attachment")
        Me.BtnAttach.Location = New System.Drawing.Point(408, 748)
        Me.BtnAttach.Name = "BtnAttach"
        Me.HelpProvider1.SetShowHelp(Me.BtnAttach, True)
        Me.BtnAttach.Size = New System.Drawing.Size(155, 43)
        Me.BtnAttach.TabIndex = 15
        Me.BtnAttach.Text = "Add Attachments"
        Me.ToolTip1.SetToolTip(Me.BtnAttach, "Click to add an attachment")
        Me.BtnAttach.UseVisualStyleBackColor = False
        '
        'LblAttach
        '
        Me.LblAttach.AutoSize = True
        Me.LblAttach.BackColor = System.Drawing.Color.Transparent
        Me.LblAttach.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAttach.Location = New System.Drawing.Point(29, 673)
        Me.LblAttach.Name = "LblAttach"
        Me.LblAttach.Size = New System.Drawing.Size(101, 18)
        Me.LblAttach.TabIndex = 14
        Me.LblAttach.Text = "Attachments"
        '
        'ListBoxAttach
        '
        Me.ListBoxAttach.FormattingEnabled = True
        Me.ListBoxAttach.Location = New System.Drawing.Point(32, 698)
        Me.ListBoxAttach.Name = "ListBoxAttach"
        Me.ListBoxAttach.Size = New System.Drawing.Size(344, 160)
        Me.ListBoxAttach.TabIndex = 13
        '
        'BtnSend
        '
        Me.BtnSend.BackColor = System.Drawing.Color.AliceBlue
        Me.BtnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.BtnSend, "Click to send email")
        Me.BtnSend.Location = New System.Drawing.Point(717, 748)
        Me.BtnSend.Name = "BtnSend"
        Me.HelpProvider1.SetShowHelp(Me.BtnSend, True)
        Me.BtnSend.Size = New System.Drawing.Size(155, 44)
        Me.BtnSend.TabIndex = 12
        Me.BtnSend.Text = "Send Email"
        Me.ToolTip1.SetToolTip(Me.BtnSend, "Click to send email")
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(979, 296)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 172)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Select Email Recipient Type:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.RadioButton1, "Select to choose a customer")
        Me.RadioButton1.Location = New System.Drawing.Point(363, 68)
        Me.RadioButton1.Name = "RadioButton1"
        Me.HelpProvider1.SetShowHelp(Me.RadioButton1, True)
        Me.RadioButton1.Size = New System.Drawing.Size(100, 22)
        Me.RadioButton1.TabIndex = 26
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Customer"
        Me.ToolTip1.SetToolTip(Me.RadioButton1, "Select to choose a customer to email")
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.RadioButton2, "Select to choose a a supplier to email")
        Me.RadioButton2.Location = New System.Drawing.Point(363, 113)
        Me.RadioButton2.Name = "RadioButton2"
        Me.HelpProvider1.SetShowHelp(Me.RadioButton2, True)
        Me.RadioButton2.Size = New System.Drawing.Size(87, 22)
        Me.RadioButton2.TabIndex = 27
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Supplier"
        Me.ToolTip1.SetToolTip(Me.RadioButton2, "Select to choose a supplier to email")
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'CustomerCombo
        '
        Me.CustomerCombo.DataSource = Me.BSCustomer
        Me.CustomerCombo.DisplayMember = "Cust_Name"
        Me.CustomerCombo.FormattingEnabled = True
        Me.CustomerCombo.Location = New System.Drawing.Point(517, 69)
        Me.CustomerCombo.Name = "CustomerCombo"
        Me.CustomerCombo.Size = New System.Drawing.Size(230, 21)
        Me.CustomerCombo.TabIndex = 28
        Me.CustomerCombo.Visible = False
        '
        'TACustomer
        '
        Me.TACustomer.ClearBeforeFill = True
        '
        'TASupplier
        '
        Me.TASupplier.ClearBeforeFill = True
        '
        'BSSupplier
        '
        Me.BSSupplier.DataMember = "Supplier"
        Me.BSSupplier.DataSource = Me.Group4DataSet1
        '
        'SupplierCombo
        '
        Me.SupplierCombo.DataSource = Me.BSSupplier
        Me.SupplierCombo.DisplayMember = "Supplier_Name"
        Me.SupplierCombo.FormattingEnabled = True
        Me.SupplierCombo.Location = New System.Drawing.Point(517, 116)
        Me.SupplierCombo.Name = "SupplierCombo"
        Me.SupplierCombo.Size = New System.Drawing.Size(230, 21)
        Me.SupplierCombo.TabIndex = 29
        Me.SupplierCombo.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Customer:"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Supplier:"
        Me.Label3.Visible = False
        '
        'TbToSupplier
        '
        Me.TbToSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSSupplier, "Supplier_Email", True))
        Me.TbToSupplier.Location = New System.Drawing.Point(170, 278)
        Me.TbToSupplier.Name = "TbToSupplier"
        Me.TbToSupplier.Size = New System.Drawing.Size(344, 20)
        Me.TbToSupplier.TabIndex = 32
        Me.TbToSupplier.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-3, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1240, 39)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Email"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button2, "Click to go back to main menu")
        Me.Button2.Location = New System.Drawing.Point(1022, 749)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(169, 43)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.Button2, "Click to go back to main menu")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbToSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SupplierCombo)
        Me.Controls.Add(Me.CustomerCombo)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TbToCustomer)
        Me.Controls.Add(Me.LblTo)
        Me.Controls.Add(Me.TbSubject)
        Me.Controls.Add(Me.LblSubject)
        Me.Controls.Add(Me.LblMessageBody)
        Me.Controls.Add(Me.TbBody)
        Me.Controls.Add(Me.BtnAttach)
        Me.Controls.Add(Me.LblAttach)
        Me.Controls.Add(Me.ListBoxAttach)
        Me.Controls.Add(Me.BtnSend)
        Me.Name = "Email"
        Me.Text = "Email"
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TbToCustomer As System.Windows.Forms.TextBox
    Friend WithEvents LblTo As System.Windows.Forms.Label
    Friend WithEvents TbSubject As System.Windows.Forms.TextBox
    Friend WithEvents LblSubject As System.Windows.Forms.Label
    Friend WithEvents LblMessageBody As System.Windows.Forms.Label
    Friend WithEvents TbBody As System.Windows.Forms.TextBox
    Friend WithEvents BtnAttach As System.Windows.Forms.Button
    Friend WithEvents LblAttach As System.Windows.Forms.Label
    Friend WithEvents ListBoxAttach As System.Windows.Forms.ListBox
    Friend WithEvents BtnSend As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents CustomerCombo As System.Windows.Forms.ComboBox
    Friend WithEvents BSCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents Group4DataSet1 As milestone2.group4DataSet
    Friend WithEvents TACustomer As milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter
    Friend WithEvents TASupplier As milestone2.group4DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents BSSupplier As System.Windows.Forms.BindingSource
    Friend WithEvents SupplierCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TbToSupplier As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
