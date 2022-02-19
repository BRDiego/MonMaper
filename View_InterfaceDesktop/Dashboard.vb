Imports DesktopController
Imports Model
Imports System.Linq

Public Class Dashboard
    Private ReadOnly _PaymentController As PaymentsDeskController

    Public Sub New()
        InitializeComponent()
        'Applying a kind of hard-coded "Dependency Injection" here
        _PaymentController = New PaymentsDeskController()

    End Sub

End Class