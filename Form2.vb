Imports System.IO
Public Class frmSignUp

    Public gender As String
    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 31
            cmbDay.Items.Add(i)
        Next
        For i = 1 To 12
            cmbMonth.Items.Add(i)
        Next
        For i = (Now.Year - 100) To (Now.Year - 14)
            cmbYear.Items.Add(i)
        Next

        With cmbCounty.Items
            .Add("Antrim")
            .Add("Armagh")
            .Add("Carlow")
            .Add("Cavan")
            .Add("Clare")
            .Add("Cork")
            .Add("Derry")
            .Add("Donegal")
            .Add("Down")
            .Add("Dublin")
            .Add("Fermanagh")
            .Add("Galway")
            .Add("Kerry")
            .Add("Kildare")
            .Add("Kilkenny")
            .Add("Laois")
            .Add("Leitrim")
            .Add("Limerick")
            .Add("Longford")
            .Add("Louth")
            .Add("Mayo")
            .Add("Meath")
            .Add("Monaghan")
            .Add("Offaly")
            .Add("Roscommon")
            .Add("Sligo")
            .Add("Tipperary")
            .Add("Tyrone")
            .Add("Waterford")
            .Add("Westmeath")
            .Add("Wexford")
            .Add("Wicklow")
        End With
        With cmbCountries.Items
            .Add("Afghanistan")
            .Add("Albania")
            .Add("Algeria")
            .Add("Andorra")
            .Add("Angola")
            .Add("Antigua And Barbuda")
            .Add("Argentina")
            .Add("Armenia")
            .Add("Aruba")
            .Add("Australia")
            .Add("Austria")
            .Add("Azerbaijan")
            .Add("Bahamas, The")
            .Add("Bahrain")
            .Add("Bangladesh")
            .Add("Barbados")
            .Add("Belarus")
            .Add("Belgium")
            .Add("Belize")
            .Add("Benin")
            .Add("Bhutan")
            .Add("Bolivia")
            .Add("Bosnia And Herzegovina")
            .Add("Botswana")
            .Add("Brazil")
            .Add("Brunei")
            .Add("Bulgaria")
            .Add("Burkina Faso")
            .Add("Burma")
            .Add("Burundi")
            .Add("Cambodia")
            .Add("Cameroon")
            .Add("Canada")
            .Add("Cabo Verde")
            .Add("Central African Republic")
            .Add("Chad")
            .Add("Chile")
            .Add("China")
            .Add("Colombia")
            .Add("Comoros")
            .Add("Congo, Democratic Republic Of the")
            .Add("Congo, Republic Of the")
            .Add("Costa Rica")
            .Add("Cote d'Ivoire")
            .Add("Croatia")
            .Add("Cuba")
            .Add("Curacao")
            .Add("Cyprus")
            .Add("Czechia")
            .Add("Denmark")
            .Add("Djibouti")
            .Add("Dominica")
            .Add("Dominican Republic")
            .Add("East Timor")
            .Add("Ecuador")
            .Add("Egypt")
            .Add("El Salvador")
            .Add("Equatorial Guinea")
            .Add("Eritrea")
            .Add("Estonia")
            .Add("Ethiopia")
            .Add("Fiji")
            .Add("Finland")
            .Add("France")
            .Add("Gabon")
            .Add("Gambia, The")
            .Add("Georgia")
            .Add("Germany")
            .Add("Ghana")
            .Add("Greece")
            .Add("Grenada")
            .Add("Guatemala")
            .Add("Guinea")
            .Add("Guinea-Bissau")
            .Add("Guyana")
            .Add("Haiti")
            .Add("Holy See")
            .Add("Honduras")
            .Add("Hong Kong")
            .Add("Hungary")
            .Add("Iceland")
            .Add("India")
            .Add("Indonesia")
            .Add("Iran")
            .Add("Iraq")
            .Add("Ireland")
            .Add("Israel")
            .Add("Italy")
            .Add("Jamaica")
            .Add("Japan")
            .Add("Jordan")
            .Add("Kazakhstan")
            .Add("Kenya")
            .Add("Kiribati")
            .Add("Korea, North")
            .Add("Korea, South")
            .Add("Kosovo")
            .Add("Kuwait")
            .Add("Kyrgyzstan")
            .Add("Laos")
            .Add("Latvia")
            .Add("Lebanon")
            .Add("Lesotho")
            .Add("Liberia")
            .Add("Libya")
            .Add("Liechtenstein")
            .Add("Lithuania")
            .Add("Luxembourg")
            .Add("Macau")
            .Add("Macedonia")
            .Add("Madagascar")
            .Add("Malawi")
            .Add("Malaysia")
            .Add("Maldives")
            .Add("Mali")
            .Add("Malta")
            .Add("Marshall Islands")
            .Add("Mauritania")
            .Add("Mauritius")
            .Add("Mexico")
            .Add("Micronesia")
            .Add("Moldova")
            .Add("Monaco")
            .Add("Mongolia")
            .Add("Montenegro")
            .Add("Morocco")
            .Add("Mozambique")
            .Add("Namibia")
            .Add("Nauru")
            .Add("Nepal")
            .Add("Netherlands")
            .Add("New Zealand")
            .Add("Nicaragua")
            .Add("Niger")
            .Add("Nigeria")
            .Add("North Korea")
            .Add("Norway")
            .Add("Oman")
            .Add("Pakistan")
            .Add("Palau")
            .Add("Palestinian Territories")
            .Add("Panama")
            .Add("Papua New Guinea")
            .Add("Paraguay")
            .Add("Peru")
            .Add("Philippines")
            .Add("Poland")
            .Add("Portugal")
            .Add("Qatar")
            .Add("Romania")
            .Add("Russia")
            .Add("Rwanda")
            .Add("Saint Kitts And Nevis")
            .Add("Saint Lucia")
            .Add("Saint Vincent And the Grenadines")
            .Add("Samoa")
            .Add("San Marino")
            .Add("Sao Tome And Principe")
            .Add("Saudi Arabia")
            .Add("Senegal")
            .Add("Serbia")
            .Add("Seychelles")
            .Add("Sierra Leone")
            .Add("Singapore")
            .Add("Sint Maarten")
            .Add("Slovakia")
            .Add("Slovenia")
            .Add("Solomon Islands")
            .Add("South Africa")
            .Add("South Korea")
            .Add("South Sudan")
            .Add("Spain")
            .Add("Sri Lanka")
            .Add("Sudan")
            .Add("Suriname")
            .Add("Swaziland")
            .Add("Sweden")
            .Add("Switzerland")
            .Add("Syria")
            .Add("Taiwan")
            .Add("Tajikistan")
            .Add("Tanzania")
            .Add("Thailand")
            .Add("Timor-Leste")
            .Add("Togo")
            .Add("Tonga")
            .Add("Tobago")
            .Add("Tunisia")
            .Add("Turkey")
            .Add("Turkmenistan")
            .Add("Tuvalu")
            .Add("Uganda")
            .Add("Ukraine")
            .Add("United Arab Emirates")
            .Add("United Kingdom")
            .Add("Uruguay")
            .Add("Uzbekistan")
            .Add("Vanuatu")
            .Add("Venezuela")
            .Add("Vietnam")
            .Add("Yemen")
            .Add("Zambia")
            .Add("Zimbabwe")
        End With

        Using clientList As StreamReader = New StreamReader("..\..\resources\clients.txt")
            While Not clientList.EndOfStream
                Dim fullDetails As String = clientList.ReadLine
                Dim clientSplit() As String = fullDetails.Split(", ")

                With clients(numClients)
                    .firstName = clientSplit(0)
                    .lastName = clientSplit(1)
                    .dateOfBirth = clientSplit(2)
                    .gender = clientSplit(3)
                    .email = clientSplit(4)
                    .mobile = clientSplit(5)
                    .address1 = clientSplit(6)
                    .address2 = clientSplit(7)
                    .address3 = clientSplit(8)
                    .county = clientSplit(9)
                    .country = clientSplit(10)
                    .pin = clientSplit(11)
                    .subType = clientSplit(12)
                    .creditCardType = clientSplit(13)
                    .creditCardNum = clientSplit(14)
                    .cvv = clientSplit(15)
                    .cardexpiry = clientSplit(16)
                    .cardName = clientSplit(17)
                    .balance = clientSplit(18)
                    .regDate = clientSplit(19)
                End With
                numClients += 1
            End While
            clientList.Close()
        End Using


    End Sub

    Private Sub txtFname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFname.KeyPress, txtLname.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Or Asc(e.KeyChar) = 8 Or Asc(e.KeyChar) = 39) Then
            e.Handled = True
        End If
    End Sub

    Private Sub cmbDay_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbDay.KeyPress, cmbMonth.KeyPress, cmbYear.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmWelcome.Show()
    End Sub

    Private Sub isValidName(ByVal theName As String, ByRef valid As Boolean)
        Dim x As Short = 0

        For i = 0 To theName.Length - 1
            If (theName.Substring(i, 1).Equals("'")) Then
                x += 1
            End If
        Next
        If (x > 1) Then
            valid = False
        Else
            valid = True
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim nameOK As Boolean

        'isValidName(txtFname.Text, nameOK)
        'isValidName(txtLname.Text, nameOK)
        If (txtFname.Text.Length = 0 Or txtLname.Text.Length = 0) Then
            MsgBox("Enter your full Name")
        Else
            isValidName(txtFname.Text, nameOK)
            If Not nameOK Then
                MsgBox("Incorrect first name entered")
            End If

            isValidName(txtLname.Text, nameOK)

            If Not nameOK Then
                MsgBox("Incorrect last name entered")

            End If
            'If (txtFname.Text.Length = 0 Or txtLname.Text.Length = 0) Then
            '    MsgBox("Enter your full Name")
            'End If
            'Dim x As Short = 0
            'For i = 0 To txtFname.Text.Length - 1
            '    If (txtFname.Text.Substring(i, 1).Equals("'")) Then
            '        x += 1
            '    End If
            'Next
            'If (x > 1) Then
            '    MsgBox("Incorrect first name entered")
            'End If
            'x = 0
            'For i = 0 To txtLname.Text.Length - 1
            '    If (txtLname.Text.Substring(i, 1).Equals("'")) Then
            '        x += 1
            '    End If
            'Next
            'If (x > 1) Then
            '    MsgBox("Incorrect last name entered")
            ' End If
        End If
        If (cmbDay.Text.Contains("Select") Or cmbMonth.Text.Contains("Select") Or cmbYear.Text.Contains("Select")) Then
            MsgBox("Enter your Date of birth")
        ElseIf Not (optMale.Checked Or optFemale.Checked) Then
            MsgBox("Enter your gender")
        ElseIf (txtEmail.Text.Length = 0) Then
            MsgBox("Enter your email address")
        ElseIf (txtIntPrefix.Text.Length = 0 Or txtPrefix.Text.Length = 0 Or txtMobile.Text.Length = 0) Then
            MsgBox("Enter your full mobile number")
        ElseIf (txtAddress1.Text.Length = 0) Then
            MsgBox("Enter your address")
        ElseIf (cmbCounty.Text.Length = 0 And cmbCountries.Text.Equals("Ireland")) Then
            MsgBox("Enter a county")
        ElseIf (cmbCountries.Text.Length = 0 And cmbCounty.Text.Length = 0) Then
            MsgBox("Enter a country")
        ElseIf Not (txtPin.Text.Length = 4) Then
            MsgBox("Enter a 4-digit pin")
        ElseIf Not (txtPin.Text.Equals(txtConfirmPin.Text)) Then
            MsgBox("Re-enter the same 4-digit pin")
        ElseIf Not (chkTandC.Checked) Then
            MsgBox("Please tick Terms and Conditions to proceed")
        Else
            If optMale.Checked Then
                gender = "m"
            Else
                gender = "f"
            End If


            'Dim searchIndex As UInt16 = 0
            Dim found As Boolean = False

            Do
                If String.Equals(clients(searchIndex).pin.Trim, txtPin.Text) Then
                    found = True
                Else
                    searchIndex += 1
                End If
            Loop Until found = True Or searchIndex = numClients

            If found Then
                MsgBox("Pin in use. Try another")
            Else
                Me.Hide()
                frmCreditCard.Show()
            End If
        End If
    End Sub

    Private Sub txtIntPrefix_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIntPrefix.KeyPress, txtPrefix.KeyPress, txtMobile.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress, txtConfirmPin.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnTandC_Click(sender As Object, e As EventArgs) Handles btnTandC.Click
        frmTandC.Show()
    End Sub

End Class