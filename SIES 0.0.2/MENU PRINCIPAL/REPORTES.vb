Public Class REPORTES
    Private Sub LISTA_Click(sender As Object, e As EventArgs) Handles LISTA.Click
        CONTENEDORRE.Controls.Clear()
        LISTADO_REPORTES.TopLevel = False
        CONTENEDORRE.Controls.Add(LISTADO_REPORTES)
        LISTADO_REPORTES.Show()
    End Sub

    Private Sub REPORTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONTENEDORRE.Controls.Clear()
        LISTADO_REPORTES.TopLevel = False
        CONTENEDORRE.Controls.Add(LISTADO_REPORTES)
        LISTADO_REPORTES.Show()
    End Sub
End Class