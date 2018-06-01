using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    public static class Math
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

        /// <summary>
        /// I don't know why.
        /// </summary>
        /// <returns>PI</returns>
        public static string PI
        {
            get
            {
                long a = 10000, b = 0, c = 2800, d = 0, e = 0;
                long[] f = new long[2801];

                for(int i = 0; i < 2800; i++)
                    f[i] = 2000;

                f[2800] = 0;

                StringBuilder sb = new StringBuilder();
                for(c = 2800; c > 0; c -= 14)
                {
                    d = 0;
                    for(b = c; b > 0; b--)
                    {
                        d += f[b] * a;
                        f[b] = d % (2 * b - 1);
                        d /= (2 * b - 1);
                        if(b > 1)
                            d *= (b - 1);
                    }
                    sb.AppendFormat("{0:D4}", e + d / a);
                    e = d % a;
                }
                return sb.Insert(1, ".").ToString();
            }
        }
    }
}
