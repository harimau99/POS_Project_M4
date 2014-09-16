Public NotInheritable Class Employee

    Public Shared employeeID As Integer
    Public Shared userPosition As String
    Public Shared empl_name As String
    Public Shared surname As String
    Public Shared usr_name As String
    Public Shared usr_pass As String

    Public Shared Function GetUserPosition(ByVal userID As Integer) As String

        Try
            'Fill the tableAdapter with the Employee whose ID is found in the User table column of current row of the logon user
            LoginForm.TAEmployee.FillByEmployeeID(LoginForm.DS1.Employee, userID)
            For i As Integer = 0 To LoginForm.DS1.Employee.Rows.Count - 1
                userPosition = LoginForm.DS1.Employee.Rows(i)(3)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return userPosition
    End Function

    Public Shared Function GetEmployeeName(ByVal userID As Integer) As String

        Try
            LoginForm.TAEmployee.FillByEmployeeID(LoginForm.DS1.Employee, userID)
            For i As Integer = 0 To LoginForm.DS1.Employee.Rows.Count - 1
                empl_name = LoginForm.DS1.Employee.Rows(i)(1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try
        Return empl_name
    End Function

    Public Shared Function GetUserName(ByVal userID As Integer) As String

        Try
            LoginForm.TAUser.FillByUserID(LoginForm.DS1.User, userID)

            For i As Integer = 0 To LoginForm.DS1.User.Rows.Count - 1
                usr_name = LoginForm.DS1.User.Rows(i)(1)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try

        Return usr_name
    End Function

    Public Shared Function GetUserPass(ByVal userID As Integer) As String

        Try
            LoginForm.TAUser.FillByUserID(LoginForm.DS1.User, userID)

            For i As Integer = 0 To LoginForm.DS1.User.Rows.Count - 1
                usr_pass = LoginForm.DS1.User.Rows(i)(2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try
        Return usr_pass
    End Function

    Public Shared Function GetUserSurname(ByVal userID As Integer) As String

        Try
            LoginForm.TAEmployee.FillByEmployeeID(LoginForm.DS1.Employee, userID)

            For i As Integer = 0 To LoginForm.DS1.Employee.Rows.Count - 1
                surname = LoginForm.DS1.Employee.Rows(i)(2)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try
        
        Return surname
    End Function

    Public Shared Function getEmployeeID()

        Try
            If LoginForm.DS1.User.Rows.Count > 0 Then
                For i As Integer = 0 To LoginForm.DS1.User.Rows.Count - 1
                    employeeID = LoginForm.DS1.User.Rows(i)(3)
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Error!")
        End Try
        Return employeeID
    End Function

End Class
