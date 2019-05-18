using System;
using System.Collections.Generic;

namespace Tennis0518
{
    internal class Tennis
    {
        private string player1;
        private string player2;

        private int player1Point;
        private int player2Point;

        public Tennis(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        internal string ShowPoint()
        {
            if (player1Point == 0 && player2Point == 0)
            {
                return "Love All";
            }
            
            Dictionary<int, string> pointText = new Dictionary<int, string>()
            {
                {0, "Love" },
                {1, "Fifteen" },
                {2, "Thirty" },
                {3, "Forty" }
            };
            return string.Format("{0} {1}", pointText[player1Point], pointText[player2Point]);
        }

        internal void Player1Scored()
        {
            player1Point++;
        }

        internal void Player2Scored()
        {
            player2Point++;
        }
    }
}