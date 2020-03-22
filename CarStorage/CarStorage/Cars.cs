using System;
using System.Collections.Generic;
using System.Text;

namespace CarStorage
{
    class Cars
    {
        private int _price = 0;
        public string Color { get; set; }
        public string Name { get; set; }
        public int Price { 
            get => _price;
            set 
            {
                if (value>0)
                {
                    _price = value;
                }

                else
                {
                    Console.WriteLine("Incorrect value of the Price");
                }
            }
        }

        internal double GetSale()
        {
            var saleSum = new Random().Next(5,10);
            return Price-(saleSum/100.0*Price); 
        }
    }
}
