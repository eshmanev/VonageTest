namespace Shmanev.VonageTest.Engine
{
    public class GameField
    {
        public const int DefaultRows = 5;
        public const int DefaultColumns = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="GameField"/> class.
        /// </summary>
        /// <param name="rowCount">The total number of rows.</param>
        /// <param name="columnCount">The total number of columns.</param>
        public GameField(int rowCount = DefaultRows, int columnCount = DefaultColumns)
        {
            Guard.EqualToOrGreaterThan(rowCount, 0);
            Guard.EqualToOrGreaterThan(columnCount, 0);
            RowCount = rowCount;
            ColumnCount = columnCount;
        }


        /// <summary>
        /// Gets the total number of rows in the game field.
        /// </summary>
        public int RowCount { get; }

        /// <summary>
        /// Gets the total number of columns in the game field.
        /// </summary>
        public int ColumnCount { get; }
    }
}
