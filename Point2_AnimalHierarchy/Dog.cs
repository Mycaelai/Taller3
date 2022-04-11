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

        public Dog(string food, string size, string origin, string clawsSize, string name) : base(food, size, origin, clawsSize)
        {
            this.name = name;
            Tag = "Dog";
        }

        public void Bath()
        {
            Console.WriteLine("Dog bath with shampu");
        }

        public void Vaccinate()
        {
            Console.WriteLine("You have inoculate vaccinated " + name);
        }

        public override void Eat()
        {
            base.Eat();
            Console.Write("I'm a Dog and I'm feed with: " + Food);
        }

        public override void DoNoice()
        {
            base.DoNoice();
            Console.WriteLine("(Dog noices)\tRaaa, Raaa\n");
        }

        public override void Show()
        {
            Console.WriteLine("Name:\t" + name);
            base.Show();
        }
    }
}
