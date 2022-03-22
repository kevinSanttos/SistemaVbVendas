Imports System.Data.SqlClient

Public Class Menu_Principal
    Private Sub CadastroToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SairDoProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairDoProgramaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New Funcionários

        form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Menu_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        Listar()
        btn_editarvendas.Enabled = False
        btn_excluirvenda.Enabled = False
        carregarprodutos()
        carregarclientes()

    End Sub



    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New Clientes

        form.ShowDialog()
        Me.Close()
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        Dim form = New Produtos

        form.ShowDialog()
        Me.Close()

    End Sub






    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * From vendas", conex)
            da.Fill(dt)
            DataGridView_principal.DataSource = dt

            FormatarDG()

        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        DataGridView_principal.Columns(0).Visible = False
        DataGridView_principal.Columns(1).HeaderText = "Num venda"
        DataGridView_principal.Columns(2).HeaderText = "Produto"
        DataGridView_principal.Columns(3).HeaderText = "Cliente"
        DataGridView_principal.Columns(4).HeaderText = "Quantidade"
        DataGridView_principal.Columns(5).HeaderText = "Valor Total"
        DataGridView_principal.Columns(6).HeaderText = "Funcionário"
        DataGridView_principal.Columns(7).HeaderText = "Data da Venda"

    End Sub

    Private Sub DesabilitarCampos()
        cbproduto.Enabled = False
        cbcliente.Enabled = False
        txt_quantidade.Enabled = False
        txt_valor.Enabled = False

    End Sub
    Private Sub habilitarCampos()
        cbproduto.Enabled = True
        cbcliente.Enabled = True
        txt_quantidade.Enabled = True


    End Sub

    Private Sub limpar()
        cbproduto.Text = ""
        cbcliente.Text = ""
        txt_quantidade.Text = ""
        txt_valor.Text = ""
    End Sub

    Sub carregarprodutos()
        Dim DT As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Select * From produtos", conex)
            da.Fill(DT)
            cbproduto.DisplayMember = "Nome"
            cbproduto.ValueMember = "id_produto"
            cbproduto.DataSource = DT

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        habilitarCampos()
        limpar()
    End Sub

    Private Sub carregarclientes()
        Dim DT As New DataTable
        Dim da As SqlDataAdapter
        Try
            abrir()
            da = New SqlDataAdapter("Select * From clientes", conex)
            da.Fill(DT)
            cbcliente.DisplayMember = "Nome"
            cbcliente.ValueMember = "id_cliente"
            cbcliente.DataSource = DT

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        fechar()

    End Sub

    Private Sub cbproduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbproduto.SelectedIndexChanged

    End Sub



    Private Sub btn_editarvendas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_salvarvenda_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cmd As SqlCommand
        If txtnum.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarvenda", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@num_vendas", txtnum.Text)
                cmd.Parameters.AddWithValue("@id_produto", cbproduto.SelectedValue)
                cmd.Parameters.AddWithValue("@id_cliente", cbcliente.SelectedValue)
                cmd.Parameters.AddWithValue("@quantidade", txt_quantidade.Text)
                cmd.Parameters.AddWithValue("@valor", 0)



                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados!" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim cmd As SqlCommand
        If txtnum.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirvenda", conex)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_venda", txtcodigo.text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()




            Catch ex As Exception
                MessageBox.Show("Erro ao excluir os dados!" + ex.Message)
                fechar()
            End Try
        End If

    End Sub
End Class