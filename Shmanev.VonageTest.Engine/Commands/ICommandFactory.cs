namespace Shmanev.VonageTest.Engine.Commands
{
    /// <summary>
    /// Defines a command factory.
    /// </summary>
    public interface ICommandFactory
    {
        /// <summary>
        /// Creates the turn left command.
        /// </summary>
        /// <returns></returns>
        CommandBase CreateTurnLeftCommand();

        /// <summary>
        /// Creates the turn right command.
        /// </summary>
        /// <returns></returns>
        CommandBase CreateTurnRightCommand();

        /// <summary>
        /// Creates the move command.
        /// </summary>
        /// <returns></returns>
        CommandBase CreateMoveCommand();
    }
}
