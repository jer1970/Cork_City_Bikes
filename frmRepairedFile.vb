Imports System.IO
Public Class frmRepairedFile
    Public changesMade As Boolean = False
    Private Sub frmRepairedFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using repairedList As StreamReader = New StreamReader("..\..\Resources\repaired.txt")
            txtRepaired.Text = repairedList.ReadToEnd.Trim
            'close the file
            repairedList.Close()
        End Using
        Using repairedList As StreamReader = New StreamReader("..\..\resources\repaired.txt")
            While Not repairedList.EndOfStream
                Dim fullDetails As String = repairedList.ReadLine
                Dim repairedSplit() As String = fullDetails.Split(",")
                With repairs(numRepairs)
                    .bikeNo = repairedSplit(0).Trim
                    .description = repairedSplit(1).Trim
                    .fix = repairedSplit(2).Trim
                    .dateTitle = repairedSplit(3).Trim
                    .dateNTime = repairedSplit(4).Trim
                    .jobDone = repairedSplit(5).Trim
                End With
                numRepairs += 1
            End While
            repairedList.Close()
        End Using

        For i = 0 To numRepairs - 1
            With lstRepairs.Items
                .Add(repairs(i).bikeNo & " " & repairs(i).description & " " & repairs(i).fix & " " & repairs(i).dateTitle & " " & repairs(i).dateNTime & " " & repairs(i).jobDone)
            End With
        Next
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Using updateRepairs As StreamWriter = New StreamWriter("..\..\Resources\repaired.txt")
            updateRepairs.WriteLine(txtRepaired.Text)
            updateRepairs.Close()
        End Using
        changesMade = False
        MsgBox("Changes saved.")
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If changesMade Then
            Dim choice As Byte = MessageBox.Show("You have unsaved changes, do you want to save the changed file?", "Warning: unsaved changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If choice = vbYes Then
                Call btnsave.PerformClick()
            Else
                frmStaff.Show()
                'ElseIf choice = vbNo Then
                '    'End
                '    frmStaff.Show()

                'ElseIf choice = vbCancel Then
                '    frmStaff.Show()
            End If
        Else
            'End
            frmStaff.Show()

        End If
        'Me.Close()
        'frmStaff.Show()
    End Sub

    Private Sub txtRepaired_TextChanged(sender As Object, e As EventArgs) Handles txtRepaired.TextChanged
        changesMade = True
    End Sub
End Class