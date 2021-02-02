using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class Stats
    {
        public static void StartStats(Button button)
        {
            var consolePrinter = new ConsolePrinter();
            consolePrinter.ConsolePrintDummy(button);
        }

    }
}
