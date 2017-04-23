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


            // Car1 Data
            Car Car1 = new Car();


            // CarMake Data
            Console.Write("Please Enter the Make of Your Car:   --->   ");
            Car1.CarMake = Validation.GetValidString();
            Console.WriteLine();


            // Get CarModel Data
            Console.Write("Please Enter the Model of Your Car:   --->   ");
            Car1.CarModel = Validation.GetValidString();
            Console.WriteLine();


            // Get CarYear Data
            Console.Write("Please Enter the Year of Your Car:   --->   ");
            Car1.CarYear = Validation.GetRange(1886, 2018);
            Console.WriteLine();


            // Get CarPrice Data
            Console.Write("Please Enter the Price of Your Car:   --->   ");
            Car1.CarPrice = Validation.GetDoubleWithinRange(0.0, 999999999999.99);
            Console.WriteLine("\n");



            // Print Output for User Input/Inventory
            Console.WriteLine("------  Current Inventory  ------\n");
            Console.WriteLine(Car1.CarMake + "\t\t" + Car1.CarModel + "\t\t" + Car1.CarYear + "\t\t" + Car1.CarPrice.ToString("$#,#.00"));

        }
    }
}
