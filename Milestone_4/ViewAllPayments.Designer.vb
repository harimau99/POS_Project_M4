<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAllPayments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAllPayments))
        Me.DS1 = New milestone2.group4DataSet()
        Me.CustomerTbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TACustomer = New milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter()
        Me.TableAdapterManager = New milestone2.group4DataSetTableAdapters.TableAdapterManager()
        Me.PaymentTbTableAdapter = New milestone2.group4DataSetTableAdapters.PaymentTbTableAdapter()
        Me.CustomerTbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentTbBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTbDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTbBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentTbDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS1
        '
        Me.DS1.DataSetName = "group4DataSet"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTbBindingSource
        '
        Me.CustomerTbBindingSource.DataMember = "CustomerTb"
        Me.CustomerTbBindingSource.DataSource = Me.DS1
        '
        'TACustomer
        '
        Me.TACustomer.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CustomerTbTableAdapter = Me.TACustomer
        Me.TableAdapterManager.PaymentTbTableAdapter = Me.PaymentTbTableAdapter
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SaleOrderLineTbTableAdapter = Nothing
        Me.TableAdapterManager.SaleOrderTbTableAdapter = Nothing
        Me.TableAdapterManager.SupplierOrderLineTableAdapter = Nothing
        Me.TableAdapterManager.SupplierOrderTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = milestone2.group4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'PaymentTbTableAdapter
        '
        Me.PaymentTbTableAdapter.ClearBeforeFill = True
        '
        'CustomerTbDataGridView
        '
        Me.CustomerTbDataGridView.AutoGenerateColumns = False
        Me.CustomerTbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerTbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.CustomerTbDataGridView.DataSource = Me.CustomerTbBindingSource
        Me.CustomerTbDataGridView.Location = New System.Drawing.Point(12, 176)
        Me.CustomerTbDataGridView.Name = "CustomerTbDataGridView"
        Me.CustomerTbDataGridView.Size = New System.Drawing.Size(1193, 318)
        Me.CustomerTbDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cust_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cust_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 60
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Cust_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cust_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 120
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cust_ID_Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cust_ID_Number"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 110
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Contact_Number"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Contact_Number"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Fax_Number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fax_Number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 110
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Email_Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Email_Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Physical_Address"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Physical_Address"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 130
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Suburb"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Suburb"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 120
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "City"
        Me.DataGridViewTextBoxColumn9.HeaderText = "City"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 120
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Area_Code"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Area_Code"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'PaymentTbBindingSource
        '
        Me.PaymentTbBindingSource.DataMember = "FK_PaymentTb_CustomerTb"
        Me.PaymentTbBindingSource.DataSource = Me.CustomerTbBindingSource
        '
        'PaymentTbDataGridView
        '
        Me.PaymentTbDataGridView.AutoGenerateColumns = False
        Me.PaymentTbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PaymentTbDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.PaymentTbDataGridView.DataSource = Me.PaymentTbBindingSource
        Me.PaymentTbDataGridView.Location = New System.Drawing.Point(276, 520)
        Me.PaymentTbDataGridView.Name = "PaymentTbDataGridView"
        Me.PaymentTbDataGridView.Size = New System.Drawing.Size(686, 247)
        Me.PaymentTbDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Payment_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Payment_ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Payment_Date"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Payment_Date"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 120
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Payment_Amount"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Payment_Amount"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 120
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Payment_Type"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Payment_Type"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Sale_Order_ID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Sale_Order_ID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Cust_ID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Cust_ID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Search Customer Name"
        '
        'SearchName
        '
        Me.HelpProvider1.SetHelpString(Me.SearchName, "Enter customer's name to search for.")
        Me.SearchName.Location = New System.Drawing.Point(370, 110)
        Me.SearchName.Name = "SearchName"
        Me.HelpProvider1.SetShowHelp(Me.SearchName, True)
        Me.SearchName.Size = New System.Drawing.Size(166, 20)
        Me.SearchName.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.SearchName, "Enter name of customer to search for")
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1236, 42)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "View Payments Made By Customers"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.CustomerTbBindingSource
        Me.ComboBox1.DisplayMember = "Cust_ID"
        Me.ComboBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.ComboBox1, "Choose a customer by ID")
        Me.ComboBox1.Location = New System.Drawing.Point(988, 109)
        Me.ComboBox1.Name = "ComboBox1"
        Me.HelpProvider1.SetShowHelp(Me.ComboBox1, True)
        Me.ComboBox1.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox1.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Choose a customer by ID")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(746, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Search By Customer ID"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button1, "Click to go back to main menu")
        Me.Button1.Location = New System.Drawing.Point(1003, 788)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(202, 60)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to go back to main menu")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewAllPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SearchName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PaymentTbDataGridView)
        Me.Controls.Add(Me.CustomerTbDataGridView)
        Me.Name = "ViewAllPayments"
        Me.Text = "ViewAllPayments"
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTbBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentTbDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS1 As milestone2.group4DataSet
    Friend WithEvents CustomerTbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TACustomer As milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter
    Friend WithEvents TableAdapterManager As milestone2.group4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PaymentTbTableAdapter As milestone2.group4DataSetTableAdapters.PaymentTbTableAdapter
    Friend WithEvents CustomerTbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents PaymentTbBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PaymentTbDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
