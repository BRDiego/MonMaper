Imports DesktopController
Imports Model
Imports System.Linq

Public Class Dashboard
    Private ReadOnly _ExpenditureController As ExpendituresDeskController
    Private ReadOnly _IncomeController As IncomesDeskController
    Private lista As New List(Of Income)
    Private rowId As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        'Applying a kind of hard-coded "Dependency Injection" here
        _ExpenditureController = New ExpendituresDeskController
        _IncomeController = New IncomesDeskController
    End Sub

    Private Sub btnTeste_Click(sender As Object, e As EventArgs) Handles btnTeste.Click, Button3.Click, Button2.Click, Button1.Click
        lista = _IncomeController.ListIncomes
        dgvIncomes.DataSource = lista
        MsgBox("Listado")
    End Sub

    Private Sub testarlistacomp_Click(sender As Object, e As EventArgs) Handles testarlistacomp.Click
        Dim novalista As New List(Of Income)
        Dim n1 As New Income()
        n1.Amount = 300
        n1.Moment = #12-12-2021#
        n1.Source = "Trabalho"
        n1.Details = "Teste novo"
        Dim n2 As New Income()
        n2 = Nothing

        novalista.Add(n1)
        novalista.Add(n2)

        Dim aux As New Income
        For Each ele As Income In novalista
            If IsNothing(ele) Then
                MsgBox("é nulo hehe")
            ElseIf Not ele.Equals(aux) Then
                aux = ele
            End If
        Next
    End Sub

    Private Sub dgvIncomes_RowLeave(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub dgvIncomes_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
        rowId = e.RowIndex
    End Sub

    Private Sub dgvIncomes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvIncomes.CellEndEdit
        Dim amountSetted As Boolean = IsNothing(dgvIncomes.Rows.Item(rowId).Cells.Item(0).Value)
        Dim dateSetted As Boolean = IsNothing(dgvIncomes.Rows.Item(rowId).Cells.Item(1).Value)
        Dim sourceSetted As Boolean = IsNothing(dgvIncomes.Rows.Item(rowId).Cells.Item(2).Value)
        If amountSetted Or dateSetted Or sourceSetted Then
            'MsgBox("Apenas o atributo Detalhes é opcional. Preencha os outros.")
            Exit Sub
        End If
        Try
            Dim inAmount As Decimal = dgvIncomes.Rows.Item(rowId).Cells.Item(0).Value
            Dim inDate As Date = Date.Parse(dgvIncomes.Rows.Item(rowId).Cells.Item(1).Value.ToString)
            Dim inSource As String = dgvIncomes.Rows.Item(rowId).Cells.Item(2).Value.ToString
            Dim inDetails As String = ""
            If Not IsNothing(dgvIncomes.Rows.Item(rowId).Cells.Item(3).Value) Then
                inDetails = dgvIncomes.Rows.Item(rowId).Cells.Item(3).Value.ToString
            End If


            Dim editedIncome As New Income(inAmount, inDate, inSource, inDetails)
            'Dim found = lista.FirstOrDefault(Function(item As Income) item.Equals(editedIncome))
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
    End Sub
End Class