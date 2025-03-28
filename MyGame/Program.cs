using System;


namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int numberEnemies = int.Parse(args[0]);
            Enemy[] enemies = new Enemy[numberEnemies];
            for (int i = 0; i < numberEnemies; i++)
            {
                Console.Write($"Nome do inimigo {i+1}: ");
                enemies[i] = new Enemy(Console.ReadLine());
            }


            for (int i = 0; i < numberEnemies; i++)
            {
                Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}");
            }

            Console.WriteLine(Enemy.HowManyPowerUps());
        }
    }

    public enum PowerUp {Health, Shield};
}
