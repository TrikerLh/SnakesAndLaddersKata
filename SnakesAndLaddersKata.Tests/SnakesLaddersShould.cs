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

        [Test]
        public void PlayerOneMoveAnotherTimeAfterPlayer2()
        {
            var snakesLadders = new SnakesLadders();
            snakesLadders.Play(1, 2); //Player1 to box 3
            snakesLadders.Play(1, 2); //Player2 to box 3
            
            var result = snakesLadders.Play(5, 1);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 9!");
        }

        [Test]
        [Ignore("paso demasiado grande")]
        public void PlayerOneMoveTwoTimesWhenIsDouble()
        {
            var snakesLadders = new SnakesLadders();
            snakesLadders.Play(3, 1); 
            
            var result = snakesLadders.Play(1, 2);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 6!");
            
        }
    }
}