using System;

namespace LaHoraDeDami
{
    public class Operation
    {
        public int Sum(int option)
        {
            int operation_result = 0;

            for (int i = 1; i <= option; i++)
            {
                operation_result += i;
            }

            return operation_result;
        }

        public int Product(int option)
        {
            int operation_result = 1;

            for (int i = 1; i <= option; i++)
            {
                operation_result *= i;
            }

            return operation_result;
        }
        public void CheckIfPrimeNumbers(int number)
        {
            int iteration = 0;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    iteration = 1;
                    break;
                }
            }

            if (iteration == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
