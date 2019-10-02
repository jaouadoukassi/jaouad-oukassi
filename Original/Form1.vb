Public Class Form1

    Dim n1 As Integer
    Dim n2 As Integer
    Dim res As Integer





    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)


        res = n1 + n2
        TextBox3.Text = res.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)


        res = n1 - n2
        TextBox3.Text = res.ToString






    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)


        res = n1 * n2
        TextBox3.Text = res.ToString







    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        n1 = CInt(TextBox1.Text)
        n2 = CInt(TextBox2.Text)

        res = n1 / n2
        TextBox3.Text = res.ToString






    End Sub
End Class

