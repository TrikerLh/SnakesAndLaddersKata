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
            7 => 14,
            8 => 31,
            15 => 26,
            16 => 6,
            21 => 42,
            28 => 84,
            36 => 44,
            46 => 25,
            49 => 11,
            51 => 67,
            62 => 19,
            64 => 60,
            71 => 91,
            74 => 53,
            78 => 98,
            87 => 94,
            92 => 88,
            95 => 75,
            99 => 80,
            _ => box
        };
    }

    private string BuildMessage(int box)
    {
        var player = _player1Turn ? "1" : "2";
        return $"¡Jugador {player} está en la casilla {box}!";
    }
}