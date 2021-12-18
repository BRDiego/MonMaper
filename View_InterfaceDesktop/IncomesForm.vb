Imports DesktopController
Imports Model
Imports System.Linq
Public Class IncomesForm
    Private ReadOnly fixedLocation As Point
    Private ReadOnly _incomeController As IncomesDeskController
    Private listacompleta As New List(Of Income)
    Public Sub New()
        _incomeController = New IncomesDeskController

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        fixedLocation = Me.Location
    End Sub
    Private Sub IncomesForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            Dim parent As Dashboard
            parent = Me.MdiParent
            parent.DgvIncomes.Show()
            parent.DgvExpenditures.Show()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Private Sub IncomesForm_LocationChanged(sender As Object, e As EventArgs) Handles MyBase.LocationChanged
        Me.Location = fixedLocation
    End Sub

    Private Sub IncomesForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            listacompleta = _incomeController.ListIncomes
            For index = 0 To listacompleta.Count - 1
                DgvLista.Rows().Add()
                Dim rowAmount As Decimal = listacompleta.Item(index).Amount
                Dim rowMoment As Date = listacompleta.Item(index).Moment.Date
                Dim rowSource As String = listacompleta.Item(index).Source
                Dim rowDetails As String = listacompleta.Item(index).Details
                DgvLista.Rows.Item(index).Cells(index).Value = rowAmount
                DgvLista.Rows.Item(index).Cells(index + 1).Value = rowMoment.ToShortDateString
                DgvLista.Rows.Item(index).Cells(index + 2).Value = rowSource
                DgvLista.Rows.Item(index).Cells(index + 3).Value = rowDetails
            Next
        Catch ex As Exception
            MsgBox("Error while listing incomes")
        End Try
    End Sub

    Private Sub DgvLista_CellValidated(sender As Object, e As DataGridViewCellEventArgs) Handles DgvLista.CellValidated
        Dim cellColumn As String = DgvLista.Columns.Item(e.ColumnIndex).Name
        Dim cell As DataGridViewCell = DgvLista.Rows.Item(e.RowIndex).Cells.Item(e.ColumnIndex)
        Dim cellContentLenght As Integer = cell.GetEditedFormattedValue(cell.RowIndex, DataGridViewDataErrorContexts.Parsing).ToString().Length
        If cellContentLenght > 0 Then

            If cellColumn = "colAmount" Then
                Try
                    Dim amount As Decimal = Decimal.Parse(cell.Value.ToString)
                Catch ex As Exception
                    DgvLista.Rows.Item(e.RowIndex).SetValues(({"", "", "", ""}))
                    MsgBox("Amount must be a monetary value")
                End Try
            ElseIf cellColumn = "colMoment" Then
                Try
                    Dim moment As Date = Date.Parse(cell.Value.ToString)
                Catch ex As Exception
                    cell.Value = Nothing
                    MsgBox("Moment must be a date in the following format: day/month/year")
                End Try
            ElseIf Not (cellColumn = "colSource" Or cellColumn = "colDetails") Then
                Throw New Exception("Error when obtaining the column name for validation")
            End If
        End If
    End Sub
End Class