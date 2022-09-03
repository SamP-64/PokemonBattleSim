
Public Class Pokemon
    Public name As String
    Public HP As Integer
    Public AtK As Integer
    Public Def As Integer
    Public SpAtk As Integer
    Public SpDef As Integer
    Public Spe As Integer

    Public currentHp As Integer

    Public HPstat As Integer
    Public AtKstat As Integer
    Public Defstat As Integer
    Public SpAtkstat As Integer
    Public SpDefstat As Integer
    Public Spestat As Integer

    Public AtKboost As Decimal = 0
    Public Defboost As Decimal = 0
    Public SpAtkboost As Decimal = 0
    Public SpDefboost As Decimal = 0
    Public Speboost As Decimal = 0

    Public IV As Integer = 31
    Public EV As Integer = 100
    Public Level As Integer = 50

    Public type1 As New MoveType
    Public type2 As New MoveType

    Public item As String

    Public index As Integer
    Public fainted As Boolean
    Public status As String
    Public sleepTurns As Integer
    Public confusedTurns As Integer
    Public flinched As Boolean = False
    Public poisonCount As Integer = 1


    Public Moves(3) As PokemonMove
    Public chosenMove As PokemonMove

    Public Function GetActualStat(baseStat As Integer)
        Dim stat As Integer
        stat = Math.Floor(Math.Floor((Me.IV + (2 * baseStat) + Math.Floor(Me.EV / 4)) * Me.Level / 100) + 5)
        Return stat
    End Function
    Public Function GetActualHP(baseStat As Integer)
        Dim stat As Integer
        stat = Math.Floor((Me.IV + (2 * baseStat) + Me.EV / 4) * Me.Level / 100 + Me.Level + 10)
        Return stat
    End Function

End Class
