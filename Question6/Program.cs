using System;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a three or more digit number");
            int number = int.Parse(Console.ReadLine());
            int thirdNum = (number % 1000) / 100;
            bool check = false;
            if(thirdNum == 7)
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

