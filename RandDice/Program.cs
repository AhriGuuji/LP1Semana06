using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            for (int i = 0; i < int.Parse(args[0]); i++)
            {
                Random value = new Random(int.Parse(args[1]));
                total += value.Next(0,7);
            }
            Console.WriteLine(total);
        }
    }
}
