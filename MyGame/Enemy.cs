using System;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }
        
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public float GetShield()
        {
            return shield;
        }
        public float GetHealth()
        {
            return health;
        }

        public void SetName(string newName)
        {
            if (newName.Length > 8) name = newName.Substring(0,8);
            else name = newName;
        } 

        public void PickupPowerUp(PowerUp powerUp,float amount)
        {
            if (powerUp == PowerUp.Health)
            {
                health += amount;
                if (health > 100) {health = 100;}
            }
            if (powerUp == PowerUp.Shield)
            {
                shield += amount;
                if (shield > 100) {shield = 100;}
            }
        }
    }
}