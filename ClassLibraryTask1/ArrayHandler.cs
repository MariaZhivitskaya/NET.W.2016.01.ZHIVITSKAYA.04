using System;

namespace ClassLibraryTask1
{
    public class ArrayHandler
    {
        /// <summary>
        /// Finds the index in the array, where the sum of left elements
        /// equals to the sum of right elements.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if the array
        /// has the wrong length.</exception>
        /// <exception cref="ArgumentException">Thrown if the array
        /// has the wrong number of arguments.</exception>
        /// <param name="array">The array for handling.</param>
        /// <returns>Returns the lowest index or return null if the element
        /// doesn't exist.</returns>
        public static int? FindIndex(int[] array)
        {
            if (array.Length == 0 || array.Length >= 1000)
                throw new ArgumentOutOfRangeException("Wrong length!");

            if (array.Length == 1 || array.Length == 2)
                throw new ArgumentException("Wrong number of arguments!");

            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 1; i < array.Length; i++)
                sumRight += array[i];

            for (int i = 1; i < array.Length - 1; i++)
            {
                sumLeft += array[i - 1];
                sumRight -= array[i];

                if (sumLeft == sumRight)
                    return i;
            }

            return null;
        }
    }
}
