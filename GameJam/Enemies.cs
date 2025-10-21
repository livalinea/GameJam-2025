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

        public void TakeDamage(int amount)
        {
            if (!IsAlive())
            {
                Console.WriteLine($"{Name} er allerede besejret!");
                return;
            }

            Lives = Lives - amount;

            if (Lives < 0) Lives = 0;
            Console.WriteLine($"{Name} mister {amount} liv! ({Lives} HP tilbage)");

            if (!IsAlive())
            {
                Console.WriteLine($"{Name} er besejret!");
            }
        }
            
       // Tjek om katten stadig lever
       public bool IsAlive() => Lives > 0;
    }
}
    

