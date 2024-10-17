Public Class frmSplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        lblStatus.Text = (ProgressBar1.Value / ProgressBar1.Maximum) * 100 & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            frmLogIn.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

End Class
