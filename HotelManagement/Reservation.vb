Imports System.Data.OleDb

Public Class Reservation
    Dim cn As New OleDb.OleDbConnection

    Private Sub FillCistomer()
        Dim cmd As New OleDbCommand("select * from Customer", cn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        custidtxt.DataSource = tbl
        custidtxt.DisplayMember = "ID"
        custidtxt.ValueMember = "ID"
    End Sub
    Private Sub FillRoom()
        Dim Status = "Free"
        Dim cmd As New OleDbCommand("select * from Room where rstatus='" & Status & "'", cn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim tb As New DataTable
        adapter.Fill(tb)
        custroomtxt.DataSource = tb
        custroomtxt.DisplayMember = "RNo"
        custroomtxt.ValueMember = "RNo"
    End Sub
    Private Sub GetName()
        Dim Query = "select * from Customer where ID=" & custidtxt.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(Query, cn)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            custnametxt.Text = "" + reader(1).ToString
        End While

    End Sub

    Private Sub UpdateRoom()
        Dim Status = "Booked"
        Try
            Dim cmd As New OleDb.OleDbCommand
            cmd.Connection = cn
            cmd.CommandText = "update Room set rstatus='" & Status & "'where RNo=" & custroomtxt.SelectedValue.ToString() & ""
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated")
            datagridShow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Reservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        MsgBox("Wellcome")
        datagridShow()
        FillCistomer()
        FillRoom()
    End Sub

    Private Sub datagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from Resrvation", cn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Rooms.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Staff.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub custidtxt_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custidtxt.SelectionChangeCommitted
        GetName()

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If custidtxt.SelectedIndex = -1 Or custroomtxt.SelectedIndex = -1 Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "insert into Reservation(cid,cname,rno,datein,dateout)values(" & custidtxt.SelectedValue.ToString & ",'" & custnametxt.Text & "'," & custroomtxt.SelectedValue.ToString & ",'" & dateintxt.Value & "','" & dateouttxt.Value & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Room Booked")
                datagridShow()
                UpdateRoom()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        If custidtxt.SelectedIndex = -1 Or custroomtxt.SelectedIndex = -1 Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cn As New OleDb.OleDbConnection
                cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
                cn.Open()
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "update Reservation set cname='" & custnametxt.Text & "',rno=" & custroomtxt.SelectedValue.ToString & ",datein='" & dateintxt.Value & "',dateout='" & dateouttxt.Value & "'where cid=" & custidtxt.SelectedValue.ToString & ""
                cmd.ExecuteNonQuery()
                MsgBox("Data Updated")
                datagridShow()
                UpdateRoom()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        custidtxt.SelectedValue = selectedRow.Cells(0).Value.ToString()
        custnametxt.Text = selectedRow.Cells(1).Value.ToString()
        custroomtxt.SelectedValue = selectedRow.Cells(2).Value.ToString()
        rtypetxt.Text = selectedRow.Cells(3).Value.ToString()
        actypetxt.Text = selectedRow.Cells(4).Value.ToString()
        dateintxt.Value = selectedRow.Cells(5).Value.ToString()
        dateouttxt.Value = selectedRow.Cells(6).Value.ToString()
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
        cn.Open()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cn
        cmd.CommandText = "delete from Reservation where cid=" & custidtxt.SelectedValue.ToString & ""
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted")
        datagridShow()
        UpdateRoom()

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        custidtxt.Text = ""
        custnametxt.Text = ""
        custroomtxt.Text = ""
       
    End Sub

    Private Sub room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles room.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub custidtxt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles custidtxt.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Payment.Show()
        Me.Hide()

    End Sub
End Class