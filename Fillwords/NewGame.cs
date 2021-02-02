using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Fillwords
{
    public class NewGame
    {
        public Random random = new Random();
        public  static void StartNewGame()
        {
            var consolePrinter = new ConsolePrinter();
            string NamePerson = consolePrinter.ConsolePrintNamePersonInNewGame();
            int[] size = consolePrinter.InputSize();
        }
        public char[,] fillWords(int[] size, string[] allwords)
        {
            Random rnd = new Random();
            string[] allWords = File.ReadAllLines("WordList.txt");
            int width = size[1];
            int height = size[0];
            char[,] field = new char[height, width];
            int numberOfCharacters = height * width;
            int[,] priorityCell = FillPriority(height, width);
            List<string> wordsInGame = new List<string>();
            List <int[][]> indexSymbolInWords = new List<int[][]>();
            while (numberOfCharacters > 6)
            {
                string word = "";
                do
                {
                    word = allWords[rnd.Next(allWords.Length)];
                }
                while (word.Length > numberOfCharacters);
                numberOfCharacters -= word.Length;

                int[][] coordinatesSymbolInWord = new int[word.Length][]; //[номер буквы][y,x]
                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        int[] coordinatesCell = SelectPriorityCell(priorityCell, out int minPriority);
                        if (minPriority == 1)
                        {
                            coordinatesSymbolInWord[i][0] = coordinatesCell[0];
                            coordinatesSymbolInWord[i][1] = coordinatesCell[1];
                        }
                        else
                        {

                        }
                    }
                }
            }
            return field;
        }
        /*private int[] SetFirstSymbol (int[,] priorityCell)
        {
            
            do
            {
                Random rand = new Random();
                //выбор случайной клетки
            }
            while (0 == 0);
            return ;
        }
        */
        private int[] SelectPriorityCell(int[,] priorityCell, out int minPriority)
        {
            int[] coordinates = new int[2];
            minPriority = 5;
            for (int i = 0; i < priorityCell.GetLength(0); i++)
            {
                for (int j = 0; j < priorityCell.GetLength(1); j++)
                {
                    if (priorityCell[i, j] < minPriority)
                    {
                        minPriority = priorityCell[i, j];
                        coordinates[0] = i;
                        coordinates[1] = j;
                    }
                }
            }
            return coordinates;
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
