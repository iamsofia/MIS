'Description: Show All Orders Form
'Date: 4/29/2014

Option Strict On
Public Class frmShowAllOrders

    Private Sub TblOrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


        'Purpose: create save item for dataset
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        Me.Validate()
        Me.TblOrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinalProjectDatabaseOlderDataSet)

    End Sub

    Private Sub frmShowAllOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'FinalProjectDatabaseOlderDataSet.tblOrders' table. You can move, or remove it, as needed.
        Me.TblOrdersTableAdapter.Fill(Me.FinalProjectDatabaseOlderDataSet.tblOrders)

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        'Purpose: returns to order form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        Close()
    End Sub
End Class
