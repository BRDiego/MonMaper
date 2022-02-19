<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvIncomes = New System.Windows.Forms.DataGridView()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.idPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payMoment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paySource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvIncomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvIncomes
        '
        Me.DgvIncomes.AllowUserToAddRows = False
        Me.DgvIncomes.AllowUserToDeleteRows = False
        Me.DgvIncomes.AllowUserToResizeColumns = False
        Me.DgvIncomes.AllowUserToResizeRows = False
        Me.DgvIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvIncomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIncomes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvIncomes.ColumnHeadersHeight = 30
        Me.DgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DgvIncomes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPayment, Me.payAmount, Me.payMoment, Me.paySource, Me.payDetails})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIncomes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvIncomes.Location = New System.Drawing.Point(15, 258)
        Me.DgvIncomes.MultiSelect = False
        Me.DgvIncomes.Name = "DgvIncomes"
        Me.DgvIncomes.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIncomes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvIncomes.RowHeadersVisible = False
        Me.DgvIncomes.RowHeadersWidth = 33
        Me.DgvIncomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvIncomes.RowTemplate.Height = 40
        Me.DgvIncomes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvIncomes.Size = New System.Drawing.Size(595, 380)
        Me.DgvIncomes.TabIndex = 2
        '
        'PanelContent
        '
        Me.PanelContent.Controls.Add(Me.Button1)
        Me.PanelContent.Controls.Add(Me.DgvIncomes)
        Me.PanelContent.Location = New System.Drawing.Point(12, 12)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1240, 657)
        Me.PanelContent.TabIndex = 6
        Me.PanelContent.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(35, 14)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 54)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'idPayment
        '
        Me.idPayment.HeaderText = "idPayment"
        Me.idPayment.Name = "idPayment"
        Me.idPayment.ReadOnly = True
        Me.idPayment.Visible = False
        '
        'payAmount
        '
        Me.payAmount.HeaderText = "Amount"
        Me.payAmount.Name = "payAmount"
        Me.payAmount.ReadOnly = True
        '
        'payMoment
        '
        Me.payMoment.HeaderText = "Moment"
        Me.payMoment.Name = "payMoment"
        Me.payMoment.ReadOnly = True
        '
        'paySource
        '
        Me.paySource.HeaderText = "Source"
        Me.paySource.Name = "paySource"
        Me.paySource.ReadOnly = True
        '
        'payDetails
        '
        Me.payDetails.HeaderText = "Details"
        Me.payDetails.Name = "payDetails"
        Me.payDetails.ReadOnly = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGreen
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.PanelContent)
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.DgvIncomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvIncomes As DataGridView
    Friend WithEvents PanelContent As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents idPayment As DataGridViewTextBoxColumn
    Friend WithEvents payAmount As DataGridViewTextBoxColumn
    Friend WithEvents payMoment As DataGridViewTextBoxColumn
    Friend WithEvents paySource As DataGridViewTextBoxColumn
    Friend WithEvents payDetails As DataGridViewTextBoxColumn
End Class
