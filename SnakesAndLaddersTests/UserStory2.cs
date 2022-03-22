using Microsoft.VisualStudio.TestTools.UnitTesting;

using SnakesAndLadders.Contracts;
using SnakesAndLadders.Models;

namespace SnakesAndLaddersTests
{
    /// <summary>
    /// Tittle: Player Can Win the Game
    /// As a player
    /// I want to be able to win the game
    /// So that I can gloat to everyone around
    /// </summary>
    [TestClass]
    public class UserStory2
    {
        /// <summary>
        /// Given the token is on square 97
        /// When the token is moved 3 spaces
        /// Then the token is on square 100
        /// And the player has won the game
        /// </summary>
        [TestMethod]
        public void Test_UAT1()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);
            player.MoveToken(96);
            Assert.AreEqual(97, player.GetTokenPosition());
            player.MoveToken(3);
            Assert.AreEqual(100, player.GetTokenPosition());
            Assert.IsTrue(player.Won());
        }

        /// <summary>
        /// Given the token is on square 97
        /// When the token is moved 4 spaces
        /// Then the token is on square 97
        /// And the player has not won the game
        /// </summary>
        [TestMethod]
        public void Test_UAT2()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);
            player.MoveToken(96);
            Assert.AreEqual(97, player.GetTokenPosition());
            player.MoveToken(4);
            Assert.AreEqual(97, player.GetTokenPosition());
            Assert.IsFalse(player.Won());
        }
    }
}