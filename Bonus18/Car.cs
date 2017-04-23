using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Car
    {

        #region Variables

        private string Make;
        private string Model;
        private int Year;
        private double Price;

        #endregion



        #region Properties

        // Property - Make
        public string CarMake
        {
            set
            {
                Make = value;
            }

            get
            {
                return Make;
            }
        }



        // Property - Model
        public string CarModel
        {
            get
            {
                return Model;
            }

            set
            {
                Model = value;
            }
        }



        // Property - Year
        public int CarYear
        {
            get
            {
                return Year;
            }

            set
            {
                Year = value;
            }
        }



        // Property - Price
        public double CarPrice
        {
            get
            {
                return Price;
            }

            set
            {
                Price = value;
            }
        }

        #endregion




        #region Input
        
        // Input
        public Car (string MakeInput,
            string ModelInput,
            int YearInput,
            double PriceInput)
        {

            Make = MakeInput;
            Model = ModelInput;
            Year = YearInput;
            Price = PriceInput;

        }


        //Default Input
        public Car()
        {
            Make = "Jeep";
            Model = "Liberty";
            Year = 2006;
            Price = 20000.02;

        }
        #endregion

    }
}
