using System;

namespace WhileExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int months = 24;
            int annieSavings = 0;

            while (months != 0)
            {
                annieSavings += 300;
                months--;
            }

            Console.WriteLine(annieSavings);
        }
    }
}
