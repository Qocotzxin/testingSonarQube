using System;
using System.Collections.Generic;
using System.Text;

namespace LaHoraDeDami

{
    static class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            Exercises excercises = new Exercises();

            int j = 0;

            do
            {
                Console.WriteLine("Ingrese ENTER para comenzar o ESCAPE para salir...");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Por favor ingrese el ejercicio deseado: ");
                Console.WriteLine("1 - Hola Mundo!");
                Console.WriteLine("2 - Bienvenida");
                Console.WriteLine("3 - Alice & Bob");
                Console.WriteLine("4 - Sumar 1");
                Console.WriteLine("5 - Múltiplos de 3 y 5");
                Console.WriteLine("6 - Sumar o multiplicar");
                Console.WriteLine("7 - Tabla de multiplicación hasta 12");
                Console.WriteLine("8 - Números primos");
                Console.WriteLine("9 - Adivinar el número");

                int option = 0;

                var myList = new List<int>();

                myList.Add(7);
                myList.Add(8);

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }


                switch (option)
                {
                    case 1:
                        excercises.HelloWorld();
                        break;
                    case 2:
                        excercises.Welcome();
                        break;
                    case 3:
                        excercises.AliceAndBob();
                        break;
                    case 4:
                        excercises.PlusOne();
                        break;
                    case 5:
                        excercises.Multiple();
                        break;
                    case 6:
                        excercises.SumOrMultiply();
                        break;
                    case 7:
                        excercises.MultiplicationTable();
                        break;
                    case 8:
                        excercises.ShowPrimeNumbers();
                        break;
                    case 9:
                        excercises.GuessTheNumber();
                        break;
                }
                j++;
                Console.WriteLine();

            } while (j > 0);


        }



    }
}
