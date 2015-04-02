Imports System.Data.OleDb

Public Class apartment
    Dim a As String
    Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db1.accdb")
    Private Sub B1_Click(sender As Object, e As EventArgs) Handles B1.Click
        Table1BindingSource.AddNew()
        Try
            Dim ob As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db1.accdb")
            Dim q1 As New OleDbCommand
            ob.Open()

            q1.CommandText = "INSERT INTO [Table1]  ([apartnament name],[square feet],[place],[area])VALUES(?,?,?,?)  "
            q1.Parameters.AddWithValue("@a", T1.Text)
            q1.Parameters.AddWithValue("@b", T2.Text)
            q1.Parameters.AddWithValue("@c", T3.Text)
            q1.Parameters.AddWithValue("@d", T4.Text)
           
            q1.Connection = ob
            q1.ExecuteNonQuery()
            ob.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        ob.Close()

    End Sub



    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db1DataSet)

    End Sub

    Private Sub apartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Db1DataSet.Table1)

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs)
        Table1TableAdapter.Update(Db1DataSet.Table1)

    End Sub

  
    Private Sub B3_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db1DataSet)
    End Sub

    Private Sub T1_TextChanged(sender As Object, e As EventArgs) Handles T1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        labourer.Show()
    End Sub
End Class
