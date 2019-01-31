namespace Domain
{
    public class Player
    {
        public Player(int startPosition, int boardSize)
        {
            this.TokenPosition = startPosition;
            this.boardSize = boardSize;
        }

        public int TokenPosition { get; private set; }
        private int boardSize;

        public void Move(int spaces)
        {
            this.TokenPosition += spaces;
        }

        public bool HasWonGame()
        {
            return this.boardSize == this.TokenPosition;
        }

        public void RollDie()
        {
            // random number generator to be used here :)
            this.Move(4);
        }
    }
}