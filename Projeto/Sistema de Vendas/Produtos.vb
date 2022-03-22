Imports System.Data.SqlClient

Public Class Produtos
    Private Sub Produtos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        Listar()
        btn_editarpro.Enabled = False
        btn_excluirpro.Enabled = False
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * From produtos", conex)
            da.Fill(dt)
            DataGridView_pro.DataSource = dt

            FormatarDG()

            Dim total As Integer = DataGridView_pro.Rows.Count

            Tot_pro.Text = CInt(total)

        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        DataGridView_pro.Columns(0).Visible = False
        DataGridView_pro.Columns(1).HeaderText = "Nome"
        DataGridView_pro.Columns(2).HeaderText = "descircao"
        DataGridView_pro.Columns(3).HeaderText = "quantidade"
        DataGridView_pro.Columns(4).HeaderText = "valor"

        DataGridView_pro.Columns(2).Width = 140

    End Sub

    Private Sub DesabilitarCampos()
        txt_nomepro.Enabled = False
        txt_descricaopro.Enabled = False
        txt_quantidadepro.Enabled = False
        txt_valorpro.Enabled = False

    End Sub
    Private Sub habilitarCampos()
        txt_nomepro.Enabled = True
        txt_descricaopro.Enabled = True
        txt_quantidadepro.Enabled = True
        txt_valorpro.Enabled = True

    End Sub

    Private Sub limpar()
        txt_nomepro.Text = ""
        txt_descricaopro.Text = ""
        txt_quantidadepro.Text = ""
        txt_valorpro.Text = ""
        txt_buscarpro.Text = ""

    End Sub

    Private Sub btn_novopro_Click(sender As Object, e As EventArgs) Handles btn_novopro.Click
        habilitarCampos()
        limpar()
    End Sub

    Private Sub btn_salvarpro_Click(sender As Object, e As EventArgs) Handles btn_salvarpro.Click
        Dim cmd As SqlCommand
        If txt_nomepro.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarpro", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nomepro.Text)
                cmd.Parameters.AddWithValue("@descricao", txt_descricaopro.Text)
                cmd.Parameters.AddWithValue("@quantidade", txt_quantidadepro.Text)
                cmd.Parameters.AddWithValue("@valor", txt_valorpro.Text)

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

    Private Sub DataGridView_pro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_pro.CellClick
        btn_editarpro.Enabled = True
        btn_excluirpro.Enabled = True
        habilitarCampos()


        txtCodigo.Text = DataGridView_pro.CurrentRow.Cells(0).Value
        txt_nomepro.Text = DataGridView_pro.CurrentRow.Cells(1).Value
        txt_descricaopro.Text = DataGridView_pro.CurrentRow.Cells(2).Value
        txt_quantidadepro.Text = DataGridView_pro.CurrentRow.Cells(3).Value
        txt_valorpro.Text = DataGridView_pro.CurrentRow.Cells(4).Value

    End Sub

    Private Sub btn_editarpro_Click(sender As Object, e As EventArgs) Handles btn_editarpro.Click
        Dim cmd As SqlCommand
        If txt_nomepro.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_editarpro", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nomepro.Text)
                cmd.Parameters.AddWithValue("@descricao", txt_descricaopro.Text)
                cmd.Parameters.AddWithValue("@Quantidade", txt_quantidadepro.Text)
                cmd.Parameters.AddWithValue("@valor", txt_valorpro.Text)
                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()

            Catch ex As Exception
                MessageBox.Show("Erro ao editar os dados!" + ex.Message)
                fechar()
            End Try
        End If
    End Sub

    Private Sub btn_excluirpro_Click(sender As Object, e As EventArgs) Handles btn_excluirpro.Click
        Dim cmd As SqlCommand
        If txtCodigo.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirpro", conex)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@id_produto", txtCodigo.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()

                btn_excluirpro.Enabled = False
                btn_editarpro.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados!" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub txt_buscarpro_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarpro.TextChanged

    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dim form = New Menu_Principal
        form.ShowDialog()
        Me.Close()
    End Sub
End Class