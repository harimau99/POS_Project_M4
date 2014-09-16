Public Class ViewCustomers

    Private Sub CustomerTbBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles CustomerTbBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Group4DataSet)

    End Sub

    Private Sub ViewCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet.CustomerTb' table. You can move, or remove it, as needed.
        Me.CustomerTbTableAdapter.Fill(Me.Group4DataSet.CustomerTb)

    End Sub

    Private Sub UpdateViewCustBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateViewCustBtn.Click
        'Make sure the item is selected
        If Me.CustomerTbDataGridView.SelectedRows.Count = 0 Then
            MsgBox("Select the customer you wish to edit", MsgBoxStyle.Information)
            Exit Sub
        End If

        'Get the customer id of the selected supplier
        Dim customer_id = Me.CustomerTbDataGridView.SelectedRows(0).Cells(0).Value

        'Create the edit windows
        Dim EditCustomerWindow As New EditCustomer

        'Fill the window with information
        EditCustomerWindow.fill_CustomerInfo(customer_id)

        If EditCustomerWindow.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Load the information from db
            EditCustomerWindow.TACustomer.Fill(EditCustomerWindow.DS1.CustomerTb)
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