using System;
using System.Collections;

namespace ClassLibraryTask2_1
{
    public class BitsInsertion
    {
        /// <summary>
        /// Inserts one number into another
        /// so that the second number occupies the position from
        /// a left bit to a right bit (bits are numbered from right
        /// to left).
        /// </summary>
        /// <param name="number1">A number to be inserted in.</param>
        /// <param name="number2">An inserted number.</param>
        /// <param name="rightBit">A right bit.</param>
        /// <param name="leftBit">A left bit.</param>
        /// <returns>Returns the resulting number.</returns>
        public static int Insertion(int number1, int number2, int rightBit, int leftBit)
        {
            if (rightBit > leftBit || 
                rightBit < 0 || rightBit > 32 ||
                leftBit < 0 || leftBit > 32)
            {
                throw new Exception("Wrong bits!");
            }

            var bits1 = new BitArray(new [] { number1 });
            var bits2 = new BitArray(new [] { number2 });

            var getPosition = 0;

            //Finding the starting position of significant bits in 
            //the second number
            for (var i = bits2.Length - 1; i >= 0; i--)
            {
                if (!bits2.Get(i))
                {
                    continue;
                }

                getPosition = i;
                break;
            }

            //if the number of bits of the second number
            //is greater or equal than the the length of insertion
            //inserting bits of the second number into the first number
            //otherwise, filling the remaining place with 0-bits
            if (getPosition >= leftBit - rightBit)
            {
                for (int i = rightBit, j = getPosition; i <= leftBit; i++)
                {
                    bits1.Set(i, bits2.Get(getPosition--));
                }
            }
            else
            {
                var counter = 0;

                for (int i = rightBit, j = getPosition; getPosition >= 0; i++)
                {
                    bits1.Set(i, bits2.Get(getPosition--));
                    counter++;
                }

                for (var i = counter; i <= rightBit - leftBit; i++)
                {
                    bits1.Set(i, false);
                }
            }

            

            var arr = new int[1];
            bits1.CopyTo(arr, 0);

            return arr[0];
        }
    }
}
