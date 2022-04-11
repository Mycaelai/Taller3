using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Tiger : Feline
    {
        public Tiger(string food, string size, string origin, string furColor) : base(food, size, origin, furColor)
        {
            Tag = "Tiger";
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a Tiger and I eat: " + Food + "\n");
        }

        public override void DoNoice()
        {
            Console.WriteLine("Tiger noices:\tRoar, Roar"); //holass
        }
    }
}
