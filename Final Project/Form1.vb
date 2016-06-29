Public Class Form1

    'dimension global variables for various tasks

    'Intro sequence variable
    Dim introTick As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Create startup intro program to instruct users on what to do
        pctIntro.Image = My.Resources.professorOak
        introTick = 0
        rtxtIntro.Text = ("Hello! And welcome to American President Battle Arena.")
    End Sub
    Private Sub btnAdvance_Click(sender As Object, e As EventArgs) Handles btnAdvance.Click
        introTick = introTick + 1

        'advance intro prompts
        If introTick = 1 Then
            rtxtIntro.Text = ("My name is professor Oak and I will be your guide.")
        End If
        If introTick = 2 Then
            rtxtIntro.Text = ("You are about to embark on an incredible journey; One which only the strong can survive.")
        End If
        If introTick = 3 Then
            rtxtIntro.Text = ("You will be facing some of the greatest American Presidents as a marvel super hero of your choosing.")
        End If
        If introTick = 4 Then
            rtxtIntro.Text = ("Now, let us begin.")
        End If
        If introTick = 5 Then

            'opens the player selection form, hides the current form
            Form2.Show()
            Me.Hide()
        End If
    End Sub
End Class