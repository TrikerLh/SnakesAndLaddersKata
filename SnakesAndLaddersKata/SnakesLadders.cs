namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    private bool _player1Turn = true;
    private int _player1Score;
    private int _player2Score;
    public string Play(int die1, int die2)
    {
        string message;
        var score = die1 + die2;

        if (_player1Turn)
        {
            _player1Score += score;
        }
        else
        {
            _player2Score += score;
        }
        message = BuildMessage();

        if (die1 != die2)
        {
            _player1Turn = !_player1Turn;
        }

        return message;
    }

    private string BuildMessage()
    {
        var player = _player1Turn ? "1" : "2";
        var score = _player1Turn ? _player1Score : _player2Score;
        return $"¡Jugador {player} está en la casilla {score}!";
    }
}