Imports System.Data.OleDb

Public Class Payment
    Dim cn As New OleDb.OleDbConnection
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WellCome.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Rooms.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Customer.Show()
        Me.Hide()
    End Sub

    Private Sub room_Click(sender As Object, e As EventArgs) Handles room.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub printpreviwe_Click(sender As Object, e As EventArgs) Handles printpreviwe.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Hotel Management", New Font("Lucida Calligraphy", 40, FontStyle.Underline), Brushes.DarkBlue, New Point(100, 20))
        e.Graphics.DrawString("Aurangabad", New Font("Lucida Calligraphy", 20, FontStyle.Regular), Brushes.DarkBlue, New Point(320, 90))
        e.Graphics.DrawString("Date:" + DateAndTime.Now, New Font("Arial", 13, FontStyle.Regular), Brushes.Black, New Point(50, 160))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, New Point(30, 185))
        e.Graphics.DrawString("Customer Id:" + custidtxt.Text, New Font("Arial", 15, FontStyle.Bold), Brushes.Black, New Point(40, 240))
        e.Graphics.DrawString("Customer Name:" + custnametxt.Text, New Font("Arial", 15, FontStyle.Bold), Brushes.Black, New Point(40, 290))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, New Point(30, 330))
        e.Graphics.DrawString("Room No", New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(50, 350))
        e.Graphics.DrawString("Days", New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(180, 350))
        e.Graphics.DrawString("Rate", New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(300, 350))
        e.Graphics.DrawString("Total Ammount", New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(510, 350))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, New Point(30, 380))
        e.Graphics.DrawString(roomnotxt.Text, New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(45, 500))
        e.Graphics.DrawString(daystxt.Text, New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(185, 500))
        e.Graphics.DrawString(ratetxt.Text, New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(305, 500))
        e.Graphics.DrawString(totaltxt.Text, New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(520, 500))
        e.Graphics.DrawString("Transaction Id:" + tidtxt.Text, New Font("Arial", 18, FontStyle.Regular), Brushes.Black, New Point(500, 770))
        e.Graphics.DrawString("Payment Mode:" + pmethodtxt.Text, New Font("Arial", 15, FontStyle.Regular), Brushes.Black, New Point(40, 770))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, New Point(30, 700))
        e.Graphics.DrawString("---------------------------------------------------------------------------------------------------------------------------------------------------------------------", New Font("Arial", 10, FontStyle.Regular), Brushes.Black, New Point(30, 895))
        e.Graphics.DrawString("Thank you for your visit..!!", New Font("Lucida Calligraphy", 25, FontStyle.Regular), Brushes.DarkBlue, New Point(170, 950))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDocument1.Print()

    End Sub

    Private Sub Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        MsgBox("Wellcome")
        datagridShow()
        FillCistomer()
    End Sub

    Private Sub datagridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from Billing", cn)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs) Handles Paid.Click
        If custidtxt.Text = "" Or custnametxt.Text = "" Or roomnotxt.Text = "" Or daystxt.Text = "" Or ratetxt.Text = "" Or pmethodtxt.Text = "" Or tidtxt.Text = "" Or totaltxt.Text = "" Then
            MsgBox("Information Missing")
        Else
            Try
                Dim cmd As New OleDb.OleDbCommand
                cmd.Connection = cn
                cmd.CommandText = "insert into Billing(CId,CName,RNo,Days,Rate,PaymentMode,TId,Amount)values(" & custidtxt.Text & ",'" & custnametxt.Text & "'," & roomnotxt.Text & "," & daystxt.Text & "," & ratetxt.Text & "," & pmethodtxt.Text & "," & tidtxt.Text & "," & totaltxt.Text & ")"
                cmd.ExecuteNonQuery()
                MsgBox("Customer Data Saved")
                datagridShow()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click

    End Sub

    Private Sub clear_Click(sender As Object, e As EventArgs) Handles clear.Click
        custidtxt.Text = ""
        custnametxt.Text = ""
        roomnotxt.Text = ""
        daystxt.Text = ""
        ratetxt.Text = ""
        pmethodtxt.Text = ""
        tidtxt.Text = ""
        totaltxt.Text = ""
        datagridShow()
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click

    End Sub

    Private Sub FillCistomer()
        Dim cmd As New OleDbCommand("select * from Resrvation", cn)
        Dim adapter As New OleDbDataAdapter(cmd)
        Dim tbl As New DataTable
        adapter.Fill(tbl)
        custidtxt.DataSource = tbl
        custidtxt.DisplayMember = "CId"
        custidtxt.ValueMember = "CId"
    End Sub

    Private Sub GetName()
        Dim Query = "select * from resrvation where CId=" & custidtxt.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(Query, cn)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            custnametxt.Text = "" + reader(1).ToString
        End While

    End Sub

    Private Sub Fillroom()
        Dim Query = "select * from resrvation where CId=" & custidtxt.SelectedValue.ToString() & ""
        Dim cmd As New OleDbCommand(Query, cn)
        Dim dt As New DataTable
        Dim reader As OleDbDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            roomnotxt.Text = "" + reader(2).ToString
        End While
    End Sub
    Private Sub custidtxt_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles custidtxt.SelectionChangeCommitted
        GetName()
        Fillroom()
    End Sub
End Class