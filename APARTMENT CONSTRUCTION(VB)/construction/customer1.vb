Public Class customer1

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = 0 Then
            TextBox4.Text = "raghul"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            TextBox4.Text = "shiva"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            TextBox4.Text = "savi"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            TextBox4.Text = "kani"
        Else
            TextBox4.Text = " keerthi"
        End If
    End Sub

    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db1DataSet)

    End Sub

    Private Sub customer1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db2DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Db2DataSet.Table2)
        'TODO: This line of code loads data into the 'Db1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Db1DataSet.Table1)

    End Sub

    Private Sub FillBy4ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table2TableAdapter.FillBy4(Me.Db2DataSet.Table2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Interior_designingToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table2TableAdapter.interior_designing(Me.Db2DataSet.Table2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox4.SelectedIndex = 0 Then
            TextBox2.Text = 100000
        ElseIf ComboBox4.SelectedIndex = 1 Then
            TextBox2.Text = 200000
        ElseIf ComboBox4.SelectedIndex = 2 Then
            TextBox2.Text = 400000
        Else
            TextBox2.Text = 10000
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ComboBox4.SelectedIndex = 0 Then
            Form5.Show()
        ElseIf ComboBox4.SelectedIndex = 1 Then
            Form6.Show()
        ElseIf ComboBox4.SelectedIndex = 2 Then
            Form3.Show()
        Else
            Form4.Show()
        End If
    End Sub
End Class