<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchCustEditTxtBx = New System.Windows.Forms.TextBox()
        Me.SearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaxNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS1 = New milestone2.group4DataSet()
        Me.AreaCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SubarbTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.UpdateCustBtn = New System.Windows.Forms.Button()
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
        Me.TACustomer = New milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.SearchCustEditTxtBx)
        Me.Panel1.Controls.Add(Me.SearchDataGridView)
        Me.Panel1.Controls.Add(Me.AreaCodeTextBox)
        Me.Panel1.Controls.Add(Me.CityTextBox)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.SubarbTextBox)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CancelBtn)
        Me.Panel1.Controls.Add(Me.UpdateCustBtn)
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
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1296, 958)
        Me.Panel1.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(64, 366)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(430, 20)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Please Enter Customer Details You Wish To Update:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(1093, 812)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 16)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Required Fields"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(1073, 806)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 29)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(1154, 472)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 29)
        Me.Label19.TabIndex = 47
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(1154, 421)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(24, 29)
        Me.Label18.TabIndex = 46
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(365, 725)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(24, 29)
        Me.Label17.TabIndex = 45
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(469, 674)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 29)
        Me.Label16.TabIndex = 44
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(469, 622)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 29)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(469, 572)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 29)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(469, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 29)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "*"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(-2, -2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1235, 36)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Update Customer"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Search By Customer Name"
        '
        'SearchCustEditTxtBx
        '
        Me.HelpProvider1.SetHelpString(Me.SearchCustEditTxtBx, "Enter a customer name to search for")
        Me.SearchCustEditTxtBx.Location = New System.Drawing.Point(328, 40)
        Me.SearchCustEditTxtBx.Name = "SearchCustEditTxtBx"
        Me.HelpProvider1.SetShowHelp(Me.SearchCustEditTxtBx, True)
        Me.SearchCustEditTxtBx.Size = New System.Drawing.Size(196, 20)
        Me.SearchCustEditTxtBx.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.SearchCustEditTxtBx, "Enter customer name to search for")
        '
        'SearchDataGridView
        '
        Me.SearchDataGridView.AutoGenerateColumns = False
        Me.SearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.CustIDNumberDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.FaxNumberDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.PhysicalAddressDataGridViewTextBoxColumn, Me.SuburbDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.AreaCodeDataGridViewTextBoxColumn})
        Me.SearchDataGridView.DataSource = Me.BSCustomer
        Me.SearchDataGridView.Location = New System.Drawing.Point(66, 94)
        Me.SearchDataGridView.Name = "SearchDataGridView"
        Me.SearchDataGridView.Size = New System.Drawing.Size(1082, 243)
        Me.SearchDataGridView.TabIndex = 34
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        Me.CustIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CustIDDataGridViewTextBoxColumn.Width = 70
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Name"
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "Cust_Name"
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
        Me.CustNameDataGridViewTextBoxColumn.Width = 120
        '
        'CustIDNumberDataGridViewTextBoxColumn
        '
        Me.CustIDNumberDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID_Number"
        Me.CustIDNumberDataGridViewTextBoxColumn.HeaderText = "Cust_ID_Number"
        Me.CustIDNumberDataGridViewTextBoxColumn.Name = "CustIDNumberDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Contact_Number"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'FaxNumberDataGridViewTextBoxColumn
        '
        Me.FaxNumberDataGridViewTextBoxColumn.DataPropertyName = "Fax_Number"
        Me.FaxNumberDataGridViewTextBoxColumn.HeaderText = "Fax_Number"
        Me.FaxNumberDataGridViewTextBoxColumn.Name = "FaxNumberDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "Email_Address"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "Email_Address"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        Me.EmailAddressDataGridViewTextBoxColumn.Width = 120
        '
        'PhysicalAddressDataGridViewTextBoxColumn
        '
        Me.PhysicalAddressDataGridViewTextBoxColumn.DataPropertyName = "Physical_Address"
        Me.PhysicalAddressDataGridViewTextBoxColumn.HeaderText = "Physical_Address"
        Me.PhysicalAddressDataGridViewTextBoxColumn.Name = "PhysicalAddressDataGridViewTextBoxColumn"
        Me.PhysicalAddressDataGridViewTextBoxColumn.Width = 120
        '
        'SuburbDataGridViewTextBoxColumn
        '
        Me.SuburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.Name = "SuburbDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'AreaCodeDataGridViewTextBoxColumn
        '
        Me.AreaCodeDataGridViewTextBoxColumn.DataPropertyName = "Area_Code"
        Me.AreaCodeDataGridViewTextBoxColumn.HeaderText = "Area_Code"
        Me.AreaCodeDataGridViewTextBoxColumn.Name = "AreaCodeDataGridViewTextBoxColumn"
        '
        'BSCustomer
        '
        Me.BSCustomer.DataMember = "CustomerTb"
        Me.BSCustomer.DataSource = Me.DS1
        '
        'DS1
        '
        Me.DS1.DataSetName = "group4DataSet"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AreaCodeTextBox
        '
        Me.AreaCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Area_Code", True))
        Me.HelpProvider1.SetHelpString(Me.AreaCodeTextBox, "Edit area code")
        Me.AreaCodeTextBox.Location = New System.Drawing.Point(290, 734)
        Me.AreaCodeTextBox.MaxLength = 4
        Me.AreaCodeTextBox.Name = "AreaCodeTextBox"
        Me.HelpProvider1.SetShowHelp(Me.AreaCodeTextBox, True)
        Me.AreaCodeTextBox.Size = New System.Drawing.Size(79, 20)
        Me.AreaCodeTextBox.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.AreaCodeTextBox, "Enter area code to update")
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "City", True))
        Me.HelpProvider1.SetHelpString(Me.CityTextBox, "Edit city")
        Me.CityTextBox.Location = New System.Drawing.Point(290, 683)
        Me.CityTextBox.Name = "CityTextBox"
        Me.HelpProvider1.SetShowHelp(Me.CityTextBox, True)
        Me.CityTextBox.Size = New System.Drawing.Size(173, 20)
        Me.CityTextBox.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.CityTextBox, "Enter city to update")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(68, 685)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "City:"
        '
        'SubarbTextBox
        '
        Me.SubarbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Suburb", True))
        Me.HelpProvider1.SetHelpString(Me.SubarbTextBox, "Edit suburb")
        Me.SubarbTextBox.Location = New System.Drawing.Point(290, 631)
        Me.SubarbTextBox.Name = "SubarbTextBox"
        Me.HelpProvider1.SetShowHelp(Me.SubarbTextBox, True)
        Me.SubarbTextBox.Size = New System.Drawing.Size(173, 20)
        Me.SubarbTextBox.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.SubarbTextBox, "Enter suburb to update")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 633)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 18)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Suburb:"
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.CancelBtn, "Click to go back to main menu")
        Me.CancelBtn.Location = New System.Drawing.Point(794, 771)
        Me.CancelBtn.Name = "CancelBtn"
        Me.HelpProvider1.SetShowHelp(Me.CancelBtn, True)
        Me.CancelBtn.Size = New System.Drawing.Size(154, 74)
        Me.CancelBtn.TabIndex = 18
        Me.CancelBtn.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.CancelBtn, "Click to go back to  main menu")
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'UpdateCustBtn
        '
        Me.UpdateCustBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.UpdateCustBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.UpdateCustBtn, "Click to update customer details")
        Me.UpdateCustBtn.Location = New System.Drawing.Point(474, 771)
        Me.UpdateCustBtn.Name = "UpdateCustBtn"
        Me.HelpProvider1.SetShowHelp(Me.UpdateCustBtn, True)
        Me.UpdateCustBtn.Size = New System.Drawing.Size(158, 74)
        Me.UpdateCustBtn.TabIndex = 17
        Me.UpdateCustBtn.Text = "Update Customer"
        Me.ToolTip1.SetToolTip(Me.UpdateCustBtn, "Click to update customer details")
        Me.UpdateCustBtn.UseVisualStyleBackColor = False
        '
        'physicalTextBox
        '
        Me.physicalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Physical_Address", True))
        Me.HelpProvider1.SetHelpString(Me.physicalTextBox, "Edit pysical address")
        Me.physicalTextBox.Location = New System.Drawing.Point(290, 578)
        Me.physicalTextBox.Name = "physicalTextBox"
        Me.HelpProvider1.SetShowHelp(Me.physicalTextBox, True)
        Me.physicalTextBox.Size = New System.Drawing.Size(173, 20)
        Me.physicalTextBox.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.physicalTextBox, "Enter physical address")
        '
        'emailTextBox
        '
        Me.emailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Email_Address", True))
        Me.HelpProvider1.SetHelpString(Me.emailTextBox, "Edit email address")
        Me.emailTextBox.Location = New System.Drawing.Point(290, 428)
        Me.emailTextBox.Name = "emailTextBox"
        Me.HelpProvider1.SetShowHelp(Me.emailTextBox, True)
        Me.emailTextBox.Size = New System.Drawing.Size(259, 20)
        Me.emailTextBox.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.emailTextBox, "Enter email address to update")
        '
        'faxNumTextBox
        '
        Me.faxNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Fax_Number", True))
        Me.HelpProvider1.SetHelpString(Me.faxNumTextBox, "Edit contact number")
        Me.faxNumTextBox.Location = New System.Drawing.Point(290, 529)
        Me.faxNumTextBox.MaxLength = 10
        Me.faxNumTextBox.Name = "faxNumTextBox"
        Me.HelpProvider1.SetShowHelp(Me.faxNumTextBox, True)
        Me.faxNumTextBox.Size = New System.Drawing.Size(177, 20)
        Me.faxNumTextBox.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.faxNumTextBox, "Enter fax number to edit")
        '
        'contactNoTextbox
        '
        Me.contactNoTextbox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Contact_Number", True))
        Me.HelpProvider1.SetHelpString(Me.contactNoTextbox, "Edit contact number")
        Me.contactNoTextbox.Location = New System.Drawing.Point(290, 480)
        Me.contactNoTextbox.MaxLength = 10
        Me.contactNoTextbox.Name = "contactNoTextbox"
        Me.HelpProvider1.SetShowHelp(Me.contactNoTextbox, True)
        Me.contactNoTextbox.Size = New System.Drawing.Size(177, 20)
        Me.contactNoTextbox.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.contactNoTextbox, "Enter contact number to update")
        '
        'custIDNumTextBox
        '
        Me.custIDNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Cust_ID_Number", True))
        Me.custIDNumTextBox.Enabled = False
        Me.custIDNumTextBox.Location = New System.Drawing.Point(949, 485)
        Me.custIDNumTextBox.Name = "custIDNumTextBox"
        Me.custIDNumTextBox.Size = New System.Drawing.Size(199, 20)
        Me.custIDNumTextBox.TabIndex = 11
        '
        'custNameTextBox
        '
        Me.custNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Cust_Name", True))
        Me.HelpProvider1.SetHelpString(Me.custNameTextBox, "Edit customer name")
        Me.custNameTextBox.Location = New System.Drawing.Point(949, 430)
        Me.custNameTextBox.Name = "custNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.custNameTextBox, True)
        Me.custNameTextBox.Size = New System.Drawing.Size(199, 20)
        Me.custNameTextBox.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.custNameTextBox, "Enter customer name to edit")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 736)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Area Code"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(68, 580)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Physical Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(68, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email Address:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 529)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fax Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 485)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contact Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(750, 485)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Customer ID Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(750, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Customer Name:"
        '
        'TACustomer
        '
        Me.TACustomer.ClearBeforeFill = True
        '
        'EditCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1284, 960)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditCustomer"
        Me.Text = "Update Customer"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AreaCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SubarbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateCustBtn As System.Windows.Forms.Button
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
    Friend WithEvents DS1 As milestone2.group4DataSet
    Friend WithEvents TACustomer As milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter
    Friend WithEvents BSCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents SearchCustEditTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents SearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CustIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustIDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FaxNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicalAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuburbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AreaCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
