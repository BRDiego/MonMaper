Public Class Payment

    Private inId As Integer
    Private dcAmount As Decimal
    Private dtMoment As Date
    Private stSource As String
    Private stDetails As String
    Private enType As TypeOfPayment

    Public Sub New()
    End Sub

    Public Enum TypeOfPayment

        Income = 1
        Expenditure = 2

    End Enum

    Public Sub New(amount As Decimal, moment As Date, source As String, details As String)
        Me.Amount = amount
        Me.Moment = moment
        Me.Source = source
        Me.Details = details
    End Sub

    Public Sub New(id As Integer, amount As Decimal, moment As Date, source As String, details As String)
        Me.New(amount, moment, source, details)
        Me.Id = id
    End Sub

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
            If value < 0 Or value > 100000 Then
                MsgBox("Amounts can have a maximum value of 100.000", vbExclamation, "Payment data")
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
                MsgBox("A payment date must be within the years 1950 and the current", vbExclamation, "Payment data")
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
                MsgBox("Source name must be within 0 or 100 characters", vbExclamation, "Payment data")
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
                MsgBox("Details can have a maximum of 300 characters.", vbExclamation, "Payment data")
            Else
                stDetails = value
            End If
        End Set
        Get
            Return stDetails
        End Get
    End Property

    Public Property PaymentType As TypeOfPayment
        Set(value As TypeOfPayment)
            If Not (value > 0 And value < 3) Then
                MsgBox("Invalid value for type of payment.", vbExclamation, "Payment data")
            End If
            enType = value
        End Set
        Get
            Return enType
        End Get
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If IsNothing(obj) Then
            Return False
        End If

        Dim other As Payment

        Try
            other = CType(obj, Payment)
        Catch ex As Exception
            Return False
        End Try

        Return other.Amount = Me.Amount And other.Moment = Me.Moment And other.Source = Me.Source And other.Details = Me.Details And other.PaymentType = Me.PaymentType

    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim result = (0 <> 0 ^ 1 > 0).ToString
        result += Amount.ToString
        result += Moment.ToShortDateString
        result += Source
        result += Details
        result += PaymentType.ToString
        Return result.GetHashCode
    End Function
End Class
