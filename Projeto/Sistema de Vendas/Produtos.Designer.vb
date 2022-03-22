<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Produtos
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
        Me.Tot_pro = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_excluirpro = New System.Windows.Forms.Button()
        Me.btn_salvarpro = New System.Windows.Forms.Button()
        Me.btn_editarpro = New System.Windows.Forms.Button()
        Me.btn_novopro = New System.Windows.Forms.Button()
        Me.DataGridView_pro = New System.Windows.Forms.DataGridView()
        Me.txt_descricaopro = New System.Windows.Forms.TextBox()
        Me.txt_valorpro = New System.Windows.Forms.TextBox()
        Me.txt_nomepro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_buscarpro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_quantidadepro = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Voltar = New System.Windows.Forms.Button()
        CType(Me.DataGridView_pro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tot_pro
        '
        Me.Tot_pro.AutoSize = True
        Me.Tot_pro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tot_pro.Location = New System.Drawing.Point(679, 414)
        Me.Tot_pro.Name = "Tot_pro"
        Me.Tot_pro.Size = New System.Drawing.Size(0, 20)
        Me.Tot_pro.TabIndex = 68
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(620, 415)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 18)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Total:"
        '
        'btn_excluirpro
        '
        Me.btn_excluirpro.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_excluirpro.ForeColor = System.Drawing.Color.White
        Me.btn_excluirpro.Location = New System.Drawing.Point(490, 410)
        Me.btn_excluirpro.Name = "btn_excluirpro"
        Me.btn_excluirpro.Size = New System.Drawing.Size(97, 31)
        Me.btn_excluirpro.TabIndex = 66
        Me.btn_excluirpro.Text = "Excluir"
        Me.btn_excluirpro.UseVisualStyleBackColor = False
        '
        'btn_salvarpro
        '
        Me.btn_salvarpro.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_salvarpro.ForeColor = System.Drawing.Color.White
        Me.btn_salvarpro.Location = New System.Drawing.Point(337, 410)
        Me.btn_salvarpro.Name = "btn_salvarpro"
        Me.btn_salvarpro.Size = New System.Drawing.Size(97, 31)
        Me.btn_salvarpro.TabIndex = 65
        Me.btn_salvarpro.Text = "Salvar"
        Me.btn_salvarpro.UseVisualStyleBackColor = False
        '
        'btn_editarpro
        '
        Me.btn_editarpro.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_editarpro.ForeColor = System.Drawing.Color.White
        Me.btn_editarpro.Location = New System.Drawing.Point(187, 410)
        Me.btn_editarpro.Name = "btn_editarpro"
        Me.btn_editarpro.Size = New System.Drawing.Size(97, 31)
        Me.btn_editarpro.TabIndex = 64
        Me.btn_editarpro.Text = "Editar"
        Me.btn_editarpro.UseVisualStyleBackColor = False
        '
        'btn_novopro
        '
        Me.btn_novopro.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.btn_novopro.ForeColor = System.Drawing.Color.White
        Me.btn_novopro.Location = New System.Drawing.Point(40, 410)
        Me.btn_novopro.Name = "btn_novopro"
        Me.btn_novopro.Size = New System.Drawing.Size(97, 31)
        Me.btn_novopro.TabIndex = 63
        Me.btn_novopro.Text = "Novo"
        Me.btn_novopro.UseVisualStyleBackColor = False
        '
        'DataGridView_pro
        '
        Me.DataGridView_pro.AllowUserToAddRows = False
        Me.DataGridView_pro.AllowUserToDeleteRows = False
        Me.DataGridView_pro.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView_pro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_pro.GridColor = System.Drawing.Color.White
        Me.DataGridView_pro.Location = New System.Drawing.Point(17, 139)
        Me.DataGridView_pro.Name = "DataGridView_pro"
        Me.DataGridView_pro.ReadOnly = True
        Me.DataGridView_pro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_pro.Size = New System.Drawing.Size(744, 263)
        Me.DataGridView_pro.TabIndex = 62
        '
        'txt_descricaopro
        '
        Me.txt_descricaopro.Location = New System.Drawing.Point(353, 15)
        Me.txt_descricaopro.Name = "txt_descricaopro"
        Me.txt_descricaopro.Size = New System.Drawing.Size(176, 20)
        Me.txt_descricaopro.TabIndex = 58
        '
        'txt_valorpro
        '
        Me.txt_valorpro.Location = New System.Drawing.Point(143, 62)
        Me.txt_valorpro.Name = "txt_valorpro"
        Me.txt_valorpro.Size = New System.Drawing.Size(131, 20)
        Me.txt_valorpro.TabIndex = 57
        '
        'txt_nomepro
        '
        Me.txt_nomepro.Location = New System.Drawing.Point(143, 13)
        Me.txt_nomepro.Name = "txt_nomepro"
        Me.txt_nomepro.Size = New System.Drawing.Size(131, 20)
        Me.txt_nomepro.TabIndex = 56
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(85, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(282, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Quantidade"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(282, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Descrição"
        '
        'txt_buscarpro
        '
        Me.txt_buscarpro.Location = New System.Drawing.Point(611, 103)
        Me.txt_buscarpro.Name = "txt_buscarpro"
        Me.txt_buscarpro.Size = New System.Drawing.Size(150, 20)
        Me.txt_buscarpro.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(562, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Buscar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(89, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Valor"
        '
        'txt_quantidadepro
        '
        Me.txt_quantidadepro.Location = New System.Drawing.Point(353, 62)
        Me.txt_quantidadepro.Name = "txt_quantidadepro"
        Me.txt_quantidadepro.Size = New System.Drawing.Size(176, 20)
        Me.txt_quantidadepro.TabIndex = 70
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(143, 103)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(46, 20)
        Me.txtCodigo.TabIndex = 71
        Me.txtCodigo.Visible = False
        '
        'Voltar
        '
        Me.Voltar.Location = New System.Drawing.Point(2, 3)
        Me.Voltar.Name = "Voltar"
        Me.Voltar.Size = New System.Drawing.Size(62, 23)
        Me.Voltar.TabIndex = 72
        Me.Voltar.Text = "Voltar"
        Me.Voltar.UseVisualStyleBackColor = True
        '
        'Produtos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(768, 450)
        Me.Controls.Add(Me.Voltar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txt_quantidadepro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Tot_pro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btn_excluirpro)
        Me.Controls.Add(Me.btn_salvarpro)
        Me.Controls.Add(Me.btn_editarpro)
        Me.Controls.Add(Me.btn_novopro)
        Me.Controls.Add(Me.DataGridView_pro)
        Me.Controls.Add(Me.txt_descricaopro)
        Me.Controls.Add(Me.txt_valorpro)
        Me.Controls.Add(Me.txt_nomepro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_buscarpro)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Produtos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        CType(Me.DataGridView_pro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tot_pro As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btn_excluirpro As Button
    Friend WithEvents btn_salvarpro As Button
    Friend WithEvents btn_editarpro As Button
    Friend WithEvents btn_novopro As Button
    Friend WithEvents DataGridView_pro As DataGridView
    Friend WithEvents txt_descricaopro As TextBox
    Friend WithEvents txt_valorpro As TextBox
    Friend WithEvents txt_nomepro As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_buscarpro As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_quantidadepro As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Voltar As Button
End Class
