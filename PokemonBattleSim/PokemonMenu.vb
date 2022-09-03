Imports System.Runtime.InteropServices
Imports System.Threading
Public Class PokemonMenu
    Dim start As Boolean = True
    Dim path As String = "C:\Users\Sampa\Music\BattleRevolution\Pokemon Battle Revolution Announcer Audio\"
    Public animatedSpritePath As String = "C:\Users\Sampa\Downloads\Pokemon Sprites\Animated Sprites\"


    Dim sprites As New List(Of PictureBox)
    Dim buttons As New List(Of Button)
    Dim hpLabels As New List(Of Label)
    Public Sub GetPokemon(num As Integer)
        If num = 1 Then
            Form1.myPokemon = Form1.player.pokemonlist(0)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(0)

        ElseIf num = 2 Then
            Form1.myPokemon = Form1.player.pokemonlist(1)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(1)
        ElseIf num = 3 Then
            Form1.myPokemon = Form1.player.pokemonlist(2)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(2)
        ElseIf num = 4 Then
            Form1.myPokemon = Form1.player.pokemonlist(3)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(3)
        ElseIf num = 5 Then
            Form1.myPokemon = Form1.player.pokemonlist(4)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(4)
        ElseIf num = 6 Then
            Form1.myPokemon = Form1.player.pokemonlist(5)
            Form1.player.pokemoninbattle = Form1.player.pokemonlist(5)
        End If
        SendInPokemon()
    End Sub

    Sub SendInPokemon()
        If Form1.myPokemon.fainted = False Then

            Form1.SetImageLocations()
            Form1.LoadImage(Form1.myPokemon.index, False)
            Form1.PlayCry(Form1.myPokemon.index)
            Form1.UpdateStatusLabels()
            Form1.updateLabels()
            Hide()
            Form1.Show()

            LoadImage(Form1.myPokemon.index, Form1.PictureBoxSprite)
            'Form1.SetMoves()
            Form1.SetMyBar()
            If start = True Then
                Form1.LoadBattle()
            End If

            ' Dim sentOutPokemon As String = path & "pk" & Form1.myPokemon.index & "_3.wav"

            Form1.PlayNameAudio(Form1.myPokemon.index, False, True)
            Form1.UpdateBattleLabel("Player sent out " & Form1.player.pokemoninbattle.name, 2.5)
            Form1.LabelBattleText.Text = ""
            Form1.LabelBattleText.Refresh()



            If start = False And Form1.mytakenTurn = True Then

                'Form1.opptakenTurn = False
                'Form1.AIMove()
                'Form1.EndTurnDamage()
                Form1.BattleCycle(1)
            End If
            start = False
            Form1.mytakenTurn = True

        End If
    End Sub

    Private Sub PokemonMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.PlayBackgroundMusic()
        Form1.UpdateStats()
        setMenu()
        UpdateMenu()
    End Sub
    Public Sub UpdateMenu()
        Dim count = 5
        HpBars.Clear()
        For Each label As Label In hpLabels
            label.Text = Form1.player.pokemonlist(count).currentHp
            SetHealthBar(buttons(count), count)
            count = count - 1
        Next

    End Sub
    Public Sub setMenu()
        Dim i As Integer = 5

        For Each button As Button In Controls.OfType(Of Button)


            '  SetSprite(button, i)


            '   button.Text = Form1.player.pokemonlist(i).name & " " & Form1.player.pokemonlist(i).currentHp & " / " & Form1.player.pokemonlist(i).HPstat & "  " & Form1.player.pokemonlist(i).status
            button.Text = Nothing

            If Form1.player.pokemonlist(i).currentHp = 0 Then
                '  button.BackColor = Color.Black
            End If



            i = i - 1
        Next

        With ButtonPokemon1
            .Left = 10
            .Top = 19
            .Width = 174
            .Height = 70
            SetButtons(ButtonPokemon1)
        End With
        With ButtonPokemon3
            .Left = 10
            .Top = 86
            .Width = 173
            .Height = 70
            SetButtons(ButtonPokemon3)
        End With
        With ButtonPokemon5
            .Left = 10
            .Top = 153
            .Width = 173
            .Height = 70
            SetButtons(ButtonPokemon5)
        End With
        With ButtonPokemon2
            .Left = 187
            .Top = 30
            .Width = 173
            .Height = 70
            SetButtons(ButtonPokemon2)
        End With
        With ButtonPokemon4
            .Left = 187
            .Top = 97
            .Width = 173
            .Height = 70
            SetButtons(ButtonPokemon4)
        End With
        With ButtonPokemon6
            .Left = 187
            .Top = 164
            .Width = 173
            .Height = 70
            SetButtons(ButtonPokemon6)
        End With

        storeControls()


        For j = 5 To 0 Step -1

            SetSprite(j)
            SetLabels(j)
        Next

    End Sub
#Region "Buttons"
    Private Sub ButtonPokemon1_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon1.MouseEnter
        ButtonPokemon1.BackgroundImage = My.Resources.First_Selected
    End Sub
    Private Sub ButtonPokemon1_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon1.MouseLeave
        ButtonPokemon1.BackgroundImage = HpBars(5)

    End Sub

    Private Sub ButtonPokemon2_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon2.MouseEnter
        ButtonPokemon2.BackgroundImage = My.Resources.Empty_Selected
        With ButtonPokemon2
            .Left = 186
            .Width = 176
        End With
    End Sub
    Private Sub ButtonPokemon2_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon2.MouseLeave
        ButtonPokemon2.BackgroundImage = HpBars(4)
        With ButtonPokemon2
            .Left = 187
            .Width = 173
        End With
    End Sub
    Private Sub ButtonPokemon3_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon3.MouseEnter
        ButtonPokemon3.BackgroundImage = My.Resources.Empty_Selected
        With ButtonPokemon3
            .Left = .Left - 1
            .Width = .Width + 3
        End With
    End Sub
    Private Sub ButtonPokemon3_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon3.MouseLeave
        ButtonPokemon3.BackgroundImage = HpBars(3)
        With ButtonPokemon3
            .Left = .Left + 1
            .Width = .Width - 3
        End With
    End Sub
    Private Sub ButtonPokemon4_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon4.MouseEnter
        ButtonPokemon4.BackgroundImage = My.Resources.Empty_Selected
        With ButtonPokemon4
            .Left = .Left - 1
            .Width = .Width + 3
        End With
    End Sub
    Private Sub ButtonPokemon4_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon4.MouseLeave
        ButtonPokemon4.BackgroundImage = HpBars(2)
        With ButtonPokemon4
            .Left = .Left + 1
            .Width = .Width - 3
        End With
    End Sub
    Private Sub ButtonPokemon5_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon5.MouseEnter
        ButtonPokemon5.BackgroundImage = My.Resources.Empty_Selected
        With ButtonPokemon5
            .Left = .Left - 1
            .Width = .Width + 3
        End With
    End Sub
    Private Sub ButtonPokemon5_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon5.MouseLeave
        ButtonPokemon5.BackgroundImage = HpBars(1)
        With ButtonPokemon5
            .Left = .Left + 1
            .Width = .Width - 3
        End With
    End Sub
    Private Sub ButtonPokemon6_MouseEnter(sender As Object, e As EventArgs) Handles ButtonPokemon6.MouseEnter
        ButtonPokemon6.BackgroundImage = My.Resources.Empty_Selected
        With ButtonPokemon6
            .Left = .Left - 1
            .Width = .Width + 3
        End With
    End Sub
    Private Sub ButtonPokemon6_MouseExit(sender As Object, e As EventArgs) Handles ButtonPokemon6.MouseLeave
        ButtonPokemon6.BackgroundImage = HpBars(0)
        With ButtonPokemon6
            .Left = .Left + 1
            .Width = .Width - 3
        End With
    End Sub
    Private Sub ButtonPokemon1_Click(sender As Object, e As EventArgs) Handles ButtonPokemon1.Click

        GetPokemon(1)
    End Sub
    Private Sub ButtonPokemon2_Click(sender As Object, e As EventArgs) Handles ButtonPokemon2.Click
        GetPokemon(2)
    End Sub
    Private Sub ButtonPokemon3_Click(sender As Object, e As EventArgs) Handles ButtonPokemon3.Click
        GetPokemon(3)
    End Sub
    Private Sub ButtonPokemon4_Click(sender As Object, e As EventArgs) Handles ButtonPokemon4.Click
        GetPokemon(4)
    End Sub
    Private Sub ButtonPokemon5_Click(sender As Object, e As EventArgs) Handles ButtonPokemon5.Click
        GetPokemon(5)
    End Sub
    Private Sub ButtonPokemon6_Click(sender As Object, e As EventArgs) Handles ButtonPokemon6.Click
        GetPokemon(6)
    End Sub
#End Region
    Sub SetButtons(button As Button)
        With PictureBox1
            .SendToBack()
        End With

        With button
            .Parent = PictureBox1
            .BackColor = Color.Transparent
            .FlatAppearance.BorderSize = 0
            .FlatAppearance.MouseDownBackColor = Color.Transparent
            .FlatAppearance.MouseOverBackColor = Color.Transparent
            .FlatStyle = FlatStyle.Flat
            .BackgroundImageLayout = ImageLayout.Zoom


        End With
    End Sub
    Sub SetSprite(count As Integer)
        Dim sprite As New PictureBox()
        Me.Controls.Add(sprite)

        With sprite
            .BringToFront()
            .SizeMode = PictureBoxSizeMode.Zoom
            .Parent = buttons(count)
            .Width = 50
            .Height = 50
            .BackColor = Color.Transparent



            .Left = 15
            .Top = 2
        End With
        If count = 0 Then
            AddHandlers(sprite, ButtonPokemon1)
        ElseIf count = 1 Then
            AddHandlers(sprite, ButtonPokemon2)
        ElseIf count = 2 Then
            AddHandlers(sprite, ButtonPokemon3)
        ElseIf count = 3 Then
            AddHandlers(sprite, ButtonPokemon4)
        ElseIf count = 4 Then
            AddHandlers(sprite, ButtonPokemon5)
        ElseIf count = 5 Then
            AddHandlers(sprite, ButtonPokemon6)
        End If


        LoadImage(Form1.player.pokemonlist(count).index, sprite)

    End Sub
    Sub AddHandlers(sprite As PictureBox, button As Button)
        AddHandler sprite.MouseClick, AddressOf button.PerformClick
        'AddHandler sprite.MouseEnter, AddressOf button.M
        'AddHandler sprite.MouseLeave, AddressOf button.MouseLeave
    End Sub
    Sub SetLabels(count As Integer)
        Dim labelName As New Label()
        Me.Controls.Add(labelName)

        With labelName
            .BringToFront()
            .Parent = buttons(count)
            .BackColor = Color.Transparent
            .Left = 60
            .Top = 6
            .Font = New Font("Pokémon DP Pro", 18)
            .Text = Form1.player.pokemonlist(count).name
            .ForeColor = Color.WhiteSmoke
        End With

        Dim labelCurrentHp As New Label()
        Me.Controls.Add(labelCurrentHp)
        hpLabels.Add(labelCurrentHp)

        With labelCurrentHp
            .BringToFront()
            .Parent = buttons(count)
            .BackColor = Color.Transparent
            .Width = 40
            .Left = 82
            .ForeColor = Color.WhiteSmoke
            .Top = 40
            .Font = New Font("Pokémon DP Pro", 15)
            .Text = Form1.player.pokemonlist(count).currentHp

        End With


        Dim labelMaxHp As New Label()
        Me.Controls.Add(labelMaxHp)

        With labelMaxHp
            .BringToFront()
            .Parent = buttons(count)
            .BackColor = Color.Transparent
            .Width = 40
            .Left = 125
            .ForeColor = Color.WhiteSmoke
            .Top = 40
            .Font = New Font("Pokémon DP Pro", 15)
            .Text = Form1.player.pokemonlist(count).HPstat

        End With


    End Sub
    Public Sub LoadImage(index As String, sprite As PictureBox)

        Dim zero As String = ""
        If index.Length = 1 Then
            zero = "00"
        End If

        If index.Length = 2 Then
            zero = "0"
        End If
        sprite.Image = Image.FromFile(animatedSpritePath & zero & index & ".gif")

    End Sub
    Sub storeControls()

        buttons.Clear()
        sprites.Clear()

        sprites.Add(PokemonSprite1)
        sprites.Add(PokemonSprite2)
        sprites.Add(PictureBox4)
        sprites.Add(PictureBox5)
        sprites.Add(PictureBox6)
        sprites.Add(PictureBox7)

        buttons.Add(ButtonPokemon1)
        buttons.Add(ButtonPokemon2)
        buttons.Add(ButtonPokemon3)
        buttons.Add(ButtonPokemon4)
        buttons.Add(ButtonPokemon5)
        buttons.Add(ButtonPokemon6)


    End Sub
    Dim green As Color = My.Resources.MenuHPDarkGreen.GetPixel(1, 1)
    Dim green2 As Color = My.Resources.MenuHPLightGreen.GetPixel(1, 1)

    Dim amber As Color = My.Resources.HPAmber.GetPixel(1, 1)
    Dim red As Color = My.Resources.HPRed.GetPixel(1, 1)
    Dim black As Color = My.Resources.HPBarColour.GetPixel(1, 1)
    Dim HpBars As New List(Of Bitmap)
    Sub SetHealthBar(button As Button, count As Integer)

        Dim myHealthPercent As Integer
        Dim targetColour As Color
        Dim pokemon As Pokemon = Form1.player.pokemonlist(count)

        myHealthPercent = pokemon.currentHp / pokemon.HPstat * 100


        If myHealthPercent > 50 Then
            targetColour = green2
        ElseIf myHealthPercent >= 20 Then
            targetColour = amber
        ElseIf myHealthPercent < 20 Then
            targetColour = red
        End If


        Dim currentBarPercentage As Integer


        Dim image As Bitmap = button.BackgroundImage





        For i = 1 To image.Width - 1
            For j = 1 To image.Height - 1
                If i > 62 And i < 111 And j > 22 And j < 27 Then
                    currentBarPercentage = (i - (62)) / ((111) - (62)) * 100
                    If currentBarPercentage <= myHealthPercent Then
                        image.SetPixel(i, j, targetColour)
                    Else
                        image.SetPixel(i, j, black)
                        End If

                    End If
            Next
        Next
        button.BackgroundImage = image
        HpBars.Add(image)
    End Sub
    Function SimilarColour(pixelcolour As Color, pixelcolour2 As Color)

        Dim a As Integer = pixelcolour.A
        Dim b As Integer = pixelcolour.B
        Dim r As Integer = pixelcolour.R
        Dim g As Integer = pixelcolour.G
        Dim a2 As Integer = pixelcolour2.A
        Dim b2 As Integer = pixelcolour2.B
        Dim r2 As Integer = pixelcolour2.R
        Dim g2 As Integer = pixelcolour2.G




        Dim variance As Integer = 3  '7

        If a - variance < a2 And a2 < a + variance Then
            If b - variance < b2 And b2 < b + variance Then
                If r - variance < r2 And r2 < r + variance Then
                    If g - variance < g2 And g2 < g + variance Then
                        Return True
                    End If
                End If
            End If
        End If
        Return False
    End Function

End Class