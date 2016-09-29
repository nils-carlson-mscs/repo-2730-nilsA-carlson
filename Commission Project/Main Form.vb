' Name:         Commission Project
' Purpose:      Displays a salesperson's commission
' Programmer:   <your name> on <current date>

Option Explicit On
Option Infer Off
Option Strict On

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRate8_Click(sender As Object, e As EventArgs) Handles btnRate8.Click
        Dim dblSales As Double
        Dim dblComm8 As Double
        Double.TryParse(txtSales.Text, dblSales)
        dblComm8 = dblSales * 0.08
        lblComm.Text = Convert.ToString(dblComm8)


    End Sub

    Private Sub btnRate10_Click(sender As Object, e As EventArgs) Handles btnRate10.Click

        Dim dblSales As Double
        Dim dblComm10 As Double
        Double.TryParse(txtSales.Text, dblSales)
        dblComm10 = dblSales * 0.1
        lblComm.Text = Convert.ToString(dblComm10)
    End Sub
End Class
