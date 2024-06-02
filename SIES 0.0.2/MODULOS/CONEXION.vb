Imports System.Data.Sql
Imports System.Data.SqlClient

Module CONEXION

    Public Conexion As SqlConnection
    Public enunciado As SqlCommand
    Public respuesta As SqlDataReader
    'esta clase sirve para abrir la conexion con la base de datos
    Sub abrir()

        Try


            Conexion = New SqlConnection("Data Source=LAPTOP-BIAFSCF5;Initial Catalog=Usuario_Final;Integrated Security=True")

            Conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo conectar" + ex.ToString)
            Conexion.Close()
        End Try

    End Sub
    'Sirve para verificar su el usuario esta registrado 
    Function usuarioRegistrado(ByVal nombreUsuario As String) As Boolean

        Dim resultado As Boolean = False
        Try

            enunciado = New SqlCommand("Select * from USU where CORREO ='" & nombreUsuario & "'", Conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                resultado = True
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    'Sirve para verifica la contraseña
    Function contrasena(ByVal nombreUsuario As String) As String
        Dim resultado As String = ""
        Try
            enunciado = New SqlCommand("Select CONTRASEÑA from USU where CORREO='" & nombreUsuario & "'", Conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                'ITEM OBTIENE EL VALOR DE LA COLUMNA ESPECIFICADA
                resultado = respuesta.Item("CONTRASEÑA")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function
    'CONSULTA EL TIPO DE USUARIO
    Function ConsultarTipoUsuario(ByVal nombreUsuario As String) As String
        Dim resultado = ""
        Try
            enunciado = New SqlCommand("Select IDTIPOU from USU where CORREO='" & nombreUsuario & "'", Conexion)
            respuesta = enunciado.ExecuteReader

            If respuesta.Read Then
                'CInt CONVIERTE  UNA EXPRESION EN INTEGER O ENTERO
                resultado = respuesta.Item("IDTIPOU")
            End If
            respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return resultado
    End Function

End Module





