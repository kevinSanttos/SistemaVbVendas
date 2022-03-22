<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funcionários
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_endereco = New System.Windows.Forms.TextBox()
        Me.txt_sexo = New System.Windows.Forms.ComboBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.DataGridView = New System.Windows.Forms.DataGridView()
        Me.btn_novofunc = New System.Windows.Forms.Button()
        Me.btn_editarfunc = New System.Windows.Forms.Button()
        Me.btn_salvarfunc = New System.Windows.Forms.Button()
        Me.btn_excluirfunc = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Tot_func = New System.Windows.Forms.Label()
        Me.Voltar = New System.Windows.Forms.Button()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(557, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(606, 104)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(150, 20)
        Me.txt_buscar.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(249, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Endereço"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(261, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "E-mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(452, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CPF"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(115, 14)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(131, 20)
        Me.txt_nome.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(66, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Nome"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(498, 66)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(131, 20)
        Me.txt_email.TabIndex = 15
        '
        'txt_endereco
        '
        Me.txt_endereco.Location = New System.Drawing.Point(307, 63)
        Me.txt_endereco.Name = "txt_endereco"
        Me.txt_endereco.Size = New System.Drawing.Size(131, 20)
        Me.txt_endereco.TabIndex = 16
        '
        'txt_sexo
        '
        Me.txt_sexo.FormattingEnabled = True
        Me.txt_sexo.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.txt_sexo.Location = New System.Drawing.Point(311, 11)
        Me.txt_sexo.Name = "txt_sexo"
        Me.txt_sexo.Size = New System.Drawing.Size(121, 21)
        Me.txt_sexo.TabIndex = 17
        '
        'txt_cpf
        '
        Me.txt_cpf.Location = New System.Drawing.Point(498, 12)
        Me.txt_cpf.Mask = "000.000.000-00"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(131, 20)
        Me.txt_cpf.TabIndex = 18
        '
        'txt_tel
        '
        Me.txt_tel.Location = New System.Drawing.Point(115, 60)
        Me.txt_tel.Mask = "(00) 00000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(131, 20)
        Me.txt_tel.TabIndex = 19
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.GridColor = System.Drawing.Color.White
        Me.DataGridView.Location = New System.Drawing.Point(12, 140)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(744, 263)
        Me.DataGridView.TabIndex = 20
        '
        'btn_novofunc
        '
        Me.btn_novofunc.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_novofunc.ForeColor = System.Drawing.Color.White
        Me.btn_novofunc.Location = New System.Drawing.Point(35, 411)
        Me.btn_novofunc.Name = "btn_novofunc"
        Me.btn_novofunc.Size = New System.Drawing.Size(97, 31)
        Me.btn_novofunc.TabIndex = 21
        Me.btn_novofunc.Text = "Novo"
        Me.btn_novofunc.UseVisualStyleBackColor = False
        '
        'btn_editarfunc
        '
        Me.btn_editarfunc.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_editarfunc.ForeColor = System.Drawing.Color.White
        Me.btn_editarfunc.Location = New System.Drawing.Point(182, 411)
        Me.btn_editarfunc.Name = "btn_editarfunc"
        Me.btn_editarfunc.Size = New System.Drawing.Size(97, 31)
        Me.btn_editarfunc.TabIndex = 22
        Me.btn_editarfunc.Text = "Editar"
        Me.btn_editarfunc.UseVisualStyleBackColor = False
        '
        'btn_salvarfunc
        '
        Me.btn_salvarfunc.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_salvarfunc.ForeColor = System.Drawing.Color.White
        Me.btn_salvarfunc.Location = New System.Drawing.Point(332, 411)
        Me.btn_salvarfunc.Name = "btn_salvarfunc"
        Me.btn_salvarfunc.Size = New System.Drawing.Size(97, 31)
        Me.btn_salvarfunc.TabIndex = 23
        Me.btn_salvarfunc.Text = "Salvar"
        Me.btn_salvarfunc.UseVisualStyleBackColor = False
        '
        'btn_excluirfunc
        '
        Me.btn_excluirfunc.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_excluirfunc.ForeColor = System.Drawing.Color.White
        Me.btn_excluirfunc.Location = New System.Drawing.Point(485, 411)
        Me.btn_excluirfunc.Name = "btn_excluirfunc"
        Me.btn_excluirfunc.Size = New System.Drawing.Size(97, 31)
        Me.btn_excluirfunc.TabIndex = 24
        Me.btn_excluirfunc.Text = "Excluir"
        Me.btn_excluirfunc.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(615, 416)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Total:"
        '
        'Tot_func
        '
        Me.Tot_func.AutoSize = True
        Me.Tot_func.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tot_func.Location = New System.Drawing.Point(674, 415)
        Me.Tot_func.Name = "Tot_func"
        Me.Tot_func.Size = New System.Drawing.Size(0, 20)
        Me.Tot_func.TabIndex = 26
        '
        'Voltar
        '
        Me.Voltar.Location = New System.Drawing.Point(2, 1)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(62, 23)
        Me.Voltar.TabIndex = 73
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = True
        '
        'Funcionários
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(768, 450)
        Me.Controls.Add(Me.Voltar)
        Me.Controls.Add(Me.Tot_func)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_excluirfunc)
        Me.Controls.Add(Me.btn_salvarfunc)
        Me.Controls.Add(Me.btn_editarfunc)
        Me.Controls.Add(Me.btn_novofunc)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.txt_tel)
        Me.Controls.Add(Me.txt_cpf)
        Me.Controls.Add(Me.txt_sexo)
        Me.Controls.Add(Me.txt_endereco)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Funcionários"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Funcionários"
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_endereco As TextBox
    Friend WithEvents txt_sexo As ComboBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents DataGridView As DataGridView
    Friend WithEvents btn_novofunc As Button
    Friend WithEvents btn_editarfunc As Button
    Friend WithEvents btn_salvarfunc As Button
    Friend WithEvents btn_excluirfunc As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Tot_func As Label
    Friend WithEvents Voltar As Button
End Class
