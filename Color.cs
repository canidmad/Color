//Author: Canidmad (2018)
/////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console asks for Canid's favorite color
            //Don't forget to upload this to Google Drive
            Console.WriteLine("What's Canid's favorite color?");
            var color = Console.ReadLine();
            //if the user gets the question correct
            bool Blue = true;

            if (Blue)
            {
                Console.WriteLine("You are... correct! You must know him or maybe that was a lucky guess.");
            }
            //user answers question incorrectly
            else
            {
                Console.WriteLine("Nope, Incorrect!");
            } 

                Console.Write("Well, you can go now!");
                Console.ReadKey();
            

        }
    }
}
