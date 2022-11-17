<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scorboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateATeamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.lstPlayers = New System.Windows.Forms.ListBox()
        Me.lblPlayers = New System.Windows.Forms.Label()
        Me.lblScores = New System.Windows.Forms.Label()
        Me.PlayerSelect = New System.Windows.Forms.ComboBox()
        Me.ScoreInput = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayersToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ResetToolStripMenuItem.Text = "Reset Scores"
        Me.ResetToolStripMenuItem.ToolTipText = "Resets scores"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        Me.ExitToolStripMenuItem.ToolTipText = "Closes Application"
        '
        'PlayersToolStripMenuItem
        '
        Me.PlayersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateATeamToolStripMenuItem})
        Me.PlayersToolStripMenuItem.Name = "PlayersToolStripMenuItem"
        Me.PlayersToolStripMenuItem.Size = New System.Drawing.Size(69, 24)
        Me.PlayersToolStripMenuItem.Text = "Players"
        '
        'CreateATeamToolStripMenuItem
        '
        Me.CreateATeamToolStripMenuItem.Name = "CreateATeamToolStripMenuItem"
        Me.CreateATeamToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CreateATeamToolStripMenuItem.Text = "New Team"
        Me.CreateATeamToolStripMenuItem.ToolTipText = "edit players"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'lstScores
        '
        Me.lstScores.BackColor = System.Drawing.SystemColors.Window
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 16
        Me.lstScores.Location = New System.Drawing.Point(273, 116)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(120, 212)
        Me.lstScores.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.lstScores, "list of player scores")
        '
        'lstPlayers
        '
        Me.lstPlayers.FormattingEnabled = True
        Me.lstPlayers.ItemHeight = 16
        Me.lstPlayers.Location = New System.Drawing.Point(63, 116)
        Me.lstPlayers.Name = "lstPlayers"
        Me.lstPlayers.Size = New System.Drawing.Size(120, 212)
        Me.lstPlayers.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.lstPlayers, "list of players")
        '
        'lblPlayers
        '
        Me.lblPlayers.Location = New System.Drawing.Point(63, 90)
        Me.lblPlayers.Name = "lblPlayers"
        Me.lblPlayers.Size = New System.Drawing.Size(120, 23)
        Me.lblPlayers.TabIndex = 3
        Me.lblPlayers.Text = "Players"
        Me.lblPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblScores
        '
        Me.lblScores.Location = New System.Drawing.Point(273, 90)
        Me.lblScores.Name = "lblScores"
        Me.lblScores.Size = New System.Drawing.Size(120, 23)
        Me.lblScores.TabIndex = 4
        Me.lblScores.Text = "Scores"
        Me.lblScores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayerSelect
        '
        Me.PlayerSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PlayerSelect.FormattingEnabled = True
        Me.PlayerSelect.Location = New System.Drawing.Point(63, 368)
        Me.PlayerSelect.Name = "PlayerSelect"
        Me.PlayerSelect.Size = New System.Drawing.Size(120, 24)
        Me.PlayerSelect.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.PlayerSelect, "Select a player")
        '
        'ScoreInput
        '
        Me.ScoreInput.Location = New System.Drawing.Point(273, 368)
        Me.ScoreInput.Name = "ScoreInput"
        Me.ScoreInput.Size = New System.Drawing.Size(120, 22)
        Me.ScoreInput.TabIndex = 6
        Me.ScoreInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.ScoreInput, "enter player score")
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Scorboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 427)
        Me.Controls.Add(Me.ScoreInput)
        Me.Controls.Add(Me.PlayerSelect)
        Me.Controls.Add(Me.lblScores)
        Me.Controls.Add(Me.lblPlayers)
        Me.Controls.Add(Me.lstPlayers)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Scorboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Soccer Score Keeper by Malachi Barbato"
        Me.TransparencyKey = System.Drawing.SystemColors.InactiveBorder
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateATeamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lstScores As ListBox
    Friend WithEvents lstPlayers As ListBox
    Friend WithEvents lblPlayers As Label
    Friend WithEvents lblScores As Label
    Friend WithEvents PlayerSelect As ComboBox
    Friend WithEvents ScoreInput As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolTip1 As ToolTip
End Class
