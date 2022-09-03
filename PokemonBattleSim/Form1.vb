Imports System.Runtime.InteropServices
Imports System.IO


Public Class Form1
#Region "TYPES"
    Dim normal As New MoveType With {
        .colour = Color.Gray,
        .index = 0,
        .notVeryEffective = {12, 16},
        .superEffective = {},
        .noEffect = {13},
        .name = "Normal"
        }
    Dim fire As New MoveType With {
        .colour = Color.Red,
        .index = 1,
        .notVeryEffective = {1, 2, 12, 14},
        .superEffective = {3, 5, 11, 16},
        .noEffect = {18},
        .name = "Fire"
    }
    Dim water As New MoveType With {
        .colour = Color.CornflowerBlue,
        .index = 2,
        .notVeryEffective = {2, 3, 14},
        .superEffective = {1, 8, 12},
        .noEffect = {18},
        .name = "Water"
        }
    Dim grass As New MoveType With {
        .colour = Color.Green,
        .index = 3,
        .notVeryEffective = {1, 3, 7, 9, 11, 14, 16},
        .superEffective = {2, 8, 12},
        .noEffect = {18},
        .name = "Grass"
        }
    Dim electric As New MoveType With {
        .colour = Color.Yellow,
        .index = 4,
        .notVeryEffective = {3, 4, 14},
        .superEffective = {2, 9},
        .noEffect = {8},
        .name = "Electric"
        }
    Dim ice As New MoveType With {
        .colour = Color.LightCyan,
        .index = 5,
        .notVeryEffective = {1, 2, 5, 16},
        .superEffective = {3, 8, 9, 14},
        .noEffect = {18},
        .name = "Ice"
        }
    Dim fighting As New MoveType With {
        .colour = Color.Firebrick,
        .index = 6,
        .notVeryEffective = {7, 9, 10, 11, 17},
        .superEffective = {0, 5, 12, 15, 16},
        .noEffect = {13},
        .name = "Fighting"
        }
    Dim poison As New MoveType With {
        .colour = Color.Purple,
        .index = 7,
        .notVeryEffective = {7, 8, 12, 13},
        .superEffective = {3, 17},
        .noEffect = {16},
        .name = "Poison"
        }
    Dim Ground As New MoveType With {
        .colour = Color.SandyBrown,
        .index = 8,
        .notVeryEffective = {3, 11},
        .superEffective = {1, 4, 7, 12, 16},
        .noEffect = {18},
        .name = "Ground"
        }
    Dim Flying As New MoveType With {
        .colour = Color.LightBlue,
        .index = 9,
        .notVeryEffective = {4, 12, 16},
        .superEffective = {3, 6, 11},
        .noEffect = {18},
        .name = "Flying"
        }
    Dim psychic As New MoveType With {
        .colour = Color.Pink,
        .index = 10,
        .notVeryEffective = {10, 16},
        .superEffective = {6, 7},
        .noEffect = {15},
        .name = "Psychic"
        }
    Dim Bug As New MoveType With {
        .colour = Color.YellowGreen,
        .index = 11,
        .notVeryEffective = {1, 6, 7, 9, 13, 16, 17},
        .superEffective = {3, 10, 15},
        .noEffect = {18},
        .name = "Electric"
        }
    Dim rock As New MoveType With {
        .colour = Color.BurlyWood,
        .index = 12,
        .notVeryEffective = {6, 8, 16},
        .superEffective = {1, 5, 9, 11},
        .noEffect = {18},
        .name = "rock"
        }
    Dim ghost As New MoveType With {
        .colour = Color.Indigo,
        .index = 13,
        .notVeryEffective = {15, 16},
        .superEffective = {10, 13},
        .noEffect = {0},
        .name = "Ghost"
        }
    Dim Dragon As New MoveType With {
        .colour = Color.Blue,
        .index = 14,
        .notVeryEffective = {16},
        .superEffective = {14},
        .noEffect = {17},
        .name = "Dragon"
        }
    Dim Dark As New MoveType With {
        .colour = Color.DarkSlateGray,
        .index = 15,
        .notVeryEffective = {6, 15, 16, 17},
        .superEffective = {10, 13},
        .noEffect = {18},
        .name = "Dark"
        }
    Dim Steel As New MoveType With {
        .colour = Color.Gray,
        .index = 16,
        .notVeryEffective = {1, 2, 16},
        .superEffective = {5, 12, 17},
        .noEffect = {18},
        .name = "Steel"
        }
    Dim Fairy As New MoveType With {
        .colour = Color.LightPink,
        .index = 17,
        .notVeryEffective = {1, 7, 16},
        .superEffective = {6, 14, 15},
        .noEffect = {18},
        .name = "Fairy"
        }
    Dim null As New MoveType With {
        .colour = Color.LightPink,
        .index = 20,
        .notVeryEffective = {},
        .superEffective = {},
        .name = "Null"
        }
#End Region
#Region "Moves"
    Public flamethrower As New PokemonMove With {
        .name = "Flamethrower",
        .damaging = True,
        .Physical = False,
        .power = 90,
        .accuracy = 100,
        .type = fire
        }
    Dim icepunch As New PokemonMove With {
        .name = "Ice Punch",
        .damaging = True,
        .Physical = True,
        .power = 75,
        .accuracy = 100,
        .type = ice
        }
    Dim firepunch As New PokemonMove With {
        .name = "Fire Punch",
        .damaging = True,
        .Physical = True,
        .power = 75,
        .accuracy = 100,
        .type = fire
        }
    Dim thunderpunch As New PokemonMove With {
        .name = "Thunder Punch",
        .damaging = True,
        .Physical = True,
        .power = 75,
        .accuracy = 100,
        .type = electric
        }
    Dim thunderfang As New PokemonMove With {
        .name = "Thunder Fang",
        .damaging = True,
        .Physical = True,
        .power = 65,
        .accuracy = 95,
        .type = electric
        }
    Dim icefang As New PokemonMove With {
        .name = "Ice Fang",
        .damaging = True,
        .Physical = True,
        .power = 65,
        .accuracy = 95,
        .type = ice
        }
    Dim firefang As New PokemonMove With {
        .name = "Fire Fang",
        .damaging = True,
        .Physical = True,
        .power = 65,
        .accuracy = 95,
        .type = fire
        }
    Dim crunch As New PokemonMove With {
        .name = "Crunch",
        .damaging = True,
        .Physical = True,
        .power = 80,
        .accuracy = 100,
        .type = Dark
        }
    Dim shadowball As New PokemonMove With {
        .name = "Shadow Ball",
        .damaging = True,
        .Physical = False,
        .power = 80,
        .accuracy = 100,
        .type = ghost
        }
    Dim surf As New PokemonMove With {
        .name = "Surf",
        .damaging = True,
        .Physical = False,
        .power = 95,
        .accuracy = 100,
        .type = water
        }
    Dim icebeam As New PokemonMove With {
        .name = "Ice Beam",
        .damaging = True,
        .Physical = False,
        .power = 90,
        .accuracy = 100,
        .type = ice
        }
    Dim earthpower As New PokemonMove With {
        .name = "Earth Power",
        .damaging = True,
        .Physical = False,
        .power = 90,
        .accuracy = 100,
        .type = Ground
        }
    Dim thunderbolt As New PokemonMove With {
        .name = "Thunderbolt",
        .damaging = True,
        .Physical = False,
        .power = 90,
        .accuracy = 100,
        .type = electric
        }
    Dim xscissor As New PokemonMove With {
        .name = "X-Scissor",
        .damaging = True,
        .Physical = True,
        .power = 80,
        .accuracy = 100,
        .type = Bug
        }
    Dim earthquake As New PokemonMove With {
        .name = "Earthquake",
        .damaging = True,
        .Physical = True,
        .power = 100,
        .accuracy = 100,
        .type = Ground
        }
    Dim flareblitz As New PokemonMove With {
        .name = "Flare Blitz",
        .damaging = True,
        .Physical = True,
        .power = 120,
        .accuracy = 100,
        .type = fire
        }
    Dim psychicmove As New PokemonMove With {
        .name = "Psychic",
        .damaging = True,
        .Physical = False,
        .power = 90,
        .accuracy = 100,
        .type = psychic
        }
    Dim thunder As New PokemonMove With {
        .name = "Thunder",
        .damaging = True,
        .Physical = False,
        .power = 110,
        .accuracy = 70,
        .type = electric
        }
    Dim payback As New PokemonMove With {
        .name = "Payback",
        .damaging = True,
        .Physical = True,
        .power = 50,
        .accuracy = 100,
        .type = Dark
        }
    Dim signalbeam As New PokemonMove With {
        .name = "Signal Beam",
        .damaging = True,
        .Physical = False,
        .power = 75,
        .accuracy = 100,
        .type = Bug
        }
    Dim Outrage As New PokemonMove With {
        .name = "Outrage",
        .damaging = True,
        .Physical = True,
        .power = 120,
        .accuracy = 100,
        .type = Dragon
        }
    Dim ironhead As New PokemonMove With {
        .name = "Iron Head",
        .damaging = True,
        .Physical = True,
        .power = 80,
        .accuracy = 100,
        .type = Steel
        }
    Dim stoneedge As New PokemonMove With {
        .name = "Stone Edge",
        .damaging = True,
        .Physical = True,
        .power = 100,
        .accuracy = 80,
        .type = rock
        }
    Dim bulletpunch As New PokemonMove With {
        .name = "Bullet Punch",
        .damaging = True,
        .Physical = True,
        .power = 40,
        .accuracy = 100,
        .type = Steel,
        .priority = 1
        }
    Dim iceshard As New PokemonMove With {
        .name = "Ice Shard",
        .damaging = True,
        .Physical = True,
        .power = 40,
        .accuracy = 100,
        .type = ice,
        .priority = 1
        }
    Dim roost As New PokemonMove With {
        .name = "Roost",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = Flying
        }
    Dim swordsdance As New PokemonMove With {
        .name = "Swords Dance",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = normal
        }
    Dim closecombat As New PokemonMove With {
        .name = "Close Combat",
        .damaging = True,
        .Physical = True,
        .power = 120,
        .accuracy = 100,
        .type = fighting
        }
    Dim thunderwave As New PokemonMove With {
        .name = "Thunder Wave",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 90,
        .type = electric
        }
    Dim willowisp As New PokemonMove With {
        .name = "Will-O-Wisp",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 85,
        .type = fire
        }
    Dim sleeppowder As New PokemonMove With {
        .name = "Sleep Powder",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 75,
        .type = grass
        }
    Dim triattack As New PokemonMove With {
        .name = "Tri-Attack",
        .damaging = True,
        .Physical = False,
        .power = 80,
        .accuracy = 100,
        .type = normal
        }
    Dim bravebird As New PokemonMove With {
        .name = "Brave Bird",
        .damaging = True,
        .Physical = True,
        .power = 120,
        .accuracy = 100,
        .type = Flying
        }
    Dim nightslash As New PokemonMove With {
        .name = "Night Slash",
        .damaging = True,
        .Physical = True,
        .power = 70,
        .accuracy = 100,
        .type = Dark
        }
    Dim quickattack As New PokemonMove With {
        .name = "Quick Attack",
        .damaging = True,
        .Physical = True,
        .power = 40,
        .accuracy = 100,
        .type = normal,
        .priority = 1
        }
    Dim uturn As New PokemonMove With {
        .name = "U-Turn",
        .damaging = True,
        .Physical = True,
        .power = 70,
        .accuracy = 100,
        .type = Bug
        }
    Dim raindance As New PokemonMove With {
        .name = "Rain Dance",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = water
        }
    Dim sunnyday As New PokemonMove With {
        .name = "Sunny Day",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = fire
        }
    Dim hail As New PokemonMove With {
        .name = "Hail",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = ice
        }
    Dim sandstorm As New PokemonMove With {
        .name = "Sandstorm",
        .damaging = False,
        .Physical = True,
        .power = 0,
        .accuracy = 100,
        .type = Ground
        }
#End Region
#Region "Pokemon"
    Public arcanine As New Pokemon With {
            .name = "Arcanine",
            .HP = 90,
            .AtK = 110,
            .Def = 80,
            .SpAtk = 100,
            .SpDef = 80,
            .Spe = 95,
            .type1 = fire,
            .type2 = null,
            .Moves = {flamethrower, willowisp, sunnyday, flareblitz},
            .index = 59
        }
    Public drifblim As New Pokemon With {
            .name = "Drifblim",
            .HP = 150,
            .AtK = 80,
            .Def = 44,
            .SpAtk = 90,
            .SpDef = 54,
            .Spe = 80,
            .type1 = ghost,
            .type2 = Flying,
            .Moves = {shadowball, thunder, psychicmove, payback},
            .index = 426
        }
    Public gastrodon As New Pokemon With {
            .name = "Gastrodon",
            .HP = 111,
            .AtK = 83,
            .Def = 68,
            .SpAtk = 92,
            .SpDef = 82,
            .Spe = 39,
            .type1 = water,
            .type2 = Ground,
            .Moves = {surf, sandstorm, hail, sleeppowder},
            .index = 423
        }
    Public jolteon As New Pokemon With {
            .name = "Jolteon",
            .HP = 65,
            .AtK = 65,
            .Def = 60,
            .SpAtk = 110,
            .SpDef = 95,
            .Spe = 130,
            .type1 = electric,
            .type2 = null,
            .Moves = {thunderbolt, thunderwave, shadowball, signalbeam},
            .index = 135
        }
    Public scizor As New Pokemon With {
            .name = "Scizor",
            .HP = 70,
            .AtK = 130,
            .Def = 100,
            .SpAtk = 55,
            .SpDef = 80,
            .Spe = 65,
            .type1 = Bug,
            .type2 = Steel,
            .Moves = {xscissor, bulletpunch, swordsdance, roost},
            .index = 212
        }
    Public Garchomp As New Pokemon With {
            .name = "Garchomp",
            .HP = 108,
            .AtK = 130,
            .Def = 95,
            .SpAtk = 80,
            .SpDef = 85,
            .Spe = 102,
            .type1 = Dragon,
            .type2 = Ground,
            .Moves = {earthquake, ironhead, Outrage, stoneedge},
            .index = 445
        }
    Public Gallade As New Pokemon With {
            .name = "Gallade",
            .HP = 68,
            .AtK = 125,
            .Def = 65,
            .SpAtk = 65,
            .SpDef = 115,
            .Spe = 80,
            .type1 = psychic,
            .type2 = fighting,
            .Moves = {closecombat, psychicmove, icepunch, firepunch},
            .index = 475
        }
    Public Mamoswine As New Pokemon With {
            .name = "Mamoswine",
            .HP = 110,
            .AtK = 130,
            .Def = 80,
            .SpAtk = 70,
            .SpDef = 60,
            .Spe = 80,
            .type1 = ice,
            .type2 = Ground,
            .Moves = {earthquake, icefang, iceshard, stoneedge},
            .index = 473
        }
    Public porygonz As New Pokemon With {
            .name = "Porygon-Z",
            .HP = 85,
            .AtK = 80,
            .Def = 70,
            .SpAtk = 135,
            .SpDef = 75,
            .Spe = 90,
            .type1 = normal,
            .type2 = null,
            .Moves = {triattack, icebeam, thunderbolt, psychicmove},
            .index = 474
        }
    Public weavile As New Pokemon With {
            .name = "Weavile",
            .HP = 70,
            .AtK = 120,
            .Def = 65,
            .SpAtk = 45,
            .SpDef = 85,
            .Spe = 125,
            .type1 = Dark,
            .type2 = ice,
            .Moves = {icepunch, iceshard, swordsdance, nightslash},
            .index = 461
        }
    Public lucario As New Pokemon With {
            .name = "Lucario",
            .HP = 70,
            .AtK = 110,
            .Def = 70,
            .SpAtk = 115,
            .SpDef = 70,
            .Spe = 90,
            .type1 = fighting,
            .type2 = Steel,
            .Moves = {closecombat, bulletpunch, swordsdance, firepunch},
            .index = 448
        }
    Public staraptor As New Pokemon With {
            .name = "Staraptor",
            .HP = 85,
            .AtK = 120,
            .Def = 70,
            .SpAtk = 50,
            .SpDef = 60,
            .Spe = 100,
            .type1 = normal,
            .type2 = Flying,
            .Moves = {bravebird, closecombat, quickattack, uturn},
            .index = 398
        }
#End Region

    Public opponent As New Trainer With {
        .pokemonlist = {arcanine, scizor, jolteon, Garchomp, Gallade, drifblim}
    }
    Public player As New Trainer With {
        .pokemonlist = {gastrodon, porygonz, Mamoswine, weavile, lucario, staraptor}
    }

    Public myPokemon As New Pokemon
    Public targetPokemon As New Pokemon

    Public mytakenTurn As Boolean = False
    Public opptakenTurn As Boolean = False

    Public mySwitched As Boolean = False
    Public oppSwitched As Boolean = False

    Dim superEffective As Boolean = False
    Dim damageValue As Integer
    Dim OppPokeNum As Integer = 0

    Dim weather As String
    Dim weatherCount As Integer
    Dim sandstormTypes As MoveType() = {Ground, Steel, rock}

    Dim meNeedToSwitch As Boolean = False
    Dim oppNeedToSwitch As Boolean = False

    Dim path As String = "C:\Users\Sampa\Music\BattleRevolution\Pokemon Battle Revolution Announcer Audio\"
    Public musicPath As String = "C:\Users\Sampa\Music\BattleRevolution\"
    Public frontSpritePath As String = "C:\Users\Sampa\Downloads\Pokemon Sprites\Pokemon Front Sprites\"
    Public backSpritePath As String = "C:\Users\Sampa\Downloads\Pokemon Sprites\Back Sprites\"
    Dim start As Boolean = True

    Dim media As New Media.SoundPlayer(musicPath & "Neon Colosseum.wav")
    Sub LoadBattle()

        PictureBox1.SendToBack()
        SetOpponent()
        SetMoves()
        updateLabels()

    End Sub

    Public Sub SetOpponent()

        targetPokemon = opponent.pokemonlist(0)
        opponent.pokemoninbattle = targetPokemon
        LabelTargetName.Text = targetPokemon.name
        LoadImage(targetPokemon.index, True)

    End Sub
    Dim first As Boolean = False
    Sub UpdateStats()

        If first = False Then
            For Each pokemon In player.pokemonlist
                pokemon.HPstat = pokemon.GetActualHP(pokemon.HP)
                pokemon.AtKstat = pokemon.GetActualStat(pokemon.AtK)
                pokemon.Defstat = pokemon.GetActualStat(pokemon.Def)
                pokemon.SpAtkstat = pokemon.GetActualStat(pokemon.SpAtk)
                pokemon.SpDefstat = pokemon.GetActualStat(pokemon.SpDef)
                pokemon.Spestat = pokemon.GetActualStat(pokemon.Spe)
                pokemon.currentHp = pokemon.HPstat
            Next
            For Each pokemon In opponent.pokemonlist
                pokemon.HPstat = pokemon.GetActualHP(pokemon.HP)
                pokemon.AtKstat = pokemon.GetActualStat(pokemon.AtK)
                pokemon.Defstat = pokemon.GetActualStat(pokemon.Def)
                pokemon.SpAtkstat = pokemon.GetActualStat(pokemon.SpAtk)
                pokemon.SpDefstat = pokemon.GetActualStat(pokemon.SpDef)
                pokemon.Spestat = pokemon.GetActualStat(pokemon.Spe)
                pokemon.currentHp = pokemon.HPstat
            Next

            '  targetPokemon.currentHp = targetPokemon.HPstat
            first = True
        End If
    End Sub
    Public Sub SetMoves()
        ButtonMove1.Text = myPokemon.Moves(0).name
        ButtonMove1.BackColor = myPokemon.Moves(0).type.colour
        ButtonMove2.Text = myPokemon.Moves(1).name
        ButtonMove2.BackColor = myPokemon.Moves(1).type.colour
        ButtonMove3.Text = myPokemon.Moves(2).name
        ButtonMove3.BackColor = myPokemon.Moves(2).type.colour
        ButtonMove4.Text = myPokemon.Moves(3).name
        ButtonMove4.BackColor = myPokemon.Moves(3).type.colour
    End Sub

    Public Sub Usemove(move As PokemonMove, attacker As Pokemon, defender As Pokemon)

        'If start = True Then
        '    My.Computer.Audio.Play(musicPath & "Neon Colosseum.wav", AudioPlayMode.BackgroundLoop)
        '    start = False
        'End If

        superEffective = False
        damageValue = 0

        Dim OppHp As Integer = targetPokemon.currentHp

        If attacker.fainted = False Then
            If CanAttack(attacker) = True Then
                UpdateBattleLabel(attacker.name & " used " & move.name)

                If Miss(move.accuracy, attacker) = False Then

                    If move.damaging = True Then
                        Dim damage As Integer = DamageCalc(move, attacker, defender)
                        ApplyDamage(defender, damage)
                        Dim damageDealt As Integer
                        If defender.currentHp < 0 Then
                            damageDealt = OppHp
                        Else
                            damageDealt = damage
                        End If
                        SecondaryEffect(move, attacker, defender, damageDealt)
                    ElseIf move.damaging = False Then
                        UseStatusMove(move, attacker, defender)

                    End If
                End If
            End If
        End If
        UpdateStatus()


    End Sub
    Sub SecondaryEffect(move As PokemonMove, attacker As Pokemon, defender As Pokemon, damage As Integer)
        If move.name = "Flare Blitz" Or move.name = "Brave Bird" Then
            UpdateBattleLabel(attacker.name & " was Damaged by Recoil")
            ApplyDamage(attacker, damage / 3)
        End If
    End Sub
    Sub UseStatusMove(move As PokemonMove, attacker As Pokemon, defender As Pokemon)
        If move.name = "Roost" Then
            ApplyHealth(attacker, 0.5 * attacker.HPstat)
        End If

        If move.name = "Swords Dance" Then
            ChangeStat(attacker, "Attack", 2, attacker.AtKboost)
        End If


        If move.name = "Thunder Wave" Then
            If defender.status = "" Then
                defender.status = "PAR"
                UpdateBattleLabel(defender.name & " is Paralyzed, it may be unable to move!")
            Else
                MoveFailed()

            End If
        End If

        If move.name = "Will-O-Wisp" Then
            If defender.status = "" Then
                defender.status = "BRN"

                PlayAudio("tb_855", False)
                UpdateBattleLabel(defender.name & " is burned!")
            Else
                MoveFailed()

            End If
        End If
        If move.name = "Sleep Powder" Then
            If defender.status = "" Then
                defender.status = "SLP"
                defender.sleepTurns = GenerateRandom(2, 5)
                'PlayAudio("tb_855", False)
                UpdateBattleLabel(defender.name & " fell Asleep!")
            Else
                MoveFailed()

            End If
        End If

        If move.name = "Rain Dance" Then
            If weather <> "Rain" Then
                weather = "Rain"
                weatherCount = 5
            Else
                MoveFailed()
            End If
        End If
        If move.name = "Sunny Day" Then
            If weather <> "Sun" Then
                weather = "Sun"
                weatherCount = 5
            Else
                MoveFailed()
            End If
        End If
        If move.name = "Hail" Then
            If weather <> "Hail" Then
                weather = "Hail"
                weatherCount = 5
            Else
                MoveFailed()
            End If
        End If
        If move.name = "Sandstorm" Then
            If weather <> "Sandstorm" Then
                weather = "Sandstorm"
                weatherCount = 5
            Else
                MoveFailed()
            End If
        End If
    End Sub

    Sub ChangeStat(pokemon As Pokemon, stat As String, change As Integer, currentBoost As Integer)

        If currentBoost = 6 Then
            PlayAudio("tb_930", False)
            UpdateBattleLabel(pokemon.name & "'s " & stat & " can't get any Higher!")

            Exit Sub
        ElseIf currentBoost = -6 Then
            PlayAudio("tb_932", False)
            UpdateBattleLabel(pokemon.name & "'s " & stat & " can't get any Lower!")
            Exit Sub
        End If


        Dim changedValue As Integer


        If stat = "Attack" Then
            pokemon.AtKboost = pokemon.AtKboost + change
            changedValue = pokemon.AtKboost
            If change > 0 Then
                PlayAudio("tb_906", False)
            Else
                PlayAudio("tb_920", False)
            End If
        ElseIf stat = "Defence" Then
            pokemon.Defboost = pokemon.Defboost + change
            changedValue = pokemon.Defboost
            If change > 0 Then
                PlayAudio("tb_910", False)
            Else
                PlayAudio("tb_924", False)
            End If
        ElseIf stat = "Special Attack" Then
            pokemon.SpAtkboost = pokemon.SpAtkboost + change
            changedValue = pokemon.SpAtkboost
            If change > 0 Then
                PlayAudio("tb_908", False)
            Else
                PlayAudio("tb_922", False)
            End If
        ElseIf stat = "Special Defence" Then
            pokemon.SpDefboost = pokemon.SpDefboost + change
            changedValue = pokemon.SpDefboost
            If change > 0 Then
                PlayAudio("tb_912", False)
            Else
                PlayAudio("tb_926", False)
            End If
        ElseIf stat = "Speed" Then
            pokemon.Speboost = pokemon.Speboost + change
            changedValue = pokemon.Speboost
            If change > 0 Then
                PlayAudio("tb_900", False)
            Else
                PlayAudio("tb_914", False)
            End If
        End If

        If change > 0 Then
            UpdateBattleLabel(pokemon.name & "'s " & stat & " rose!")
        ElseIf change < 0 Then
            UpdateBattleLabel(pokemon.name & "'s " & stat & " fell!")
        End If

        If changedValue > 6 Then
            If stat = "Attack" Then
                pokemon.AtKboost = 6

            ElseIf stat = "Defence" Then
                pokemon.Defboost = 6

            ElseIf stat = "Special Attack" Then
                pokemon.SpAtkboost = 6

            ElseIf stat = "Special Defence" Then
                pokemon.SpDefboost = 6

            ElseIf stat = "Speed" Then
                pokemon.Speboost = 6
            End If

        ElseIf changedValue < -6 Then
            If stat = "Attack" Then
                pokemon.AtKboost = -6

            ElseIf stat = "Defence" Then
                pokemon.Defboost = -6

            ElseIf stat = "Special Attack" Then
                pokemon.SpAtkboost = -6

            ElseIf stat = "Special Defence" Then
                pokemon.SpDefboost = -6

            ElseIf stat = "Speed" Then
                pokemon.Speboost = -6
            End If
        End If
    End Sub
    Function GenerateRandom(low As Integer, high As Integer)
        Dim randomFactor As Integer
        Dim random As New Random
        randomFactor = random.Next(low, high + 1)
        Return randomFactor
    End Function
    Function CanAttack(attacker As Pokemon)
        If attacker.status = "PAR" Then

            If GenerateRandom(1, 4) = 1 Then
                UpdateBattleLabel(attacker.name & " is paralyzed, it can't move!")
                Return False
            Else
                Return True
            End If

        ElseIf attacker.status = "SLP" Then

            If attacker.sleepTurns = 0 Then
                PlayAudio("cb_151", False)
                UpdateBattleLabel(attacker.name & " Woke Up!")
                attacker.status = ""
                UpdateStatus()
                Return True
            Else

                If GenerateRandom(1, 2) = 1 Then
                    PlayAudio("sl_420", False)
                Else

                End If
                UpdateBattleLabel(attacker.name & " Is Fast Asleep!")
                Return False
            End If
        End If
        Return True
    End Function
    Public Sub UpdateStatus()

        If myPokemon.status = "" Then
            LabelMyStatus.Text = ""
        End If

        If targetPokemon.status = "" Then
            LabelTargetStatus.Text = ""
        End If


        If myPokemon.status = "PAR" Then
            LabelMyStatus.Text = "PAR"
            LabelMyStatus.ForeColor = Color.Yellow
        End If

        If targetPokemon.status = "PAR" Then
            LabelTargetStatus.Text = "PAR"
            LabelTargetStatus.ForeColor = Color.Yellow
        End If
        If myPokemon.status = "BRN" Then
            LabelMyStatus.Text = "BRN"
            LabelMyStatus.ForeColor = Color.Red
        End If

        If targetPokemon.status = "BRN" Then
            LabelTargetStatus.Text = "BRN"
            LabelTargetStatus.ForeColor = Color.Red
        End If

        If myPokemon.status = "SLP" Then
            LabelMyStatus.Text = "SLP"
            LabelMyStatus.ForeColor = Color.Black
        End If

        If targetPokemon.status = "SLP" Then
            LabelTargetStatus.Text = "SLP"
            LabelTargetStatus.ForeColor = Color.Black
        End If

        If myPokemon.fainted = True Then
            LabelMyStatus.Text = ""
            myPokemon.status = ""
        End If
        If targetPokemon.fainted = True Then
            LabelTargetStatus.Text = ""
            targetPokemon.status = ""
        End If
    End Sub
    Sub AIMove()
        If opptakenTurn = False And oppSwitched = False Then

            Dim move As PokemonMove = targetPokemon.chosenMove
            Usemove(move, targetPokemon, myPokemon)

            opptakenTurn = True
        End If
    End Sub
    Sub MyMove(moveNo As Integer)
        If mytakenTurn = False And mySwitched = False Then
            Usemove(myPokemon.Moves(moveNo), myPokemon, targetPokemon)
            mytakenTurn = True
        End If
    End Sub
    Sub CheckFainted()

        If myPokemon.currentHp < 1 And myPokemon.fainted = False Then
            myPokemon.fainted = True
            FaintedAudio()
            UpdateBattleLabel(myPokemon.name & " Fainted!")
            meNeedToSwitch = True
        End If
        If targetPokemon.currentHp < 1 And targetPokemon.fainted = False Then
            targetPokemon.fainted = True
            FaintedAudio()
            Timer2.Enabled = True
            UpdateBattleLabel(targetPokemon.name & " Fainted!")
            oppNeedToSwitch = True
        End If

    End Sub

    Function getAIMove()


        Return opponent.pokemoninbattle.Moves(GenerateRandom(0, 3))

    End Function

    Function Miss(accuracy As Integer, attacker As Pokemon)


        If GenerateRandom(1, 100) > accuracy Then
            If GenerateRandom(1, 2) = 1 Then
                PlayAudio("tb_552", False)
            Else
                PlayAudio("tb_556", False)
            End If
            UpdateBattleLabel(attacker.name & "'s Attack Missed!")
            Return True
        Else
            Return False
        End If
    End Function
    Function DamageCalc(move As PokemonMove, attacker As Pokemon, defender As Pokemon)
        Dim attack As Integer
        Dim defence As Integer
        Dim attackMod As Decimal
        Dim defenceMod As Decimal




        If move.Physical = True Then
            attack = attacker.AtKstat
            attackMod = attacker.AtKboost
            defence = defender.Defstat
            defenceMod = defender.Defboost
        ElseIf move.Physical = False Then
            attack = attacker.SpAtkstat
            attackMod = attacker.SpAtkboost
            defence = defender.SpDefstat
            defenceMod = defender.SpDefboost
        End If

        Dim typeFactor As Decimal = typeMatchup(move, defender)
        Dim burnMultiplier As Decimal
        Dim attackMultiplier As Decimal
        Dim defenceMultiplier As Decimal
        Dim randomfactor As Integer
        Dim criticalFactor As Integer
        Dim weatherMultiplier As Decimal

        If typeFactor <> 0 Then
            burnMultiplier = IsBurned(attacker, move)
            attackMultiplier = ReturnStatMultiplier(attackMod)
            defenceMultiplier = ReturnStatMultiplier(defenceMod)
            randomfactor = GenerateRandom(85, 100)
            criticalFactor = IsCritical()
            weatherMultiplier = WeatherMultiplierCalc(attacker, move)
        End If

        Return Int((((2 * attacker.Level / 5 + 2) * attack * attackMultiplier * move.power / defence * defenceMultiplier) / 50) + 2) * Stab(attacker.type1.index, attacker.type2.index, move.type.index) * typeFactor * (randomfactor / 100) * criticalFactor * burnMultiplier * weatherMultiplier

    End Function
    Function WeatherMultiplierCalc(attacker As Pokemon, move As PokemonMove)
        If weather = "Rain" And move.type.name = "Fire" Then
            MsgBox("rain fire")
            Return 0.5
        ElseIf weather = "Rain" And move.type.name = "Water" Then
            MsgBox("Rain water")
            Return 1.5
        End If

        If weather = "Sun" And move.type.name = "Fire" Then
            MsgBox("sun fire")
            Return 1.5
        ElseIf weather = "Sun" And move.type.name = "Water" Then
            MsgBox("sun water")
            Return 0.5
        End If


        Return 1
    End Function
    Function IsCritical()

        If GenerateRandom(1, 16) = 1 Then
            UpdateBattleLabel("A Critical Hit")
            Return 2
        Else
            Return 1
        End If
    End Function
    Function Stab(type1 As Integer, type2 As Integer, movetype As Integer)

        If type1 = movetype Or type2 = movetype Then
            Return 1.5
        Else
            Return 1
        End If
    End Function
    Function typeMatchup(move As PokemonMove, defender As Pokemon)

        Dim first As Decimal
        Dim second As Decimal
        If move.type.noEffect.Contains(defender.type1.index) Then
            first = 0
        ElseIf Move.Type.notVeryEffective.Contains(defender.type1.index) Then
            first = 0.5
        ElseIf Move.Type.superEffective.Contains(defender.type1.index) Then
            first = 2
        Else
            first = 1
        End If

        If move.type.noEffect.Contains(defender.type2.index) Then
            second = 0
        ElseIf Move.Type.notVeryEffective.Contains(defender.type2.index) Then
            second = 0.5
        ElseIf Move.Type.superEffective.Contains(defender.type2.index) Then
            second = 2
        Else
            second = 1
        End If
        If (first * second) > 1 Then
            PlaySuperEffectiveAudio(move.name)
            superEffective = True
            UpdateBattleLabel("It's Super Effective!")
        ElseIf (first * second) < 1 And (first * second) <> 0 Then
            PlayNotVeryEffectiveAudio()
            UpdateBattleLabel("It's not Very Effective...")
        ElseIf (first * second) = 0 Then
            PlayNoEffectAudio()
            UpdateBattleLabel("It doesn't effect " & defender.name & "...")
        End If
        Return first * second

    End Function
    Function ReturnStatMultiplier(statMod As Integer)
        If statMod = 6 Then
            Return 4
        ElseIf statMod = 5 Then
            Return 3.5
        ElseIf statMod = 4 Then
            Return 3
        ElseIf statMod = 3 Then
            Return 2.5
        ElseIf statMod = 2 Then
            Return 2
        ElseIf statMod = 1 Then
            Return 1.5
        ElseIf statMod = 0 Then
            Return 1
        ElseIf statMod = -1 Then
            Return 2 / 3
        ElseIf statMod = -2 Then
            Return 0.5
        ElseIf statMod = -3 Then
            Return 0.4
        ElseIf statMod = -4 Then
            Return 2 / 6
        ElseIf statMod = -5 Then
            Return 2 / 7
        ElseIf statMod = -6 Then
            Return 2 / 8
        End If
        Return 1
    End Function
    Function IsBurned(attacker As Pokemon, move As PokemonMove)
        If attacker.status = "BRN" Then
            If move.Physical = True Then
                Return 0.5
            End If
        End If
        Return 1

    End Function
    Function IsFaster(mySpeed As Integer, oppSpeed As Integer, mymove As PokemonMove, aimove As PokemonMove)



        If myPokemon.status = "PAR" Then
            mySpeed = mySpeed * 0.5

        End If
        If targetPokemon.status = "PAR" Then
            oppSpeed = oppSpeed * 0.5
        End If



        If mymove.priority > aimove.priority Then
            Return True

        ElseIf mymove.priority < aimove.priority Then
            Return False
        End If

        If mySpeed > oppSpeed Then
            Return True
        ElseIf oppSpeed < mySpeed Then
            Return False
        End If
        Return False ' add speed tie later
    End Function
    Sub EndTurnDamage()

        If myPokemon.status = "BRN" Then
            UpdateBattleLabel(myPokemon.name & " was hurt by its Burn!")
            Dim burnDamage1 As Integer
            burnDamage1 = myPokemon.HPstat / 12
            ApplyDamage(myPokemon, burnDamage1)
        End If
        If targetPokemon.status = "BRN" Then
            UpdateBattleLabel(targetPokemon.name & " was hurt by its Burn!")
            Dim burnDamage2 As Integer
            burnDamage2 = targetPokemon.HPstat / 12
            ApplyDamage(targetPokemon, burnDamage2)
        End If


    End Sub
    Sub ApplyDamage(pokemon As Pokemon, damage As Integer)
        If pokemon.fainted = False Then
            pokemon.currentHp = pokemon.currentHp - damage
            If pokemon.currentHp < 0 Then
                pokemon.currentHp = 0
            End If

            updateLabels()
            CheckFainted()
        End If
    End Sub
    Sub ApplyHealth(pokemon As Pokemon, health As Integer)

        If pokemon.currentHp = pokemon.HPstat Then
            UpdateBattleLabel(pokemon.name & "'s HP is already Full!")
        Else
            pokemon.currentHp = pokemon.currentHp + health
            PlayNameAudio(pokemon.index, "2", True)
            PlayAudio("cb_170", False )
            UpdateBattleLabel(pokemon.name & " Restored it's Health!")

        End If
        If pokemon.currentHp > pokemon.HPstat Then
            pokemon.currentHp = pokemon.HPstat
        End If
        updateLabels()
    End Sub
    Sub resetmyStatBoost()
        myPokemon.AtKboost = 0
        myPokemon.Defboost = 0
        myPokemon.SpAtkboost = 0
        myPokemon.SpDefboost = 0
        myPokemon.Speboost = 0
    End Sub
    Sub resetoppStatBoost()
        targetPokemon.AtKboost = 0
        targetPokemon.Defboost = 0
        targetPokemon.SpAtkboost = 0
        targetPokemon.SpDefboost = 0
        targetPokemon.Speboost = 0
    End Sub
    Sub BattleCycle(i As Integer)
        DisableAllButtons()
        UpdateStatus()
        updateLabels()

        targetPokemon.chosenMove = getAIMove()
        If IsFaster(myPokemon.Spestat, targetPokemon.Spestat, myPokemon.Moves(i), targetPokemon.chosenMove) = True Then

            MyMove(i)
            AIMove()

        Else
            AIMove()
            MyMove(i)
        End If

        EndTurnDamage()
        EndTurnEffects()
        WeatherDamage()
        DecreaseSleep()
        SwitchChecker()
        EnableAllButtons()

    End Sub
    Sub SwitchChecker()
        If meNeedToSwitch = True Then
            meNeedToSwitch = False
            SwitchPokemon(False)
        End If
        If oppNeedToSwitch = True Then
            oppNeedToSwitch = False
            AiSwitch()
        End If
    End Sub
    Sub DecreaseSleep()
        If myPokemon.status = "SLP" Then
            myPokemon.sleepTurns = myPokemon.sleepTurns - 1
        End If
        If targetPokemon.status = "SLP" Then
            targetPokemon.sleepTurns = targetPokemon.sleepTurns - 1
        End If
    End Sub
    Sub WeatherDamage()
        If weather = "Hail" Then
            If myPokemon.type1.name <> "Ice" And myPokemon.type2.name <> "Ice" Then
                UpdateBattleLabel(myPokemon.name & " was Buffeted by the Hail!")
                ApplyDamage(myPokemon, myPokemon.HPstat / 16)
            End If
            If targetPokemon.type1.name <> "Ice" And targetPokemon.type2.name <> "Ice" Then
                UpdateBattleLabel(targetPokemon.name & " was Buffeted by the Hail!")
                ApplyDamage(targetPokemon, targetPokemon.HPstat / 16)
            End If

        ElseIf weather = "Sandstorm" Then
            Dim meImmune As Boolean = False
            Dim targetImmune As Boolean = False

            For Each type In sandstormTypes
                If myPokemon.type1.name = type.name Or myPokemon.type2.name = type.name Then


                    meImmune = True

                End If
                If targetPokemon.type1.name = type.name Or targetPokemon.type2.name = type.name Then

                    targetImmune = True

                End If
            Next
            If meImmune = False Then
                UpdateBattleLabel(myPokemon.name & " was Buffeted by the Sandstorm!")
                ApplyDamage(myPokemon, myPokemon.HPstat / 16)
            End If
            If targetImmune = False Then
                UpdateBattleLabel(targetPokemon.name & " was Buffeted by the Sandstorm!")
                ApplyDamage(targetPokemon, targetPokemon.HPstat / 16)
            End If
        End If
    End Sub
    Sub EndTurnEffects()
        If weather = "Rain" Then
            If weatherCount = 1 Then
                UpdateBattleLabel("The Rain Stopped!")
                weather = ""
            Else
                UpdateBattleLabel("The Rain Continues to fall!")
            End If
        End If
        If weather = "Sun" Then
            If weatherCount = 1 Then
                UpdateBattleLabel("The Sunlight faded!")
                weather = ""
            Else
                UpdateBattleLabel("The Sunlight is Strong!")
            End If
        End If

        If weather = "Hail" Then
            If weatherCount = 1 Then
                UpdateBattleLabel("The Hail Stopped!")
                weather = ""
            Else
                UpdateBattleLabel("Hail Continues to Fall!")
            End If
        End If


        If weather = "Sandstorm" Then
            If weatherCount = 1 Then
                UpdateBattleLabel("The Sandstorm Stopped!")
                weather = ""
            Else
                UpdateBattleLabel("The Sandstorm Rages on!")
            End If
        End If

        If weatherCount > 0 Then
            weatherCount = weatherCount - 1
        End If

    End Sub
#Region "Buttons"
    Private Sub ButtonMove1_Click(sender As Object, e As EventArgs) Handles ButtonMove1.Click
        SetNewTurn()
        myPokemon.chosenMove = myPokemon.Moves(0)
        BattleCycle(0)
    End Sub
    Private Sub ButtonMove2_Click(sender As Object, e As EventArgs) Handles ButtonMove2.Click
        SetNewTurn()
        myPokemon.chosenMove = myPokemon.Moves(0)
        BattleCycle(1)
    End Sub
    Private Sub ButtonMove3_Click(sender As Object, e As EventArgs) Handles ButtonMove3.Click
        SetNewTurn()
        myPokemon.chosenMove = myPokemon.Moves(0)
        BattleCycle(2)
    End Sub
    Private Sub ButtonMove4_Click(sender As Object, e As EventArgs) Handles ButtonMove4.Click
        SetNewTurn()
        myPokemon.chosenMove = myPokemon.Moves(0)
        BattleCycle(3)
    End Sub

    Private Sub ButtonSwitchPokemon_Click(sender As Object, e As EventArgs) Handles ButtonSwitchPokemon.Click
        SetNewTurn()
        targetPokemon.chosenMove = getAIMove()
        switchPokemon(False)

    End Sub
#End Region
    Sub SwitchPokemon(forced As Boolean)

        resetmyStatBoost()

        mySwitched = True
        If forced = True Then
            mytakenTurn = False
        ElseIf forced = False Then
            mytakenTurn = True
        End If
        ' player.pokemoninbattle = myPokemon

        Me.Hide()

        PokemonMenu.Show()
        PokemonMenu.setMenu()


    End Sub

    Sub AiSwitch()
        OppPokeNum = OppPokeNum + 1
        MsgBox("AI s2witch")
        If OppPokeNum = 6 Then
            MsgBox("You Win")
            End
        End If
        resetoppStatBoost()
        opponent.pokemoninbattle = opponent.pokemonlist(OppPokeNum)
        targetPokemon = opponent.pokemoninbattle
        UpdateBattleLabel("Opponent Sent out " & targetPokemon.name)
        LoadImage(targetPokemon.index, True)
        opptakenTurn = True
        oppSwitched = True
        updateLabels()
        UpdateStatus()
    End Sub
    Dim texty As String
    Dim count As Integer = 0
    Dim currentText As String = ""
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If count = texty.Length Then

            count = 0

            currentText = ""
            Timer1.Enabled = False
        Else
            currentText = currentText.Concat(currentText, texty(count))
            LabelBattleText.Text = currentText

            count = count + 1
        End If





    End Sub
    Sub DisableAllButtons()

        For Each button As Button In Me.Controls.OfType(Of Button)
            button.Enabled = False
        Next
    End Sub
    Sub EnableAllButtons()

        For Each button As Button In Me.Controls.OfType(Of Button)
            button.Enabled = True
        Next

    End Sub
    Public Sub SetNewTurn()
        opptakenTurn = False
        mytakenTurn = False
        oppSwitched = False
        mySwitched = False
    End Sub
    Sub UpdateBattleLabel(text As String)
        '  MsgBox("WOW")

        texty = text
        Timer1.Enabled = True
        wait(2.5)
        LabelBattleText.Text = ""
        LabelBattleText.Refresh()
    End Sub
    Sub updateLabels()
        LabelTargetHP.Text = targetPokemon.currentHp & " / " & targetPokemon.HPstat
        LabelHP.Text = myPokemon.currentHp & " / " & myPokemon.HPstat
        LabelMyName.Text = myPokemon.name
        LabelTargetName.Text = targetPokemon.name

    End Sub
    Sub wait(time)
        HoldKeyDown(99, time)
    End Sub
    Sub PlayAudio(name As String, wait As Boolean)
        Dim audio As String = path & name & ".wav"
        If wait = True Then
            My.Computer.Audio.Play(audio, AudioPlayMode.WaitToComplete)
        Else
            My.Computer.Audio.Play(audio)
        End If

    End Sub
    Sub PlayNameAudio(index As String, number As String, wait As Boolean)

        Dim zero As String = ""

        If index.Length = 1 Then
            zero = "00"
        End If

        If index.Length = 2 Then
            zero = "0"
        End If

        Dim audio As String = path & "pk" & zero & index & "_" & number & ".wav"
        If wait = True Then
            My.Computer.Audio.Play(audio, AudioPlayMode.WaitToComplete)
        Else
            My.Computer.Audio.Play(audio)
        End If

    End Sub
    Sub FaintedAudio()
        Dim randomFactor As Integer
        Dim random As New Random
        randomFactor = random.Next(1, 3)
        If superEffective = False Then
            If randomFactor = 1 Then
                PlayAudio("h1b_107", False)
            ElseIf randomFactor = 2 Then
                PlayAudio("h1b_105", False)
            End If
        Else
            If randomFactor = 1 Then
                PlayAudio("h1b_090", False)
            ElseIf randomFactor = 2 Then
                PlayAudio("h1b_080", False)
            ElseIf randomFactor = 3 Then
                PlayAudio("h1b_070", False)
            End If
        End If
    End Sub
    Sub MoveFailed()
        Dim randomFactor As Integer
        Dim random As New Random
        randomFactor = random.Next(1, 3)
        If randomFactor = 1 Then
            PlayAudio("tb_550", False)
        ElseIf randomFactor = 2 Then
            PlayAudio("tb_554", False)
        End If
        UpdateBattleLabel("But it Failed!")
    End Sub
    Sub PlaySuperEffectiveAudio(move As String)
        If move = "Flamethrower" Then
            PlayAudio("wz_053k", False)
        ElseIf move = "Surf" Then
            PlayAudio("wz_057k", False)
        Else
            Dim randomFactor As Integer
            Dim random As New Random
            randomFactor = random.Next(1, 7)
            If randomFactor = 1 Then
                PlayAudio("h1b_026", False)
            ElseIf randomFactor = 2 Then
                PlayAudio("h1b_027", False)
            ElseIf randomFactor = 3 Then
                PlayAudio("h1b_030", False)
            ElseIf randomFactor = 4 Then
                PlayAudio("tb_272", False)
            ElseIf randomFactor = 5 Then
                PlayAudio("tb_330", False)
            ElseIf randomFactor = 6 Then
                PlayAudio("tl_270", False)
            End If
        End If
    End Sub
    Sub PlayNotVeryEffectiveAudio()

        Dim randomFactor As Integer
        Dim random As New Random
        randomFactor = random.Next(1, 4)
        If randomFactor = 1 Then
            PlayAudio("tb_110", False)
        ElseIf randomFactor = 2 Then
            PlayAudio("tb_111", False)
        ElseIf randomFactor = 3 Then
            PlayAudio("tl_290", False)
        End If
    End Sub
    Sub PlayNoEffectAudio()

        Dim randomFactor As Integer
        Dim random As New Random
        randomFactor = random.Next(1, 4)
        If randomFactor = 1 Then
            PlayAudio("tb_556", False)
        ElseIf randomFactor = 2 Then
            PlayAudio("tb_550", False)
        ElseIf randomFactor = 3 Then
            PlayAudio("tb_554", False)
        ElseIf randomFactor = 4 Then
            PlayAudio("tb_030", False)
        End If
    End Sub
    Public Sub LoadImage(index As String, front As Boolean)
        If front = True Then

            Dim zero As String = ""
            If index.Length = 1 Then
                zero = "00"
            End If

            If index.Length = 2 Then
                zero = "0"
            End If

            PictureBoxOpponent.Image = Image.FromFile(frontSpritePath & zero & index & ".png")
        Else

            PictureBoxPlayer.Image = Image.FromFile(backSpritePath & index & ".png")
        End If

    End Sub

    Private Sub HoldKeyDown(key As Byte, durationInSeconds As Decimal)
        Dim targetTime As DateTime = DateTime.Now().AddSeconds(durationInSeconds)
        keybd_event(key, MapVirtualKey(key, 0), 0, 0) ' Down
        While targetTime.Subtract(DateTime.Now()).TotalSeconds > 0
            Application.DoEvents()
        End While
        keybd_event(key, MapVirtualKey(key, 0), 2, 0) ' Up


    End Sub
    Private Declare Sub keybd_event Lib "user32.dll" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)

    <DllImport("User32.dll", SetLastError:=False, CallingConvention:=CallingConvention.StdCall,
       CharSet:=CharSet.Auto)>
    Public Shared Function MapVirtualKey(ByVal uCode As UInt32, ByVal uMapType As MappingType) As UInt32
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With PictureBox1

            ' .Image = My.Resources._00_lichaam
            '.SizeMode = PictureBoxSizeMode.Zoom
        End With
        With PictureBoxPlayer
            .Parent = PictureBox1
            .Left = 50
            .Top = 130
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
        With PictureBoxOpponent
            .Parent = PictureBox1
            .Left = 270
            .Top = 30
            .SizeMode = PictureBoxSizeMode.Zoom
            .BackColor = Color.Transparent
        End With
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'PictureBoxOpponent.Top = PictureBoxOpponent.Top + 10
        'If Top > 120 Then
        '    Timer2.Enabled = False
        'End If
    End Sub
End Class

