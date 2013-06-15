using System;

namespace Tennis
{
    internal class Score
    {
        private readonly Player _player1;
        private readonly Player _player2;
        private readonly ScoreFormatter _formatter;

        public Score(Player player1, Player player2, ScoreFormatter formatter)
        {
            _player1 = player1;
            _player2 = player2;
            _formatter = formatter;
        }

        public string GetScore()
        {
            if (IsEqual)
                return EqualScore();

            if (AnyPlayerPastForty)
                return PlayOffScore();

            return NormalScore();
        }

        private string EqualScore()
        {
            return _formatter.EqualScore(_player1.Score);
        }

        private string PlayOffScore()
        {
            int difference = (_player1.Score - _player2.Score);
            var winningPlayer = difference > 0 ? _player1 : _player2;
            var hasWon = Math.Abs(difference) >= 2;

            return hasWon
                ? _formatter.Won(winningPlayer)
                : _formatter.Advantage(winningPlayer);
        }
        
        private string NormalScore()
        {
            return _formatter.Points(_player1.Score, _player2.Score);
        }

        private bool AnyPlayerPastForty
        {
            get { return _player1.Score >= 4 || _player2.Score >= 4; }
        }

        private bool IsEqual
        {
            get { return _player1.Score == _player2.Score; }
        }
    }
}