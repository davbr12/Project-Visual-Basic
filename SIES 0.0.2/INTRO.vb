Public Class INTRO
    Private Sub INTRO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        Timer1.Interval = 1000
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        BunifuProgressBar1.Value += 1

        If BunifuProgressBar1.Value = 1 Then
            Timer1.Stop()
            Me.Hide()
            CARGA.Show()
        End If
    End Sub
End Class