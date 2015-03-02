'Description: Select Product Form
'Date: 4/29/2014
Option Strict On
Public Class frmSelectProduct

    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FinalProjectDatabaseOlderDataSet)

    End Sub

    Private Sub frmSelectProduct_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.TblProductsTableAdapter.Fill(Me.FinalProjectDatabaseOlderDataSet.tblProducts)
    End Sub

    Private Sub frmSelectProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FinalProjectDatabaseOlderDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.FinalProjectDatabaseOlderDataSet.tblProducts)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Purpose: return to order form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        Close()
    End Sub

    Private Sub btnAddProducts_Click(sender As Object, e As EventArgs) Handles btnAddProducts.Click

        'Purpose: open Add Products Form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        frmAddProducts.ShowDialog()
    End Sub

    Private Sub btnSelectProduct_Click(sender As Object, e As EventArgs) Handles btnSelectProduct.Click

        'Purpose: Select product and add to order form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        'get selected data and fill textbox
        Dim decPrice As Decimal

        frmOrder.lblSKU.Text = SKUTextBox.Text

        decPrice = CDec(PriceTextBox.Text)
        decPrice.ToString("c")
        frmOrder.lblUnitPrice.Text = decPrice.ToString("C")

        Close()

    End Sub
End Class
