using System;
using System.Collections.Generic;

/*
 Enunciado:
- Todos los animales pueden comer, pero cada uno come de forma diferente
- Todos los animales están despiertos o dormidos (estado)
- Todos los animales hacen un ruido, pero cada uno lo hace un ruido diferente
- Solo las mascotas (gatos o perros):
o Tienen un nombre
o Pueden ser vacunados: a los perros se les vacuna de forma subcutánea, a los gatos
de forma inocular
o Pueden ser bañados: a los perros con champú, a los gatos con jabón

Crear un menú que permita:
- Crear felinos o caninos
- Si se elige felinos debe permitir crear leones, tigres, o gatos
- Si se elige caninos debe permitir crear perros o lobos
- Ver el ruido que hace cada animal.
- Ver el nombre de las mascotas creadas, su origen, lo que pueden comer, y su tamaño.
- Ver los animales que están dormidos o despiertos, (despiertos estado=1; dormidos
estado=0)
- El programa termina cuando el usuario elija la opción salir. 

 */

namespace Point2_AnimalHierarchy
{
    interface IPet
    {
        static string Status = "Pet";
        public void Vaccinate();
        public void Bath();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool flag = false;
            string n1, n2, n3, n4;

            string[] animalSizes = { "Small","Small-medium","Medium","Big"};
            string[] felineFood = { "Whiskas" , "Salmon" , "Tuna" , "Chiken" , "Suplements"};
            string[] canineFood = { "Red Meat" , "Lamb" , "Vitamins" , "Hills" , "Pork"};
            string[] origins = { "South-America" , "North-America" , "Europe" , "Asia" , "Africa" , "Oceania"};
            string[] fur = { "Tabby", "Solid" , "Bicolor" , "Tricolor" , "Colorpoint" , "Shiny"};
            string[] claws = { "Small", "Small-medium", "Medium", "Big" };

            Random random = new Random();
            List<Animal> animals = new List<Animal>();
            
            do
            {
                //switch para la creacion de los animales, se va a trabajar con switch dentro de switch de momento
                //Alabada sean las Gachas
                Console.WriteLine("Welcome to Build a Pet Workshop\nHere you can pick if you want to have an animal, like a gacha");
                Console.WriteLine("1)\tAdd a Feline Animal.\n2)\tAdd a Canine Animal.\n3)\tManage Animals.\n4)\tGet out of the store.");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Congrats you decide to add a feline please pick up between this variants:");
                        Console.WriteLine("1)\tTiger\n2)\tLion\n3)\tCat");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                Tiger tiger;
                                tiger = new Tiger(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)]);
                                animals.Add(tiger);
                                tiger.Show();
                                tiger.Eat();
                                tiger.DoNoice();
                                break;

                            case 2:
                                Lion lion;
                                lion = new Lion(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)]);
                                animals.Add(lion);
                                lion.Show();
                                lion.Eat();
                                lion.DoNoice();
                                break; 

                            case 3:
                                Console.WriteLine("This is a domestic specie, so you need to add a name");
                                Cat cat;
                                Console.Write("Add name:\t");
                                n1 = Console.ReadLine();
                                cat = new Cat(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)],n1);
                                animals.Add(cat);
                                cat.Show();
                                cat.Eat();
                                cat.DoNoice();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Congrats you decide to add a canine please pick up between this variants:");
                        Console.WriteLine("1)\tWolf\n2)\tDog");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                Wolf wolf;
                                wolf = new Wolf(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],claws[random.Next(claws.Length)]);
                                animals.Add(wolf);
                                wolf.Show();
                                wolf.Eat();
                                wolf.DoNoice();
                                break;

                            case 2:
                                Console.WriteLine("This is a domestic specie, so you need to add a name");
                                Dog dog;
                                Console.Write("Add name:\t");
                                n1 = Console.ReadLine();
                                dog = new Dog(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],claws[random.Next(claws.Length)],n1);
                                animals.Add(dog);
                                dog.Show();
                                dog.Eat();
                                dog.DoNoice();
                                break;
                        }
                        break;

                    case 3:
                        Console.Write("Space to Manage Animals");
                        break;

                    case 4:
                        Console.Write("You have exited the program, Sayonara");
                        flag = true;
                        break;
                }    

            } while (!flag);
        }
    }
}
