Public Class Form1

    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                       e.KeyChar <> ControlChars.Back Then
            'cancel the key
            e.Handled = True
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".")

        End If
    End Sub

    Private Sub btnCalcIfThen_Click(sender As Object, e As EventArgs) Handles btnCalcIfThen.Click
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommission = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommission = 120 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommission = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMorethen10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnCalcNestedIf_Click(sender As Object, e As EventArgs) Handles btnCalcNestedIf.Click
        'nested if

        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)



        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        Else
            If boolSalesOK AndAlso dblSales >= 30000.0 Then
                dblCommission = 3120.0 + (dblSales - 30000) * 0.14
            Else
                If dblSales >= 6000.0 Then
                    dblCommission = 120 + (dblSales - 6000) * 0.13
                Else
                    If dblSales >= 1.0 Then
                        dblCommission = dblSales * 0.1
                    Else
                        If dblSales < 1.0 Then
                            dblCommission = 0.0
                        End If
                    End If
                End If
            End If
        End If

        If chkMorethen10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnCalcIfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalcIfElseIf.Click
        'If ElseIf

        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        ElseIf boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommission = 0.0
        ElseIf dblSales < 6000.0 Then
            dblCommission = dblSales * 0.1
        ElseIf dblSales < 30000.0 Then
            dblCommission = 120 + (dblSales - 6000) * 0.13
        ElseIf dblSales >= 30000.0 Then
            dblCommission = 3120.0 + (dblSales - 30000) * 0.14

        End If

        If chkMorethen10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnCalcSelectCase_Click(sender As Object, e As EventArgs) Handles btnCalcSelectCase.Click
        'Select Case

        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommission As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotal As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK)
        End If

        Select Case dblSales
            Case Is < 1.0
                dblCommission = 0.0
            Case 1.0 To 5999.99
                dblCommission = dblSales * 0.1
            Case 6000.0 To 29999.99
                dblCommission = 120 + (dblSales - 6000.0) * 0.13
            Case Else
                dblCommission = 3120.0 + (dblSales - 30000.0) * 0.14

        End Select



        If chkMorethen10.Checked Then
            dblAdditional = dblAdditional + 500
        End If

        If chkTraveling.Checked Then
            dblAdditional = dblAdditional + 700
        End If

        dblTotal = dblCommission + dblAdditional

        If boolSalesOK Then
            lblCommission.Text = dblCommission.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotal.Text = dblTotal.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMorethen10.CheckedChanged, chkTraveling.CheckedChanged
        lblCommission.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotal.Text = String.Empty

    End Sub
End Class
