Imports DesktopController
Imports Model
Imports System.Linq

Public Class Dashboard
    Private ReadOnly _PaymentController As PaymentsDeskController

    Private selectedRow As Short
    Private changesMade As Boolean
    Private messageCounter As Short
    Private errorMessage As String
    Private objPayment As New Payment

    Public Sub New()
        InitializeComponent()
        'Applying a kind of hard-coded "Dependency Injection" here
        _PaymentController = New PaymentsDeskController()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            GridIncomes.EditMode = DataGridViewEditMode.EditProgrammatically
            TimerAutoSave.Start()

        Catch ex As Exception
            MsgBox("Error while loading interface!" + vbCrLf + "Try again or contact the developer about it.", MsgBoxStyle.Critical, "MonMaper LOADING ERROR!!!")
        End Try

    End Sub

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            TimerAutoSave_Tick(Nothing, Nothing)
        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub UserFeedback(ByVal message As String, ByVal messageOfError As String)

        Try

            If messageOfError.Length > 0 Then
                LblAux.Text = "An error occurred (click HERE to see it)"
                errorMessage = messageOfError
            Else
                LblAux.Text = message
            End If

        Catch ex As Exception
            MsgBox("Error while showing temporary messages: " + vbCrLf + ex.Message, MsgBoxStyle.Critical, "MonMaper message showing error")
        End Try

    End Sub

    Private Sub LblAux_Click(sender As Object, e As EventArgs) Handles LblAux.Click
        Try
            If errorMessage.Length > 0 Then
                MsgBox(errorMessage, MsgBoxStyle.Critical, "Error message")
            End If
        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub LblAux_TextChanged(sender As Object, e As EventArgs) Handles LblAux.TextChanged
        Try
            If LblAux.Text.Length > 0 Then
                TimerMessages.Start()
            End If

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub TimerMessages_Tick(sender As Object, e As EventArgs) Handles TimerMessages.Tick
        Try

            If messageCounter = 5 Then
                LblAux.Text = ""
                messageCounter = 0
                TimerMessages.Stop()
            Else
                messageCounter += 1
            End If

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub TimerAutoSave_Tick(sender As Object, e As EventArgs) Handles TimerAutoSave.Tick
        Try

            If changesMade Then
                If MsgBox("There are unsaved changes, would you like to save them?", vbQuestion + vbYesNo, "Unsaved changes") = MsgBoxResult.Yes Then
                    BtnSaveChanges_Click(Nothing, Nothing)
                End If
            End If

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub BtnAddPayment_Click(sender As Object, e As EventArgs) Handles BtnAddPayment.Click
        Try

            If Not IsNumeric(TxtAmount.Text.Trim) Then
                UserFeedback("Please verify the payment value.", "")
                TxtAmount.Focus()
                Exit Sub
            End If

            If Not IsDate(TxtMoment.Text) Then
                UserFeedback("Please verify the date value.", "")
                TxtMoment.Focus()
                Exit Sub
            End If

            If TxtSource.Text.Trim = "" Then
                UserFeedback("Please verify the source value.", "")
                TxtSource.Focus()
                Exit Sub
            End If

            If ComboType.SelectedIndex < 1 Then
                UserFeedback("Please select the payment type.", "")
                ComboType.Focus()
                Exit Sub
            End If

            If ComboType.SelectedIndex = 1 Then
                With GridIncomes

                    .Rows.Add()

                    ' add new row values
                End With
            Else

            End If


            objPayment.Amount = CDec(TxtAmount.Text)
            objPayment.Moment = CDate(TxtMoment.Text)
            objPayment.Source = TxtSource.Text
            objPayment.Details = TxtDetails.Text.Trim
            objPayment.PaymentType = ComboType.SelectedIndex


        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub BtnNewPayment_Click(sender As Object, e As EventArgs) Handles BtnNewPayment.Click
        Try

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub BtnReloadData_Click(sender As Object, e As EventArgs) Handles BtnReloadData.Click
        Try

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub BtnSaveChanges_Click(sender As Object, e As EventArgs, Optional automatic As String = "") Handles BtnSaveChanges.Click
        Try

            Call UserFeedback("Data saved successfully!" + automatic, "")

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub BtnDeletePayment_Click(sender As Object, e As EventArgs) Handles BtnDeletePayment.Click
        Try

            If MsgBox("Are you sure you want to delete this payment permanently?" + vbCrLf + "It won't be possible to recover it!", vbExclamation + vbYesNo, "Delete register") = MsgBoxResult.No Then Exit Sub

            If MsgBox("The payment register will be permanently deleted. Do you confirm this action?", vbQuestion + vbYesNo, "Delete register") = MsgBoxResult.No Then Exit Sub


            _PaymentController.DeletePayment(New Payment)

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub GridIncomes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridIncomes.CellClick
        Try

            If e.RowIndex >= 0 Then
                selectedRow = e.RowIndex
            End If

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub GridIncomes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridIncomes.CellDoubleClick
        Try

            If e.RowIndex >= 0 Then
                GridIncomes.BeginEdit(False)
            End If

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

    Private Sub GridIncomes_CellLeave(sender As Object, e As DataGridViewCellEventArgs) Handles GridIncomes.CellLeave
        Try

            BtnDeletePayment.Enabled = False

        Catch ex As Exception
            Call UserFeedback("", ex.Message)
        End Try
    End Sub

End Class