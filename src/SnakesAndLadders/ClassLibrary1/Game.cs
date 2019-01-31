namespace Domain
{
    public class Game
    {
        private readonly int boardSize;

        public Game(int boardSize, int playerCount)
        {
            this.boardSize = boardSize;
            this.Players = new Player[playerCount];
        }

        public Player[] Players { get; set; }

        public void Start()
        {
            this.Players[0] = new Player(1, boardSize);
        }
    }
}