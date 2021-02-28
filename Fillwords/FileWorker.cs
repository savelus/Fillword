using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Fillwords
{
    class FileWorker
    {
        public static string[] ReadFile(string nameDoc)
        {
            return File.ReadAllLines(nameDoc);
        }
    }
}
