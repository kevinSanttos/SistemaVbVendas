<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RelatórioDeVendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_quantidade = New System.Windows.Forms.TextBox()
        Me.cbproduto = New System.Windows.Forms.ComboBox()
        Me.DataGridView_principal = New System.Windows.Forms.DataGridView()
        Me.txt_valor = New System.Windows.Forms.TextBox()
        Me.cbcliente = New System.Windows.Forms.ComboBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SeaGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioDeVendasToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.FuncionáriosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(768, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RelatórioDeVendasToolStripMenuItem
        '
        Me.RelatórioDeVendasToolStripMenuItem.Name = "RelatórioDeVendasToolStripMenuItem"
        Me.RelatórioDeVendasToolStripMenuItem.Size = New System.Drawing.Size(122, 20)
        Me.RelatórioDeVendasToolStripMenuItem.Text = "Relatório de vendas"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDoProgramaToolStripMenuItem})
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'SairDoProgramaToolStripMenuItem
        '
        Me.SairDoProgramaToolStripMenuItem.Name = "SairDoProgramaToolStripMenuItem"
        Me.SairDoProgramaToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.SairDoProgramaToolStripMenuItem.Text = "Sair do Programa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(658, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bem Vindo!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(340, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Nova venda"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Produto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(604, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Valor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(454, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Cliente"
        '
        'txt_quantidade
        '
        Me.txt_quantidade.Location = New System.Drawing.Point(518, 94)
        Me.txt_quantidade.Name = "txt_quantidade"
        Me.txt_quantidade.Size = New System.Drawing.Size(69, 20)
        Me.txt_quantidade.TabIndex = 9
        '
        'cbproduto
        '
        Me.cbproduto.FormattingEnabled = True
        Me.cbproduto.Location = New System.Drawing.Point(56, 93)
        Me.cbproduto.Name = "cbproduto"
        Me.cbproduto.Size = New System.Drawing.Size(162, 21)
        Me.cbproduto.TabIndex = 12
        '
        'DataGridView_principal
        '
        Me.DataGridView_principal.AllowUserToAddRows = False
        Me.DataGridView_principal.AllowUserToDeleteRows = False
        Me.DataGridView_principal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridView_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_principal.GridColor = System.Drawing.Color.White
        Me.DataGridView_principal.Location = New System.Drawing.Point(10, 137)
        Me.DataGridView_principal.Name = "DataGridView_principal"
        Me.DataGridView_principal.ReadOnly = True
        Me.DataGridView_principal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView_principal.Size = New System.Drawing.Size(744, 289)
        Me.DataGridView_principal.TabIndex = 42
        '
        'txt_valor
        '
        Me.txt_valor.Enabled = False
        Me.txt_valor.Location = New System.Drawing.Point(637, 94)
        Me.txt_valor.Name = "txt_valor"
        Me.txt_valor.Size = New System.Drawing.Size(69, 20)
        Me.txt_valor.TabIndex = 43
        '
        'cbcliente
        '
        Me.cbcliente.FormattingEnabled = True
        Me.cbcliente.Location = New System.Drawing.Point(274, 93)
        Me.cbcliente.Name = "cbcliente"
        Me.cbcliente.Size = New System.Drawing.Size(162, 21)
        Me.cbcliente.TabIndex = 44
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(56, 42)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(69, 20)
        Me.txtnum.TabIndex = 48
        Me.txtnum.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(198, 437)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 49
        Me.Button2.Text = "Salvar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(441, 437)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "Excluir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(149, 42)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(69, 20)
        Me.txtcodigo.TabIndex = 51
        Me.txtcodigo.Visible = False
        '
        'Menu_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(768, 472)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.cbcliente)
        Me.Controls.Add(Me.txt_valor)
        Me.Controls.Add(Me.DataGridView_principal)
        Me.Controls.Add(Me.cbproduto)
        Me.Controls.Add(Me.txt_quantidade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Menu_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView_principal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairDoProgramaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioDeVendasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_quantidade As TextBox
    Friend WithEvents cbproduto As ComboBox
    Friend WithEvents DataGridView_principal As DataGridView
    Friend WithEvents txt_valor As TextBox
    Friend WithEvents cbcliente As ComboBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txtcodigo As TextBox
End Class
