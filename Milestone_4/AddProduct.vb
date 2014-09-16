Public Class AddProduct

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If prodItemTextBox.Text = "" Then
            MsgBox("Please enter a product item name!", vbExclamation, "Input Error")
        ElseIf prodModelTextBox.Text = "" Then
            MsgBox("Please enter a product model!", vbExclamation, "Input Error")
        ElseIf prodPriceTextBox.Text = "" Then
            MsgBox("Please enter a product price!", vbExclamation, "Input Error")
        ElseIf CategoryComboBox.Text = "" Then
            MsgBox("Please choose product category!", vbExclamation, "Input Error")
        ElseIf prodDescTextBox.Text = "" Then
            MsgBox("Please enter a product description!", vbExclamation, "Input Error")
        ElseIf QuantityTextBox.Text = "" Then
            MsgBox("Please enter a product available quantity!", vbExclamation, "Input Error")
        Else
            Try
                Me.TAProduct.InsertProd(prodItemTextBox.Text, prodModelTextBox.Text, prodPriceTextBox.Text, CategoryComboBox.SelectedItem, prodDescTextBox.Text, QuantityTextBox.Text)
                MessageBox.Show("Product Added Successfully", "Product")
            Catch ex As Exception
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub prodPriceTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles prodPriceTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub QuantityTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles QuantityTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        prodItemTextBox.Clear()
        prodModelTextBox.Clear()
        prodPriceTextBox.Clear()
        prodDescTextBox.Clear()
        QuantityTextBox.Clear()



    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class