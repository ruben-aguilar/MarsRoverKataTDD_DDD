﻿using NUnit.Framework;

namespace MarsRoverKata
{
    [TestFixture]
    class RoverShould
    {
        private const int COORDINATE_ORIGIN_X = 0;
        private const int COORDINATE_ORIGIN_Y = 0;
        private const char INITIAL_DIRECTION = 'N';

        private Rover _rover;
        [SetUp]
        public void SetUp()
        {
            _rover = new Rover(COORDINATE_ORIGIN_X, COORDINATE_ORIGIN_Y, INITIAL_DIRECTION);
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
            Assert.AreEqual(INITIAL_DIRECTION, _rover.Direction);
        }

        [Test]
        public void move_forward()
        {
            _rover.Move(new char['f']);

            Assert.AreEqual(1, _rover.Location.Y);
        }
    }
}
