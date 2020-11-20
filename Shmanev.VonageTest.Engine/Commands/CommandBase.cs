namespace Shmanev.VonageTest.Engine.Commands
{
    /// <summary>
    /// Defines a base abstract class for commands.
    /// </summary>
    public abstract class CommandBase
    {
        /// <summary>
        /// Determines whether the command can be executed.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the command can be executed; otherwise, <c>false</c>.
        /// </returns>
        public abstract bool CanExecute();

        /// <summary>
        /// Executes the command.
        /// </summary>
        public abstract void Execute();
    }
}
