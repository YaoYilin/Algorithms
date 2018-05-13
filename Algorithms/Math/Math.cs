using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    public class Math
    {
        /// <summary>
        /// calculate the square value of a positive number greater than 0
        /// </summary>
        /// <param name="x">input</param>
        /// <returns>sqrt</returns>
        public static uint Sqrt(uint x)
        {
            uint m = 0x40000000, y = 0, b;
            while(m != 0)
            {
                b = y | m;
                y >>= 1;
                if(x >= b)
                {
                    x -= b;
                    y |= m;
                }
                m >>= 2;
            }
            return y;
        }

        /// <summary>
        /// calculate the absolute value of a number
        /// </summary>
        /// <param name="x">input</param>
        /// <returns>absolute value</returns>
        public static int Abs(int x)
        {
            return ((x >> 30) | 1) * x;
        }

        /// <summary>
        /// calculate the average of two numbers
        /// </summary>
        /// <param name="x">input a</param>
        /// <param name="y">input b</param>
        /// <returns>averange</returns>
        public static int Averange(int x, int y)
        {
            // floor
            return (x & y) + ((x ^ y) >> 1);
            // ceil
            //return (x | y) - ((x ^ y) >> 1);
        }

        /// <summary>
        /// gets a symbol of a number, greater than 0 returns 1, less than 0 returns-1, equals 0 returns 0
        /// </summary>
        /// <param name="x"></param>
        /// <returns>symbol</returns>
        public static int Sign(int x)
        {
            return -(-x >> 31) | (x >> 31);
        }
    }
}
