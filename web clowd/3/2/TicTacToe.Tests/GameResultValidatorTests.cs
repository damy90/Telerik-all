using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.GameLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TicTacToe.Tests
{
    [TestClass()]
    public class GameResultValidatorTests
    {
        [TestMethod()]
        public void GetResultWinXTest()
        {
            GameResultValidator gameResultValidator = new GameResultValidator();
            var gameResult = gameResultValidator.GetResult("XXXOO----");
            Assert.AreEqual(gameResult, GameResult.WonByX);
        }

        [TestMethod()]
        public void GetResultWinOTest()
        {
            GameResultValidator gameResultValidator = new GameResultValidator();
            var gameResult = gameResultValidator.GetResult("X-XOOO--X");
            Assert.AreEqual(gameResult, GameResult.WonByO);
        }

        [TestMethod()]
        public void GetResultNotFinishedTest()
        {
            GameResultValidator gameResultValidator = new GameResultValidator();
            var gameResult = gameResultValidator.GetResult("X-XOO----");
            Assert.AreEqual(gameResult, GameResult.NotFinished);
        }

        [TestMethod()]
        public void GetResultDrawTest()
        {
            GameResultValidator gameResultValidator = new GameResultValidator();
            var gameResult = gameResultValidator.GetResult("XOXXOOOXX");
            Assert.AreEqual(gameResult, GameResult.Draw);
        }

        // TODO test invalid cases
    }
}
