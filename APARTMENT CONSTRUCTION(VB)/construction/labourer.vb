Imports System.Data.OleDb

Public Class labourer
    Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db2.accdb")
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db2DataSet)

    End Sub

    Private Sub labourer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db2DataSet.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Db2DataSet.Table2)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table2BindingSource.AddNew()
        Try
            Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db2.accdb")
            Dim q1 As New OleDbCommand
            ob.Open()

            q1.CommandText = "INSERT INTO [Table2]  ([labour name],[address],[place],[area],[specialist in])VALUES(?,?,?,?,?)  "
            q1.Parameters.AddWithValue("@a", t1.Text)
            q1.Parameters.AddWithValue("@a", r1.Text)
            q1.Parameters.AddWithValue("@b", t2.Text)
            q1.Parameters.AddWithValue("@c", t3.Text)
            q1.Parameters.AddWithValue("@d", ComboBox1.SelectedItem)

            q1.Connection = ob
            q1.ExecuteNonQuery()
            ob.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ob.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        flat.Show()
    End Sub
End Class