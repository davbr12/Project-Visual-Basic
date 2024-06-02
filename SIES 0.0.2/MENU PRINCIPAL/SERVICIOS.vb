Imports System.Data.SqlClient
Public Class SERVICIOS
    Dim con As New SqlConnection("Data Source=LAPTOP-BIAFSCF5;Initial Catalog=FINAL_VER;Integrated Security=True")
    Dim opcion As String
    Sub comandSQL(sql As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Mostrar()
        Dim most As New SqlDataAdapter("select * from SERVICIOO1", con)
        Dim ds As New DataSet
        Try
            most.Fill(ds)
            VIEWCLIENTES.DataSource = ds.Tables(0)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AÑADIR_Click(sender As Object, e As EventArgs) Handles AÑADIR.Click
        Try
            If Me.ValidateChildren And txtItem.Text <> String.Empty And txtservicio.Text <> String.Empty And txtDescrip.Text <> String.Empty And txtTiempo.Text <> String.Empty And txtPreciou.Text <> String.Empty And txtcod.Text <> String.Empty Then
                'Aqui se agregan los clientes en la base de datos doges:v
                con.Open()

                Dim cadena As String = "insert into SERVICIOO1(ITEM_SER,NOM_SER,DESCRIPCION_SER,TIEMPO_EJECSER,PRECIO_UNITARIO,COD_HERRAMIENTA_USADA) values ('" + txtItem.Text + "','" + txtservicio.Text + "','" + txtDescrip.Text + "','" + txtTiempo.Text + "','" + txtPreciou.Text + "','" + txtcod.Text + "')"
                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, con)
                comando.ExecuteNonQuery()
                GUARDAR_DATOS.Show()
            Else
                ERROR_CLIENTE.Show()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try
    End Sub

    Private Sub VER_Click(sender As Object, e As EventArgs) Handles VER.Click
        Mostrar()
    End Sub
    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
        Try
            If Me.ValidateChildren And txtItem.Text <> String.Empty And txtservicio.Text <> String.Empty And txtDescrip.Text <> String.Empty And txtTiempo.Text <> String.Empty And txtPreciou.Text <> String.Empty And txtcod.Text <> String.Empty Then
                con.Open()
                opcion = "update SERVICIOO1 set ITEM_SER='" + txtItem.Text + "',NOM_SER='" + txtservicio.Text + "',DESCRIPCION_SER='" + txtDescrip.Text + "',TIEMPO_EJECSER='" + txtTiempo.Text + "',PRECIO_UNITARIO='" + txtPreciou.Text + "',COD_HERRAMIENTA_USADA='" + txtcod.Text + "' where ITEM_SER='" + txtItem.Text + "'"
                Dim comando As SqlCommand
                comando = New SqlCommand(opcion, con)
                comando.ExecuteNonQuery()
                Mostrar()
                ACTUALIZACION_CORRECTA.Show()

            Else
                ERROR_ACTUALIZAR.Show()
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        Try
            If txtItem.TextLength <> 0 Then
                con.Open()
                opcion = "delete from SERVICIOO1 where ITEM_SER='" + txtItem.Text + "'"
                Dim comando As SqlCommand
                comando = New SqlCommand(opcion, con)
                comando.ExecuteNonQuery()
                Mostrar()
                DATOS_ELIMINADOS.Show()
            Else

            End If
        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub LIMPIAR_Click(sender As Object, e As EventArgs) Handles LIMPIAR.Click
        txtcod.Text = ""
        txtItem.Text = ""
        txtservicio.Text = ""
        txtDescrip.Text = ""
        txtTiempo.Text = ""
        txtPreciou.Text = ""
    End Sub
End Class