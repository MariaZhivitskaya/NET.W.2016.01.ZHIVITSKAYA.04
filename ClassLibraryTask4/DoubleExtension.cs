using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTask4
{
    public class DoubleExtension
    {
        /// <summary>
        /// Obtains the binary representation of a real number 
        /// in the IEEE double precision format 754. 
        /// </summary>
        /// <param name="number">A number to be converted.</param>
        /// <returns>Returns a representation of the number 
        /// (as a string)</returns>
        public static string DoubleToIEEE754(double number)
        {
            var bits = new BitArray(BitConverter.GetBytes(number));
            var ieeeNumber = new StringBuilder(64);

            for (var i = bits.Length - 1; i >= 0; i--)
            {
                ieeeNumber.Append(bits[i] ? '1' : '0');
            }

            return ieeeNumber.ToString();
        }

    }
}
