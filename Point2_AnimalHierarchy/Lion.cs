using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Lion : Feline
    {
        public Lion(string food, string size, string origin, string furColor) : base(food, size, origin, furColor)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I'm a Lion and I eat: " + Food);
        }

        public override void DoNoice()
        {
            base.DoNoice();
            Console.WriteLine("(Lion noices)\tRaaa, Raaa");
        }
    }
}
