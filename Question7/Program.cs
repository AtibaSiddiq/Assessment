using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            bool check = false;
            if(number % 5 == 0 && number % 7 == 0)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            System.Console.WriteLine(check);
        }
    }
}
