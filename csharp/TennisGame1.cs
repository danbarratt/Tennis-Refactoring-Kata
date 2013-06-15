namespace Tennis
{
    internal class TennisGame1 : TennisGame
    {
        private readonly Player _player1;
        private readonly Player _player2;

        public TennisGame1(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
        }

        public void WonPoint(string playerName)
        {
            if (playerName == _player1.Name)
                _player1.WonPoint();
            else
                _player2.WonPoint();
        }

        public string GetScore()
        {
            return new Score(_player1, _player2, new ScoreFormatter()).GetScore();
        }
    }

}