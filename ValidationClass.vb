'Description: Validation Class
'Date: 4/29/2014

Option Strict On
Public Class ValidationClass
    Public Function CheckDecimal(ByVal strInput As String) As Decimal

        'Purpose: check to see if input is decimal
        'Arguments: object and event argument
        'Returns: -1 if input not decimal, input as result if it is
        'Authors: Rick Byars
        'Date: 5/3/2014


        'declare variables
        Dim decResult As Decimal

        'test for numeric
        Try
            decResult = Convert.ToDecimal(strInput)
        Catch ex As Exception
            'value is not numeric, so return -1 (flag that something is wrong)
            Return -1
        End Try

        'test for greater than zero
        If decResult <= 0 Then
            'value is less than or equal, so return -1 (flag that something is wrong)
            Return -1
        End If

        'if the code gets this far, the input is valid, so return the result
        Return decResult
    End Function

    Public Function CheckInteger(ByVal strInput As String) As Integer

        'Purpose: check to see if input is integer
        'Arguments: object and event argument
        'Returns: -1 if input not integer, input as result if it is
        'Authors: Rick Byars
        'Date: 5/3/2014

        'declare variables
        Dim intResult As Integer

        'test for numeric
        Try
            intResult = Convert.ToInt32(strInput)
        Catch ex As Exception
            'value is not numeric, so return -1 (flag that something is wrong)
            Return -1
        End Try

        'test for greater than zero
        If intResult <= 0 Then
            'value is less than or equal, so return -1 (flag that something is wrong)
            Return -1
        End If

        'if the code gets this far, the input is valid, so return the result
        Return intResult
    End Function

    Public Function CheckReorderPt(ByVal strInput As String) As Integer

        'Purpose: check to see if reoder point input is valid
        'Arguments: object and event argument
        'Returns: input as result if input is integer greater than 2, -1 if it is not
        'Author: Sofia Moreno Cesar
        'Date: 5/3/2014

        'declare variables
        Dim intResult As Integer

        'test for numeric
        Try
            intResult = Convert.ToInt32(strInput)
        Catch ex As Exception
            'value is not numeric, so return -1 (flag that something is wrong)
            Return -1
        End Try

        'test for greater than zero
        If intResult < 2 Then
            'value is less than or equal, so return -1 (flag that something is wrong)
            Return -1
        End If

        'if the code gets this far, the input is valid, so return the result
        Return intResult
    End Function

    Public Function CheckSKU(strIN As String) As Boolean
        'Purpose: validate Inventory ID
        'Arguments: user input for inventory  as a string
        'Returns: false if the input is not valid
        'Author: Sofia Moreno Cesar
        'Date: 5/1/2014

        'strIN has to be 5 digit positive integer
        'check length 

        If strIN.Length <> 5 Then
            Return False
        End If

        'check if positive

        If CheckInteger(strIN) = -1 Then
            Return False

        Else
            Return True
        End If

    End Function

    Public Function CheckCar(ByVal strIN As String) As Boolean
        ' checks to see if manufacturer is valid
        ' input:  any string
        ' returns: boolean - true if manufacturer matches the list below
        '                    false if manufacturer does not match
        'Author: Professor Byars
        'Date: 4/16/2014

        Select Case strIN.ToUpper
            Case "A".ToUpper
            Case "B".ToUpper
            Case "C".ToUpper
            Case "D".ToUpper
            Case "E".ToUpper
            Case "F".ToUpper
            Case "G".ToUpper
            Case "H".ToUpper
            Case "I".ToUpper
            Case Else
                Return False
        End Select
        Return True
    End Function

End Class
