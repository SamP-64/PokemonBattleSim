<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonMove1 = New System.Windows.Forms.Button()
        Me.ButtonMove4 = New System.Windows.Forms.Button()
        Me.ButtonMove3 = New System.Windows.Forms.Button()
        Me.ButtonMove2 = New System.Windows.Forms.Button()
        Me.LabelHP = New System.Windows.Forms.Label()
        Me.LabelTargetHP = New System.Windows.Forms.Label()
        Me.LabelMyName = New System.Windows.Forms.Label()
        Me.LabelTargetName = New System.Windows.Forms.Label()
        Me.LabelBattleText = New System.Windows.Forms.Label()
        Me.ButtonSwitchPokemon = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelTargetStatus = New System.Windows.Forms.Label()
        Me.LabelMyStatus = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxPlayer = New System.Windows.Forms.PictureBox()
        Me.PictureBoxOpponent = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxOpponent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonMove1
        '
        Me.ButtonMove1.Location = New System.Drawing.Point(260, 363)
        Me.ButtonMove1.Name = "ButtonMove1"
        Me.ButtonMove1.Size = New System.Drawing.Size(105, 92)
        Me.ButtonMove1.TabIndex = 0
        Me.ButtonMove1.Text = "Button1"
        Me.ButtonMove1.UseVisualStyleBackColor = True
        '
        'ButtonMove4
        '
        Me.ButtonMove4.Location = New System.Drawing.Point(382, 473)
        Me.ButtonMove4.Name = "ButtonMove4"
        Me.ButtonMove4.Size = New System.Drawing.Size(105, 92)
        Me.ButtonMove4.TabIndex = 1
        Me.ButtonMove4.Text = "Button1"
        Me.ButtonMove4.UseVisualStyleBackColor = True
        '
        'ButtonMove3
        '
        Me.ButtonMove3.Location = New System.Drawing.Point(260, 473)
        Me.ButtonMove3.Name = "ButtonMove3"
        Me.ButtonMove3.Size = New System.Drawing.Size(105, 92)
        Me.ButtonMove3.TabIndex = 2
        Me.ButtonMove3.Text = "Button1"
        Me.ButtonMove3.UseVisualStyleBackColor = True
        '
        'ButtonMove2
        '
        Me.ButtonMove2.Location = New System.Drawing.Point(382, 363)
        Me.ButtonMove2.Name = "ButtonMove2"
        Me.ButtonMove2.Size = New System.Drawing.Size(105, 92)
        Me.ButtonMove2.TabIndex = 3
        Me.ButtonMove2.Text = "Button1"
        Me.ButtonMove2.UseVisualStyleBackColor = True
        '
        'LabelHP
        '
        Me.LabelHP.AutoSize = True
        Me.LabelHP.Location = New System.Drawing.Point(740, 303)
        Me.LabelHP.Name = "LabelHP"
        Me.LabelHP.Size = New System.Drawing.Size(62, 17)
        Me.LabelHP.TabIndex = 4
        Me.LabelHP.Text = "LabelHP"
        '
        'LabelTargetHP
        '
        Me.LabelTargetHP.AutoSize = True
        Me.LabelTargetHP.Location = New System.Drawing.Point(421, 63)
        Me.LabelTargetHP.Name = "LabelTargetHP"
        Me.LabelTargetHP.Size = New System.Drawing.Size(104, 17)
        Me.LabelTargetHP.TabIndex = 5
        Me.LabelTargetHP.Text = "LabelTargetHP"
        '
        'LabelMyName
        '
        Me.LabelMyName.AutoSize = True
        Me.LabelMyName.Location = New System.Drawing.Point(654, 303)
        Me.LabelMyName.Name = "LabelMyName"
        Me.LabelMyName.Size = New System.Drawing.Size(63, 17)
        Me.LabelMyName.TabIndex = 6
        Me.LabelMyName.Text = "MyName"
        '
        'LabelTargetName
        '
        Me.LabelTargetName.AutoSize = True
        Me.LabelTargetName.Location = New System.Drawing.Point(542, 63)
        Me.LabelTargetName.Name = "LabelTargetName"
        Me.LabelTargetName.Size = New System.Drawing.Size(87, 17)
        Me.LabelTargetName.TabIndex = 7
        Me.LabelTargetName.Text = "TargetName"
        '
        'LabelBattleText
        '
        Me.LabelBattleText.AutoSize = True
        Me.LabelBattleText.Location = New System.Drawing.Point(515, 376)
        Me.LabelBattleText.Name = "LabelBattleText"
        Me.LabelBattleText.Size = New System.Drawing.Size(71, 17)
        Me.LabelBattleText.TabIndex = 8
        Me.LabelBattleText.Text = "BattleText"
        '
        'ButtonSwitchPokemon
        '
        Me.ButtonSwitchPokemon.Location = New System.Drawing.Point(566, 473)
        Me.ButtonSwitchPokemon.Name = "ButtonSwitchPokemon"
        Me.ButtonSwitchPokemon.Size = New System.Drawing.Size(121, 92)
        Me.ButtonSwitchPokemon.TabIndex = 9
        Me.ButtonSwitchPokemon.Text = "Pokemon"
        Me.ButtonSwitchPokemon.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 30
        '
        'LabelTargetStatus
        '
        Me.LabelTargetStatus.AutoSize = True
        Me.LabelTargetStatus.Location = New System.Drawing.Point(654, 62)
        Me.LabelTargetStatus.Name = "LabelTargetStatus"
        Me.LabelTargetStatus.Size = New System.Drawing.Size(0, 17)
        Me.LabelTargetStatus.TabIndex = 10
        '
        'LabelMyStatus
        '
        Me.LabelMyStatus.AutoSize = True
        Me.LabelMyStatus.Location = New System.Drawing.Point(448, 256)
        Me.LabelMyStatus.Name = "LabelMyStatus"
        Me.LabelMyStatus.Size = New System.Drawing.Size(0, 17)
        Me.LabelMyStatus.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PokemonBattleSim.My.Resources.Resources.Battle_Scene1
        Me.PictureBox1.Location = New System.Drawing.Point(229, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(615, 341)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxPlayer
        '
        Me.PictureBoxPlayer.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxPlayer.Location = New System.Drawing.Point(300, 165)
        Me.PictureBoxPlayer.Name = "PictureBoxPlayer"
        Me.PictureBoxPlayer.Size = New System.Drawing.Size(211, 173)
        Me.PictureBoxPlayer.TabIndex = 12
        Me.PictureBoxPlayer.TabStop = False
        '
        'PictureBoxOpponent
        '
        Me.PictureBoxOpponent.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxOpponent.Location = New System.Drawing.Point(610, 62)
        Me.PictureBoxOpponent.Name = "PictureBoxOpponent"
        Me.PictureBoxOpponent.Size = New System.Drawing.Size(211, 173)
        Me.PictureBoxOpponent.TabIndex = 14
        Me.PictureBoxOpponent.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 630)
        Me.Controls.Add(Me.PictureBoxOpponent)
        Me.Controls.Add(Me.PictureBoxPlayer)
        Me.Controls.Add(Me.LabelMyStatus)
        Me.Controls.Add(Me.LabelTargetStatus)
        Me.Controls.Add(Me.ButtonSwitchPokemon)
        Me.Controls.Add(Me.LabelBattleText)
        Me.Controls.Add(Me.LabelTargetName)
        Me.Controls.Add(Me.LabelMyName)
        Me.Controls.Add(Me.LabelTargetHP)
        Me.Controls.Add(Me.LabelHP)
        Me.Controls.Add(Me.ButtonMove2)
        Me.Controls.Add(Me.ButtonMove3)
        Me.Controls.Add(Me.ButtonMove4)
        Me.Controls.Add(Me.ButtonMove1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxOpponent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonMove1 As Button
    Friend WithEvents ButtonMove4 As Button
    Friend WithEvents ButtonMove3 As Button
    Friend WithEvents ButtonMove2 As Button
    Friend WithEvents LabelHP As Label
    Friend WithEvents LabelTargetHP As Label
    Friend WithEvents LabelMyName As Label
    Friend WithEvents LabelTargetName As Label
    Friend WithEvents LabelBattleText As Label
    Friend WithEvents ButtonSwitchPokemon As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LabelTargetStatus As Label
    Friend WithEvents LabelMyStatus As Label
    Friend WithEvents PictureBoxPlayer As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxOpponent As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
