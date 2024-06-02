Public Class CARGA
    Private Sub CARGA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 10
        Label1.Text = BunifuProgressBar1.Value

        If BunifuProgressBar1.Value = 100 Then
            Timer1.Stop()
            Me.Hide()
            SIES.Show()
        End If
    End Sub
End Class

