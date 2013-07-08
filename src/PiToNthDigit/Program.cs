using System;

namespace PiToNthDigit
{
    class Program
    {
        private static int MAX_DIGIT = 15; //The max amount of digits

        static void Main(string[] args)
        {
            //If the method fails, clear console and run again
            while(!PiToNthDigit())
                Console.Clear();            
            Console.ReadLine();
        }

        private static bool PiToNthDigit()
        {
            try
            {
                //Take input and convert it into an integer
                Console.WriteLine("Pi to which digit? (Max is {0})", MAX_DIGIT);
                int inputDigit = Int32.Parse(Console.ReadLine());

                //Make sure input digit is in range
                if (inputDigit > MAX_DIGIT)
                    inputDigit = MAX_DIGIT;
                else if (inputDigit < 1)
                    inputDigit = 1;

                //Writeout the output of the rounded Pi
                Console.WriteLine(Math.Round(Math.PI, inputDigit));

                //Return true because SUCCESS!
                return true;
            }
            catch
            {
                //Return false because something went wrong and we need to restart
                return false;
            }
        }
    }
}
