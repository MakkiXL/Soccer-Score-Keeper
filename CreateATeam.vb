Public Class CreateATeam
    Private Sub ScoreBoardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScoreBoardToolStripMenuItem.Click
        ClearBoards()



        FrmScoreboard.lstPlayers.Items.AddRange(NameInput.Lines)
        MaxIndex = FrmScoreboard.lstPlayers.Items.Count
        NameInput.Lines.CopyTo(PlayerList, 0)

        Dim IntScore As Integer = FrmScoreboard.lstScores.Items.Count


        Do While number < MaxIndex
            FrmScoreboard.PlayerSelect.Items.Add(PlayerList(number).ToString)
            number += 1
        Loop



        MaxIndex = CInt(FrmScoreboard.lstPlayers.Items.Count)
        For IntCount = 0 To MaxIndex - 1
            Playerscore(IntCount) = 0
            If MaxIndex > IntScore Then
                FrmScoreboard.lstScores.Items.Add(Playerscore(IntCount))
            End If
        Next

        Me.Hide()
        FrmScoreboard.Visible = True


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'closes all forms
        closeProgram()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Visible = True
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'clears textbox and both boards on click
        NameInput.Text = ""
        ClearBoards()
    End Sub
End Class