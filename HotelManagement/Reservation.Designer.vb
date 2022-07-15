<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.room = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.custidtxt = New System.Windows.Forms.ComboBox()
        Me.custroomtxt = New System.Windows.Forms.ComboBox()
        Me.custnametxt = New System.Windows.Forms.TextBox()
        Me.dateintxt = New System.Windows.Forms.DateTimePicker()
        Me.dateouttxt = New System.Windows.Forms.DateTimePicker()
        Me.save = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.rtypetxt = New System.Windows.Forms.TextBox()
        Me.actypetxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.room)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 615)
        Me.Panel1.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(21, 407)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 34)
        Me.Button3.TabIndex = 54
        Me.Button3.Text = "Payment"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'room
        '
        Me.room.Location = New System.Drawing.Point(21, 486)
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
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(167, 31)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Reservation"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(21, 143)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(124, 34)
        Me.Button5.TabIndex = 43
        Me.Button5.Text = "Home"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(21, 226)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 34)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Rooms"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(21, 324)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 34)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Customer"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Customer Id"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 41)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Hotel Management"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(210, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Customer Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(210, 396)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Date In"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Date Out"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(210, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Room No"
        '
        'custidtxt
        '
        Me.custidtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.custidtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.custidtxt.FormattingEnabled = True
        Me.custidtxt.Location = New System.Drawing.Point(417, 135)
        Me.custidtxt.Name = "custidtxt"
        Me.custidtxt.Size = New System.Drawing.Size(148, 28)
        Me.custidtxt.TabIndex = 32
        '
        'custroomtxt
        '
        Me.custroomtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.custroomtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.custroomtxt.FormattingEnabled = True
        Me.custroomtxt.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.custroomtxt.Location = New System.Drawing.Point(417, 245)
        Me.custroomtxt.Name = "custroomtxt"
        Me.custroomtxt.Size = New System.Drawing.Size(148, 28)
        Me.custroomtxt.TabIndex = 33
        '
        'custnametxt
        '
        Me.custnametxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.custnametxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.custnametxt.Location = New System.Drawing.Point(417, 189)
        Me.custnametxt.Name = "custnametxt"
        Me.custnametxt.Size = New System.Drawing.Size(148, 27)
        Me.custnametxt.TabIndex = 34
        '
        'dateintxt
        '
        Me.dateintxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dateintxt.Location = New System.Drawing.Point(417, 389)
        Me.dateintxt.Name = "dateintxt"
        Me.dateintxt.Size = New System.Drawing.Size(148, 27)
        Me.dateintxt.TabIndex = 35
        '
        'dateouttxt
        '
        Me.dateouttxt.Location = New System.Drawing.Point(417, 441)
        Me.dateouttxt.Name = "dateouttxt"
        Me.dateouttxt.Size = New System.Drawing.Size(148, 27)
        Me.dateouttxt.TabIndex = 36
        '
        'save
        '
        Me.save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.save.Location = New System.Drawing.Point(194, 499)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(99, 32)
        Me.save.TabIndex = 40
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.update.Location = New System.Drawing.Point(299, 499)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(99, 32)
        Me.update.TabIndex = 41
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.delete.Location = New System.Drawing.Point(417, 499)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(99, 32)
        Me.delete.TabIndex = 42
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.clear.Location = New System.Drawing.Point(539, 499)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(99, 32)
        Me.clear.TabIndex = 43
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(666, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Reservation List"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(670, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(658, 472)
        Me.DataGridView1.TabIndex = 45
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1274, 98)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox1.Location = New System.Drawing.Point(1059, 98)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 27)
        Me.TextBox1.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button1.Location = New System.Drawing.Point(194, 555)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 32)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "First"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button6.Location = New System.Drawing.Point(299, 555)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 32)
        Me.Button6.TabIndex = 49
        Me.Button6.Text = "Last"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button7.Location = New System.Drawing.Point(417, 555)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(99, 32)
        Me.Button7.TabIndex = 50
        Me.Button7.Text = "Next"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button8.Location = New System.Drawing.Point(539, 555)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(99, 32)
        Me.Button8.TabIndex = 51
        Me.Button8.Text = "Previous"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(398, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(147, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 52
        Me.PictureBox1.TabStop = False
        '
        'rtypetxt
        '
        Me.rtypetxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.rtypetxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.rtypetxt.Location = New System.Drawing.Point(417, 299)
        Me.rtypetxt.Name = "rtypetxt"
        Me.rtypetxt.Size = New System.Drawing.Size(148, 27)
        Me.rtypetxt.TabIndex = 53
        '
        'actypetxt
        '
        Me.actypetxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.actypetxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.actypetxt.Location = New System.Drawing.Point(417, 344)
        Me.actypetxt.Name = "actypetxt"
        Me.actypetxt.Size = New System.Drawing.Size(148, 27)
        Me.actypetxt.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(210, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 20)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Room Type"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 351)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 20)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "AC / Non AC"
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 615)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.actypetxt)
        Me.Controls.Add(Me.rtypetxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.dateouttxt)
        Me.Controls.Add(Me.dateintxt)
        Me.Controls.Add(Me.custnametxt)
        Me.Controls.Add(Me.custroomtxt)
        Me.Controls.Add(Me.custidtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Reservation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservation"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents custidtxt As System.Windows.Forms.ComboBox
    Friend WithEvents custroomtxt As System.Windows.Forms.ComboBox
    Friend WithEvents custnametxt As System.Windows.Forms.TextBox
    Friend WithEvents dateintxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateouttxt As System.Windows.Forms.DateTimePicker
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents room As System.Windows.Forms.Button
    Friend WithEvents Button3 As Button
    Friend WithEvents rtypetxt As TextBox
    Friend WithEvents actypetxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
