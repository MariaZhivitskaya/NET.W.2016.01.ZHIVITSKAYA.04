using System;

namespace ClassLibraryTask1
{
    public class ArrayHandler
    {
        /// <summary>
        /// Finds an index in the array, where sum of left elements
        /// equals to sum of right elements.
        /// </summary>
        /// <param name="array">An array for handling.</param>
        /// <returns>Returns the lowest index or return -1 if element
        /// doesn't exist.</returns>
        public static int FindIndex(int[] array)
        {
            if (array.Length == 0 || array.Length >= 1000)
            {
                throw new Exception("Wrong length!");
            }

            if (array.Length == 1 || array.Length == 2)
            {
                return -1;
            }

            var sumLeft = 0;
            var sumRight = 0;

            for (var i = 1; i < array.Length; i++)
            {
                sumRight += array[i];
            }

            for (var i = 1; i < array.Length - 1; i++)
            {
                sumLeft += array[i - 1];
                sumRight -= array[i];

                if (sumLeft == sumRight)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
