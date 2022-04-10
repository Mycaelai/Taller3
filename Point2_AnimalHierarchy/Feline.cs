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

        public override void DoNoice()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }
    }
}
