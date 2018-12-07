<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.picSugar = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.start = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lvlkey = New System.Windows.Forms.Label()
        Me.t_keyPress = New System.Windows.Forms.Timer(Me.components)
        Me.picKilled = New System.Windows.Forms.PictureBox()
        Me.HighScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hscores = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSugar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picKilled, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(341, 482)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 60)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(314, 359)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(57, 78)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'picSugar
        '
        Me.picSugar.Image = CType(resources.GetObject("picSugar.Image"), System.Drawing.Image)
        Me.picSugar.Location = New System.Drawing.Point(-12, 28)
        Me.picSugar.Margin = New System.Windows.Forms.Padding(0)
        Me.picSugar.Name = "picSugar"
        Me.picSugar.Size = New System.Drawing.Size(414, 67)
        Me.picSugar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSugar.TabIndex = 5
        Me.picSugar.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(141, 377)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(38, 60)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(64, 415)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(9, 274)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(38, 60)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(189, 445)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(57, 78)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'start
        '
        '
        'Timer2
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem, Me.ExitToolStripMenuItem, Me.StopToolStripMenuItem, Me.RestartToolStripMenuItem, Me.HelpToolStripMenuItem, Me.HighScoreToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(404, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.Image = CType(resources.GetObject("PlayToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.PlayToolStripMenuItem.Text = "play"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Image = CType(resources.GetObject("StopToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.StopToolStripMenuItem.Text = "pause"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Image = CType(resources.GetObject("RestartToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.RestartToolStripMenuItem.Text = "restart"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpToolStripMenuItem.Image = CType(resources.GetObject("HelpToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.HelpToolStripMenuItem.Text = "help"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.BackColor = System.Drawing.Color.DarkRed
        Me.lblLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblLabel.Location = New System.Drawing.Point(12, 28)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(42, 13)
        Me.lblLabel.TabIndex = 11
        Me.lblLabel.Text = "Level 1"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.BackColor = System.Drawing.Color.DarkRed
        Me.lblScore.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblScore.Location = New System.Drawing.Point(330, 28)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(44, 19)
        Me.lblScore.TabIndex = 12
        Me.lblScore.Text = "score"
        '
        'lvlkey
        '
        Me.lvlkey.AutoSize = True
        Me.lvlkey.Location = New System.Drawing.Point(335, 95)
        Me.lvlkey.Name = "lvlkey"
        Me.lvlkey.Size = New System.Drawing.Size(67, 13)
        Me.lvlkey.TabIndex = 13
        Me.lvlkey.Text = "key Checker"
        Me.lvlkey.Visible = False
        '
        't_keyPress
        '
        Me.t_keyPress.Enabled = True
        '
        'picKilled
        '
        Me.picKilled.Image = CType(resources.GetObject("picKilled.Image"), System.Drawing.Image)
        Me.picKilled.Location = New System.Drawing.Point(146, 184)
        Me.picKilled.Name = "picKilled"
        Me.picKilled.Size = New System.Drawing.Size(48, 40)
        Me.picKilled.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKilled.TabIndex = 14
        Me.picKilled.TabStop = False
        Me.picKilled.Visible = False
        '
        'HighScoreToolStripMenuItem
        '
        Me.HighScoreToolStripMenuItem.Image = Global.hit_ant.My.Resources.Resources.icons8_trophy_64
        Me.HighScoreToolStripMenuItem.Name = "HighScoreToolStripMenuItem"
        Me.HighScoreToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HighScoreToolStripMenuItem.Text = "high score"
        '
        'hscores
        '
        Me.hscores.Enabled = True
        Me.hscores.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(404, 545)
        Me.Controls.Add(Me.lvlkey)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.picSugar)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.picKilled)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ant killing"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSugar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picKilled, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents picSugar As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents start As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblLabel As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lvlkey As Label
    Friend WithEvents t_keyPress As Timer
    Friend WithEvents picKilled As PictureBox
    Friend WithEvents HighScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hscores As Timer
End Class
