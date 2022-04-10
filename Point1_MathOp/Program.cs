using System;

    /*
    Realizar un programa en C#, para implementar la solución propuesta en el siguiente diagrama de clases...

    El programa debe tener un menú, que permita realizar operaciones hasta que el usuario decida lo contrario. 
    */

namespace Point1_MathOp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            bool flag = false;
            double value1, value2;

            do
            {
                Console.WriteLine("\nThis a simple calculator to do basics aritmethic operations, to proceed, please add the values you want to use." +
                                  "\nKeep in mind that the order is importat in this case.");
                Console.WriteLine("1) Go for the maths\n2) Get out of here");
                i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("Proceed with the calculator.");

                        Console.WriteLine("Select the operation that you want to realize. \n\t 1)\t Add (+).\n\t 2)\t Difference(-).\n\t 3)\t Plus (*).\n\t 4)\t Divide (/).");
                        i = Convert.ToInt32(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                Console.Write("Add 1st number:\t");
                                value1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\nAdd 2nd number:\t");
                                value2 = Convert.ToDouble(Console.ReadLine());
                                Addition addition = new (value1, value2);
                                addition.DoOperation(value1, value2);
                                Console.WriteLine("\nThe result is: " + addition.Result);
                                break;

                            case 2:
                                Console.Write("Add 1st number:\t");
                                value1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\nAdd 2nd number:\t");
                                value2 = Convert.ToDouble(Console.ReadLine());
                                Subtraction subtraction = new (value1, value2);
                                subtraction.DoOperation(value1, value2);
                                Console.WriteLine("\nThe result is: " + subtraction.Result);
                                break;

                            case 3:
                                Console.Write("Add 1st number:\t");
                                value1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\nAdd 2nd number:\t");
                                value2 = Convert.ToDouble(Console.ReadLine());
                                Multiplication multiplication = new (value1, value2);
                                multiplication.DoOperation(value1, value2);
                                Console.WriteLine("\nThe result is: " + multiplication.Result);
                                break;

                            case 4:
                                Console.Write("Add 1st number:\t");
                                value1 = Convert.ToDouble(Console.ReadLine());
                                Console.Write("\nAdd 2nd number:\t");
                                value2 = Convert.ToDouble(Console.ReadLine());
                                Division division = new (value1, value2);
                                division.DoOperation(value1, value2);
                                Console.WriteLine("\nThe result is: " + division.Result);
                                break;
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("Sayonara");
                        flag = true;
                        break;
                }

            } while (!flag);
        }
    }
}
