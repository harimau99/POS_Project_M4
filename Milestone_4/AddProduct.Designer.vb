<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddProduct))
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prodDescTextBox = New System.Windows.Forms.TextBox()
        Me.prodPriceTextBox = New System.Windows.Forms.TextBox()
        Me.prodModelTextBox = New System.Windows.Forms.TextBox()
        Me.prodItemTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Group4DataSet1 = New milestone2.group4DataSet()
        Me.TAProduct = New milestone2.group4DataSetTableAdapters.ProductTableAdapter()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuantityTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.QuantityTextBox, "Enter product quantity in stock")
        Me.QuantityTextBox.Location = New System.Drawing.Point(446, 486)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.HelpProvider1.SetShowHelp(Me.QuantityTextBox, True)
        Me.QuantityTextBox.Size = New System.Drawing.Size(121, 20)
        Me.QuantityTextBox.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.QuantityTextBox, "Enter product quantity in stock")
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.CategoryComboBox, "Choose product category")
        Me.CategoryComboBox.Items.AddRange(New Object() {"Refrigeration", "Catering", "Butchery", "Bakery"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(446, 361)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.HelpProvider1.SetShowHelp(Me.CategoryComboBox, True)
        Me.CategoryComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CategoryComboBox.TabIndex = 43
        Me.ToolTip1.SetToolTip(Me.CategoryComboBox, "Choose product category")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(220, 487)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 18)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Product Quantity:"
        '
        'prodDescTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.prodDescTextBox, "Enter product description(eg. weight, capacity etc.)")
        Me.prodDescTextBox.Location = New System.Drawing.Point(446, 429)
        Me.prodDescTextBox.Name = "prodDescTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodDescTextBox, True)
        Me.prodDescTextBox.Size = New System.Drawing.Size(365, 20)
        Me.prodDescTextBox.TabIndex = 41
        Me.ToolTip1.SetToolTip(Me.prodDescTextBox, "Enter product description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(eg. capacity, weight etc.)")
        '
        'prodPriceTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.prodPriceTextBox, "Enter product price")
        Me.prodPriceTextBox.Location = New System.Drawing.Point(446, 296)
        Me.prodPriceTextBox.Name = "prodPriceTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodPriceTextBox, True)
        Me.prodPriceTextBox.Size = New System.Drawing.Size(212, 20)
        Me.prodPriceTextBox.TabIndex = 40
        Me.ToolTip1.SetToolTip(Me.prodPriceTextBox, "Enter product price")
        '
        'prodModelTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.prodModelTextBox, "Enter new product model")
        Me.prodModelTextBox.Location = New System.Drawing.Point(446, 242)
        Me.prodModelTextBox.Name = "prodModelTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodModelTextBox, True)
        Me.prodModelTextBox.Size = New System.Drawing.Size(212, 20)
        Me.prodModelTextBox.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.prodModelTextBox, "Enter product model")
        '
        'prodItemTextBox
        '
        Me.HelpProvider1.SetHelpString(Me.prodItemTextBox, "Enter new product name")
        Me.prodItemTextBox.Location = New System.Drawing.Point(446, 191)
        Me.prodItemTextBox.Name = "prodItemTextBox"
        Me.HelpProvider1.SetShowHelp(Me.prodItemTextBox, True)
        Me.prodItemTextBox.Size = New System.Drawing.Size(365, 20)
        Me.prodItemTextBox.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.prodItemTextBox, "Enter product name")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(220, 433)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Product Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 18)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Product Category:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, 297)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Product Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(220, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Product Model:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(220, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Product Item Name:"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(-3, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1241, 33)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Add New Product"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(794, 654)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 67)
        Me.Button2.TabIndex = 48
        Me.Button2.Text = "Back To Main Menu "
        Me.ToolTip1.SetToolTip(Me.Button2, "Click to go back to main menu")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(515, 654)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 67)
        Me.Button4.TabIndex = 47
        Me.Button4.Text = "Clear All"
        Me.ToolTip1.SetToolTip(Me.Button4, "Click to clear all fields")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(223, 654)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 67)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Add New Product"
        Me.ToolTip1.SetToolTip(Me.Button1, "Click to add new product")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Group4DataSet1
        '
        Me.Group4DataSet1.DataSetName = "group4DataSet"
        Me.Group4DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAProduct
        '
        Me.TAProduct.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(817, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 29)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(664, 233)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 29)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(652, 287)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 29)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(573, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 29)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(817, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 29)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(573, 474)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 29)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(951, 775)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 29)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(967, 788)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(119, 16)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "Required Fields"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(19, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(360, 20)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "Please Enter The Following Product Details:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(927, 183)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(259, 266)
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prodDescTextBox)
        Me.Controls.Add(Me.prodPriceTextBox)
        Me.Controls.Add(Me.prodModelTextBox)
        Me.Controls.Add(Me.prodItemTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Name = "AddProduct"
        Me.Text = "AddProduct"
        CType(Me.Group4DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prodDescTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prodPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prodModelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents prodItemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Group4DataSet1 As milestone2.group4DataSet
    Friend WithEvents TAProduct As milestone2.group4DataSetTableAdapters.ProductTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
