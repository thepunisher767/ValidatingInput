using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace ValidatingInput
{
    class Program
    {
        static void Main(string[] args)
        {

            bool continueFlag = true;

            while (continueFlag)
            {
                Console.Clear();

                Regex emailRegex = new Regex(@"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$");
                Regex nameRegex = new Regex(@"^[A-Z]{1}[a-zA-Z]{0,29}$");
                Regex dateRegex = new Regex(@"^([1-9]|[0-2][0-9]|3[0-1])[/]([1-9]|1[012]|0[1-9])[/][0-9]{4}$");
                Regex phoneRegex = new Regex(@"^[(]{0,1}[0-9]{3}[)]{0,1}[-]{0,1}[.]{0,1}[0-9]{3}[-]{0,1}[.]{0,1}[0-9]{4}$");

                Console.Write($"\nPlease enter a valid Name: ");
                string testname = Console.ReadLine();
                bool matchNameRegex = nameRegex.IsMatch(testname);

                if (matchNameRegex)
                {
                    Console.WriteLine("Name is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid!");
                }

                Console.Write($"\nPlease enter a valid Email: ");
                string testemail = Console.ReadLine();
                bool matchEmailRegex = emailRegex.IsMatch(testemail);

                if (matchEmailRegex)
                {
                    Console.WriteLine("Email is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, email is not valid!");
                }

                Console.Write($"\nPlease enter a valid phone number: ");
                string testphone = Console.ReadLine();
                bool matchPhoneRegex = phoneRegex.IsMatch(testphone);

                if (matchPhoneRegex)
                {
                    Console.WriteLine("Phone is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, phone is not valid!");
                }
                
                Console.Write($"\nPlease enter a valid Date: ");
                string testdate = Console.ReadLine();
                bool matchDateRegex = dateRegex.IsMatch(testdate);

                if (matchDateRegex)
                {
                    Console.WriteLine("Date is valid!");
                }
                else
                {
                    Console.WriteLine("Sorry, date is not valid!");
                }

                Console.Write($"\nWould you like to try again?? (q to Quit): ");
                string userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                if (userInput == "q")
                {
                    continueFlag = false;
                }
            }

            Console.WriteLine($"\nGood Bye!!!!!!!!!!!");
        }
    }
}
