using System;


public class GameLevel
    {
        private int manyRooms;
        private Hardness howHard;
        private int manyEnemies;
        private MyRPG.Enemy[] enemie;

        public GameLevel(int manyRooms, Hardness howHard)
        {
            this.manyRooms = manyRooms;
            this.howHard = howHard;
            enemie = new MyRPG.Enemy[manyRooms];
            manyEnemies = 0;
            
        }

        public void SetEnemyInRoom(int idRom, MyRPG.Enemy enemy)
        {
            enemie[idRom] = enemy;
            manyEnemies++;
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
            foreach (MyRPG.Enemy enemy in enemie)
                Console.WriteLine($"Room {Array.IndexOf(enemie,enemy)}: {enemy.GetName()}");
        }
    }
    public enum PowerUp {Health, Shield};
