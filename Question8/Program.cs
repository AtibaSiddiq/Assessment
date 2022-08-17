using System;

namespace Question8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight on the earth");
            double weightOnEarth = double.Parse(Console.ReadLine());
            double weightOnMoon = weightOnEarth * 0.17; 
            System.Console.WriteLine("You weight on the moon is approximately {0}", weightOnMoon);
        }
    }
}
