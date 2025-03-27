using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            Random value = new Random(int.Parse(args[1]));
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                total += value.Next(1,7);
            }
            Console.WriteLine(total);
        }
    }
}
