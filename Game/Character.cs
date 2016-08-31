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
    }
}
