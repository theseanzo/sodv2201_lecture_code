using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    class OverloadingExample
    {
        class Sum
        {
            public int GetSum()
            {
                return 0;
            }
            public int GetSum(int num)
            {
                return num;
            }
            public int GetSum(int num0, int num1)
            {
                return num0 + num1;
            }

        }
    }
}
