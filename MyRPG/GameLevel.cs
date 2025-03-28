using System;
using System.Linq;
using Humanizer;

namespace MyRPG
{
    public class GameLevel
    {
        private int manyRooms;
        private Hardness howHard;
        private int manyEnemies;
        private Enemy[] enemies;  // Changed from enemie to enemies

        public GameLevel(int manyRooms, Hardness howHard)
        {
            this.manyRooms = manyRooms;
            this.howHard = howHard;
            this.enemies = new Enemy[manyRooms];  // Initialize array with proper size
            this.manyEnemies = 0;
        }

        public void SetEnemyInRoom(int roomId, Enemy enemy)
        {
            // Check for valid room index and that the room is empty
            if (roomId >= 0 && roomId < manyRooms && enemies[roomId] == null)
            {
                enemies[roomId] = enemy;
                manyEnemies++;
            }
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
            for (int i = 0; i < enemies.Length; i++)
            {
                if (enemies[i] != null)
                {
                    // Note: Humanizer's ToRoman starts with 1, so we use i+1
                    Console.WriteLine($"Room {(i + 1).ToRoman()}: {enemies[i].GetName()}");
                }
            }
        }
    }

    public enum PowerUp { Shield, Health }
}