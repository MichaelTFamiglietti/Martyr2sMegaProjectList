using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of all the factors and list of all the primes
            List<long> factors = new List<long>();
            List<long> primes = new List<long>();

            //The number the user entered
            long inputNumber = long.Parse(Console.ReadLine());

            //Add the factor because obviously it is a factor of itself and 1
            factors.Add(inputNumber);
            factors.Add(1);

            //Start at 2 because we already used 1 and 0 can't be a factor. Max is the square root because a factor can't be more than the square root of the number
            for (long i = 2; i < Math.Sqrt(inputNumber); i++)
                if (inputNumber % i == 0)
                {
                    if(IsPrime(i))
                        primes.Add(i);
                    if(IsPrime(inputNumber / i))
                        primes.Add(inputNumber / i);
                }

            for (int i = 0; i < primes.Count(); i++ )
                Console.WriteLine(primes[i]);
            Console.ReadLine();
        }

        //Check if a number is prime
        static bool IsPrime(long num)
        {
            for (long i = 2; i < num; i++)
                if (num % i == 0 && i != num)
                    return false;

            return true;
        }
    }
}
