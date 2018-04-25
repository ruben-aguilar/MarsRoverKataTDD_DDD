using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class RoverShould
    {
        public void have_a_location()
        {
            Rover rover = new Rover();

            Assert.NotNull(rover.Location);
        }
    }
}
