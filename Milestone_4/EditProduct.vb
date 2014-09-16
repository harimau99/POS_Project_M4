Public Class EditProduct

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to Cancel", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub ProductSearchTxtBx_TextChanged(sender As System.Object, e As System.EventArgs)
        TAProduct.FillByProdSearch(DS1.Product, ProductSearchTxtBx.Text)
    End Sub

    ' Method used to fill in the information
    Public Sub fill_ItemInfo(ByRef Product_ID As String)
        TAProduct.FillByProdIDEdit(DS1.Product, Product_ID)
    End Sub

    Private Sub EditProductBtn_Click(sender As System.Object, e As System.EventArgs)
        'Perform check for the item name
        If ProdNameTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter name for the item", ProdNameTextBox)
            Exit Sub
        End If

        'Perform validation for product model
        If prodModelTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter product model", prodModelTextBox)
            Exit Sub
        End If

        'Perform validation for a product price
        If Not IsNumeric(prodPriceTextBox.Text) Or prodPriceTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter the product price as a number", prodPriceTextBox)
            Exit Sub
        End If

        'Perform validation for product description
        If prodDescTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter product model", prodDescTextBox)
            Exit Sub
        End If

        'Inserting the product item into the database
        Try
            'Create the adapter
            Dim TA As New group4DataSetTableAdapters.ProductTableAdapter

            'Update the product item
            BSProduct.EndEdit()
            TA.Update(DS1.Product)

            'Close windows and return OK
            MsgBox("Product updated successfully", MsgBoxStyle.OkOnly)
            'Me.Close()

        Catch ex As Exception
            'Handle error if couldn't connect to the database
            MsgBox("Couldn't connect to the database", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub prodPriceTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub QuantityTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub EditProduct_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class