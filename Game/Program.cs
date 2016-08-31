﻿using System;
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
        static void Main(string[] args)
        {

            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("Welcome to this simple game");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("\nIntroduce yourself\n");
            int LifePoints = 100;
            if (LifePoints == 0)
            {
                Console.WriteLine("You are dead");
                Console.WriteLine("GAME OVER");
                Console.ReadLine();
            }
            var playerName = "";

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
            Console.WriteLine("****************************");
            Console.WriteLine("Well, right now you can only play mage");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("****************************");
            Console.WriteLine("\n\n"+ playerName + ", you are being teleported into battle");
            Console.WriteLine("\nYou encounter stone golem, what you are gonna do?");
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
                    LifePoints--;
                    Console.WriteLine("You have " + LifePoints + " life remaining");
                }
                else if (input_.Contains("fireball"))
                {
                    abilityUsed.fireball();
                    Console.WriteLine("");
                    LifePoints--;
                    LifePoints--;
                    Console.WriteLine("You have " + LifePoints + " life remaining");
                }
                else if (input_.Contains("blink"))
                {
                    abilityUsed.blink();
                    Console.WriteLine("");
                    Console.WriteLine("You have " + LifePoints + " life remaining");
                }
                
            }
            //       else if (input_.Contains())
        }
            //var input_ = Console.ReadLine();
            //int input_parsed;
            //if (int.TryParse(input_, out input_parsed))
            //{
            //    abilityUsed.felBlast();
            //}
            //else Console.WriteLine("Invalid input... Select a number");

        }
}

