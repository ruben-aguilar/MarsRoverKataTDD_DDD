using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class RoverShould
    {
        private const int COORDINATE_ORIGIN_X = 0;
        private const int COORDINATE_ORIGIN_Y = 0;
        private const char INITIAL_DIRECTION = 'N';

        [Test]
        public void start_in_the_given_position()
        {
            var rover = new Rover(COORDINATE_ORIGIN_X, COORDINATE_ORIGIN_Y, INITIAL_DIRECTION);

            Assert.AreEqual(COORDINATE_ORIGIN_X, rover.Location.X);
            Assert.AreEqual(COORDINATE_ORIGIN_Y, rover.Location.Y);
        }

        [Test]
        public void start_in_a_given_direction()
        {
            var rover = new Rover(COORDINATE_ORIGIN_X, COORDINATE_ORIGIN_Y, INITIAL_DIRECTION);

            Assert.AreEqual(INITIAL_DIRECTION, rover.Direction);
        }
    }
}
