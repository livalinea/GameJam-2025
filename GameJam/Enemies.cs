using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameJam
{
    public class Enemies
    {
        private const int DefaultLives = 4;  // Alle katte starter med 4 liv
        public string Name { get; } = "Evil Cat";
        public int Lives { get; private set; }

        public Enemies()
        {
            Lives = DefaultLives;
        }

        public Enemies Clone()
        {
            return new Enemies();
        }

        // TakeDamage tager nu et parameter: listen over katte i rummet
        public void TakeDamage(int amount, List<Enemies> roomEnemies)
        {
            if (!IsAlive())
            {
                Console.WriteLine($"{Name} er allerede besejret!");
                return;
            }

            Lives -= amount;
            if (Lives < 0) Lives = 0;

            Console.WriteLine($"{Name} mister {amount} liv! ({Lives} HP tilbage)");

            if (!IsAlive())
            {
                Console.WriteLine($"{Name} er besejret!");
            }

            // Opsummer alle katte i listen
            int totalLives = 0;
            foreach (var cat in roomEnemies)
            {
                totalLives += cat.Lives;
            }

            Console.WriteLine($"Samlet antal liv for alle kattene: {totalLives}");
        }

        public bool IsAlive() => Lives > 0;
    }
}




