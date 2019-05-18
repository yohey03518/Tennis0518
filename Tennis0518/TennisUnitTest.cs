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
            string result = game.ShowPoint();
            Assert.AreEqual("Love All", result);
        }

        [TestCase]
        public void FifteenLove()
        {
            game.Player1Scored();
            string result = game.ShowPoint();
            Assert.AreEqual("Fifteen Love", result);
        }
    }
}
