<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProduct))
        Me.BSProduct = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS1 = New milestone2.group4DataSet()
        Me.TAProduct = New milestone2.group4DataSetTableAdapters.ProductTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProdNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductItemDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductModelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductSearchTxtBx = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EditProductBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prodModelTextBox = New System.Windows.Forms.TextBox()
        Me.prodDescTextBox = New System.Windows.Forms.TextBox()
        Me.prodPriceTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.BSProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BSProduct
        '
        Me.BSProduct.DataMember = "Product"
        Me.BSProduct.DataSource = Me.DS1
        '
        'DS1
        '
        Me.DS1.DataSetName = "group4DataSet"
        Me.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAProduct
        '
        Me.TAProduct.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(0, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(1236, 42)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Update Product"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(1089, 824)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(119, 16)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "Required Fields"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(1072, 814)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(24, 29)
        Me.Label15.TabIndex = 102
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(787, 710)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 29)
        Me.Label14.TabIndex = 101
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(787, 656)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 29)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(1047, 601)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 29)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(1047, 546)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 29)
        Me.Label11.TabIndex = 98
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1046, 475)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 29)
        Me.Label10.TabIndex = 97
        Me.Label10.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(1045, 404)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 29)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "*"
        '
        'ProdNameTextBox
        '
        Me.ProdNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Item", True))
        Me.HelpProvider1.SetHelpString(Me.ProdNameTextBox, "Edit product name")
        Me.ProdNameTextBox.Location = New System.Drawing.Point(659, 416)
        Me.ProdNameTextBox.Name = "ProdNameTextBox"
        Me.HelpProvider1.SetShowHelp(Me.ProdNameTextBox, True)
        Me.ProdNameTextBox.Size = New System.Drawing.Size(380, 20)
        Me.ProdNameTextBox.TabIndex = 95
        Me.ToolTip1.SetToolTip(Me.ProdNameTextBox, "Edit product name")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 18)
        Me.Label8.TabIndex = 94
        Me.Label8.Text = "Product Name"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductItemDataGridViewTextBoxColumn, Me.ProductModelDataGridViewTextBoxColumn, Me.ProductPriceDataGridViewTextBoxColumn, Me.ProductCategoryDataGridViewTextBoxColumn, Me.ProductDescriptionDataGridViewTextBoxColumn, Me.ProductQuantityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BSProduct
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(81, 110)
        Me.DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Size = New System.Drawing.Size(1027, 244)
        Me.DataGridView1.TabIndex = 93
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductItemDataGridViewTextBoxColumn
        '
        Me.ProductItemDataGridViewTextBoxColumn.DataPropertyName = "Product_Item"
        Me.ProductItemDataGridViewTextBoxColumn.HeaderText = "Product_Item"
        Me.ProductItemDataGridViewTextBoxColumn.Name = "ProductItemDataGridViewTextBoxColumn"
        Me.ProductItemDataGridViewTextBoxColumn.Width = 180
        '
        'ProductModelDataGridViewTextBoxColumn
        '
        Me.ProductModelDataGridViewTextBoxColumn.DataPropertyName = "Product_Model"
        Me.ProductModelDataGridViewTextBoxColumn.HeaderText = "Product_Model"
        Me.ProductModelDataGridViewTextBoxColumn.Name = "ProductModelDataGridViewTextBoxColumn"
        '
        'ProductPriceDataGridViewTextBoxColumn
        '
        Me.ProductPriceDataGridViewTextBoxColumn.DataPropertyName = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn.HeaderText = "Product_Price"
        Me.ProductPriceDataGridViewTextBoxColumn.Name = "ProductPriceDataGridViewTextBoxColumn"
        '
        'ProductCategoryDataGridViewTextBoxColumn
        '
        Me.ProductCategoryDataGridViewTextBoxColumn.DataPropertyName = "Product_Category"
        Me.ProductCategoryDataGridViewTextBoxColumn.HeaderText = "Product_Category"
        Me.ProductCategoryDataGridViewTextBoxColumn.Name = "ProductCategoryDataGridViewTextBoxColumn"
        '
        'ProductDescriptionDataGridViewTextBoxColumn
        '
        Me.ProductDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.HeaderText = "Product_Description"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Name = "ProductDescriptionDataGridViewTextBoxColumn"
        Me.ProductDescriptionDataGridViewTextBoxColumn.Width = 300
        '
        'ProductQuantityDataGridViewTextBoxColumn
        '
        Me.ProductQuantityDataGridViewTextBoxColumn.DataPropertyName = "Product_Quantity"
        Me.ProductQuantityDataGridViewTextBoxColumn.HeaderText = "Product_Quantity"
        Me.ProductQuantityDataGridViewTextBoxColumn.Name = "ProductQuantityDataGridViewTextBoxColumn"
        '
        'ProductSearchTxtBx
        '
        Me.HelpProvider1.SetHelpString(Me.ProductSearchTxtBx, "Enter product name to search for.")
        Me.ProductSearchTxtBx.Location = New System.Drawing.Point(284, 70)
        Me.ProductSearchTxtBx.Name = "ProductSearchTxtBx"
        Me.HelpProvider1.SetShowHelp(Me.ProductSearchTxtBx, True)
        Me.ProductSearchTxtBx.Size = New System.Drawing.Size(294, 20)
        Me.ProductSearchTxtBx.TabIndex = 92
        Me.ToolTip1.SetToolTip(Me.ProductSearchTxtBx, "Enter product name to search for")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(78, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 18)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Enter Product Name"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(32, 449)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 255)
        Me.PictureBox1.TabIndex = 88
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.AliceBlue
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button2, "Click to go back to main menu")
        Me.Button2.Location = New System.Drawing.Point(851, 791)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(146, 52)
        Me.Button2.TabIndex = 90
        Me.Button2.Text = "Back To Main Menu"
        Me.ToolTip1.SetToolTip(Me.Button2, "Go back to main menu")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(433, 486)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Product Model:"
        '
        'EditProductBtn
        '
        Me.EditProductBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.EditProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.EditProductBtn, "Click to update product ")
        Me.EditProductBtn.Location = New System.Drawing.Point(436, 791)
        Me.EditProductBtn.Name = "EditProductBtn"
        Me.HelpProvider1.SetShowHelp(Me.EditProductBtn, True)
        Me.EditProductBtn.Size = New System.Drawing.Size(151, 52)
        Me.EditProductBtn.TabIndex = 89
        Me.EditProductBtn.Text = "Update Product"
        Me.ToolTip1.SetToolTip(Me.EditProductBtn, "Click to update product")
        Me.EditProductBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(433, 554)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Product Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 668)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Product Category:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Quantity", True))
        Me.HelpProvider1.SetHelpString(Me.QuantityTextBox, "Edit product quantity")
        Me.QuantityTextBox.Location = New System.Drawing.Point(660, 721)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.HelpProvider1.SetShowHelp(Me.QuantityTextBox, True)
        Me.QuantityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.QuantityTextBox.TabIndex = 87
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Edit product quantity")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(433, 612)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 18)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Product Description:"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Category", True))
        Me.CategoryComboBox.Enabled = False
        Me.CategoryComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.CategoryComboBox, "Edit product category")
        Me.CategoryComboBox.Items.AddRange(New Object() {"Refrigeration", "Catering", "Butchery", "Bakery"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(661, 665)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.HelpProvider1.SetShowHelp(Me.CategoryComboBox, True)
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 86
        Me.ToolTip1.SetToolTip(Me.CategoryComboBox, "Edit product category")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(433, 721)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Product Quantity:"
        '
        'prodModelTextBox
        '
        Me.prodModelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Model", True))
        Me.HelpProvider1.SetHelpString(Me.prodModelTextBox, "Edit product model")
        Me.prodModelTextBox.Location = New System.Drawing.Point(659, 484)
        Me.prodModelTextBox.Name = "prodModelTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodModelTextBox, True)
        Me.prodModelTextBox.Size = New System.Drawing.Size(381, 20)
        Me.prodModelTextBox.TabIndex = 82
        Me.ToolTip1.SetToolTip(Me.prodModelTextBox, "Edit product model")
        '
        'prodDescTextBox
        '
        Me.prodDescTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Description", True))
        Me.HelpProvider1.SetHelpString(Me.prodDescTextBox, "Edit product description")
        Me.prodDescTextBox.Location = New System.Drawing.Point(659, 610)
        Me.prodDescTextBox.Name = "prodDescTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodDescTextBox, True)
        Me.prodDescTextBox.Size = New System.Drawing.Size(382, 20)
        Me.prodDescTextBox.TabIndex = 84
        Me.ToolTip1.SetToolTip(Me.prodDescTextBox, "Edit product decsription")
        '
        'prodPriceTextBox
        '
        Me.prodPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSProduct, "Product_Price", True))
        Me.HelpProvider1.SetHelpString(Me.prodPriceTextBox, "Edit product price")
        Me.prodPriceTextBox.Location = New System.Drawing.Point(661, 558)
        Me.prodPriceTextBox.Name = "prodPriceTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodPriceTextBox, True)
        Me.prodPriceTextBox.Size = New System.Drawing.Size(381, 20)
        Me.prodPriceTextBox.TabIndex = 83
        Me.ToolTip1.SetToolTip(Me.prodPriceTextBox, "Edit product price")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 366)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 20)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Please Enter Product Details You Wish To Update:"
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ProdNameTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProductSearchTxtBx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.EditProductBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prodModelTextBox)
        Me.Controls.Add(Me.prodDescTextBox)
        Me.Controls.Add(Me.prodPriceTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EditProduct"
        Me.Text = "Edit Product"
        CType(Me.BSProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BSProduct As System.Windows.Forms.BindingSource
    Friend WithEvents DS1 As milestone2.group4DataSet
    Friend WithEvents TAProduct As milestone2.group4DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ProdNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductItemDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductModelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductCategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductSearchTxtBx As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EditProductBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prodModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prodDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prodPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
