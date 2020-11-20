namespace Shmanev.VonageTest.Engine
{
    using System;

    /// <summary>
    /// A simple guard class.
    /// </summary>
    public class Guard
    {
        /// <summary>
        /// Throws <see cref="ArgumentNullException"/> if the given <paramref name="value"/> is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <exception cref="System.ArgumentNullException">value</exception>
        public static void NotNull<T>(T value) where T : class
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the given <paramref name="value"/> is greater than <paramref name="valueToCompare"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void EqualToOrLessThan<T>(T value, T valueToCompare) where T: IComparable<T>
        {
            if (value.CompareTo(valueToCompare) == 1)
                throw new ArgumentException($"{nameof(value)} must be less than or equal to {valueToCompare}");
        }

        /// <summary>
        /// Throws <see cref="ArgumentException"/> if the given <paramref name="value"/> is less than <paramref name="valueToCompare"/>.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="valueToCompare">The value to compare.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public static void EqualToOrGreaterThan<T>(T value, T valueToCompare) where T : IComparable<T>
        {
            if (value.CompareTo(valueToCompare) == -1)
                throw new ArgumentException($"{nameof(value)} must be greater than or equal to {valueToCompare}");
        }
    }
}
