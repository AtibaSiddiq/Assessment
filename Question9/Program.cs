using System;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            double account = 0;
            Console.WriteLine("Enter a monthly savings amount");
            double savings = double.Parse(Console.ReadLine());
            for(int i = 0; i < 6; i++)
            {
                if(i == 0)
                {
                    account = savings * (1 + 0.00417);
                }
                else
                {
                    account = (savings + account) * (1 + 0.00417);
                }
            }
            System.Console.WriteLine("After the sixth month, the account value is " + account);
        }
    }
}
