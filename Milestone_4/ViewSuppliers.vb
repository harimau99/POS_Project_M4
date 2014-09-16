Public Class ViewSuppliers

    Private Sub SupplierBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles SupplierBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BSSupplier.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS1)

    End Sub

    Private Sub ViewSuppliers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet.Supplier' table. You can move, or remove it, as needed.
        Me.TASupplier.Fill(Me.DS1.Supplier)
    End Sub

    Private Sub EditSupplierBtn_Click(sender As System.Object, e As System.EventArgs) Handles EditSupplierBtn.Click
        'Make sure the item is selected
        If Me.SupplierDataGridView.SelectedRows.Count = 0 Then
            MsgBox("Select the supplier you wish to update", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Get the supplier id of the selected supplier
        Dim supplier_id = Me.SupplierDataGridView.SelectedRows(0).Cells(0).Value

        'Create the edit windows
        Dim EditSupplierWindow As New EditSupplierDetails

        'Fill the window with information
        EditSupplierWindow.fill_SupplierInfo(supplier_id)

        If EditSupplierWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Load the information from db
            EditSupplierWindow.TASupplier.Fill(EditSupplierWindow.DS1.Supplier)
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