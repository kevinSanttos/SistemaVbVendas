Imports System.Data.SqlClient

Public Class Funcionários
    Private dg As Object

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Funcionários_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        Listar()
        btn_editarfunc.Enabled = False
        btn_excluirfunc.Enabled = False
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * From funcionarios", conex)
            da.Fill(dt)
            DataGridView.DataSource = dt

            FormatarDG()

            Dim total As Integer = DataGridView.Rows.Count

            Tot_func.Text = CInt(total)

        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        DataGridView.Columns(0).Visible = False
        DataGridView.Columns(1).HeaderText = "Nome"
        DataGridView.Columns(2).HeaderText = "Sexo"
        DataGridView.Columns(3).HeaderText = "CPF"
        DataGridView.Columns(4).HeaderText = "Endereço"
        DataGridView.Columns(5).HeaderText = "Telefone"
        DataGridView.Columns(6).HeaderText = "Email"

        DataGridView.Columns(6).Width = 140
        DataGridView.Columns(1).Width = 140

    End Sub

    Private Sub DesabilitarCampos()
        txt_nome.Enabled = False
        txt_sexo.Enabled = False
        txt_tel.Enabled = False
        txt_email.Enabled = False
        txt_cpf.Enabled = False
        txt_endereco.Enabled = False


    End Sub
    Private Sub habilitarCampos()
        txt_nome.Enabled = True
        txt_sexo.Enabled = True
        txt_tel.Enabled = True
        txt_email.Enabled = True
        txt_cpf.Enabled = True
        txt_endereco.Enabled = True


    End Sub

    Private Sub limpar()
        txt_nome.Text = ""
        txt_tel.Text = ""
        txt_email.Text = ""
        txt_cpf.Text = ""
        txt_endereco.Text = ""
        txt_buscar.Text = ""

    End Sub

    Private Sub btn_novofunc_Click(sender As Object, e As EventArgs) Handles btn_novofunc.Click
        habilitarCampos()
        limpar()
    End Sub

    Private Sub btn_salvarfunc_Click(sender As Object, e As EventArgs) Handles btn_salvarfunc.Click
        Dim cmd As SqlCommand
        If txt_cpf.Text <> "" And txt_nome.Text <> "" Then



            Try
                abrir()
                cmd = New SqlCommand("sp_salvarfunc", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                cmd.Parameters.AddWithValue("@sexo", txt_sexo.Text)
                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txt_tel.Text)
                cmd.Parameters.AddWithValue("@email", txt_email.Text)
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

    Private Sub btn_editarfunc_Click(sender As Object, e As EventArgs) Handles btn_editarfunc.Click
        Dim cmd As SqlCommand
        If txt_cpf.Text <> "" And txt_nome.Text <> "" Then



            Try
                abrir()
                cmd = New SqlCommand("sp_editarfunc", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nome.Text)
                cmd.Parameters.AddWithValue("@sexo", txt_sexo.Text)
                cmd.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                cmd.Parameters.AddWithValue("@endereco", txt_endereco.Text)
                cmd.Parameters.AddWithValue("@telefone", txt_tel.Text)
                cmd.Parameters.AddWithValue("@email", txt_email.Text)
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

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView.CellClick
        btn_editarfunc.Enabled = True
        btn_excluirfunc.Enabled = True
        habilitarCampos()
        txt_cpf.Enabled = False

        txt_nome.Text = DataGridView.CurrentRow.Cells(1).Value
        txt_sexo.Text = DataGridView.CurrentRow.Cells(2).Value
        txt_cpf.Text = DataGridView.CurrentRow.Cells(3).Value
        txt_endereco.Text = DataGridView.CurrentRow.Cells(4).Value
        txt_tel.Text = DataGridView.CurrentRow.Cells(5).Value
        txt_email.Text = DataGridView.CurrentRow.Cells(6).Value


    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        If txt_buscar.Text = "" Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarfuncNome", conex)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txt_buscar.Text)

                da.Fill(dt)
                DataGridView.DataSource = (dt)

            Catch ex As Exception
                MessageBox.Show("Eroo ao listar")
                fechar()

            End Try
        End If

    End Sub

    Private Sub btn_excluirfunc_Click(sender As Object, e As EventArgs) Handles btn_excluirfunc.Click
        Dim cmd As SqlCommand
        If txt_nome.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluirfunc", conex)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@nome", txt_nome.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()

                btn_excluirfunc.Enabled = False
                btn_editarfunc.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados!" + ex.Message)
                fechar()
            End Try
        End If



    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dim form = New Menu_Principal
        form.ShowDialog()
        Me.Close()
    End Sub
End Class