using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_Exceptions
{
    #region Abstract Refresher
    //Remember from last class
    public abstract class Dog //abstract class is like a promise to implement these things
    {
        public virtual void Bark()
        {
            Console.WriteLine("Woof");
        }
        public abstract void Walk();
        public abstract void Sit();

    }
    public class Shiba : Dog
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
    #endregion
    #region Interfaces
    //Interfaces define the way in which you can interact with an object
    //they have methods and properties, but contain no data members or function implementations
    //interfaces are basically a contract that a class must adhere to.
    //interface methods are not virtual and so do not need to be overriden
    public interface DogBehaviour
    {
        void Bark();
        void Walk();
        void Sit();
    }
    public interface CatBehaviour
    {
        void Meow();
        void Purr();
        void AttackAnkles();
    }
    public class GoldenRetriever: DogBehaviour
    {
        public void Bark()
        {
            Console.WriteLine("Woof!");

        }
        public void Walk()
        {
            Console.WriteLine("Walk!");
        }
        public void Sit()
        {
            Console.WriteLine("Sitting like a good boy");
        }
    }
    #endregion

}
