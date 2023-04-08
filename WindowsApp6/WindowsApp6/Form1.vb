Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Dim res As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        Call findmax(a, b)
        res = findmax(a, b)
        MessageBox.Show("maximum number " & res)
        Console.ReadLine()
    End Sub
    Private Function findmax(ByVal num1 As Integer, ByVal num2 As Integer)
        Dim result As Integer
        If (num1 > num2) Then
            result = num1
        Else
            result = num2

        End If
        findmax = result

    End Function
End Class
