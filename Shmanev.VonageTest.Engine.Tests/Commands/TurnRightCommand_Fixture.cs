namespace Shmanev.VonageTest.Engine.Tests.Commands
{
    using NUnit.Framework;
    using Shmanev.VonageTest.Engine.Commands;

    [TestFixture]
    class TurnRightCommand_Fixture
    {
        TurnRightCommand _command;
        Piece _piece;

        [SetUp]
        public void Setup()
        {
            _piece = new Piece();
            _command = new TurnRightCommand(_piece);
        }

        [Test]
        public void Test_Execute()
        {
            _piece.SightDirection = Direction.North;

            _command.Execute();
            Assert.AreEqual(Direction.East, _piece.SightDirection);

            _command.Execute();
            Assert.AreEqual(Direction.South, _piece.SightDirection);

            _command.Execute();
            Assert.AreEqual(Direction.West, _piece.SightDirection);

            _command.Execute();
            Assert.AreEqual(Direction.North, _piece.SightDirection);
        }
    }
}
