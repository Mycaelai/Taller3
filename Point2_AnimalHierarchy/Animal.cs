using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    abstract class Animal
    {
        string food, size, origin, tag;
        bool state;

        public string Food { get => food; set => food = value; }
        public string Size { get => size; set => size = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Tag { get => tag; set => tag = value; }
        public bool State { get => state; set => state = value; }

        protected Animal(string food, string size, string origin)
        {
            this.food = food;
            this.size = size;
            this.origin = origin;
            state = false;
        }

        public abstract void Eat();
        public abstract void DoNoice();

        public virtual void Show()
        {
            Console.WriteLine("Specie:\t\t" + Tag);
            if (State == false)
            {
                Console.WriteLine("Status:\t\tSleep");
            }
            else
            {
                Console.WriteLine("Status:\t\tAwake");
            }
            Console.WriteLine("Origin:\t\t" + Origin);
            Console.WriteLine("Size:\t\t" + Size);
        }
        public void ModifyState()
        {
            int i = 0;
            //Indicador estado de los animales, {0} es dormido y {1} es despierto
            if (state == true)
                Console.WriteLine("State: Awake");
            else
                Console.WriteLine("State: Sleep");

            Console.WriteLine("Do want to change the state of the Animal\n1)\tYes\n2)\tNo");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    if (state == false)
                    {
                        state = true;
                        Console.WriteLine("State: Awake");
                    }
                    else
                    {
                        state = false;
                        Console.WriteLine("State: Sleep");
                    }
                    break;

                case 2:
                    Console.WriteLine("Bye then");
                    break;
            }
        }
    }
}
