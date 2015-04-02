Imports System.Data.OleDb

Public Class manager
    Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db4.accdb")
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db4DataSet.Table4' table. You can move, or remove it, as needed.
        Me.Table4TableAdapter.Fill(Me.Db4DataSet.Table4)

    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click

        Try
            Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db4.accdb")
            Dim q1 As New OleDbCommand
            ob.Open()

            q1.CommandText = "INSERT INTO [Table4]  ([manager name],[num of labour],[place],[area])VALUES(?,?,?,?)  "
            q1.Parameters.AddWithValue("@a", T1.Text)
            q1.Parameters.AddWithValue("@a", NumericUpDown1.Value)
            q1.Parameters.AddWithValue("@b", T3.Text)
            q1.Parameters.AddWithValue("@c", T4.Text)


            q1.Connection = ob
            q1.ExecuteNonQuery()
            ob.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ob.Close()
       
    End Sub

    Private Sub Table4BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table4BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table4BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db4DataSet)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        login.Show()
    End Sub
End Class