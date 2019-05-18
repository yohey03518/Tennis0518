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
            if (PointIsSame())
            {
                if (player1Point >= 3)
                    return "Deuce";
                return $"{PointText[player1Point]} All";
            }
            else if (AnyPlayerGreaterThen3())
            {
                if (PointDiffAbsIs1())
                {
                    if (player1Point > player2Point)
                        return $"{player1} Adv";
                    else
                        return $"{player2} Adv";
                }
                if (player1Point > player2Point)
                    return $"{player1} Win";
                else
                    return $"{player2} Win";
            }
            return $"{PointText[player1Point]} {PointText[player2Point]}";
        }

        private bool PointDiffAbsIs1()
        {
            return Math.Abs(player1Point - player2Point) == 1;
        }

        private bool AnyPlayerGreaterThen3()
        {
            return (player1Point > 3 || player2Point > 3);
        }

        private bool PointIsSame()
        {
            return player1Point == player2Point;
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