using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class RoverShould
    {
        private const int COORDINATE_ORIGIN_X = 0;
        private const int COORDINATE_ORIGIN_Y = 0;

        private const char NORTH_DIRECTION = 'N';
        private const char WEST_DIRECTION = 'W';
        private const char EAST_DIRECTION = 'E';

        private const char FORWARD_COMMAND = 'f';
        private const char BACKWARDS_COMMAND = 'b';
        private const char TURN_LEFT_COMMAND = 'l';
        private const char TURN_RIGHT_COMMAND = 'r';
        private const char SOUTH_DIRECTION = 'S';
        private Rover _rover;

        [SetUp]
        public void SetUp()
        {
            _rover = new Rover(COORDINATE_ORIGIN_X, COORDINATE_ORIGIN_Y, NORTH_DIRECTION);
        }

        [Test]
        public void start_in_the_given_position()
        {
            Assert.AreEqual(COORDINATE_ORIGIN_X, _rover.Location.X);
            Assert.AreEqual(COORDINATE_ORIGIN_Y, _rover.Location.Y);
        }

        [Test]
        public void start_in_a_given_direction()
        {
            Assert.AreEqual(NORTH_DIRECTION, _rover.Direction);
        }

        [Test]
        public void move_forward()
        {
            char[] commands = { FORWARD_COMMAND };
            _rover.Move(commands);

            Assert.AreEqual(1, _rover.Location.Y);
        }

        [Test]
        public void move_backwards()
        {
            char[] commands = { BACKWARDS_COMMAND };
            _rover.Move(commands);

            Assert.AreEqual(-1, _rover.Location.Y);
        }

        [Test]
        public void move_forward_two_units()
        {
            char[] commands = { FORWARD_COMMAND, FORWARD_COMMAND };

            _rover.Move(commands);

            Assert.AreEqual(2, _rover.Location.Y);
        }

        [Test]
        public void return_to_origin_when_moving_forward_and_backwards()
        {
            char[] commands = { FORWARD_COMMAND, BACKWARDS_COMMAND };

            _rover.Move(commands);

            Assert.AreEqual(0, _rover.Location.Y);
            Assert.AreEqual(0, _rover.Location.X);
        }

        [Test]
        public void turn_left()
        {
            char[] commands = { TURN_LEFT_COMMAND };

            _rover.Move(commands);

            Assert.AreEqual(WEST_DIRECTION, _rover.Direction);
        }

        [Test]
        public void turn_right()
        {
            char[] commands = { TURN_RIGHT_COMMAND };

            _rover.Move(commands);

            Assert.AreEqual(EAST_DIRECTION, _rover.Direction);
        }

        [Test]
        public void turnt_left_twice()
        {
            char[] commands = { TURN_LEFT_COMMAND, TURN_LEFT_COMMAND };

            _rover.Move(commands);

            Assert.AreEqual(SOUTH_DIRECTION, _rover.Direction);
        }
    }
}
