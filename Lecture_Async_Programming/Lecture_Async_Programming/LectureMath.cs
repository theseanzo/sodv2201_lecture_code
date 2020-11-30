using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Async_Programming
{
    static class LectureMath
    {
        public static long NextPrime(long number)
        {
            for(long i = number + 1; i < 2 * number; i++)
            {
                bool prime = true;
                for(long j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    return i;
                }
              
            }
            return -1;
        }
    }
}
