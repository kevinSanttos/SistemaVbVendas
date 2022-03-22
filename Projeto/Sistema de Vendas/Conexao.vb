Imports System.Data.SqlClient

Module Conexao
    Public conex As New SqlConnection("Server=DESKTOP-2MTLEVF\SQLEXPRESS; DataBase=sistemavb; Integrated Security=SSPI")
    Sub abrir()
        If conex.State = 0 Then
            conex.Open()
        End If
    End Sub
    Sub fechar()
        If conex.State = 1 Then
            conex.Close()
        End If
    End Sub
End Module
