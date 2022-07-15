Imports System.Data.OleDb

Public Class Staff
    Dim cn As New OleDb.OleDbConnection

    Private Sub Staff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        da = New OleDbDataAdapter("select * from Staff", cn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

    End Sub


    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If sidtxt.Text = "" Or nmtxt.Text = "" Or gendertxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "insert into Staff(sid,sname,gender,contactno,address,pass) values(" & sidtxt.Text & ",'" & nmtxt.Text & "','" & gendertxt.Text & "'," & contxt.Text & ",'" & addtxt.Text & "'," & passtxt.Text & ")"
                cmd.ExecuteNonQuery()
                MsgBox("Data Saved")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        sidtxt.Text = ""
        nmtxt.Text = ""
        gendertxt.Text = ""
        contxt.Text = ""
        addtxt.Text = ""
        passtxt.Text = ""
        datagridShow()


    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
        cn.Open()
        If sidtxt.Text = "" Or nmtxt.Text = "" Or gendertxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "delete from Staff where sid=" & sidtxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystem.mdb"
        cn.Open()
        If sidtxt.Text = "" Or nmtxt.Text = "" Or gendertxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDbCommand
                cmd.Connection = cn
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "update Staff set sname='" & nmtxt.Text & "',gender='" & gendertxt.Text & "',contactno=" & contxt.Text & ",address='" & addtxt.Text & "',Pass=" & passtxt.Text & " where sid=" & sidtxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Staff Updated")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub ToolStripComboBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub coustemer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coustemer.Click
        Customer.Show()
        Me.Hide()

    End Sub

    Private Sub room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles room.Click
        Rooms.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reserv.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        sidtxt.Text = selectedRow.Cells(0).Value.ToString()
        nmtxt.Text = selectedRow.Cells(1).Value.ToString()
        gendertxt.Text = selectedRow.Cells(2).Value.ToString()
        contxt.Text = selectedRow.Cells(3).Value.ToString()
        addtxt.Text = selectedRow.Cells(4).Value.ToString()
        passtxt.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Admin.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Payment.Show()
        Me.Hide()

    End Sub
End Class