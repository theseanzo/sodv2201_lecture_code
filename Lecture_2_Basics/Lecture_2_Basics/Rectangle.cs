using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2Class
{
    //4 access modifiers
    //public 
    //protected
    //private
    //internal
    class Rectangle
    {
        public float width = 1.0f;
        public float height = 1.0f;
        private static int amountOfBoxes = 0; //can create static members; these are shared between classes
        public Rectangle()
        {
            amountOfBoxes++;
        }
        public Rectangle(float _w, float _h)
        {
            this.width = _w;
            this.height = _h;
            amountOfBoxes++;
        }
        public static int GetAmountOfBoxes()
        {
            return amountOfBoxes;
        }
        public float CalcArea()
        {
            return this.width * this.height;
        }



    }
}