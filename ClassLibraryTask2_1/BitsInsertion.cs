using System;
using System.Collections;

namespace ClassLibraryTask2_1
{
    public class BitsInsertion
    {
        private const int BitsLength = sizeof (int) * 8;

        /// <summary>
        /// Inserts one number into another
        /// so that the second number occupies the position from
        /// a left bit to a right bit (bits are numbered from right
        /// to left).
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if bits are wrong.</exception>
        /// <param name="number1">A number to be inserted in.</param>
        /// <param name="number2">An inserted number.</param>
        /// <param name="rightBit">A right bit.</param>
        /// <param name="leftBit">A left bit.</param>
        /// <returns>Returns the resulting number.</returns>
        public static int Insertion(int number1, int number2, int rightBit, int leftBit)
        {
            if (rightBit > leftBit || 
                rightBit < 0 || rightBit > BitsLength ||
                leftBit < 0 || leftBit > BitsLength)
                throw new ArgumentException("Wrong bits!");

            var bits1 = new BitArray(new [] { number1 });
            var bits2 = new BitArray(new [] { number2 });

            int position = GetPosition(bits2);

            Insert(leftBit, rightBit, position, bits1, bits2);

            var arr = new int[1];
            bits1.CopyTo(arr, 0);

            return arr[0];
        }

        /// <summary>
        /// Finding the starting position of significant bits in 
        /// the second number.
        /// </summary>
        /// <param name="bitArray">An array for finding.</param>
        /// <returns>Returns the starting position of significant bits.</returns>
        private static int GetPosition(BitArray bitArray)
        {
            for (var i = bitArray.Length - 1; i >= 0; i--)
                if (bitArray.Get(i))
                    return i;

            return 0;
        }

        /// <summary>
        /// If the number of bits of the second number
        /// is greater or equal than the the length of insertion,
        /// inserting bits of the second number into the first number
        /// otherwise, filling the remaining place with 0-bits.
        /// </summary>
        /// <param name="leftBit">A left bit.</param>
        /// <param name="rightBit">A right bit.</param>
        /// <param name="position">A starting position of significant bits in 
        /// a BitArray2.</param>
        /// <param name="bitArray1">Bits of number to be inserted in.</param>
        /// <param name="bitArray2">>Bits of inserted number.</param>
        private static void Insert(int leftBit, int rightBit, int position,
            BitArray bitArray1, BitArray bitArray2)
        {
            if (position >= leftBit - rightBit)
                for (int i = rightBit; i <= leftBit; i++)
                    bitArray1.Set(i, bitArray2.Get(position--));
            else
            {
                int counter = 0;

                for (int i = rightBit; position >= 0; i++)
                {
                    bitArray1.Set(i, bitArray2.Get(position--));
                    counter++;
                }

                for (int i = counter; i <= rightBit - leftBit; i++)
                    bitArray1.Set(i, false);
            }
        }
    }
}
