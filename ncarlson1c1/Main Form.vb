Public Class Form1

    Private Sub tmrExit_Tick(sender As Object, e As EventArgs) Handles tmrExit.Tick
        frmStarWars.Show()
        tmrExit.Enabled = False

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        frmToucan.Show()
        Timer2.Enabled = False


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Close()

    End Sub
End Class
