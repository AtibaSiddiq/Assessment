using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value in pounds");
            decimal pounds = decimal.Parse(Console.ReadLine());
            decimal kilograms = pounds * 0.454m;
            System.Console.WriteLine("{0} pounds is {1} kilograms.", pounds, kilograms);
        }
    }
}
