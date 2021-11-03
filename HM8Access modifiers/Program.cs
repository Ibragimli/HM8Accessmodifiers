using System;

namespace HM8Access_modifiers
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Doctor sayin qeyd edin:");
            string countstr = Console.ReadLine();
            int count = Convert.ToInt32(countstr);
            Doctor[] newdoctor = new Doctor[0];

            if (count > 0)
            {

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine($"{i + 1}. Doctorun melumatlarini daxil edin");
                    Console.WriteLine("==========================================\n");

                    int no = GetInputInt("No", 0);
                    string name = GetInputStr("Name", 3, 25);
                    string surname = GetInputStr("Surname", 3, 30);
                    string gender = GetInputGender("Gender");
                    int experience = GetInputInt("Experience", 1);
                    string speacialty = GetInputStr("Speaclity", 0);




                    Doctor doctor = new Doctor(no, speacialty, experience, name, surname, gender);

                    Array.Resize(ref newdoctor, newdoctor.Length + 1);
                    newdoctor[newdoctor.Length - 1] = doctor;
                    foreach (var item in newdoctor)
                    {
                        Console.WriteLine(item.ShowInfo());
                    }
                }
            }


            static string GetInputStr(string inputWord, int minLength = 0, int maxLength = int.MaxValue)
            {
                string inputstr;
                do
                {
                    Console.WriteLine($"{inputWord} deyerin daxil edin");
                    inputstr = Console.ReadLine();

                } while (inputstr.Length < minLength || inputstr.Length > maxLength);
                return inputstr;
            }

            static int GetInputInt(string inputWord, int min = int.MinValue, int max = int.MaxValue)
            {
                string inputstr;
                int input;

                do
                {
                    Console.WriteLine($"{inputWord} deyerin daxil edin:");
                    inputstr = Console.ReadLine();
                    input = Convert.ToInt32(inputstr);

                } while (input < min || input > max);
                return input;

            }

            static double GetInputDouble(string inputWord, double min = 0, double max = double.MaxValue)
            {
                string inputStr;
                double input;
                do
                {
                    Console.WriteLine($"{inputWord} deyerin daxil edin:");
                    inputStr = Console.ReadLine();
                    input = Convert.ToDouble(inputStr);

                }
                while (input < min || input > max);
                return input;
            }

            static string GetInputGender(string inputWord)
            {
                string inputStr;
                bool check = false;
                do
                {
                    if (check)
                    {
                        Console.WriteLine("Serti duz oxuyun!!");
                    }
                    Console.WriteLine($"{inputWord} deyerin daxil edin:");
                    inputStr = Console.ReadLine();


                } while (inputStr != "kisi" && inputStr != "qadin");
                return inputStr;
            }
        }
    }
}