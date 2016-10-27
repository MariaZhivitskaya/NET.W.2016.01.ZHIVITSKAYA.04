using System;

namespace ClassLibraryTask3
{
    public class NewtonsMethod
    {
        /// <summary>
        /// Counts an n-th root of the number
        /// with the given accuracy.
        /// </summary>
        /// <param name="number">A number for counting an n-th root.</param>
        /// <param name="degree">The value of n.</param>
        /// <param name="precision">The exact number of decimal places.</param>
        /// <returns>Returns the resulting number.</returns>
        public static double CountRoot(double number, double degree, int precision)
        {
            if (precision > 16 || precision < 1)
            {
                throw new Exception("Wrong precision!");
            }

            if (number < 0 && (degree > 1 && (int)degree%2 == 0))
            {
                throw new Exception("Impossible to take an aliquot root " +
                                    "from a negative number!");
            }


            if (degree.Equals(0.0) && number.Equals(0.0))
            {
                throw new Exception("Uncertainty (zero in the zero degree)!");
            }

            var xCur = number;
            double xPrev;
            var eps = Math.Pow(10, -(precision + 1));

            do
            {
                xPrev = xCur;
                xCur = ((degree - 1) * xPrev + 
                    number / Math.Pow(xPrev, degree - 1)) / degree;
            } while (Math.Abs(xCur - xPrev) > eps);

            return xCur;
        }
    }
}
