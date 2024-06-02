Imports System.Data.SqlClient

Module CONEXION2
    Public con As New SqlConnection("Data Source=LAPTOP-BIAFSCF5;Initial Catalog=FINAL_VER;Integrated Security=True")

    Public Class EXPO
        Sub abrir()
            Try
                con.Open()
                MsgBox("Conexion Realizada", MsgBoxStyle.Information, "Conexion")


            Catch ex As Exception
                MsgBox("No se pudo conectar" + ex.ToString)

            End Try

        End Sub
        Sub consulta(ByVal Tabla As DataGridView, ByVal sql As String)
            Try
                Dim DA As New SqlDataAdapter(sql, con)
                Dim DT As New DataTable
                DA.Fill(DT)
                Tabla.DataSource = DT
            Catch ex As Exception
                MsgBox("No se logro realizar la consulta" & ex.Message, MsgBoxStyle.Critical, "Conexion")
            End Try


        End Sub
        Sub operacion(ByVal Tabla As DataGridView, ByVal sql As String)
            con.Open()
            Try
                Dim cmd As New SqlCommand(sql, con)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("No se logro hacer la operacion" & ex.Message, MsgBoxStyle.Critical, "conexion")
            End Try
            con.Close()
        End Sub
    End Class
End Module
