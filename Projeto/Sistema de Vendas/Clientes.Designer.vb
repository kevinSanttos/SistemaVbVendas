<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Me.Tot_cli = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_excluircli = New System.Windows.Forms.Button()
        Me.btn_salvarcli = New System.Windows.Forms.Button()
        Me.btn_editarcli = New System.Windows.Forms.Button()
        Me.btn_novocli = New System.Windows.Forms.Button()
        Me.DataGridView_cli = New System.Windows.Forms.DataGridView()
        Me.txt_telcli = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfcli = New System.Windows.Forms.MaskedTextBox()
        Me.txt_sexocli = New System.Windows.Forms.ComboBox()
        Me.txt_enderecocli = New System.Windows.Forms.TextBox()
        Me.txt_emailcli = New System.Windows.Forms.TextBox()
        Me.txt_nomecli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_buscarcli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Voltar = New System.Windows.Forms.Button()
        CType(Me.DataGridView_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tot_cli
        '
        Me.Tot_cli.AutoSize = True
        Me.Tot_cli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tot_cli.Location = New System.Drawing.Point(678, 414)
        Me.Tot_cli.Name = "Tot_cli"
        Me.Tot_cli.Size = New System.Drawing.Size(0, 20)
        Me.Tot_cli.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(619, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Total:"
        '
        'btn_excluircli
        '
        Me.btn_excluircli.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_excluircli.ForeColor = System.Drawing.Color.White
        Me.btn_excluircli.Location = New System.Drawing.Point(489, 410)
        Me.btn_excluircli.Name = "btn_excluircli"
        Me.btn_excluircli.Size = New System.Drawing.Size(97, 31)
        Me.btn_excluircli.TabIndex = 45
        Me.btn_excluircli.Text = "Excluir"
        Me.btn_excluircli.UseVisualStyleBackColor = False
        '
        'btn_salvarcli
        '
        Me.btn_salvarcli.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_salvarcli.ForeColor = System.Drawing.Color.White
        Me.btn_salvarcli.Location = New System.Drawing.Point(336, 410)
        Me.btn_salvarcli.Name = "btn_salvarcli"
        Me.btn_salvarcli.Size = New System.Drawing.Size(97, 31)
        Me.btn_salvarcli.TabIndex = 44
        Me.btn_salvarcli.Text = "Salvar"
        Me.btn_salvarcli.UseVisualStyleBackColor = False
        '
        'btn_editarcli
        '
        Me.btn_editarcli.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_editarcli.ForeColor = System.Drawing.Color.White
        Me.btn_editarcli.Location = New System.Drawing.Point(186, 410)
        Me.btn_editarcli.Name = "btn_editarcli"
        Me.btn_editarcli.Size = New System.Drawing.Size(97, 31)
        Me.btn_editarcli.TabIndex = 43
        Me.btn_editarcli.Text = "Editar"
        Me.btn_editarcli.UseVisualStyleBackColor = False
        '
        'btn_novocli
        '
        Me.btn_novocli.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_novocli.ForeColor = System.Drawing.Color.White
        Me.btn_novocli.Location = New System.Drawing.Point(39, 410)
        Me.btn_novocli.Name = "btn_novocli"
        Me.btn_novocli.Size = New System.Drawing.Size(97, 31)
        Me.btn_novocli.TabIndex = 42
        Me.btn_novocli.Text = "Novo"
        Me.btn_novocli.UseVisualStyleBackColor = False
        '
        'DataGridView_cli
        '
        Me.DataGridView_cli.AllowUserToAddRows = False
        Me.DataGridView_cli.AllowUserToDeleteRows = False
        Me.DataGridView_cli.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView_cli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_cli.GridColor = System.Drawing.Color.White
        Me.DataGridView_cli.Location = New System.Drawing.Point(16, 139)
        Me.DataGridView_cli.Name = "DataGridView_cli"
        Me.DataGridView_cli.ReadOnly = True
        Me.DataGridView_cli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_cli.Size = New System.Drawing.Size(744, 263)
        Me.DataGridView_cli.TabIndex = 41
        '
        'txt_telcli
        '
        Me.txt_telcli.Location = New System.Drawing.Point(117, 62)
        Me.txt_telcli.Mask = "(00) 00000-0000"
        Me.txt_telcli.Name = "txt_telcli"
        Me.txt_telcli.Size = New System.Drawing.Size(131, 20)
        Me.txt_telcli.TabIndex = 40
        '
        'txt_cpfcli
        '
        Me.txt_cpfcli.Location = New System.Drawing.Point(500, 11)
        Me.txt_cpfcli.Mask = "000.000.000-00"
        Me.txt_cpfcli.Name = "txt_cpfcli"
        Me.txt_cpfcli.Size = New System.Drawing.Size(131, 20)
        Me.txt_cpfcli.TabIndex = 39
        '
        'txt_sexocli
        '
        Me.txt_sexocli.FormattingEnabled = True
        Me.txt_sexocli.Items.AddRange(New Object() {"Masculino", "Feminino"})
        Me.txt_sexocli.Location = New System.Drawing.Point(313, 10)
        Me.txt_sexocli.Name = "txt_sexocli"
        Me.txt_sexocli.Size = New System.Drawing.Size(131, 21)
        Me.txt_sexocli.TabIndex = 38
        '
        'txt_enderecocli
        '
        Me.txt_enderecocli.Location = New System.Drawing.Point(313, 65)
        Me.txt_enderecocli.Name = "txt_enderecocli"
        Me.txt_enderecocli.Size = New System.Drawing.Size(131, 20)
        Me.txt_enderecocli.TabIndex = 37
        '
        'txt_emailcli
        '
        Me.txt_emailcli.Location = New System.Drawing.Point(500, 65)
        Me.txt_emailcli.Name = "txt_emailcli"
        Me.txt_emailcli.Size = New System.Drawing.Size(131, 20)
        Me.txt_emailcli.TabIndex = 36
        '
        'txt_nomecli
        '
        Me.txt_nomecli.Location = New System.Drawing.Point(117, 13)
        Me.txt_nomecli.Name = "txt_nomecli"
        Me.txt_nomecli.Size = New System.Drawing.Size(131, 20)
        Me.txt_nomecli.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Nome"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(454, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "CPF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Telefone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "E-mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(263, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Sexo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Endereço"
        '
        'txt_buscarcli
        '
        Me.txt_buscarcli.Location = New System.Drawing.Point(610, 103)
        Me.txt_buscarcli.Name = "txt_buscarcli"
        Me.txt_buscarcli.Size = New System.Drawing.Size(150, 20)
        Me.txt_buscarcli.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(561, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Buscar"
        '
        'Voltar
        '
        Me.Voltar.Location = New System.Drawing.Point(2, 2)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(62, 23)
        Me.Voltar.TabIndex = 74
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = True
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(768, 450)
        Me.Controls.Add(Me.Voltar)
        Me.Controls.Add(Me.Tot_cli)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_excluircli)
        Me.Controls.Add(Me.btn_salvarcli)
        Me.Controls.Add(Me.btn_editarcli)
        Me.Controls.Add(Me.btn_novocli)
        Me.Controls.Add(Me.DataGridView_cli)
        Me.Controls.Add(Me.txt_telcli)
        Me.Controls.Add(Me.txt_cpfcli)
        Me.Controls.Add(Me.txt_sexocli)
        Me.Controls.Add(Me.txt_enderecocli)
        Me.Controls.Add(Me.txt_emailcli)
        Me.Controls.Add(Me.txt_nomecli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_buscarcli)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DataGridView_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tot_cli As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_excluircli As Button
    Friend WithEvents btn_salvarcli As Button
    Friend WithEvents btn_editarcli As Button
    Friend WithEvents btn_novocli As Button
    Friend WithEvents DataGridView_cli As DataGridView
    Friend WithEvents txt_telcli As MaskedTextBox
    Friend WithEvents txt_cpfcli As MaskedTextBox
    Friend WithEvents txt_sexocli As ComboBox
    Friend WithEvents txt_enderecocli As TextBox
    Friend WithEvents txt_emailcli As TextBox
    Friend WithEvents txt_nomecli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_buscarcli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Voltar As Button
End Class
