namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    private bool _player1 = true;
    private int _player1Score = 0;
    private int _player2Score = 0;
    public string Play(int die1, int die2)
    {
        var score = die1 + die2;

        if (_player1)
        {
            _player1 = false;
            _player1Score += score;
            return $"¡Jugador 1 está en la casilla {_player1Score}!";
        }
        _player1 = true;
        _player2Score += score;
        return $"¡Jugador 2 está en la casilla {_player2Score}!";
    }
}