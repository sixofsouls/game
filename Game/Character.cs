using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class Character
    {
        private int health;
        private int mana;

        public int Health
        {
            get { return this.health; }
            set
            {
                if (value <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("\n************\nYou are dead \n GAME OVER");
                }
                else
                {
                    health = value;
                }
            }
        }

        public int Mana
        {
            get { return mana; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("\n You are out of mana!");
                }
                else
                {
                    mana = value;
                } 
                
            }
        }
        
    }
}
