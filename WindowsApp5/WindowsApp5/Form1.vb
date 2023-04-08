
Imports System.Text.RegularExpressions
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "please enter your name")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "enter your password")
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
        Dim number As New Regex("/d{10}")
        If number.IsMatch(TextBox3.Text) Then
            ErrorProvider1.SetError(TextBox3, "")
            MsgBox("valid phone number")
        Else
            ErrorProvider1.SetError(TextBox3, "invalid phone number")
        End If
    End Sub
End Class
