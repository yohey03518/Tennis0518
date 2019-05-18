using System;

namespace Tennis0518
{
    internal class Tennis
    {
        private string player1;
        private string player2;

        private int player1Point;

        public Tennis(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        internal string ShowPoint()
        {
            if (player1Point == 1)
            {
                return "Fifteen Love";
            }
            return "Love All";
        }

        internal void Player1Scored()
        {
            player1Point++;
        }
    }
}