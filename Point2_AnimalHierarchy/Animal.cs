using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    abstract class Animal
    {
        string food, size, origin;
        bool state;

        protected Animal(string food, string size, string origin)
        {
            this.food = food;
            this.size = size;
            this.origin = origin;
        }

        public abstract void Eat();
        public abstract void State();
        public abstract void DoNoice();
    }
}
