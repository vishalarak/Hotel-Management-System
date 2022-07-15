Imports System.Data.OleDb

Public Class Rooms
    Dim cn As New OleDb.OleDbConnection
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Staff.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Rooms_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        MsgBox("Wellcome")
        datagridShow()
    End Sub

    Private Sub datagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from Room", cn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If roomnotxt.Text = "" Or roomphonetxt.Text = "" Or roomstatustxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "insert into Room(rno,rphone,rstatus) values(" & roomnotxt.Text & "," & roomphonetxt.Text & ",'" & roomstatustxt.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Data Saved")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Staff.Show()
        Me.Hide()

    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
          Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
        cn.Open()
        If roomnotxt.Text = "" Or roomphonetxt.Text = "" Or roomstatustxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "update Room set rphone=" & roomphonetxt.Text & ",rstatus='" & roomstatustxt.Text & "'where rno=" & roomnotxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
        cn.Open()
        If roomnotxt.Text = "" Or roomphonetxt.Text = "" Or roomstatustxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "delete from Room where rno=" & roomnotxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        roomnotxt.Text = ""
        roomphonetxt.Text = ""
        roomstatustxt.Text = ""
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        roomnotxt.Text = selectedRow.Cells(0).Value.ToString()
        roomphonetxt.Text = selectedRow.Cells(1).Value.ToString()
        roomstatustxt.Text = selectedRow.Cells(2).Value.ToString()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles room.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Payment.Show()
        Me.Hide()
    End Sub
End Class