using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.String
{
    public static class String
    {
        /// <summary>
        /// convert all English strings to uppercase letters
        /// </summary>
        /// <param name="s">input</param>
        /// <returns>uppercase string</returns>
        public static string ToUpper(string s)
        {
            char[] chars = s.ToArray();
            for(int i = 0; i < chars.Length; i++)
                chars[i] = ToUpper(chars[i]);

            return new string(chars);
        }

        /// <summary>
        /// convert all English strings to lowercase letters
        /// </summary>
        /// <param name="s">input</param>
        /// <returns>lowercase string</returns>
        public static string ToLower(string s)
        {
            char[] chars = s.ToArray();
            for(int i = 0; i < chars.Length; i++)
                chars[i] = ToLower(chars[i]);

            return new string(chars);
        }

        private static char ToUpper(char c)
        {
            if('a' <= c && c <= 'z')
                c = (char)(c & ~0x20);
            return c;
        }

        private static char ToLower(char c)
        {
            if('A' <= c && c <= 'Z')
                c = (char)(c | 0x20);
            return c;
        }
    }
}
