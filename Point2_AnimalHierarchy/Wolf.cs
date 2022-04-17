using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Wolf : Canine
    {
        public Wolf(string food, string size, string origin, string clawsSize, string sleepState) : base(food, size, origin, clawsSize, sleepState)
        {
            Tag = "Wolf";
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a Wolf and I eat: " + Food + "\n");
        }

        public override void DoNoice()
        {
            Console.WriteLine("Wolf noices:\tHowl, Howl");
        }
    }
}
