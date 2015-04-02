Imports System.Data.OleDb

Public Class flat
    Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db3.accdb")
    Private Sub Table3BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table3BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table3BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db3DataSet)

    End Sub

    Private Sub flat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db3DataSet.Table3' table. You can move, or remove it, as needed.
        Me.Table3TableAdapter.Fill(Me.Db3DataSet.Table3)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db3.accdb")
            Dim q1 As New OleDbCommand
            ob.Open()

            q1.CommandText = "INSERT INTO [Table3]  ([num of flats],[flats in each floor],[num of rooms in each flat],[flat sq])VALUES(?,?,?,?)  "
            q1.Parameters.AddWithValue("@a", NumericUpDown1.Value)
            q1.Parameters.AddWithValue("@a", NumericUpDown2.Value)
            q1.Parameters.AddWithValue("@b", NumericUpDown3.Value)
            q1.Parameters.AddWithValue("@c", T1.Text)


            q1.Connection = ob
            q1.ExecuteNonQuery()
            ob.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ob.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        manager.Show()
    End Sub
End Class