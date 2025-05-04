Public Class Form5
    Dim reply As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reply = MsgBox("簡單模式不好玩，確定要玩嗎", 32 + 4)
        If reply = 6 Then
            PictureBox1.Visible = True
            reply = MsgBox("你沒得選，去玩困難模式", 48 + 0)
            PictureBox1.Visible = False
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Visible = True
        reply = MsgBox("我警告過你了!", 48 + 0)
        If reply = 1 Then
            PictureBox2.Visible = False
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form5_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub
End Class
