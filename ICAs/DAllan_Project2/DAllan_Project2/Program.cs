using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAllan_Project2
{
    class Program
    {
    /*********************************************************************************
    *
    *String Multiplier
    *
    *Accepts at least two arguments:
    *   1. Argument 1 is a positive integer that will become the multiplier.
    *
    *   2. The other args are strings that will be printed by the value of argument 1.
    *
    **********************************************************************************/
        static void Main(string[] args)
        {
            uint arg1 = 0; //Value container for argument 1.
            
            //Confirm I have at least two arguments.
            if (args.Count() < 2)
            {
                //Print error message and exit.
                PrintError("Invalid number of arguments (" + args.Count() + ")", "", true, true, -1);
            }

            //Confirm arg1 is a valid positive integer.
            try
            {
                arg1 = uint.Parse(args[0]);
            }
            catch (Exception e)
            {
                PrintError("Parsing error on argument: \"" + args[0] + "\"", e.Message, true, true, -2);
            }

            //Print remaining args by the value of arg1.
            for (int i = 0; i < arg1; i++)
            {
                for (int j = 1; j < args.Count(); j++)
                {
                    Console.Write(args[j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PrintError(string Err = "Unknown Failure", string Dbg = "", bool printUsage = true, bool exit = false, int exitVal = 1)
        {
            //Print error message.
            ConsoleColor currBackColor = Console.BackgroundColor;
            ConsoleColor currForeColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red; //Prints error message in red.
            Console.Error.WriteLine("Error: " + Err);
            if (Dbg.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //Prints debug message in yellow.
                Console.Error.WriteLine(Dbg);
            }
            Console.ForegroundColor = currForeColor;
            Console.BackgroundColor = currBackColor;

            if (printUsage) PrintUsage();

            if (exit) Environment.Exit(exitVal);
        }

        static void PrintUsage() //Usage message that describes program function.
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + " <arg1> <args>" +
                                " where <arg1> is a \npositive integer greater than zero.\nPrints remaining <args> by "
                                + "the value of <arg1>.");
        }
    }
}
