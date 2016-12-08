
'Name:         3d1: Arrays, subscripts, loops
'Purpose:      
'Programmer:   Nils Carlson on 12/3/16

Option Strict On
Option Infer Off
Option Explicit On


Public Class Form1
    Private intSold() As Integer = {250, 225, 193, 260}
    Private dblWholeSale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 12.25, 10, 30}


    'Days in month
    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click
        Dim dblMonth() As Double = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12}
        Dim intDays As Integer
        Dim intResult As Integer

        Integer.TryParse(txtMonthNumber.Text, intDays)

        If intDays = dblMonth(0) Then
            intResult = 31
        ElseIf intDays = dblMonth(1) Then
            intResult = 28
        ElseIf intDays = dblMonth(2) Then
            intResult = 31
        ElseIf intDays = dblMonth(3) Then
            intResult = 30
        ElseIf intDays = dblMonth(4) Then
            intResult = 31
        ElseIf intDays = dblMonth(5) Then
            intResult = 30
        ElseIf intDays = dblMonth(6) Then
            intResult = 31
        ElseIf intDays = dblMonth(7) Then
            intResult = 31
        ElseIf intDays = dblMonth(8) Then
            intResult = 30
        ElseIf intDays = dblMonth(9) Then
            intResult = 31
        ElseIf intDays = dblMonth(10) Then
            intResult = 30
        ElseIf intDays = dblMonth(11) Then
            intResult = 31
        ElseIf intDays <> 1 - 12 Then
            MessageBox.Show("Invalid Response", "Invalid", MessageBoxButtons.OK)

        End If

        lblDaysofMonth.Text = intResult.ToString()

    End Sub
    Private Sub NumberChanged(sender As Object, e As EventArgs) Handles txtMonthNumber.TextChanged

        txtMonthNumber.Focus()

    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------



    ' display avg number sold
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click


        Dim dblTotal As Double
        Dim dblAvg As Double
        Dim dblOtherLessThanAvg As Double
        Dim dblLessthenAvg As Double
        Dim intLast As Integer = intSold.GetUpperBound(0)
        Dim intLowest As Integer = intSold(0)



        For intElement As Integer = 0 To (intSold.Length - 1)
            dblTotal += intSold(intElement)
            dblAvg = dblTotal / intSold.Length
        Next



        For intElement As Integer = 1 To (intSold.Length - 1)
            If intSold(intElement) < dblAvg Then
                dblLessthenAvg = intSold(intElement)

            End If
            If intSold(intElement) < dblAvg Then
                dblOtherLessThanAvg = intSold(1)
            End If

        Next

        If lblLessthenAvg.Text.EndsWith(", ") Then
            lblLessthenAvg.Text = lblLessthenAvg.Text.Substring(0, lblLessthenAvg.Text.Length - 2)
        End If


        lblAvgSold.Text = String.Empty
        lblLessthenAvg.Text = String.Empty

        lblAvgSold.Text = dblAvg.ToString
        lblLessthenAvg.Text = dblLessthenAvg.ToString & ", " & dblOtherLessThanAvg




    End Sub



    ' display avg number sold
    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        Dim dblOtherLessThanAvg As Double
        Dim dblLessThenAvg As Double
        Dim dblAverage As Double
        Dim dblTotal As Double


        For Each intElement As Integer In intSold
            dblTotal += intElement
            dblAverage = dblTotal / intSold.Length
        Next intElement

        For Each intElement As Integer In intSold
            If intElement >= dblAverage Then
                Continue For


                If intElement < dblAverage Then
                    Exit For
                End If
            End If
            dblLessThenAvg = intElement
            dblOtherLessThanAvg = intSold(1)



        Next



        If lblLessthenAvg.Text.EndsWith(", ") Then
            lblLessthenAvg.Text = lblLessthenAvg.Text.Substring(0, lblLessthenAvg.Text.Length - 2)
        End If


        lblAvgSold.Text = dblAverage.ToString
        lblLessthenAvg.Text = dblLessThenAvg.ToString & ", " & dblOtherLessThanAvg



        'lblAvgSold.Text = String.Empty
        'lblLessthenAvg.Text = String.Empty
    End Sub
    ' display avg number sold
    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click

        Dim dblAvg As Double
        Dim dblLessThanAvg As Double









        lblAvgSold.Text = String.Empty
        lblLessthenAvg.Text = String.Empty
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        Dim dblPercent As Double
        Dim strPercent As String

        strPercent = InputBox("Percent")

        dblPercent = Convert.ToDouble(strPercent)





        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            lstRetail.Items.Add((dblWholeSale(intSub) * dblPercent) + dblWholeSale(intSub)).ToString("n2").PadLeft(6)
        Next
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) = Convert.ToDouble(lstWholeSale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            lstWholeSale.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
