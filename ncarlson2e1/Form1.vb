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
            dblCharge = 9




        End If

        lblCharge.Text = dblCharge.ToString("c")


    End Sub
End Class
