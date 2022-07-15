Public Class Login
    Dim cn As New OleDb.OleDbConnection

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If usertxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Enter the  staff name and password")
        Else
            Dim Querry = "select * from Staff where sname='" & usertxt.Text & "' And Pass=" & passtxt.Text & ""
            Dim cmd = New OleDb.OleDbCommand(Querry, cn)
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(cmd)
            Dim ds As DataSet = New DataSet()
            da.Fill(ds)
            Dim a As Integer
            a = ds.Tables(0).Rows.Count
            If a = 0 Then
                MsgBox("Invalid Username or Password")
            Else
                Customer.Show()
                Me.Hide()
                usertxt.Text = ""
                passtxt.Text = ""
            End If
            usertxt.Text = ""
            passtxt.Text = ""
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            passtxt.PasswordChar = "*"
        Else
            passtxt.PasswordChar = ""
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\College\Programing\Project Material\HotelManagementSystemFinale.mdb"
        cn.Open()
        Timer1.Enabled = True
        Timer2.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("hh:mm:ss")
        Label5.Text = Date.Now.ToString("dd-MMM-yy")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Admin.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        WellCome.Show()
        Me.Hide()

    End Sub

    Private Sub usertxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub passtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passtxt.TextChanged

    End Sub
End Class
