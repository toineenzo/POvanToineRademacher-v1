Public Class Startup
    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' load form' 
        If System.Diagnostics.Debugger.IsAttached = False Then
            lblVersion.Text = "Version: " &
            My.Application.Deployment.CurrentVersion.ToString
        Else
            lblVersion.Text = "Debug Mode"
        End If
        ' Laat publish versie zien, is het niet gepublisht maar rechtstreeks vanuit visual studio'
        ' opgestart? dan is het debug mode'
    End Sub

    Private Sub btnProblem1_Click(sender As Object, e As EventArgs) Handles btnProblem1.Click
        Me.Close()
        Main.Show()
    End Sub

    Private Sub btnProblem2_Click(sender As Object, e As EventArgs) Handles btnProblem2.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
        ' Cancel loading = close' 
    End Sub


End Class