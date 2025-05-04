namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    private bool _player1 = true;
    public string Play(int die1, int die2)
    {
        var box = die1 + die2;

        if (_player1)
        {
            _player1 = false;
            return $"¡Jugador 1 está en la casilla {box}!";
        }
        return $"¡Jugador 2 está en la casilla {box}!";
    }
}