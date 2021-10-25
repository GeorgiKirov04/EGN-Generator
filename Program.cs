using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace final_project
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("1: ID maker");
            Console.WriteLine("2: E - mail maker");
            Console.WriteLine("3: Password generator");
            Console.WriteLine("4: Random phone number");
            Console.WriteLine("5: Credit card maker");
            Console.WriteLine("Select option: ");

            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Please eneter the following data:");
                Console.WriteLine("Make sure to put '/' between the given information");
                IDmaker();
            }
            else
            {
                Console.WriteLine("This function is unavailable!");
                Console.WriteLine();
                Console.WriteLine("1: ID maker");
                Console.WriteLine("2: E - mail maker");
                Console.WriteLine("3: Password generator");
                Console.WriteLine("4: Random phone number");
                Console.WriteLine("5: Credit card maker");
                Console.WriteLine("Select option: ");
                Console.WriteLine("Please chose a valid option:");

                option = Console.ReadLine();
            }
        }

        class ID
        {
            public string[] name;
            public string[] age;
            public string[] gender;
            public string[] live;
        }

        private static void IDmaker()
        {
           
            string birth = @"^([0]?[0-9]|[12][0-9]|[3][01])[./-]([0]?[1-9]|[1][0-2])[./-]([0-9]{4}|[0-9]{2})$";
            string namecheck = @"^\b[A-Z]+\/?[A-Z]+\/?[A-Z]\b$";
            string sexcheck = @"^\b[A - Z]?[a - z]{ 3,6}\b$";

            Regex checkday = new Regex(birth);
            Regex checkname = new Regex(namecheck);
            Regex sexc = new Regex(sexcheck);

            ID info = new ID();

            Console.WriteLine();
            Console.WriteLine("Name/Middle name/Surname:");
            string[] name = Console.ReadLine().ToUpper().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var item in name)
            {
                if (checkname.IsMatch(item))
                {
                    info.name = name;
                }
                else
                {
                    Console.WriteLine("Incorrect format!");
                    Console.WriteLine("Please make sure you've entered it correctly!");
                    Console.WriteLine("Name/Middle name/Surname:");
                    
                   name = Console.ReadLine().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Day/Month/Year:");
            string[] dob = Console.ReadLine().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();
          
            foreach (string item in dob)
            {

                if (checkday.IsMatch(item))
                {
                    info.age = dob;
                }
                else
                {
                    Console.WriteLine("Unvalid birth date!");
                    Console.WriteLine("Please enter your full information!");
                    Console.WriteLine("Day/Month/Year:");
         
                }
                dob = Console.ReadLine().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine();
            Console.WriteLine("Gender: (Male,Female)");
            Console.WriteLine("First letter should be capital!");
            string[] sex = Console.ReadLine().Split().ToArray();
            foreach (string sc in sex)
            {

                if (sexc.IsMatch(sc))
                {
                    
                    if (sex[0]!="Male" || sex[0]!="Female")
                    {
                        Console.WriteLine("Unvalid gender!");
                        Console.WriteLine("Please enter your real gender");
                        Console.WriteLine("Gender:");
                        Console.WriteLine();
                    }
                    else
                    {
                        info.gender = sex;
                    }
                }
                else
                {
                    Console.WriteLine("Unvalid gender!");
                    Console.WriteLine("Please enter your real gender");
                    Console.WriteLine("Gender:");
                    Console.WriteLine();
                    sex = Console.ReadLine().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();
                }
            }
          

            Console.WriteLine("City/Contry:");
            string[] live = Console.ReadLine().Split(("/"), StringSplitOptions.RemoveEmptyEntries).ToArray();
            info.live = live;

        }

    }

}
