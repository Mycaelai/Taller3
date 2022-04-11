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
            //No quitar el base, esta es la referncia al metodo Show de la Clase Animal
            base.Show();
            Console.WriteLine("Fur Color:\t" + FurColor);
            DoNoice();
            Eat();
        }
    }
}
