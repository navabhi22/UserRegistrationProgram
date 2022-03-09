using System;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            eMail mail = new eMail();

            bool[] match = new bool[23];

            match[1] = mail.ValidateEmail("abc@yahoo.com");
            match[2] = mail.ValidateEmail("abc-100@yahoo.com");
            match[3] = mail.ValidateEmail("abc.100@yahoo.com");
            match[4] = mail.ValidateEmail("abc.111@abc.com");
            match[5] = mail.ValidateEmail("abc.100@abc.net");
            match[6] = mail.ValidateEmail("abc.100@abc.com.au");
            match[7] = mail.ValidateEmail("abc@1.com");
            match[8] = mail.ValidateEmail("abc@gmail.com.com");
            match[9] = mail.ValidateEmail("abc+100@gmail.com");
            match[10] = mail.ValidateEmail("abc");
            match[11] = mail.ValidateEmail("abc@.com.my");
            match[12] = mail.ValidateEmail("abc123@gmail.a");
            match[13] = mail.ValidateEmail("abc123@.com");
            match[14] = mail.ValidateEmail("abc123@.com.com");
            match[15] = mail.ValidateEmail(".abc@abc.com");
            match[16] = mail.ValidateEmail("abc()*@gmail.com");
            match[17] = mail.ValidateEmail("abc@%*.com");
            match[18] = mail.ValidateEmail("abc..2002@gmail.com");
            match[19] = mail.ValidateEmail("abc.@gmail.com");
            match[20] = mail.ValidateEmail("abc@abc@gmail.com");
            match[21] = mail.ValidateEmail("abc@gmail.com.1a");
            match[22] = mail.ValidateEmail("abc@gmail.com.aa.au");

            for (int i = 1; i < 23; i++)
            {
                if (match[i] == true)
                { Console.WriteLine("valid"); }
                else
                { Console.WriteLine("not valid"); }
            }
        }
    }
}