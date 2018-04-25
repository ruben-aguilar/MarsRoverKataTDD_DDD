namespace MarsRoverKata
{
    public class Rover
    {
        public Rover(int x, int y)
        {
            Location = new Location {X = x, Y = y};
        }

        public Location Location { get; }
    }
}
