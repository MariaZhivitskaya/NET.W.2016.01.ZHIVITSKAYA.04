using System;
using System.Linq;
using System.Text;

namespace ClassLibraryTask2
{
    public class StringsHandler
    {
        /// <summary>
        /// Concatenates and sorts two strings
        /// excluding duplicate symbols.
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown if strings are 
        /// null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown if strings don't
        /// consist of numbers.</exception>
        /// <param name="a">The string consisting of symbols
        /// from 'a' to 'z'. </param>
        /// <param name="b">The string consisting of symbols
        /// from 'a' to 'z'. </param>
        /// <returns>Returns the resulting string.</returns>
        public static string Longest(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
                throw new ArgumentNullException("String is null or empty!");

            if (!a.All(char.IsLetter) || !b.All(char.IsLetter))
                throw new ArgumentException("Wrong format of strings!");
            
            var res = new StringBuilder(a);
            res.Append(b);

            var chars = (a + b).ToCharArray().Distinct().ToArray();
            Array.Sort(chars);
            
            return new string(chars);
        }
    }
}
