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
                int buttonNumberTemp = consolePrinter.ChoiseButton(buttonNumber); //выбор кнопки
                if (buttonNumber != buttonNumberTemp) buttonNumber = buttonNumberTemp;
                else
                {
                    switch (buttonNumber)
                    {
                        case 0:
                            NewGame(buttons[0], consolePrinter);
                            break;
                        case 1:
                            Resume(buttons[1], consolePrinter);
                            break;
                        case 2:
                            Stats(buttons[2], consolePrinter);
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void NewGame(Button button, ConsolePrinter consolePrinter)
        {
            consolePrinter.ConsolePrintDummy(button);
        }

        private void Resume(Button button, ConsolePrinter consolePrinter)
        {
            consolePrinter.ConsolePrintDummy(button);
        }

        private void Stats(Button button, ConsolePrinter consolePrinter)
        {
            consolePrinter.ConsolePrintDummy(button);
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
