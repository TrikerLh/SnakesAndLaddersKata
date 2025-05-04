using Shouldly;

namespace SnakesAndLaddersKata.Tests
{

    public class SnakesLaddersShould
    {
        private SnakesLadders snakesLadders;
        [SetUp]
        public void Setup()
        {
            snakesLadders = new SnakesLadders();
        }

        [Test]
        public void PlayerOneMove3()
        {
            var result = snakesLadders.Play(1, 2);

            result.ShouldBe("¡Jugador 1 está en la casilla 3!");
        }

        [Test]
        public void PlayerOneMove5()
        {
            var result = snakesLadders.Play(3, 2);

            result.ShouldBe("¡Jugador 1 está en la casilla 5!");
        }
        
        [Test]
        public void PlayerTwoMove3()
        {
            snakesLadders.Play(1, 2);
            
            var result = snakesLadders.Play(1, 2);

            result.ShouldBe("¡Jugador 2 está en la casilla 3!");
        }

        [Test]
        public void PlayerOneMoveAnotherTimeAfterPlayer2()
        {
            snakesLadders.Play(1, 2); //Player1 to box 3
            snakesLadders.Play(1, 2); //Player2 to box 3
            
            var result = snakesLadders.Play(5, 1);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 9!");
        }

        [Test]
        public void PlayerOneMoveTwoTimesWhenIsDouble()
        {
            snakesLadders.Play(3, 3); 
            
            var result = snakesLadders.Play(1, 2);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 9!");
        }

        [Test]
        [Ignore("Refactor preparatorio")]
        public void PlayerOneUptoLadderInBox2()
        {
            var result = snakesLadders.Play(1, 1);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 38!");
        }
    }
}