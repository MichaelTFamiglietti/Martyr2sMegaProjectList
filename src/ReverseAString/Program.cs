using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAString
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("String to reverse: ");
            Console.WriteLine(ReverseString(Console.ReadLine()));
            Console.ReadLine();
        }

        static string ReverseString(string toBeRevd)
        {
            string toReturn = "";       //The new reversed string

            //Loops backwards through the string
            for (int i = toBeRevd.Count() - 1; i >= 0; i--)
                toReturn += toBeRevd[i];

            return toReturn;
        }

    }
}
