using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsSolutions
{
    public class IsNumberDivisible
    {
        public static bool IsDivisible(int n, int x, int y)
        {

            bool result = n % x == 0 && n % y == 0 ? true : false;
            return result;
        }
    }
}
