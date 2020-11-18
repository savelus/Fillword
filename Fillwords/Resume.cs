using System;
using System.Collections.Generic;
using System.Text;

namespace Fillwords
{
    public class Resume
    {
        public void StartResume(Button button)
        {
            var consolePrinter = new ConsolePrinter();
            consolePrinter.ConsolePrintDummy(button);
        }
    }
}
