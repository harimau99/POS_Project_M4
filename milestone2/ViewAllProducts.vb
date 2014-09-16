Public Class ViewAllProducts

    Private Sub ProductBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.ProductBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet)

    End Sub

    Private Sub ViewAllProducts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.Group4DataSet.Product)

    End Sub

    Private Sub UpdateProdBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateProdBtn.Click
        'Make sure the item is selected
        If Me.ProductDataGridView.SelectedRows.Count = 0 Then
            MsgBox("Select the product you wish to edit", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Get the customer id of the selected supplier
        Dim product_id = Me.ProductDataGridView.SelectedRows(0).Cells(0).Value

        'Create the edit windows
        Dim EditProductWindow As New EditProduct

        'Fill the window with information
        EditProductWindow.fill_ItemInfo(product_id)

        If EditProductWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Load the information from db
            EditProductWindow.TAProduct.Fill(EditProductWindow.DS1.Product)
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