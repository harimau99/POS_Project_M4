Public Class AddCustomer

    
    Private Sub AddcustBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddcustBtn.Click

        'If custNameTextBox.Text = "" Or custIDNumTextBox.Text = "" Or contactNoTextbox.Text = "" Or physicalTextBox.Text = "" Or SubarbTextBox.Text = "" Or cityTextBox.Text = "" Or areaCodeTextBox.Text Then
        Dim custID As String = custIDNumTextBox.Text
        Dim contactNum As String = contactNoTextbox.Text
        Dim area = areaCodeTextBox.Text

        If custNameTextBox.Text = "" Then
            MsgBox("Please enter a customer's name!", vbExclamation, "Input Error")
        ElseIf custIDNumTextBox.Text = "" Or custID.Length() < 13 Then
            MsgBox("Please enter a 13 digit valid customer ID number!", vbExclamation, "Input Error")
        ElseIf contactNoTextbox.Text = "" Or contactNum.Length() < 10 Then
            MsgBox("Please enter a 10 digit customer contact number!", vbExclamation, "Input Error")
        ElseIf physicalTextBox.Text = "" Then
            MsgBox("Please enter a customer's physical address!", vbExclamation, "Input Error")
        ElseIf SubarbTextBox.Text = "" Then
            MsgBox("Please enter a customer's suburb address!", vbExclamation, "Input Error")
        ElseIf cityTextBox.Text = "" Then
            MsgBox("Please enter a customer's city!", vbExclamation, "Input Error")
        ElseIf areaCodeTextBox.Text = "" Or area.Length() < 4 Then
            MsgBox("Please enter a 4 digit customer area code!", vbExclamation, "Input Error")
        Else
            Try
                Me.TACustomer.InsertCust(custNameTextBox.Text, custIDNumTextBox.Text, contactNoTextbox.Text, faxNumTextBox.Text, emailTextBox.Text, physicalTextBox.Text, SubarbTextBox.Text, cityTextBox.Text, areaCodeTextBox.Text)
                MessageBox.Show("Customer Added Successfully", "Customer")
            Catch ex As Exception
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If



    End Sub

    Private Sub ClearBtn_Click(sender As System.Object, e As System.EventArgs) Handles ClearBtn.Click
        custNameTextBox.Clear()
        custIDNumTextBox.Clear()
        contactNoTextbox.Clear()
        faxNumTextBox.Clear()
        emailTextBox.Clear()
        physicalTextBox.Clear()
        SubarbTextBox.Clear()
        cityTextBox.Clear()
        areaCodeTextBox.Clear()
    End Sub

    Private Sub CancelBtn_Click(sender As System.Object, e As System.EventArgs) Handles CancelBtn.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub faxNumTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles faxNumTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers")
            End If
        End If
    End Sub

    Private Sub contactNoTextbox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles contactNoTextbox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub custIDNumTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles custIDNumTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
            End If
        End If
    End Sub

    Private Sub areaCodeTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles areaCodeTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers", vbExclamation)
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

    Private Sub SubarbTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles SubarbTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If
    End Sub

    Private Sub cityTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles cityTextBox.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Or (Asc(e.KeyChar) = 32)) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
                MsgBox("Please enter only characters!", vbExclamation, "Input Error")
            End If
        End If
    End Sub
End Class