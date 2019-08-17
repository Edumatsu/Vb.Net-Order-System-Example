<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProduto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbCategorias = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMarcas = New System.Windows.Forms.ComboBox()
        Me.salvar = New System.Windows.Forms.Button()
        Me.cancelar = New System.Windows.Forms.Button()
        Me.addCategoria = New System.Windows.Forms.Button()
        Me.addMarca = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'txtProNome
        '
        Me.txtProNome.Location = New System.Drawing.Point(95, 74)
        Me.txtProNome.Name = "txtProNome"
        Me.txtProNome.Size = New System.Drawing.Size(284, 20)
        Me.txtProNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Inserir/Editar Produtos"
        '
        'cmbCategorias
        '
        Me.cmbCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategorias.FormattingEnabled = True
        Me.cmbCategorias.Location = New System.Drawing.Point(95, 113)
        Me.cmbCategorias.Name = "cmbCategorias"
        Me.cmbCategorias.Size = New System.Drawing.Size(284, 21)
        Me.cmbCategorias.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Categoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Marca"
        '
        'cmbMarcas
        '
        Me.cmbMarcas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMarcas.FormattingEnabled = True
        Me.cmbMarcas.Location = New System.Drawing.Point(95, 153)
        Me.cmbMarcas.Name = "cmbMarcas"
        Me.cmbMarcas.Size = New System.Drawing.Size(284, 21)
        Me.cmbMarcas.TabIndex = 5
        '
        'salvar
        '
        Me.salvar.BackColor = System.Drawing.Color.YellowGreen
        Me.salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.salvar.Location = New System.Drawing.Point(95, 206)
        Me.salvar.Name = "salvar"
        Me.salvar.Size = New System.Drawing.Size(137, 34)
        Me.salvar.TabIndex = 7
        Me.salvar.Text = "Salvar"
        Me.salvar.UseVisualStyleBackColor = False
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(254, 206)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(125, 34)
        Me.cancelar.TabIndex = 8
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'addCategoria
        '
        Me.addCategoria.Location = New System.Drawing.Point(386, 112)
        Me.addCategoria.Name = "addCategoria"
        Me.addCategoria.Size = New System.Drawing.Size(25, 23)
        Me.addCategoria.TabIndex = 9
        Me.addCategoria.Text = "+"
        Me.addCategoria.UseVisualStyleBackColor = True
        '
        'addMarca
        '
        Me.addMarca.Location = New System.Drawing.Point(385, 152)
        Me.addMarca.Name = "addMarca"
        Me.addMarca.Size = New System.Drawing.Size(25, 23)
        Me.addMarca.TabIndex = 10
        Me.addMarca.Text = "+"
        Me.addMarca.UseVisualStyleBackColor = True
        '
        'FormProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 408)
        Me.Controls.Add(Me.addMarca)
        Me.Controls.Add(Me.addCategoria)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.salvar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbMarcas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbCategorias)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProNome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormProduto"
        Me.Text = "Inserir/Editar Produto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProNome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbCategorias As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMarcas As ComboBox
    Friend WithEvents salvar As Button
    Friend WithEvents cancelar As Button
    Friend WithEvents addCategoria As Button
    Friend WithEvents addMarca As Button
End Class
