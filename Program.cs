using System;

namespace App35
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] numbers = text.Split(" ");
            string reverse = "";

            for (int i = numbers.Length - 1; i > -1; i--)
            {                
                reverse += numbers[i] + " ";
            }
            Console.WriteLine(reverse);
        }
    }
}
