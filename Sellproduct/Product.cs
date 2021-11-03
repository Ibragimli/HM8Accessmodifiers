using System;
using System.Collections.Generic;
using System.Text;

namespace Sellproduct
{
    class Product
    {
        public Product(string name)
        {
            this._name = name;
           
        }

        private string _name;
        public string Name
        {
            get => _name;

            set
            {
                if (value.Length > 3 && value.Length < 25)
                {
                    _name = value;
                }
            }

        }

        private double _price;

        public double Price
        {
            get => _price;

            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }


        public int Count
        {
            get;
            private set;
        } = 10;


        public double TotalInCome { get; private set; }


        public void Sell()
        {
            if (Count > 0)
            {
                Count = Count - 1;
                TotalInCome += Price;
            }
            else
            {
                Console.WriteLine("Mehsulun sayi 0-dir");
            }
           
        }

        public virtual string ShowInfo()
        {
            return $"Name:{Name} Price:{Price} Count:{Count} TotalInCome:{TotalInCome}";
        }


    }
}
