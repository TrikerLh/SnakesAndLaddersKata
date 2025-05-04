namespace SnakesAndLaddersKata;

public class Player
{
    private string _name;
    private int _position;

    public Player(string name)
    {
        _name = name;
        _position = 0;
    }

    public int Move(int score)
    {
        _position += score;
        return _position;
    }

    public string GetMessage()
    {
        return $"¡Jugador {_name} está en la casilla {_position}!";
    }

    public void MoveTo(int box)
    {
        _position = box;
    }

    public bool IsWinner()
    {
        return _position == 100;
    }

    public string GetMessageWin()
    {
        return $"¡Jugador {_name} gana!";
    }
}