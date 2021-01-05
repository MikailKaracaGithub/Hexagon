namespace BoardSystem
{
    public class Tile
    {
        public Position Position { get; } // so i can access the tiles position

        public Tile(int x, int y, int z)
        {
            Position = new Position { X = x, Y = y , Z = z};
        }
    }
}
