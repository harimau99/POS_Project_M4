Public Class ViewAllPayments

    Private Sub PaymentTbBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.PaymentTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS1)

    End Sub

    Private Sub ViewAllPayments_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Group4DataSet.PaymentTb' table. You can move, or remove it, as needed.
        Me.PaymentTbTableAdapter.Fill(Me.DS1.PaymentTb)
        'TODO: This line of code loads data into the 'Group4DataSet.CustomerTb' table. You can move, or remove it, as needed.
        Me.TACustomer.Fill(Me.DS1.CustomerTb)
        'TODO: This line of code loads data into the 'Group4DataSet.PaymentTb' table. You can move, or remove it, as needed.
        Me.PaymentTbTableAdapter.Fill(Me.DS1.PaymentTb)

    End Sub

    Private Sub CustomerTbBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CustomerTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DS1)

    End Sub

    Private Sub SearchName_TextChanged(sender As System.Object, e As System.EventArgs) Handles SearchName.TextChanged
        TACustomer.FillBy(DS1.CustomerTb, SearchName.Text)
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class