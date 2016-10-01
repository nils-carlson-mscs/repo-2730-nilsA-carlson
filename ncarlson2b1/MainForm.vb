'Name:          Cranston Berries Project
'Purpose:       Calculates projected sales
'Programmer:    Nils Carlson on 09/28/2016

Option Strict On
Option Explicit On
Option Infer Off




Public Class frmMain




    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub



    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'calculate projected sales

        'lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        'lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        'lblProjRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")

        Dim dblStraw As Double
        Dim dblProjStraw As Double
        Dim dblBlue As Double
        Dim dblProjBlue As Double
        Dim dblRasp As Double
        Dim dblProjRasp As Double
        Dim dblProjIncrease As Double

        Double.TryParse(txtStraw.Text, dblStraw)
        Double.TryParse(txtBlue.Text, dblBlue)
        Double.TryParse(txtRasp.Text, dblRasp)
        Double.TryParse(txtProjIncrease.Text, dblProjIncrease)



        dblProjStraw = dblStraw * dblProjIncrease
        dblProjBlue = dblBlue * dblProjIncrease
        dblProjRasp = dblRasp * dblProjIncrease




        lblProjStraw.Text = (Convert.ToString(dblProjStraw) 
       lblProjBlue.Text = Convert.ToString(dblProjBlue)
        lblProjRasp.Text = Convert.ToString(dblProjRasp)



    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' clear screen

        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        txtProjIncrease.Text = String.Empty
    End Sub

End Class
