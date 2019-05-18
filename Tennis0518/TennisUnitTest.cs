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

        [TestCase]
        public void LoveThirty()
        {
            Player2ScoreTimes(2);
            PointShouldBe("Love Thirty");
        }

        [TestCase]
        public void FifteenAll()
        {
            Player1ScoreTimes(1);
            Player2ScoreTimes(1);
            PointShouldBe("Fifteen All");
        }

        [TestCase]
        public void Deuce()
        {
            Player1ScoreTimes(3);
            Player2ScoreTimes(3);
            PointShouldBe("Deuce");
        }

        [TestCase]
        public void Player1Adv()
        {
            Player1ScoreTimes(4);
            Player2ScoreTimes(3);
            PointShouldBe($"{player1} Adv");
        }

        [TestCase]
        public void Player2Adv()
        {
            Player1ScoreTimes(3);
            Player2ScoreTimes(4);
            PointShouldBe($"{player2} Adv");
        }

        [TestCase]
        public void Player1Win()
        {
            Player1ScoreTimes(4);
            Player2ScoreTimes(0);
            PointShouldBe($"{player1} Win");
        }

        [TestCase]
        public void Player2Win()
        {
            Player1ScoreTimes(3);
            Player2ScoreTimes(5);
            PointShouldBe($"{player2} Win");
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
