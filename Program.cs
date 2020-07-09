using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ValidatingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopyMcLoopyPants();
        }

        private static void LoopyMcLoopyPants()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.Clear();

                Console.Write($"Please enter a valid Name: ");
                NameRegex(Console.ReadLine());

                Console.Write($"\nPlease enter a valid Email: ");
                EmailRegex(Console.ReadLine());

                Console.Write($"\nPlease enter a valid phone number: ");
                PhoneRegex(Console.ReadLine());

                Console.Write($"\nPlease enter a valid Date: ");
                DateRegex(Console.ReadLine());

                Console.Write($"\nPlease enter a valid HTML tag: ");
                HTMLRegex(Console.ReadLine());

                continueFlag = KeepGoing(continueFlag);
            }
            Console.WriteLine($"\nGood Bye!!!!!!!!!!!");
        }

        private static bool KeepGoing(bool continueFlag)
        {
            Console.Write($"\nWould you like to try again?? (q to Quit): ");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if (userInput == "q")
            {
                continueFlag = false;
            }

            return continueFlag;
        }

        public static void NameRegex(string testname)
        {
            Regex nameRegex = new Regex(@"^[A-Z]{1}[a-zA-Z]{0,29}$");
            bool matchNameRegex = nameRegex.IsMatch(testname);

            if (matchNameRegex)
            {
                Console.WriteLine("Name is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, name is not valid!");
            }
        }

        public static void EmailRegex(string testemail)
        {
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$");
            bool matchEmailRegex = emailRegex.IsMatch(testemail);

            if (matchEmailRegex)
            {
                Console.WriteLine("Email is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, email is not valid!");
            }
        }

        public static void PhoneRegex(string testphone)
        {
            Regex phoneRegex = new Regex(@"^\({0,1}[0-9]{3}\){0,1}-{0,1}\.{0,1}[0-9]{3}-{0,1}\.{0,1}[0-9]{4}$");
            bool matchPhoneRegex = phoneRegex.IsMatch(testphone);

            if (matchPhoneRegex)
            {
                Console.WriteLine("Phone is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, phone is not valid!");
            }
        }

        public static void DateRegex(string testdate)
        {
            Regex dateRegex = new Regex(@"^([1-9]|[0-2][0-9]|3[0-1])/([1-9]|1[012]|0[1-9])/[0-9]{4}$");
            bool matchDateRegex = dateRegex.IsMatch(testdate);

            if (matchDateRegex)
            {
                Console.WriteLine("Date is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, date is not valid!");
            }
        }

        public static void HTMLRegex(string testhtml)
        {
            Regex htmlRegex = new Regex(@"^<([!]*[-]*[.]*\w*)>\w*</\1>$");
            bool matchHTMLRegex = htmlRegex.IsMatch(testhtml);

            if (matchHTMLRegex)
            {
                Console.WriteLine("HTML is valid!");
            }
            else
            {
                Console.WriteLine("Sorry, HTML is not valid!");
            }
        }
    }
}