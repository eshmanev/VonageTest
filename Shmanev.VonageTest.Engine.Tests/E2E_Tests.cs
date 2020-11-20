namespace Shmanev.VonageTest.Engine.Tests
{
    using NUnit.Framework;
    using Shmanev.VonageTest.Engine.Commands;

    [TestFixture]
    public class E2E_Tests
    {
        private Engine _engine;

        [OneTimeSetUp]
        public void FixtureSetup()
        {
            _engine = new Engine();
        }

        [SetUp]
        public void Setup()
        {
            _engine.Restart();
        }

        [Test]
        public void Run_MRMLMRM()
        {
            _engine.Move();
            _engine.TurnRight();
            _engine.Move();
            _engine.TurnLeft();
            _engine.Move();
            _engine.TurnRight();
            _engine.Move();

            Assert.AreEqual(2, _engine.Player.X);
            Assert.AreEqual(2, _engine.Player.Y);
            Assert.AreEqual(Direction.East, _engine.Player.SightDirection);
        }

        [Test]
        public void Run_RMMMLMM()
        {
            _engine.TurnRight();
            _engine.Move();
            _engine.Move();
            _engine.Move();
            _engine.TurnLeft();
            _engine.Move();
            _engine.Move();

            Assert.AreEqual(3, _engine.Player.X);
            Assert.AreEqual(2, _engine.Player.Y);
            Assert.AreEqual(Direction.North, _engine.Player.SightDirection);
        }

        [Test]
        public void Run_MMMMM()
        {
            _engine.Move();
            _engine.Move();
            _engine.Move();
            _engine.Move();
            _engine.Move();

            Assert.AreEqual(0, _engine.Player.X);
            Assert.AreEqual(4, _engine.Player.Y);
            Assert.AreEqual(Direction.North, _engine.Player.SightDirection);
        }
    }
}
