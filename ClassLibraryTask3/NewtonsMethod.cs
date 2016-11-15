using System;

namespace ClassLibraryTask3
{
    public class NewtonsMethod
    {
        private static readonly double MaxPrecision = Math.Pow(10, -sizeof(double) * 8);

        /// <summary>
        /// Counts an n-th root of the number
        /// with the given accuracy.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown if parameters are wrong.</exception>
        /// <param name="number">The number for counting an n-th root.</param>
        /// <param name="power">The value of n.</param>
        /// <param name="precision">The precision.</param>
        /// <returns>Returns the resulting number.</returns>
        public static double CountRoot(double number, int power, double precision)
        {
            if (precision < MaxPrecision || precision > 0.1)
                throw new ArgumentException("Wrong precision!");

            if (power < 0)
                throw new ArgumentException("Wrong power!");

            if (number < 0 && power%2 == 0)
                throw new ArgumentException("Impossible to take an aliquot root " +
                                    "from a negative number!");

            double xCur = number;
            double xPrev;
            
            do
            {
                xPrev = xCur;
                xCur = ((power - 1) * xPrev + 
                    number / Math.Pow(xPrev, power - 1)) / power;
            } while (Math.Abs(xCur - xPrev) > precision);

            return xCur;
        }
    }
}
