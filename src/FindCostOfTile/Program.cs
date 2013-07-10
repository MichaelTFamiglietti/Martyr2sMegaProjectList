using System;

namespace FindCostOfTile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find cost of tile to cover your floor in feet");

            //Get the width and height
            Console.Write("What is the width: ");
            var width = float.Parse(Console.ReadLine());
            Console.Write("What is the length: ");
            var length = float.Parse(Console.ReadLine());

            //Calculate total area
            var area = length*width;

            //Get price per square foot
            Console.Write("Price Per Square Foot: ");
            var price = float.Parse(Console.ReadLine());

            //Calculate total price
            var totalPrice = price*area;
            Console.WriteLine("Total Price: " + totalPrice);
            Console.ReadLine();
        }
    }
}
