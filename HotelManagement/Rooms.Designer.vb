<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rooms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rooms))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.roomstatustxt = New System.Windows.Forms.ComboBox()
        Me.roomnotxt = New System.Windows.Forms.ComboBox()
        Me.save = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.roomphonetxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.room = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1688, 156)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 34)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(537, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 41)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Hotel Management"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(870, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(662, 138)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(658, 472)
        Me.DataGridView1.TabIndex = 53
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(658, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 20)
        Me.Label8.TabIndex = 54
        Me.Label8.Text = "Rooms List"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1267, 108)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(46, 27)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 57
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox1.Location = New System.Drawing.Point(1052, 108)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 27)
        Me.TextBox1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Room No"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Room Phone"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(202, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Room Status"
        '
        'roomstatustxt
        '
        Me.roomstatustxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.roomstatustxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.roomstatustxt.FormattingEnabled = True
        Me.roomstatustxt.Items.AddRange(New Object() {"Free ", "Booked"})
        Me.roomstatustxt.Location = New System.Drawing.Point(382, 285)
        Me.roomstatustxt.Name = "roomstatustxt"
        Me.roomstatustxt.Size = New System.Drawing.Size(148, 28)
        Me.roomstatustxt.TabIndex = 61
        '
        'roomnotxt
        '
        Me.roomnotxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.roomnotxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.roomnotxt.FormattingEnabled = True
        Me.roomnotxt.Items.AddRange(New Object() {"101", "102", "103", "104", "105", "201", "202", "203", "204", "205"})
        Me.roomnotxt.Location = New System.Drawing.Point(382, 144)
        Me.roomnotxt.Name = "roomnotxt"
        Me.roomnotxt.Size = New System.Drawing.Size(148, 28)
        Me.roomnotxt.TabIndex = 63
        '
        'save
        '
        Me.save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.save.Location = New System.Drawing.Point(180, 512)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(99, 32)
        Me.save.TabIndex = 64
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.update.Location = New System.Drawing.Point(309, 512)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(99, 32)
        Me.update.TabIndex = 65
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.delete.Location = New System.Drawing.Point(431, 512)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(99, 32)
        Me.delete.TabIndex = 66
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.clear.Location = New System.Drawing.Point(557, 512)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(99, 32)
        Me.clear.TabIndex = 67
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'roomphonetxt
        '
        Me.roomphonetxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.roomphonetxt.Location = New System.Drawing.Point(382, 222)
        Me.roomphonetxt.Name = "roomphonetxt"
        Me.roomphonetxt.Size = New System.Drawing.Size(148, 27)
        Me.roomphonetxt.TabIndex = 72
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(202, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "AC / Non AC"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"AC", "Non AC"})
        Me.ComboBox1.Location = New System.Drawing.Point(382, 354)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(148, 28)
        Me.ComboBox1.TabIndex = 74
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Room Type"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ComboBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Single Bed", "Double Bed", "Family Bed"})
        Me.ComboBox2.Location = New System.Drawing.Point(382, 425)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(148, 28)
        Me.ComboBox2.TabIndex = 76
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 34)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Reservation"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 34)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Customer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(18, 125)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 34)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 34)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Rooms"
        '
        'room
        '
        Me.room.Location = New System.Drawing.Point(21, 488)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(124, 34)
        Me.room.TabIndex = 73
        Me.room.Text = "Back"
        Me.room.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.room)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 622)
        Me.Panel1.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Payment"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Rooms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 622)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.roomphonetxt)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.roomnotxt)
        Me.Controls.Add(Me.roomstatustxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Rooms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents roomstatustxt As System.Windows.Forms.ComboBox
    Friend WithEvents roomnotxt As System.Windows.Forms.ComboBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents roomphonetxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents room As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
