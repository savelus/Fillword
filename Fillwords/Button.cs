using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fillwords
{
    public class Button
    {
        static int width = 20;
        public int height = 3;
        public string inputname;

        public Button(string name) 
        {
            inputname = name;
        }

        public void PrintButton (int cursorLeft, int cursorTop)
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
