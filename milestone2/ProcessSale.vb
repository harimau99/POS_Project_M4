Public Class ProcessSale

    Public Shared employeeID As Integer = Employee.getEmployeeID()

    Dim datetime As Date = Now()
    Dim choice As String
    Dim SaleOrderNo As Integer
    Dim delivery As Decimal

    Public Function GetTotal() As Double
        Dim Sum As Double
        For i As Integer = 0 To DSMain.Invoice.Rows.Count - 1
            Sum += DSMain.Invoice.Rows(i)("SubTotal")
        Next
        Return Sum
    End Function

    Public Function GetVAT() As Double
        Return GetTotal() * 0.14
    End Function


    Private Sub ProcessSale_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMain.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DSMain.Product)
        'TODO: This line of code loads data into the 'DSMain.CustomerTb' table. You can move, or remove it, as needed.
        Me.TACustomer.Fill(Me.DSMain.CustomerTb)
        'TODO: This line of code loads data into the 'DSMain.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DSMain.Product)
        'TODO: This line of code loads data into the 'DS1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DSMain.Product)
        'TODO: This line of code loads data into the 'DS1.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DSMain.Product)
        TACustomer.Fill(DSMain.CustomerTb)
        TAEmployee.Fill(DSMain.Employee)

        'SalesIDTextBox.Text = employeeID
        'EmployeeNameTextBox.Text = Employee.GetUserName(employeeID)

    End Sub


    Private Sub SearchName_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchName.TextChanged
        TACustomer.FillBy(DSMain.CustomerTb, SearchName.Text)
    End Sub

    Private Sub CustIDCombo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CustIDCombo.SelectedIndexChanged
        'BSCustomer.RemoveFilter()
        ' DGVCust.Visible = False
        'SearchName.Clear()
    End Sub

    Private Sub SearchBtn_Click(sender As System.Object, e As System.EventArgs)
        'DGVCust.Visible = True
        ' BSCustomer.RemoveFilter()
        'BSCustomer.Filter = "Cust_Name like '%" & SearchName.Text & "%'"
    End Sub

    Private Sub SearchProduct_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchProduct.TextChanged
        If SearchProduct.Text <> "" Then
            ProductDGV.Visible = True
            ProductTableAdapter.FillBy(DSMain.Product, SearchProduct.Text)
        Else
            ProductDGV.Visible = False
        End If

    End Sub

    Private Sub DelChargeBtn_Click(sender As System.Object, e As System.EventArgs) Handles DelChargeBtn.Click

        Dim km As Integer
        Dim K As String
        K = KilometerText.Text
        Dim charge As Decimal = 15D

        If YesRadioButton.Checked Then
            choice = "Yes"
            Try
                km = Integer.Parse(KilometerText.Text)
                delivery = km * charge
                delChargeText.Text = delivery.ToString("C")
            Catch kmException As FormatException
                MessageBox.Show("Kilometer must be a numeric integer value", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With KilometerText
                    .Focus()
                    .SelectAll()
                End With
            Catch ex As Exception
                MessageBox.Show("There is an error in input of data")
            End Try
        ElseIf NoRadioButton.Checked Then
            choice = "No"
            delivery = 0D
            delChargeText.Text = delivery.ToString("C")
            MsgBox("You have chosen to decline delivery and will not be charged")
        ElseIf NoRadioButton.Checked And K.Length <> 0 Then
            MsgBox("You opted to not choose delivery and cannot calculate a charge")

        Else : MsgBox("You have not chosen any delivery option")
        End If

    End Sub

    Private Sub RemoveBtn_Click(sender As System.Object, e As System.EventArgs) Handles RemoveBtn.Click
        DSMain.Invoice.Rows.RemoveAt(InvoiceDGV.CurrentRow.Index)
        TotalTextBox.Text = FormatCurrency(GetTotal())
    End Sub

    Private Sub addToInvoiceBtn_Click(sender As System.Object, e As System.EventArgs) Handles addToInvoiceBtn.Click
        Dim DR As DataRow

        If YesRadioButton.Checked = False And NoRadioButton.Checked = False Then
            MsgBox("You have not chosen a delivery option!", vbExclamation)

        ElseIf ProductDGV.Rows.Count - 1 > 0 Then
            For i As Integer = 0 To ProductDGV.Rows.Count - 1
                If ProductDGV.Rows(i).Cells(7).Value > 0 Then
                    If ProductDGV.Rows(i).Cells(7).Value <= ProductDGV.Rows(i).Cells(6).Value Then
                        Dim Duplicate As Boolean = False
                        DR = DSMain.Invoice.NewRow
                        DR("ProductID") = ProductDGV.Rows(i).Cells(0).Value
                        DR("ProductItem") = ProductDGV.Rows(i).Cells(1).Value
                        DR("ProductModel") = ProductDGV.Rows(i).Cells(2).Value
                        DR("ProductUnitPrice") = ProductDGV.Rows(i).Cells(3).Value
                        DR("ProductDescription") = ProductDGV.Rows(i).Cells(5).Value
                        DR("Quantity") = ProductDGV.Rows(i).Cells(7).Value
                        DR("SubTotal") = ProductDGV.Rows(i).Cells(3).Value * ProductDGV.Rows(i).Cells(7).Value

                        For j As Integer = 0 To DSMain.Invoice.Rows.Count - 1
                            If DSMain.Invoice.Rows(j)("ProductID") = DR("ProductID") Then
                                Duplicate = True
                                DSMain.Invoice.Rows(j)("Quantity") += DR("Quantity")
                                DSMain.Invoice.Rows(j)("SubTotal") = DSMain.Invoice.Rows(j)("Quantity") * DSMain.Invoice.Rows(j)("ProductUnitPrice")
                                TotalTextBox.Text = FormatCurrency(GetTotal() + delivery)
                            End If
                        Next
                        ProductDGV.Rows(i).Cells(6).Value = ProductDGV.Rows(i).Cells(6).Value - ProductDGV.Rows(i).Cells(7).Value
                        ProductTableAdapter.UpdateQuery(ProductDGV.Rows(i).Cells(6).Value, ProductDGV.Rows(i).Cells(0).Value)
                        If Not Duplicate Then
                            DSMain.Invoice.AddInvoiceRow(DR)
                        End If
                    ElseIf ProductDGV.Rows(i).Cells(7).Value > ProductDGV.Rows(i).Cells(6).Value Then
                        MessageBox.Show("There is not enough stock for the available item", "Low Stock Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If

                End If
            Next
            Else
                MsgBox("No Items Selected")
            End If
            SearchProduct.Text = ""


    End Sub

    Public Sub ClearInvoiceProductRows()
        DSMain.Invoice.Rows.Clear()
        DSMain.Product.Rows.Clear()
        DateTextbox.Clear()
        PayAmountText.Clear()
    End Sub

    Public Sub ResetCustSearch()
        BSCustomer.RemoveFilter()
        DGVCust.Visible = False
        SearchName.Clear()
        delChargeText.Clear()
        KilometerText.Clear()

    End Sub

    Private Sub ClearBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearBtn.Click
        ClearInvoiceProductRows()
        ResetCustSearch()
    End Sub

    Private Sub FinSaleBtn_Click(sender As System.Object, e As System.EventArgs) Handles FinSaleBtn.Click

        If DSMain.Invoice.Rows.Count > 0 Then
            SaleOrderNo = TASaleOrder.InsertSale(datetime, choice, delChargeText.Text, TotalTextBox.Text, CustID.Text, SalesIDTextBox.Text)


            For i As Integer = 0 To DSMain.Invoice.Rows.Count - 1
                Dim DR As DataRow
                DR = DSMain.SaleOrderLineTb.NewRow
                DR("Product_ID") = DSMain.Invoice.Rows(i)("ProductID")
                DR("Sale_Order_ID") = SaleOrderNo
                DR("SaleOrder_Quantity") = DSMain.Invoice.Rows(i)("Quantity")
                DR("UnitPrice") = DSMain.Invoice.Rows(i)("ProductUnitPrice")
                DR("SubTotal") = DSMain.Invoice.Rows(i)("SubTotal")
                DSMain.SaleOrderLineTb.AddSaleOrderLineTbRow(DR)
            Next

            TASaleOrderLine.Update(DSMain.SaleOrderLineTb)
            MsgBox("Sale to Customer " & CustName.Text & " Finalised for Amount of " & vbCrLf & FormatCurrency(GetTotal()) + delivery)
            PaymentGroupBox.Visible = True
            DateTextbox.Text = datetime
            PayAmountText.Text = TotalTextBox.Text
            'ClearInvoiceProductRows()
            'ResetCustSearch()
        Else
            MsgBox("No Sale has been Recorded - Please Select Sale Items")
        End If

    End Sub

    Private Sub InvoiceDGV_CellValueChanged(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        If DSMain.Invoice.Rows.Count > 1 Then
            DSMain.Invoice.Rows(e.RowIndex)("SubTotal") = DSMain.Invoice.Rows(e.RowIndex)("Quantity") * DSMain.Invoice.Rows(e.RowIndex)("ProductUntiPrice")

            TotalTextBox.Text = FormatCurrency(GetTotal()) + delivery
        End If

    End Sub

    Private Sub InvoiceDGV_RowsAdded(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs)
        TotalTextBox.Text = FormatCurrency(GetTotal())
    End Sub

    'Private Sub NoRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs)
    '   MsgBox("Note that you have opted to not choose our delivery service")
    ' End Sub

    ' Private Sub YesRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles YesRadioButton.CheckedChanged
    ' MsgBox("Please enter the number of kilometers to the destination")
    ' End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub InvoiceDGV_CellValueChanged_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles InvoiceDGV.CellValueChanged
        If DSMain.Invoice.Rows.Count > 1 Then
            DSMain.Invoice.Rows(e.RowIndex)("SubTotal") = DSMain.Invoice.Rows(e.RowIndex)("Quantity") * DSMain.Invoice.Rows(e.RowIndex)("ProductUntiPrice")

            TotalTextBox.Text = FormatCurrency(GetTotal())
        End If
    End Sub

    Private Sub InvoiceDGV_RowsAdded_1(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles InvoiceDGV.RowsAdded
        TotalTextBox.Text = FormatCurrency(GetTotal())
    End Sub

    Private Sub NoRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles NoRadioButton.CheckedChanged
        Dim delivery As Decimal = 0D
        KilometerText.Clear()
        delChargeText.Text = delivery.ToString("C")
    End Sub


    Private Sub GetInvoiceBtn_Click(sender As System.Object, e As System.EventArgs) Handles GetInvoiceBtn.Click
        Invoice.Show()
    End Sub

    Private Sub RecPayBtn_Click(sender As System.Object, e As System.EventArgs) Handles RecPayBtn.Click
        Dim payment As Integer
        Try
            payment = (TAPayment.ScalarPayment()) + 1
        Catch ex As Exception
            payment = 1
        End Try


        Try
            Me.TAPayment.InsertPayment(payment, DateTextbox.Text, PayAmountText.Text, PayTypeCombo.SelectedItem, SaleOrderNo, CustID.Text)
            MessageBox.Show("Payment Recorded Successfully", "Payment")
        Catch ex As Exception
            MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SearchName_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SearchName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub KilometerText_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles KilometerText.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub


End Class