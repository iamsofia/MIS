'Description: Add Products Form
Option Strict On
Public Class frmAddProducts

    Dim valid As New ValidationClass
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click


        'Purpose: validate and save new product
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        'validations - test for bad case

        'all fields required

        If SKUTextBox.Text = "" Then
            MessageBox.Show("Please enter SKU")
            Exit Sub
        End If

        If NameTextBox.Text = "" Then
            MessageBox.Show("Please enter Name")
            Exit Sub
        End If

        If DescriptionTextBox.Text = "" Then
            MessageBox.Show("Please enter Description")
            Exit Sub
        End If

        If PriceTextBox.Text = "" Then
            MessageBox.Show("Please enter Price")
            Exit Sub
        End If

        If SupplierTextBox.Text = "" Then
            MessageBox.Show("Please enter Supplier")
            Exit Sub
        End If

        If ReorderPointTextBox.Text = "" Then
            MessageBox.Show("Please enter Reorder Point")
            Exit Sub
        End If

        If ProductCategoryTextBox.Text = "" Then
            MessageBox.Show("Please enter Product Category")
            Exit Sub
        End If

        If StoreLocationTextBox.Text = "" Then
            MessageBox.Show("Please enter Store Location")
            Exit Sub
        End If


        'sku must be 5 digit number
        If valid.CheckSKU(SKUTextBox.Text) = False Then
            MessageBox.Show("SKU invalid")
            Exit Sub
        End If

        'price must be + decimal
        If valid.CheckDecimal(PriceTextBox.Text) = -1 Then
            MessageBox.Show("Price Invalid")
            Exit Sub
        End If

        'reorder point must be + int > 2
        If valid.CheckReorderPt(ReorderPointTextBox.Text) = -1 Then
            MessageBox.Show("Reorder Point invalid")
            Exit Sub
        End If


            'Store location must be an upper case letter A – I.
            If valid.CheckCar(StoreLocationTextBox.Text) = False Then
                MessageBox.Show("Store Location invalid")
                Exit Sub
            End If


            Try
                Me.Validate()
                Me.TblProductsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.FinalProjectDatabaseOlderDataSet)

            Catch ex As Exception

                MessageBox.Show("database error - record not saved")

            End Try

    End Sub
  
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Purpose: Add new product and return to order form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014


        'return to order form
        Close()
    End Sub

End Class
