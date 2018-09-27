Imports System.IO
Public Class frmrevenue
    Private Sub frmrevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using revenueList As StreamReader = New StreamReader("..\..\resources\revenue.txt")
            Dim fullDetails As String = revenueList.ReadLine
            revenues(numRevenues).overallTotal = fullDetails
        End Using
        Using stationList As StreamReader = New StreamReader("..\..\resources\stations.txt")
            While Not stationList.EndOfStream
                Dim fullDetails As String = stationList.ReadLine
                Dim stationSplit() As String = fullDetails.Split(",")
                'MsgBox(numStations)
                With stations(numStations)
                    .revenue = stationSplit(0).Trim
                    .position1 = stationSplit(1).Trim
                    .status1 = stationSplit(2).Trim
                    .position2 = stationSplit(3).Trim
                    .status2 = stationSplit(4).Trim
                    .position3 = stationSplit(5).Trim
                    .status3 = stationSplit(6).Trim
                    .position4 = stationSplit(7).Trim
                    .status4 = stationSplit(8).Trim
                    .position5 = stationSplit(9).Trim
                    .status5 = stationSplit(10).Trim
                    .position6 = stationSplit(11).Trim
                    .status6 = stationSplit(12).Trim
                    .position7 = stationSplit(13).Trim
                    .status7 = stationSplit(14).Trim
                    .position8 = stationSplit(15).Trim
                    .status8 = stationSplit(16).Trim
                    .position9 = stationSplit(17).Trim
                    .status9 = stationSplit(18).Trim
                    .position10 = stationSplit(19).Trim
                    .status10 = stationSplit(20).Trim
                    .position11 = stationSplit(21).Trim
                    .status11 = stationSplit(22).Trim
                    .position12 = stationSplit(23).Trim
                    .status12 = stationSplit(24).Trim
                    .position13 = stationSplit(25).Trim
                    .status13 = stationSplit(26).Trim
                    .position14 = stationSplit(27).Trim
                    .status14 = stationSplit(28).Trim
                    .position15 = stationSplit(29).Trim
                    .status15 = stationSplit(30).Trim
                End With
                numStations += 1
            End While
            stationList.Close()
        End Using
        For i = 1 To 20
            cmbStationNumber.Items.Add(i)
        Next
        lblOverallDigits.Text = FormatNumber(revenues(numRevenues).overallTotal)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        End
    End Sub

    Private Sub cmbStationNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStationNumber.SelectedIndexChanged
        lblTotal.Text = FormatNumber(stations(cmbStationNumber.SelectedIndex).revenue)
    End Sub
End Class