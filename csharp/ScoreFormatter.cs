namespace Tennis
{
    internal class ScoreFormatter
    {
        public string Won(Player player)
        {
            return string.Format("Win for {0}", player.Name);
        }

        public string Advantage(Player player)
        {
            return string.Format("Advantage {0}", player.Name);
        }

        public string EqualScore(int score)
        {
            if (score <= 3)
                return string.Format("{0}-All", (ScoreName)score);

            return "Deuce";
        }

        public string Points(int score1, int score2)
        {
            ScoreName ps1 = (ScoreName) score1;
            ScoreName ps2 = (ScoreName) score2;

            return string.Format("{0}-{1}", ps1, ps2);
        }

        private enum ScoreName
        {
            Love = 0,
            Fifteen = 1,
            Thirty = 2,
            Forty = 3
        }
    }
}