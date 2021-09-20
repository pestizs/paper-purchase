using System;

namespace paper_purchase
{
    class Program
    {
        static void Main(string[] args)
        {  
            int people = 25;
            int reportPages = 140;
            int ream = 500;
            int sheets;
            int result;
            int cartridgeCapacity = 1200;
            int cartridges;

            string InputcartridgeCost;
            string InputReamCost;
            double cartidgeCost;
            double reamCost;
            double totalCartridgeCost;
            double totalReamCost;
            double totalCost;
            

            sheets = (people + 5) * reportPages;
            result = sheets / ream;

            cartridges = sheets / cartridgeCapacity;

            Console.Write("Please enter how much a Toner cartridge cost(in dollar):");
            InputcartridgeCost = Console.ReadLine();
            cartidgeCost = Convert.ToDouble(InputcartridgeCost);

            Console.Write("Please enter how much a 500 sheet Ream cost(in dollar):");
            InputReamCost = Console.ReadLine();
            reamCost = Convert.ToDouble(InputReamCost);

            totalCartridgeCost = (cartridges + 1) * cartidgeCost;
            totalReamCost = ((result + 1) * reamCost) * 0.9;
            totalCost = totalCartridgeCost + totalReamCost;

            Console.WriteLine("Joe has to order "+ (result + 1) + " reams.");
            Console.WriteLine("Joe will need " + (cartridges+1) + " toner cartridges.");
            Console.WriteLine("10% discount has been added to your ream purchase.");
            Console.WriteLine("The total cost of the reams and Toner cartridges will be: " + totalCost);
            Console.ReadLine();
        }
    }
}
