namespace MarsRoverKata
{
    public class Rover
    {
        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARDS_COMMAND = 'b';
        private const int DISTANCE_UNIT = 1;
        private const char LEFT_COMMAND = 'l';
        private const char WEST = 'W';
        private const char EAST = 'E';
        private const char NORTH = 'N';
        private const char SOUTH = 'S';

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
                ExecuteCommand(command);
            }           
        }

        private void ExecuteCommand(char command)
        {
            switch (command)
            {
                case FORWARD_COMMAND:
                    Location.Y += DISTANCE_UNIT;
                    break;
                case BACKWARDS_COMMAND:
                    Location.Y -= DISTANCE_UNIT;
                    break;
                case LEFT_COMMAND:
                    if (Direction.Equals(NORTH))
                    {
                        Direction = WEST;
                    }
                    else
                    {
                        Direction = SOUTH;
                    }
                    break;
                default:
                    Direction = EAST;
                    break;
            }
        }
    }
}
