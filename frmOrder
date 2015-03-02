'Description: Order Form
'Date: 4/29/2014
Option Strict On
Public Class frmOrder

    Dim order As New OrderClass
    Dim valid As New ValidationClass
    Dim calc As New CalculationClass

    Dim mintQuantity As Integer
    Dim mdecPrice As Decimal
    Dim mdecTotal As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click


        'Purpose: open selec customer form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        frmSelectCustomers.ShowDialog()


    End Sub


    Private Sub btnSelectProduct_Click(sender As Object, e As EventArgs) Handles btnSelectProduct.Click


        'Purpose: open select product form
        'Arguments: object and event argument
        'Returns: none
        'Authors: Collin McLaughlin and Sofia Moreno Cesar
        'Date: 5/3/2014

        frmSelectProduct.ShowDialog()

    End Sub


    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click


        'Purpose: place order
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014


        'validate required fields

        If txtQuantity.Text = "" Then
            MessageBox.Show("Please enter a quantity")
            Exit Sub

        End If

        If valid.CheckInteger(txtQuantity.Text.ToString) = -1 Then
            MessageBox.Show("Invalid quantity")
            Exit Sub
        End If

        'define varaiables

        mintQuantity = CInt(txtQuantity.Text)
        mdecPrice = CDec(lblUnitPrice.Text)

        'calculate order total

        mdecTotal = calc.CalculateTotal(mintQuantity, mdecPrice)

        lblOrderTotal.Text = mdecTotal.ToString("C")



        'ask for confirmation with order total 
        'have yes or no option

        Dim result As DialogResult
        result = MessageBox.Show("Order total is $" & mdecTotal & ". Are you sure you wish to place this order?",
                                 "Place Order", MessageBoxButtons.YesNo)
        'if yes
        If result = Windows.Forms.DialogResult.Yes Then

            'customerID, productID, quantity and price
            'send order class three values via properties

            order.CustomerID = CInt(lblCustomerID.Text)
            order.Quantity = CInt(txtQuantity.Text)
            order.SKU = CInt(lblSKU.Text)

            'now add order
            order.AddOrder()
            'give a completion message

            MessageBox.Show("Order has been placed.")

        End If


        'if no, clear and set focus
        If result = Windows.Forms.DialogResult.No Then
            txtQuantity.Text = ""
            txtQuantity.Focus()
            Exit Sub
        End If


    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Purpose: clear text boxes
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        'clear all 
        lblCustomerID.Text = ""
        lblSKU.Text = ""
        lblUnitPrice.Text = ""
        txtQuantity.Text = ""
        lblOrderTotal.Text = ""


    End Sub

    Private Sub btnShowAll_Click(sender As Object, e As EventArgs) Handles btnShowAll.Click

        'Purpose: opens show all orders form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        frmShowAllOrders.ShowDialog()
    End Sub


End Class
