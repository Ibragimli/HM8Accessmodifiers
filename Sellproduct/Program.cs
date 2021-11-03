using System;

namespace Sellproduct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daxil edilecek productun sayin qeyd edin:");
            string counterstr = Console.ReadLine();
            int counter = Convert.ToInt32(counterstr);
            Milk[] milks = new Milk[0];


            if (counter > 0)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine($"{i + 1}. Productin melumatlarini daxil edin:");
                    Console.WriteLine("==========================================\n");

                    double volume = GetDoubleStr("Volume");
                    double fatrate = GetDoubleStr("FatRate", 0, 100);
                    string name = GetString("Name", 3, 25);
                    double price = GetDoubleStr("Price", 0);
                    Milk milk = new Milk(volume, fatrate, name)
                    {
                        Price = price
                        
                    };

                    Array.Resize(ref milks, milks.Length + 1);
                    milks[milks.Length - 1] = milk;

                }   
            }

            foreach (var milk in milks)
            {
                Console.WriteLine($"{milk.ShowInfo()}");
            }
            Product product = new Product("Sud1");
            product.Sell();
            Console.WriteLine($"Count-{product.Count} Total-{product.TotalInCome}");

            product.Sell();
            Console.WriteLine($"Count-{product.Count} Total-{product.TotalInCome}");

            product.Sell();
            Console.WriteLine($"Count-{product.Count} Total-{product.TotalInCome}");

            product.Sell();
            Console.WriteLine($"Count-{product.Count} Total-{product.TotalInCome}");




            static int GetIntString(string inputWord)
            {
                string inputstr;
                int input;
                bool check = false;

                do
                {
                    if (check)
                    {
                        Console.WriteLine("Serti duz oxu");
                    }
                    Console.WriteLine($"{inputWord} deyerin daxil edin:");
                    inputstr = Console.ReadLine();
                    input = Convert.ToInt32(inputstr);

                } while (int.TryParse(inputstr, out input));
                return input;

            }

            static string GetString(string inputWord, int minLength, int maxLength)
            {
                string str;
                bool check = false;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Serti duz oxu");
                    }
                    Console.WriteLine($"{inputWord} deyerin daxil edin:");
                    str = Console.ReadLine();


                } while (str.Length < minLength && str.Length > maxLength);
                return str;
            }


            static double GetDoubleStr(string inputWord, double minvalue = 0, double maxvalue = double.MaxValue)
            {
                string inputstr;
                double input;
                bool check = false;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Serti duz oxu");
                    }
                    Console.WriteLine($"{inputWord}-deyerin daxil edin");
                    inputstr = Console.ReadLine();

                } while (!double.TryParse(inputstr, out input) || input <= minvalue || input >= maxvalue);
                input = Convert.ToDouble(inputstr);
                return input;
            }

            //static double GetDoublePriceStr(string inputWord, double minvalue = 0, double maxvalue = 100)
            //{
            //    string inputstr;
            //    double input;
            //    bool check = false;
            //    do
            //    {
            //        if (check)
            //        {
            //            Console.WriteLine("Serti duz oxu");
            //        }
            //        Console.WriteLine($"{inputWord}-deyerin daxil edin");
            //        inputstr = Console.ReadLine();

            //    } while (!double.TryParse(inputstr, out input) || input <= minvalue || input >= maxvalue);
            //    input = Convert.ToDouble(inputstr);
            //    return input;
            //}
        }
    }
}
