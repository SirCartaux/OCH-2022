Public Class ChannelButton
    Public selected As Boolean = False
    Public motherform As MainForm
    Public id As Integer = 0

    Public Sub ChangeButtonText(text As String)
        Label1.Text = text
    End Sub

    Private Sub Button_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, PictureBox1.MouseEnter
        If selected = False Then
            Label1.BackColor = Color.FromArgb(40, 40, 40)
            PictureBox1.BackColor = Color.FromArgb(40, 40, 40)
            Label1.ForeColor = Color.White
        End If
    End Sub
    Private Sub Button_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave, PictureBox1.MouseLeave
        If selected = False Then
            Label1.BackColor = Color.FromArgb(30, 30, 30)
            PictureBox1.BackColor = Color.FromArgb(30, 30, 30)
            Label1.ForeColor = Color.FromArgb(180, 180, 180)
        End If
    End Sub
    Private Sub Button_MouseDown(sender As Object, e As EventArgs) Handles Label1.MouseDown, PictureBox1.MouseDown
        If selected = False Then
            Label1.BackColor = Color.FromArgb(50, 50, 50)
            PictureBox1.BackColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub
    Private Sub Button_MouseUp(sender As Object, e As EventArgs) Handles Label1.MouseUp, PictureBox1.MouseUp
        If selected = False Then
            motherform.unselectAllChannels()
            selected = True
            Label1.BackColor = Color.FromArgb(60, 60, 60)
            PictureBox1.BackColor = Color.FromArgb(60, 60, 60)
            Label1.ForeColor = Color.White
            motherform.switchChannel(id)
        End If
    End Sub
End Class
