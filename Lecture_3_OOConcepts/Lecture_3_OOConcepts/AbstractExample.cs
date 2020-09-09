using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_OOConcepts
{
    public abstract class Dog //abstract class is like a promise to implement these things
    {
        public abstract void Bark();
        public abstract void Walk();
        public abstract void Sit();
    }
    public class Shiba: Dog
    {
        public override void Bark()
        {
            Console.WriteLine("Whiney tiny bark");
        }
        public override void Walk()
        {
            Console.WriteLine("Tiny walk");

        }
        public override void Sit()
        {
            Console.WriteLine("Sit like a good dog");
        }
    }
    public class GermanShepard : Dog
    {
        
    }

    public abstract class CommodoreView
    {
        public abstract void acceptKeyboardInput(char key);
    }
    public class CommodoreViewActive : CommodoreView
    {
        public override void acceptKeyboardInput(char key)
        {
            //do something
        }
    }
    public class CommodoreViewNotActive : CommodoreView
    {
        public override void acceptKeyboardInput(char key)
        {
            //do nothing
        }
    }

    public class MainProgram
    {
        public MainProgram()
        {
            CommodoreView currentView = new CommodoreViewActive();
            currentView.acceptKeyboardInput('a');
        }
    }
}
