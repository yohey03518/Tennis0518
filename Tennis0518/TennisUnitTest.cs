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
            game.Player1Scored();
            PointShouldBe("Fifteen Love");
        }

        [TestCase]
        public void ThirtyLove()
        {
            game.Player1Scored();
            game.Player1Scored();
            PointShouldBe("Thirty Love");
        }

        private void PointShouldBe(string expected)
        {
            string result = game.ShowPoint();
            Assert.AreEqual(expected, result);
        }
    }
}
