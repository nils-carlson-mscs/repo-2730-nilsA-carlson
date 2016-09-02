'Name:          Bakery Project
'Purpose:       Calculates the total number of items sold and sales
'Programmer:    Nils Carlson on 09/01/16

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'preapare screen for the next sale
        txtDonuts.Text = String.Empty
        txtMuffins.Text = String.Empty
        lblTotalItems.Text = String.Empty
        lblTotalSales.Text = String.Empty
        txtDonuts.Focus()
        'send the focus to the Donuts box
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'calculate number of items sold and total sales
        lblTotalItems.Text = Val(txtDonuts.Text) + Val(txtMuffins.Text)
        lblTotalSales.Text = Val(lblTotalItems.Text) * 0.5
        lblTotalSales.Text = Format(lblTotalSales.Text, "currency")
    End Sub
End Class
