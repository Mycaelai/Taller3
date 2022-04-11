using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    class Canine : Animal
    {
        string clawsSize;
        public Canine(string food, string size, string origin, string clawsSize) : base(food, size, origin)
        {
            this.clawsSize = clawsSize;
        }

        public string ClawsSize { get => clawsSize; set => clawsSize = value; }

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
