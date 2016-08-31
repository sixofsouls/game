using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static string PlayerName()
        {
            var playerName = "";
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("Welcome to this simple game");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("\nIntroduce yourself\n");

            while (true)
            {
                var input = Console.ReadLine();
                const string pattern = @"^[a-zA-Z]+$";

                if (input != null && Regex.IsMatch(input, pattern))
                {
                    playerName = input;
                    Console.WriteLine("\n\n\n\nHi " + playerName);
                    Console.WriteLine("****************************");
                }

                else
                {
                    Console.WriteLine("Invalid name, try again");
                }
                if (playerName == input)
                {
                    break;
                }
            }
            return playerName;
        }
        static void Main(string[] args)
    {
        Character currentLife = new Character();
        currentLife.Health = 10;

        Console.WriteLine("\n\n" + PlayerName() + ", you are being teleported into battle");

        Console.WriteLine("\nYou encounter stone giant, what you are gonna do?");
            var abilityUsed = new classMage();
            while (true)
            {
                Console.WriteLine("Golem is getting closer...");
                var input_ = Console.ReadLine();
                input_ = input_.ToLower();
                if (input_.Contains("felblast"))
                {
                    abilityUsed.felblast();
                    Console.WriteLine("Golem explodes in a thousand pieces");
                    break;
                }
                if (input_.Contains("icelance"))
                {
                    abilityUsed.icelance();
                    Console.WriteLine(
                        "Golem freezes for a little while, then after a short while, throws a piece of stone in your face. You take 1 damage");
                    Console.WriteLine("You have " + currentLife.Health + " life remaining");
                }
                else if (input_.Contains("fireball"))
                {
                    abilityUsed.fireball();
                    Console.WriteLine(
                        "Fireball ignited and molted the giant. Then, it throws piece of lava at you. You take 2 damage");
                    currentLife.Health--;
                    currentLife.Health--;
                    Console.WriteLine("You have " + currentLife.Health + " life remaining");
                }
                else if (input_.Contains("blink"))
                {
                    abilityUsed.blink();
                    Console.WriteLine("");
                    Console.WriteLine("You have " + currentLife.Health + " life remaining");
                }
                else
                {
                    Console.WriteLine("Invalid input. No spell detected");
                }

            }
        }

        static void introduction(string[] args)
        {
        }
    }
}

