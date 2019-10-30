using System;
using System.Text.RegularExpressions;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email, phoneNumber, date, repeatChoice;

            do
            {
                Console.Write("Please enter your name: ");
                name = Console.ReadLine();
                CheckName(name);

                while (!CheckName(name))
                {
                    Console.Write("Invalid name. Please enter again: ");
                    name = Console.ReadLine();
                    CheckName(name);
                }

                Console.WriteLine("Name is valid!");

                Console.Write("Please enter your email address: ");
                email = Console.ReadLine();
                CheckEmail(email);

                while (!CheckEmail(email))
                {
                    Console.Write("Invalid email address. Please enter again: ");
                    email = Console.ReadLine();
                    CheckEmail(email);
                }

                Console.WriteLine("Email is valid!");

                Console.Write("Please enter your phone number (###-###-####): ");
                phoneNumber = Console.ReadLine();
                CheckPhoneNumber(phoneNumber);

                while (!CheckPhoneNumber(phoneNumber))
                {
                    Console.Write("Invalid phone number. Please enter again: ");
                    phoneNumber = Console.ReadLine();
                    CheckPhoneNumber(phoneNumber);
                }

                Console.WriteLine("Phone number is valid!");

                Console.Write("Please enter today's date (dd/mm/yyyy): ");
                date = Console.ReadLine();
                CheckDate(date);

                while (!CheckDate(date))
                {
                    Console.Write("Invalid date. Please enter again: ");
                    date = Console.ReadLine();
                    CheckDate(date);
                }

                Console.WriteLine("Date is valid!");

                Console.WriteLine("Would you like to validate again?");
                repeatChoice = Console.ReadLine().ToLower();

                while (repeatChoice != "y" && repeatChoice != "n")
                {
                    Console.WriteLine("Invalid Input");
                    repeatChoice = Console.ReadLine().ToLower();
                }
            } while (repeatChoice == "y");

            Console.WriteLine("Thanks for validating!");
            return;
        }

        static bool CheckName(string name)
        {
            if (Regex.Match(name, @"(^[A-Z]{1}[a-z]{0,29}$)").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckEmail(string email)
        {
            if (Regex.Match(email, @"(^[a-zA-Z0-9]{5,30}@{1}[a-zA-A0-9]{5,30}\.{1}[a-zA-Z0-0]{2,3}$)").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckPhoneNumber(string phoneNum)
        {
            if (Regex.Match(phoneNum, @"(^[0-9]{3}-{1}[0-9]{3}-[0-9]{4}$)").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool CheckDate(string date)
        {
            if (Regex.Match(date, @"(^(0[1-9]|1[1-9]|2[1-9]|3[0-1])\/{1}(0[1-9]|1[0-2])\/{1}(19|20)[0-9]{2}$)").Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
