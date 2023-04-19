using System;
using System.Collections.Generic;

namespace VSCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;

            while(true){
                choice = "";
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Quadratic Formula (QF)");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please enter the abreviation for which program you would like to use:");
                Console.ForegroundColor = ConsoleColor.Blue;

                while(choice != "qf"){
                    choice = Console.ReadLine().ToLower();
                    if(choice == "qf"){
                        Console.Clear();
                        QuadraticFormula.QF();
                    }
                }
            }
        }
    }
}