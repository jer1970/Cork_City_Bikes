Imports System.IO
Public Class frmReturn
    Dim index As Single = 0
    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 20
            cmbStationNumber.Items.Add(i)
        Next
        numRenters = 0
        Using renterList As StreamReader = New StreamReader("..\..\resources\renters.txt")
            While Not renterList.EndOfStream
                Dim fullDetails As String = renterList.ReadLine
                Dim renterSplit() As String = fullDetails.Split(", ")
                With renters(numRenters)
                    .firstName = renterSplit(0).Trim
                    .lastName = renterSplit(1).Trim
                    .pin = renterSplit(2).Trim
                    .bikeNumber = renterSplit(3).Trim
                    .startTime = renterSplit(4).Trim
                End With
                numRenters += 1
            End While
        End Using

        Dim found As Boolean = False
        Do
            If String.Equals(renters(Index).pin.Trim, frmWelcome.txtPinEnter.Text) Then
                found = True
            End If
            If found Then
                lstBikesToReturn.Items.Add(renters(Index).bikeNumber & ", " & renters(Index).startTime)
                With returners(0)
                    .name = renters(index).firstName
                    .surname = renters(index).lastName
                    .thePin = renters(index).pin
                End With
            End If
            Index += 1
            found = False
        Loop Until Index = numRenters

        numStations = 0
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
                If numStations <= 20 Then
                    numStations += 1
                End If
            End While
            stationList.Close()
        End Using
    End Sub

    Private Sub btnSelectBike_Click(sender As Object, e As EventArgs) Handles btnSelectBike.Click

        If lstBikesToReturn.SelectedIndex = -1 Then
            MessageBox.Show("You must select a bike")
        Else
            lstReturnedBikes.Items.Add(lstBikesToReturn.Text)
            lstBikesToReturn.Items.RemoveAt(lstBikesToReturn.SelectedIndex)
        End If
    End Sub

    Private Sub btnSelectAll_Click(sender As Object, e As EventArgs) Handles btnSelectAll.Click
        If lstBikesToReturn.Text = "" Then
            MessageBox.Show("You must select a bike")
        Else
            lstBikesToReturn.SelectedIndex = 0
            For i = 0 To lstBikesToReturn.Items.Count - 1
                lstBikesToReturn.SelectedIndex = i
                lstReturnedBikes.Items.Add(lstBikesToReturn.Text)
            Next
            lstBikesToReturn.Items.Clear()
        End If
    End Sub

    Private Sub btnDoneReturn_Click(sender As Object, e As EventArgs) Handles btnDoneReturn.Click
        Dim totalSeconds As Integer = 0
        Dim available As Byte = 0
        If lstReturnedBikes.Items.Count = 0 Or cmbStationNumber.SelectedIndex = -1 Then
            MsgBox("Please select a bike and a station")
        Else
            For i = 0 To lstReturnedBikes.Items.Count - 1
                lstReturnedBikes.SelectedIndex = i
                Dim bikeTime() As String = lstReturnedBikes.Text.Split(",")
                With returners(i)
                    .name = returners(0).name
                    .surname = returners(0).surname
                    .thePin = returners(0).thePin
                    .theBikeNumber = bikeTime(0)
                    .theStartTime = bikeTime(1)
                    .endTime = DateAndTime.Now
                End With
                numReturners = i + 1
            Next

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
            If available < numReturners Then
                MsgBox("There are not enough available spaces. Remove " & numReturners - available & " bikes from the return list")
            Else
                For i = 0 To numReturners - 1
                    If stations(cmbStationNumber.Text - 1).position1 = "" Then
                        stations(cmbStationNumber.Text - 1).position1 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position2 = "" Then
                        stations(cmbStationNumber.Text - 1).position2 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position3 = "" Then
                        stations(cmbStationNumber.Text - 1).position3 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position4 = "" Then
                        stations(cmbStationNumber.Text - 1).position4 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position5 = "" Then
                        stations(cmbStationNumber.Text - 1).position5 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position6 = "" Then
                        stations(cmbStationNumber.Text - 1).position6 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position7 = "" Then
                        stations(cmbStationNumber.Text - 1).position7 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position8 = "" Then
                        stations(cmbStationNumber.Text - 1).position8 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position9 = "" Then
                        stations(cmbStationNumber.Text - 1).position9 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position10 = "" Then
                        stations(cmbStationNumber.Text - 1).position10 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position11 = "" Then
                        stations(cmbStationNumber.Text - 1).position11 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position12 = "" Then
                        stations(cmbStationNumber.Text - 1).position12 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position13 = "" Then
                        stations(cmbStationNumber.Text - 1).position13 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position14 = "" Then
                        stations(cmbStationNumber.Text - 1).position14 = returners(i).theBikeNumber
                    ElseIf stations(cmbStationNumber.Text - 1).position15 = "" Then
                        stations(cmbStationNumber.Text - 1).position15 = returners(i).theBikeNumber
                    End If
                Next
                'calculate the cost
                Using revenueList As StreamReader = New StreamReader("..\..\Resources\revenue.txt")
                    Dim total As Double = revenueList.ReadLine
                    revenues(0).overallTotal = total

                End Using
                For i = 0 To numReturners - 1
                    Dim difference As TimeSpan = DateAndTime.Now - DateTime.Parse(returners(i).theStartTime)
                    returners(i).duration = difference.Days & " days " & difference.Hours & ":" & difference.Minutes & ":" & difference.Seconds
                    totalSeconds = (difference.Days * 24 * 60 * 60) + (difference.Hours * 60 * 60) + (difference.Minutes * 60) + difference.Seconds
                    If totalSeconds > 10800 Then
                        returners(i).cost = (totalSeconds - 10800) / 60 / 30 * 2 + 6.5
                    ElseIf totalSeconds > 7200 Then
                        returners(i).cost = 6.5
                    ElseIf totalSeconds > 3600 Then
                        returners(i).cost = 1.5
                    ElseIf totalSeconds > 1800 Then
                        returners(i).cost = 0.5
                    Else returners(i).cost = 0
                    End If

                    clients(searchIndex).balance -= returners(i).cost

                    'Add to the stations revenue and the overall total
                    stations(cmbStationNumber.Text - 1).revenue += returners(i).cost
                    revenues(0).overallTotal += returners(i).cost
                    If searchIndex > 0 Then
                        Using clientList As StreamWriter = New StreamWriter("..\..\Resources\clients.txt")
                            For x = 0 To searchIndex - 1
                                With clients(x)
                                    clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                                End With
                            Next

                            With clients(searchIndex)
                                clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                            End With

                            For x = searchIndex + 1 To numClients - 1
                                With clients(x)
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

                            For x = searchIndex + 1 To numClients - 1
                                With clients(x)
                                    clientList.WriteLine(.firstName & ", " & .lastName & ", " & .dateOfBirth & ", " & .gender & ", " & .email & ", " & .mobile & ", " & .address1 & ", " & .address2 & ", " & .address3 & ", " & .county & ", " & .country & ", " & .pin & ", " & .subType & ", " & .creditCardType & ", " & .creditCardNum & ", " & .cvv & ", " & .cardexpiry & ", " & .cardName & ", " & FormatNumber(.balance) & ", " & .regDate, True)
                                End With
                            Next
                            clientList.Close()
                        End Using
                    End If
                Next


                If (cmbStationNumber.Text - 1) > 1 Then
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
            MsgBox("numReturners = " & numReturners)
            Dim canWrite As Boolean = True
            index = 0
                Using rentersList As StreamWriter = New StreamWriter("..\..\Resources\renters.txt")
                    Do
                        For i = 0 To numReturners - 1
                            If String.Equals(renters(index).bikeNumber, returners(i).theBikeNumber) Then
                                canWrite = False
                            End If
                        Next
                        If canWrite Then
                            rentersList.WriteLine(renters(index).firstName & ", " & renters(index).lastName & ", " & renters(index).pin & ", " & renters(index).bikeNumber & ", " & renters(index).startTime, True)
                        End If
                        index += 1
                        canWrite = True
                    Loop Until index = numRenters
                    rentersList.Close()
                End Using
                Using revenueList As StreamWriter = New StreamWriter("..\..\Resources\revenue.txt")
                    revenueList.WriteLine(FormatNumber(revenues(0).overallTotal))
                    revenueList.Close()
                End Using
                Me.Close()
            frmPrintBill.Show()
        End If
        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstReturnedBikes.SelectedIndex = -1 Then
            MessageBox.Show("You must select an bike")
        Else
            lstBikesToReturn.Items.Add(lstReturnedBikes.Text)
            lstReturnedBikes.Items.RemoveAt(lstReturnedBikes.SelectedIndex)
        End If
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        lstBikesToReturn.Items.Clear()
        Me.Close()
        frmClientAction.Show()
    End Sub
End Class