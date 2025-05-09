﻿using Shouldly;

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
        public void PlayerOneUptoLadderInBox2()
        {
            var result = snakesLadders.Play(1, 1);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 38!");
        }
        
        [Test]
        public void PlayerOneDownToSnakeInBox16()
        {
            snakesLadders.Play(6, 6);
            
            var result = snakesLadders.Play(3, 1);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 6!");
        }

        [Test]
        public void PlayerTwoWins()
        {
            snakesLadders.Play(1, 2); //Player1 to box 3
            snakesLadders.Play(1, 1); //Player2 to box 38
            snakesLadders.Play(6, 6); //Player2 to box 50
            snakesLadders.Play(5, 5); //Player2 to box 60
            snakesLadders.Play(5, 5); //Player2 to box 70
            snakesLadders.Play(4, 4); //Player2 to box 98
            
            var result = snakesLadders.Play(1, 1);
            
            result.ShouldBe("¡Jugador 2 gana!");
            
        }

        [Test]
        public void GameIsOver()
        {
            snakesLadders.Play(1, 2); //Player1 to box 3
            snakesLadders.Play(1, 1); //Player2 to box 38
            snakesLadders.Play(6, 6); //Player2 to box 50
            snakesLadders.Play(5, 5); //Player2 to box 60
            snakesLadders.Play(5, 5); //Player2 to box 70
            snakesLadders.Play(4, 4); //Player2 to box 98
            snakesLadders.Play(1, 1); //Player2 Wins
            
            var result = snakesLadders.Play(3,6);
            
            result.ShouldBe("¡Fin del juego!");
            
        }
        
        [Test]
        public void PlayerOneBounceWhenHisScoreIsGreaterThan100()
        {
            snakesLadders.Play(1, 1); //Player1 to box 38
            snakesLadders.Play(6, 6); //Player1 to box 50
            snakesLadders.Play(5, 5); //Player1 to box 60
            snakesLadders.Play(5, 5); //Player1 to box 70
            snakesLadders.Play(4, 4); //Player1 to box 98
            
            var result = snakesLadders.Play(2,3);
            
            result.ShouldBe("¡Jugador 1 está en la casilla 97!");
            
        }
    }
}