using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Math
{
    public class Math
    {
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
    }
}
