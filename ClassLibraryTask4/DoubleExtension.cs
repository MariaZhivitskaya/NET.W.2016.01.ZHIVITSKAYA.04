using System;
using System.Collections;
using System.Text;

namespace ClassLibraryTask4
{
    public static class DoubleExtension
    {
        private const int DoubleSize = sizeof (double) * 8;

        /// <summary>
        /// Obtains the binary representation of a real number 
        /// in the IEEE double precision format 754. 
        /// </summary>
        /// <param name="number">A number to be converted.</param>
        /// <returns>Returns a representation of the number 
        /// (as a string).</returns>
        public static string DoubleToIEEE754(this double number)
        {
            var bits = new BitArray(BitConverter.GetBytes(number));
            var ieeeNumber = new StringBuilder(DoubleSize);

            for (var i = bits.Length - 1; i >= 0; i--)
                ieeeNumber.Append(bits[i] ? '1' : '0');

            return ieeeNumber.ToString();
        }
    }
}
