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
        public void Vaccinate();
        public void Bath();
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool flag = false;

            do
            {
                //switch para la creacion de los animales, se va a trabajar con switch dentro de switch de momento
                //Alabada sean las Gachas
                Console.WriteLine("Welcome to Build a Pet Workshop");

                switch(i)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        Console.Write("You have exited the program, Sayonara");
                        flag = true;
                        break;
                }    

            } while (!flag);
        }
    }
}
