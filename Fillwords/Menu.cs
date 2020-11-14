using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class Menu
    {
        public void CreateWindow()
        {
            Button[] buttons = new Button[] {new Button("New game"), new Button("Resume"),
                                             new Button("Stats"), new Button("Quit the Game") };
            Console.SetWindowSize(120, 30);
            ConsolePrinter consolePrinter = new ConsolePrinter();
            int buttonNumber = 0;
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();
                consolePrinter.ConsolePrintNameGame(35, 2); //Название игры
                PrintButtons(buttons, buttonNumber); // отрисовка кнопок
                buttonNumber = consolePrinter.ChangeButtons(buttonNumber);
            }
        }

        private void PrintButtons(Button[] buttons, int buttonNumber)
        {
            int cursorLeft = 50;
            int cursorTop = 10;
            
            for(int i = 0; i < 4; i++)
            {
                bool changeColor = false;
                if (i == buttonNumber) changeColor = true;
                buttons[i].PrintButton(cursorLeft, cursorTop, changeColor);
                cursorTop += 3;

            }
        }
    }
}
