using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class classMage
    {
        public void icelance()
        {
            Console.WriteLine("\nYou throw a piercing ice into target\n");
        }

        public void fireball()
        {
            Console.WriteLine("\nYou blast a target with fireball\n");
        }

        public void felblast()
        {
            Console.WriteLine("\nYou inflame a target with demonic fire\n");
        }

        public void blink()
        {
            Console.WriteLine("\nYou are blinking in a short distance, avoiding the damage\n");
        }

        public void showSpellbook()
        {
            Console.WriteLine("These are your spells..");
            Console.WriteLine("Ice Lance");
            Console.WriteLine("Fireball");
            Console.WriteLine("Fel Blast");
            Console.WriteLine("Blink");
        }

    }
}
