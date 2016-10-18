
' Name:         Currancy Converter
' Purpose:      Display curranceies
' Programmer:   Nils Carlson on 10/14/16





Public Class Form1
    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        'convert american dollar to euro, pound, and rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.791
        Const dblRAND_RATE As Double = 13.89
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty


        If txtDollar.Text = String.Empty Then
            MessageBox.Show("Insert number for Dollar", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtDollar.Text, dblDollar)
        End If
        dblEuro = dblDollar * 0.9
        dblPound = dblDollar * 0.79
        dblRand = dblDollar * 13.89

        lblRand.Text = dblRand.ToString("c2")
        lblPound.Text = dblPound.ToString("c2")
        lblEuro.Text = dblEuro.ToString("c2")



    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click

        Dim dblPounds As Double
        Dim dblPrice As Double
        Dim dblTotalDue As Double

        lblTotalDue.Text = String.Empty


        Double.TryParse(txtPounds.Text, dblPounds)
        Double.TryParse(txtPrice.Text, dblPrice)

        If MessageBox.Show("Charge for shipping?", "Shipping", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
            dblTotalDue = 15 + (dblPrice * dblPounds)
        Else
            dblTotalDue = dblPrice * dblPounds
        End If

        lblTotalDue.Text = dblTotalDue.ToString("c2")
        txtPounds.Text = String.Empty
        txtPrice.Text = String.Empty

    End Sub

    Private Sub btnCalcTri_Click(sender As Object, e As EventArgs) Handles btnCalcTri.Click
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblBill As Double

        lblBill.Text = String.Empty

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)

        If dblPrevious >= dblCurrent Then
            MessageBox.Show("The current reading must be greater than or equal to previous reading.", "Tri County Electric", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            dblBill = 0.13 * (dblCurrent - dblPrevious)

        End If
        lblBill.Text = dblBill.ToString("c2")
        txtCurrent.Text = String.Empty
        txtPrevious.Text = String.Empty
    End Sub

    Private Sub btnCalcDiv_Click(sender As Object, e As EventArgs) Handles btnCalcDiv.Click

        Dim dblFirst As Double
        Dim dblSecond As Double
        Dim dblQuotient As Double

        lblQuotient.Text = String.Empty
        Double.TryParse(txtFirst.Text, dblFirst)
        Double.TryParse(txtSecond.Text, dblSecond)


        If dblSecond = 0 AndAlso dblFirst = 0 Then
            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        If dblFirst > dblSecond Then
            Dim dblTemp As Double
            dblTemp = dblFirst
            dblFirst = dblSecond
            dblSecond = dblTemp
        End If


        dblQuotient = dblSecond / dblFirst


        lblQuotient.Text = dblQuotient.ToString
        txtFirst.Text = String.Empty
        txtSecond.Text = String.Empty
    End Sub

    Private Sub btnConvertNot_Click(sender As Object, e As EventArgs) Handles btnConvertNot.Click

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.791
        Const dblRAND_RATE As Double = 13.89
        Dim dblDollar As Double
        Dim dblEuro As Double
        Dim dblPound As Double
        Dim dblRand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty


        If txtDollar.Text <> String.Empty Then
            MessageBox.Show("Input does not work.", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Double.TryParse(txtDollar.Text, dblDollar)
        End If
        dblEuro = dblDollar * 0.9
        dblPound = dblDollar * 0.79
        dblRand = dblDollar * 13.89

        lblRand.Text = dblRand.ToString("c2")
        lblPound.Text = dblPound.ToString("c2")
        lblEuro.Text = dblEuro.ToString("c2")
    End Sub
End Class
