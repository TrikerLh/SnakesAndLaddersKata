namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    private bool _player1Turn = true;
    private int _player1Score;
    private int _player2Score;
    public string Play(int die1, int die2)
    {
        var result = "";
        var score = die1 + die2;

        if (_player1Turn)
        {
            _player1Score += score;
            result = $"¡Jugador 1 está en la casilla {_player1Score}!";
        }
        else
        {
            _player2Score += score;
            result = $"¡Jugador 2 está en la casilla {_player2Score}!";
        }

        if (die1 != die2)
        {
            _player1Turn = !_player1Turn;
        }

        return result;
    }
}