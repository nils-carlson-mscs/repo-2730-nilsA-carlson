Option Explicit On
Option Strict On
Option Infer Off


Public Class form1



    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04.Text
        strItem = strItem.Substring(2, 4)
        lbl04Substring.Text = strItem

        '#05a: Length
        Dim strMsg As String = txt05a.Text
        Dim dblMsg As Double

        dblMsg = strMsg.Length
        strMsg = dblMsg.ToString()
        lbl05aLength.Text = strMsg

        '#05b: Trim
        Dim strState As String = txt05b.Text
        strState = strState.Trim
        lbl05bTrim.Text = strState

        '#05c: Remove/Insert
        Dim strWoord As String = txt05c.Text
        strWoord = strWoord.Remove(1, 1)
        strWoord = strWoord.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strWoord

        '#05d: Insert
        Dim strDay As String = txt05d.Text
        strDay = strDay.Insert(0, "Mon")
        lbl05dInsert.Text = strDay

        '#05e: Pad
        Dim strPay As String = txt05e.Text
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#06:Remove
        Dim strAmount As String = txt06.Text

        strAmount = strAmount.Remove()

        lbl06Remove.Text = strAmount

        '#07: Contain

        Dim strAddress As String = txt07.Text
        Dim blnContain As Boolean
        blnContain = strAddress.ToUpper.Contains("Jefferson Street")
        If blnContain = blnContain Then
            strAddress = "Jefferson Street Found"
        Else
            strAddress = "Jefferson Street Not Found"

        End If
        lbl07Contains.Text = strAddress

        '#12: Len/Remove
        Dim strRemove As String = txt12.Text
        Dim dblRemove As Double
        Const dblTAX_RATE As Double = 10
        dblRemove = txt12.Text.Length
        strRemove = strRemove.Remove(3)




        lbl12LenRomove.Text = strRemove


        '#13: Like

        Dim dblZip As Double
        Dim strZip As String = txt13.Text



        If strZip Like "[605]##" Then



        End If

        lbl13Like.Text = strZip

    End Sub
End Class
