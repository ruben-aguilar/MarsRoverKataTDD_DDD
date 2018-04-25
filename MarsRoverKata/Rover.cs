namespace MarsRoverKata
{
    public class Rover
    {
        public Rover(int x, int y, char direction)
        {
            Location = new Location {X = x, Y = y};
            Direction = direction;
        }

        public Location Location { get; }

        public char Direction { get; }
    }
}
