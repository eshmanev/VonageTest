namespace Shmanev.VonageTest.Engine
{
    /// <summary>
    /// A simple participle that can be located on the <see cref="GameField"/>.
    /// </summary>
    public class Piece
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Piece"/> class.
        /// </summary>
        /// <param name="x">An initial value of the X-coordinate.</param>
        /// <param name="y">An initial value of the Y-coordinate.</param>
        public Piece(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Gets or sets the X-coordinate on the game field.
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y-coordinate on the game field.
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the sight direction.
        /// </summary>
        public Direction SightDirection { get; set; }
    }
}
