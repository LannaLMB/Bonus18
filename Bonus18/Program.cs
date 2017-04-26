/*
 *Created By:  Lanna Brasure
 * Last Updated:  4/23/17
 * Program:  Bonus 18 - This Program Will Get User Input for Car Data and Print the Output
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {

            // Welcome Message
            Console.WriteLine("Welcome to the Grand Circus Motors Admin Console!");
            Console.WriteLine();

            Console.Write("Please Enter How Many Cars You Would Like to Input:   \n--->   ");



            // Declare Array & Initialize Range for Number of Cars
            int NumCars = Validation.GetRange(1, 5);
            Car[] CarList = new Car[NumCars];
            Validation.GetInput(NumCars, CarList);
            GetInventory(NumCars, CarList);

        }



        // Method Get Inventory List
        public static void GetInventory(int NumCars, Car[] CarList)
        {

            Console.WriteLine("----------  Current Inventory  ----------\n");

            for (int i = 0; i < NumCars; i++)
            {

                // Print Output for User Input/Inventory
                Console.WriteLine($"{CarList[i].CarMake.Trim()}\t\t{CarList[i].CarModel.Trim()}\t\t{CarList[i].CarYear}\t\t{CarList[i].CarPrice.ToString("$#,#.00")}");
            }
        }
    }
}
