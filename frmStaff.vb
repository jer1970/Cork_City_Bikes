Imports System.IO
Public Class frmStaff
    Private Sub frmStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbStationNumber.Hide()
        lblStationNum.Hide()
        cmbStationNumber.Enabled = False
        lbldamagedBikes.Text = ""
        lblBikesForRepair.Text = ""

        Using stationList As StreamReader = New StreamReader("..\..\resources\stations.txt")
            While Not stationList.EndOfStream
                Dim fullDetails As String = stationList.ReadLine
                Dim stationSplit() As String = fullDetails.Split(",")
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
        Using maintenanceList As StreamReader = New StreamReader("..\..\resources\maintenance.txt")
            While Not maintenanceList.EndOfStream
                Dim fullDetails As String = maintenanceList.ReadLine
                Dim maintenanceSplit() As String = fullDetails.Split(",")
                With logs(numLogs)
                    .place = maintenanceSplit(0).Trim
                    .bikeNo = maintenanceSplit(1).Trim
                    .description = maintenanceSplit(2).Trim
                End With
                numLogs += 1
            End While
            maintenanceList.Close()
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
    End Sub

    Private Sub btnDamage_Click(sender As Object, e As EventArgs) Handles btnDamage.Click
        lstDamagedBikes.Items.Clear()
        lstForRepair.Items.Clear()
        lblStationNum.Text = "Remove bikes from station"
        lbldamagedBikes.Text = "Damaged Bikes"
        lblBikesForRepair.Text = "Bikes for Repair"
        For i = 0 To numLogs - 1
            If Not logs(i).place = "garage" Then
                With lstDamagedBikes.Items
                    .Add("Station Number " & logs(i).place & " Bike Number" & logs(i).bikeNo)
                    .Add("Fault" & logs(i).description)
                    .Add("")
                End With
            End If
        Next
        lblStationNum.Show()
        cmbStationNumber.Show()
        cmbStationNumber.Enabled = True
        If cmbStationNumber.Items.Count = 0 Then
            For i = 1 To 20
                cmbStationNumber.Items.Add(i)
            Next
        End If
        cmbStationNumber.SelectedIndex = -1
    End Sub

    Private Sub cmbStationNumber_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbStationNumber.SelectedIndexChanged
        If lbldamagedBikes.Text.Contains("Damaged") Then
            lstDamagedBikes.Items.Clear()
            For i = 0 To numLogs - 1
                If logs(i).place = cmbStationNumber.Text Then
                    With lstDamagedBikes.Items
                        .Add("Station Number: " & logs(i).place)
                        .Add("Bike Number: " & logs(i).bikeNo)
                        .Add("Fault: " & logs(i).description)
                        .Add("")
                    End With
                End If
            Next
        End If
    End Sub

    Private Sub btnSelectBike_Click(sender As Object, e As EventArgs) Handles btnSelectBike.Click
        If cmbStationNumber.Enabled = True And cmbStationNumber.SelectedIndex = -1 Then
            MessageBox.Show("You must select a station first")
        ElseIf lstDamagedBikes.SelectedIndex = -1 Then
            MessageBox.Show("You must select a bike")
        ElseIf Not lstDamagedBikes.Text.Contains("Bike") Then
            MsgBox("please select a bike number")
        Else
            If lbldamagedBikes.Text.Contains("Damaged") Then
                MsgBox(lstDamagedBikes.SelectedIndex)
                With lstForRepair.Items
                    .Add("Station:" & cmbStationNumber.Text)
                    .Add(lstDamagedBikes.Text)
                End With
            ElseIf lbldamagedBikes.Text.Contains("Under") Then
                With lstForRepair.Items
                    '.Add("Station:" & cmbStationNumber.Text)
                    .Add(lstDamagedBikes.Text)
                    lstDamagedBikes.SelectedIndex += 1
                    .Add(lstDamagedBikes.Text)
                    lstDamagedBikes.SelectedIndex -= 1
                End With
            ElseIf lbldamagedBikes.Text.Contains("Ready") Then
                lstForRepair.Items.Add(lstDamagedBikes.Text)
                lstDamagedBikes.Items.RemoveAt(lstDamagedBikes.SelectedIndex)
            End If
            If lbldamagedBikes.Text.Contains("Damaged") Or lbldamagedBikes.Text.Contains("Under") Then
                lstDamagedBikes.Items.RemoveAt(lstDamagedBikes.SelectedIndex - 1)
                lstDamagedBikes.Items.RemoveAt(lstDamagedBikes.SelectedIndex + 1)
                lstDamagedBikes.Items.Remove(lstDamagedBikes.SelectedIndex + 2)
                lstDamagedBikes.Items.RemoveAt(lstDamagedBikes.SelectedIndex)
            End If
        End If
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        If cmbStationNumber.Enabled = True And cmbStationNumber.SelectedIndex = -1 Then
            MessageBox.Show("You must select a station first")
        Else
            If lbldamagedBikes.Text.Contains("Damaged") Then
                lstDamagedBikes.SelectedIndex = 0
                For i = 0 To lstDamagedBikes.Items.Count - 1
                    lstDamagedBikes.SelectedIndex = i
                    lstForRepair.Items.Add(lstDamagedBikes.Text)
                Next
            End If
            If lbldamagedBikes.Text.Contains("Under") Then
                MsgBox("Under")
                lstDamagedBikes.SelectedIndex = 0
                For i = 0 To lstDamagedBikes.Items.Count - 1
                    lstDamagedBikes.SelectedIndex = i
                    If lstDamagedBikes.Text.Contains("Bike") Or lstDamagedBikes.Text.Contains("Fault") Then
                        lstForRepair.Items.Add(lstDamagedBikes.Text)
                    End If
                Next
            End If
            If lbldamagedBikes.Text.Contains("Ready") Then
                For i = 0 To lstDamagedBikes.Items.Count - 1
                    lstDamagedBikes.SelectedIndex = i
                    lstForRepair.Items.Add(lstDamagedBikes.Text)
                Next
            End If
            lstDamagedBikes.Items.Clear()
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstForRepair.SelectedIndex = -1 Or Not lstForRepair.Text.Contains("Bike") Then
            MessageBox.Show("You must select an bike")
        Else
            lstDamagedBikes.Items.Add(lstForRepair.Text)
            'lstForRepair.Items.RemoveAt(lstForRepair.SelectedIndex - 1)
            lstForRepair.Items.RemoveAt(lstForRepair.SelectedIndex)
        End If
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        If lbldamagedBikes.Text.Contains("Damaged") Then

            If lstForRepair.Items.Count = 0 Or cmbStationNumber.SelectedIndex = -1 Then
                MsgBox("You must select a station and a bike")
            Else
                lstForRepair.SelectedIndex = 1
                If lstDamagedBikes.Items.Count = 0 Then
                    'change place/station of bike to garage
                    MsgBox("numlogs = " & numLogs)
                    For i = 0 To numLogs - 1
                        If logs(i).place = cmbStationNumber.Text Then
                            If stations(logs(i).place - 1).position1 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position1 = ""
                                stations(logs(i).place - 1).status1 = True
                            ElseIf stations(logs(i).place - 1).position2 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position2 = ""
                                stations(logs(i).place - 1).status2 = True
                            ElseIf stations(logs(i).place - 1).position3 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position3 = ""
                                stations(logs(i).place - 1).status3 = True
                            ElseIf stations(logs(i).place - 1).position4 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position4 = ""
                                stations(logs(i).place - 1).status4 = True
                            ElseIf stations(logs(i).place - 1).position5 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position5 = ""
                                stations(logs(i).place - 1).status5 = True
                            ElseIf stations(logs(i).place - 1).position6 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position6 = ""
                                stations(logs(i).place - 1).status6 = True
                            ElseIf stations(logs(i).place - 1).position7 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position7 = ""
                                stations(logs(i).place - 1).status7 = True
                            ElseIf stations(logs(i).place - 1).position8 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position8 = ""
                                stations(logs(i).place - 1).status8 = True
                            ElseIf stations(logs(i).place - 1).position9 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position9 = ""
                                stations(logs(i).place - 1).status9 = True
                            ElseIf stations(logs(i).place - 1).position10 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position10 = ""
                                stations(logs(i).place - 1).status10 = True
                            ElseIf stations(logs(i).place - 1).position11 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position11 = ""
                                stations(logs(i).place - 1).status11 = True
                            ElseIf stations(logs(i).place - 1).position12 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position12 = ""
                                stations(logs(i).place - 1).status12 = True
                            ElseIf stations(logs(i).place - 1).position13 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position13 = ""
                                stations(logs(i).place - 1).status13 = True
                            ElseIf stations(logs(i).place - 1).position14 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position14 = ""
                                stations(logs(i).place - 1).status14 = True
                            ElseIf stations(logs(i).place - 1).position15 = logs(i).bikeNo Then
                                stations(logs(i).place - 1).position15 = ""
                                stations(logs(i).place - 1).status15 = True
                            End If
                            logs(i).place = "garage"
                        End If
                    Next
                Else
                    For x = 1 To lstForRepair.Items.Count / 2
                        For i = 0 To numLogs - 1
                            If logs(i).bikeNo = lstForRepair.Text.Substring(13).Trim Then
                                If stations(cmbStationNumber.Text - 1).position1 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position1 = ""
                                    stations(cmbStationNumber.Text - 1).status1 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position2 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position2 = ""
                                    stations(cmbStationNumber.Text - 1).status2 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position3 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position3 = ""
                                    stations(cmbStationNumber.Text - 1).status3 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position4 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position4 = ""
                                    stations(cmbStationNumber.Text - 1).status4 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position5 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position5 = ""
                                    stations(cmbStationNumber.Text - 1).status5 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position6 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position6 = ""
                                    stations(cmbStationNumber.Text - 1).status6 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position7 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position7 = ""
                                    stations(cmbStationNumber.Text - 1).status7 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position8 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position8 = ""
                                    stations(cmbStationNumber.Text - 1).status8 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position9 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position9 = ""
                                    stations(cmbStationNumber.Text - 1).status9 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position10 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position10 = ""
                                    stations(cmbStationNumber.Text - 1).status10 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position11 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position11 = ""
                                    stations(cmbStationNumber.Text - 1).status11 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position12 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position12 = ""
                                    stations(cmbStationNumber.Text - 1).status12 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position13 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position13 = ""
                                    stations(cmbStationNumber.Text - 1).status13 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position14 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position14 = ""
                                    stations(cmbStationNumber.Text - 1).status14 = True
                                ElseIf stations(cmbStationNumber.Text - 1).position15 = lstForRepair.Text.Substring(13) Then
                                    stations(cmbStationNumber.Text - 1).position15 = ""
                                    stations(cmbStationNumber.Text - 1).status15 = True
                                End If
                                logs(i).place = "garage"
                            End If
                        Next
                        If lstForRepair.SelectedIndex < lstForRepair.Items.Count - 1 Then
                            lstForRepair.SelectedIndex += 2
                        End If
                        ' Loop
                    Next
                End If

                'rewrite maintenance file
                Using logsList As StreamWriter = New StreamWriter("..\..\resources\maintenance.txt")
                    For i = 0 To numLogs - 1
                        logsList.WriteLine(logs(i).place & ", " & logs(i).bikeNo & ", " & logs(i).description)
                    Next
                    logsList.Close()
                End Using
                'rewrite stations file

                Using stationList As StreamWriter = New StreamWriter("..\..\resources\stations.txt")
                    For i = 0 To numStations - 1
                        With stations(i)
                            stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                        End With
                    Next
                    stationList.Close()
                End Using
            End If
        ElseIf lbldamagedBikes.Text.Contains("Under") Then
            MsgBox("sending to repaierd file")
            'lstForRepair.SelectedIndex = 0
            numRepairs = 0
            For x = 1 To lstForRepair.Items.Count / 2
                With repairs(numRepairs)
                    lstForRepair.SelectedIndex += 1
                    .bikeNo = lstForRepair.Text.Substring(13)
                    lstForRepair.SelectedIndex += 1
                    .description = lstForRepair.Text
                    .fix = ""
                    .dateNTime = DateAndTime.Now
                    .jobDone = False
                End With
                numRepairs += 1
            Next
            MsgBox("numRepairs = " & numRepairs)
            Using repairsList As StreamWriter = New StreamWriter("..\..\resources\repaired.txt", True)
                For i = 0 To lstForRepair.Items.Count / 2 - 1
                    repairsList.WriteLine("Bike No. " & repairs(i).bikeNo & ", " & repairs(i).description & ", " & "Work carried out: " & repairs(i).fix & ", " & "Date And Time: ," & repairs(i).dateNTime & ", " & repairs(i).jobDone, True)
                Next
                repairsList.Close()
            End Using
            'rewrite maintenance file
            Dim found As Boolean = False
            MsgBox("Rewriting Maintenance file")
            For i = 0 To numRepairs - 1
                Dim index As Byte = 0
                Do Until found = True Or index = numLogs
                    MsgBox(repairs(i).bikeNo)
                    If repairs(i).bikeNo = logs(index).bikeNo Then
                        found = True
                        If found Then
                            Using logsList As StreamWriter = New StreamWriter("..\..\resources\maintenance.txt")
                                For x = 0 To index - 1
                                    logsList.WriteLine(logs(x).place & ", " & logs(x).bikeNo & ", " & logs(x).description)
                                Next
                                For x = index + 1 To numLogs - 1
                                    logsList.WriteLine(logs(x).place & ", " & logs(x).bikeNo & ", " & logs(x).description)
                                Next
                                logsList.Close()
                            End Using
                        End If
                    End If

                    index += 1
                Loop
                found = False
                numLogs = 0
                Using maintenanceList As StreamReader = New StreamReader("..\..\resources\maintenance.txt")
                    While Not maintenanceList.EndOfStream
                        Dim fullDetails As String = maintenanceList.ReadLine
                        Dim maintenanceSplit() As String = fullDetails.Split(",")
                        With logs(numLogs)
                            .place = maintenanceSplit(0).Trim
                            .bikeNo = maintenanceSplit(1).Trim
                            .description = maintenanceSplit(2).Trim
                        End With
                        numLogs += 1
                    End While
                    maintenanceList.Close()
                End Using
            Next
            Me.Hide()
            frmRepairedFile.Show()

        ElseIf lbldamagedBikes.Text.Contains("Ready") Then

            If lstForRepair.Items.Count = 0 Or cmbStationNumber.SelectedIndex = -1 Then
                MsgBox("You must select a station and a bike")
            Else
                Dim available As Byte = 0
                If stations(cmbStationNumber.Text - 1).position1 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position2 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position3 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position4 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position5 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position6 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position7 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position8 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position9 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position11 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position12 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position13 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position14 = "" Then
                    available += 1
                End If
                If stations(cmbStationNumber.Text - 1).position15 = "" Then
                    available += 1
                End If
                If available < lstForRepair.Items.Count Then
                    MsgBox("There are not enough available spaces. Remove " & lstForRepair.Items.Count - available & " bikes from the return list")
                Else

                    ' MsgBox(lstForRepair.Text.Substring(9))
                    For i = 0 To lstForRepair.Items.Count - 1
                        lstForRepair.SelectedIndex += 1
                        If stations(cmbStationNumber.Text - 1).position1 = "" Then
                            stations(cmbStationNumber.Text - 1).position1 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position2 = "" Then
                            stations(cmbStationNumber.Text - 1).position2 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position3 = "" Then
                            stations(cmbStationNumber.Text - 1).position3 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position4 = "" Then
                            stations(cmbStationNumber.Text - 1).position4 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position5 = "" Then
                            stations(cmbStationNumber.Text - 1).position5 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position6 = "" Then
                            stations(cmbStationNumber.Text - 1).position6 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position7 = "" Then
                            stations(cmbStationNumber.Text - 1).position7 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position8 = "" Then
                            stations(cmbStationNumber.Text - 1).position8 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position9 = "" Then
                            stations(cmbStationNumber.Text - 1).position9 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position10 = "" Then
                            stations(cmbStationNumber.Text - 1).position10 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position11 = "" Then
                            stations(cmbStationNumber.Text - 1).position11 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position12 = "" Then
                            stations(cmbStationNumber.Text - 1).position12 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position13 = "" Then
                            stations(cmbStationNumber.Text - 1).position13 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position14 = "" Then
                            stations(cmbStationNumber.Text - 1).position14 = lstForRepair.Text.Substring(9)
                        ElseIf stations(cmbStationNumber.Text - 1).position15 = "" Then
                            stations(cmbStationNumber.Text - 1).position15 = lstForRepair.Text.Substring(9)
                        End If
                        Dim index As Byte = 0
                        Dim found As Boolean = False
                        Do Until found = True
                            MsgBox("repairs " & repairs(index).bikeNo.Substring(9) & " lst " & lstForRepair.Text.Substring(9))
                            If lstForRepair.Text.Substring(9) = repairs(index).bikeNo.Substring(9) Then
                                repairs(index).jobDone = True
                                found = True
                            End If
                            index += 1
                        Loop
                    Next
                    ' lstForRepair.Items.Clear()
                End If
            End If
            Using stationList As StreamWriter = New StreamWriter("..\..\resources\stations.txt")
                For i = 0 To numStations - 1
                    With stations(i)
                        stationList.WriteLine(FormatNumber(.revenue) & ", " & .position1 & ", " & .status1 & ", " & .position2 & ", " & .status2 & ", " & .position3 & ", " & .status3 & ", " & .position4 & ", " & .status4 & ", " & .position5 & ", " & .status5 & ", " & .position6 & ", " & .status6 & ", " & .position7 & ", " & .status7 & ", " & .position8 & ", " & .status8 & ", " & .position9 & ", " & .status9 & ", " & .position10 & ", " & .status10 & ", " & .position11 & ", " & .status11 & ", " & .position12 & ", " & .status12 & ", " & .position13 & ", " & .status13 & ", " & .position14 & ", " & .status14 & ", " & .position15 & ", " & .status15, True)
                    End With
                Next
                stationList.Close()
            End Using
            Using repairsList As StreamWriter = New StreamWriter("..\..\resources\repaired.txt")
                For i = 0 To numRepairs - 1
                    repairsList.WriteLine(repairs(i).bikeNo & ", " & repairs(i).description & ", " & repairs(i).fix & ", " & "Date And Time: ," & repairs(i).dateNTime & ", " & repairs(i).jobDone, True)
                Next
                repairsList.Close()
            End Using

        End If
        lstForRepair.Items.Clear()
    End Sub

    Private Sub btnGarage_Click(sender As Object, e As EventArgs) Handles btnGarage.Click
        lstDamagedBikes.Items.Clear()
        lstForRepair.Items.Clear()
        cmbStationNumber.Hide()
        lblStationNum.Hide()
        cmbStationNumber.Enabled = False
        lbldamagedBikes.Text = "Bikes Under Repair"
        lblBikesForRepair.Text = "Repaired Bikes"
        For i = 0 To numLogs - 1
            If logs(i).place = "garage" Then
                With lstDamagedBikes.Items
                    .Add("Garage")
                    .Add("Bike Number: " & logs(i).bikeNo)
                    .Add("Fault: " & logs(i).description)
                    .Add("")
                End With
            End If
        Next
    End Sub

    Private Sub btnRepaired_Click(sender As Object, e As EventArgs) Handles btnRepaired.Click
        numRepairs = 0
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
        lstDamagedBikes.Items.Clear()
        lstForRepair.Items.Clear()
        cmbStationNumber.Show()
        lblStationNum.Show()
        cmbStationNumber.Enabled = True
        lbldamagedBikes.Text = "Ready for Return"
        lblBikesForRepair.Text = "Returned Bikes"
        For i = 0 To numRepairs - 1
            If repairs(i).jobDone = False Then
                lstDamagedBikes.Items.Add(repairs(i).bikeNo)
            End If
        Next
        lblStationNum.Text = "Return bikes to Station "
        If cmbStationNumber.Items.Count = 0 Then
            For i = 1 To 20
                cmbStationNumber.Items.Add(i)
            Next
        End If
        cmbStationNumber.SelectedIndex = -1
    End Sub
End Class