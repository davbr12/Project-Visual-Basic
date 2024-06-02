Imports System.Data.SqlClient
Public Class CREAR
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
    Private Sub AÑADIR_Click(sender As Object, e As EventArgs) Handles AÑADIR.Click
        Try
            If Me.ValidateChildren And NOMBRE.Text <> String.Empty And ATENCION.Text <> String.Empty And DIRECCION.Text <> String.Empty And EMAIL.Text <> String.Empty And Val(TELEFONO.Text) - Int(Val(TELEFONO.Text)) = 0 Then
                'Aqui se agregan los clientes en la base de datos doges:v
                con.Open()

                Dim cadena As String = "insert into CLIENTESS(ITEM_CLIENTE,NOMBRE_CLIENTE,DIRECCION,TELEFONO,CONTACTO,E_MAIL,HISTORIAL,RESPUESTA) values ('" + ITEM.Text + "','" + NOMBRE.Text + "','" + DIRECCION.Text + "','" + TELEFONO.Text + "','" + ATENCION.Text + "','" + EMAIL.Text + "','" + HISTORIAL.Text + "','" + RESPUESTA.Text + "')"
                Dim comando As SqlCommand
                comando = New SqlCommand(cadena, con)
                comando.ExecuteNonQuery()
                GUARDAR_DATOS.Show()


            Else
                ERROR_CLIENTE.Show()
            End If

        Catch ex As Exception
            MsgBox("Datos repetidos u Invalidos")
            con.Close()

        End Try
    End Sub
    Sub Mostrar()


        Dim most As New SqlDataAdapter("select * from CLIENTESS", con)
        Dim ds As New DataSet
        Try
            most.Fill(ds)
            VIEWCLIENTES.DataSource = ds.Tables(0)
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub VER_Click(sender As Object, e As EventArgs) Handles VER.Click
        Mostrar()
    End Sub

    Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
        Try
            If NOMBRE.TextLength <> 0 AndAlso ATENCION.TextLength <> 0 AndAlso DIRECCION.TextLength <> 0 AndAlso TELEFONO.TextLength <> 0 AndAlso EMAIL.TextLength <> 0 Then
                con.Open()
                opcion = "update CLIENTESS set ITEM_CLIENTE='" + ITEM.Text + "',NOMBRE_CLIENTE='" + NOMBRE.Text + "',DIRECCION='" + DIRECCION.Text + "',TELEFONO='" + TELEFONO.Text + "',CONTACTO='" + ATENCION.Text + "',E_MAIL='" + EMAIL.Text + "',HISTORIAL='" + HISTORIAL.Text + "',RESPUESTA='" + RESPUESTA.Text + "' where ITEM_CLIENTE='" + ITEM.Text + "'"
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
            MsgBox("ERROR")
        End Try
    End Sub

    Private Sub ELIMINAR_Click(sender As Object, e As EventArgs) Handles ELIMINAR.Click
        Try
            If ITEM.TextLength <> 0 Then
                con.Open()
                opcion = "delete from CLIENTESS where ITEM_CLIENTE='" + ITEM.Text + "'"
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
        NOMBRE.Text = ""
        ATENCION.Text = ""
        ITEM.Text = ""
        DIRECCION.Text = ""
        TELEFONO.Text = ""
        HISTORIAL.Text = ""
        EMAIL.Text = ""
        RESPUESTA.Text = ""
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
    End Sub

    Private Sub VIEWCLIENTES_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles VIEWCLIENTES.CellClick
        Dim i As Integer
        'permite agarrar el nunero de fila
        i = VIEWCLIENTES.CurrentRow.Index
        ITEM.Text = VIEWCLIENTES.Item(0, i).Value()
        NOMBRE.Text = VIEWCLIENTES.Item(1, i).Value()
        DIRECCION.Text = VIEWCLIENTES.Item(2, i).Value()
        TELEFONO.Text = VIEWCLIENTES.Item(3, i).Value()
        ATENCION.Text = VIEWCLIENTES.Item(4, i).Value()
        EMAIL.Text = VIEWCLIENTES.Item(5, i).Value()
        HISTORIAL.Text = VIEWCLIENTES.Item(6, i).Value()
        RESPUESTA.Text = VIEWCLIENTES.Item(7, i).Value()
    End Sub
    Public Sub Busqueda()
        'Busca el item de cliente
        Try
            Dim cargar As New SqlDataAdapter("Select * FROM CLIENTESS WHERE ITEM_CLIENTE LIKE'" & BUSCAR.Text & "%'", con)
            Dim ds As New DataSet
            cargar.Fill(ds, "CLIENTESS")
            VIEWCLIENTES.DataSource = ds.Tables("CLIENTESS")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles BUSCAR.TextChanged
        Busqueda()
    End Sub
End Class