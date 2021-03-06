﻿using System;

namespace Example
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DisplayNumbers(6);
        }

        private static void DisplayNumbers(int iterations)
        {
            for (int i = 1; i < iterations; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

            // The -2 is needed because it needs one less iteration
            for (int i = iterations - 2; i > 0; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }

                for (int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }
        }
    }
}
