Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        InputBox("a=", a)
        InputBox("b=", b)
        MsgBox("Please close it.")


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Print("123")
    End Sub
End Class
