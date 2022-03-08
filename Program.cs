using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MobileNumber MobileNum = new MobileNumber();
            Console.WriteLine("Enter the mobile num");
            string number = Console.ReadLine();
            bool match = MobileNum.ValidateNumber(number);
            if (match != true)
            {
                Console.WriteLine("Enter a valid Mobile number");
            }
        }
    }
}