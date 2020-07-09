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

                Console.Write($"\nPlease enter a valid Name: ");
                var nameResult = NameRegex(Console.ReadLine());
                Console.WriteLine(nameResult);

                Console.Write($"\nPlease enter a valid Email: ");
                var emailResult = EmailRegex(Console.ReadLine());
                Console.WriteLine(emailResult);

                Console.Write($"\nPlease enter a valid phone number: ");
                var phoneResult = PhoneRegex(Console.ReadLine());
                Console.WriteLine(phoneResult);

                Console.Write($"\nPlease enter a valid Date: ");
                var dateResult = DateRegex(Console.ReadLine());
                Console.WriteLine(dateResult);


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

        public static string NameRegex(string testname)
        {
            string answer;
            Regex nameRegex = new Regex(@"^[A-Z]{1}[a-zA-Z]{0,29}$");
            bool matchNameRegex = nameRegex.IsMatch(testname);

            if (matchNameRegex)
            {
                answer = "Name is valid!";
            }
            else
            {
                answer = "Sorry, name is not valid!";
            }
            return answer;
        }

        public static string EmailRegex(string testemail)
        {
            string answer;
            Regex emailRegex = new Regex(@"^[a-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$");
            bool matchEmailRegex = emailRegex.IsMatch(testemail);

            if (matchEmailRegex)
            {
                answer = "Email is valid!";
            }
            else
            {
                answer = "Sorry, email is not valid!";
            }
            return answer;
        }

        public static string PhoneRegex(string testphone)
        {
            string answer;
            Regex phoneRegex = new Regex(@"^[(]{0,1}[0-9]{3}[)]{0,1}[-]{0,1}[.]{0,1}[0-9]{3}[-]{0,1}[.]{0,1}[0-9]{4}$");
            bool matchPhoneRegex = phoneRegex.IsMatch(testphone);

            if (matchPhoneRegex)
            {
                answer = "Phone is valid!";
            }
            else
            {
                answer = "Sorry, phone is not valid!";
            }
            return answer;
        }

        public static string DateRegex(string testdate)
        {
            string answer;
            Regex dateRegex = new Regex(@"^([1-9]|[0-2][0-9]|3[0-1])[/]([1-9]|1[012]|0[1-9])[/][0-9]{4}$");
            bool matchDateRegex = dateRegex.IsMatch(testdate);

            if (matchDateRegex)
            {
                answer = "Date is valid!";
            }
            else
            {
                answer = "Sorry, date is not valid!";
            }
            return answer;
        }
    }
}