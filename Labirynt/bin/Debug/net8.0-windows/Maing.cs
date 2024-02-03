using System;

namespace Labirynt_kod
{
   public class Maing                                                                // Główna klasa programu
    {

       static void Main()
        {
            char[,] labiryntArch = {                                                // Budowa labiryntu. Opcjonalnie można użyć "false" i "true" ale szybciej i czytelniej będzie w ten sposób
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
                { '#', '#', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', ' ', '#', '#', ' ', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', '#', '#', '#', '#', '#', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
                { '#', '#', '#', '#', '#', ' ', '#', '#', ' ', ' ', '#' },
                { '#', '#', ' ', '#', ' ', ' ', ' ', '#', ' ', ' ', '#' },
                { '#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#', '#' },
                { '#', ' ', ' ', ' ', '#', ' ', ' ', '#', ' ', ' ', '#' },
                { '#', ' ', '#', '#', '#', ' ', '#', '#', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
            };
                                                                                    // Tworzenie instancji klasy labiryntu
            Labirynt labirynt = new Labirynt(labiryntArch);
            Gracz gracz = new Gracz(11, 1);

            ConsoleKeyInfo key;
            do
            {                                                                      // Wyświetla obecny stan labiryntu
                labirynt.PrintLabirynt(gracz.Row, gracz.Column);
                                                                                   // Pobiera klawisz wciśnięty przez gracza
                key = Console.ReadKey();
                                                                                   // Rusza graczem na podstawie pobranego klawisza
                gracz.Move(key.Key, labirynt);
            } while (key.Key != ConsoleKey.Escape);

            Console.WriteLine("\nKoniec Gry");
        }

    }
}