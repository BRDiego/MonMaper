Imports DesktopController
Imports Model
Imports System.Linq

Public Class Dashboard
    Private ReadOnly _ExpenditureController As ExpendituresDeskController
    Private ReadOnly _IncomeController As IncomesDeskController
    Private lista As New List(Of Income)
    Private rowId As Integer

    Public Sub New()
        'Applying a kind of hard-coded "Dependency Injection" here
        _ExpenditureController = New ExpendituresDeskController
        _IncomeController = New IncomesDeskController

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Private Sub IncomesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IncomesToolStripMenuItem.Click
        Dim formIncomes As New IncomesForm
        formIncomes.MdiParent = Me
        formIncomes.Show()
        DgvIncomes.Hide()
        DgvExpenditures.Hide()
    End Sub

    Private Sub DgvIncomes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvIncomes.CellEndEdit
        Dim amountSetted As Boolean = IsNothing(DgvIncomes.Rows.Item(rowId).Cells.Item(0).Value) = False
        Dim dateSetted As Boolean = IsNothing(DgvIncomes.Rows.Item(rowId).Cells.Item(1).Value) = False
        Dim sourceSetted As Boolean = IsNothing(DgvIncomes.Rows.Item(rowId).Cells.Item(2).Value) = False
        If amountSetted And dateSetted And sourceSetted Then
            Try
                Dim inAmount As Decimal = DgvIncomes.Rows.Item(rowId).Cells.Item(0).Value
                Dim inDate As Date = Date.Parse(DgvIncomes.Rows.Item(rowId).Cells.Item(1).Value.ToString)
                Dim inSource As String = DgvIncomes.Rows.Item(rowId).Cells.Item(2).Value.ToString
                Dim inDetails As String = ""
                If Not IsNothing(DgvIncomes.Rows.Item(rowId).Cells.Item(3).Value) Then
                    inDetails = DgvIncomes.Rows.Item(rowId).Cells.Item(3).Value.ToString
                End If


                Dim editedIncome As New Income(inAmount, inDate, inSource, inDetails)
                Dim found As New Income
                For Each item In lista
                    If item.Equals(editedIncome) Then
                        found = item
                    End If
                Next

                If found.Id > 0 Then
                    Dim id = found.Id
                    editedIncome.Id = id
                    Dim result As Integer
                    result = _IncomeController.UpdateIncome(editedIncome)
                    If result = 1 Then
                        MsgBox("Income updated")
                    Else
                        MsgBox("Income update failed")
                    End If
                Else
                    Dim result As Integer
                    result = _IncomeController.AddIncome(editedIncome)
                    If result = 1 Then
                        MsgBox("Income added")
                    Else
                        MsgBox("Add income failed")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Error while constructing the model from the data grid")
            End Try
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lista = _IncomeController.ListIncomes
            DgvIncomes.DataSource = lista
            If DgvIncomes.Columns.GetColumnCount(DataGridViewElementStates.None) = 5 Then
                DgvIncomes.Columns.Remove(DgvIncomes.Columns.GetFirstColumn(DataGridViewElementStates.None))
            End If
        Catch ex As Exception
            MsgBox("Error while listing last incomes")
        End Try
    End Sub
End Class