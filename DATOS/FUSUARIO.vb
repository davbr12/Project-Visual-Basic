Imports System.Data.SqlClient
Imports ENTIDAD
Public Class FUSUARIO
    Inherits EJERCONEXION
    Public Function VALIDARUSUARIO(ByVal DTS As ENTIDADU) As DataTable
        conectado()
        cmd = New SqlCommand("_INICIOSESION")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cnn
        cmd.Parameters.AddWithValue("@CORREO", DTS._CORREO)
        cmd.Parameters.AddWithValue("@CONTRASEÑA", DTS._CONTRASEÑA)
        If cmd.ExecuteNonQuery Then
            Using DT As New DataTable
                Using DA As New SqlDataAdapter(cmd)
                    DA.Fill(DT)
                    Return DT
                End Using
            End Using
        Else
            Return Nothing
        End If

    End Function

End Class
