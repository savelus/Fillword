using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class NewGame
    {
        public void StartNewGame(Button button)
        {
            var consolePrinter = new ConsolePrinter();
            string NamePerson = consolePrinter.ConsolePrintNamePersonInNewGame();
        }
    }
}
