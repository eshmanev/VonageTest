namespace Shmanev.VonageTest.Engine.Commands
{

    /// <summary>
    /// Represents a command allowing to turn a piece anticlockwise.
    /// </summary>
    /// <seealso cref="Shmanev.VonageTest.Engine.Commands.TurnCommandBase" />
    public class TurnLeftCommand : TurnCommandBase
    {
        private readonly Piece _piece;

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnLeftCommand"/> class.
        /// </summary>
        /// <param name="piece">The piece.</param>
        public TurnLeftCommand(Piece piece)
        {
            _piece = piece;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        public override void Execute()
        {
            if (_piece.SightDirection == MinDirection)
                _piece.SightDirection = MaxDirection;
            else
                _piece.SightDirection -= 1;
        }
    }
}
