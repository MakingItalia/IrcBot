using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcBot
{
    /// <summary>
    /// Console Utility for Drawing, Cursor, graphics and more
    /// </summary>
    public class ConsoleUtility
    {


        /// <summary>
        /// Change Console Color
        /// </summary>
        /// <param name="ForeGround">Foreground Color</param>
        /// <param name="Background">Background Color</param>
        public static void ChangeColor(ConsoleColor ForeGround, ConsoleColor Background)
        {
            Console.BackgroundColor = Background;
            Console.ForegroundColor = ForeGround;
        }


        /// <summary>
        /// Set Default Color
        /// </summary>
        public static void DefaultColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }


        /// <summary>
        /// Show Waring Message
        /// </summary>
        /// <param name="msg">Message</param>
        public static void WaringMessage(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write(@"/!\ Warning:");

            DefaultColor();

            Console.Write(" ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(msg);

            DefaultColor();
        }



        /// <summary>
        /// Show Error Message
        /// </summary>
        /// <param name="msg">Message</param>
        public static void ErrorMessage(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("[ ! ] Error:");

            DefaultColor();
            Console.Write(" ");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            
            DefaultColor();
        }



        /// <summary>
        /// Show a Information Message
        /// </summary>
        /// <param name="msg">Message</param>
        public static void InfoMessage(string msg)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.Write("( ? ) Info:");

            DefaultColor();
            Console.Write(" ");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(msg);

            DefaultColor();
        }




    }
}
