Imports System.IO
Public Class frmWelcome
    Dim attempt As Int16 = 0
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPinEnter.Hide()
        txtPinEnter.Hide()
        lblPassword.Hide()
        txtpassword.Hide()
        btnStaffLogin.Hide()
        btnLogin.Enabled = False
        btnLogin.Hide()
        'Dim i As Single
        'Dim details As String = ""

        'For i = 1001 To 1015
        '    details += i & ", True, "
        'Next
        '' MsgBox(details)
        'Using clientList As StreamWriter = New StreamWriter("..\..\Resources\stations.txt", True)
        '    clientList.WriteLine(details, True)

        'End Using
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Me.Hide()
        frmSignUp.Show()
    End Sub

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        lblPinEnter.Show()
        txtPinEnter.Show()
        btnLogin.Enabled = True
        btnLogin.Show()
        txtPinEnter.Focus()
    End Sub

    Private Sub txtPinEnter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPinEnter.KeyPress
        If btnLogin.Enabled Then
            If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'check the pin
        If txtPinEnter.Text > 9999 Or txtPinEnter.Text < 1000 Then
            MsgBox("Invalid pin. Try again")
        Else
            Using clientList As StreamReader = New StreamReader("..\..\resources\clients.txt")
                While Not clientList.EndOfStream
                    Dim fullDetails As String = clientList.ReadLine
                    Dim clientSplit() As String = fullDetails.Split(", ")
                    With clients(numClients)
                        .firstName = clientSplit(0).Trim
                        .lastName = clientSplit(1).Trim
                        .dateOfBirth = clientSplit(2).Trim
                        .gender = clientSplit(3).Trim
                        .email = clientSplit(4).Trim
                        .mobile = clientSplit(5).Trim
                        .address1 = clientSplit(6).Trim
                        .address2 = clientSplit(7).Trim
                        .address3 = clientSplit(8).Trim
                        .county = clientSplit(9).Trim
                        .country = clientSplit(10).Trim
                        .pin = clientSplit(11).Trim
                        .subType = clientSplit(12).Trim
                        .creditCardType = clientSplit(13).Trim
                        .creditCardNum = clientSplit(14).Trim
                        .cvv = clientSplit(15).Trim
                        .cardexpiry = clientSplit(16).Trim
                        .cardName = clientSplit(17).Trim
                        .balance = clientSplit(18).Trim
                        .regDate = clientSplit(19).Trim
                    End With
                    numClients += 1
                End While
            End Using

            'Dim searchIndex As UInt16 = 0
            Dim found As Boolean = False

            Do
                If String.Equals(clients(searchIndex).pin.Trim, txtPinEnter.Text) Then
                    found = True
                Else
                    searchIndex += 1
                End If
            Loop Until found = True Or searchIndex = numClients

            If found Then
                'do i need this?
                ' signedInClientPin = clients(searchIndex).pin.Trim
                Me.Hide()
                frmClientAction.Show()
            Else
                MsgBox("Invalid Pin. Try again")
            End If
        End If
    End Sub

    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        btnStaffLogin.Show()
        lblPassword.Show()
        txtpassword.Show()
        txtPinEnter.Show()
        lblPinEnter.Show()
        lblPinEnter.Text = "Enter Username"
        txtPinEnter.Focus()
    End Sub

    Private Sub btnStaffLogin_Click(sender As Object, e As EventArgs) Handles btnStaffLogin.Click
        Dim namechecker As String,
                    passwordchecker As String
        Using reader As StreamReader = New StreamReader("..\..\Resources\Passwords.txt")
            Dim quit As Boolean = False
            Do
                namechecker = reader.ReadLine
                passwordchecker = reader.ReadLine
                If namechecker = txtPinEnter.Text And passwordchecker = txtpassword.Text Then

                    quit = True
                    attempt = 0
                End If
            Loop Until quit Or reader.EndOfStream
            If quit = False Then
                MsgBox("Access denied. " & (2 - attempt) & " attempts remain.")
                attempt += 1
                If attempt = 3 Then
                    btnStaffLogin.Enabled = False
                    MsgBox("Three fails, you are shut out.")
                End If
            ElseIf quit And namechecker = "manager" Then
                frmrevenue.Show()
                Me.Hide()
            ElseIf quit And namechecker = "ma" Then
                frmStaff.show()
                Me.Hide()
            End If
            reader.Close()
        End Using

    End Sub
End Class
