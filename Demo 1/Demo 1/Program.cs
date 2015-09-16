using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    class Program
    {
        /**********************************************************
        *
        * Accepts one argument must be a positibe integer > 0
        * Outputs space delimitted list of prime factors of arg 1.
        *
        ***********************************************************/
        static void Main(string[] args)
        {
            //Confirm I have one argument (exactly)
            //Confirm that it is a positive integer
            //Generate facors (if possible)
            if (args.Count() != 1)
            {
                //Print error and exit
                PrintError("Invalid number of arguments (" + args.Count() + ")", "", true, true, -1);
            }
            //for testing.
            Console.ReadKey();
        }

        static void PrintError(string Err = "Unknown Failure", string Dbg = "", 
                                bool printUsage = true, bool exit = false, int exitVal = 1)
        {
            //1 Print out error message.
            ConsoleColor currBackColor = Console.BackgroundColor;
            ConsoleColor currForeColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Error: " + Err);
            if (Dbg.Length>0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Error.WriteLine(Dbg);
            }
            if (printUsage)
                PrintUsage();
            Console.ForegroundColor = currForeColor;
            Console.BackgroundColor = currBackColor;
            //for testing.
            Console.ReadKey();
            if (exit)
                Environment.Exit(exitVal); //By convention, exit with a value != 0 for error. i.e. if exitVal = 0, program has run without any errors.
           


        }

        //General usage message.
        static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + "<val>" +
                                "where <val> is a \npositive integer greater than zero. Prints a\nspace delimitted" +
                                " list of primt factors of only \nargument");

        }
    }
}
