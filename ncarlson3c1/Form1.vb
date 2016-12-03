Public Class Form1


    Private Sub txtMeasurments_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurments.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
            Handles txtMeasurments.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
            radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged
        Dim dblMeasurment As Double = 0.0
        Dim dblResult As Double = 0.0

        Double.TryParse(txtMeasurments.Text, dblMeasurment)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblMeasurment, dblResult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblMeasurment, dblResult)
        ElseIf radFuncCentimeters.Checked Then
            dblResult = CalcCentimetersFunc(dblMeasurment)
        ElseIf radFuncInches.Checked Then
            dblResult = CalcInchesFunc(dblMeasurment)

        End If

        lblResults.Text = dblResult.ToString("n2")

    End Sub

    Private Sub CalcCentimetersSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblMeas As Double, ByRef dblRes As Double)
        dblRes = dblMeas / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblMeas As Double) As Double
        Dim dblNew As Double
        dblNew = dblMeas * 2.54
        Return dblNew



    End Function

    Private Function CalcInchesFunc(ByVal dblMeas As Double)
        Dim dblNew As Double
        dblNew = dblMeas / 2.54
        Return dblNew
    End Function

    '-------------------------------------------------------------------------------------------------------------------------
    'Add planets to cboPlanets
    'Set selected item to Earth

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Venus")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Jupiter")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    'Display weight

    Private Sub WeightChanged(sender As Object, e As EventArgs) _
        Handles txtEarthWeight.TextChanged, radSubWeight.CheckedChanged, radFuncWeight.CheckedChanged, cboPlanets.TextChanged
        Dim intEarthWeight As Integer
        Dim dblWeightonPlanet As Double = 0.0
        Dim dblGravity As Double = 0.0

        Integer.TryParse(txtEarthWeight.Text, intEarthWeight)

        If radSubWeight.Checked Then
            CalcWeightSub(intEarthWeight, dblWeightonPlanet)
        ElseIf radFuncWeight.Checked Then
            dblWeightonPlanet = CalcFuncWeight(intEarthWeight)

        End If





        lblWeight.Text = dblWeightonPlanet.ToString

    End Sub

    'Calculate sub

    Private Sub CalcWeightSub(ByVal intWeight As Integer, ByRef dblWeight As Double)
        Dim dblGravity As Double


        Select Case dblGravity
            Case cboPlanets.SelectedItem = "Mercury"
                dblGravity = 0.38
            Case cboPlanets.SelectedItem = "Mars"
                dblGravity = 0.38
            Case cboPlanets.SelectedItem = "Venus"
                dblGravity = 0.91
            Case cboPlanets.SelectedItem = "Earth"
                dblGravity = 1.0
            Case cboPlanets.SelectedItem = "Jupiter"
                dblGravity = 2.34
            Case cboPlanets.SelectedItem = "Saturn"
                dblGravity = 1.06
            Case cboPlanets.SelectedItem = "Uranus"
                dblGravity = 0.92
            Case cboPlanets.SelectedItem = "Neptun"
                dblGravity = 1.14
            Case cboPlanets.SelectedItem = "Pluto"
                dblGravity = 0.06
        End Select
        If cboPlanets.SelectedItem = "Mercury" Then
            dblWeight = 0.38 * intWeight
        ElseIf cboPlanets.SelectedItem = "Mars" Then
            dblWeight = 0.38 * intWeight
        ElseIf cboPlanets.SelectedItem = "Venus" Then
            dblWeight = 0.92 * intWeight
        ElseIf cboPlanets.SelectedItem = "Earth" Then
            dblWeight = 1.0 * intWeight
        ElseIf cboPlanets.SelectedItem = "Jupiter" Then
            dblWeight = 2.34 * intWeight
        ElseIf cboPlanets.SelectedItem = "Saturn" Then
            dblWeight = 1.06 * intWeight
        ElseIf cboPlanets.SelectedItem = "Uranus" Then
            dblWeight = 0.92 * intWeight
        ElseIf cboPlanets.SelectedItem = "Neptune" Then
            dblWeight = 1.14 * intWeight
        ElseIf cboPlanets.SelectedItem = "Pluto" Then
            dblWeight = 0.06 * intWeight

        End If




    End Sub

    'calculate function

    Private Function CalcFuncWeight(ByVal intWeight As Integer) As Double
        Dim dblNewWeight As Double
        If cboPlanets.SelectedItem = "Mercury" Then
            dblNewWeight = 0.38 * intWeight
        ElseIf cboPlanets.SelectedItem = "Mars" Then
            dblNewWeight = 0.38 * intWeight
        ElseIf cboPlanets.SelectedItem = "Venus" Then
            dblNewWeight = 0.92 * intWeight
        ElseIf cboPlanets.SelectedItem = "Earth" Then
            dblNewWeight = 1.0 * intWeight
        ElseIf cboPlanets.SelectedItem = "Jupiter" Then
            dblNewWeight = 2.34 * intWeight
        ElseIf cboPlanets.SelectedItem = "Saturn" Then
            dblNewWeight = 1.06 * intWeight
        ElseIf cboPlanets.SelectedItem = "Uranus" Then
            dblNewWeight = 0.92 * intWeight
        ElseIf cboPlanets.SelectedItem = "Neptune" Then
            dblNewWeight = 1.14 * intWeight
        ElseIf cboPlanets.SelectedItem = "Pluto" Then
            dblNewWeight = 0.06 * intWeight

        End If
        Return dblNewWeight
    End Function

    'select all text

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles txtEarthWeight.Enter
        If txtEarthWeight.SelectionLength = 0 Then

            txtEarthWeight.SelectAll()
        End If
    End Sub

    'Allow only # and backspace

    Private Sub txtEarthWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
End Class
