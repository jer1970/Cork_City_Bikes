Imports System.IO
Public Class frmClientAction
    Public noMore As Boolean = False
    Private Sub frmClientAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello " & clients(searchIndex).firstName & ". Select your option"
        lblTopUpAction.Hide()
        lblEuroAction.Hide()
        txtTopUpAction.Hide()
        btnSubmitTopUp.Hide()
    End Sub

    Private Sub btnTopUp_Click(sender As Object, e As EventArgs) Handles btnTopUp.Click
        lblTopUpAction.Show()
        lblEuroAction.Show()
        txtTopUpAction.Show()
        btnSubmitTopUp.Show()
        txtTopUpAction.Text = 0
    End Sub

    Private Sub btnSubmitTopUp_Click(sender As Object, e As EventArgs) Handles btnSubmitTopUp.Click
        If txtTopUpAction.Text < 10 Then
            MsgBox("Enter at least €10")
        Else
            clients(searchIndex).balance += txtTopUpAction.Text
        End If
        If searchIndex > 0 Then
            Using clientList As StreamWriter = New StreamWriter("..\..\Resources\clients.txt")
                For i = 0 To searchIndex - 1
                    With clients(i)
                        clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                    End With
                Next
                With clients(searchIndex)
                    clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                End With
                For i = searchIndex + 1 To numClients - 1
                    With clients(i)
                        clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                    End With
                Next
                clientList.Close()
            End Using
        Else
            Using clientList As StreamWriter = New StreamWriter("..\..\Resources\clients.txt")
                With clients(searchIndex)
                    clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                End With
                For i = searchIndex + 1 To numClients - 1
                    With clients(i)
                        clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                    End With
                Next
                clientList.Close()
            End Using
        End If
        MsgBox("Your account has been topped up by €" & txtTopUpAction.Text & ".")
        txtTopUpAction.Clear()
        txtTopUpAction.Hide()
        lblEuroAction.Hide()
        btnSubmitTopUp.Hide()
        lblTopUpAction.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnHire_Click(sender As Object, e As EventArgs) Handles btnHire.Click
        Me.Hide()
        frmHire.Show()

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        ' If noMore = False Then
        Me.Hide()
            frmReturn.Show()
        'Else
        '    MsgBox("You must exit and login if you want to return more bikes.")
        'End If
        noMore = True
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Close()
        frmReport.Show()

    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class