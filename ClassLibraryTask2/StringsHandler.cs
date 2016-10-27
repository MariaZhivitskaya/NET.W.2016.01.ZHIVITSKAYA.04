using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ClassLibraryTask2
{
    public class StringsHandler
    {
        /// <summary>
        /// Concatenates and sorts two strings
        /// excluding duplicate symbols.
        /// </summary>
        /// <param name="a">A string consisting of symbols
        /// from 'a' to 'z'. </param>
        /// <param name="b">A string consisting of symbols
        /// from 'a' to 'z'. </param>
        /// <returns>Returns the resulting string.</returns>
        public static string Longest(string a, string b)
        {
            if (string.IsNullOrEmpty(a) || string.IsNullOrEmpty(b))
            {
                throw new ArgumentNullException();
            }

            var regex = new Regex(@"^[a-z]+$");

            if (!regex.IsMatch(a) || !regex.IsMatch(b))
            {
                throw new Exception("Wrong format of strings!");
            }

            var res = new StringBuilder();
            res.Append(a);
            res.Append(b);

            BubbleSort(res);

            return res.ToString();
        }

        /// <summary>
        /// Sorts the string and deletes duplicate symbols.
        /// </summary>
        /// <param name="str">A string for sorting.</param>
        private static void BubbleSort(StringBuilder str)
        {
            //Sorting the string
            for (var i = 0; i < str.Length; i++)
            {
                for (var j = 0; j < str.Length - i - 1 ; j++)
                {
                    if (str[j] <= (str[j + 1]))
                    {
                        continue;
                    }

                    var tmp = str[j];
                    str[j] = str[j + 1];
                    str[j + 1] = tmp;
                }
            }

            //Deleting duplicate symbols
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    continue;
                }

                var counter = 1;

                for (var j = i + 2; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                str.Remove(i + 1, counter);
            }
        }
    }
}
