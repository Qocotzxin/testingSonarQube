using System;
using System.Text;

namespace Listas
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ListPractice excercises = new ListPractice();

            int j = 0;

            do
            {
                Console.WriteLine("Ingrese ENTER para comenzar o ESCAPE para salir...");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("Por favor ingrese el ejercicio deseado: ");
                Console.WriteLine("1 - Obtiene el elemento más grande de la lista");
                Console.WriteLine("2 - Invierte el orden de la lista");

                int option = 0;

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
                        excercises.LargestElementInList();
                        break;
                    case 2:
                        excercises.ReverseList();
                        break;
                    case 3:
                        excercises.CheckElementInList(option);
                        break;
                }
                j++;
                Console.WriteLine();

            } while (j > 0);
        }
    }
}
