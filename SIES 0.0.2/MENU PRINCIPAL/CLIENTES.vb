Public Class CLIENTES
    Private Sub LISTA_Click(sender As Object, e As EventArgs) Handles LISTA.Click
        CONTENEDOR2.Controls.Clear()
        LISTADO.TopLevel = False
        CONTENEDOR2.Controls.Add(LISTADO)
        LISTADO.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AÑADIR.Click
        CONTENEDOR2.Controls.Clear()
        CREAR.TopLevel = False
        CONTENEDOR2.Controls.Add(CREAR)
        CREAR.Show()
    End Sub

    Private Sub CONTENEDOR2_Paint(sender As Object, e As PaintEventArgs) 
    End Sub

    Private Sub CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONTENEDOR2.Controls.Clear()
        LISTADO.TopLevel = False
        CONTENEDOR2.Controls.Add(LISTADO)
        LISTADO.Show()
    End Sub
End Class