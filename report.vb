﻿Imports System.IO
Public Class frmReport
    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 20
            cmbStationNumber.Items.Add(i)
        Next
        numStations = 0
        Using stationList As StreamReader = New StreamReader("..\..\resources\stations.txt")
            MsgBox("About to populate the stations data structure")
            While Not stationList.EndOfStream
                Dim fullDetails As String = stationList.ReadLine
                Dim stationSplit() As String = fullDetails.Split(",")
                'MsgBox(numClients)
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
    End Sub

    Private Sub cmbStationNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStationNumber.SelectedIndexChanged
        With lstAvailableBikes.Items
            .Clear()
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position1) And stations(cmbStationNumber.Text - 1).status1 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position1)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position2) And stations(cmbStationNumber.Text - 1).status2 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position2)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position3) And stations(cmbStationNumber.Text - 1).status3 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position3)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position4) And stations(cmbStationNumber.Text - 1).status4 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position4)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position5) And stations(cmbStationNumber.Text - 1).status5 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position5)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position6) And stations(cmbStationNumber.Text - 1).status6 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position6)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position7) And stations(cmbStationNumber.Text - 1).status7 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position7)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position8) And stations(cmbStationNumber.Text - 1).status8 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position8)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position9) And stations(cmbStationNumber.Text - 1).status9 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position9)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position10) And stations(cmbStationNumber.Text - 1).status10 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position10)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position11) And stations(cmbStationNumber.Text - 1).status11 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position11)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position12) And stations(cmbStationNumber.Text - 1).status12 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position12)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position13) And stations(cmbStationNumber.Text - 1).status13 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position13)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position14) And stations(cmbStationNumber.Text - 1).status14 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position14)
            End If
            If Not String.IsNullOrEmpty(stations(cmbStationNumber.Text - 1).position15) And stations(cmbStationNumber.Text - 1).status15 = True Then
                Call .Add(stations(cmbStationNumber.Text - 1).position15)
            End If
        End With
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        If lstAvailableBikes.SelectedIndex = -1 Then
            MessageBox.Show("You must select an bike")
        Else
            lstSelectedBikes.Items.Add(lstAvailableBikes.Text)
            lstAvailableBikes.Items.RemoveAt(lstAvailableBikes.SelectedIndex)
            lstSelectedBikes.SelectedIndex = 0
            'btnSelect.Enabled = False
            'until done is clicked
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        Dim bikeNumber As String = ""
        If lstSelectedBikes.Text = "" Then
            MsgBox("Please select a bike ")
        ElseIf txtDamage.Text = "" Then
            MsgBox("Please enter a description of the damage")
        Else
            'change the status of the bike to false and lock it in the station
            If lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position1 Then
                stations(cmbStationNumber.Text - 1).status1 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position1
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position2 Then
                stations(cmbStationNumber.Text - 1).status2 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position2
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position3 Then
                stations(cmbStationNumber.Text - 1).status3 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position3
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position4 Then
                stations(cmbStationNumber.Text - 1).status4 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position4
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position5 Then
                stations(cmbStationNumber.Text - 1).status5 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position5
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position6 Then
                stations(cmbStationNumber.Text - 1).status6 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position6
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position7 Then
                stations(cmbStationNumber.Text - 1).status7 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position7
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position8 Then
                stations(cmbStationNumber.Text - 1).status8 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position8
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position9 Then
                stations(cmbStationNumber.Text - 1).status9 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position9
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position10 Then
                stations(cmbStationNumber.Text - 1).status10 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position10
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position11 Then
                stations(cmbStationNumber.Text - 1).status11 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position11
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position12 Then
                stations(cmbStationNumber.Text - 1).status12 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position12
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position13 Then
                stations(cmbStationNumber.Text - 1).status13 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position13
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position14 Then
                stations(cmbStationNumber.Text - 1).status14 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position14
            ElseIf lstSelectedBikes.Text = stations(cmbStationNumber.Text - 1).position15 Then
                stations(cmbStationNumber.Text - 1).status15 = False
                bikeNumber = stations(cmbStationNumber.Text - 1).position15

            End If
            MsgBox("About to update the stations.txt file")
            'rewrite to the stations.txt file
            If (cmbStationNumber.Text - 1) > 0 Then
                Using stationList As StreamWriter = New StreamWriter("..\..\Resources\stations.txt")
                    For i = 0 To cmbStationNumber.Text - 1 - 1
                        With stations(i)
                            stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                        End With
                    Next
                    With stations(cmbStationNumber.Text - 1)
                        stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                    End With
                    For i = cmbStationNumber.Text - 1 + 1 To numStations - 1
                        With stations(i)
                            stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                        End With
                    Next
                    stationList.Close()
                End Using
            Else
                Using stationList As StreamWriter = New StreamWriter("..\..\Resources\stations.txt")
                    With stations(cmbStationNumber.Text - 1)
                        stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                    End With
                    For i = cmbStationNumber.Text - 1 + 1 To numStations - 1
                        With stations(i)
                            stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                        End With
                    Next
                    stationList.Close()
                End Using
            End If
            Using maintenancelist As StreamWriter = New StreamWriter("..\..\Resources\maintenance.txt", True)
                maintenancelist.WriteLine(cmbStationNumber.Text & ", " & bikeNumber & ", " & txtDamage.Text.Trim)

                maintenancelist.Close()
            End Using

            lstSelectedBikes.Items.Clear()
            txtDamage.Clear()
            btnSelect.Enabled = True

        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        lstSelectedBikes.Items.Clear()
        txtDamage.Clear()
        Me.Close()
        frmClientAction.Show()

    End Sub
End Class