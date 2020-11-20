namespace Shmanev.VonageTest.Engine.Commands
{
    using System;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Shmanev.VonageTest.Engine.Commands.ICommandFactory" />
    public class DefaultCommandFactory : ICommandFactory
    {
        private readonly Engine _engine;

        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultCommandFactory"/> class.
        /// </summary>
        /// <param name="engine">The engine.</param>
        public DefaultCommandFactory(Engine engine)
        {
            Guard.NotNull(engine);
            _engine = engine;
        }

        /// <summary>
        /// Creates the move command.
        /// </summary>
        /// <returns></returns>
        public CommandBase CreateMoveCommand()
        {
            return new MoveCommand(_engine.Player, _engine.GameField);
        }

        /// <summary>
        /// Creates the turn left command.
        /// </summary>
        /// <returns></returns>
        public CommandBase CreateTurnLeftCommand()
        {
            return new TurnLeftCommand(_engine.Player);
        }

        /// <summary>
        /// Creates the turn right command.
        /// </summary>
        /// <returns></returns>
        public CommandBase CreateTurnRightCommand()
        {
            return new TurnRightCommand(_engine.Player);
        }
    }
}
