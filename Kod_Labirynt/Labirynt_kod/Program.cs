using System;

namespace Labirynt_kod
{
    class Program                                                                   // Główna klasa programu.
    {

       static void Main()
        {
            char[,] labiryntArch = {                                             // Budowa labiryntu.Opcjonalnie można użyć "false" i "true" ale szybciej i czytelniej będzie w ten sposób.
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

            Labirynt labirynt = new Labirynt(labiryntArch);
            Gracz gracz = new Gracz(11, 1);

            ConsoleKeyInfo key;
            do
            {
                labirynt.PrintLabirynt(gracz.Row, gracz.Column);

                key = Console.ReadKey();

                gracz.Move(key.Key, labirynt);
            } while (key.Key != ConsoleKey.Escape);

            Console.WriteLine("\nKoniec Gry");
        }

    }
}