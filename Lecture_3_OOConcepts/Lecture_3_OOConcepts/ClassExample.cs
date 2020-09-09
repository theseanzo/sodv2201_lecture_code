using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    #region Rectangle
    class Rectangle //class name
    {
        static int numberOfRectangles = 0; //static is not instantiated
        public float height;  //data member
        public float width;
        public Rectangle()
        {
            numberOfRectangles++;
        }
        public Rectangle(float _width, float _height)
        {
            this.width = _width;
            this.height = _height;
            numberOfRectangles++;
        }
        public float CalcArea() //method
        {
            return this.width * this.height;
        }
        public float Width
        {
            get { return this.width; }
            set
            {
                this.width = value;
                Console.WriteLine("we changed the width!");
            }
        }
            
        public void setWidth(float _width)
        {
            this.width = _width;
            Console.WriteLine("We changed the width!");
        }
        public float getWidth()
        {
            return this.width;
        }
    }
    #endregion
}
