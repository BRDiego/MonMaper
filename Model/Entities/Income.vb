Public Class Income
    Inherits Payment

    Public Sub New()
    End Sub

    Public Sub New(amount As Decimal, moment As Date, source As String, details As String)
        MyBase.New(amount, moment, source, details)
    End Sub

    Public Sub New(id As Integer, amount As Decimal, moment As Date, source As String, details As String)
        MyBase.New(id, amount, moment, source, details)
    End Sub
End Class
