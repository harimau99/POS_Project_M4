<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSupplierDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSupplierDetails))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CancelBtn = New System.Windows.Forms.Button()
        Me.EditSuppBtn = New System.Windows.Forms.Button()
        Me.SpecialityComboBox = New System.Windows.Forms.ComboBox()
        Me.BSSupplier = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS1 = New milestone2.group4DataSet()
        Me.suppEmailTextBox = New System.Windows.Forms.TextBox()
        Me.suppNumbTextBox = New System.Windows.Forms.TextBox()
        Me.suppNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SupplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierSpecialityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SupSearchTxtBox = New System.Windows.Forms.TextBox()
        Me.TASupplier = New milestone2.group4DataSetTableAdapters.SupplierTableAdapter()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.BSSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1239, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Update Supplier Details"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CancelBtn
        '
        Me.CancelBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.CancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.CancelBtn, "Click to go back to main menu")
        Me.CancelBtn.Location = New System.Drawing.Point(700, 782)
        Me.CancelBtn.Name = "CancelBtn"
        Me.HelpProvider1.SetShowHelp(Me.CancelBtn, True)
        Me.CancelBtn.Size = New System.Drawing.Size(158, 64)
        Me.CancelBtn.TabIndex = 25
        Me.CancelBtn.Text = "Back To Main Menu"
        Me.CancelBtn.UseVisualStyleBackColor = False
        '
        'EditSuppBtn
        '
        Me.EditSuppBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.EditSuppBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.EditSuppBtn, "Click to update supplier")
        Me.EditSuppBtn.Location = New System.Drawing.Point(290, 782)
        Me.EditSuppBtn.Name = "EditSuppBtn"
        Me.HelpProvider1.SetShowHelp(Me.EditSuppBtn, True)
        Me.EditSuppBtn.Size = New System.Drawing.Size(177, 64)
        Me.EditSuppBtn.TabIndex = 24
        Me.EditSuppBtn.Text = "Update Supplier"
        Me.ToolTip1.SetToolTip(Me.EditSuppBtn, "Click to update supplier")
        Me.EditSuppBtn.UseVisualStyleBackColor = False
        '
        'SpecialityComboBox
        '
        Me.SpecialityComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSSupplier, "Supplier_Speciality", True))
        Me.SpecialityComboBox.Enabled = False
        Me.SpecialityComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.SpecialityComboBox, "Edit supplier speciality")
        Me.SpecialityComboBox.Items.AddRange(New Object() {"Refrigeration" & Global.Microsoft.VisualBasic.ChrW(9), "Catering", "Butchery", "Bakery"})
        Me.SpecialityComboBox.Location = New System.Drawing.Point(519, 700)
        Me.SpecialityComboBox.Name = "SpecialityComboBox"
        Me.HelpProvider1.SetShowHelp(Me.SpecialityComboBox, True)
        Me.SpecialityComboBox.Size = New System.Drawing.Size(118, 21)
        Me.SpecialityComboBox.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.SpecialityComboBox, "Edit supplier speciality")
        '
        'BSSupplier
        '
        Me.BSSupplier.DataMember = "Supplier"
        Me.BSSupplier.DataSource = Me.DS1
        '
        'DS1
        '
        Me.DS1.DataSetName = "group4DataSet"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'suppEmailTextBox
        '
        Me.suppEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSSupplier, "Supplier_Email", True))
        Me.HelpProvider1.SetHelpString(Me.suppEmailTextBox, "Edit supplier email address")
        Me.suppEmailTextBox.Location = New System.Drawing.Point(519, 647)
        Me.suppEmailTextBox.Name = "suppEmailTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppEmailTextBox, True)
        Me.suppEmailTextBox.Size = New System.Drawing.Size(274, 20)
        Me.suppEmailTextBox.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.suppEmailTextBox, "Edit email address")
        '
        'suppNumbTextBox
        '
        Me.suppNumbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSSupplier, "Supplier_Contact_No", True))
        Me.HelpProvider1.SetHelpString(Me.suppNumbTextBox, "Edit supplier contact number")
        Me.suppNumbTextBox.Location = New System.Drawing.Point(519, 591)
        Me.suppNumbTextBox.Name = "suppNumbTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppNumbTextBox, True)
        Me.suppNumbTextBox.Size = New System.Drawing.Size(274, 20)
        Me.suppNumbTextBox.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.suppNumbTextBox, "Edit contact number")
        '
        'suppNameTextBox
        '
        Me.suppNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSSupplier, "Supplier_Name", True))
        Me.HelpProvider1.SetHelpString(Me.suppNameTextBox, "Edit supplier name")
        Me.suppNameTextBox.Location = New System.Drawing.Point(519, 531)
        Me.suppNameTextBox.Name = "suppNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.suppNameTextBox, True)
        Me.suppNameTextBox.Size = New System.Drawing.Size(274, 20)
        Me.suppNameTextBox.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.suppNameTextBox, "Edit Supplier name")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(287, 703)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Supplier Speciality:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(287, 646)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(287, 590)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contact Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(287, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Supplier Name:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SupplierIDDataGridViewTextBoxColumn, Me.SupplierNameDataGridViewTextBoxColumn, Me.SupplierContactNoDataGridViewTextBoxColumn, Me.SupplierEmailDataGridViewTextBoxColumn, Me.SupplierSpecialityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BSSupplier
        Me.DataGridView1.Location = New System.Drawing.Point(264, 140)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(676, 277)
        Me.DataGridView1.TabIndex = 28
        '
        'SupplierIDDataGridViewTextBoxColumn
        '
        Me.SupplierIDDataGridViewTextBoxColumn.DataPropertyName = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.HeaderText = "Supplier_ID"
        Me.SupplierIDDataGridViewTextBoxColumn.Name = "SupplierIDDataGridViewTextBoxColumn"
        Me.SupplierIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SupplierNameDataGridViewTextBoxColumn
        '
        Me.SupplierNameDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.HeaderText = "Supplier_Name"
        Me.SupplierNameDataGridViewTextBoxColumn.Name = "SupplierNameDataGridViewTextBoxColumn"
        Me.SupplierNameDataGridViewTextBoxColumn.Width = 130
        '
        'SupplierContactNoDataGridViewTextBoxColumn
        '
        Me.SupplierContactNoDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Contact_No"
        Me.SupplierContactNoDataGridViewTextBoxColumn.HeaderText = "Supplier_Contact_No"
        Me.SupplierContactNoDataGridViewTextBoxColumn.Name = "SupplierContactNoDataGridViewTextBoxColumn"
        Me.SupplierContactNoDataGridViewTextBoxColumn.Width = 110
        '
        'SupplierEmailDataGridViewTextBoxColumn
        '
        Me.SupplierEmailDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.HeaderText = "Supplier_Email"
        Me.SupplierEmailDataGridViewTextBoxColumn.Name = "SupplierEmailDataGridViewTextBoxColumn"
        Me.SupplierEmailDataGridViewTextBoxColumn.Width = 170
        '
        'SupplierSpecialityDataGridViewTextBoxColumn
        '
        Me.SupplierSpecialityDataGridViewTextBoxColumn.DataPropertyName = "Supplier_Speciality"
        Me.SupplierSpecialityDataGridViewTextBoxColumn.HeaderText = "Supplier_Speciality"
        Me.SupplierSpecialityDataGridViewTextBoxColumn.Name = "SupplierSpecialityDataGridViewTextBoxColumn"
        Me.SupplierSpecialityDataGridViewTextBoxColumn.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(304, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Enter Supplier Name"
        '
        'SupSearchTxtBox
        '
        Me.SupSearchTxtBox.Location = New System.Drawing.Point(521, 91)
        Me.SupSearchTxtBox.Name = "SupSearchTxtBox"
        Me.SupSearchTxtBox.Size = New System.Drawing.Size(272, 20)
        Me.SupSearchTxtBox.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.SupSearchTxtBox, "Enter supplier name to search for")
        '
        'TASupplier
        '
        Me.TASupplier.ClearBeforeFill = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1053, 817)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 29)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(799, 519)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 29)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(799, 582)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 29)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(643, 691)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 29)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1071, 830)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 16)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Required Fields"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1013, 469)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 184)
        Me.PictureBox1.TabIndex = 61
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(18, 459)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(454, 20)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Please Enter The Supplier Details You Wish To Update:"
        '
        'EditSupplierDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.SupSearchTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.EditSuppBtn)
        Me.Controls.Add(Me.SpecialityComboBox)
        Me.Controls.Add(Me.suppEmailTextBox)
        Me.Controls.Add(Me.suppNumbTextBox)
        Me.Controls.Add(Me.suppNameTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Name = "EditSupplierDetails"
        Me.Text = "Edit Supplier Details"
        CType(Me.BSSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Supplier_BS As System.Windows.Forms.BindingSource
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents EditSuppBtn As System.Windows.Forms.Button
    Friend WithEvents SpecialityComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents suppEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents suppNumbTextBox As System.Windows.Forms.TextBox
    Friend WithEvents suppNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SupSearchTxtBox As System.Windows.Forms.TextBox
    Friend WithEvents TASupplier As milestone2.group4DataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents DS1 As milestone2.group4DataSet
    Friend WithEvents BSSupplier As System.Windows.Forms.BindingSource
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SupplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SupplierSpecialityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
