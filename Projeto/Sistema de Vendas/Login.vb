Imports System.Data.SqlClient

Public Class Login

    Private Sub btn_entrar_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        Dim usuario As String = txt_usuario.Text
        Dim senha As String = txt_senha.Text

        If usuario = "" Or senha = "" Then

            MessageBox.Show("Preencha os campos")

        Else

            Dim cmd As New SqlCommand("login", conex)

            Try
                abrir()
                cmd.CommandType = 4
                With cmd.Parameters
                    .AddWithValue("@nome", usuario)
                    .AddWithValue("@cpf", senha)
                    .Add("@msg", SqlDbType.VarChar, 100).Direction = 2
                    cmd.ExecuteNonQuery()
                End With
                usuario = txt_usuario.Text
                Dim msg As String = cmd.Parameters("@msg").Value
                MsgBox(msg, vbInformation)

                If (msg = "Dados incorretos") Then
                    txt_senha.Clear()
                    txt_usuario.Clear()
                    txt_usuario.Focus()

                Else
                    Dim form = New Menu_Principal
                    form.ShowDialog()
                    Me.Close()
                End If

            Catch ex As Exception
                MessageBox.Show("Erro ao salvar os dados!" + ex.Message)
                fechar()
            End Try
        End If



    End Sub
End Class
