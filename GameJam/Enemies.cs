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
        public string Cat { get; } = "EvilCat";
        public int Catlives { get; private set; }

        public Enemies( int catlives) 
        {
            Catlives = 4;
        }
        public Enemies Clone()
        {
            return new Enemies(this.Catlives);
        }

        public void CatAttack()
        {
            Random rand = new Random();
            int catAttack = rand.Next(1, 4);
            if (catAttack == 1)
            {
                Console.WriteLine("The cat scratches you! You lose 1 life.");
                Catlives -= 1;
            }
            else if (catAttack == 2)
            {
                Console.WriteLine("The cat bites you! You lose 2 lives.");
                Catlives -= 2;
            }
            else
            {
                Console.WriteLine("The cat pounces on you! You lose 3 lives.");
                Catlives -= 3;
            }
        }
    }
  
}
