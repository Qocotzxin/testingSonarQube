using System;

namespace LaHoraDeDami
{
    class Exercises
    {
        private readonly Operation Operation = new Operation();

        public void HelloWorld()
        {
            Console.WriteLine("Hola mundo!");
        }

        public void Welcome()
        {
            Console.WriteLine("Por favor ingresá tu nombre: ");
            String nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido " + nombre + "!");
        }

        public void AliceAndBob()
        {
            Console.WriteLine("Por favor ingresá tu nombre: ");
            String nombre = Console.ReadLine();
            String first_user = "Alice";
            String second_user = "Bob";

            if (nombre == first_user || nombre == second_user)
            {
                Console.WriteLine("Bienvenido " + nombre + "!");
            }
            else
            {
                Console.WriteLine("Usuario no registrado. ");
            }
        }

        public void PlusOne()
        {
            Console.WriteLine("por favor ingresá un número: ");
            string user_input = Console.ReadLine();
            int user_input_to_number = Convert.ToInt32(user_input);
            var result = user_input_to_number + 1;

            Console.WriteLine(user_input + " + 1 = " + result);
        }
        public void Multiple()
        {
            Console.WriteLine("Por favor ingrese un número múltiplo de 3 o 5: ");
            string user_input = Console.ReadLine();
            if (String.IsNullOrEmpty(user_input))
            {
                user_input = "0";
            }
            int user_input_to_number = Convert.ToInt32(user_input);
            var is_multiple_of_three = user_input_to_number % 3;
            var is_multiple_of_five = user_input_to_number % 5;

            if (is_multiple_of_three == 0 || is_multiple_of_five == 0)
            {
                var result = user_input_to_number + 1;
                Console.WriteLine(user_input + " + 1 = " + result);
            }
            else
            {
                Console.WriteLine("El valor ingresado no es correcto, por favor intente nuevamente");
            }
        }

        public void SumOrMultiply()
        {
            Console.WriteLine("Por favor ingrese un número: ");
            int user_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Presione 1 para elegir suma o 2 para producto: ");
            int user_option = Convert.ToInt32(Console.ReadLine());

            switch (user_option)
            {
                case 1:
                    Console.WriteLine(Operation.Sum(user_number));
                    break;
                case 2:
                    Console.WriteLine(Operation.Product(user_number));
                    break;
                default:
                    Console.WriteLine("La operación ingresada no es correcta");
                    break;
            }
        }
        public void MultiplicationTable()
        {
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j);
                }
            }
        }

        public void ShowPrimeNumbers()
        {
            for (int i = 2; i <= 10000; i++)
            {
                Operation.CheckIfPrimeNumbers(i);
            }
        }

        public void GuessTheNumber()
        {
            Random random = new Random();
            int j = 0;
            int secretNumber = random.Next(1, 101);

            Console.WriteLine("Intentá adivinar el número entre 1 y 100: ");

            do
            {

                int userOption = Convert.ToInt32(Console.ReadLine());

                if (secretNumber == userOption)
                {
                    Console.WriteLine("Correcto! El número era " + secretNumber);
                    Console.WriteLine("Lo lograste en " + (j + 1) + " intentos!");
                    j = 0;
                }
                else
                {
                    if (userOption > secretNumber)
                    {
                        Console.WriteLine("Intentá con un número menor...");
                        j++;
                    }
                    else
                    {
                        Console.WriteLine("Intentá con un número mayor");
                        j++;
                    }
                }

            } while (j > 0);
        }
    }
}
