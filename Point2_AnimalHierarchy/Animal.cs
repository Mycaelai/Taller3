using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point2_AnimalHierarchy
{
    abstract class Animal
    {
        //Atributos string
        private string food, size, origin, tag, sleepState;
        //Estado del Sueño
        private bool state;

        //Encapsulamiento de todas las propiedades

        public bool State { get => state; set => state = value; }
        public string Food { get => food; set => food = value; }
        public string Size { get => size; set => size = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Tag { get => tag; set => tag = value; }
        public string SleepState { get => sleepState; set => sleepState = value; }

        protected Animal(string food, string size, string origin,string sleepState)
        {
            this.Food = food;
            this.Size = size;
            this.Origin = origin;
            this.SleepState = sleepState;
            //Todos los animales se spawnean Dormidos
            state = false;
        }

        //Metodos Abstractos
        public abstract void Eat();
        public abstract void DoNoice();

        //Visualizador
        public virtual void Show()
        {
            Console.WriteLine("Specie:\t\t" + Tag);
            Console.WriteLine("Satus:\t\t" + sleepState);
            Console.WriteLine("Origin:\t\t" + Origin);
            Console.WriteLine("Size:\t\t" + Size);
        }
        public void ModifyState()
        {
            int i = 0;
            //Indicador estado de los animales, {0} es dormido y {1} es despierto
            //Aca se indica el estado de los animales
            if (state == true)
                Console.WriteLine("State: Awake");
            else
                Console.WriteLine("State: Sleep");

            Console.WriteLine("Do want to change the state of the Animal\n1)\tYes\n2)\tNo");
            i = Convert.ToInt32(Console.ReadLine());
            //Switch de cambio de estado
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
