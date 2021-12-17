Public Class IncomesForm
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
End Class