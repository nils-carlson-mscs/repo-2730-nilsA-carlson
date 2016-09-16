
'Name:              Average Project
'Purpose:           Display average of 3 tes scores
'Programmer:        Nils Carlson on 09/15/16


Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        lblTestScore.Text = Format((Val(txtTest1.Text) + Val(txtTest2.Text) + Val(txtTest3.Text)) / 3)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        lblTestScore.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
