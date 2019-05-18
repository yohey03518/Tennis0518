using System;

namespace Tennis0518
{
    internal class Tennis
    {
        private string player1;
        private string player2;

        public Tennis(string player1, string player2)
        {
            this.player1 = player1;
            this.player2 = player2;
        }

        internal string ShowPoint()
        {
            return "Love All";
        }
    }
}