using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class Menu
    {

        public void CreateWindow()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Button[] buttons = new Button[] {new Button("New game"), new Button("Resume"), 
                                             new Button("Stats"), new Button("Quit the Game") };
            Console.SetWindowSize(120, 30);
            ConsolePrinter nameGame = new ConsolePrinter();
            nameGame.ConsolePrintNameGame(35, 2);
            PrintButtons(buttons); // отрисовка кнопок
            Console.ReadKey();
        }

        private void PrintButtons(Button[] buttons)
        {
            int cursorLeft = 50;
            int cursorTop = 10;
            foreach(Button button in buttons)
            {
                button.PrintButton(cursorLeft, cursorTop);
                cursorTop += 3;
            }
        }
    }
}
