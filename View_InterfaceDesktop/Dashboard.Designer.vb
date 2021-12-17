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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DgvIncomes = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OptionsMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaymentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncomesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExpendituresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DgvExpenditures = New System.Windows.Forms.DataGridView()
        Me.PanelContent = New System.Windows.Forms.Panel()
        CType(Me.DgvIncomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DgvExpenditures, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvIncomes
        '
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvIncomes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgvIncomes.Location = New System.Drawing.Point(12, 60)
        Me.DgvIncomes.MultiSelect = False
        Me.DgvIncomes.Name = "DgvIncomes"
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
        Me.DgvIncomes.Size = New System.Drawing.Size(1223, 221)
        Me.DgvIncomes.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsMenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OptionsMenuToolStripMenuItem
        '
        Me.OptionsMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PaymentsToolStripMenuItem})
        Me.OptionsMenuToolStripMenuItem.Name = "OptionsMenuToolStripMenuItem"
        Me.OptionsMenuToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.OptionsMenuToolStripMenuItem.Text = "Options Menu"
        '
        'PaymentsToolStripMenuItem
        '
        Me.PaymentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncomesToolStripMenuItem, Me.ExpendituresToolStripMenuItem})
        Me.PaymentsToolStripMenuItem.Name = "PaymentsToolStripMenuItem"
        Me.PaymentsToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PaymentsToolStripMenuItem.Text = "Payments"
        '
        'IncomesToolStripMenuItem
        '
        Me.IncomesToolStripMenuItem.Name = "IncomesToolStripMenuItem"
        Me.IncomesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.IncomesToolStripMenuItem.Text = "Incomes"
        '
        'ExpendituresToolStripMenuItem
        '
        Me.ExpendituresToolStripMenuItem.Name = "ExpendituresToolStripMenuItem"
        Me.ExpendituresToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ExpendituresToolStripMenuItem.Text = "Expenditures"
        '
        'DgvExpenditures
        '
        Me.DgvExpenditures.AllowUserToDeleteRows = False
        Me.DgvExpenditures.AllowUserToResizeColumns = False
        Me.DgvExpenditures.AllowUserToResizeRows = False
        Me.DgvExpenditures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvExpenditures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvExpenditures.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvExpenditures.ColumnHeadersHeight = 30
        Me.DgvExpenditures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvExpenditures.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgvExpenditures.Location = New System.Drawing.Point(12, 312)
        Me.DgvExpenditures.MultiSelect = False
        Me.DgvExpenditures.Name = "DgvExpenditures"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvExpenditures.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DgvExpenditures.RowHeadersVisible = False
        Me.DgvExpenditures.RowHeadersWidth = 33
        Me.DgvExpenditures.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvExpenditures.RowTemplate.Height = 40
        Me.DgvExpenditures.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvExpenditures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DgvExpenditures.Size = New System.Drawing.Size(1223, 221)
        Me.DgvExpenditures.TabIndex = 2
        '
        'PanelContent
        '
        Me.PanelContent.Location = New System.Drawing.Point(12, 36)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1240, 597)
        Me.PanelContent.TabIndex = 6
        Me.PanelContent.Visible = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DgvExpenditures)
        Me.Controls.Add(Me.DgvIncomes)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PanelContent)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.DgvIncomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DgvExpenditures, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvIncomes As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OptionsMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IncomesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExpendituresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DgvExpenditures As DataGridView
    Friend WithEvents PanelContent As Panel
End Class
