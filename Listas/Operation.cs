using System;
using System.Collections.Generic;

namespace Listas
{
    class Operation
    {
        private readonly Random randomNumber = new Random();
        private readonly List<int> newList = new List<int>();

        public List<int> CreateList()
        {
            for (int i = 0; i < 10; i++)
            {
                newList.Add(randomNumber.Next(0, 100));
            }

            return newList;
        }
    }
}
