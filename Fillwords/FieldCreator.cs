using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Fillwords
{
    class FieldCreator
    {
        /*public Random random = new Random();
        public void StartfillField() //int[] size
        {
            int width = 10;//size[1];
            int height = 10;//size[0];
            char[,] field = new char[height, width];
            int[,] fieldPriorityCell = FillPriority(height, width);
             var wordsInGame = FillField(GetDictionaryWords(height, width), ref field, fieldPriorityCell);
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1) -1; j++)
                {
                    Console.Write(field[i, j] + "\t");

                }
                Console.WriteLine();
            }
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

        private Dictionary<string, int[,]> GetDictionaryWords(int height, int width)
        {
            string[] allWords = File.ReadAllLines("WordList.txt");
            int countAllWords = allWords.Length;
            int numberOfLetters = 0;
            int needLetters = height * width;
            var wordsInGame = new Dictionary<string, int[,]>();
            while (needLetters - numberOfLetters != 0)
            {
                string word = allWords[random.Next(countAllWords)];
                if (word.Length + numberOfLetters > needLetters || wordsInGame.ContainsKey(word))
                    continue;
                wordsInGame.Add(word, new int[2, word.Length]);
                numberOfLetters += word.Length;
            }
            return wordsInGame;
        }

        private int GetMinPriorityinAll(int[,] priorityCell)
        {
            int minPriority = priorityCell[0, 0];
            foreach ( var num in priorityCell)
            {
                if (num < minPriority)
                    minPriority = num;
            }
            return minPriority;
        }

        private List<int[]> GetAllCoordinatesMinPriorityArroundChar(int[,] priorityCell, List<int[]> coordinates)
        {
            int minPriority = priorityCell[coordinates[0][0], coordinates[0][1]];
            foreach (var num in coordinates)
            {
                if (priorityCell[num[0], num[1]] < minPriority)
                    minPriority = priorityCell[num[0], num[1]];
            }
            var newCoord = new List<int[]>();
            foreach (var coord in coordinates)
            {
                if(priorityCell[coord[0], coord[1]] == minPriority)
                {
                    newCoord.Add(coord);
                }
            }
            return newCoord;
        }

        private List<int[]> GetAllCoordinatesMinPriority(int[,] priorityCell, int minPriority)
        {
            List<int[]> allCoordMinPriority = new List<int[]>();
            for (int i = 0; i < priorityCell.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < priorityCell.GetLength(1) - 1; j++)
                {
                    if(minPriority == priorityCell[i,j])
                    {
                        allCoordMinPriority.Add(new int[] { i, j });
                    }
                }
            }
            return allCoordMinPriority;
        }
        
        enum Direction {Up, Right, Down, Left};

        private Dictionary<string, int[,]> FillField(Dictionary<string, int[,]> wordsInGame, ref char[,] field, int[,] priorityCell)
        {
           foreach( var pair in wordsInGame)
           {
                char[] wordByChar = pair.Key.ToCharArray();
                int[] coord = new int[2] {0, 0 };
                for (int i = 0; i < wordByChar.Length; i++)
                {
                    if (i == 0)
                    {
                        coord = GetRndCoord(GetAllCoordinatesMinPriority(priorityCell, GetMinPriorityinAll(priorityCell)));
                    }
                    else
                    {
                        var coordinatesArrChar = new List<int[]>();
                        if(coord[0] - 1 >= 0)
                        { 
                            coordinatesArrChar.Add(new int[] { coord[0] - 1, coord[1] });
                            priorityCell[coord[0] - 1, coord[1]] -= 1;    
                        }
                        if (coord[0] + 1 <= field.GetLength(0) - 1)
                        {
                            coordinatesArrChar.Add(new int[] { coord[0] + 1, coord[1] });
                            priorityCell[coord[0] + 1, coord[1]] -= 1;
                        }
                        if (coord[1] - 1 >= 0)
                        {
                            coordinatesArrChar.Add(new int[] { coord[0], coord[1] - 1 });
                            priorityCell[coord[0], coord[1] - 1] -= 1;
                        }
                        if (coord[1] + 1 <= field.GetLength(1) - 1)
                        { 
                            coordinatesArrChar.Add(new int[] { coord[0], coord[1] + 1 });
                            priorityCell[coord[0], coord[1] + 1] -= 1;
                        }
                        coord = GetRndCoord(GetAllCoordinatesMinPriorityArroundChar(priorityCell, coordinatesArrChar));
                    }
                    pair.Value[i, 0] = coord[0];
                    pair.Value[i, 1] = coord[1];
                    priorityCell[coord[0], coord[1]] = 50;
                    field[coord[0], coord[1]] = wordByChar[i];
                }
           }
            return wordsInGame;
        }

        private int[] GetRndCoord(List<int[]> coordinates)
        {
            return coordinates[random.Next(coordinates.Count)];
        }
 */
    }
}
