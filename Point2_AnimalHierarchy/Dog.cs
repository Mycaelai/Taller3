using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Dog : Canine , IPet
    {
        string name;

        public Dog(string food, string size, string origin, string clawsSize) : base(food, size, origin, clawsSize)
        {
        }

        public void Bath()
        {
            throw new NotImplementedException();
        }

        public void Vaccinate()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I'm a Dog and I'm feed with: ");
        }

        public override void DoNoice()
        {
            base.DoNoice();
            Console.WriteLine("(Dog noices)\tRaaa, Raaa");
        }
    }
}
