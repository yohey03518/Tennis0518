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
            if (player1Point == player2Point)
            {
                if (player1Point >= 4)
                    return "Deuce";
                return string.Format("{0} All", PointText[player1Point]);
            }
            return string.Format("{0} {1}", PointText[player1Point], PointText[player2Point]);
        }

        private static Dictionary<int, string> PointText = new Dictionary<int, string>()
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"}
        };

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