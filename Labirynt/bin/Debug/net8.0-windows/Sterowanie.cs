using System;

namespace Labirynt_kod
{ 
    static class Sterowanie                                                                            // Zawiera rozszerzenia dla klasy "Gracz"
    {                                                                                                  // Odpowiada za poruszanie "gracza/użytkownika" na podstawie sterowania i aktualizuje położenie w/w w labiryncie
                                                                                                       // Parametr "gracz" to gracz/użytkownik do ruszania
                                                                                                       // Parametr "key" to klawisz konsoli reprezentujący żądany kierunek ruchu
                                                                                                       // Parametr "labirynt" to labirynt w którym porusza się gracz 
        public static void Move(this Gracz gracz, ConsoleKey key, Labirynt labirynt)
        {
            int newRow = gracz.Row;
            int newCol = gracz.Column;

            switch (key)                                                                               // Z racji że można poruszać się tylko trzema klawiszami, definiujemy "strzałkę" w górę, prawo i lewo.
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
                    Console.WriteLine("\n Gratulacje, labirynt ukończony!");                             // Wiadomość wyświetlana po pomyślnym przejściu labiryntu 
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                else if ((gracz.Row == 1 && gracz.Column == 2) || (gracz.Row == 7 && gracz.Column == 2)) // Zakodowanie miejsc "ślepych". Z braku możliwości ruchu w "dół" postać musi zostać przywrócona na początek. 
                {
                    gracz.Row = gracz.SpawnRow;
                    gracz.Column = gracz.SpawnColumn;
                }
            }
        }

    }
}