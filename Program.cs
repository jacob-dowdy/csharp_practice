using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }   
            }
            Console.WriteLine($"The sume is {sum}");
        }
    }
}