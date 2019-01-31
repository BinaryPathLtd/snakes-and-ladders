namespace Domain
{
    public class Player
    {
        public Player(int startPosition)
        {
            this.TokenPosition = startPosition;
        }

        public int TokenPosition
        {
            get => 1;
            private set { }
        }
    }
}