using Shouldly;

namespace SnakesAndLaddersKata.Tests;

public class SnakesLaddersShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PlayerOneMove3()
    {
        var snakesLadders = new SnakesLadders();

        var result = snakesLadders.Play(1, 2);

        result.ShouldBe("¡Jugador 1 está en la casilla 3!");
    }
    
    [Test]
    public void PlayerOneMove5()
    {
        var snakesLadders = new SnakesLadders();

        var result = snakesLadders.Play(3, 2);

        result.ShouldBe("¡Jugador 1 está en la casilla 5!");
    }
}

public class SnakesLadders
{
    public string Play(int die1, int die2)
    {
        var box = die1 + die2;
        return $"¡Jugador 1 está en la casilla {box}!";
    }
}