using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IrcBot
{
    /// <summary>
    /// Console Utility for Drawing, Cursor, graphics and more
    /// </summary>
    class ConsoleUtility
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

    }
}
