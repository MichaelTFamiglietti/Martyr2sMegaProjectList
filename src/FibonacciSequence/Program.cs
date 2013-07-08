using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSequence
{
    class Program
    {
        static void Main()
        {
            //The number of "How many times" or "The Starting point"
            Console.WriteLine("Insert Number: ");
            float inputNumber = float.Parse(Console.ReadLine());

            //Menu
            Console.Clear();
            Console.WriteLine("0: Fibonacci Sequence to the {0} index", inputNumber);
            Console.WriteLine("1: Fibonacci Sequence from {0}", inputNumber);
            var menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 0)
                Fibonacci(inputNumber, 1);  //uses the input number as how many times it runs; starts with 1 as the first numbe
            else if (menuChoice == 1)
                Fibonacci(100, inputNumber);//uses 100 for how many times it runs; starts with the input number

            Console.ReadLine();             //Prevent program from closing at the end
        }

        static void Fibonacci(float times, float startingNumber)
        {
            Console.Clear();

            var firstNum = 0f;              //Sets the first number to 0, it will always start at 0
            var secondNum = startingNumber; //Sets second number to the parameter starting number

            //as long as x is less then the parameter "times" then go again
            for(var x = 1f; x < times; x++)
            {
                Console.WriteLine(firstNum);
                var tempFirst = firstNum;  //Set these temp number so we can rearrange the real numbers

                firstNum = secondNum;
                secondNum += tempFirst;
            }
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
        }
    }
}
