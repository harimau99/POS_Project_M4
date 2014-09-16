<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProcessSale
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProcessSale))
        Me.FinSaleBtn = New System.Windows.Forms.Button()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.addToInvoiceBtn = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RemoveBtn = New System.Windows.Forms.Button()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.InvoiceDGV = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductUnitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSInvoice = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSMain = New milestone2.group4DataSet()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NoRadioButton = New System.Windows.Forms.RadioButton()
        Me.YesRadioButton = New System.Windows.Forms.RadioButton()
        Me.delChargeText = New System.Windows.Forms.TextBox()
        Me.DelChargeBtn = New System.Windows.Forms.Button()
        Me.KilometerText = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProductDGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SearchProduct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.EmployeeNameTextBox = New System.Windows.Forms.TextBox()
        Me.SalesIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BSEmployee = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DGVCust = New System.Windows.Forms.DataGridView()
        Me.CustIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustIDNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhysicalAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuburbDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSCustomer = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustIDCombo = New System.Windows.Forms.ComboBox()
        Me.SearchName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustName = New System.Windows.Forms.TextBox()
        Me.CustID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TACustomer = New milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter()
        Me.ProductTableAdapter = New milestone2.group4DataSetTableAdapters.ProductTableAdapter()
        Me.TAEmployee = New milestone2.group4DataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New milestone2.group4DataSetTableAdapters.TableAdapterManager()
        Me.TASaleOrder = New milestone2.group4DataSetTableAdapters.SaleOrderTbTableAdapter()
        Me.TASaleOrderLine = New milestone2.group4DataSetTableAdapters.SaleOrderLineTbTableAdapter()
        Me.GetInvoiceBtn = New System.Windows.Forms.Button()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.RecPayBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PayTypeCombo = New System.Windows.Forms.ComboBox()
        Me.PayAmountText = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTextbox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TAPayment = New milestone2.group4DataSetTableAdapters.PaymentTbTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox3.SuspendLayout()
        CType(Me.InvoiceDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.BSEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVCust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PaymentGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'FinSaleBtn
        '
        Me.FinSaleBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.FinSaleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.FinSaleBtn, "Click to finalise sale and get total owing amount")
        Me.FinSaleBtn.Location = New System.Drawing.Point(1118, 370)
        Me.FinSaleBtn.Name = "FinSaleBtn"
        Me.HelpProvider1.SetShowHelp(Me.FinSaleBtn, True)
        Me.FinSaleBtn.Size = New System.Drawing.Size(111, 57)
        Me.FinSaleBtn.TabIndex = 25
        Me.FinSaleBtn.Text = "Finalise Sale"
        Me.ToolTip1.SetToolTip(Me.FinSaleBtn, "Click to finalise sale and total amount.")
        Me.FinSaleBtn.UseVisualStyleBackColor = False
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.ClearBtn, "Click to clear sale order")
        Me.ClearBtn.Location = New System.Drawing.Point(1124, 516)
        Me.ClearBtn.Name = "ClearBtn"
        Me.HelpProvider1.SetShowHelp(Me.ClearBtn, True)
        Me.ClearBtn.Size = New System.Drawing.Size(105, 63)
        Me.ClearBtn.TabIndex = 24
        Me.ClearBtn.Text = "Clear Sale Order"
        Me.ToolTip1.SetToolTip(Me.ClearBtn, "Click to clear sale order")
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'addToInvoiceBtn
        '
        Me.addToInvoiceBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.addToInvoiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.addToInvoiceBtn, "Click to add product to the invoice")
        Me.addToInvoiceBtn.Location = New System.Drawing.Point(971, 370)
        Me.addToInvoiceBtn.Name = "addToInvoiceBtn"
        Me.HelpProvider1.SetShowHelp(Me.addToInvoiceBtn, True)
        Me.addToInvoiceBtn.Size = New System.Drawing.Size(111, 57)
        Me.addToInvoiceBtn.TabIndex = 23
        Me.addToInvoiceBtn.Text = "Add To Invoice"
        Me.ToolTip1.SetToolTip(Me.addToInvoiceBtn, "Click to add ordered products to invoice")
        Me.addToInvoiceBtn.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox3.Controls.Add(Me.RemoveBtn)
        Me.GroupBox3.Controls.Add(Me.TotalTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.InvoiceDGV)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 532)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(953, 204)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Invoice"
        '
        'RemoveBtn
        '
        Me.RemoveBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.RemoveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveBtn.Location = New System.Drawing.Point(57, 9)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.Size = New System.Drawing.Size(125, 31)
        Me.RemoveBtn.TabIndex = 3
        Me.RemoveBtn.Text = "Remove Item"
        Me.ToolTip1.SetToolTip(Me.RemoveBtn, "Click to remove an item from invoice")
        Me.RemoveBtn.UseVisualStyleBackColor = False
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(754, 69)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(141, 20)
        Me.TotalTextBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(764, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Amount Owing"
        '
        'InvoiceDGV
        '
        Me.InvoiceDGV.AutoGenerateColumns = False
        Me.InvoiceDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductItemDataGridViewTextBoxColumn, Me.ProductModelDataGridViewTextBoxColumn, Me.ProductUnitPriceDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.SubTotalDataGridViewTextBoxColumn})
        Me.InvoiceDGV.DataSource = Me.BSInvoice
        Me.InvoiceDGV.Location = New System.Drawing.Point(6, 46)
        Me.InvoiceDGV.Name = "InvoiceDGV"
        Me.InvoiceDGV.Size = New System.Drawing.Size(918, 152)
        Me.InvoiceDGV.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductItemDataGridViewTextBoxColumn
        '
        Me.ProductItemDataGridViewTextBoxColumn.DataPropertyName = "ProductItem"
        Me.ProductItemDataGridViewTextBoxColumn.HeaderText = "ProductItem"
        Me.ProductItemDataGridViewTextBoxColumn.Name = "ProductItemDataGridViewTextBoxColumn"
        '
        'ProductModelDataGridViewTextBoxColumn
        '
        Me.ProductModelDataGridViewTextBoxColumn.DataPropertyName = "ProductModel"
        Me.ProductModelDataGridViewTextBoxColumn.HeaderText = "ProductModel"
        Me.ProductModelDataGridViewTextBoxColumn.Name = "ProductModelDataGridViewTextBoxColumn"
        '
        'ProductUnitPriceDataGridViewTextBoxColumn
        '
        Me.ProductUnitPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductUnitPrice"
        Me.ProductUnitPriceDataGridViewTextBoxColumn.HeaderText = "ProductUnitPrice"
        Me.ProductUnitPriceDataGridViewTextBoxColumn.Name = "ProductUnitPriceDataGridViewTextBoxColumn"
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProductDescription"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "ProductDescription"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'SubTotalDataGridViewTextBoxColumn
        '
        Me.SubTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal"
        Me.SubTotalDataGridViewTextBoxColumn.Name = "SubTotalDataGridViewTextBoxColumn"
        '
        'BSInvoice
        '
        Me.BSInvoice.DataMember = "Invoice"
        Me.BSInvoice.DataSource = Me.DSMain
        '
        'DSMain
        '
        Me.DSMain.DataSetName = "group4DataSet"
        Me.DSMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox4.Controls.Add(Me.NoRadioButton)
        Me.GroupBox4.Controls.Add(Me.YesRadioButton)
        Me.GroupBox4.Controls.Add(Me.delChargeText)
        Me.GroupBox4.Controls.Add(Me.DelChargeBtn)
        Me.GroupBox4.Controls.Add(Me.KilometerText)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Location = New System.Drawing.Point(969, 223)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(266, 118)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Delivery"
        '
        'NoRadioButton
        '
        Me.NoRadioButton.AutoSize = True
        Me.NoRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoRadioButton.Location = New System.Drawing.Point(124, 22)
        Me.NoRadioButton.Name = "NoRadioButton"
        Me.NoRadioButton.Size = New System.Drawing.Size(43, 19)
        Me.NoRadioButton.TabIndex = 6
        Me.NoRadioButton.TabStop = True
        Me.NoRadioButton.Text = "No"
        Me.NoRadioButton.UseVisualStyleBackColor = True
        '
        'YesRadioButton
        '
        Me.YesRadioButton.AutoSize = True
        Me.YesRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesRadioButton.Location = New System.Drawing.Point(7, 22)
        Me.YesRadioButton.Name = "YesRadioButton"
        Me.YesRadioButton.Size = New System.Drawing.Size(48, 19)
        Me.YesRadioButton.TabIndex = 5
        Me.YesRadioButton.TabStop = True
        Me.YesRadioButton.Text = "Yes"
        Me.YesRadioButton.UseVisualStyleBackColor = True
        '
        'delChargeText
        '
        Me.delChargeText.Enabled = False
        Me.delChargeText.Location = New System.Drawing.Point(156, 81)
        Me.delChargeText.Name = "delChargeText"
        Me.delChargeText.Size = New System.Drawing.Size(104, 20)
        Me.delChargeText.TabIndex = 4
        '
        'DelChargeBtn
        '
        Me.DelChargeBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.DelChargeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DelChargeBtn.Location = New System.Drawing.Point(6, 76)
        Me.DelChargeBtn.Name = "DelChargeBtn"
        Me.DelChargeBtn.Size = New System.Drawing.Size(136, 29)
        Me.DelChargeBtn.TabIndex = 3
        Me.DelChargeBtn.Text = "Delivery Charge"
        Me.ToolTip1.SetToolTip(Me.DelChargeBtn, "Click to calculate delivery charge")
        Me.DelChargeBtn.UseVisualStyleBackColor = False
        '
        'KilometerText
        '
        Me.KilometerText.Location = New System.Drawing.Point(156, 46)
        Me.KilometerText.Name = "KilometerText"
        Me.KilometerText.Size = New System.Drawing.Size(104, 20)
        Me.KilometerText.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.KilometerText, "Enter number of kilometres from BBRW to destination")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Enter Kilometers"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox2.Controls.Add(Me.ProductDGV)
        Me.GroupBox2.Controls.Add(Me.SearchProduct)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 287)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product List"
        '
        'ProductDGV
        '
        Me.ProductDGV.AutoGenerateColumns = False
        Me.ProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.Quantity})
        Me.ProductDGV.DataSource = Me.ProductBindingSource
        Me.ProductDGV.Location = New System.Drawing.Point(6, 58)
        Me.ProductDGV.Name = "ProductDGV"
        Me.ProductDGV.Size = New System.Drawing.Size(941, 220)
        Me.ProductDGV.TabIndex = 3
        Me.ProductDGV.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Product_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Product_Item"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product_Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product_Model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product_Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Product_Price"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product_Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Product_Category"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Product_Category"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Product_Description"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Product_Description"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Product_Quantity"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Product_Quantity"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Quantity
        '
        DataGridViewCellStyle1.NullValue = "0"
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle1
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.Quantity.Name = "Quantity"
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.DSMain
        '
        'SearchProduct
        '
        Me.SearchProduct.Location = New System.Drawing.Point(203, 25)
        Me.SearchProduct.Name = "SearchProduct"
        Me.SearchProduct.Size = New System.Drawing.Size(241, 20)
        Me.SearchProduct.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Search By Product Name"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox5.Controls.Add(Me.EmployeeNameTextBox)
        Me.GroupBox5.Controls.Add(Me.SalesIDTextBox)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Location = New System.Drawing.Point(969, 50)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(266, 103)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Employee"
        '
        'EmployeeNameTextBox
        '
        Me.EmployeeNameTextBox.Enabled = False
        Me.EmployeeNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeNameTextBox.Location = New System.Drawing.Point(142, 55)
        Me.EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        Me.EmployeeNameTextBox.Size = New System.Drawing.Size(118, 20)
        Me.EmployeeNameTextBox.TabIndex = 9
        '
        'SalesIDTextBox
        '
        Me.SalesIDTextBox.Enabled = False
        Me.SalesIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesIDTextBox.Location = New System.Drawing.Point(142, 15)
        Me.SalesIDTextBox.Name = "SalesIDTextBox"
        Me.SalesIDTextBox.Size = New System.Drawing.Size(49, 20)
        Me.SalesIDTextBox.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 15)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Employee Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Employee ID"
        '
        'BSEmployee
        '
        Me.BSEmployee.DataMember = "Employee"
        Me.BSEmployee.DataSource = Me.DSMain
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.GroupBox1.Controls.Add(Me.DGVCust)
        Me.GroupBox1.Controls.Add(Me.CustIDCombo)
        Me.GroupBox1.Controls.Add(Me.SearchName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CustName)
        Me.GroupBox1.Controls.Add(Me.CustID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 167)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Search"
        '
        'DGVCust
        '
        Me.DGVCust.AutoGenerateColumns = False
        Me.DGVCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCust.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustIDDataGridViewTextBoxColumn, Me.CustNameDataGridViewTextBoxColumn, Me.CustIDNumberDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.PhysicalAddressDataGridViewTextBoxColumn, Me.SuburbDataGridViewTextBoxColumn, Me.AreaCodeDataGridViewTextBoxColumn})
        Me.DGVCust.DataSource = Me.BSCustomer
        Me.DGVCust.Location = New System.Drawing.Point(242, 60)
        Me.DGVCust.Name = "DGVCust"
        Me.DGVCust.Size = New System.Drawing.Size(721, 92)
        Me.DGVCust.TabIndex = 11
        '
        'CustIDDataGridViewTextBoxColumn
        '
        Me.CustIDDataGridViewTextBoxColumn.DataPropertyName = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.HeaderText = "Cust_ID"
        Me.CustIDDataGridViewTextBoxColumn.Name = "CustIDDataGridViewTextBoxColumn"
        Me.CustIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CustNameDataGridViewTextBoxColumn
        '
        Me.CustNameDataGridViewTextBoxColumn.DataPropertyName = "Cust_Name"
        Me.CustNameDataGridViewTextBoxColumn.HeaderText = "Cust_Name"
        Me.CustNameDataGridViewTextBoxColumn.Name = "CustNameDataGridViewTextBoxColumn"
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
        'PhysicalAddressDataGridViewTextBoxColumn
        '
        Me.PhysicalAddressDataGridViewTextBoxColumn.DataPropertyName = "Physical_Address"
        Me.PhysicalAddressDataGridViewTextBoxColumn.HeaderText = "Physical_Address"
        Me.PhysicalAddressDataGridViewTextBoxColumn.Name = "PhysicalAddressDataGridViewTextBoxColumn"
        '
        'SuburbDataGridViewTextBoxColumn
        '
        Me.SuburbDataGridViewTextBoxColumn.DataPropertyName = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.HeaderText = "Suburb"
        Me.SuburbDataGridViewTextBoxColumn.Name = "SuburbDataGridViewTextBoxColumn"
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
        Me.BSCustomer.DataSource = Me.DSMain
        '
        'CustIDCombo
        '
        Me.CustIDCombo.DataSource = Me.BSCustomer
        Me.CustIDCombo.DisplayMember = "Cust_ID"
        Me.CustIDCombo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.CustIDCombo, "Choose a customer by ID from drop down list")
        Me.CustIDCombo.Location = New System.Drawing.Point(167, 17)
        Me.CustIDCombo.Name = "CustIDCombo"
        Me.HelpProvider1.SetShowHelp(Me.CustIDCombo, True)
        Me.CustIDCombo.Size = New System.Drawing.Size(121, 21)
        Me.CustIDCombo.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.CustIDCombo, "Search for a customer by ID")
        '
        'SearchName
        '
        Me.HelpProvider1.SetHelpString(Me.SearchName, "Enter customer name to search for.")
        Me.SearchName.Location = New System.Drawing.Point(533, 16)
        Me.SearchName.Name = "SearchName"
        Me.HelpProvider1.SetShowHelp(Me.SearchName, True)
        Me.SearchName.Size = New System.Drawing.Size(144, 20)
        Me.SearchName.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.SearchName, "Search for a customer by name")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(350, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search by Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(116, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Customer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Customer ID"
        '
        'CustName
        '
        Me.CustName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Cust_Name", True))
        Me.CustName.Enabled = False
        Me.CustName.Location = New System.Drawing.Point(119, 110)
        Me.CustName.Name = "CustName"
        Me.CustName.Size = New System.Drawing.Size(107, 20)
        Me.CustName.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.CustName, "To display customer name")
        '
        'CustID
        '
        Me.CustID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSCustomer, "Cust_ID", True))
        Me.CustID.Enabled = False
        Me.CustID.Location = New System.Drawing.Point(13, 110)
        Me.CustID.Name = "CustID"
        Me.CustID.Size = New System.Drawing.Size(100, 20)
        Me.CustID.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.CustID, "To display customer ID")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search By Customer ID"
        '
        'TACustomer
        '
        Me.TACustomer.ClearBeforeFill = True
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'TAEmployee
        '
        Me.TAEmployee.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.CustomerTbTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTbTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SaleOrderLineTbTableAdapter = Nothing
        Me.TableAdapterManager.SaleOrderTbTableAdapter = Nothing
        Me.TableAdapterManager.SupplierOrderLineTableAdapter = Nothing
        Me.TableAdapterManager.SupplierOrderTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = milestone2.group4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableAdapter = Nothing
        '
        'TASaleOrder
        '
        Me.TASaleOrder.ClearBeforeFill = True
        '
        'TASaleOrderLine
        '
        Me.TASaleOrderLine.ClearBeforeFill = True
        '
        'GetInvoiceBtn
        '
        Me.GetInvoiceBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.GetInvoiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.GetInvoiceBtn, "Click to get invoice")
        Me.GetInvoiceBtn.Location = New System.Drawing.Point(969, 516)
        Me.GetInvoiceBtn.Name = "GetInvoiceBtn"
        Me.HelpProvider1.SetShowHelp(Me.GetInvoiceBtn, True)
        Me.GetInvoiceBtn.Size = New System.Drawing.Size(110, 63)
        Me.GetInvoiceBtn.TabIndex = 26
        Me.GetInvoiceBtn.Text = "Get Invoice"
        Me.ToolTip1.SetToolTip(Me.GetInvoiceBtn, "Click to retrieve invoice.")
        Me.GetInvoiceBtn.UseVisualStyleBackColor = False
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PaymentGroupBox.Controls.Add(Me.RecPayBtn)
        Me.PaymentGroupBox.Controls.Add(Me.Label13)
        Me.PaymentGroupBox.Controls.Add(Me.PayTypeCombo)
        Me.PaymentGroupBox.Controls.Add(Me.PayAmountText)
        Me.PaymentGroupBox.Controls.Add(Me.Label12)
        Me.PaymentGroupBox.Controls.Add(Me.DateTextbox)
        Me.PaymentGroupBox.Controls.Add(Me.Label11)
        Me.PaymentGroupBox.Location = New System.Drawing.Point(6, 742)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(515, 136)
        Me.PaymentGroupBox.TabIndex = 29
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Record Payment"
        Me.ToolTip1.SetToolTip(Me.PaymentGroupBox, "Choose the customer's payment method")
        Me.PaymentGroupBox.Visible = False
        '
        'RecPayBtn
        '
        Me.RecPayBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.RecPayBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.RecPayBtn, "Click to record customer payment")
        Me.RecPayBtn.Location = New System.Drawing.Point(353, 17)
        Me.RecPayBtn.Name = "RecPayBtn"
        Me.HelpProvider1.SetShowHelp(Me.RecPayBtn, True)
        Me.RecPayBtn.Size = New System.Drawing.Size(91, 69)
        Me.RecPayBtn.TabIndex = 6
        Me.RecPayBtn.Text = "Record Payment"
        Me.ToolTip1.SetToolTip(Me.RecPayBtn, "Click to record payment details")
        Me.RecPayBtn.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 15)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Payment Type"
        '
        'PayTypeCombo
        '
        Me.PayTypeCombo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.PayTypeCombo, "Choose cutomer payment method")
        Me.PayTypeCombo.Items.AddRange(New Object() {"Cash", "Card"})
        Me.PayTypeCombo.Location = New System.Drawing.Point(133, 73)
        Me.PayTypeCombo.Name = "PayTypeCombo"
        Me.HelpProvider1.SetShowHelp(Me.PayTypeCombo, True)
        Me.PayTypeCombo.Size = New System.Drawing.Size(168, 21)
        Me.PayTypeCombo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.PayTypeCombo, "Choose customer payment method")
        '
        'PayAmountText
        '
        Me.PayAmountText.Location = New System.Drawing.Point(133, 47)
        Me.PayAmountText.Name = "PayAmountText"
        Me.PayAmountText.Size = New System.Drawing.Size(168, 20)
        Me.PayAmountText.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Payment Amount"
        '
        'DateTextbox
        '
        Me.DateTextbox.Location = New System.Drawing.Point(133, 21)
        Me.DateTextbox.Name = "DateTextbox"
        Me.DateTextbox.Size = New System.Drawing.Size(168, 20)
        Me.DateTextbox.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 15)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Payment Date"
        '
        'TAPayment
        '
        Me.TAPayment.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button1, "Click to go back to main menu")
        Me.Button1.Location = New System.Drawing.Point(1025, 670)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(147, 60)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to go back to main menu")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(0, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(1244, 42)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Process Customer Sale Order"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ProcessSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PaymentGroupBox)
        Me.Controls.Add(Me.GetInvoiceBtn)
        Me.Controls.Add(Me.FinSaleBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.addToInvoiceBtn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProcessSale"
        Me.Text = "ProcessSale"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.InvoiceDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ProductDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.BSEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVCust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FinSaleBtn As System.Windows.Forms.Button
    Friend WithEvents ClearBtn As System.Windows.Forms.Button
    Friend WithEvents addToInvoiceBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RemoveBtn As System.Windows.Forms.Button
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents InvoiceDGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents delChargeText As System.Windows.Forms.TextBox
    Friend WithEvents DelChargeBtn As System.Windows.Forms.Button
    Friend WithEvents KilometerText As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents SearchProduct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DGVCust As System.Windows.Forms.DataGridView
    Friend WithEvents CustIDCombo As System.Windows.Forms.ComboBox
    Friend WithEvents SearchName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CustName As System.Windows.Forms.TextBox
    Friend WithEvents CustID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DSMain As milestone2.group4DataSet
    Friend WithEvents BSCustomer As System.Windows.Forms.BindingSource
    Friend WithEvents TACustomer As milestone2.group4DataSetTableAdapters.CustomerTbTableAdapter
    Friend WithEvents ProductBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductTableAdapter As milestone2.group4DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents TableAdapterManager As milestone2.group4DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductDGV As System.Windows.Forms.DataGridView
    Friend WithEvents NoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents YesRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents TAEmployee As milestone2.group4DataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents BSEmployee As System.Windows.Forms.BindingSource
    Friend WithEvents BSInvoice As System.Windows.Forms.BindingSource
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductUnitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TASaleOrder As milestone2.group4DataSetTableAdapters.SaleOrderTbTableAdapter
    Friend WithEvents TASaleOrderLine As milestone2.group4DataSetTableAdapters.SaleOrderLineTbTableAdapter
    Friend WithEvents GetInvoiceBtn As System.Windows.Forms.Button
    Friend WithEvents PaymentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents RecPayBtn As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PayTypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents PayAmountText As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TAPayment As milestone2.group4DataSetTableAdapters.PaymentTbTableAdapter
    Friend WithEvents SalesIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CustIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustIDNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhysicalAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SuburbDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AreaCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
