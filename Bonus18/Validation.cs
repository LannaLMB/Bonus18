using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Validation
    {

        #region Methods


        // Method to Get Valid String
        public static string GetValidString()
        {
            string Input = Console.ReadLine().ToUpper();

            // Validate Input
            while ((string.IsNullOrEmpty(Input)) || (string.IsNullOrWhiteSpace(Input)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Word  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                Input = Console.ReadLine().ToUpper(); ;

            }
            return Input;
        }



        // Method to Get Valid Integer
        public static int GetValidInt()
        {

            int number;

            // Validate Input
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();

                // Number Validation with Colors
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.Write("You Must Enter a Number:  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;

            }
            return number;
        }



        // Method to Get Input and Validate That Number is Between Min and Max
        public static int GetRange(int min, int max)
        {

            // Get a Valid Int from Previous Method
            int number = GetValidInt();

            while (number < min || number > max)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"You MUST Enter a Number That is in Between {min} and {max}  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                number = GetValidInt();
            }
            return number;

        }



        // Method GetDouble
        public static double GetDouble()
        {
            double DoubleInput;

            while (!double.TryParse(Console.ReadLine(), out DoubleInput))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid Entry - You MUST Enter a Number:  --->   ");
                Console.ForegroundColor = ConsoleColor.Green;
                continue;
            }
            return DoubleInput;
        }




        // Method GetDouble in Range
        public static double GetDoubleWithinRange(double Min, double Max)
        {

            double DoubleInput = GetDouble();

            while (DoubleInput < Min || DoubleInput > Max)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Entry! Must Be Between {0} and {1}", Min, Max);
                Console.ForegroundColor = ConsoleColor.Green;
                DoubleInput = GetDouble();
            }
            return DoubleInput;
        }


        #endregion
    }
}
