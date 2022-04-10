using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Wolf : Canine
    {
        public Wolf(string food, string size, string origin, string clawsSize) : base(food, size, origin, clawsSize)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I'm a Wolf and I feed myself with: ");
        }

        public override void DoNoice()
        {
            base.DoNoice();
            Console.WriteLine("(Wolf noices)\tHowl, Howl");
        }
    }
}
