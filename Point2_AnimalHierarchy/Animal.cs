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
            state = false;
        }

        public abstract void Eat();
        public abstract void DoNoice();

        public void State()
        {
            int i = 0;
            //Indicador estado de los animales, {0} es dormido y {1} es despierto
            if (state == true)
                Console.WriteLine("State: Awake");
            else
                Console.WriteLine("State: Sleep");

            Console.WriteLine("Do want to change the state of the Animal\n1)\tYes\n2)\tNo");
            switch(i)
            {
                case 1:
                    if (state == false)
                    {
                        state = true;
                        Console.WriteLine("State: " + state);
                    }
                    else
                    {
                        state = false;
                        Console.WriteLine("State: " + state);
                    }
                        
                    break;
                case 2:
                    Console.WriteLine("Bye then");
                    break;
            }
        }
    }
}
