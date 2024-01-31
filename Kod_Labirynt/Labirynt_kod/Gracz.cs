using System;

namespace Gra_Labirynt
{
    class Gracz
    {
        public int Row { get; set; }

        public int Column { get; set; }

        public int SpawnRow { get; private set; }

        public int SpawnColumn { get; private set; }

        public Gracz(int startRow, int startCol)
        {
            Row = startRow;
            Column = startCol;
            SpawnRow = startRow;
            SpawnColumn = startCol;
        }
    }
}
