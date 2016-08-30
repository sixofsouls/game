using System;
using System.Collections.Generic;
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
            Console.WriteLine("\nYou encounter stone golem");
            Console.WriteLine("\nWhat are you going to do? Here are the spells you can use");
            var abilityUsed = new classMage();
            var validNumber = false;
            while (!validNumber)
            {
                var enteredNumber = 0;
                int.TryParse()
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
}
