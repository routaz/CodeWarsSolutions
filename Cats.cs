using System;
using System;
using System.Collections.Generic;

namespace CodeWarsSolutions
{
    public class Cats
    {
        public static int Catss(int start, int finish)
        {
            var jumps = ((finish - start) / 3.0f);
            jumps = (int)Math.Ceiling(jumps);

            bool isOnSameSide = finish % 2 == start % 2;

            if(isOnSameSide && jumps % 2 ==1)
                jumps++;

            if (!isOnSameSide && jumps % 2 == 0)
                jumps++;

            return (int)jumps;
        }

    }
}

//Very cool solution!!!
/*
 var diff = finish - start;
    return diff / 3 + diff % 3;
*/