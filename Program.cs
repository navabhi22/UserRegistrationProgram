using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eMail mail = new eMail();
            Console.WriteLine("Enter the eMail");
            string Mail = Console.ReadLine();
            bool match = mail.ValidateEmail(Mail);
            if (match != true)
            {
                Console.WriteLine("Enter a valid Email address");
            }
        }
    }
}