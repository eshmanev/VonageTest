using System;
using System.Linq;

namespace Shmanev.VonageTest.Engine.Commands
{
    /// <summary>
    /// Represents an abstract turn command.
    /// </summary>
    /// <seealso cref="Shmanev.VonageTest.Engine.Commands.CommandBase" />
    public abstract class TurnCommandBase : CommandBase
    {
        /// <summary>
        /// Initializes static members of the <see cref="TurnCommandBase"/> class.
        /// </summary>
        static TurnCommandBase()
        {
            MinDirection = Enum.GetValues(typeof(Direction)).Cast<Direction>().First();
            MaxDirection = Enum.GetValues(typeof(Direction)).Cast<Direction>().Last();
        }

        /// <summary>
        /// Gets the minimum value of the <see cref="Direction"/>.
        /// </summary>
        /// <value>
        /// The minimum direction.
        /// </value>
        protected static Direction MinDirection { get; }

        /// <summary>
        /// Gets the minimum value of the <see cref="Direction"/>.
        /// </summary>
        /// <value>
        /// The maximum direction.
        /// </value>
        protected static Direction MaxDirection { get; }

        /// <summary>
        /// Always returns true.
        /// </summary>
        public override bool CanExecute()
        {
            return true;
        }
    }
}
