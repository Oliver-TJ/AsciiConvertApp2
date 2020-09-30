using System;

namespace asciiConvertApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            string g = Console.ReadLine();
            int asc = Convert.ToChar(g);
            if (((asc >= 65) && (asc <= 90)) || ((asc >= 97) && (asc <= 122)))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}