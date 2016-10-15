Public Class Form1
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Const intMAX_PER_ROOM As Integer = 6
        Const dblDAILY_ROOM_CHG As Double = 225.5
        Const dblTAX_RATE As Double = 0.1625
        Const dblDAILY_RESORT_FEE As Double = 12.5
        Const strMSG As String = "You have exceeded the maximum guests per room."
        Dim intRoomsReserverd As Integer
        Dim intNights As Integer
        Dim intAdults As Integer
        Dim intChildren As Integer
        Dim intNumGuests As Integer
        Dim dblRoomsRequired As Double
        Dim dblTotalRoomChg As Double
        Dim dblTax As Double
        Dim dblTotalResortFee As Double
        Dim dblTotaldue As Double

        'store input in variables

        Integer.TryParse(txtRooms.Text, intRoomsReserverd)
        Integer.TryParse(txtNights.Text, intNights)
        Integer.TryParse(txtAdults.Text, intAdults)
        Integer.TryParse(txtChildren.Text, intChildren)

        'calculate total number of guests
        intNumGuests = intAdults + intChildren

        'calculate number of rooms required
        dblRoomsRequired = intNumGuests / intMAX_PER_ROOM

        If intRoomsReserverd < dblRoomsRequired Then
            MessageBox.Show(strMSG, "Treeline Resort",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        Else
            dblTotalRoomChg = intRoomsReserverd *
                intNights * dblDAILY_ROOM_CHG
            dblTax = dblTotalRoomChg * dblTAX_RATE
            dblTotalResortFee = intRoomsReserverd *
                intNights * dblDAILY_RESORT_FEE
            dblTotaldue = dblTotalRoomChg +
                dblTax + dblTotalResortFee
        End If

    End Sub
End Class
