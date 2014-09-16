<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCustomer))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.areaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.cityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SubarbTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.AddcustBtn = New System.Windows.Forms.Button()
        Me.physicalTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.faxNumTextBox = New System.Windows.Forms.TextBox()
        Me.contactNoTextbox = New System.Windows.Forms.TextBox()
        Me.custIDNumTextBox = New System.Windows.Forms.TextBox()
        Me.custNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DS1 = New milestone2.group4DataSet()
        Me.TACustomer = New milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1237, 36)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add New Customer"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ClearBtn)
        Me.Panel1.Controls.Add(Me.areaCodeTextBox)
        Me.Panel1.Controls.Add(Me.cityTextBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.SubarbTextBox)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CancelBtn)
        Me.Panel1.Controls.Add(Me.AddcustBtn)
        Me.Panel1.Controls.Add(Me.physicalTextBox)
        Me.Panel1.Controls.Add(Me.emailTextBox)
        Me.Panel1.Controls.Add(Me.faxNumTextBox)
        Me.Panel1.Controls.Add(Me.contactNoTextbox)
        Me.Panel1.Controls.Add(Me.custIDNumTextBox)
        Me.Panel1.Controls.Add(Me.custNameTextBox)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(1, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1285, 921)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(959, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 183)
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(375, 20)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Please Enter The Following Customer Details:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(1048, 738)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 16)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "Required Fields"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(1031, 728)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 29)
        Me.Label17.TabIndex = 42
        Me.Label17.Text = "* "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(672, 515)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 29)
        Me.Label16.TabIndex = 41
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(760, 463)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 29)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(760, 424)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 29)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(760, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 29)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(730, 190)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 29)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(730, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 29)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(802, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 29)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "*"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(592, 641)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(162, 73)
        Me.ClearBtn.TabIndex = 34
        Me.ClearBtn.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Clcik to clear fields for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "new input")
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'areaCodeTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.areaCodeTextBox, "Enter area code")
        Me.areaCodeTextBox.Location = New System.Drawing.Point(581, 524)
        Me.areaCodeTextBox.MaxLength = 4
        Me.areaCodeTextBox.Name = "areaCodeTextBox"
        Me.HelpProvider1.SetShowHelp(Me.areaCodeTextBox, True)
        Me.areaCodeTextBox.Size = New System.Drawing.Size(85, 20)
        Me.areaCodeTextBox.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.areaCodeTextBox, "enter area code")
        '
        'cityTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.cityTextBox, "Enter city")
        Me.cityTextBox.Location = New System.Drawing.Point(581, 475)
        Me.cityTextBox.MaxLength = 1000
        Me.cityTextBox.Name = "cityTextBox"
        Me.HelpProvider1.SetShowHelp(Me.cityTextBox, True)
        Me.cityTextBox.Size = New System.Drawing.Size(173, 20)
        Me.cityTextBox.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.cityTextBox, "Enter city")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(329, 479)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "City"
        '
        'SubarbTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.SubarbTextBox, "Enter suburb")
        Me.SubarbTextBox.Location = New System.Drawing.Point(581, 424)
        Me.SubarbTextBox.Name = "SubarbTextBox"
        Me.HelpProvider1.SetShowHelp(Me.SubarbTextBox, True)
        Me.SubarbTextBox.Size = New System.Drawing.Size(173, 20)
        Me.SubarbTextBox.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.SubarbTextBox, "Enter suburb")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(329, 428)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Suburb"
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(845, 641)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(162, 73)
        Me.CancelBtn.TabIndex = 18
        Me.CancelBtn.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.CancelBtn, "Click to go Back to Main Menu")
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'AddcustBtn
        '
        Me.AddcustBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.AddcustBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddcustBtn.Location = New System.Drawing.Point(332, 641)
        Me.AddcustBtn.Name = "AddcustBtn"
        Me.AddcustBtn.Size = New System.Drawing.Size(162, 73)
        Me.AddcustBtn.TabIndex = 17
        Me.AddcustBtn.Text = "Add New Customer"
        Me.ToolTip1.SetToolTip(Me.AddcustBtn, "Click to add the new customer")
        Me.AddcustBtn.UseVisualStyleBackColor = False
        '
        'physicalTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.physicalTextBox, "Enter customer physical address")
        Me.physicalTextBox.Location = New System.Drawing.Point(581, 375)
        Me.physicalTextBox.Name = "physicalTextBox"
        Me.HelpProvider1.SetShowHelp(Me.physicalTextBox, True)
        Me.physicalTextBox.Size = New System.Drawing.Size(173, 20)
        Me.physicalTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.physicalTextBox, "Enter customer physical address")
        '
        'emailTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.emailTextBox, "Enter customer email address")
        Me.emailTextBox.Location = New System.Drawing.Point(581, 312)
        Me.emailTextBox.Name = "emailTextBox"
        Me.HelpProvider1.SetShowHelp(Me.emailTextBox, True)
        Me.emailTextBox.Size = New System.Drawing.Size(215, 20)
        Me.emailTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.emailTextBox, "Enter customer email address")
        '
        'faxNumTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.faxNumTextBox, "Enter customer fax number")
        Me.faxNumTextBox.Location = New System.Drawing.Point(581, 258)
        Me.faxNumTextBox.MaxLength = 10
        Me.faxNumTextBox.Name = "faxNumTextBox"
        Me.HelpProvider1.SetShowHelp(Me.faxNumTextBox, True)
        Me.faxNumTextBox.Size = New System.Drawing.Size(149, 20)
        Me.faxNumTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.faxNumTextBox, "Enter customer fax number")
        '
        'contactNoTextbox
        '
        Me.HelpProvider1.SetHelpString(Me.contactNoTextbox, "Enter contact number")
        Me.contactNoTextbox.Location = New System.Drawing.Point(581, 197)
        Me.contactNoTextbox.MaxLength = 10
        Me.contactNoTextbox.Name = "contactNoTextbox"
        Me.HelpProvider1.SetShowHelp(Me.contactNoTextbox, True)
        Me.contactNoTextbox.Size = New System.Drawing.Size(149, 20)
        Me.contactNoTextbox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.contactNoTextbox, "Enter in customer contact number")
        '
        'custIDNumTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.custIDNumTextBox, "Enter customer ID number")
        Me.custIDNumTextBox.Location = New System.Drawing.Point(581, 145)
        Me.custIDNumTextBox.MaxLength = 13
        Me.custIDNumTextBox.Name = "custIDNumTextBox"
        Me.HelpProvider1.SetShowHelp(Me.custIDNumTextBox, True)
        Me.custIDNumTextBox.Size = New System.Drawing.Size(149, 20)
        Me.custIDNumTextBox.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.custIDNumTextBox, "Enter customer ID number")
        '
        'custNameTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.custNameTextBox, "Enter customer name and surname")
        Me.custNameTextBox.Location = New System.Drawing.Point(581, 92)
        Me.custNameTextBox.Name = "custNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.custNameTextBox, True)
        Me.custNameTextBox.Size = New System.Drawing.Size(215, 20)
        Me.custNameTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.custNameTextBox, "Enter customer name and surname")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(329, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Area Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(329, 379)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Physical Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(329, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 262)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fax Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(329, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer ID Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(329, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name and Surname:"
        '
        'DS1
        '
        Me.DS1.DataSetName = "group4DataSet"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TACustomer
        '
        Me.TACustomer.ClearBeforeFill = True
        '
        'AddCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 940)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "AddCustomer"
        Me.Text = "Add New Customer "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents AddcustBtn As System.Windows.Forms.Button
    Friend WithEvents physicalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents faxNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents contactNoTextbox As System.Windows.Forms.TextBox
    Friend WithEvents custIDNumTextBox As System.Windows.Forms.TextBox
    Friend WithEvents custNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SubarbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents areaCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DS1 As milestone2.group4DataSet
    Friend WithEvents TACustomer As milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
