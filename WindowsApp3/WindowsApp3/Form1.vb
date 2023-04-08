Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add(5)
        ComboBox1.Items.Add(8)
        ComboBox1.Items.Add(12)
        ComboBox2.Items.Add(6)
        ComboBox2.Items.Add(11)
        ComboBox2.Items.Add(17)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim average As Single
        average = (Val(ComboBox1.Text) + Val(ComboBox2.Text)) / 2
        MsgBox("average" & average)
    End Sub
End Class
