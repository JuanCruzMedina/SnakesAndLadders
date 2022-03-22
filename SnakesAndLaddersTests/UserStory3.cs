using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using SnakesAndLadders.Contracts;
using SnakesAndLadders.Models;

namespace SnakesAndLaddersTests
{
    /// <summary>
    /// Tittle: Moves Are Determined By Dice Rolls.
    /// As a player
    /// I want to move my token based on the roll of a die
    /// So that there is an element of chance in the game
    /// </summary>
    [TestClass]
    public class UserStory3
    {
        /// <summary>
        /// Given the game is started
        /// When the player rolls a die
        /// Then the result should be between 1-6 inclusive
        /// </summary>
        [TestMethod]
        public void Test_UAT1()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);

            player.RollTheDie();
            Assert.IsTrue(1 <= player.GetSpacesToMove() && player.GetSpacesToMove() <= 6);
        }

        /// <summary>
        /// Given the player rolls a 4
        /// When they move their token
        /// Then the token should move 4 spaces
        /// </summary>
        [TestMethod]
        public void Test_UAT2()
        {
            int startPosition = 1;
            int mockResult = 4;
            IDice diceMocked = GetDiceMocked(mockResult);

            IBoardGame snakesAndLadders = new BoardGameModel(diceMocked, startPosition);
            IPlayer player = new PlayerModel(snakesAndLadders);
            Assert.AreEqual(startPosition, player.GetTokenPosition());

            player.RollTheDie();
            Assert.AreEqual(mockResult, player.GetSpacesToMove());

            player.Move();
            Assert.AreEqual(startPosition + mockResult, player.GetTokenPosition());
        }

        /// <summary>
        /// Permite obtener un dado mockeado.
        /// Su método para rodar el dado tendrá siempre un valor fijo.
        /// </summary>
        /// <param name="minValue">Valor mínimo del dado.</param>
        /// <param name="maxValue">Valor máximo del dado.</param>
        /// <param name="mockValue">Valor fijo que retornará el método para rodar el dado.</param>
        /// <returns>Dado con su método mockeado.</returns>
        private static IDice GetDiceMocked(int mockValue)
        {
            Mock<IDice> diceMocked = new();
            diceMocked.Setup(a => a.Roll()).Returns(mockValue);
            return diceMocked.Object;
        }
    }
}