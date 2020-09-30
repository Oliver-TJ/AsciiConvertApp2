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
            if (((65 <= asc) && (asc >= 90)) || ((95 <= asc) && (asc >= 120)))
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