using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("How many numbers do you want to enter:");
                    numbers = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input. Please use only numerical characters as integer.");
                }
            }

            bool[] primeNumberArray = OperateSieve(numbers);
            for (int i = 2; i < primeNumberArray.Length; i++)
            {
                if (primeNumberArray[i])
                {
                    Console.WriteLine("Enter Numer: " + i);
                }
            }


            Console.Read();
        }

        static bool[] OperateSieve(int numbers)
        {
            bool[] primeNumberArray = new bool[numbers + 1];

            for (int i = 2; i <= numbers; i++)
            {
                primeNumberArray[i] = true;
            }

            for (int i = 2; i <= numbers; i++)
            {
                if (primeNumberArray[i])
                {
                    for (int j = i * 2; j <= numbers; j += i)
                    {
                        primeNumberArray[j] = false;
                    }
                }
            }
            return primeNumberArray;
        }
    }
}
