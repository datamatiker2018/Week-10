using System;

namespace GotoFortran
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = -6;

            if (x < 0)
            {
                x = MakePositive(x);
                x = IncrementNumber(x);
            }
            else if (x > 0)
            {
                x = IncrementNumber(x);
            }
            else
            {
                x = 1;
            }

            Console.WriteLine(x);
            Console.ReadKey();
        }

        private static int MakePositive(int number)
        {
            return -number;
        }

        private static int IncrementNumber(int number)
        {
            return ++number;
        }
    }
}
