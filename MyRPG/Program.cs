using System;

namespace MyRPG
{
    public class Program
    {
        private static void Main()
        {
            GameLevel gl = new GameLevel(104, Hardness.Normal);

            gl.SetEnemyInRoom(1, new Enemy("Worf"));
            gl.SetEnemyInRoom(7, new Enemy("Picard"));
            gl.SetEnemyInRoom(16, new Enemy("Data"));
            gl.SetEnemyInRoom(94, new Enemy("Riker"));
            gl.SetEnemyInRoom(59, new Enemy("Troi"));

            Console.WriteLine($"Difficulty: {gl.GetHardness()}");

            Console.WriteLine($"Number of rooms: {gl.GetNumRooms()}");

            Console.WriteLine($"Number of enemies: {gl.GetNumEnemies()}");

            gl.PrintEnemies();

            // Este programa mostra o seguinte no ecrã:
            //
            // Difficulty: Normal
            // Number of rooms: 104
            // Number of enemies: 5
            // Room I: Worf
            // Room VII: Picard
            // Room XVI: Data
            // Room LIX: Troi
            // Room XCIV: Riker
        }
    }

    public class GameLevel
    {
        private int manyRooms;
        private Hardness howHard;
        private int manyEnemies;
        private Enemy[] enemie;

        public GameLevel(int manyRooms, Hardness howHard)
        {
            this.manyRooms = manyRooms;
            this.howHard = howHard;
            manyEnemies = enemie.Length;
        }

        public void SetEnemyInRoom(int idRom, Enemy enemy)
        {
            enemie[idRom] = enemy;
        }

        public Hardness GetHardness()
        {
            return howHard;
        }

        public int GetNumRooms()
        {
            return manyRooms;
        }

        public int GetNumEnemies()
        {
            return manyEnemies;
        }

        public void PrintEnemies()
        {
            foreach (Enemy enemy in enemie)
                Console.WriteLine($"Room {enemie}: {enemy.GetName()}");
        }
    }
    public enum PowerUp {Health, Shield};
}
