Module Module1
    'used to call forms
    Public frmPrompt As New CreateATeam
    Public FrmScoreboard As New Scorboard
    'used to hold a value for various loops 
    Public IntCount As Integer

    'two arrays one for holding names the other for scorse
    Public PlayerList(52) As String
    Public Playerscore(999) As Integer


    Public number As Integer = 0

    Public MaxIndex As Integer



    'closes all windows when exit is clicked on either one
    Public Sub closeProgram()
        frmPrompt.Close()
        FrmScoreboard.Close()
    End Sub

    'clears boards
    Sub ClearBoards()
        FrmScoreboard.lstPlayers.Items.Clear()
        FrmScoreboard.lstPlayers.Items.Clear()
    End Sub

End Module
