'Description: Select Customer Form
'Date: 4/29/2014

Option Strict On
Public Class frmSelectCustomers

    Private Sub TblCustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinalProjectDatabaseOlderDataSet)

    End Sub

    Private Sub frmSelectCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjectDatabaseOlderDataSet.tblCustomers' table. You can move, or remove it, as needed.
        Me.TblCustomersTableAdapter.Fill(Me.FinalProjectDatabaseOlderDataSet.tblCustomers)

    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelect.Click

        'Purpose: add customer ID to order form and return
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014


        'take customer ID from textbox and place it on Order Form

        frmOrder.lblCustomerID.Text = CustomerIDTextBox.Text

        'close this form
        Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        'Purpose: return to order form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        Close()

    End Sub
End Class
