using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_2_Basics
{
    //a static class is one that cannot be instantiated
    //static classes are sealed (they cannot be inherited from)
    //they cannot contain constructors and can only contain static members

    static class MathFunctions
    {
        public static float addNumbers(float a, float b)
        {
            return a + b;
        }
        public static float subtractNumbers(float a, float b)
        {
            return a - b;
        }
    }
}
