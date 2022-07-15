<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.room = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.custid = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.custnametxt = New System.Windows.Forms.TextBox()
        Me.roomnotxt = New System.Windows.Forms.TextBox()
        Me.daystxt = New System.Windows.Forms.TextBox()
        Me.ratetxt = New System.Windows.Forms.TextBox()
        Me.tidtxt = New System.Windows.Forms.TextBox()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.pmethodtxt = New System.Windows.Forms.ComboBox()
        Me.clear = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.Paid = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.printpreviwe = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.custidtxt = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.room)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 610)
        Me.Panel1.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(21, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 54
        Me.Button1.Text = "Reservation"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'room
        '
        Me.room.Location = New System.Drawing.Point(21, 469)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(124, 34)
        Me.room.TabIndex = 53
        Me.room.Text = "Back"
        Me.room.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 31)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Payment"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 199)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 34)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Customer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 107)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 34)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 287)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 34)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Rooms"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 41)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Hotel Management"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(196, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Days"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(196, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 20)
        Me.Label4.TabIndex = 77
        Me.Label4.Text = "Room Number"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Name"
        '
        'custid
        '
        Me.custid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.custid.AutoSize = True
        Me.custid.Location = New System.Drawing.Point(196, 145)
        Me.custid.Name = "custid"
        Me.custid.Size = New System.Drawing.Size(111, 20)
        Me.custid.TabIndex = 75
        Me.custid.Text = "Customer Id"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(196, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Rate"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(196, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 20)
        Me.Label8.TabIndex = 84
        Me.Label8.Text = "Payment Method"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(196, 490)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 20)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Transaction Id"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(196, 552)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 20)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Total Ammount"
        '
        'custnametxt
        '
        Me.custnametxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.custnametxt.Location = New System.Drawing.Point(390, 199)
        Me.custnametxt.Name = "custnametxt"
        Me.custnametxt.Size = New System.Drawing.Size(148, 27)
        Me.custnametxt.TabIndex = 87
        '
        'roomnotxt
        '
        Me.roomnotxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.roomnotxt.Location = New System.Drawing.Point(390, 254)
        Me.roomnotxt.Name = "roomnotxt"
        Me.roomnotxt.Size = New System.Drawing.Size(148, 27)
        Me.roomnotxt.TabIndex = 88
        '
        'daystxt
        '
        Me.daystxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.daystxt.Location = New System.Drawing.Point(390, 312)
        Me.daystxt.Name = "daystxt"
        Me.daystxt.Size = New System.Drawing.Size(148, 27)
        Me.daystxt.TabIndex = 89
        '
        'ratetxt
        '
        Me.ratetxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.ratetxt.Location = New System.Drawing.Point(390, 369)
        Me.ratetxt.Name = "ratetxt"
        Me.ratetxt.Size = New System.Drawing.Size(148, 27)
        Me.ratetxt.TabIndex = 90
        '
        'tidtxt
        '
        Me.tidtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.tidtxt.Location = New System.Drawing.Point(390, 490)
        Me.tidtxt.Name = "tidtxt"
        Me.tidtxt.Size = New System.Drawing.Size(148, 27)
        Me.tidtxt.TabIndex = 91
        '
        'totaltxt
        '
        Me.totaltxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.totaltxt.Location = New System.Drawing.Point(390, 552)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(148, 27)
        Me.totaltxt.TabIndex = 92
        '
        'pmethodtxt
        '
        Me.pmethodtxt.FormattingEnabled = True
        Me.pmethodtxt.Items.AddRange(New Object() {"Cash", "Debit Card", "Creadit Card", "UPI"})
        Me.pmethodtxt.Location = New System.Drawing.Point(390, 429)
        Me.pmethodtxt.Name = "pmethodtxt"
        Me.pmethodtxt.Size = New System.Drawing.Size(148, 28)
        Me.pmethodtxt.TabIndex = 93
        '
        'clear
        '
        Me.clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.clear.Location = New System.Drawing.Point(746, 193)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(99, 32)
        Me.clear.TabIndex = 97
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.delete.Location = New System.Drawing.Point(937, 196)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(99, 32)
        Me.delete.TabIndex = 96
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.update.Location = New System.Drawing.Point(862, 145)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(99, 32)
        Me.update.TabIndex = 95
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'Paid
        '
        Me.Paid.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Paid.Location = New System.Drawing.Point(689, 145)
        Me.Paid.Name = "Paid"
        Me.Paid.Size = New System.Drawing.Size(99, 32)
        Me.Paid.TabIndex = 94
        Me.Paid.Text = "Paid"
        Me.Paid.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button3.Location = New System.Drawing.Point(1100, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 32)
        Me.Button3.TabIndex = 98
        Me.Button3.Text = "Print"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'printpreviwe
        '
        Me.printpreviwe.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.printpreviwe.Location = New System.Drawing.Point(1032, 145)
        Me.printpreviwe.Name = "printpreviwe"
        Me.printpreviwe.Size = New System.Drawing.Size(167, 32)
        Me.printpreviwe.TabIndex = 99
        Me.printpreviwe.Text = "Print Previwe"
        Me.printpreviwe.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HotelManagement.My.Resources.Resources.images
        Me.PictureBox1.Location = New System.Drawing.Point(380, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(626, 242)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(675, 361)
        Me.DataGridView1.TabIndex = 100
        '
        'custidtxt
        '
        Me.custidtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.custidtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.custidtxt.FormattingEnabled = True
        Me.custidtxt.Location = New System.Drawing.Point(390, 137)
        Me.custidtxt.Name = "custidtxt"
        Me.custidtxt.Size = New System.Drawing.Size(148, 28)
        Me.custidtxt.TabIndex = 101
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 610)
        Me.Controls.Add(Me.custidtxt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.printpreviwe)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.Paid)
        Me.Controls.Add(Me.pmethodtxt)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Me.tidtxt)
        Me.Controls.Add(Me.ratetxt)
        Me.Controls.Add(Me.daystxt)
        Me.Controls.Add(Me.roomnotxt)
        Me.Controls.Add(Me.custnametxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.custid)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents room As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents custid As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents custnametxt As TextBox
    Friend WithEvents roomnotxt As TextBox
    Friend WithEvents daystxt As TextBox
    Friend WithEvents ratetxt As TextBox
    Friend WithEvents tidtxt As TextBox
    Friend WithEvents totaltxt As TextBox
    Friend WithEvents pmethodtxt As ComboBox
    Friend WithEvents clear As Button
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents Paid As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents printpreviwe As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents custidtxt As ComboBox
End Class
