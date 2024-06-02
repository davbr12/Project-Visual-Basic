Public Class LISTADO
    Dim OBJETO As New EXPO
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SENTENCIA As String
        If TextBox1.Text <> "" Then
            SENTENCIA = "Select * From  CLIENTESS where ITEM_CLIENTE='" + Replace(TextBox1.Text, "'", "''") + "'"
            OBJETO.consulta(DataGridView1, SENTENCIA)
        End If
    End Sub
End Class