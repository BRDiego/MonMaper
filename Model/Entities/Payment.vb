Public Class Payment

    Private inId As Integer
    Private dcAmount As Decimal
    Private dtMoment As Date
    Private stSource As String
    Private stDetails As String

    Public Property Id As Integer
        Set(value As Integer)
            inId = value
        End Set
        Get
            Return inId
        End Get
    End Property

    Public Property Amount As Decimal
        Set(value As Decimal)
            If value < 0 Or value > 1000000 Then
                MsgBox("Amounts can have a maximum value of 1.000.000")
            Else
                dcAmount = value
            End If
        End Set
        Get
            Return dcAmount
        End Get
    End Property

    Public Property Moment As Date
        Set(value As Date)
            If value.Date.Year < 1950 Or value.Date.Year > Now.Year Then
                MsgBox("A payment date must be within the years 1950 and the current")
            Else
                dtMoment = value
            End If
        End Set
        Get
            Return dtMoment
        End Get
    End Property

    Public Property Source As String
        Set(value As String)
            If value.ToString.Length = 0 Or value.ToString.Length > 100 Then
                MsgBox("Source name must be within 0 or 100 characters")
            Else
                stSource = value
            End If
        End Set
        Get
            Return stSource
        End Get
    End Property

    Public Property Details As String
        Set(value As String)
            If value.ToString.Length > 300 Then
                MsgBox("Details can have a maximum of 300 characters")
            Else
                stDetails = value
            End If
        End Set
        Get
            Return stDetails
        End Get
    End Property
End Class
