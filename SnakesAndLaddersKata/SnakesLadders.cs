namespace SnakesAndLaddersKata;

public class SnakesLadders
{
    public string Play(int die1, int die2)
    {
        var box = die1 + die2;
        return $"¡Jugador 1 está en la casilla {box}!";
    }
}