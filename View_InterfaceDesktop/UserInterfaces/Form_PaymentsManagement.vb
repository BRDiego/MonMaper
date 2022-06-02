Imports Model
Imports DesktopController
Imports System.Globalization

Public Class Form_PaymentsManagement

    Private ReadOnly _controller As PaymentsDeskController

    Private ReadOnly quickMessagesList As List(Of String)
    Private secondsCounter As Short = 0

    Private selectedPayments As Short = 0
    Private selectedRow As DataGridViewRow

    Public Sub New(ByRef controller As PaymentsDeskController)
        InitializeComponent()

        _controller = controller
        quickMessagesList = New List(Of String)

    End Sub


#Region "Logical Methods"
    Private Sub ConfigureForm()

        DTPicker_PaymentDate.MaxDate = Now.Date
        TBox_PaymentDate.Text = Now.Date.ToShortDateString

    End Sub

    Private Sub DisplayMessage() Handles Timer_QuickMessages.Tick
        Try

            If secondsCounter < 5 Then
                TBox_QuickMessage.Text = quickMessagesList(0)
                TBox_QuickMessage.Visible = True
                secondsCounter += 1
            Else
                quickMessagesList.RemoveAt(0)
                secondsCounter = 0
                If quickMessagesList.Count = 0 Then
                    TBox_QuickMessage.Visible = False
                    Timer_QuickMessages.Stop()
                End If
            End If

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Name, "Messages display timer", ex.Message)
        End Try
    End Sub

    Friend Sub SavePayment()

        Try

            Dim payment = New Payment

            If TBox_PaymentId.Text <> "" Then
                payment.Id = CInt(TBox_PaymentId.Text)
            End If

            If Combo_PaymentType.SelectedIndex = 1 Then
                payment.PaymentType = Payment.TypeOfPayment.Income
            ElseIf Combo_PaymentType.SelectedIndex = 2 Then
                payment.PaymentType = Payment.TypeOfPayment.Expenditure
            End If

            payment.Source = Combo_Source.Text
            payment.Moment = CDate(TBox_PaymentDate.Text)
            payment.Amount = CDbl(TBox_Amount.Text)
            payment.Details = TBox_Details.Text

            Dim result = _controller.AddPayment(payment)

            If result = 1 Then
                FormModel.SuccessDialog("Payment added!")

                Select Case payment.PaymentType
                    Case Payment.TypeOfPayment.Income
                        Call ListIncomes()
                    Case Payment.TypeOfPayment.Expenditure
                        Call ListExpenditures()
                End Select

            Else

                FormModel.WarningDialog(Me.Text, "Saving a payment", result.ToString)

            End If

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Payment Saving", ex.Message)
        End Try

    End Sub

    Friend Sub DeletePayment()
        Try

            Dim payment = New Payment

            With selectedRow

                payment.Id = .Cells(0).Value.ToString
                payment.Moment = .Cells(1).Value.ToString
                payment.Amount = .Cells(2).Value.ToString
                payment.Source = .Cells(3).Value.ToString
                payment.Details = .Cells(4).Value.ToString

                If .DataGridView.Name.Contains("Incomes") Then

                    payment.PaymentType = Payment.TypeOfPayment.Income

                Else

                    payment.PaymentType = Payment.TypeOfPayment.Expenditure

                End If

            End With

            Dim result = _controller.DeletePayment(payment)

            If result = 1 Then
                FormModel.SuccessDialog("Payment removed!")

                Select Case payment.PaymentType
                    Case Payment.TypeOfPayment.Income
                        Call ListIncomes()
                    Case Payment.TypeOfPayment.Expenditure
                        Call ListExpenditures()
                End Select

            Else

                FormModel.WarningDialog(Me.Text, "Deleting a payment", result.ToString)

            End If

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Deleting Payment", ex.Message)
        End Try

    End Sub

    Private Sub ListIncomes()
        Try

            Dim list = _controller.ListPayments(Payment.TypeOfPayment.Income)

            If list.Count > 0 Then

                Call FillGrid(list, DGView_Incomes)

            Else

                quickMessagesList.Add("No incomes found.")
                Timer_QuickMessages.Start()

            End If

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Listing Incomes", ex.Message)
        End Try

    End Sub

    Private Sub ListExpenditures()
        Try

            Dim list = _controller.ListPayments(Payment.TypeOfPayment.Expenditure)
            If list.Count > 0 Then

                Call FillGrid(list, DGView_Expenditures)

            Else
                quickMessagesList.Add("No expenditures found.")
                Timer_QuickMessages.Start()
            End If
        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Listing Expenditures", ex.Message)
        End Try

    End Sub

    Private Sub FillGrid(ByRef paymentsList As List(Of Payment), ByRef grid As DataGridView)
        Try

            With grid

                .Rows.Clear()

                For Each payment In paymentsList

                    Dim row = New DataGridViewRow

                    Dim rowArray(4) As Object

                    rowArray(0) = payment.Id.ToString
                    rowArray(1) = payment.Moment.ToShortDateString
                    rowArray(2) = payment.Amount.ToString()
                    rowArray(3) = payment.Source.ToString
                    rowArray(4) = payment.Details.ToString

                    row.CreateCells(grid)
                    row.SetValues(rowArray)

                    .Rows.Add(row)

                Next

            End With

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Filling grid with payments", ex.Message)
        End Try

    End Sub

    Private Sub GridContentClick(ByRef grid As DataGridView, ByRef e As DataGridViewCellEventArgs)

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

            If grid.Columns(e.ColumnIndex).Name = "check" Then

                If grid.Item(e.ColumnIndex, e.RowIndex).Value = True Then

                    selectedPayments += 1

                Else

                    selectedPayments -= 1

                End If

                selectedRow = Nothing

                If selectedPayments = 1 Then

                    UC_Actions.EnablePaymentSelected()
                    selectedRow = grid.Rows(e.RowIndex)

                ElseIf selectedPayments = 0 Then

                    UC_Actions.EnableNothingSelected()

                Else

                    UC_Actions.EnableSelectionClicked()

                End If

            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

    Private Sub GridContentDoubleClick(ByRef grid As DataGridView, ByRef e As DataGridViewCellEventArgs)

        Try

            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub

            If grid.Columns(e.ColumnIndex).Name <> "check" Then

                If FormModel.QuestionDialog("Edit this payment?") Then

                    UC_Actions.Btn_Selection_Click(Nothing, Nothing, True)

                End If

                If selectedPayments = 1 Then

                    UC_Actions.EnablePaymentSelected()

                ElseIf selectedPayments = 0 Then

                    UC_Actions.EnableNothingSelected()

                Else

                    UC_Actions.EnableSelectionClicked()

                End If

            End If

        Catch ex As Exception
            Throw
        End Try

    End Sub

#End Region


    Private Sub Form_PaymentsManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ConfigureForm()
        Call ListIncomes()
        Call ListExpenditures()

    End Sub

    Private Sub Form_PaymentsManagement_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        FormModel.AccessHomepage(Me.Name)
    End Sub

    Private Sub Form_PaymentsManagement_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

    End Sub

    Private Sub DTPicker_PaymentDate_ValueChanged(sender As Object, e As EventArgs) Handles DTPicker_PaymentDate.ValueChanged
        TBox_PaymentDate.Text = DTPicker_PaymentDate.Value.ToShortDateString
    End Sub

    Private Sub UC_Actions_Load(sender As Object, e As EventArgs) Handles UC_Actions.Load
        UC_Actions.Parent = Me
    End Sub

    Private Sub Group_PaymentData_EnabledChanged(sender As Object, e As EventArgs) Handles Group_PaymentData.EnabledChanged
        Try

            If Group_PaymentData.Enabled Then
                Btn_CancelEdit.Visible = True
            Else
                Btn_CancelEdit.Visible = False
            End If

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, e.ToString, ex.Message)
        End Try
    End Sub

    Private Sub Btn_CancelEdit_Click(sender As Object, e As EventArgs) Handles Btn_CancelEdit.Click

        Try

            Dim insertedData As Boolean = False

            For Each control In Group_PaymentData.Controls

                If TypeOf (control) Is TextBoxBase Then

                    If CType(control, TextBoxBase).Text <> "" Then
                        insertedData = True
                        Exit For
                    End If

                ElseIf TypeOf (control) Is ComboBox Then

                    If CType(control, ComboBox).Text <> "" Then
                        insertedData = True
                        Exit For
                    End If

                End If

            Next

            If insertedData Then

                If Not FormModel.QuestionDialog("The data inserted will be lost, are you sure you want to cancel the edit?") Then

                    Exit Sub

                End If

            End If

            For Each control In Group_PaymentData.Controls

                If TypeOf (control) Is TextBoxBase Then

                    CType(control, TextBoxBase).Text = ""


                ElseIf TypeOf (control) Is ComboBox Then
                    CType(control, ComboBox).Text = ""
                    CType(control, ComboBox).SelectedIndex = -1

                End If

            Next

            Group_PaymentData.Enabled = False

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Cancelling payment edit", ex.Message)
        End Try

    End Sub

    Private Sub TBox_Amount_TextChanged(sender As Object, e As EventArgs) Handles TBox_Amount.TextChanged

        Try

            TBox_Amount.Text = FormModel.FormatMoney(TBox_Amount.Text)
            TBox_Amount.SelectionStart = TBox_Amount.Text.Length

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Formating amount", ex.Message)
        End Try

    End Sub

    Private Sub DGView_Incomes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView_Incomes.CellContentClick
        Try

            GridContentClick(CType(sender, DataGridView), e)

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Incomes cell content click", ex.Message)
        End Try
    End Sub

    Private Sub DGView_Incomes_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGView_Incomes.CellContentDoubleClick
        Try

        Catch ex As Exception
            FormModel.ExceptionDialog(Me.Text, "Incomes cell content double click", ex.Message)
        End Try
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

        If dtpSelecaoMesesAno.DropDownAlign = LeftRightAlignment.Left Then
            dtpSelecaoMesesAno.DropDownAlign = LeftRightAlignment.Right
        Else
            dtpSelecaoMesesAno.DropDownAlign = LeftRightAlignment.Left
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If dtpSelecaoMesesAno.ShowCheckBox = True Then
            dtpSelecaoMesesAno.ShowCheckBox = False
        Else
            dtpSelecaoMesesAno.ShowCheckBox = True
        End If
    End Sub

    Private Sub dtpSelecaoMesesAno_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelecaoMesesAno.ValueChanged

        'If Txt_Meses.Text = "" Then



        'ElseIf Txt_Meses.Text.Count(Function(ByVal x As Char) x = ",") = 1 Then



        'Else



        'End If
        'Dim valor = dtpSelecaoMesesAno.Value.ToString("MMMM/yyyy")
        'If Txt_Meses.Text.Contains(valor) Then
        '    Txt_Meses.Text = Txt_Meses.Text.Replace(valor + ",", "")
        'Else
        '    Txt_Meses.Text = Txt_Meses.Text + valor + ","
        'End If
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        If dtpSelecaoMesesAno.ShowUpDown = True Then
            dtpSelecaoMesesAno.ShowUpDown = False
        Else
            dtpSelecaoMesesAno.ShowUpDown = True
        End If
    End Sub

    Private Sub Group_Content_Enter(sender As Object, e As EventArgs) Handles Group_Content.Enter
        If dtpSelecaoMesesAno.Checked = True Then
            dtpSelecaoMesesAno.Checked = False
        Else
            dtpSelecaoMesesAno.Checked = True
        End If
    End Sub

    Private Sub dtpSelecaoMesesAno_CloseUp(sender As Object, e As EventArgs) Handles dtpSelecaoMesesAno.CloseUp
        MsgBox("Closep")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor = dtpSelecaoMesesAno.Value.ToString("MMMM/yyyy")
        If Txt_Meses.Text.Contains(valor) Then
            Txt_Meses.Text = Txt_Meses.Text.Replace(valor + ", ", "").Replace(valor, "")
        Else

            If Txt_Meses.Text = "" Then
                Txt_Meses.Text = Txt_Meses.Text + valor + ", "
            Else
                If Txt_Meses.Text(Txt_Meses.Text.Length - 1) <> "," Then
                    Txt_Meses.Text = Txt_Meses.Text + ", " + valor + ", "
                End If

            End If

        End If

        If Txt_Meses.Text <> "" Then
            Call OrganizarMesesSelecao()

        End If
    End Sub

    Private Sub OrganizarMesesSelecao()

        Try

            Txt_Meses.Text = Txt_Meses.Text.Trim

            If Txt_Meses.Text(Txt_Meses.Text.Length - 1) = "," Then
                Txt_Meses.Text = Txt_Meses.Text.Remove(Txt_Meses.Text.Length - 1, 1)
            End If

            Dim vetor = Txt_Meses.Text.Replace(" ", "").Split(",")
            Dim vetorDatas(vetor.Length - 1) As Date
            Dim dataCompleta As String = ""

            For i As UShort = 0 To vetor.Length - 1

                dataCompleta = "01/" + vetor(i).Trim
                vetorDatas(i) = CDate(dataCompleta)

            Next

            Array.Sort(vetorDatas, Function(ByVal date1 As Date, ByVal date2 As Date) date1 < date2)

            Txt_Meses.Text = ""

            For i As UShort = 0 To vetorDatas.Length - 1

                If i = vetorDatas.Length - 1 Then

                    Txt_Meses.Text += vetorDatas(i).Date.ToString("MMMM/yyyy")

                Else

                    Txt_Meses.Text += vetorDatas(i).Date.ToString("MMMM/yyyy, ")

                End If

            Next

            If Txt_Meses.Text(Txt_Meses.Text.Length - 1) = "," Then
                Txt_Meses.Text = Txt_Meses.Text.Remove(Txt_Meses.Text.Length - 1, 1)
            End If

            Txt_Meses.Text = Txt_Meses.Text.Trim

        Catch ex As Exception
            MsgBox("Erro: " + ex.Message)
        End Try

    End Sub


End Class