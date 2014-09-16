Public Class LoginForm

    Public Shared employeeID As Integer

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        login()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Quit the login", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            MainMDIForm.Close()
        End If
    End Sub

    Private Sub login()

        Try
            TAUser.FillByUserPass(DS1.User, UsernameTextBox.Text, PasswordTextBox.Text)

            If DS1.User.Rows.Count > 0 Then
                For i As Integer = 0 To DS1.User.Rows.Count - 1
                    employeeID = DS1.User.Rows(i)(3)
                Next
                MsgBox("Welcome " + Employee.GetUserName(employeeID) + " " + ". " + "Login successful")
                ProcessSale.SalesIDTextBox.Text = employeeID
                ProcessSale.EmployeeNameTextBox.Text = Employee.GetUserName(employeeID)

                MainMDIForm.AccessControl(Employee.GetUserPosition(employeeID))
                Me.Close()
                MainMDIForm.LoginToolStripMenuItem1.Enabled = False
                MainMDIForm.ChangePasswordToolStripMenuItem.Enabled = True
                MainMDIForm.Logout.Enabled = True

            Else
                'Username or password do not match
                MsgBox("Invalid username or password", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error")
                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try
    End Sub
End Class
