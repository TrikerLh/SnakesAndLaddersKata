using Shouldly;

namespace SnakesAndLaddersKata.Tests
{

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
        
        [Test]
        public void PlayerTwoMove3()
        {
            var snakesLadders = new SnakesLadders();
            snakesLadders.Play(1, 2);
            
            var result = snakesLadders.Play(1, 2);

            result.ShouldBe("¡Jugador 2 está en la casilla 3!");
        }
    }
}