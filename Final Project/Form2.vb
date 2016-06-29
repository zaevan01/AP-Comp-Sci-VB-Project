Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load

        'providing instruction for the user
        MsgBox("Choose your character")
    End Sub

    'the following lines of code translate the player's character to a numeric value for easer processing of data
    Private Sub btnIronMan_Click(sender As Object, e As EventArgs) Handles btnIronMan.Click

        'brings the next form to the front, moves the playerCharacter variable to the next form, closes the current form
        Form3.playerCharacter = 1
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnDeadPool_Click(sender As Object, e As EventArgs) Handles btnDeadPool.Click

        'brings the next form to the front, moves the playerCharacter variable to the next form, closes the current form
        Form3.playerCharacter = 2
        Form3.Show()
        Me.Hide()
    End Sub
    Private Sub btnGambit_Click(sender As Object, e As EventArgs) Handles btnGambit.Click

        'brings the next form to the front, moves the playerCharacter variable to the next form, closes the current form
        Form3.playerCharacter = 3
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnLukeCage_Click(sender As Object, e As EventArgs) Handles btnLukeCage.Click

        'brings the next form to the front, moves the playerCharacter variable to the next form, closes the current form
        Form3.playerCharacter = 4
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub btnAntMan_Click(sender As Object, e As EventArgs) Handles btnAntMan.Click

        'brings the next form to the front, moves the playerCharacter variable to the next form, closes the current form
        Form3.playerCharacter = 5
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub
End Class