namespace Domain
{
    public class Player
    {
        public Player(int startPosition)
        {
            this.TokenPosition = startPosition;
        }

        public int TokenPosition { get; private set; }

        public void Move(int spaces)
        {
            this.TokenPosition += spaces;
        }
    }
}