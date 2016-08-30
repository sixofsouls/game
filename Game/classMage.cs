using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class classMage
    {
        public void iceLance()
        {
            Console.WriteLine("You throw a piercing ice into target");
        }

        public void fireball()
        {
            Console.WriteLine("You blast a target with fireball");
        }

        public void felBlast()
        {
            Console.WriteLine("You inflame a target with demonic fire");
        }

        public void blink()
        {
            Console.WriteLine("You are blinking in a short distance, avoiding the damage");
        }

        enum Spellbook
        {
            fireball = 1,
            iceLance = 2,
            felBlast = 3,
            blink = 4
        }
    }
}
