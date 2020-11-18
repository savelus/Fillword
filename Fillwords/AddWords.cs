using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class AddWords
    {
        public void StartAddWords(Button button)
        {
            var consolePrinter = new ConsolePrinter();
            consolePrinter.ConsolePrintDummy(button);
        }
    }
}
