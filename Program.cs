using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the password");
            Password password = new Password();
            string pass = Console.ReadLine();
            bool match = password.Rule3(pass);
            if (match != true)
            {
                Console.WriteLine("Enter a valid password ");
            }
        }
    }
}