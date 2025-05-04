namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    private readonly Player _player1; 
    private readonly Player _player2;
    private Player _activePlayer;
    private bool _gameOver;

    public SnakesLadders()
    {
        _player1 = new Player("1");
        _player2 = new Player("2");
        _activePlayer = _player1;
        _gameOver = false;
    }
    public string Play(int die1, int die2)
    {
        if (_gameOver)
            return "¡Fin del juego!";
        
        var score = die1 + die2;
        var box = _activePlayer.Move(score);
        box = IsSnakeOrLadders(box);
        _activePlayer.MoveTo(box);

        string message;
        if (_activePlayer.IsWinner())
        {
            message = _activePlayer.GetMessageWin();
            _gameOver = true;
        }
        else
        {
            message = _activePlayer.GetMessage();
        }

        if (die1 != die2)
        {
            _activePlayer = _activePlayer == _player1 ? _player2 : _player1;
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
}