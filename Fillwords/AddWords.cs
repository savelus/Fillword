using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class AddWords
    {
        ConsolePrinter consolePrinter = new ConsolePrinter();
        public void StartAddWords()
        {

            Button[] buttonsAdd = new Button[] { new Button("Show all words"), new Button("Add word"),
                                                 new Button ("Return in Menu") };
            ConsolePrinter.Clear();
            int buttonNumber = 0;
            while (true)
            {
                var menu = new Menu();
                menu.PrintButtons(buttonsAdd, buttonNumber);
                int buttonNumberTemp = consolePrinter.SwitchingButton(buttonNumber, buttonsAdd.Length);
                if (buttonNumber != buttonNumberTemp) buttonNumber = buttonNumberTemp;
                else
                {
                    ChoiseButton(buttonNumber, buttonsAdd);
                }
            }
        }
        public void ChoiseButton(int buttonNumber, Button[] buttons)
        {
            switch (buttonNumber)
            {
                case 0:
                    ShowAllWords(buttons[0]);
                    break;
                case 1:
                    AddWord(buttons[1]);
                    break;
                case 2:
                    var menu = new Menu();
                    menu.CreateWindow();
                    break;
            }
        }

        public void ShowAllWords(Button button)
        {
            ConsolePrinter.ConsolePrintDummy(button);
        }

        public void AddWord(Button button)
        {
            ConsolePrinter.ConsolePrintDummy(button);
        }

    }
}
