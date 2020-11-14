using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class ConsolePrinter
    {
        public void ConsolePrintNameGame (int cursorLeft, int cursorTop)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine(" _____  _  _  _ __        __              _          ");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine("|___  |(_)| || |\\ \\      / /  ___   __ _ | |__   ___ ");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine("   _| || || || | \\ \\ /\\ / /  / _ \\ |__` || '_ \\ |__ \\");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine("  |_  || || || |  \\ V  V /  | (_) |   | || |_) |/ __/");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine("    |_||_||_||_|   \\_/\\_/    \\___/    |_||_.__/ \\___|");
        }
        public void ConsolePrintButton(int cursorLeft, int cursorTop, int width, string inputname)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine($"┌{new string('─', width - 2)}┐");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine($"│{new string(' ', (18 - inputname.Length) / 2)}" +
                              $"{inputname}{new string(' ', (18 - inputname.Length - (18 - inputname.Length) / 2))}│");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine($"└{new string('─', width - 2)}┘");
        }

    }
}
