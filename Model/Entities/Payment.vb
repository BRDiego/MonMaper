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
            dcAmount = value
        End Set
        Get
            Return dcAmount
        End Get
    End Property

    Public Property Moment As Date
        Set(value As Date)
            dtMoment = value
        End Set
        Get
            Return dtMoment
        End Get
    End Property

    Public Property Source As String
        Set(value As String)
            stSource = value
        End Set
        Get
            Return stSource
        End Get
    End Property

    Public Property Details As String
        Set(value As String)
            stDetails = value
        End Set
        Get
            Return stDetails
        End Get
    End Property
End Class
