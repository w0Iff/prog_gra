using System;

namespace Labirynt_kod
{
    class Labirynt
    {
        private char[,] arch;

       public int Rows { get; private set;}

        public int Columns { get; private set;}

        public Labirynt(char[,] arch)
        {
            this.arch = arch;
            Rows = arch.GetLength(0);
            Columns = arch.GetLength(1);
        }
        public bool IsMoveValid(int row, int col)
        {
            return row >= 0 && row < Rows &&
                   col >= 0 && col < Columns &&
                   arch[row, col] != '#';
        }
        public void PrintLabirynt(int graczRow, int graczCol)
        {

            Console.Clear();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (i == graczRow && j == graczCol)
                        Console.Write('G');
                    else
                        Console.Write(arch[i, j]);

                    Console.Write(' ');
                }
                Console.Write('\n');
                //Console.WriteLine();
            }
        }
    }

}