using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Fillwords
{
    public class Button
    {
        public int width = 20;
        public int height = 3;
        public string inputname;

        public Button(string name) 
        {
            inputname = name;
        }

        public void PrintButton(int cursorLeft, int cursorTop, bool changeColor)
        {
            ConsolePrinter printButton = new ConsolePrinter();
            printButton.ConsolePrintButton(cursorLeft, cursorTop, width, inputname, changeColor);
        }
    }
}
