using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimalAndBackConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert Number to be converted to Binary");
            int inputNumber = int.Parse(Console.ReadLine());

            string numberInBinary = DecimalToBinary(inputNumber);
            Console.WriteLine(numberInBinary);
            Console.WriteLine(BinaryToDecimal(numberInBinary));
            Console.ReadLine();
        }

        //valueInColumn * (BaseYouAreIn ^ Column)  (^ = to the power of)
        static string DecimalToBinary(int decimalNumber, int Base = 2)
        {
            //Find how many Columns (length) the number has
            int columns = 0;
            while (true)
            {
                var totalValInColumns = 0;
                for (var i = columns; i >= 0; i--)
                    totalValInColumns += (int)Math.Pow(Base, i) * (Base - 1);   //

                if (totalValInColumns < decimalNumber)
                    columns++;
                else
                    break;
            }

            var valueInNewBase = new int[columns + 1]; //make the array of number. (+1 because of how positions in arrays work)

            //Convert the decimal to binary
            for (var i = 0; i < decimalNumber; i++) //Run as many times as the decimal number
                for (var currColumn = 0; currColumn < valueInNewBase.Count(); currColumn++) //Current Column
                {
                    //check to see if the value in the column is less than the max per column (base - 1)
                    if (valueInNewBase[currColumn] < Base - 1) //"Base - 1" because you never see "X" in Base "X"
                    {
                        //If it is, add 1 and break the column loop
                        valueInNewBase[currColumn]++;
                        break;
                    }
                    // if it is the max (it can never be above) set the number to 0 and then go to the next column
                    else
                        valueInNewBase[currColumn] = 0;
                }

            //Change it from an int array (4 byts per index) to a string array (1 byte/char per index)
            var toReturn = "";
            for (var i = 0; i < valueInNewBase.Count(); i++)
                toReturn += valueInNewBase[i];

            return ReverseString(toReturn);//Reverse because we did everything left to right while numbers go right to left (kind of)
        }

        static string ReverseString(string toBeRevd)
        {
            string toReturn = "";

            for (int i = toBeRevd.Count() - 1; i >= 0; i--)
                toReturn += toBeRevd[i];

            return toReturn;
        }

        static int BinaryToDecimal(string numberAsString, int Base = 2)
        {
            //Reverse the string back to we can read it left to right
            numberAsString = ReverseString(numberAsString);

            //Set how many columns for later algorithm
            int columns = numberAsString.Count();

            //Creating this ro store the total value and will be returned
            int valueInDecimal = 0;

            //Go through each column
            for (int i = 0; i < columns; i++)
            {
                //Parse number in column to an integer
                int num = int.Parse(numberAsString[i].ToString());

                //valueInColumn * (BaseYouAreIn ^ Column) <- Algorithm to finding out the decimal value in each column
                int toAdd = num * (int)(Math.Pow(Base, i)); //<- algorithm in code

                //Add the algorithm's result here
                valueInDecimal += toAdd;
            }

            return valueInDecimal;
        }
    }
}
