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

        public Dog(string food, string size, string origin, string clawsSize, string name, string sleepState) : base(food, size, origin, clawsSize, sleepState)
        {
            this.name = name;
            Tag = "Dog";
        }

        public void Bath()
        {
            Console.WriteLine(Tag + " is bath with: \tShampu");
        }

        public void Vaccinate()
        {
            Console.WriteLine("You have inoculate vaccinated " + name);
        }

        public override void Eat()
        {
            Console.WriteLine("I'm a Dog and I'm feed with: " + Food + "\n");
        }

        public override void DoNoice()
        {
            Console.WriteLine("Dog noices:\tRaaa, Raaa");
        }

        public override void Show()
        {
            Console.WriteLine("Name:\t\t" + name + "\nStatus:\t\t" + IPet.Status);
            //No quitar el base, esta es la referncia al metodo Show de la Clase Canino
            base.Show();
        }
    }
}
