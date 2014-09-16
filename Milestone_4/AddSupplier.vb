Public Class AddSupplier

    Private Sub AddSuppBtn_Click(sender As System.Object, e As System.EventArgs) Handles AddSuppBtn.Click
        Dim contactNum = suppNumbTextBox.Text

        If suppNameTextBox.Text = "" Then
            MsgBox("Please enter a supplier name!", vbExclamation, "Input Error")
        ElseIf suppNumbTextBox.Text = "" Or contactNum.Length() < 10 Then
            MsgBox("Please enter a 10 digit supplier contact number!", vbExclamation, "Input Error")
        ElseIf SpecialityComboBox.Text = "" Then
            MsgBox("Please enter a supplier speciality!", vbExclamation, "Input Error")
        Else
            Try
                Me.TASupplier.InsertSupp(suppNameTextBox.Text, suppNumbTextBox.Text, suppEmailTextBox.Text, SpecialityComboBox.SelectedItem)
                MessageBox.Show("Supplier Added Successfully", "Supplier")
            Catch ex As Exception
                MessageBox.Show("Please fill in all the required fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub suppNumbTextBox_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles suppNumbTextBox.KeyPress
        If (Asc(e.KeyChar) <> 8) Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
                MsgBox("Please input only numbers")
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

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        suppNameTextBox.Clear()
        suppNumbTextBox.Clear()
        suppEmailTextBox.Clear()

    End Sub
End Class