using System;
using System.Collections.Generic;

namespace Question5
{
    class Program
    {

        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a four digit number");
            int abcd = int.Parse(Console.ReadLine());
            int firstNum = abcd / 1000;
            int secNum = (abcd / 100) % 10;
            int thirdNum = (abcd / 10) % 10;
            int fourthNum = abcd % 10;
            int sum = firstNum + secNum + thirdNum + fourthNum;
            System.Console.WriteLine("The sum of the four digit number is " + sum);
            System.Console.WriteLine($"{fourthNum}, {thirdNum}, {secNum}, {firstNum}"); 
            System.Console.WriteLine($"{fourthNum}, {secNum}, {thirdNum}, {firstNum}"); 
            System.Console.WriteLine($"{firstNum}, {thirdNum}, {secNum}, {fourthNum}"); 
        }
    }
}
