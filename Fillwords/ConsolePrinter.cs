﻿using System;
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
        public void ConsolePrintButton(int cursorLeft, int cursorTop, int width, string inputname, bool changeColor)
        {
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            if (changeColor) Console.BackgroundColor = ConsoleColor.Cyan;
            else Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"┌{new string('─', width - 2)}┐");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine($"│{new string(' ', (18 - inputname.Length) / 2)}" +
                              $"{inputname}{new string(' ', (18 - inputname.Length - (18 - inputname.Length) / 2))}│");
            Console.SetCursorPosition(cursorLeft, cursorTop++);
            Console.WriteLine($"└{new string('─', width - 2)}┘");
        }


        public int SelectButton(int buttonNumber)
        {
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter) return buttonNumber;
                else if (key.KeyChar == 'w' || key.Key == ConsoleKey.UpArrow)
                {
                    if (buttonNumber == 0) return 3;
                    else return buttonNumber-=1;
                }
                else if (key.KeyChar == 's' || key.Key == ConsoleKey.DownArrow)
                {
                    if (buttonNumber == 3) return 0;
                    else return buttonNumber+=1;
                }
                else continue;
            }
        }

        public void ConsolePrintDummy (Button button)
        {
            Console.Clear();
            Console.SetCursorPosition(((120 - button.inputname.Length - 20) / 2), 10);
            Console.WriteLine($"Здесь однажды будет \"{button.inputname}\"");
            Console.SetCursorPosition(((120 - button.inputname.Length - 20) / 2), 11);
            Console.WriteLine("Нажмите любую кнопку, чтобы выйти.");
            Console.ReadKey();
        }

        public string ConsolePrintNameParsonInNewGame()
        {

            Console.Clear();
            Console.SetCursorPosition((120 - 16)/2, 10);
            Console.WriteLine("Введите ваше имя");
            Console.CursorVisible = true;
            Console.SetCursorPosition((120 - 16) / 2, 11);
            string namePerson = Console.ReadLine();
            Console.CursorVisible = false;
            return namePerson;
        }
    }
}
