Public Class ViewAllSales

    Private Sub CustomerTbBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        ' Me.CustomerTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMain)

    End Sub

    Private Sub ViewAllSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSMain.Product' table. You can move, or remove it, as needed.
        Me.ProductTableAdapter.Fill(Me.DSMain.Product)
        'TODO: This line of code loads data into the 'Group4DataSet.SaleOrderLineTb' table. You can move, or remove it, as needed.
        Me.SaleOrderLineTbTableAdapter.Fill(Me.DSMain.SaleOrderLineTb)
        'TODO: This line of code loads data into the 'Group4DataSet.SaleOrderTb' table. You can move, or remove it, as needed.
        Me.SaleOrderTbTableAdapter.Fill(Me.DSMain.SaleOrderTb)
        'TODO: This line of code loads data into the 'Group4DataSet.CustomerTb' table. You can move, or remove it, as needed.
        Me.TACustomer.Fill(Me.DSMain.CustomerTb)
        'TODO: This line of code loads data into the 'Group4DataSet.SaleOrderLineTb' table. You can move, or remove it, as needed.
        Me.SaleOrderLineTbTableAdapter.Fill(Me.DSMain.SaleOrderLineTb)
        'TODO: This line of code loads data into the 'Group4DataSet.SaleOrderTb' table. You can move, or remove it, as needed.
        Me.SaleOrderTbTableAdapter.Fill(Me.DSMain.SaleOrderTb)

    End Sub

    Private Sub SaleOrderTbBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.SaleOrderTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMain)

    End Sub

    Private Sub CustomerTbBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CustomerTbBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DSMain)

    End Sub

    Private Sub searchCust_TextChanged(sender As System.Object, e As System.EventArgs) Handles searchCust.TextChanged
        TACustomer.FillBy(DSMain.CustomerTb, searchCust.Text)
    End Sub

    Private Sub SaleOrderLineTbDataGridView_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles SaleOrderLineTbDataGridView.SelectionChanged
        If SaleOrderLineTbDataGridView.Rows.Count > 0 Then
            ProductTableAdapter.FillBy1(DSMain.Product, SaleOrderLineTbDataGridView.Rows(SaleOrderLineTbDataGridView.CurrentRow.Index).Cells(0).Value)
        End If
    End Sub

    Private Sub DescText_TextChanged(sender As System.Object, e As System.EventArgs) Handles DescText.TextChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure you want to go back to Main Menu?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            Me.Dispose()
        End If
    End Sub
End Class