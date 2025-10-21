using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public class Character
    {
    private const int DefaultLives = 10; 
        public string Name { get; } = "Mouse";
        public int Lives { get; private set; }

        public Character()
        {
            Lives = DefaultLives;
        }

        // Tjek om spilleren lever
        public bool IsAlive() => Lives > 0;

        // Spilleren tager skade
        public void TakeDamage(int amount)
        {
            Lives -= amount;
            if (Lives < 0) Lives = 0;
            Console.WriteLine($"{Name} mister {amount} liv! ({Lives} HP tilbage)");

            if (!IsAlive())
            {
                Console.WriteLine($"{Name} er død! Game Over!");
            }
        }
    }
}
