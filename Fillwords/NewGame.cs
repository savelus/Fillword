using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fillwords
{
    public class NewGame
    {
        public void StartNewGame()
        {
            var consolePrinter = new ConsolePrinter();
            string NamePerson = consolePrinter.ConsolePrintNamePersonInNewGame();
            int[] size = consolePrinter.InputSize();
            int width = size[1];
            int height = size[0];
            char[,] field = new char[height, width];
            int[,] priorityCell = FillPriority(height, width);
        }
        private int[,] FillPriority(int height, int width)
        {
            int[,] priorityCell = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i % (height - 1) == 0 || j % (width - 1) == 0)
                    {
                        if (j % (width - 1) == 0 && i % (height - 1) == 0)
                        { priorityCell[i, j] = 2; }
                        else
                        { priorityCell[i, j] = 3; } 
                    }
                    else
                    { priorityCell[i, j] = 4; }
                }
            }
            return priorityCell;
        }
        
    }
}
