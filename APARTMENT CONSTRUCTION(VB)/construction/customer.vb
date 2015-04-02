Imports System.Data.OleDb
Public Class customer
    Dim con As OleDbConnection
    Dim a, b As String
    Private Sub customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Db1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Db1DataSet.Table1)
        'TODO: This line of code loads data into the 'Db2DataSet1.Table2' table. You can move, or remove it, as needed.
        Me.Table2TableAdapter.Fill(Me.Db2DataSet1.Table2)
        ' a=AcceptButton.
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            TextBox2.Text = 500000
        Else
            TextBox2.Text = 1000000
        End If
    End Sub

    Private Sub Table2BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table2BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table2BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db2DataSet1)

    End Sub







    Private Sub FillBy2ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\elcot\Documents\db1.accdb")
            con.Open()
            Dim query As OleDbCommand
            Dim st = "select [square feet],[area] from Table1 where [place] = '" & labourer.t2.Text & " '"
            MsgBox(st)
            query = New OleDbCommand(st, con)
            Dim acc As OleDbDataReader
            acc = query.ExecuteReader()
            acc.Read()
            Dim b As Form2
            b = New Form2
            b.TextBox1.Text = acc.GetString(0)
            b.TextBox2.Text = acc.GetString(1)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("invalid place")
        End Try


    End Sub

    Private Sub Specialist_inToolStripTextBox_Click(sender As Object, e As EventArgs)

    End Sub

   

    Private Sub FillBy1ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.Table2TableAdapter.FillBy3(Me.Db2DataSet1.Table2)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub PlaceTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class