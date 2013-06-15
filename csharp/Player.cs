namespace Tennis
{
    internal class Player
    {
        public string Name { private set; get; }
        public int Score { private set; get; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        public void WonPoint()
        {
            Score++;
        }
    }
}