namespace Shmanev.VonageTest.Engine
{
    using Shmanev.VonageTest.Engine.Commands;
    using System.Collections.Generic;

    public class Engine
    {
        private readonly ICommandFactory _commandFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="Engine"/> class.
        /// </summary>
        /// <param name="commandFactory">The command factory.</param>
        public Engine(ICommandFactory commandFactory = null)
        {
            _commandFactory = commandFactory ?? new DefaultCommandFactory(this);
            Restart();
        }

        /// <summary>
        /// Gets the player's piece.
        /// </summary>
        public Piece Player { get; private set; }

        /// <summary>
        /// Gets the game field.
        /// </summary>
        public GameField GameField { get; private set; }

        /// <summary>
        /// Restarts the game.
        /// </summary>
        public void Restart()
        {
            Player = new Piece();
            GameField = new GameField();
        }

        /// <summary>
        /// A facade for turning the player's piece anticlockwise.
        /// </summary>
        public void TurnLeft()
        {
            ExecuteCommand(_commandFactory.CreateTurnLeftCommand());
        }

        /// <summary>
        /// A facade for turning the player's piece clockwise.
        /// </summary>
        public void TurnRight()
        {
            ExecuteCommand(_commandFactory.CreateTurnRightCommand());
        }

        /// <summary>
        /// A facade for moving the player's piece.
        /// </summary>
        public void Move()
        {
            ExecuteCommand(_commandFactory.CreateMoveCommand());
        }

        private void ExecuteCommand(CommandBase command)
        {
            if (!command.CanExecute())
                return;

            command.Execute();
        }
    }
}
