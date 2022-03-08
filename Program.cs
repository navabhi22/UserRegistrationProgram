using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Program");
            Console.WriteLine("Enter First Name (First letter capital and min 3 charater)");
            string FirstName = Console.ReadLine();
            Name name = new Name();
            bool match = name.FirstName(FirstName);
            if (match == true)
            {
                Console.WriteLine("Valid First Name");
            }
            else
            {
                Console.WriteLine("Enter a Valid First Name");
            }
        }
    }
}