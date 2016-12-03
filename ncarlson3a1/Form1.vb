Public Class Form1
    Private Sub btnDoWhile_Click(sender As Object, e As EventArgs) Handles btnDoWhile.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnDoUntil_Click(sender As Object, e As EventArgs) Handles btnDoUntil.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i = 22
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop
    End Sub

    Private Sub btnLoopWhile_Click(sender As Object, e As EventArgs) Handles btnLoopWhile.Click
        lblEven.Text = "Posttest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop While i <= 20
    End Sub

    Private Sub btnLoopuntil_Click(sender As Object, e As EventArgs) Handles btnLoopuntil.Click
        lblEven.Text = "Posttest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 2
        Loop Until i = 22
    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        lblEven.Text = "Pretest For " & ControlChars.NewLine
        For i As Integer = 2 To 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i = i + 1
        Next

    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        'clear screen
        txtList.Text = String.Empty
        lblAverage.Text = String.Empty
        lblCount.Text = String.Empty

        ' calculates average
        Const strPROMPT As String = "Enter a number" & ControlChars.NewLine & "Click cancel or leave blank to end."
        Const strTITLE As String = "Number Entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        'get first sales amount
        strNum = InputBox(strPROMPT, strTITLE, "0")

        '***begin loop here: repeat as long as input is not empty
        Do While strNum = InputBox(strPROMPT, strTITLE, "0")

            'convert the input to a number
            Int32.TryParse(strNum, intNum)

            'display the input in the next line
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine

            'update the counter and accumulation
            intCount = intCount + 1
            intSum = intSum + intNum

            '***update control variable

            '***end loop here
        Loop
        lblCount.Text = intCount.ToString

        'verify that the counter is greater than 0
        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAverage.Text = dblAvg.ToString("N2")
        Else
            lblAverage.Text = "N/A"
        End If



    End Sub
End Class
