using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fillwords
{
    public class Menu
    {
        public void CreateWindow()
        {
            Button[] buttonsMenu = new Button[] {new Button("New game"), new Button("Resume"),
                                             new Button("Stats"), new Button ("Add words"),
                                             new Button("Quit the Game") };
            Console.SetWindowSize(120, 30);
            ConsolePrinter consolePrinter = new ConsolePrinter();
            int buttonNumber = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true)
            {
                consolePrinter.ConsolePrintNameGame(35, 2); //Название игры
                PrintButtons(buttonsMenu, buttonNumber); // отрисовка кнопок
                int buttonNumberTemp = consolePrinter.SwitchingButton(buttonNumber, buttonsMenu.Length); //выбор кнопки
                if (buttonNumber != buttonNumberTemp) buttonNumber = buttonNumberTemp;
                else
                {
                    ChoiseButton(buttonNumber, buttonsMenu);
                }
            }
        }

        public void ChoiseButton(int buttonNumber, Button[] buttons)
        {
            switch (buttonNumber)
            {
                case 0:
                    var newGame = new NewGame();
                    newGame.StartNewGame(buttons[0]);
                    break;
                case 1:
                    var resume = new Resume();
                    resume.StartResume(buttons[1]);
                    break;
                case 2:
                    var stats = new Stats();
                    stats.StartStats(buttons[2]);
                    break;
                case 3:
                    var addWords = new AddWords();
                    addWords.StartAddWords();
                    break;
                case 4:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        public void PrintButtons(Button[] buttons, int buttonNumber)
        {
            int cursorLeft = 50;
            int cursorTop = 10;
            
            for(int i = 0; i < buttons.Length; i++)
            {
                bool changeColor = false;
                if (i == buttonNumber) changeColor = true;
                buttons[i].PrintButton(cursorLeft, cursorTop, changeColor);
                cursorTop += 3;
            }
        }
    }
}
