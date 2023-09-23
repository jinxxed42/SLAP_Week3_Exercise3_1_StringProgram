using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAP_Week3_Exercise3_1_StringProgram
{
    public static class Str
    {
        // Names, comments and method summaries are copied directly from the Exercise text.


        /// <summary>
        /// Method which cuts off a string of specific length n.
        /// If the string length is less than or equal n, the operation is
        /// ignored and the string is returned unchanged.
        /// </summary>
        /// <param name="s">The string that must be cut off</param>
        /// <param name="n">The length of the resulting string</param>
        /// <returns>The string cut off to length n</returns>
        public static string Cut(this string s, int n)
        {
            if (n > s.Length) return s;
            return s.Substring(0, n);
        }

        /// <summary>
        /// Method as left adjusts a string in a field of width n.
        /// If the string length is greater than n,
        /// the operation is ignored and the string is returned unchanged. Else the
        /// string is padded with the char c.
        /// </summary>
        /// <param name="s">The string that needs to be adjusted</param>
        /// <param name="n">The width of the field</param>
        /// <param name="c">The padding char that field
        /// has to be filled with</param>
        /// <returns>The string left adjusted in a field of width n</returns>
        public static string Left(this string s, int n, char c)
        {
            if (n > s.Length) return s;
            return $"{new string(c, n)}{s}";
        }

        /// <summary>
        /// Method as right adjusts a string in a field of width n.
        /// If the string length is greater than n,
        /// the operation is ignored and the string is returned unchanged. Else the
        /// string is padded with the char c.
        /// </summary>
        /// <param name="s">The string that needs to be adjusted</param>
        /// <param name="n">The width of the field</param>
        /// <param name="c">The padding char that field
        /// has to be filled with</param>
        /// <returns>The string right adjusted in a field of width n</returns>
        public static string Right(this string s, int n, char c)
        {
            if (n > s.Length) return s;
            return $"{s}{new string(c, n)}";
        }

        /// <summary>
        /// Method as center adjusts a string in a field of width n.
        /// If the string length is greater than n,
        /// the operation is ignored and the string is returned unchanged. Else the
        /// string is padded from left and 
        /// right with the char c.
        /// </summary>
        /// <param name="s">The string that needs to be adjusted</param>
        /// <param name="n">The width of the field</param>
        /// <param name="c">The padding char that field
        /// has to be filled with</param>
        /// <returns>The string center adjusted in a field of width n</returns>
        public static string Center(this string s, int n, char c)
        {
            if (n > s.Length) return s;
            return $"{new string(c, n)}{s}{new string(c, n)}";
        }

        /// <summary>
        /// Method which removes all characters with a certain value from a
        /// string.
        /// </summary>
        /// <param name="text">The text where to remove characters</param>
        /// <param name="ch">The character to be removed</param>
        /// <returns>The string text after all the characters with the value ch
        /// are removed</returns>
        public static string Clear(this string text, char ch)
        {
            // return text.Clear(ch); // Clear already exists, but for a more "manual" implementation.
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ch) sb.Append(text[i]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// Method which splits a string into tokens
        /// where the array sep contains strings
        /// used to separate tokens. The method returns
        /// a list with the tokens found and
        /// two bool parameters indicates where empty
        /// tokens must be interpreted as tokens
        /// and where the separator strings should be interpreted as tokens.
        /// </summary>
        /// <param name="text">The string to be split into tokens</param>
        /// <param name="noempty">If true empty tokens are ignored</param>
        /// <param name="astokens">If true the separator strings are used as 
        /// tokens</param>
        /// <param name="sep">A list containing the tokens</param>
        /// <returns></returns>
        public static List<string> Split(this string text, bool noempty, bool astokens, params string[] sep)
        {
            List<string> strings = new();

            // RemoveEmptyEntries in case we separate for the last token to avoid an empty token
            strings = text.Split(sep, StringSplitOptions.RemoveEmptyEntries).ToList();

            if (noempty) strings.RemoveAll(string.IsNullOrWhiteSpace);

            if (astokens)
            {
                foreach (string s in sep)
                {
                    if (text.Contains(s))
                    {
                        strings.Add(s);
                    }
                }
            }

            return strings;
        }
    }
}

