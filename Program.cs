using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name (First letter capital and min 3 charater)");
            string FirstName = Console.ReadLine();
            Name first_name = new Name();
            bool match = first_name.ValidName(FirstName);
            if (match != true)
            {
                Console.WriteLine("Enter a Valid First Name");
            }

            Console.WriteLine("Enter Last Name (First letter capital and min 3 charater)");
            string LastName = Console.ReadLine();
            Name last_name = new Name();
            bool match2 = last_name.ValidName(LastName);
            if (match != true)
            {
                Console.WriteLine("Enter a valid Second Name");
            }
        }
    }
}