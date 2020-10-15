using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Delegates
{
    abstract class Animal
    {
        public void RunAway()
        {
            Console.WriteLine("Roaring is scary, so I am running away");
        }
    }
    class Lion : Animal {
        public delegate void RoarListener();
        public RoarListener roarListener;
        public void AddRoarListener(RoarListener listener)
        {
            roarListener += listener;
        }

        public void RemoveRoarListener(RoarListener listener)
        {
            roarListener -= listener;
        }
        public void Roar()
        {
            Console.WriteLine("Roar");
            roarListener();
        }
    }
    class Zebra : Animal
    {
        public void MeetLion(Lion lion)
        {
            lion.AddRoarListener(this.RunAway);
        }
    }
    class Gazelle : Animal
    {
        public void MeetLion(Lion lion)
        {
            lion.AddRoarListener(this.RunAway);
        }
    }
}
