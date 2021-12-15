<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnTeste = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgcolQuantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolMomento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolFonte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolDetalhes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTeste
        '
        Me.btnTeste.Location = New System.Drawing.Point(932, 12)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(139, 39)
        Me.btnTeste.TabIndex = 1
        Me.btnTeste.Text = "Teste fill table"
        Me.btnTeste.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcolQuantia, Me.dgcolMomento, Me.dgcolFonte, Me.dgcolDetalhes})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 105)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(1240, 221)
        Me.DataGridView1.TabIndex = 2
        '
        'dgcolQuantia
        '
        Me.dgcolQuantia.HeaderText = "Quantia"
        Me.dgcolQuantia.Name = "dgcolQuantia"
        '
        'dgcolMomento
        '
        Me.dgcolMomento.HeaderText = "Momento"
        Me.dgcolMomento.Name = "dgcolMomento"
        '
        'dgcolFonte
        '
        Me.dgcolFonte.HeaderText = "Fonte"
        Me.dgcolFonte.Name = "dgcolFonte"
        '
        'dgcolDetalhes
        '
        Me.dgcolDetalhes.HeaderText = "Detalhes"
        Me.dgcolDetalhes.Name = "dgcolDetalhes"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnTeste)
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTeste As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgcolQuantia As DataGridViewTextBoxColumn
    Friend WithEvents dgcolMomento As DataGridViewTextBoxColumn
    Friend WithEvents dgcolFonte As DataGridViewTextBoxColumn
    Friend WithEvents dgcolDetalhes As DataGridViewTextBoxColumn
End Class
