Public Class ModCalculator

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtInput.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim input As Decimal
        Dim remainder As Integer
        Dim ans As Decimal
        'input
        input = CDec(TxtInput.Text)
        'process
        remainder = input Mod 16
        ans = input / 16
        'output 
        TxtMod.Text = CStr(remainder)
        txtAns.Text = CStr(ans)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub LblAns_Click(sender As Object, e As EventArgs) Handles LblAns.Click

    End Sub

    Private Sub LblInput_Click(sender As Object, e As EventArgs) Handles LblInput.Click

    End Sub
End Class
