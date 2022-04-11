using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Cat : Feline , IPet
    {
        string name;
        public Cat(string food, string size, string origin, string furColor, string name) : base(food, size, origin, furColor)
        {
            this.name = name;
            Tag = "Cat";
        }

        public void Bath()
        {
            Console.WriteLine("Cat bath with soap");
        }

        public void Vaccinate()
        {
            Console.WriteLine("You have subcutaneously vaccinated " + name);
        }

        public override void Eat()
        {
            base.Eat();
            Console.Write("I'm a Cat and I'm feed with: " + Food);
        }

        public override void DoNoice()
        {
            base.DoNoice();
            Console.WriteLine("(Cat noices)\tMeow, Meow\n");
        }

        public override void Show()
        {
            Console.WriteLine("Name:\t" + name);
            base.Show();
        }
    }
}
