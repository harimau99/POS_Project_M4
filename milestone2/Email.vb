Imports System.Net.Mail
Imports System.Net.Mime

Public Class Email

    Dim TheSmtp As New SmtpClient()
    Private YourSmtpServerName As String = "mail"

    Public Sub SendThis(ByVal SubjectText As String, _
                         ByVal BodyText As String, _
                         ByVal FromAddress As String, _
                         ByVal ToAddress As String, _
                         Optional ByVal FileName As Collection = Nothing _
                         )


        Try

            Dim email As New Net.Mail.MailMessage(FromAddress, ToAddress)

            email.Subject = SubjectText
            email.Body = BodyText

            If Not FileName Is Nothing Then
                For Each Name As String In FileName
                    Dim attach As New Net.Mail.Attachment(Name) 'Includes Path
                    email.Attachments.Add(attach)
                Next
                For Each At As Attachment In email.Attachments
                    At.TransferEncoding() = Net.Mime.TransferEncoding.Base64
                Next
            End If



            TheSmtp.Credentials = New Net.NetworkCredential("username@gmail.com", "password")
            TheSmtp.Port = 587

            TheSmtp.Host = "smtp.gmail.com"

            Dim basicCredential = New System.Net.NetworkCredential("adikarampookar@gmail.com", "supersad1")
            'uncomment and add the correct e-mail address and password for smtp authentication

            TheSmtp.Credentials = New Net.NetworkCredential("adikarampookar@gmail.com", "supersad1")


            TheSmtp.UseDefaultCredentials = True

            TheSmtp.Credentials = basicCredential



            TheSmtp.EnableSsl = True

            TheSmtp.DeliveryMethod = SmtpDeliveryMethod.Network

            TheSmtp.Send(email)

            email.Attachments.Clear()

            TheSmtp = Nothing
            email = Nothing

        Catch ex As Exception
            Debug.WriteLine(ex.Message)
            Debug.Write(ex)
            Debug.Write(vbCrLf)

        End Try
    End Sub


  

    Private Sub BtnAttach_Click(sender As System.Object, e As System.EventArgs) Handles BtnAttach.Click
        Dim Response As DialogResult
        Response = Me.OpenFileDialog1.ShowDialog()

        If Response = Windows.Forms.DialogResult.OK Then
            For Each Name As String In Me.OpenFileDialog1.FileNames
                Me.ListBoxAttach.Items.Add(Name)
            Next
        End If


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        CustomerCombo.Visible = True
        SupplierCombo.Visible = False
        Label2.Visible = True
        TbToCustomer.Visible = True
        Label3.Visible = False
        TbToSupplier.Visible = False
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        SupplierCombo.Visible = True
        CustomerCombo.Visible = False
        Label2.Visible = False
        TbToCustomer.Visible = False
        Label3.Visible = True
        TbToSupplier.Visible = True

    End Sub

    Private Sub BtnSend_Click(sender As System.Object, e As System.EventArgs) Handles BtnSend.Click
        Dim BodyText As String
        Dim SubjectText As String
        Dim FromAddress As String
        Dim ToAddress As String
        Dim Filename As New Collection



        If Me.ListBoxAttach.Items.Count > 0 Then
            For Each TheItem As String In ListBoxAttach.Items
                Filename.Add(TheItem)
            Next
        End If


        SubjectText = Me.TbSubject.Text
        BodyText = Me.TbBody.Text
        FromAddress = "yashodham108@gmail.com"
        If RadioButton1.Checked = True Then
            ToAddress = Me.TbToCustomer.Text
        Else
            ToAddress = Me.TbToSupplier.Text
        End If


        SendThis(SubjectText, _
                  BodyText, _
                  FromAddress, _
                  ToAddress, _
                  Filename _
                  )

        SubjectText = ""
        BodyText = ""
        FromAddress = "yashodham108@gmail.com"
        ToAddress = ""
        MessageBox.Show("Email was sent successfully")
    End Sub

    Private Sub Email_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.TACustomer.Fill(Me.Group4DataSet1.CustomerTb)
        Me.TASupplier.Fill(Me.Group4DataSet1.Supplier)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class