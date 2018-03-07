using System;

namespace ReverseString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string name = "Rune";
            string reversedName = "";

            foreach (var character in name)
            {
                reversedName = character + reversedName;
            }

            Console.WriteLine(reversedName);
            Console.ReadKey();
        }
    }
}
