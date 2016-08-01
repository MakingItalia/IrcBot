using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace IrcBot
{
    class Program
    {
        /* ==========================================
         * IrcBOT Engine
         * By Thejuster ( Making Italia)
         * Free and OpenSource Project
         * ========================================= */


        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Credit(); //Show Credit

            Console.WriteLine("a");
            Console.ReadKey();
        }



        /// <summary>
        /// Simple void to Draw Credit
        /// </summary>
        static void Credit()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(@"=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o");
            Console.WriteLine(@"                                                                             ");
            Console.WriteLine(@" _____            ______                _______             _                ");
            Console.WriteLine(@"(_____)          (____  \       _      (_______)           (_)               ");
            Console.WriteLine(@"   _    ____ ____ ____)  ) ___ | |_     _____   ____   ____ _ ____   ____    ");
            Console.WriteLine(@"  | |  / ___) ___)  __  ( / _ \|  _)   |  ___) |  _ \ / _  | |  _ \ / _  )   ");
            Console.WriteLine(@" _| |_| |  ( (___| |__)  ) |_| | |__   | |_____| | | ( ( | | | | | ( (/ /    ");
            Console.WriteLine(@"(_____)_|   \____)______/ \___/ \___)  |_______)_| |_|\_|| |_|_| |_|\____)   ");
            Console.WriteLine(@"                                                     (_____|                 ");
            Console.WriteLine(@"                                                                             ");
            Console.WriteLine(@"=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o,.o=o");
            Thread.Sleep(2000);
        }
    }
}
