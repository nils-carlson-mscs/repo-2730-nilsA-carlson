
'Name:              Richardson County Property Tax Project
'Purpose:           Calculate property tax
'Programmer:        Nils Carlson on 09/07/16



Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate property tax
        lblTax.Text = Val(txtAssessed.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear screen for next use
        lblTax.Text = String.Empty
        txtAssessed.Text = String.Empty
        txtAssessed.Focus()
    End Sub
End Class
