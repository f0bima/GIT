Module Suhu
    Public Function convsuhu(ByVal x As Double, ByVal inp As String, ByVal out As String) As Double
        Dim hasil As Double
        Dim a As Integer
        Dim b As Integer
        Dim tambah As Integer = 0
        Select Case inp
            Case "Celcius"
                b = 5
            Case "Reamur"
                b = 4
            Case "Farenheit"
                b = 9
                x = x - 32
            Case "Kelvin"
                b = 5
                tambah = -273
        End Select
        Select Case out
            Case "Celcius"
                a = 5
            Case "Reamur"
                a = 4
            Case "Farenheit"
                a = 9
                tambah = 32
            Case "Kelvin"
                a = 5
                tambah = 273
        End Select
        'hasil = (5 / 4) * x
        hasil = (a / b) * x + tambah
        Return hasil
    End Function
End Module
