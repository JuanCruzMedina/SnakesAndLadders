using Microsoft.VisualStudio.TestTools.UnitTesting;

using Moq;

using SnakesAndLadders.Contracts;
using SnakesAndLadders.Models;

namespace SnakesAndLaddersTests
{
    [TestClass]
    public class UserStory4
    {
        /// <summary>
        /// Poder jugar con 2 jugadores.
        /// </summary>
        [TestMethod]
        public void Test_UAT1()
        {
            IBoardGame snakesAndLadders = new BoardGameModel(new DiceModel());
            IPlayer nino = new PlayerModel(snakesAndLadders);
            IPlayer meri = new PlayerModel(snakesAndLadders);
            Assert.AreEqual(nino.GetTokenPosition(), 1);
            Assert.AreEqual(meri.GetTokenPosition(), 1);
            Assert.AreEqual(nino.GetBoardGame(), meri.GetBoardGame());
        }
    }
}