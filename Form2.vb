Public Class Form2
    Dim a As Integer
    Dim x2 As Integer
    Dim y2 As Integer '代表食物中心座標
    Dim reply As Integer
    Dim player1 As New WMPLib.WindowsMediaPlayer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles boommov.Tick



        ime.Image = mejump.Image

        If a = 1 Then
            ime.Top += 90
            boom.Visible = False

        End If

        If ime.Top + ime.Height > PictureBox1.Top Then
            ime.Image = PictureBox5.Image

        End If
        '人擋牆
        If ime.Top > PictureBox1.Top + PictureBox1.Height - ime.Height Then
            ime.Top = PictureBox1.Top - ime.Height
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick '球往回飛(下)


        ball.Left -= 15
        ball.Top -= 15
        If ball.Left < block.Left Then
            Timer6.Enabled = True
            Timer2.Enabled = False
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles enemove.Tick '永遠執行Timer
        '對手的移動
        Randomize()
        ene.Left = Int(15 + Rnd() * (Me.Width - 15 - ene.Width - 15 + 1))
        ene.Top = Int(15 + Rnd() * (Me.Width - 15 - ene.Width - 15 + 1))


        '對手擋牆
        If ene.Left < block.Left + block.Width Then
            ene.Left = block.Left + block.Width

        End If

        If ene.Left < ball.Left + ball.Width And
            ene.Top < ball.Top + ball.Height Then

            Timer8.Enabled = False
            Timer2.Enabled = True
            Timer6.Enabled = True
        End If

        '球落地
        If ball.Top > PictureBox1.Top - ball.Height AndAlso ball.Left < block.Left Then
            ball.Top = PictureBox1.Top - ball.Height

            Label3.Text += 1
            boommov.Enabled = False
            Timer2.Enabled = False
            enemove.Enabled = False
            Timer4.Enabled = False
            Timer5.Enabled = False
            Timer6.Enabled = False
            Timer7.Enabled = False
            Timer8.Enabled = False
            Timer9.Enabled = False



            '重發
            Button3.Enabled = True
            Button3.Visible = True
        ElseIf ball.Top > PictureBox4.Top - ball.Height AndAlso ball.Left < block.Left Then
            ball.Top = PictureBox4.Top - ball.Height

            Label1.Text += 1
            boommov.Enabled = False
                Timer2.Enabled = False
                enemove.Enabled = False
                Timer4.Enabled = False
                Timer5.Enabled = False
                Timer6.Enabled = False
                Timer7.Enabled = False
                Timer8.Enabled = False
                Timer9.Enabled = False



                '重發
                Button3.Enabled = True
                Button3.Visible = True

            End If



        '球掉到邊邊
        If ball.Left < Me.Left + 5 - ball.Width Then
            ball.Left = Me.Left + 5 - ball.Width
            ball.Top += 10


        End If

        If ball.Top > PictureBox4.Top - ball.Height AndAlso ball.Left > block.Left Then
            Label1.Text += 1
            Button1.Enabled = True
        End If

        If Label1.Text = 5 Then
            reply = MsgBox("你贏了阿阿阿阿!!還要玩嗎?", 32 + 4)
            If reply = 6 Then
                reply = MsgBox("玩遊戲傷眼睛 去休息!", 48 + 0)
                If reply = 1 Then
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf reply = 7 Then
                Form1.Show()
                Me.Close()
            End If
        ElseIf Label3.Text = 5 Then
            reply = MsgBox("阿阿阿阿好菜!!要再試一次嗎?", 32 + 4)
            If reply = 6 Then
                reply = MsgBox("你那麼菜還想玩喔 ", 48 + 0)
                If reply = 1 Then
                    Form1.Show()
                    Me.Close()
                End If
            ElseIf reply = 7 Then
                Form1.Show()
                Me.Close()
            End If
        End If


    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick '球往右下掉



        x2 = ball.Left + ball.Width
        y2 = ball.Top + ball.Height
        '打球
        If x2 > ime.Left And
                x2 < ime.Left + ime.Width And
                y2 > ime.Top And
                y2 < ime.Top + ime.Height Then

            Timer8.Enabled = True
        End If


    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick


        If ball.Top < PictureBox3.Top + PictureBox3.Height Then
            ball.Top = PictureBox3.Top + PictureBox3.Height
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick '對手掛網


        If ball.Left < block.Left + block.Width AndAlso
            ball.Top < block.Top - ball.Height Then

            Timer7.Enabled = True

        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick

        ball.Top += 10
        ball.Left -= 13

        x2 = ball.Left + ball.Width
        y2 = ball.Top + ball.Height
        '打球
        If x2 > ime.Left And
                x2 < ime.Left + ime.Width And
                y2 > ime.Top And
                y2 < ime.Top + ime.Height Then
            My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\打臉音效.wav", AudioPlayMode.Background)

            Timer6.Enabled = False
            Timer7.Enabled = False
            Timer9.Enabled = True

        End If

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick '右下
        My.Computer.Audio.Play(My.Application.Info.DirectoryPath & "\打臉音效.wav", AudioPlayMode.Background)

        ball.Left += 15
        ball.Top += 10
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        Timer8.Enabled = False
        ball.Top -= 15

        If ball.Top < reball.Top Then
            Timer4.Enabled = True
            Timer9.Enabled = False
            ball.Top = reball.Top
            Timer10.Enabled = True

        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.W Then
            a = 1


            ime.Top -= 45
            boommov.Enabled = True
            boom.Visible = True




        ElseIf e.KeyCode = Keys.A Then
            ime.Left -= 15
        ElseIf e.KeyCode = Keys.D Then
            ime.Left += 15
        End If

        '黨強
        If ime.Left < 0 Then
            ime.Left = 0
        ElseIf ime.Left > Me.Width - 300 - ime.Width Then
            ime.Left = Me.Width - 300 - ime.Width
        End If

        If ime.Top < 0 Then
            ime.Top = 0
        ElseIf ime.Top > Me.Height - 40 - ime.Height Then
            ime.Top = Me.Height - 40 - ime.Height
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Visible = True
        Me.Close()

    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click '說明
        enemove.Enabled = True
        Button1.Enabled = False
        Button2.Enabled = False
        Button2.Visible = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer4.Enabled = True
        enemove.Enabled = True
        Button3.Visible = False
        Button3.Enabled = False
        Button1.Enabled = False
        ball.Location = reball.Location
    End Sub



    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick

        ball.Top += 2

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        player1.settings.setMode("loop", True)
    End Sub

    Private Sub ene_Click(sender As Object, e As EventArgs) Handles ene.Click

    End Sub

    Private Sub ball_Click(sender As Object, e As EventArgs) Handles ball.Click

    End Sub
End Class