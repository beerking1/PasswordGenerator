using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PassGen());
            Console.ReadKey();
        }
        public static string PassGen()
        {
            string password = string.Empty;
            string smallLetters = "abcdefghijklmnopqrstuvwxyz";
            string bigLetters = "ABCDEGFGHIJKLMNOPQRSTUVWXYZ";
            string numbers = "0123456789";
            string specialChars = "/*-+´=)§¨$,.-_:?!'(ˇ%°;";
            Random chars = new Random();
            for (int i = 0; i < 3; i++)
            {
                password += numbers[chars.Next(numbers.Length)];
                password += smallLetters[chars.Next(smallLetters.Length)];
                password += bigLetters[chars.Next(bigLetters.Length)];                
                password += specialChars[chars.Next(specialChars.Length)];
            }
            return $"Your new password is: {password}";
        }
    }
}
