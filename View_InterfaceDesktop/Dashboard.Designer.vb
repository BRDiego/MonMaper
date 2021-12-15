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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnTeste = New System.Windows.Forms.Button()
        Me.dgvIncomes = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.testarlistacomp = New System.Windows.Forms.Button()
        Me.dgcolQuantia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolMomento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolFonte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgcolDetalhes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvIncomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTeste
        '
        Me.btnTeste.Location = New System.Drawing.Point(852, 12)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(139, 39)
        Me.btnTeste.TabIndex = 1
        Me.btnTeste.Text = "remover"
        Me.btnTeste.UseVisualStyleBackColor = True
        '
        'dgvIncomes
        '
        Me.dgvIncomes.AllowUserToDeleteRows = False
        Me.dgvIncomes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvIncomes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncomes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgcolQuantia, Me.dgcolMomento, Me.dgcolFonte, Me.dgcolDetalhes})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvIncomes.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvIncomes.Location = New System.Drawing.Point(12, 128)
        Me.dgvIncomes.Name = "dgvIncomes"
        Me.dgvIncomes.RowHeadersVisible = False
        Me.dgvIncomes.RowTemplate.Height = 25
        Me.dgvIncomes.Size = New System.Drawing.Size(1240, 221)
        Me.dgvIncomes.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 39)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "listar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(680, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "listar por mes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1098, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Teste fill table"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'testarlistacomp
        '
        Me.testarlistacomp.Location = New System.Drawing.Point(125, 12)
        Me.testarlistacomp.Name = "testarlistacomp"
        Me.testarlistacomp.Size = New System.Drawing.Size(139, 39)
        Me.testarlistacomp.TabIndex = 1
        Me.testarlistacomp.Text = "testar comparacao"
        Me.testarlistacomp.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.NullValue = """"""
        Me.dgcolDetalhes.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgcolDetalhes.HeaderText = "Detalhes"
        Me.dgcolDetalhes.Name = "dgcolDetalhes"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.dgvIncomes)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.testarlistacomp)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnTeste)
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        CType(Me.dgvIncomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnTeste As Button
    Friend WithEvents dgvIncomes As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents testarlistacomp As Button
    Friend WithEvents dgcolQuantia As DataGridViewTextBoxColumn
    Friend WithEvents dgcolMomento As DataGridViewTextBoxColumn
    Friend WithEvents dgcolFonte As DataGridViewTextBoxColumn
    Friend WithEvents dgcolDetalhes As DataGridViewTextBoxColumn
End Class
