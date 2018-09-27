Module globalvars
    Structure client
        Dim firstName As String
        Dim lastName As String
        Dim dateOfBirth As String
        Dim gender As String
        Dim email As String
        Dim mobile As String
        Dim address1 As String
        Dim address2 As String
        Dim address3 As String
        Dim county As String
        Dim country As String
        Dim pin As String
        Dim subType As String
        Dim creditCardType As String
        Dim creditCardNum As String
        Dim cvv As String
        Dim cardexpiry As Date
        Dim cardName As String
        Dim balance As Double
        Dim regDate As Date

    End Structure

    Structure rent
        Dim firstName As String
        Dim lastName As String
        Dim pin As String
        Dim bikeNumber As String
        Dim startTime As Date
    End Structure
    Structure returner
        Dim name As String
        Dim surname As String
        Dim thePin As String
        Dim theBikeNumber As String
        Dim theStartTime As Date
        Dim endTime As Date
        Dim duration As String
        Dim cost As Double
    End Structure

    Structure station
        Dim revenue As Double
        Dim position1 As String
        Dim status1 As Boolean
        Dim position2 As String
        Dim status2 As Boolean
        Dim position3 As String
        Dim status3 As Boolean
        Dim position4 As String
        Dim status4 As Boolean
        Dim position5 As String
        Dim status5 As Boolean
        Dim position6 As String
        Dim status6 As Boolean
        Dim position7 As String
        Dim status7 As Boolean
        Dim position8 As String
        Dim status8 As Boolean
        Dim position9 As String
        Dim status9 As Boolean
        Dim position10 As String
        Dim status10 As Boolean
        Dim position11 As String
        Dim status11 As Boolean
        Dim position12 As String
        Dim status12 As Boolean
        Dim position13 As String
        Dim status13 As Boolean
        Dim position14 As String
        Dim status14 As Boolean
        Dim position15 As String
        Dim status15 As Boolean

    End Structure

    Structure revenue
        Dim overallTotal As Double
    End Structure

    Structure maintenence
        Dim place As String
        Dim bikeNo As String
        Dim description As String
    End Structure
    Structure repair
        Dim bikeNo As String
        Dim description As String
        Dim fix As String
        Dim dateTitle As String
        Dim dateNTime As Date
        Dim jobDone As Boolean
    End Structure

    Public clients(99) As client
    Public numClients As Byte = 0
    Public renters(100) As rent
    Public numRenters As Byte = 0
    Public returners(10) As returner
    Public numReturners As Byte = 1
    Public stations(20) As station
    Public numStations As Byte = 0
    Public revenues(1) As revenue
    Public numRevenues As Byte
    Public logs(300) As maintenence
    Public numLogs As Byte = 0
    Public repairs(100) As repair
    Public numRepairs As Byte = 0
    Public signedInClientPin As String
    Public searchIndex As UInt16 = 0

End Module
