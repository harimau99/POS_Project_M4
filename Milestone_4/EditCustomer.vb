Public Class EditCustomer

    'Method used to fill in the information
    Public Sub fill_CustomerInfo(ByRef Customer_name As String)
        TACustomer.FillByCustEdit(DS1.CustomerTb, Customer_name)
    End Sub

    Friend Sub acceptance_criteria(ByRef msg As String, ByVal txtBx As TextBox)
        MsgBox(msg, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Error")
        txtBx.Focus()
    End Sub

    Private Sub UpdateCustBtn_Click(sender As System.Object, e As System.EventArgs) Handles UpdateCustBtn.Click

        'Perform validation for a customer contact number
        If Not IsNumeric(contactNoTextbox.Text) Or contactNoTextbox.Text.Trim = "" Or contactNoTextbox.Text.Length <> 10 Then
            AcceptanceCriteria.empty_string("Enter a valid contact number", contactNoTextbox)
            Exit Sub
        End If

        'Perform validation for customer email address 
        If Not AcceptanceCriteria.email_check(emailTextBox.Text) Then
            Exit Sub
        End If

        'Perform validation for customer area code
        If AreaCodeTextBox.Text.Trim = "" Or Not IsNumeric(AreaCodeTextBox.Text) Or AreaCodeTextBox.Text.Length <> 4 Then
            AcceptanceCriteria.empty_string("Enter a valid area code", AreaCodeTextBox)
            Exit Sub
        End If

        'Inserting the product item into the database
        Try
            'Create the adapter
            Dim TA As New group4DataSetTableAdapters.CustomerTbTableAdapter

            'Update customer details
            BSCustomer.EndEdit()
            TA.Update(DS1.CustomerTb)

            'Close windows and return OK
            MsgBox("Customer details updated successfully", MsgBoxStyle.OkOnly)
            Me.Close()

        Catch ex As Exception
            'Handle error if couldn't connect to the database
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
        End Try
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub SearchCustEditTxtBx_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchCustEditTxtBx.TextChanged
        TACustomer.FillByCustSearch(DS1.CustomerTb, SearchCustEditTxtBx.Text)
    End Sub

    Private Sub contactNoTextbox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles contactNoTextbox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers!", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub faxNumTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles faxNumTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub AreaCodeTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles AreaCodeTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub SubarbTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SubarbTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If

    End Sub

    Private Sub CityTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles CityTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub custNameTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles custNameTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If
    End Sub

End Class