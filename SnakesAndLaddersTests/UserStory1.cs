using Microsoft.VisualStudio.TestTools.UnitTesting;

using SnakesAndLadders.Contracts;
using SnakesAndLadders.Models;

namespace SnakesAndLaddersTests
{
    /// <summary>
    /// Tittle: Token Can Move Across the Board
    /// As a player
    /// I want to be able to move my token
    /// So that I can get closer to the goal
    /// </summary>
    [TestClass]
    public class UserStory1
    {
        /// <summary>
        /// Given the game is started 
        /// When the token is placed on the board 
        /// Then the token is on square 1
        /// </summary>
        [TestMethod]
        public void Test_UAT1()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);
            Assert.AreEqual(1, player.GetTokenPosition());
        }

        /// <summary>
        /// Given the token is on square 1 
        /// When the token is moved 3 spaces 
        /// Then the token is on square 4
        /// </summary>
        [TestMethod]
        public void Test_UAT2()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);
            Assert.AreEqual(1, player.GetTokenPosition());
            player.MoveToken(3);
            Assert.AreEqual(4, player.GetTokenPosition());
        }

        /// <summary>
        /// Given the token is on square 1
        /// When the token is moved 3 spaces
        /// And then it is moved 4 spaces
        /// Then the token is on square 8
        /// </summary>
        [TestMethod]
        public void Test_UAT3()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer player = new PlayerModel(snakesAndLadders);
            Assert.AreEqual(1, player.GetTokenPosition());
            player.MoveToken(3);
            player.MoveToken(4);
            Assert.AreEqual(8, player.GetTokenPosition());
        }
    }
}