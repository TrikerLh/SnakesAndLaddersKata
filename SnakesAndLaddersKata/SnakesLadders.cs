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
        var box = 0;

        if (_player1Turn)
        {
            box = _player1Score += score;
        }
        else
        {
           box = _player2Score += score;
        }

        box = IsSnakeOrLadders(box);
        
        message = BuildMessage(box);

        if (die1 != die2)
        {
            _player1Turn = !_player1Turn;
        }

        return message;
    }

    private static int IsSnakeOrLadders(int box)
    {
        return box switch
        {
            2 => 38,
            16 => 6,
            _ => box
        };
    }

    private string BuildMessage(int box)
    {
        var player = _player1Turn ? "1" : "2";
        return $"¡Jugador {player} está en la casilla {box}!";
    }
}