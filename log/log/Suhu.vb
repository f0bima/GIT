Module Suhu
    Public Function Celcius(ByVal x As Double, ByVal inp As String, ByVal out As String) As Double
        Dim hasil As Double
        Dim a As Integer
        Dim b As Integer
        Dim tambah As Integer = 0
        Select Case inp
            Case "c"
                b = 5
            Case "r"
                b = 4
            Case "f"
                b = 9
                x = x - 32
            Case "k"
                b = 5
                tambah = -273
        End Select
        Select Case out
            Case "c"
                a = 5
            Case "r"
                a = 4
            Case "f"
                a = 9
                tambah = 32
            Case "k"
                a = 5
                tambah = 273
        End Select
        'hasil = (5 / 4) * x
        hasil = (a / b) * x + tambah
        Return hasil
    End Function
End Module
