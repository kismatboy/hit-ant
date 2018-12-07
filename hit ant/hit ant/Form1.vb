Public Class Form1
    'to move borderless form
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim increase As Integer = 0
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If start.Enabled Then
        Else
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If

    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If start.Enabled Then
        Else
            If drag Then
                Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
                Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
            End If
        End If

    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        If start.Enabled Then
        Else
            drag = False
        End If

    End Sub


    'some needed golbal variable

    Dim ant(6) As PictureBox
    Dim lvl As Integer = 1
    Dim score As Integer = 0
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        For i As Integer = 0 To 5
            If (picSugar.Bounds.IntersectsWith(ant(i).Bounds)) Then
                form_restart(e, e)
                MessageBox.Show("game over" + vbNewLine + "your score is " & score, "GAME OVER")
                gameover()
            End If
        Next

    End Sub
    Private Sub gameover()
        score = 0
        lblScore.Text = "Score " & 0
        Timer2.Stop()
        start.Stop()
    End Sub
    Private Sub start_Tick(sender As Object, e As EventArgs) Handles start.Tick
        For i As Integer = 0 To 5
            If lblLabel.Text = "level 2" Then
                ant(i).Top -= 4
            ElseIf lblLabel.Text = "level 3" Then
                ant(i).Top -= 6
            ElseIf lblLabel.Text = "level 4" Then
                ant(i).Top -= 8
            ElseIf lblLabel.Text = "level 5" Then
                ant(i).Top -= 14
            Else
                ant(i).Top -= 2
            End If
        Next
        If score > 5 And score <= 10 Then
            lblLabel.Text = "level 2"
        ElseIf score > 10 And score <= 15 Then
            lblLabel.Text = "level 3"
        ElseIf score > 15 And score <= 20 Then
            lblLabel.Text = "level 4"
        ElseIf score > 20 And score <= 25 Then
            lblLabel.Text = "level 5"
        ElseIf score > 25 And score <= 30 Then
            lblLabel.Text = "level 6"
        ElseIf score > 30 And score <= 35 Then
            lblLabel.Text = "level 7"
        ElseIf score > 35 And score <= 40 Then
            lblLabel.Text = "level 8"
        ElseIf score > 40 And score <= 45 Then
            lblLabel.Text = "level 9"
        ElseIf score > 45 And score <= 50 Then
            lblLabel.Text = "level 10 (max)"
        ElseIf score > 55 Then
            start.Stop()
            Timer2.Stop()
            ' MessageBox.Show("congratulation you win the game", "congratulation")
            Select Case MsgBox("congratulation you win the game." + vbNewLine + "Do you want to play this game again?", MsgBoxStyle.YesNoCancel, "congratulation")
                Case MsgBoxResult.Yes
                    form_restart(e, e)
                Case MsgBoxResult.Cancel
                    Application.Exit()
                Case MsgBoxResult.No
                    form_restart(e, e)
            End Select
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLabel.Text = "level 1"
        lblScore.Text = "score 0"
        ant(0) = PictureBox1
        ant(1) = PictureBox2
        ant(2) = PictureBox3
        ant(3) = PictureBox4
        ant(4) = PictureBox5
        ant(5) = PictureBox6
    End Sub
    Private Sub score_inc()
        score = score + 1
        lblScore.Text = "Score " & score
    End Sub
    ' for random generation of picture box
    Dim random As New Random
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        picKilled.Top = PictureBox1.Top
        picKilled.Left = PictureBox1.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            ' Dim newTop As Integer = random.Next(Me.Height - PictureBox1.Height)
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox1.Width)
            PictureBox1.Top = 472
            PictureBox1.Left = newLeft
        End If

    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        picKilled.Top = PictureBox2.Top
        picKilled.Left = PictureBox2.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            ' PictureBox2.Location = New Point(200, 400)
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox2.Width)
            PictureBox2.Top = 472
            PictureBox2.Left = newLeft
        End If
    End Sub
    Private Sub PictureBox3_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox3.DoubleClick
        picKilled.Top = PictureBox3.Top
        picKilled.Left = PictureBox3.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox3.Width)
            PictureBox3.Top = 472
            PictureBox3.Left = newLeft
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        picKilled.Top = PictureBox4.Top
        picKilled.Left = PictureBox4.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox4.Width)
            PictureBox4.Top = 472
            PictureBox4.Left = newLeft
        End If
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        picKilled.Top = PictureBox5.Top
        picKilled.Left = PictureBox5.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox5.Width)
            PictureBox5.Top = 472
            PictureBox5.Left = newLeft
        End If

    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        picKilled.Top = PictureBox6.Top
        picKilled.Left = PictureBox6.Left
        picKilled.Show()
        If start.Enabled Then
            score_inc()
            Dim newLeft As Integer = random.Next(Me.Width - PictureBox6.Width)
            PictureBox6.Top = 472
            PictureBox6.Left = newLeft
        End If
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub PlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem.Click
        start.Start()
        Timer2.Start()
    End Sub

    Private Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        start.Stop()
        Timer2.Stop()

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        MsgBox("                 game control

                 'p' to play
                 'q' to quite
                 'r' to restart
                  space to pause

(*Please use mouse for better performance)

(hit 2 times for big ants and 1 time for small ants)

dont let the ants to eat sugar hehe :-)

Developer: Romeo Sunil Sapkota

Report bug: sunilsapkota9@gmail.com :-)
          : admin@sapkotasunil.com.np :-)")
    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        form_restart(e, e)

    End Sub
    Private Sub form_restart(sender As Object, e As EventArgs)
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) > 1 Then
            lvlkey.Text = e.KeyChar
        End If
    End Sub

    Private Sub t_keyPress_Tick(sender As Object, e As EventArgs) Handles t_keyPress.Tick
        If lvlkey.Text = "q" Or lvlkey.Text = "Q" Then
            Application.Exit()
        End If
        If lvlkey.Text = "p" Or lvlkey.Text = "P" Then
            start.Start()
            Timer2.Start()
        End If
        If lvlkey.Text = " " Then
            start.Stop()
            Timer2.Stop()
        End If
        If lvlkey.Text = "r" Or lvlkey.Text = "R" Then
            form_restart(e, e)
        End If
    End Sub

    Private Sub HighScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoreToolStripMenuItem.Click
        MsgBox("highest score: " & My.Settings.h_score)
    End Sub

    Private Sub hscores_Tick(sender As Object, e As EventArgs) Handles hscores.Tick

        If score > My.Settings.h_score Then
            My.Settings.h_score = score
            My.Settings.Save()

            increase = 1
        End If
    End Sub
End Class
