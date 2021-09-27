using System;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEGHIJKLMNOPRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&()";

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (Tools.Contains(password, uppercase))
            {
                score++;
            }
            if (Tools.Contains(password, lowercase))
            {
                score++;
            }
            if (Tools.Contains(password, digits))
            {
                score++;
            }
            if (Tools.Contains(password, specialChars))
            {
                score++;
            }
            if (password == "password" || password == "1234")
            {
                score = 0;
            }

            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak");
                    break;
                case 2:
                    Console.WriteLine("Medium");
                    break;
                case 3:
                    Console.WriteLine("Strong");
                    break;
                case 4:
                    Console.WriteLine("Extremely strong");
                    break;
                case 5:
                    Console.WriteLine("Extremely strong");
                    break;
                default:
                    Console.WriteLine("Password doesn't meet the standards. Follow the guidelines \r\nor refrain from using passwords like 'password' or '1234'.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
