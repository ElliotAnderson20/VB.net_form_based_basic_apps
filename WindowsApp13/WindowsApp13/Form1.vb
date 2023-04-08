Public Class Form1
    Dim i, j, r As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = InputBox("enter first value")
        j = InputBox("enter second value")
        r = Val(i) * Val(j)
        MsgBox("result =" & r)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        i = InputBox("enter first value")
        j = InputBox("enter second value")
        r = Val(i) / Val(j)
        MsgBox("result =" & r)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = InputBox("enter first value")
        j = InputBox("enter second value")
        r = Val(i) - Val(j)
        MsgBox("result =" & r)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = InputBox("enter first value")
        j = InputBox("enter second value")
        r = Val(i) + Val(j)
        MsgBox("result=" & r)
    End Sub
End Class
