using NUnit.Framework;

namespace Tennis0518
{
    [TestFixture]
    public class TennisUnitTest
    {
        [TestCase]
        public void LoveAll()
        {
            string player1 = "Jay";
            string player2 = "Moon";
            Tennis game = new Tennis(player1, player2);
            string result = game.ShowPoint();
            Assert.AreEqual("Love All", result);
        }
    }
}
