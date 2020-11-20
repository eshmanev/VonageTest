namespace Shmanev.VonageTest.Engine.Tests.Commands
{
    using NUnit.Framework;
    using Shmanev.VonageTest.Engine.Commands;
    using System;

    [TestFixture]
    class MoveCommand_Fixture
    {
        MoveCommand _command;
        Piece _piece;
        GameField _gameField;

        [SetUp]
        public void Setup()
        {
            _piece = new Piece();
            _gameField = new GameField(5, 5);
            _command = new MoveCommand(_piece, _gameField);
        }

        private static readonly Tuple<int, int, Direction, bool>[] CanExecuteValues =
        {
            new Tuple<int, int, Direction, bool>(0, 0, Direction.West, false),
            new Tuple<int, int, Direction, bool>(0, 0, Direction.South, false),
            new Tuple<int, int, Direction, bool>(0, 0, Direction.North, true),
            new Tuple<int, int, Direction, bool>(0, 0, Direction.East, true),

            new Tuple<int, int, Direction, bool>(4, 0, Direction.West, true),
            new Tuple<int, int, Direction, bool>(4, 0, Direction.South, false),
            new Tuple<int, int, Direction, bool>(4, 0, Direction.North, true),
            new Tuple<int, int, Direction, bool>(4, 0, Direction.East, false),

            new Tuple<int, int, Direction, bool>(4, 4, Direction.West, true),
            new Tuple<int, int, Direction, bool>(4, 4, Direction.South, true),
            new Tuple<int, int, Direction, bool>(4, 4, Direction.North, false),
            new Tuple<int, int, Direction, bool>(4, 4, Direction.East, false),

            new Tuple<int, int, Direction, bool>(0, 4, Direction.West, false),
            new Tuple<int, int, Direction, bool>(0, 4, Direction.South, true),
            new Tuple<int, int, Direction, bool>(0, 4, Direction.North, false),
            new Tuple<int, int, Direction, bool>(0, 4, Direction.East, true),
        };

        [Test]
        public void Test_CanExecute_BottomLeft(
            [ValueSource(nameof(CanExecuteValues))] Tuple<int, int, Direction, bool> values)
        {
            // arrange
            _piece.X = values.Item1;
            _piece.Y = values.Item2;
            _piece.SightDirection = values.Item3;

            // act
            var result = _command.CanExecute();

            // assert
            Assert.AreEqual(values.Item4, result);
        }

        private static readonly Tuple<int, int, Direction, int, int, bool>[] ExecuteValues =
       {
            new Tuple<int, int, Direction, int, int, bool>(0, 0, Direction.West, 0, 0, true),
            new Tuple<int, int, Direction, int, int, bool>(0, 0, Direction.South, 0, 0, true),
            new Tuple<int, int, Direction, int, int, bool>(0, 0, Direction.North, 0, 1, false),
            new Tuple<int, int, Direction, int, int, bool>(0, 0, Direction.East, 1, 0, false),

            new Tuple<int, int, Direction, int, int, bool>(4, 0, Direction.West, 3, 0, false),
            new Tuple<int, int, Direction, int, int, bool>(4, 0, Direction.South, 4, 0, true),
            new Tuple<int, int, Direction, int, int, bool>(4, 0, Direction.North, 4, 1, false),
            new Tuple<int, int, Direction, int, int, bool>(4, 0, Direction.East, 4, 0, true),

            new Tuple<int, int, Direction, int, int, bool>(4, 4, Direction.West, 3, 4, false),
            new Tuple<int, int, Direction, int, int, bool>(4, 4, Direction.South, 4, 3, false),
            new Tuple<int, int, Direction, int, int, bool>(4, 4, Direction.North, 4, 4, true),
            new Tuple<int, int, Direction, int, int, bool>(4, 4, Direction.East, 4, 4, true),

            new Tuple<int, int, Direction, int, int, bool>(0, 4, Direction.West, 0, 4, true),
            new Tuple<int, int, Direction, int, int, bool>(0, 4, Direction.South, 0, 3, false),
            new Tuple<int, int, Direction, int, int, bool>(0, 4, Direction.North, 0, 4, true),
            new Tuple<int, int, Direction, int, int, bool>(0, 4, Direction.East, 1, 4, false),
        };

        [Test]
        public void Test_Execute_BottomLeft(
            [ValueSource(nameof(ExecuteValues))] Tuple<int, int, Direction, int, int, bool> values)
        {
            // arrange
            _piece.X = values.Item1;
            _piece.Y = values.Item2;
            _piece.SightDirection = values.Item3;
            bool thrown = false;

            // act
            try
            {
                _command.Execute();
            }
            catch (InvalidOperationException)
            {
                thrown = true;
            }

            // assert
            Assert.AreEqual(values.Item6, thrown);
            Assert.AreEqual(values.Item4, _piece.X);
            Assert.AreEqual(values.Item5, _piece.Y);
        }
    }
}
