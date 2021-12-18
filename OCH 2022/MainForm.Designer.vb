<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ChatPanel = New System.Windows.Forms.Panel()
        Me.ChatboxPanel = New System.Windows.Forms.Panel()
        Me.MessageBox = New System.Windows.Forms.TextBox()
        Me.MessageBox_Fill_Lower = New System.Windows.Forms.PictureBox()
        Me.MessageBox_Fill_Upper = New System.Windows.Forms.PictureBox()
        Me.MessageBox_Corners_Left = New System.Windows.Forms.PictureBox()
        Me.MessageBox_Corners_Right = New System.Windows.Forms.PictureBox()
        Me.ChannelPannel = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel13 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel12 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel11 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel10 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel9 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel8 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel7 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel6 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel5 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel4 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel3 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel2 = New System.Windows.Forms.Panel()
        Me.ChannelButtonPanel1 = New System.Windows.Forms.Panel()
        Me.ServerPanel = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel10 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel9 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel8 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel7 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel6 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel5 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel4 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel3 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel2 = New System.Windows.Forms.Panel()
        Me.ServerButtonPanel1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChatPanel.SuspendLayout()
        Me.ChatboxPanel.SuspendLayout()
        CType(Me.MessageBox_Fill_Lower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageBox_Fill_Upper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageBox_Corners_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MessageBox_Corners_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ChannelPannel.SuspendLayout()
        Me.ServerPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ChatPanel
        '
        Me.ChatPanel.Controls.Add(Me.Panel1)
        Me.ChatPanel.Controls.Add(Me.ChatboxPanel)
        Me.ChatPanel.Controls.Add(Me.ChannelPannel)
        Me.ChatPanel.Controls.Add(Me.ServerPanel)
        Me.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChatPanel.Location = New System.Drawing.Point(0, 0)
        Me.ChatPanel.Name = "ChatPanel"
        Me.ChatPanel.Size = New System.Drawing.Size(984, 611)
        Me.ChatPanel.TabIndex = 3
        '
        'ChatboxPanel
        '
        Me.ChatboxPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ChatboxPanel.Controls.Add(Me.MessageBox)
        Me.ChatboxPanel.Controls.Add(Me.MessageBox_Fill_Lower)
        Me.ChatboxPanel.Controls.Add(Me.MessageBox_Fill_Upper)
        Me.ChatboxPanel.Controls.Add(Me.MessageBox_Corners_Left)
        Me.ChatboxPanel.Controls.Add(Me.MessageBox_Corners_Right)
        Me.ChatboxPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ChatboxPanel.Location = New System.Drawing.Point(273, 535)
        Me.ChatboxPanel.Name = "ChatboxPanel"
        Me.ChatboxPanel.Size = New System.Drawing.Size(711, 76)
        Me.ChatboxPanel.TabIndex = 0
        '
        'MessageBox
        '
        Me.MessageBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MessageBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MessageBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessageBox.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.MessageBox.ForeColor = System.Drawing.Color.White
        Me.MessageBox.Location = New System.Drawing.Point(32, 17)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(649, 22)
        Me.MessageBox.TabIndex = 7
        '
        'MessageBox_Fill_Lower
        '
        Me.MessageBox_Fill_Lower.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MessageBox_Fill_Lower.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessageBox_Fill_Lower.Location = New System.Drawing.Point(32, 39)
        Me.MessageBox_Fill_Lower.Name = "MessageBox_Fill_Lower"
        Me.MessageBox_Fill_Lower.Size = New System.Drawing.Size(652, 14)
        Me.MessageBox_Fill_Lower.TabIndex = 6
        Me.MessageBox_Fill_Lower.TabStop = False
        '
        'MessageBox_Fill_Upper
        '
        Me.MessageBox_Fill_Upper.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MessageBox_Fill_Upper.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessageBox_Fill_Upper.Location = New System.Drawing.Point(32, 3)
        Me.MessageBox_Fill_Upper.Name = "MessageBox_Fill_Upper"
        Me.MessageBox_Fill_Upper.Size = New System.Drawing.Size(649, 14)
        Me.MessageBox_Fill_Upper.TabIndex = 5
        Me.MessageBox_Fill_Upper.TabStop = False
        '
        'MessageBox_Corners_Left
        '
        Me.MessageBox_Corners_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MessageBox_Corners_Left.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessageBox_Corners_Left.Image = CType(resources.GetObject("MessageBox_Corners_Left.Image"), System.Drawing.Image)
        Me.MessageBox_Corners_Left.Location = New System.Drawing.Point(17, 3)
        Me.MessageBox_Corners_Left.Name = "MessageBox_Corners_Left"
        Me.MessageBox_Corners_Left.Size = New System.Drawing.Size(15, 50)
        Me.MessageBox_Corners_Left.TabIndex = 4
        Me.MessageBox_Corners_Left.TabStop = False
        '
        'MessageBox_Corners_Right
        '
        Me.MessageBox_Corners_Right.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.MessageBox_Corners_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.MessageBox_Corners_Right.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MessageBox_Corners_Right.Image = CType(resources.GetObject("MessageBox_Corners_Right.Image"), System.Drawing.Image)
        Me.MessageBox_Corners_Right.Location = New System.Drawing.Point(681, 3)
        Me.MessageBox_Corners_Right.Name = "MessageBox_Corners_Right"
        Me.MessageBox_Corners_Right.Size = New System.Drawing.Size(15, 50)
        Me.MessageBox_Corners_Right.TabIndex = 3
        Me.MessageBox_Corners_Right.TabStop = False
        '
        'ChannelPannel
        '
        Me.ChannelPannel.AutoScroll = True
        Me.ChannelPannel.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel13)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel12)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel11)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel10)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel9)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel8)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel7)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel6)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel5)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel4)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel3)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel2)
        Me.ChannelPannel.Controls.Add(Me.ChannelButtonPanel1)
        Me.ChannelPannel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ChannelPannel.Location = New System.Drawing.Point(73, 0)
        Me.ChannelPannel.Name = "ChannelPannel"
        Me.ChannelPannel.Size = New System.Drawing.Size(200, 611)
        Me.ChannelPannel.TabIndex = 1
        '
        'ChannelButtonPanel13
        '
        Me.ChannelButtonPanel13.Location = New System.Drawing.Point(10, 538)
        Me.ChannelButtonPanel13.Name = "ChannelButtonPanel13"
        Me.ChannelButtonPanel13.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel13.TabIndex = 4
        '
        'ChannelButtonPanel12
        '
        Me.ChannelButtonPanel12.Location = New System.Drawing.Point(10, 494)
        Me.ChannelButtonPanel12.Name = "ChannelButtonPanel12"
        Me.ChannelButtonPanel12.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel12.TabIndex = 4
        '
        'ChannelButtonPanel11
        '
        Me.ChannelButtonPanel11.Location = New System.Drawing.Point(10, 450)
        Me.ChannelButtonPanel11.Name = "ChannelButtonPanel11"
        Me.ChannelButtonPanel11.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel11.TabIndex = 4
        '
        'ChannelButtonPanel10
        '
        Me.ChannelButtonPanel10.Location = New System.Drawing.Point(10, 406)
        Me.ChannelButtonPanel10.Name = "ChannelButtonPanel10"
        Me.ChannelButtonPanel10.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel10.TabIndex = 4
        '
        'ChannelButtonPanel9
        '
        Me.ChannelButtonPanel9.Location = New System.Drawing.Point(10, 362)
        Me.ChannelButtonPanel9.Name = "ChannelButtonPanel9"
        Me.ChannelButtonPanel9.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel9.TabIndex = 4
        '
        'ChannelButtonPanel8
        '
        Me.ChannelButtonPanel8.Location = New System.Drawing.Point(10, 318)
        Me.ChannelButtonPanel8.Name = "ChannelButtonPanel8"
        Me.ChannelButtonPanel8.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel8.TabIndex = 4
        '
        'ChannelButtonPanel7
        '
        Me.ChannelButtonPanel7.Location = New System.Drawing.Point(10, 274)
        Me.ChannelButtonPanel7.Name = "ChannelButtonPanel7"
        Me.ChannelButtonPanel7.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel7.TabIndex = 4
        '
        'ChannelButtonPanel6
        '
        Me.ChannelButtonPanel6.Location = New System.Drawing.Point(10, 230)
        Me.ChannelButtonPanel6.Name = "ChannelButtonPanel6"
        Me.ChannelButtonPanel6.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel6.TabIndex = 4
        '
        'ChannelButtonPanel5
        '
        Me.ChannelButtonPanel5.Location = New System.Drawing.Point(10, 186)
        Me.ChannelButtonPanel5.Name = "ChannelButtonPanel5"
        Me.ChannelButtonPanel5.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel5.TabIndex = 4
        '
        'ChannelButtonPanel4
        '
        Me.ChannelButtonPanel4.Location = New System.Drawing.Point(10, 142)
        Me.ChannelButtonPanel4.Name = "ChannelButtonPanel4"
        Me.ChannelButtonPanel4.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel4.TabIndex = 4
        '
        'ChannelButtonPanel3
        '
        Me.ChannelButtonPanel3.Location = New System.Drawing.Point(10, 98)
        Me.ChannelButtonPanel3.Name = "ChannelButtonPanel3"
        Me.ChannelButtonPanel3.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel3.TabIndex = 4
        '
        'ChannelButtonPanel2
        '
        Me.ChannelButtonPanel2.Location = New System.Drawing.Point(10, 54)
        Me.ChannelButtonPanel2.Name = "ChannelButtonPanel2"
        Me.ChannelButtonPanel2.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel2.TabIndex = 4
        '
        'ChannelButtonPanel1
        '
        Me.ChannelButtonPanel1.Location = New System.Drawing.Point(10, 10)
        Me.ChannelButtonPanel1.Name = "ChannelButtonPanel1"
        Me.ChannelButtonPanel1.Size = New System.Drawing.Size(180, 38)
        Me.ChannelButtonPanel1.TabIndex = 3
        '
        'ServerPanel
        '
        Me.ServerPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel10)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel9)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel8)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel7)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel6)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel5)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel4)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel3)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel2)
        Me.ServerPanel.Controls.Add(Me.ServerButtonPanel1)
        Me.ServerPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.ServerPanel.Location = New System.Drawing.Point(0, 0)
        Me.ServerPanel.Name = "ServerPanel"
        Me.ServerPanel.Size = New System.Drawing.Size(73, 611)
        Me.ServerPanel.TabIndex = 2
        '
        'ServerButtonPanel10
        '
        Me.ServerButtonPanel10.Location = New System.Drawing.Point(11, 516)
        Me.ServerButtonPanel10.Name = "ServerButtonPanel10"
        Me.ServerButtonPanel10.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel10.TabIndex = 13
        '
        'ServerButtonPanel9
        '
        Me.ServerButtonPanel9.Location = New System.Drawing.Point(12, 460)
        Me.ServerButtonPanel9.Name = "ServerButtonPanel9"
        Me.ServerButtonPanel9.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel9.TabIndex = 12
        '
        'ServerButtonPanel8
        '
        Me.ServerButtonPanel8.Location = New System.Drawing.Point(11, 404)
        Me.ServerButtonPanel8.Name = "ServerButtonPanel8"
        Me.ServerButtonPanel8.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel8.TabIndex = 11
        '
        'ServerButtonPanel7
        '
        Me.ServerButtonPanel7.Location = New System.Drawing.Point(11, 348)
        Me.ServerButtonPanel7.Name = "ServerButtonPanel7"
        Me.ServerButtonPanel7.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel7.TabIndex = 10
        '
        'ServerButtonPanel6
        '
        Me.ServerButtonPanel6.Location = New System.Drawing.Point(11, 292)
        Me.ServerButtonPanel6.Name = "ServerButtonPanel6"
        Me.ServerButtonPanel6.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel6.TabIndex = 9
        '
        'ServerButtonPanel5
        '
        Me.ServerButtonPanel5.Location = New System.Drawing.Point(11, 236)
        Me.ServerButtonPanel5.Name = "ServerButtonPanel5"
        Me.ServerButtonPanel5.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel5.TabIndex = 8
        '
        'ServerButtonPanel4
        '
        Me.ServerButtonPanel4.Location = New System.Drawing.Point(11, 180)
        Me.ServerButtonPanel4.Name = "ServerButtonPanel4"
        Me.ServerButtonPanel4.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel4.TabIndex = 7
        '
        'ServerButtonPanel3
        '
        Me.ServerButtonPanel3.Location = New System.Drawing.Point(11, 124)
        Me.ServerButtonPanel3.Name = "ServerButtonPanel3"
        Me.ServerButtonPanel3.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel3.TabIndex = 6
        '
        'ServerButtonPanel2
        '
        Me.ServerButtonPanel2.Location = New System.Drawing.Point(11, 68)
        Me.ServerButtonPanel2.Name = "ServerButtonPanel2"
        Me.ServerButtonPanel2.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel2.TabIndex = 5
        '
        'ServerButtonPanel1
        '
        Me.ServerButtonPanel1.Location = New System.Drawing.Point(11, 12)
        Me.ServerButtonPanel1.Name = "ServerButtonPanel1"
        Me.ServerButtonPanel1.Size = New System.Drawing.Size(50, 50)
        Me.ServerButtonPanel1.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(273, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 535)
        Me.Panel1.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(984, 611)
        Me.Controls.Add(Me.ChatPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1000, 650)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "O-Chat 2022"
        Me.ChatPanel.ResumeLayout(False)
        Me.ChatboxPanel.ResumeLayout(False)
        Me.ChatboxPanel.PerformLayout()
        CType(Me.MessageBox_Fill_Lower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageBox_Fill_Upper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageBox_Corners_Left, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MessageBox_Corners_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ChannelPannel.ResumeLayout(False)
        Me.ServerPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ChatPanel As Panel
    Friend WithEvents ChatboxPanel As Panel
    Friend WithEvents ChannelPannel As Panel
    Friend WithEvents ServerPanel As Panel
    Friend WithEvents ChannelButtonPanel13 As Panel
    Friend WithEvents ChannelButtonPanel12 As Panel
    Friend WithEvents ChannelButtonPanel11 As Panel
    Friend WithEvents ChannelButtonPanel10 As Panel
    Friend WithEvents ChannelButtonPanel9 As Panel
    Friend WithEvents ChannelButtonPanel8 As Panel
    Friend WithEvents ChannelButtonPanel7 As Panel
    Friend WithEvents ChannelButtonPanel6 As Panel
    Friend WithEvents ChannelButtonPanel5 As Panel
    Friend WithEvents ChannelButtonPanel4 As Panel
    Friend WithEvents ChannelButtonPanel3 As Panel
    Friend WithEvents ChannelButtonPanel2 As Panel
    Friend WithEvents ChannelButtonPanel1 As Panel
    Friend WithEvents ServerButtonPanel10 As Panel
    Friend WithEvents ServerButtonPanel9 As Panel
    Friend WithEvents ServerButtonPanel8 As Panel
    Friend WithEvents ServerButtonPanel7 As Panel
    Friend WithEvents ServerButtonPanel6 As Panel
    Friend WithEvents ServerButtonPanel5 As Panel
    Friend WithEvents ServerButtonPanel4 As Panel
    Friend WithEvents ServerButtonPanel3 As Panel
    Friend WithEvents ServerButtonPanel2 As Panel
    Friend WithEvents ServerButtonPanel1 As Panel
    Friend WithEvents MessageBox_Corners_Right As PictureBox
    Friend WithEvents MessageBox_Corners_Left As PictureBox
    Friend WithEvents MessageBox_Fill_Upper As PictureBox
    Friend WithEvents MessageBox_Fill_Lower As PictureBox
    Friend WithEvents MessageBox As TextBox
    Friend WithEvents Panel1 As Panel
End Class
