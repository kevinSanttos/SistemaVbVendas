Imports System.Data.SqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DesabilitarCampos()
        Listar()
        btn_editarcli.Enabled = False
        btn_excluircli.Enabled = False
    End Sub

    Private Sub Listar()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter

        Try
            abrir()
            da = New SqlDataAdapter("Select * From clientes", conex)
            da.Fill(dt)
            DataGridView_cli.DataSource = dt

            FormatarDG()

            Dim total As Integer = DataGridView_cli.Rows.Count

            Tot_cli.Text = CInt(total)

        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            fechar()
        End Try
    End Sub

    Private Sub FormatarDG()
        DataGridView_cli.Columns(0).Visible = False
        DataGridView_cli.Columns(1).HeaderText = "Nome"
        DataGridView_cli.Columns(2).HeaderText = "Sexo"
        DataGridView_cli.Columns(3).HeaderText = "CPF"
        DataGridView_cli.Columns(4).HeaderText = "Endereço"
        DataGridView_cli.Columns(5).HeaderText = "Telefone"
        DataGridView_cli.Columns(6).HeaderText = "Email"

        DataGridView_cli.Columns(6).Width = 140
        DataGridView_cli.Columns(1).Width = 140

    End Sub

    Private Sub DesabilitarCampos()
        txt_nomecli.Enabled = False
        txt_sexocli.Enabled = False
        txt_telcli.Enabled = False
        txt_emailcli.Enabled = False
        txt_cpfcli.Enabled = False
        txt_enderecocli.Enabled = False


    End Sub
    Private Sub habilitarCampos()
        txt_nomecli.Enabled = True
        txt_sexocli.Enabled = True
        txt_telcli.Enabled = True
        txt_emailcli.Enabled = True
        txt_cpfcli.Enabled = True
        txt_enderecocli.Enabled = True


    End Sub

    Private Sub limpar()
        txt_nomecli.Text = ""
        txt_telcli.Text = ""
        txt_emailcli.Text = ""
        txt_cpfcli.Text = ""
        txt_enderecocli.Text = ""
        txt_buscarcli.Text = ""

    End Sub

    Private Sub btn_novocli_Click(sender As Object, e As EventArgs) Handles btn_novocli.Click
        habilitarCampos()
        limpar()
    End Sub

    Private Sub btn_salvarcli_Click(sender As Object, e As EventArgs) Handles btn_salvarcli.Click
        Dim cmd As SqlCommand
        If txt_cpfcli.Text <> "" And txt_nomecli.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_salvarcli", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nomecli.Text)
                cmd.Parameters.AddWithValue("@sexo", txt_sexocli.Text)
                cmd.Parameters.AddWithValue("@cpf", txt_cpfcli.Text)
                cmd.Parameters.AddWithValue("@endereco", txt_enderecocli.Text)
                cmd.Parameters.AddWithValue("@telefone", txt_telcli.Text)
                cmd.Parameters.AddWithValue("@email", txt_emailcli.Text)
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

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub DataGridView_cli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_cli.CellContentClick
        btn_editarcli.Enabled = True
        btn_excluircli.Enabled = True
        habilitarCampos()
        txt_cpfcli.Enabled = False

        txt_nomecli.Text = DataGridView_cli.CurrentRow.Cells(1).Value
        txt_sexocli.Text = DataGridView_cli.CurrentRow.Cells(2).Value
        txt_cpfcli.Text = DataGridView_cli.CurrentRow.Cells(3).Value
        txt_enderecocli.Text = DataGridView_cli.CurrentRow.Cells(4).Value
        txt_telcli.Text = DataGridView_cli.CurrentRow.Cells(5).Value
        txt_emailcli.Text = DataGridView_cli.CurrentRow.Cells(6).Value

    End Sub

    Private Sub btn_editarcli_Click(sender As Object, e As EventArgs) Handles btn_editarcli.Click
        Dim cmd As SqlCommand
        If txt_cpfcli.Text <> "" And txt_nomecli.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_editarcli", conex)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nome", txt_nomecli.Text)
                cmd.Parameters.AddWithValue("@sexo", txt_sexocli.Text)
                cmd.Parameters.AddWithValue("@cpf", txt_cpfcli.Text)
                cmd.Parameters.AddWithValue("@endereco", txt_enderecocli.Text)
                cmd.Parameters.AddWithValue("@telefone", txt_telcli.Text)
                cmd.Parameters.AddWithValue("@email", txt_emailcli.Text)
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

    Private Sub btn_excluircli_Click(sender As Object, e As EventArgs) Handles btn_excluircli.Click
        Dim cmd As SqlCommand
        If txt_nomecli.Text <> "" Then

            Try
                abrir()
                cmd = New SqlCommand("sp_excluircli", conex)
                cmd.CommandType = CommandType.StoredProcedure

                cmd.Parameters.AddWithValue("@nome", txt_nomecli.Text)

                cmd.Parameters.Add("@mensagem", SqlDbType.VarChar, 100).Direction = 2
                cmd.ExecuteNonQuery()

                Dim msg As String = cmd.Parameters("@mensagem").Value.ToString
                MessageBox.Show(msg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)


                Listar()
                limpar()

                btn_excluircli.Enabled = False
                btn_editarcli.Enabled = False


            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados!" + ex.Message)
                fechar()
            End Try
        End If

    End Sub

    Private Sub txt_buscarcli_TextChanged(sender As Object, e As EventArgs) Handles txt_buscarcli.TextChanged
        If txt_buscarcli.Text = "" Then
            Listar()
        Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter

            Try
                abrir()
                da = New SqlDataAdapter("sp_buscarcliNome", conex)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@nome", txt_buscarcli.Text)

                da.Fill(dt)
                DataGridView_cli.DataSource = (dt)

            Catch ex As Exception
                MessageBox.Show("Eroo ao listar")
                fechar()

            End Try
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Tot_cli_Click(sender As Object, e As EventArgs) Handles Tot_cli.Click

    End Sub

    Private Sub txt_telcli_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_telcli.MaskInputRejected

    End Sub

    Private Sub txt_cpfcli_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txt_cpfcli.MaskInputRejected

    End Sub

    Private Sub txt_sexocli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_sexocli.SelectedIndexChanged

    End Sub

    Private Sub txt_enderecocli_TextChanged(sender As Object, e As EventArgs) Handles txt_enderecocli.TextChanged

    End Sub

    Private Sub txt_emailcli_TextChanged(sender As Object, e As EventArgs) Handles txt_emailcli.TextChanged

    End Sub

    Private Sub txt_nomecli_TextChanged(sender As Object, e As EventArgs) Handles txt_nomecli.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Voltar_Click(sender As Object, e As EventArgs) Handles Voltar.Click
        Dim form = New Menu_Principal
        form.ShowDialog()
        Me.Close()
    End Sub
End Class