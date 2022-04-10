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
