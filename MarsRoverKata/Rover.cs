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

        public void Move(char[] commands)
        {
            foreach (char command in commands)
            {
                if (command == 'f')
                {
                    Location.Y += 1;
                }
                else
                {
                    Location.Y = -1;
                }
            }           
        }
    }
}
