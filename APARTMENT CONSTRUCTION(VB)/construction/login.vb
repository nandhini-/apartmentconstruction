Public Class login

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        customer.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel1.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "priya" And TextBox2.Text = "123" Then
            apartment.Show()

        elseif TextBox1.Text = Nothing Or TextBox2.Text = Nothing
            MsgBox("fill the column")
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        customer1.Show()
    End Sub
End Class