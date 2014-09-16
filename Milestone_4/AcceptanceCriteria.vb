Imports System.Text.RegularExpressions

Public Class AcceptanceCriteria
    Shared Sub empty_string(ByRef msg As String, ByVal txtBx As TextBox)
        MsgBox(msg, MsgBoxStyle.Critical Or MsgBoxStyle.OkCancel, "Error")
        txtBx.Focus()
    End Sub

    Shared Function email_check(ByVal email As String) As Boolean
        Dim pattern As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim emailAddressMatch As Match = Regex.Match(email, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            MsgBox("Enter a valid Email address ")
            Return False
        End If
    End Function

End Class
