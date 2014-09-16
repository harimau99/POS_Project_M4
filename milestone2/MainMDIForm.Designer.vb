<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMDIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMDIForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Access_Control = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllSuppliersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessSaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAllPaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewCustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateCustomerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = CType(resources.GetObject("MenuStrip1.BackgroundImage"), System.Drawing.Image)
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Access_Control, Me.SupplierToolStripMenuItem, Me.ProductToolStripMenuItem, Me.SalesToolStripMenuItem, Me.PaymentsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.CustomerToolStripMenuItem1, Me.EmailToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1236, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Access_Control
        '
        Me.Access_Control.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.ChangePasswordToolStripMenuItem, Me.Logout, Me.ExitToolStripMenuItem})
        Me.Access_Control.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Access_Control.Name = "Access_Control"
        Me.Access_Control.Size = New System.Drawing.Size(142, 24)
        Me.Access_Control.Text = "Access Control"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(222, 24)
        Me.LoginToolStripMenuItem1.Text = "Login"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Enabled = False
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'Logout
        '
        Me.Logout.Enabled = False
        Me.Logout.Name = "Logout"
        Me.Logout.Size = New System.Drawing.Size(222, 24)
        Me.Logout.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SupplierToolStripMenuItem
        '
        Me.SupplierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewSupplierToolStripMenuItem, Me.ViewAllSuppliersToolStripMenuItem, Me.UpdateSupplierToolStripMenuItem})
        Me.SupplierToolStripMenuItem.Enabled = False
        Me.SupplierToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SupplierToolStripMenuItem.Name = "SupplierToolStripMenuItem"
        Me.SupplierToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.SupplierToolStripMenuItem.Text = "Supplier"
        '
        'AddNewSupplierToolStripMenuItem
        '
        Me.AddNewSupplierToolStripMenuItem.Name = "AddNewSupplierToolStripMenuItem"
        Me.AddNewSupplierToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.AddNewSupplierToolStripMenuItem.Text = "Add New Supplier"
        '
        'ViewAllSuppliersToolStripMenuItem
        '
        Me.ViewAllSuppliersToolStripMenuItem.Name = "ViewAllSuppliersToolStripMenuItem"
        Me.ViewAllSuppliersToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.ViewAllSuppliersToolStripMenuItem.Text = "View All Suppliers"
        '
        'UpdateSupplierToolStripMenuItem
        '
        Me.UpdateSupplierToolStripMenuItem.Name = "UpdateSupplierToolStripMenuItem"
        Me.UpdateSupplierToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.UpdateSupplierToolStripMenuItem.Text = "Update Supplier"
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewProductToolStripMenuItem, Me.ViewAllProductsToolStripMenuItem, Me.UpdateProductToolStripMenuItem})
        Me.ProductToolStripMenuItem.Enabled = False
        Me.ProductToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.ProductToolStripMenuItem.Text = "Product"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.AddNewProductToolStripMenuItem.Text = "Add New Product"
        '
        'ViewAllProductsToolStripMenuItem
        '
        Me.ViewAllProductsToolStripMenuItem.Name = "ViewAllProductsToolStripMenuItem"
        Me.ViewAllProductsToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.ViewAllProductsToolStripMenuItem.Text = "View All Products"
        '
        'UpdateProductToolStripMenuItem
        '
        Me.UpdateProductToolStripMenuItem.Name = "UpdateProductToolStripMenuItem"
        Me.UpdateProductToolStripMenuItem.Size = New System.Drawing.Size(232, 24)
        Me.UpdateProductToolStripMenuItem.Text = "Update Product"
        '
        'SalesToolStripMenuItem
        '
        Me.SalesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessSaleToolStripMenuItem, Me.ViewAllSalesToolStripMenuItem})
        Me.SalesToolStripMenuItem.Enabled = False
        Me.SalesToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesToolStripMenuItem.Name = "SalesToolStripMenuItem"
        Me.SalesToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.SalesToolStripMenuItem.Text = "Sales"
        '
        'ProcessSaleToolStripMenuItem
        '
        Me.ProcessSaleToolStripMenuItem.Name = "ProcessSaleToolStripMenuItem"
        Me.ProcessSaleToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.ProcessSaleToolStripMenuItem.Text = "Process Sale"
        '
        'ViewAllSalesToolStripMenuItem
        '
        Me.ViewAllSalesToolStripMenuItem.Name = "ViewAllSalesToolStripMenuItem"
        Me.ViewAllSalesToolStripMenuItem.Size = New System.Drawing.Size(202, 24)
        Me.ViewAllSalesToolStripMenuItem.Text = "View All Sales"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAllPaymentsToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Enabled = False
        Me.PaymentsToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(104, 24)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'ViewAllPaymentsToolStripMenuItem
        '
        Me.ViewAllPaymentsToolStripMenuItem.Name = "ViewAllPaymentsToolStripMenuItem"
        Me.ViewAllPaymentsToolStripMenuItem.Size = New System.Drawing.Size(239, 24)
        Me.ViewAllPaymentsToolStripMenuItem.Text = "View All Payments"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.Enabled = False
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'CustomerToolStripMenuItem1
        '
        Me.CustomerToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.ViewCustomerToolStripMenuItem1, Me.UpdateCustomerToolStripMenuItem1})
        Me.CustomerToolStripMenuItem1.Enabled = False
        Me.CustomerToolStripMenuItem1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerToolStripMenuItem1.Name = "CustomerToolStripMenuItem1"
        Me.CustomerToolStripMenuItem1.Size = New System.Drawing.Size(106, 24)
        Me.CustomerToolStripMenuItem1.Text = "Customer"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(247, 24)
        Me.AddNewToolStripMenuItem.Text = "Add New Customer"
        '
        'ViewCustomerToolStripMenuItem1
        '
        Me.ViewCustomerToolStripMenuItem1.Name = "ViewCustomerToolStripMenuItem1"
        Me.ViewCustomerToolStripMenuItem1.Size = New System.Drawing.Size(247, 24)
        Me.ViewCustomerToolStripMenuItem1.Text = "View Customer"
        '
        'UpdateCustomerToolStripMenuItem1
        '
        Me.UpdateCustomerToolStripMenuItem1.Name = "UpdateCustomerToolStripMenuItem1"
        Me.UpdateCustomerToolStripMenuItem1.Size = New System.Drawing.Size(247, 24)
        Me.UpdateCustomerToolStripMenuItem1.Text = "Update Customer"
        '
        'EmailToolStripMenuItem
        '
        Me.EmailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateEmailToolStripMenuItem})
        Me.EmailToolStripMenuItem.Enabled = False
        Me.EmailToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailToolStripMenuItem.Name = "EmailToolStripMenuItem"
        Me.EmailToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.EmailToolStripMenuItem.Text = "Email"
        '
        'CreateEmailToolStripMenuItem
        '
        Me.CreateEmailToolStripMenuItem.Name = "CreateEmailToolStripMenuItem"
        Me.CreateEmailToolStripMenuItem.Size = New System.Drawing.Size(191, 24)
        Me.CreateEmailToolStripMenuItem.Text = "Create Email"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "C:\Users\210522543\Desktop\WithChange\Milestone_3_Beta_v0.10.2\milestone2\Help Fi" & _
    "les\Milestone_3_Beta_v0.10.chm"
        '
        'MainMDIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1236, 870)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMDIForm"
        Me.Text = "MainMDIForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Access_Control As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllSuppliersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateSupplierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllProductsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateProductToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessSaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewAllPaymentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewCustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateCustomerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Logout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
