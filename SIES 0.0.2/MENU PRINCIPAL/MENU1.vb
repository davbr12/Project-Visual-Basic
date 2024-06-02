Public Class MENU1
    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer
        Timer1.Interval = 1000
        Timer1.Start()

        CONTENEDOR.Controls.Clear()
        PRINCIPAL.TopLevel = False
        CONTENEDOR.Controls.Add(PRINCIPAL)
        PRINCIPAL.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Hora
        Me.HORA.Text = String.Format("{0:HH:mm}", DateTime.Now)
    End Sub

    Private Sub CERRAR_Click(sender As Object, e As EventArgs) Handles CERRAR.Click
        End
    End Sub

    Private Sub MINIMIZAR_Click(sender As Object, e As EventArgs) Handles MINIMIZAR.Click
        'Minimizar
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CONTENEDOR_Paint(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub CLIENTE_Click(sender As Object, e As EventArgs) Handles CLIENTE.Click
        CONTENEDOR.Controls.Clear()
        CLIENTES.TopLevel = False
        CONTENEDOR.Controls.Add(CLIENTES)
        CLIENTES.Show()
    End Sub

    Private Sub SERVICIO_Click(sender As Object, e As EventArgs) Handles SERVICIO.Click
        CONTENEDOR.Controls.Clear()
        SERVICIOS.TopLevel = False
        CONTENEDOR.Controls.Add(SERVICIOS)
        SERVICIOS.Show()
    End Sub

    Private Sub HERRAMIENTA_Click(sender As Object, e As EventArgs) Handles HERRAMIENTA.Click
        CONTENEDOR.Controls.Clear()
        HERRAMIENTAS.TopLevel = False
        CONTENEDOR.Controls.Add(HERRAMIENTAS)
        HERRAMIENTAS.Show()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel3.Width = 37 Then
            Panel3.Width = 194
        Else
            Panel3.Width = 37
        End If
    End Sub

    Private Sub INICIO_Click(sender As Object, e As EventArgs) Handles INICIO.Click
        CONTENEDOR.Controls.Clear()
        PRINCIPAL.TopLevel = False
        CONTENEDOR.Controls.Add(PRINCIPAL)
        PRINCIPAL.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles REGISTRAR.Click
        CONTENEDOR.Controls.Clear()
        REGISTRO_DE_USUARIOS.TopLevel = False
        CONTENEDOR.Controls.Add(REGISTRO_DE_USUARIOS)
        REGISTRO_DE_USUARIOS.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        CERRAR_SESION.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CONTENEDOR.Controls.Clear()
        ENVIAR_CORREO.TopLevel = False
        CONTENEDOR.Controls.Add(ENVIAR_CORREO)
        ENVIAR_CORREO.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles REPORTE.Click
        CONTENEDOR.Controls.Clear()
        REPORTES.TopLevel = False
        CONTENEDOR.Controls.Add(REPORTES)
        REPORTES.Show()
    End Sub
End Class