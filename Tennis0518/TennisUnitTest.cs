using System;
using NUnit.Framework;

namespace Tennis0518
{
    [TestFixture]
    public class TennisUnitTest
    {
        private const string player1 = "Jay";
        private const string player2 = "Moon";

        [SetUp]
        public void Setup()
        {
            game = new Tennis(player1, player2);
        }

        private Tennis game;

        [TestCase]
        public void LoveAll()
        {
            PointShouldBe("Love All");
        }

        [TestCase]
        public void FifteenLove()
        {
            Player1ScoreTimes(1);
            PointShouldBe("Fifteen Love");
        }

        [TestCase]
        public void ThirtyLove()
        {
            Player1ScoreTimes(2);
            PointShouldBe("Thirty Love");
        }

        [TestCase]
        public void FortyLove()
        {
            Player1ScoreTimes(3);
            PointShouldBe("Forty Love");
        }

        [TestCase]
        public void LoveFifteen()
        {
            Player2ScoreTimes(1);
            PointShouldBe("Love Fifteen");
        }

        private void Player2ScoreTimes(int times)
        {
            for (int j = 0; j < times; j++)
            {
                game.Player2Scored();
            }
        }

        private void Player1ScoreTimes(int times)
        {
            for (int j = 0; j < times; j++)
            {
                game.Player1Scored();
            }
        }

        private void PointShouldBe(string expected)
        {
            string result = game.ShowPoint();
            Assert.AreEqual(expected, result);
        }
    }
}
