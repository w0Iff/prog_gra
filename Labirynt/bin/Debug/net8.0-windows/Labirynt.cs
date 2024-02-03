using System;

namespace Labirynt_kod
{
    class Labirynt                                                  // Tworzenie klasy "Labirynt"
    {
        private char[,] arch;

       public int Rows { get; private set;}                         // Pobranie numeru wierszy w naszym stworzonym labiryncie

        public int Columns { get; private set;}                     // Pobranie numeru kolumn w labiryncie

        public Labirynt(char[,] arch)                               // Inicjacja nowej instancji klasy Labirynt na podstawie stworzonego "szkicu"
        {                                                           // Parametr "arch" w zamyśle (moim - architektura) jest szablonem labiryntu 2d
            this.arch = arch;
            Rows = arch.GetLength(0);
            Columns = arch.GetLength(1);
        }
        public bool IsMoveValid(int row, int col)                  // Sprawdzanie czy ruch w labiryncie jest prawidłowy
        {                                                          // "row" - indeks wiersza ruchu 
            return row >= 0 && row < Rows &&                       // "col" - indeks kolumny ruchu 
                   col >= 0 && col < Columns &&                    // "return" - zwraca "true" jeżeli ruch jest prawidłowy, w innym przypadku zwraca "false". 
                   arch[row, col] != '#';
        }
        public void PrintLabirynt(int graczRow, int graczCol)      // Wyświetla obecny stan labiryntu, wraz z pozycją gracza
        {                                                          // "graczRow" indeks wiersza pozycji gracza
                                                                   // "graczCol" indeks kolumny pozycji gracza

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