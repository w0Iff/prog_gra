using System;

namespace Labirynt_kod
{
class Gracz                                                   // Stworzenie klasy "Gracz"
    {                                                          
        public int Row { get; set; }                          // Pobiera lub ustawia bieżący indeks wiersza gracza 

        public int Column { get; set; }                       // Pobiera lub ustawia bieżący indeks kolumny gracza

        public int SpawnRow { get; private set; }             // Pobiera początkowy indeks wiersza w którym pojawia się gracz 

        public int SpawnColumn { get; private set; }          // Pobiera początkowy indeks kolumny w którym pojawia się gracz 

        public Gracz(int startRow, int startCol)              // Inicjuje nową instancję klasy gracza z określoną pozycją początkową (chodzi żeby postać "respiła" się na dole)
        {                                                     // "startRow" odpowiada za początkowy wiersz a "startCol" za początkową kolumnę
            Row = startRow;                                   
            Column = startCol;
            SpawnRow = startRow;
            SpawnColumn = startCol;
        }
    }
}
