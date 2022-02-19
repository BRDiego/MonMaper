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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GridIncomes = New System.Windows.Forms.DataGridView()
        Me.idPayment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payMoment = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paySource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.LblAux = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupNewPayment = New System.Windows.Forms.GroupBox()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAddPayment = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.TxtMoment = New System.Windows.Forms.TextBox()
        Me.TxtDetails = New System.Windows.Forms.TextBox()
        Me.TxtSource = New System.Windows.Forms.TextBox()
        Me.BtnDeletePayment = New System.Windows.Forms.Button()
        Me.BtnNewPayment = New System.Windows.Forms.Button()
        Me.BtnSaveChanges = New System.Windows.Forms.Button()
        Me.BtnReloadData = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TimerAutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.TimerMessages = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GridIncomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContent.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupNewPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridIncomes
        '
        Me.GridIncomes.AllowUserToAddRows = False
        Me.GridIncomes.AllowUserToDeleteRows = False
        Me.GridIncomes.AllowUserToOrderColumns = True
        Me.GridIncomes.AllowUserToResizeColumns = False
        Me.GridIncomes.AllowUserToResizeRows = False
        Me.GridIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GridIncomes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridIncomes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridIncomes.ColumnHeadersHeight = 30
        Me.GridIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GridIncomes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPayment, Me.payAmount, Me.payMoment, Me.paySource, Me.payDetails})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridIncomes.DefaultCellStyle = DataGridViewCellStyle8
        Me.GridIncomes.Location = New System.Drawing.Point(6, 184)
        Me.GridIncomes.MultiSelect = False
        Me.GridIncomes.Name = "GridIncomes"
        Me.GridIncomes.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridIncomes.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridIncomes.RowHeadersVisible = False
        Me.GridIncomes.RowHeadersWidth = 33
        Me.GridIncomes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GridIncomes.RowTemplate.Height = 30
        Me.GridIncomes.RowTemplate.ReadOnly = True
        Me.GridIncomes.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridIncomes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridIncomes.Size = New System.Drawing.Size(595, 436)
        Me.GridIncomes.TabIndex = 2
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
        'PanelContent
        '
        Me.PanelContent.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.PanelContent.Controls.Add(Me.LblAux)
        Me.PanelContent.Controls.Add(Me.GroupBox1)
        Me.PanelContent.Controls.Add(Me.Label2)
        Me.PanelContent.Location = New System.Drawing.Point(4, 4)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1256, 672)
        Me.PanelContent.TabIndex = 6
        '
        'LblAux
        '
        Me.LblAux.AutoSize = True
        Me.LblAux.Font = New System.Drawing.Font("Sitka Small", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblAux.Location = New System.Drawing.Point(8, 5)
        Me.LblAux.Name = "LblAux"
        Me.LblAux.Size = New System.Drawing.Size(0, 33)
        Me.LblAux.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupNewPayment)
        Me.GroupBox1.Controls.Add(Me.GridIncomes)
        Me.GroupBox1.Controls.Add(Me.BtnDeletePayment)
        Me.GroupBox1.Controls.Add(Me.BtnNewPayment)
        Me.GroupBox1.Controls.Add(Me.BtnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.BtnReloadData)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1240, 626)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'GroupNewPayment
        '
        Me.GroupNewPayment.Controls.Add(Me.ComboType)
        Me.GroupNewPayment.Controls.Add(Me.Label1)
        Me.GroupNewPayment.Controls.Add(Me.Label6)
        Me.GroupNewPayment.Controls.Add(Me.Label4)
        Me.GroupNewPayment.Controls.Add(Me.Label3)
        Me.GroupNewPayment.Controls.Add(Me.BtnAddPayment)
        Me.GroupNewPayment.Controls.Add(Me.Label5)
        Me.GroupNewPayment.Controls.Add(Me.TxtAmount)
        Me.GroupNewPayment.Controls.Add(Me.TxtMoment)
        Me.GroupNewPayment.Controls.Add(Me.TxtDetails)
        Me.GroupNewPayment.Controls.Add(Me.TxtSource)
        Me.GroupNewPayment.Enabled = False
        Me.GroupNewPayment.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupNewPayment.Location = New System.Drawing.Point(6, 71)
        Me.GroupNewPayment.Name = "GroupNewPayment"
        Me.GroupNewPayment.Size = New System.Drawing.Size(1186, 102)
        Me.GroupNewPayment.TabIndex = 6
        Me.GroupNewPayment.TabStop = False
        Me.GroupNewPayment.Text = "Add new payment"
        '
        'ComboType
        '
        Me.ComboType.Font = New System.Drawing.Font("Sitka Small", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"", "1 - Income", "2 - Expenditure"})
        Me.ComboType.Location = New System.Drawing.Point(880, 63)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(116, 27)
        Me.ComboType.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(10, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Amount:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(819, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(425, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Source:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(228, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date:"
        '
        'BtnAddPayment
        '
        Me.BtnAddPayment.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddPayment.Enabled = False
        Me.BtnAddPayment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnAddPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.BtnAddPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAddPayment.ForeColor = System.Drawing.Color.White
        Me.BtnAddPayment.Location = New System.Drawing.Point(1016, 25)
        Me.BtnAddPayment.Name = "BtnAddPayment"
        Me.BtnAddPayment.Size = New System.Drawing.Size(151, 67)
        Me.BtnAddPayment.TabIndex = 3
        Me.BtnAddPayment.Text = "ADD PAYMENT"
        Me.BtnAddPayment.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(10, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Details:"
        '
        'TxtAmount
        '
        Me.TxtAmount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtAmount.Location = New System.Drawing.Point(99, 25)
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(113, 29)
        Me.TxtAmount.TabIndex = 4
        '
        'TxtMoment
        '
        Me.TxtMoment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtMoment.Location = New System.Drawing.Point(287, 25)
        Me.TxtMoment.Name = "TxtMoment"
        Me.TxtMoment.Size = New System.Drawing.Size(113, 29)
        Me.TxtMoment.TabIndex = 4
        '
        'TxtDetails
        '
        Me.TxtDetails.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtDetails.Location = New System.Drawing.Point(99, 63)
        Me.TxtDetails.Name = "TxtDetails"
        Me.TxtDetails.Size = New System.Drawing.Size(702, 29)
        Me.TxtDetails.TabIndex = 4
        '
        'TxtSource
        '
        Me.TxtSource.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtSource.Location = New System.Drawing.Point(514, 25)
        Me.TxtSource.Name = "TxtSource"
        Me.TxtSource.Size = New System.Drawing.Size(482, 29)
        Me.TxtSource.TabIndex = 4
        '
        'BtnDeletePayment
        '
        Me.BtnDeletePayment.BackColor = System.Drawing.Color.Crimson
        Me.BtnDeletePayment.Enabled = False
        Me.BtnDeletePayment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeletePayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnDeletePayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.BtnDeletePayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDeletePayment.ForeColor = System.Drawing.Color.White
        Me.BtnDeletePayment.Location = New System.Drawing.Point(483, 17)
        Me.BtnDeletePayment.Name = "BtnDeletePayment"
        Me.BtnDeletePayment.Size = New System.Drawing.Size(249, 48)
        Me.BtnDeletePayment.TabIndex = 3
        Me.BtnDeletePayment.Text = "DELETE SELECTED PAYMENT"
        Me.BtnDeletePayment.UseVisualStyleBackColor = False
        '
        'BtnNewPayment
        '
        Me.BtnNewPayment.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnNewPayment.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNewPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnNewPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.BtnNewPayment.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnNewPayment.ForeColor = System.Drawing.Color.White
        Me.BtnNewPayment.Location = New System.Drawing.Point(6, 17)
        Me.BtnNewPayment.Name = "BtnNewPayment"
        Me.BtnNewPayment.Size = New System.Drawing.Size(157, 48)
        Me.BtnNewPayment.TabIndex = 3
        Me.BtnNewPayment.Text = "NEW PAYMENT"
        Me.BtnNewPayment.UseVisualStyleBackColor = False
        '
        'BtnSaveChanges
        '
        Me.BtnSaveChanges.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnSaveChanges.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSaveChanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnSaveChanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.BtnSaveChanges.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSaveChanges.ForeColor = System.Drawing.Color.White
        Me.BtnSaveChanges.Location = New System.Drawing.Point(357, 17)
        Me.BtnSaveChanges.Name = "BtnSaveChanges"
        Me.BtnSaveChanges.Size = New System.Drawing.Size(99, 48)
        Me.BtnSaveChanges.TabIndex = 3
        Me.BtnSaveChanges.Text = "SAVE"
        Me.BtnSaveChanges.UseVisualStyleBackColor = False
        '
        'BtnReloadData
        '
        Me.BtnReloadData.BackColor = System.Drawing.Color.DarkBlue
        Me.BtnReloadData.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnReloadData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.BtnReloadData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue
        Me.BtnReloadData.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnReloadData.ForeColor = System.Drawing.Color.White
        Me.BtnReloadData.Location = New System.Drawing.Point(182, 17)
        Me.BtnReloadData.Name = "BtnReloadData"
        Me.BtnReloadData.Size = New System.Drawing.Size(157, 48)
        Me.BtnReloadData.TabIndex = 3
        Me.BtnReloadData.Text = "RELOAD DATA"
        Me.BtnReloadData.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MV Boli", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(435, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(369, 46)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "D A S H B O A R D"
        '
        'TimerAutoSave
        '
        Me.TimerAutoSave.Interval = 180000
        '
        'TimerMessages
        '
        Me.TimerMessages.Interval = 1000
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
        Me.Text = "MonMaper - Money Management Helper"
        CType(Me.GridIncomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContent.ResumeLayout(False)
        Me.PanelContent.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupNewPayment.ResumeLayout(False)
        Me.GroupNewPayment.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridIncomes As DataGridView
    Friend WithEvents PanelContent As Panel
    Friend WithEvents idPayment As DataGridViewTextBoxColumn
    Friend WithEvents payAmount As DataGridViewTextBoxColumn
    Friend WithEvents payMoment As DataGridViewTextBoxColumn
    Friend WithEvents paySource As DataGridViewTextBoxColumn
    Friend WithEvents payDetails As DataGridViewTextBoxColumn
    Friend WithEvents BtnDeletePayment As Button
    Friend WithEvents TxtDetails As TextBox
    Friend WithEvents TxtSource As TextBox
    Friend WithEvents TxtMoment As TextBox
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupNewPayment As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAddPayment As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnNewPayment As Button
    Friend WithEvents BtnReloadData As Button
    Friend WithEvents BtnSaveChanges As Button
    Friend WithEvents LblAux As Label
    Friend WithEvents TimerAutoSave As Timer
    Friend WithEvents TimerMessages As Timer
End Class
