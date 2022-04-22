using System;
using System.Collections.Generic;

/*
 Enunciado:
- Todos los animales pueden comer, pero cada uno come de forma diferente                DONE
- Todos los animales están despiertos o dormidos (estado)   DONE
- Todos los animales hacen un ruido, pero cada uno lo hace un ruido diferente           DONE
- Solo las mascotas (gatos o perros):                                                   DONE
o Tienen un nombre                                                                      DONE
o Pueden ser vacunados: a los perros se les vacuna de forma subcutánea, a los gatos
de forma inocular                                                                       DONE
o Pueden ser bañados: a los perros con champú, a los gatos con jabón                    DONE

Crear un menú que permita:
- Crear felinos o caninos                                                               DONE
- Si se elige felinos debe permitir crear leones, tigres, o gatos                       DONE
- Si se elige caninos debe permitir crear perros o lobos                                DONE
- Ver el ruido que hace cada animal.
- Ver el nombre de las mascotas creadas, su origen, lo que pueden comer, y su tamaño.   DONE
- Ver los animales que están dormidos o despiertos, (despiertos estado=1; dormidos    DONE
estado=0)
- El programa termina cuando el usuario elija la opción salir.                          DONE

 */

namespace Point2_AnimalHierarchy
{
    //Interfaz para las mascotas
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
            //Aca esta  la variable del switch, la bandera del "Do While" & el n1 para los nombres
            int i = 0;
            bool flag = false;
            string n1;

            //Aca se inicializan los arreglos de los atributos de los animales
            //Tamaño
            string[] animalSizes = { "Small", "Small-medium", "Medium", "Big" };
            //Tipo de comida. NOTA: Es diferente para caninos y felinos
            string[] felineFood = { "Whiskas", "Salmon", "Tuna", "Chiken", "Suplements" };
            string[] canineFood = { "Red Meat", "Lamb", "Vitamins", "Hills", "Pork" };
            //El origen de los animales
            string[] origins = { "South-America", "North-America", "Europe", "Asia", "Africa", "Oceania" };
            //Y los atributos del orden felino y canino. -> Pelaje & Garras
            string[] fur = { "Tabby", "Solid" , "Bicolor" , "Tricolor" , "Colorpoint" , "Shiny"};
            string[] claws = { "Small", "Small-medium", "Medium", "Big" };
            string[] sleepState = { "Asleep", "WOKE"};

            //Creacion de la lista de animales
            List<Animal> animals = new List<Animal>();
            List<IPet> pets = new List<IPet>();

            Random random = new Random();

            do
            {
                //Switch del Menu
                //Alabada sean las Gachas
                Console.WriteLine("\nWelcome to Build a Pet Workshop\nHere you can pick if you want to have an animal, like a gacha");
                Console.WriteLine("1)\tAdd a Feline Animal.\n2)\tAdd a Canine Animal.\n3)\tManage Animals.\n4)\tGet out of the store.");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        //Creacion de Felinos
                        Console.WriteLine("\nCongrats you decide to add a Feline please pick up between this variants:");
                        Console.WriteLine("1)\tTiger.\n2)\tLion.\n3)\tCat.");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                //Instanciamos
                                Tiger tiger;
                                //Asignamos los atributos con el {random}, y los respectivos arreglos correspondientes por categoria, {food,size,origin,fur(solo para felino)}
                                tiger = new Tiger(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)], sleepState[random.Next(sleepState.Length)]);
                                //Adicionamos el animal a la lista
                                animals.Add(tiger);
                                //Mostramos la informacion del animal
                                tiger.Show();
                                break;

                            case 2:
                                Lion lion;
                                lion = new Lion(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)], sleepState[random.Next(sleepState.Length)]);
                                animals.Add(lion);
                                lion.Show();
                                break; 

                            case 3:
                                Console.Write("This is a domestic specie, so you need to add a name:\t");
                                Cat cat;
                                //Los Animales dosmesticos requieren nombre, por lo que aca se le pide al usuario
                                n1 = Console.ReadLine();
                                cat = new Cat(felineFood[random.Next(felineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],fur[random.Next(fur.Length)], n1, sleepState[random.Next(sleepState.Length)]);
                                animals.Add(cat);
                                pets.Add(cat);
                                cat.Show();
                                break;
                        }
                        break;

                    case 2:
                        //Creacion de Caninos
                        Console.WriteLine("\nCongrats you decide to add a Canine please pick up between this variants:");
                        Console.WriteLine("1)\tWolf\n2)\tDog");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                Wolf wolf;
                                //  {food,size,origin,claws(solo para canino)}
                                wolf = new Wolf(canineFood[random.Next(canineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],claws[random.Next(claws.Length)], sleepState[random.Next(sleepState.Length)]);
                                animals.Add(wolf);
                                wolf.Show();
                                break;

                            case 2:
                                Console.WriteLine("This is a domestic specie, so you need to add a name:\t");
                                Dog dog;
                                n1 = Console.ReadLine();
                                dog = new Dog(canineFood[random.Next(canineFood.Length)],animalSizes[random.Next(animalSizes.Length)],origins[random.Next(origins.Length)],claws[random.Next(claws.Length)], n1, sleepState[random.Next(sleepState.Length)]);
                                animals.Add(dog);
                                pets.Add(dog);
                                dog.Show();
                                break;
                        }
                        break;

                    case 3:
                        //Maya Aca es la opcion para que implementes los puntos que faltan, todo lo que tiene DONE en la parte de arriba del documento esta hecho (Borra esto cuando lo hagas)
                        /*
                         Ver el ruido
                         Ver elementos de las mascotas, entonces para eso puedes utilizar el Tag que puso, entonces asi emperejas con eso
                         Una opcion para cambiar el estado de dormir a despierto y viceversa, el metodo ya esta implementado, asi que es mas por menu
                         Los animales domesticos tiene acciones propias entoces hacerlas accesibles (Vacunar & Bañar)
                         Puedes hacer una lista enorme o con switches dentro switches, si es asi mi recomendacion es que diferencies las opciones para domesticos
                         */
                        Console.WriteLine("\nSelect an option");
                        Console.WriteLine("\n1)\tShow the noises of each animal.\n2)\tShow the name and characteristics of each animal and if they are asleep or awake.\n3)\tManage Domestic necesities (Bathing and Vaccinating). ");
                        i = Convert.ToInt32(Console.ReadLine());

                        switch (i)
                        {
                            case 1:
                                foreach( Animal item in animals)
                                {
                                    item.DoNoice();
                                }
                                break;

                            case 2:
                                foreach (Animal item in animals)
                                {
                                    item.Show();
                                }
                                break;

                            case 3:
                                Console.WriteLine("\nSelect an option, be wary that we vaccinate and bath in full batches, so we will apply this decision for all domestic animals"); //En realidad el enunciado no encontré que pidiera en el menú poder vacunarlos y bañarlos, entonces por simpleza los puse en baches.
                                Console.WriteLine("\n1)\t Vaccinate all domestic animals .\n2)\t Bath all animals.\n");
                                i = Convert.ToInt32(Console.ReadLine());
                                switch (i)
                                {
                                    case 1:
                                        foreach(IPet item in pets)
                                        {
                                            
                                            item.Vaccinate();
                                        }
                                        break;

                                    case 2:
                                        foreach( IPet item in pets)
                                        {
                                            item.Bath();
                                        }
                                        break;
                                }
                             break;

                        }
                        break;
                       

                    case 4:
                        //Salida del programa
                        Console.Write("You have exited the program, Sayonara");
                        flag = true;
                        break;
                }
                
            } while (!flag);
        }
    }
}
