using System;

namespace Shmanev.VonageTest.Engine.Commands
{
    /// <summary>
    /// Represents a command that can move a <see cref="Piece"/> to a new position.
    /// </summary>
    /// <seealso cref="Shmanev.VonageTest.Engine.Commands.CommandBase" />
    public class MoveCommand : CommandBase
    {
        private readonly Piece _piece;
        private readonly GameField _gameField;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoveCommand"/> class.
        /// </summary>
        /// <param name="piece">The piece.</param>
        /// <param name="gameField">The game field.</param>
        public MoveCommand(Piece piece, GameField gameField)
        {
            Guard.NotNull(piece);
            Guard.NotNull(gameField);
            _piece = piece;
            _gameField = gameField;
        }

        /// <summary>
        /// Determines whether the command can be executed.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the command can be executed; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanExecute()
        {
            switch (_piece.SightDirection)
            {
                case Direction.North:
                    return _piece.Y + 1 < _gameField.RowCount;
                case Direction.East:
                    return _piece.X + 1 < _gameField.ColumnCount;
                case Direction.South:
                    return _piece.Y > 0;
                case Direction.West:
                    return _piece.X > 0;
            }
            return false;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        public override void Execute()
        {
            if (!CanExecute())
                throw new InvalidOperationException();

            switch (_piece.SightDirection)
            {
                case Direction.North:
                    _piece.Y += 1;
                    break;
                case Direction.West:
                    _piece.X -= 1;
                    break;
                case Direction.South:
                    _piece.Y -= 1;
                    break;
                case Direction.East:
                    _piece.X += 1;
                    break;
            }
        }
    }
}
