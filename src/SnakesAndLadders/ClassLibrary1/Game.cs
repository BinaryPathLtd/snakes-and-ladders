namespace Domain
{
    public class Game
    {
        public Game(int boardSize, int playerCount)
        {
            this.Players = new Player[playerCount];
        }

        public Player[] Players { get; set; }

        public void Start()
        {
            this.Players[0] = new Player();
        }
    }
}