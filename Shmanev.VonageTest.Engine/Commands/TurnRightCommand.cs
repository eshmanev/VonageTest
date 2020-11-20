namespace Shmanev.VonageTest.Engine.Commands
{
    /// <summary>
    /// Represents a command allowing to turn a piece clockwise.
    /// </summary>
    /// <seealso cref="Shmanev.VonageTest.Engine.Commands.TurnCommandBase" />
    public class TurnRightCommand : TurnCommandBase
    {
        private readonly Piece _piece;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnRightCommand"/> class.
        /// </summary>
        /// <param name="piece">The piece.</param>
        public TurnRightCommand(Piece piece)
        {
            Guard.NotNull(piece);
            _piece = piece;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        public override void Execute()
        {
            if (_piece.SightDirection == MaxDirection)
                _piece.SightDirection = MinDirection;
            else
                _piece.SightDirection += 1;
        }
    }
}
