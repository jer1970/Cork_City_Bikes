Public Class frmPrintBill
    Private Sub frmPrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To numReturners - 1
            With lstCostOfHire.Items
                .Add("Name " & returners(i).name & returners(i).surname)
                .Add("Bike Number " & returners(i).theBikeNumber)
                .Add("Start Time " & returners(i).theStartTime)
                .Add("End Time " & returners(i).endTime)
                .Add("Duration " & returners(i).duration)
                .Add("Cost of Hire " & FormatCurrency(returners(i).cost))
            End With
        Next
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Me.Close()
        frmClientAction.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class