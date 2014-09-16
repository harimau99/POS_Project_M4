Public Class EditSupplierDetails

    Friend Sub acceptance_criteria(ByRef msg As String, ByVal txtBx As TextBox)
        MsgBox(msg, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Error")
        txtBx.Focus()
    End Sub

    ' Method used to fill in the information
    Public Sub fill_SupplierInfo(ByRef Supplier_ID As String)
        TASupplier.FillBySupplierID(DS1.Supplier, Supplier_ID)
    End Sub

    Private Sub CancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub


    Private Sub EditSuppBtn_Click(sender As System.Object, e As System.EventArgs) Handles EditSuppBtn.Click

        'Perform check for the supplier name
        If suppNameTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter name for the supplier", suppNameTextBox)
            Exit Sub
        End If

        'Perform validation for a supplier contact number
        If Not IsNumeric(suppNumbTextBox.Text) Or suppNumbTextBox.Text.Trim = "" Then
            AcceptanceCriteria.empty_string("You should enter the contact details as a number", suppNumbTextBox)
            Exit Sub
        End If

        'Perform validation for customer email address 
        If Not suppEmailTextBox.Text = "" And Not AcceptanceCriteria.email_check(suppEmailTextBox.Text) Then
            Exit Sub
        End If

        'Perform validation for supplier speciality
        If SpecialityComboBox.SelectedItem = "" Then
            AcceptanceCriteria.empty_string("You should enter product model", SpecialityComboBox.SelectedItem)
            Exit Sub
        End If

        'Inserting the product item into the database
        Try
            'Create the adapter
            Dim TA As New group4DataSetTableAdapters.SupplierTableAdapter

            'Update the product item
            BSSupplier.EndEdit()
            TA.Update(DS1.Supplier)

            'Close windows and return OK
            MsgBox("Supplier details updated successfully", MsgBoxStyle.OkOnly)
            ' Me.Close()

        Catch ex As Exception
            'Handle error if couldn't connect to the database
            MsgBox("Couldn't connect to the database", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try

    End Sub

    Private Sub SupSearchTxtBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles SupSearchTxtBox.TextChanged
        TASupplier.FillBySupplierSearch(DS1.Supplier, SupSearchTxtBox.Text)
    End Sub

    Private Sub EditSupplierDetails_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class