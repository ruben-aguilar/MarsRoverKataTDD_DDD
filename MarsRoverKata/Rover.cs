namespace MarsRoverKata
{
    public class Rover
    {
        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARDS_COMMAND = 'b';
        private const int DISTANCE_UNIT = 1;

        public Rover(int x, int y, char direction)
        {
            Location = new Location {X = x, Y = y};
            Direction = direction;
        }

        public Location Location { get; }

        public char Direction { get; private set; }

        public void Move(char[] commands)
        {
            foreach (char command in commands)
            {
                if (command == FORWARD_COMMAND)
                {
                    Location.Y += DISTANCE_UNIT;
                }
                else if (command == BACKWARDS_COMMAND)
                {
                    Location.Y -= DISTANCE_UNIT;
                }
                else
                {
                    Direction = 'W';
                }
            }           
        }
    }
}
