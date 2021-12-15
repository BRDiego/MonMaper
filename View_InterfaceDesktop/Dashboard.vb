Imports DesktopController

Public Class Dashboard
    Private ReadOnly _ExpenditureController As ExpendituresDeskController
    Private ReadOnly _IncomeController As IncomesDeskController

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Applying a kind of hard-coded "Dependency Injection" here
        _ExpenditureController = New ExpendituresDeskController
        _IncomeController = New IncomesDeskController
    End Sub

End Class