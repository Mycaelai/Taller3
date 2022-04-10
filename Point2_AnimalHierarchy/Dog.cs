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
    }
}
