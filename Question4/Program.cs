using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 2; i < number; i++)
            {
                if(number % i == 0)
                {
                        
                    count++;
                    break;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
        }
    }
}
