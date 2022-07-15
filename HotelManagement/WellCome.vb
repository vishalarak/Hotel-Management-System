Public Class WellCome

    Private Sub LoginPageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginPageToolStripMenuItem.Click
        Admin.Show()
        Me.Hide()

    End Sub

    Private Sub LoginPageToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginPageToolStripMenuItem1.Click
        Login.Show()
        Me.Hide()

    End Sub

    Private Sub WellCome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label9.Text = Date.Now.ToString("dd-MMM-yy")
    End Sub
End Class