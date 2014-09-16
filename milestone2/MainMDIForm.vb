Public Class MainMDIForm

    Friend Sub FormSetUp(ByVal ChildForm As Form)
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try

        With ChildForm
            .MdiParent = Me
            .WindowState = FormWindowState.Maximized
            .Show()

        End With
    End Sub

    Friend Sub FormClose()
        Try
            Me.ActiveMdiChild.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub AccessControl(ByVal position As String)
        If position = "Cashier" Then
            With Me
                .PaymentsToolStripMenuItem.Enabled = True
                .SalesToolStripMenuItem.Enabled = True
                .Access_Control.Enabled = True
                .ProductToolStripMenuItem.Enabled = True
                .AddNewProductToolStripMenuItem.Enabled = False
                .UpdateProductToolStripMenuItem.Enabled = False
                .SupplierToolStripMenuItem.Enabled = True
                .CustomerToolStripMenuItem1.Enabled = True
                .EmailToolStripMenuItem.Enabled = True
            End With
        Else
            With Me
                .ReportsToolStripMenuItem.Enabled = True
                .PaymentsToolStripMenuItem.Enabled = True
                .SalesToolStripMenuItem.Enabled = True
                .ProductToolStripMenuItem.Enabled = True
                .SupplierToolStripMenuItem.Enabled = True
                .Access_Control.Enabled = True
                .CustomerToolStripMenuItem1.Enabled = True
                .AddNewProductToolStripMenuItem.Enabled = True
                .UpdateProductToolStripMenuItem.Enabled = True
                .EmailToolStripMenuItem.Enabled = True
            End With
        End If
    End Sub

    Private Sub ProcessSaleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessSaleToolStripMenuItem.Click
        If ProcessSale.IsMdiChild = False Then
            FormSetUp(ProcessSale)
        Else
            MsgBox("Already on Process Sale Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewProductToolStripMenuItem.Click
        If AddProduct.IsMdiChild = False Then
            FormSetUp(AddProduct)
        Else
            MsgBox("Already on Add Product Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub AddNewSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewSupplierToolStripMenuItem.Click
        If AddSupplier.IsMdiChild = False Then
            FormSetUp(AddSupplier)
        Else
            MsgBox("Already on Add Supplier Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ViewAllSuppliersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllSuppliersToolStripMenuItem.Click
        If ViewSuppliers.IsMdiChild = False Then
            FormSetUp(ViewSuppliers)
        Else
            MsgBox("Already on View Suppliers Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ViewAllProductsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllProductsToolStripMenuItem.Click
        If ViewAllProducts.IsMdiChild = False Then
            FormSetUp(ViewAllProducts)
        Else
            MsgBox("Already on View All Products Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ViewAllSalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllSalesToolStripMenuItem.Click
        If ViewAllSales.IsMdiChild = False Then
            FormSetUp(ViewAllSales)
        Else
            MsgBox("Already on View All Sales Form", MsgBoxStyle.Exclamation)
        End If
    End Sub



    Private Sub ViewAllPaymentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewAllPaymentsToolStripMenuItem.Click
        If ViewAllPayments.IsMdiChild = False Then
            FormSetUp(ViewAllPayments)
        Else
            MsgBox("Already on View All Payment Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UpdateSupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateSupplierToolStripMenuItem.Click
        If EditSupplierDetails.IsMdiChild = False Then
            FormSetUp(EditSupplierDetails)
        Else
            MsgBox("Already on Update Supplier Form", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub UpdateProductToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateProductToolStripMenuItem.Click
        If EditProduct.IsMdiChild = False Then
            FormSetUp(EditProduct)
        Else
            MsgBox("Already on Update Product Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNewToolStripMenuItem.Click
        If AddCustomer.IsMdiChild = False Then
            FormSetUp(AddCustomer)
        Else
            MsgBox("Already on Add Customer Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ViewCustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewCustomerToolStripMenuItem1.Click
        If ViewCustomers.IsMdiChild = False Then
            FormSetUp(ViewCustomers)
        Else
            MsgBox("Already on View Customers Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UpdateCustomerToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateCustomerToolStripMenuItem1.Click
        If EditCustomer.IsMdiChild = False Then
            FormSetUp(EditCustomer)
        Else
            MsgBox("Already on Update Customer Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub LoginToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem1.Click
        If LoginForm.IsMdiChild = False Then
            FormSetUp(LoginForm)
        Else
            MsgBox("Already on Login Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to quit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Logout.Click
        With Me
            .ReportsToolStripMenuItem.Enabled = False
            .PaymentsToolStripMenuItem.Enabled = False
            .SalesToolStripMenuItem.Enabled = False
            .ProductToolStripMenuItem.Enabled = False
            .SupplierToolStripMenuItem.Enabled = False
            .CustomerToolStripMenuItem1.Enabled = False
            .EmailToolStripMenuItem.Enabled = False
            .LoginToolStripMenuItem1.Enabled = True
            .ChangePasswordToolStripMenuItem.Enabled = False
            .Logout.Enabled = False
            ProcessSale.SalesIDTextBox.Clear()
            ProcessSale.EmployeeNameTextBox.Clear()
        End With
        FormClose()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HelpToolStripMenuItem.Click
        Help.ShowHelp(Me, HelpProvider1.HelpNamespace)
    End Sub


    Private Sub CreateEmailToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CreateEmailToolStripMenuItem.Click
        If Email.IsMdiChild = False Then
            FormSetUp(Email)
        Else
            MsgBox("Already on Email Form", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub MainMDIForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackgroundImage = Me.BackgroundImage

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        If ChangePassword.IsMdiChild = False Then
            FormSetUp(ChangePassword)
        Else
            MsgBox("Already on Email Form", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class