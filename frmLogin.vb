'Description: Login form
'Date: 4/29/2014

Option Strict On
Public Class frmLogin

    Dim valid As New ValidationClass
    Dim emp As New EmployeeClass
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        'Purpose: close form
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        Close()

    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Purpose: check to see if input matches data set and log in to system
        'Arguments: object and event argument
        'Returns: none
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        'define variables
        Dim intEmpID As Integer
        Dim strPassword As String

        'boxes can't be empty
        If txtEmpID.Text = "" Then
            MessageBox.Show("Please enter Employee ID")
            Exit Sub
        End If

        If txtPassword.Text = "" Then
            MessageBox.Show("Please enter password")
            Exit Sub
        End If

        intEmpID = CInt(txtEmpID.Text)
        strPassword = txtPassword.Text


        'validate EMP as integer
        If valid.CheckInteger(intEmpID.ToString) = -1 Then
            MessageBox.Show("Bad Employee ID")
            Exit Sub
        End If


        'perform function --> check to see if it's a match
        If emp.CheckLogin(intEmpID, txtPassword.Text) = False Then
            'error message and exit
            MessageBox.Show("Incorrect ID or Password")
            Exit Sub

        Else

            'if good login, call next form

            frmOrder.ShowDialog()
            txtEmpID.Text = ""
            txtPassword.Text = ""
        End If

    End Sub
   


End Class
