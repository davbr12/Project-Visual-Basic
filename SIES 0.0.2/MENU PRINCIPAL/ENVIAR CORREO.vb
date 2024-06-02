Public Class ENVIAR_CORREO
    Private Sub AÑADIR_Click(sender As Object, e As EventArgs) Handles AÑADIR.Click
        enviarCorreo(txtEmisor.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, txtReceptor.Text, txtRutaArchivo.Text)
    End Sub
    Private Sub FILE_Click(sender As Object, e As EventArgs) Handles FILE.Click
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                txtRutaArchivo.Text = Me.OpenFileDialog1.FileName
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        Panel2.Visible = True
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Panel2.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtEmisor.Text = ""
        txtPassword.Text = ""
        rtbMensaje.Text = ""
        txtAsunto.Text = ""
        txtReceptor.Text = ""
        txtRutaArchivo.Text = ""
    End Sub
End Class