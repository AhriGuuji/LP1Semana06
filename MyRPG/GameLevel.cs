using System;
using System.Linq;
using Humanizer;

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
            for (int i=0; i < manyRooms; i++)
            {
                enemie.Append(null);
            }
            manyEnemies = 0;
            
        }

        public void SetEnemyInRoom(int idRom, MyRPG.Enemy enemy)
        {
            if (enemie[manyRooms] != null) return;
            enemie[manyRooms] = enemy;
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
            {
                if (enemy == null) continue;
                int index = enemie.IndexOf(enemy);
                Console.WriteLine($"Room {index.ToRoman()}: {enemy.GetName()}");
            }
        }
    }
    public enum PowerUp {Health, Shield};
