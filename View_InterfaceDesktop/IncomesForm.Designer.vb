<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IncomesForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvLista = New System.Windows.Forms.DataGridView()
        Me.colAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMoment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvLista
        '
        Me.DgvLista.AllowUserToResizeColumns = False
        Me.DgvLista.AllowUserToResizeRows = False
        Me.DgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvLista.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvLista.ColumnHeadersHeight = 30
        Me.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvLista.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colAmount, Me.colMoment, Me.colSource, Me.colDetails})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvLista.DefaultCellStyle = DataGridViewCellStyle4
        Me.DgvLista.Location = New System.Drawing.Point(12, 141)
        Me.DgvLista.MultiSelect = False
        Me.DgvLista.Name = "DgvLista"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvLista.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvLista.RowHeadersVisible = False
        Me.DgvLista.RowHeadersWidth = 33
        Me.DgvLista.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvLista.RowTemplate.Height = 40
        Me.DgvLista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvLista.Size = New System.Drawing.Size(1200, 528)
        Me.DgvLista.TabIndex = 3
        '
        'colAmount
        '
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colAmount.DefaultCellStyle = DataGridViewCellStyle2
        Me.colAmount.HeaderText = "Amount"
        Me.colAmount.Name = "colAmount"
        '
        'colMoment
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colMoment.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMoment.HeaderText = "Moment"
        Me.colMoment.Name = "colMoment"
        '
        'colSource
        '
        Me.colSource.HeaderText = "Source"
        Me.colSource.Name = "colSource"
        '
        'colDetails
        '
        Me.colDetails.HeaderText = "Details"
        Me.colDetails.Name = "colDetails"
        '
        'IncomesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1224, 681)
        Me.Controls.Add(Me.DgvLista)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1240, 720)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1240, 720)
        Me.Name = "IncomesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "IncomesForm"
        CType(Me.DgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvLista As DataGridView
    Friend WithEvents colAmount As DataGridViewTextBoxColumn
    Friend WithEvents colMoment As DataGridViewTextBoxColumn
    Friend WithEvents colSource As DataGridViewTextBoxColumn
    Friend WithEvents colDetails As DataGridViewTextBoxColumn
End Class
