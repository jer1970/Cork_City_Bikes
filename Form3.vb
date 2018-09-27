Imports System.IO
Public Class frmCreditCard
    Public subType As String
    Private Sub frmCreditCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 12
            cmbMonth.Items.Add(i)
        Next
        For i = Now.Year To Now.Year + 10
            cmbYear.Items.Add(i)
        Next
        With cmbCreditCards.Items
            .Add("Visa Credit")
            .Add("Mastercard")
            .Add("Debit Mastercard")
            .Add("Visa Debit")
            .Add("Visa Electron")
        End With
        txtTopUp.Text = 0
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        If opt3Day.Checked = False And optAnnual.Checked = False Then
            MsgBox("Select a subscription")
        ElseIf cmbCreditCards.Text.Length = 0 Then
            MsgBox("Select a Credit Card")
        ElseIf Not txtCardNumber.Text.Length = 16 Then
            MsgBox("Enter your 16 digit Card Number")
            With txtCardNumber
                .Clear()
                .Focus()
            End With
        ElseIf Not txtCvv.Text.Length = 3 Then
            MsgBox("Enter your 3 digit CVV Number")
            With txtCvv
                .Clear()
                .Focus()
            End With
        ElseIf cmbMonth.Text.Equals("Month") Or cmbYear.Text.Equals("Year") Then
            MsgBox("Enter the expiry date")
        ElseIf cmbMonth.Text < Now.Month And cmbYear.Text = Now.Year Then
            MsgBox("Enter a valid expiry date")
        ElseIf txtname.Text.Length = 0 Then
            MsgBox("Enter the Card Holder's name")
            txtname.Focus()
        ElseIf txtTopUp.Text = "" Or Convert.ToDouble(txtTopUp.Text) < 10 Then
            MsgBox("Top-up must be at least €10")
        Else
            'Using clientList As StreamWriter = New StreamWriter("..\..\Resources\clients.txt", True)
            '    With clients(numClients)
            '        clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & .regDate, True)
            '    End With
            '    clientList.Close()

            'End Using
            If opt3Day.Checked Then
                subType = "3Day"
            Else
                subType = "annual"
            End If
            MsgBox("Your account has been created. A deposit of €150 has been debited from your credit card. Please sign in to rent a bike.")
            Using clientList As StreamWriter = New StreamWriter("..\..\Resources\clients.txt", True)
                ' With clients(numClients)
                clientList.WriteLine(frmSignUp.txtFname.Text & ", " & frmSignUp.txtLname.Text & ", " & frmSignUp.cmbDay.Text & "/ " & frmSignUp.cmbMonth.Text & "/ " & frmSignUp.cmbYear.Text & ", " & frmSignUp.gender & ", " & frmSignUp.txtEmail.Text & ", " & frmSignUp.txtIntPrefix.Text & frmSignUp.txtPrefix.Text & frmSignUp.txtMobile.Text & ", " & frmSignUp.txtAddress1.Text & ", " & frmSignUp.txtAddress2.Text & ", " & frmSignUp.txtAddress3.Text & ", " & frmSignUp.cmbCounty.Text & ", " & frmSignUp.cmbCountries.Text & ", " & frmSignUp.txtPin.Text & ", " & subType & ", " & cmbCreditCards.Text & ", " & txtCardNumber.Text & ", " & txtCvv.Text & ", " & "1/" & cmbMonth.Text & "/" & cmbYear.Text & ", " & txtname.Text & ", " & FormatNumber(txtTopUp.Text) & ", " & Now.Date, True)
                'End With
                clientList.Close()

            End Using
            frmWelcome.Show()
            Me.Close()
        End If

    End Sub



    Private Sub txtCardNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCardNumber.KeyPress, txtCvv.KeyPress, txtTopUp.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        frmWelcome.Show()
    End Sub

End Class