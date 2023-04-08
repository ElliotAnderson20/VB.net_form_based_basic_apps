Public Class Form1
    Dim i As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        i = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox3.Text = i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        i = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox3.Text = i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        i = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox3.Text = i
    End Sub

End Class
