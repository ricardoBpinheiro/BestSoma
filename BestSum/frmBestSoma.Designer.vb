<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBestSoma
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dtgDados = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSomar = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.btnTeste = New System.Windows.Forms.Button()
        CType(Me.dtgDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtgDados
        '
        Me.dtgDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgDados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero})
        Me.dtgDados.Location = New System.Drawing.Point(12, 41)
        Me.dtgDados.Name = "dtgDados"
        Me.dtgDados.Size = New System.Drawing.Size(397, 195)
        Me.dtgDados.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Números Soma"
        Me.numero.Name = "numero"
        Me.numero.Width = 250
        '
        'btnSomar
        '
        Me.btnSomar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSomar.Location = New System.Drawing.Point(319, 242)
        Me.btnSomar.Name = "btnSomar"
        Me.btnSomar.Size = New System.Drawing.Size(90, 29)
        Me.btnSomar.TabIndex = 1
        Me.btnSomar.Text = "Somar"
        Me.btnSomar.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(92, 12)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(100, 20)
        Me.txtNumero.TabIndex = 2
        '
        'lblNumero
        '
        Me.lblNumero.AutoSize = True
        Me.lblNumero.Location = New System.Drawing.Point(12, 15)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(74, 13)
        Me.lblNumero.TabIndex = 3
        Me.lblNumero.Text = "Número  Alvo:"
        '
        'btnTeste
        '
        Me.btnTeste.Location = New System.Drawing.Point(219, 242)
        Me.btnTeste.Name = "btnTeste"
        Me.btnTeste.Size = New System.Drawing.Size(94, 29)
        Me.btnTeste.TabIndex = 4
        Me.btnTeste.Text = "Teste Console"
        Me.btnTeste.UseVisualStyleBackColor = True
        '
        'frmBestSoma
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 283)
        Me.Controls.Add(Me.btnTeste)
        Me.Controls.Add(Me.lblNumero)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnSomar)
        Me.Controls.Add(Me.dtgDados)
        Me.Name = "frmBestSoma"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Best Sum"
        CType(Me.dtgDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtgDados As DataGridView
    Friend WithEvents btnSomar As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents lblNumero As Label
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents btnTeste As Button
End Class
