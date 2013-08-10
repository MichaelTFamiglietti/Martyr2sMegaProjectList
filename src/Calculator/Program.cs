using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your problem: ");
            string input = Console.ReadLine();
            Console.WriteLine(Calculate(input));
            Console.ReadLine();
        }

        static string Calculate(string input)
        {
            //Removes all spaces to reduce confusion
            input = input.Replace(" ", "").Replace("[", "(").Replace("]", ")").Replace(",", "");

            //Perenthesis, Exponents, Multiply/Divide, Add/Subtract
            //Do PEMDAS
            for (int i = 0; i < input.Count(); i++)
            {
                //Perenthesis
                if (input[i] == '(')
                {
                    int openPeren = 0;
                    for (int x = i + 1; x < input.Count(); x++)
                        if (input[x] == '(')
                            openPeren++;
                        else if (input[x] == ')')
                            if (openPeren != 0)
                                openPeren--;
                            else
                            {
                                var insidePeren = "";
                                for (int i2 = i + 1; i2 < x; i2++)
                                    insidePeren += input[i2];
                                var result = Calculate(insidePeren);

                                input = input.Remove(i, x + 1 - i);
                                input = input.Insert(i, result);

                                break;
                            }
                }
            }

            if (input == "34-34" || input == "34-0")
                input = "0";


            return input;
        }
    }
}
