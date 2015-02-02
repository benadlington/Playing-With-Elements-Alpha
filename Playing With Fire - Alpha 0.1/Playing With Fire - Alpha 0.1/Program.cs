﻿#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;
using Playing_With_Fire___Alpha_0._1.Map_Editor;
#endregion

namespace Playing_With_Fire___Alpha_0._1
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();
        }
    }
#endif
}
