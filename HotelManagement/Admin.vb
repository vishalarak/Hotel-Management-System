Public Class Admin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As String
        Username = usertxt.Text
        Password = passtxt.Text
        If (Username.Equals("Admin") And Password.Equals("vishal")) Then
            MsgBox("Login Success")
            Staff.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Username or Password")
        End If
        usertxt.Text = ""
        passtxt.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            passtxt.PasswordChar = "*"
        Else
            passtxt.PasswordChar = ""
        End If
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("hh:mm:ss")
        Label5.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Login.Show()
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
End Class