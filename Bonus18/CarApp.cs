using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class CarApp
    {
        // Welcome Message
        Console.WriteLine("Welcome to the Grand Circus Motors Admin Console!");
            Console.WriteLine();


            // Car1 Data
            Car Car1 = new Car();


        //Make Data
        Console.Write("Please Enter the Make of Your Car:   --->   ");
            Car1.CarMake = Console.ReadLine();
            Console.WriteLine();


            // Model Data
            Console.Write("Please Enter the Model of Your Car:   --->   ");
            Car1.CarModel = Console.ReadLine();
            Console.WriteLine();


            // Year Data
            Console.Write("Please Enter the Year of Your Car:   --->   ");
            Car1.CarYear = int.Parse(Console.ReadLine());
            Console.WriteLine();


            // Price Data
            Console.Write("Please Enter the Price of Your Car:   --->   ");
            Car1.CarPrice = double.Parse(Console.ReadLine());
            Console.WriteLine();



            Car Car2 = new Car();
        Console.WriteLine(Car1.CarMake +" "+ Car1.CarModel +" "+ Car1.CarYear +" "+ Car1.CarPrice);
        

    }
}
