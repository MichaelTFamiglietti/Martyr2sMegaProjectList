using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAmountOfPrimes = 0;
            for(long num = 0; true; num++)
            {
                if (IsPrime(num))
                {
                    currentAmountOfPrimes++;
                    Console.WriteLine("Prime Number {0}: {1}", currentAmountOfPrimes, num);
                    Console.WriteLine("Type a key and hit enter to close, or just hit enter to continue");
                    if (Console.ReadLine() != "")
                        break;
                    Console.Clear();
                }
            }
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
