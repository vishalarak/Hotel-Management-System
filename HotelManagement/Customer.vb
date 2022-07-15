Imports System.Data.OleDb

Public Class Customer
    Dim cn As New OleDb.OleDbConnection

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        da = New OleDbDataAdapter("select * from Customer", cn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        If Cidtxt.Text = "" Or nametxt.Text = "" Or gendertxt.Text = "" Or adhartxt.Text = "" Or adulttxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "insert into Customer(ID,CName,Gender,AdharNo,Adult,Children,ContactNo,Address)values(" & Cidtxt.Text & ",'" & nametxt.Text & "','" & gendertxt.Text & "'," & adhartxt.Text & "," & adulttxt.Text & "," & childtxt.Text & "," & contxt.Text & ",'" & addtxt.Text & "')"
                cmd.ExecuteNonQuery()
                MsgBox("Customer Data Saved")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles update.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        If Cidtxt.Text = "" Or nametxt.Text = "" Or gendertxt.Text = "" Or adhartxt.Text = "" Or adulttxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "update customer set CName='" & nametxt.Text & "',gender='" & gendertxt.Text & "',AdharNo=" & adhartxt.Text & ",age='" & adulttxt.Text & "', ContactNo=" & contxt.Text & ",address='" & addtxt.Text & "'where Cid=" & Cidtxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Customer Data Updated")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        Dim cn As New OleDb.OleDbConnection
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        If Cidtxt.Text = "" Or nametxt.Text = "" Or gendertxt.Text = "" Or adhartxt.Text = "" Or adulttxt.Text = "" Or contxt.Text = "" Or addtxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "delete from Customer where Cid=" & Cidtxt.Text & ""
                cmd.ExecuteNonQuery()
                MsgBox("Customer Data Deleted")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clear.Click
        Cidtxt.Text = ""
        nametxt.Text = ""
        gendertxt.Text = ""
        adhartxt.Text = ""
        adulttxt.Text = ""
        contxt.Text = ""
        addtxt.Text = ""
        datagridShow()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        WellCome.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Staff.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        Cidtxt.Text = selectedRow.Cells(0).Value.ToString()
        nametxt.Text = selectedRow.Cells(1).Value.ToString()
        gendertxt.Text = selectedRow.Cells(2).Value.ToString()
        adhartxt.Text = selectedRow.Cells(3).Value.ToString()
        adulttxt.Text = selectedRow.Cells(4).Value.ToString()
        childtxt.Text = selectedRow.Cells(5).Value.ToString()
        contxt.Text = selectedRow.Cells(6).Value.ToString()
        addtxt.Text = selectedRow.Cells(7).Value.ToString()
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Rooms.Show()
        Me.Hide()

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reservation.Show()
        Me.Hide()

    End Sub

    Private Sub room_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles room.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Payment.Show()
        Me.Hide()

    End Sub
End Class