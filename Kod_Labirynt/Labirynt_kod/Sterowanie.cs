using System;

namespace Labirynt_kod
{ 
    static class Sterowanie    
    {
        public static void Move(this Gracz gracz, ConsoleKey key, Labirynt labirynt)
        {
            int newRow = gracz.Row;
            int newCol = gracz.Column;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    newRow--;
                    break;
                case ConsoleKey.LeftArrow:
                    newCol--;
                    break;
                case ConsoleKey.RightArrow:
                    newCol++;
                    break;
            }
            if (labirynt.IsMoveValid(newRow, newCol))
            {
                gracz.Row = newRow;
                gracz.Column = newCol;

                if (gracz.Row == 0 && gracz.Column == 9)
                {
                    labirynt.PrintLabirynt(gracz.Row, gracz.Column);
                    Console.WriteLine("\n Gratulacje, labirynt ukończony!");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if ((gracz.Row == 1 && gracz.Column == 2) || (gracz.Row == 7 && gracz.Column == 2))
                {
                    gracz.Row = gracz.SpawnRow;
                    gracz.Column = gracz.SpawnColumn;
                }
            }
        }

    }
}