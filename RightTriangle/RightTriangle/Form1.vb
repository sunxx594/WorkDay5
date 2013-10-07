Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim hyp As Double
        Dim SideOne, SideTwo As Double
        SideOne = CDbl(txtSideOne.Text)
        SideTwo = CDbl(txtSideTwo.Text)
        hyp = Hypotenuse(SideOne, SideTwo)
        txtHyp.Text = CStr(hyp)
    End Sub

    Function Hypotenuse(ByVal SideOne As Double, ByVal SideTwo As Double) As Double

        Return Math.Sqrt(SideOne ^ 2 + SideTwo ^ 2)
    End Function
End Class
