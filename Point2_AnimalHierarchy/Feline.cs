using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Feline : Animal
    {
        string furColor;

        public Feline(string food, string size, string origin, string furColor) : base(food, size, origin)
        {
            this.furColor = furColor;
        }

        public string FurColor { get => furColor; set => furColor = value; }

        public override void DoNoice()
        {
            Console.WriteLine("");
        }

        public override void Eat()
        {
            Console.WriteLine("");
        }

        public override void Show()
        {
            base.Show();
            Console.Write("Fur Color:\t" + FurColor);
        }
    }
}
