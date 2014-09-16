Public Class ChangePassword
    ' User cancels pwd change
    Private Sub CancelPwdChangeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelPwdChangeButton.Click
        Me.Close()
    End Sub

    ' User wants to change the password
    Private Sub ChangePwdButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePwdButton.Click

        Try
            ' Validate the new password
            If NewPwdTextBox.Text = "" Then
                MsgBox("You should enter a password", MsgBoxStyle.Critical)
                NewPwdTextBox.Focus()
                Exit Sub
            End If

            If NewPwdTextBox.Text <> ConfirmPwdTextBox.Text Then
                MsgBox("Passwords do not match", MsgBoxStyle.Critical)
                ConfirmPwdTextBox.Focus()
                Exit Sub
            End If

            ' Get the original password
            Dim user_name As String = Employee.GetUserName(LoginForm.employeeID)
            Dim user_pass As String = Employee.GetUserPass(LoginForm.employeeID)

            Dim TA As New group4DataSetTableAdapters.UserTableAdapter

            If user_pass <> OldPwdTextBox.Text Then
                MsgBox("Old password is incorrect!", MsgBoxStyle.Critical)
                OldPwdTextBox.Focus()
                Exit Sub
            End If

            ' Update the password in the database.
            Dim Rc As Integer = TA.UpdateDbPasswd(NewPwdTextBox.Text, user_name)
            If Rc = 0 Then
                MsgBox("Password not updated.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
                Exit Sub
            Else
                MessageBox.Show("Password updated successful.")
                Me.Close()
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try

    End Sub
End Class