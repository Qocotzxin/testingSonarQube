using System;
using System.Linq;

namespace Listas
{
    class ListPractice
    {

        private readonly Operation operation = new Operation();
        public void LargestElementInList()
        {
            var newArray = operation.CreateList();

            Console.WriteLine("Lista: ");

            newArray.ForEach(res => Console.WriteLine(res));

            Console.WriteLine();
            Console.WriteLine("El número más grande es el: " + newArray.Max());
        }

        public void ReverseList()
        {
            var newArray = operation.CreateList();

            Console.WriteLine("Lista: ");
            newArray.ForEach(res => Console.WriteLine(res));

            newArray.Reverse();

            Console.WriteLine();

            Console.WriteLine("Lista invertida: ");
            newArray.ForEach(res => Console.WriteLine(res));
        }

        public void CheckElementInList(int option)
        {
            var newArray = operation.CreateList();

            Console.WriteLine("Lista: ");
            newArray.ForEach(res => Console.WriteLine(res));
        }
    }
}
