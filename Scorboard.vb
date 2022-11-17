Public Class Scorboard
    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        'displays about box
        AboutBox1.Visible = True
    End Sub

    Private Sub CreateATeamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateATeamToolStripMenuItem.Click

        'displays team creation page
        Me.Hide()
        CreateATeam.Visible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        'closes all forms on exit click
        closeProgram()
        Me.Close()
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PlayerSelect.SelectedIndexChanged

        'clears textbox when new name is selected
        ScoreInput.Clear()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles ScoreInput.TextChanged



        'lines 33 to 40 checks to see if textbox equals a number and if it does the number is that value is assigned to a parallel array
        If IsNumeric(ScoreInput.Text) = True Then

            If PlayerSelect.SelectedIndex >= 0 Then

                Playerscore(PlayerSelect.SelectedIndex) = CInt(ScoreInput.Text)
                lstScores.Items(PlayerSelect.SelectedIndex) = Playerscore(PlayerSelect.SelectedIndex)

            End If


            'if the textbox input is not a number or a error message is shown and textbox is cleared 
        ElseIf IsNumeric(ScoreInput.Text) = False And ScoreInput.Text <> "" Then

            MessageBox.Show("   You must enter a number.")
            ScoreInput.Text = ""
            lstScores.Items(PlayerSelect.SelectedIndex) = 0


            'if textbox is blank resets selected name to 0 points
        ElseIf ScoreInput.Text = "" Then
            lstScores.Items(PlayerSelect.SelectedIndex) = 0

        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click


        Dim hold As Integer = lstScores.Items.Count
        lstScores.Items.Clear()
        ScoreInput.Clear()
        MaxIndex = CInt(FrmScoreboard.lstPlayers.Items.Count)
        For IntCount = 0 To MaxIndex
            Playerscore(IntCount) = 0

            FrmScoreboard.lstScores.Items.Add(Playerscore(IntCount))

        Next
    End Sub
End Class
