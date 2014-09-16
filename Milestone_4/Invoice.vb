Public Class Invoice

    
    Private Sub Invoice_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        DateTextBox.Text = Now()
        CustIdTextBox.Text = ProcessSale.CustID.Text
        CustNameTextBox.Text = ProcessSale.CustName.Text
        With DGVInvoice
            .DataSource = ProcessSale.InvoiceDGV.DataSource
            .Columns(3).DefaultCellStyle.Format = "c2"
            .Columns(6).DefaultCellStyle.Format = "c2"
            .Columns(5).Width = 60
            .Columns(2).Width = 80
            .Columns(3).Width = 95
            .Columns(4).Width = 150
            .Columns(0).Visible = False
            .Refresh()
        End With

        

        TotalTextBox.Text = ProcessSale.TotalTextBox.Text

        TextBox8.Text = ProcessSale.GetVAT()
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles PrintBtn.Click
        PrintBtn.Visible = False
        BackBtn.Visible = False
        Me.PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        Me.PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.Scrollable)
        PrintBtn.Visible = True
        BackBtn.Visible = True
    End Sub

    Private Sub BackBtn_Click(sender As System.Object, e As System.EventArgs) Handles BackBtn.Click
        Me.Close()
        ProcessSale.Show()
    End Sub

    
End Class