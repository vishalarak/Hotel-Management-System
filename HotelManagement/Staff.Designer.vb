﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Staff))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.reserv = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.coustemer = New System.Windows.Forms.Button()
        Me.room = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nmtxt = New System.Windows.Forms.TextBox()
        Me.contxt = New System.Windows.Forms.TextBox()
        Me.gendertxt = New System.Windows.Forms.ComboBox()
        Me.sidtxt = New System.Windows.Forms.TextBox()
        Me.addtxt = New System.Windows.Forms.RichTextBox()
        Me.save = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.clear = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.reserv)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.coustemer)
        Me.Panel1.Controls.Add(Me.room)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 599)
        Me.Panel1.TabIndex = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(23, 407)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(124, 34)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "Payment"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label10.Location = New System.Drawing.Point(45, 559)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Logout"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(23, 495)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 34)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'reserv
        '
        Me.reserv.Location = New System.Drawing.Point(23, 330)
        Me.reserv.Name = "reserv"
        Me.reserv.Size = New System.Drawing.Size(124, 34)
        Me.reserv.TabIndex = 5
        Me.reserv.Text = "Reservtion"
        Me.reserv.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'coustemer
        '
        Me.coustemer.Location = New System.Drawing.Point(23, 249)
        Me.coustemer.Name = "coustemer"
        Me.coustemer.Size = New System.Drawing.Size(124, 34)
        Me.coustemer.TabIndex = 2
        Me.coustemer.Text = "Coustemer"
        Me.coustemer.UseVisualStyleBackColor = True
        '
        'room
        '
        Me.room.Location = New System.Drawing.Point(23, 164)
        Me.room.Name = "room"
        Me.room.Size = New System.Drawing.Size(124, 34)
        Me.room.TabIndex = 1
        Me.room.Text = "Rooms"
        Me.room.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(4, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 34)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Staff"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(527, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hotel Management"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Staff Id"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(197, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(197, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(197, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Contact No"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 344)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Address"
        '
        'nmtxt
        '
        Me.nmtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.nmtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.nmtxt.Location = New System.Drawing.Point(351, 164)
        Me.nmtxt.Name = "nmtxt"
        Me.nmtxt.Size = New System.Drawing.Size(214, 27)
        Me.nmtxt.TabIndex = 8
        '
        'contxt
        '
        Me.contxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.contxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.contxt.Location = New System.Drawing.Point(351, 283)
        Me.contxt.Name = "contxt"
        Me.contxt.Size = New System.Drawing.Size(214, 27)
        Me.contxt.TabIndex = 10
        '
        'gendertxt
        '
        Me.gendertxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.gendertxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.gendertxt.FormattingEnabled = True
        Me.gendertxt.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.gendertxt.Location = New System.Drawing.Point(351, 225)
        Me.gendertxt.Name = "gendertxt"
        Me.gendertxt.Size = New System.Drawing.Size(139, 28)
        Me.gendertxt.TabIndex = 13
        '
        'sidtxt
        '
        Me.sidtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.sidtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.sidtxt.Location = New System.Drawing.Point(351, 106)
        Me.sidtxt.Name = "sidtxt"
        Me.sidtxt.Size = New System.Drawing.Size(139, 27)
        Me.sidtxt.TabIndex = 14
        '
        'addtxt
        '
        Me.addtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.addtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.addtxt.Location = New System.Drawing.Point(351, 344)
        Me.addtxt.Name = "addtxt"
        Me.addtxt.Size = New System.Drawing.Size(214, 61)
        Me.addtxt.TabIndex = 15
        Me.addtxt.Text = ""
        '
        'save
        '
        Me.save.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.save.Location = New System.Drawing.Point(191, 495)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(99, 32)
        Me.save.TabIndex = 16
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.update.Location = New System.Drawing.Point(309, 495)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(99, 32)
        Me.update.TabIndex = 17
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.delete.Location = New System.Drawing.Point(429, 495)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(99, 32)
        Me.delete.TabIndex = 18
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'clear
        '
        Me.clear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.clear.Location = New System.Drawing.Point(546, 495)
        Me.clear.Name = "clear"
        Me.clear.Size = New System.Drawing.Size(99, 32)
        Me.clear.TabIndex = 19
        Me.clear.Text = "Clear All"
        Me.clear.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(667, 106)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(667, 488)
        Me.DataGridView1.TabIndex = 20
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(429, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(197, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 20)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Password"
        '
        'passtxt
        '
        Me.passtxt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.passtxt.ForeColor = System.Drawing.Color.DarkBlue
        Me.passtxt.Location = New System.Drawing.Point(351, 425)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(214, 27)
        Me.passtxt.TabIndex = 23
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1281, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.TextBox2.Location = New System.Drawing.Point(1060, 73)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(220, 27)
        Me.TextBox2.TabIndex = 45
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(671, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 20)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Staff List"
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1338, 599)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.clear)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.addtxt)
        Me.Controls.Add(Me.sidtxt)
        Me.Controls.Add(Me.gendertxt)
        Me.Controls.Add(Me.contxt)
        Me.Controls.Add(Me.nmtxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Staff"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nmtxt As System.Windows.Forms.TextBox
    Friend WithEvents contxt As System.Windows.Forms.TextBox
    Friend WithEvents gendertxt As System.Windows.Forms.ComboBox
    Friend WithEvents sidtxt As System.Windows.Forms.TextBox
    Friend WithEvents addtxt As System.Windows.Forms.RichTextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents update As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents clear As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents coustemer As System.Windows.Forms.Button
    Friend WithEvents room As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents reserv As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As Button
End Class
