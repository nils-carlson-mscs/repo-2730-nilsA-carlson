Public Class Form1
    Private Sub calcAnd_Click(sender As Object, e As EventArgs) Handles calcAnd.Click
        Dim dblOrder As Double
        Dim strYN As String = "Y"
        Dim dblCharge As Double

        'txtOrder.Text = String.Empty
        ' txtYN.Text = String.Empty
        Double.TryParse(txtOrder.Text, dblOrder)
        strYN = txtYN.Text


        If strYN.ToUpper = "Y" AndAlso dblOrder < 100 Then
            dblCharge = 0
        End If
        If strYN.ToUpper <> "Y" AndAlso dblOrder < 100 Then
            dblCharge = 9
        End If
        If strYN.ToUpper <> "Y" AndAlso dblOrder >= 100 Then
            dblCharge = 9
        End If
        lblCharge.Text = dblCharge.ToString("c0")
        'lblCharge.Text = String.Empty

    End Sub

    Private Sub calcOr_Click(sender As Object, e As EventArgs) Handles calcOr.Click
        Dim dblOrder As Double
        Dim strYN As String = "Y"
        Dim dblCharge As Double

        'txtOrder.Text = String.Empty
        ' txtYN.Text = String.Empty
        Double.TryParse(txtOrder.Text, dblOrder)
        strYN = txtYN.Text


        If strYN.ToUpper = "Y" Or strYN.ToLower = "y" OrElse dblOrder < 100 Then
            dblCharge = 0
        End If
        If strYN.ToUpper <> "Y" Or strYN.ToLower = "y" OrElse dblOrder < 100 Then
            dblCharge = 9
        End If
        If strYN.ToUpper <> "Y" Or strYN.ToLower = "y" OrElse dblOrder >= 100 Then
            dblCharge = 9
        End If
        lblCharge.Text = dblCharge.ToString("c0")
        'lblCharge.Text = String.Empty
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Dim strId As String = "A1, B2, C3"
        Dim dblSales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblSales)
        Double.TryParse(lblCommission.Text, dblCommission)
        strId = txtId.Text

        If dblSales >= 25000 AndAlso strId.ToUpper = "A1" Or strId.ToUpper = "B2" Or strId.ToUpper = "C3" Then
            dblCommission = dblSales * 0.15
        Else
            dblCommission = dblSales * 0.12
        End If

        txtId.Text = String.Empty
        txtSales.Text = String.Empty
        lblCommission.Text = dblCommission.ToString("c2")


    End Sub

    Private Sub calcNotEqual_Click(sender As Object, e As EventArgs) Handles calcNotEqual.Click
        Dim strId As String = "A1, B2, C3"
        Dim dblSales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblSales)
        Double.TryParse(lblCommission.Text, dblCommission)
        strId = txtId.Text

        If dblSales <> 25000 AndAlso strId.ToUpper = "A1" Or strId.ToUpper = "B2" Or strId.ToUpper = "C3" Then
            dblCommission = dblSales * 0.15
        Else
            dblCommission = dblSales * 0.12
        End If

        txtId.Text = String.Empty
        txtSales.Text = String.Empty
        lblCommission.Text = dblCommission.ToString("c2")
    End Sub
End Class
