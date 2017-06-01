using Generator.Traektoriya;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class AlgoritmFindKartaStaniv
    {
        public int[,] FindKartaStaniv(List<PositionOfTraektoriya> listPositions, int[,] MapState)
        {
            int line;
            int column;
            int lin = 0;
            int[,] PidKuch = new int[listPositions.Count, 8];
            foreach (var item in listPositions)
            {
                line = item.line;
                column = item.colum;
                if (line == 0 && column == 0)
                {          
                    PidKuch[lin, 0] = MapState[7, column];
                    PidKuch[lin, 1] = MapState[7, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[line + 1, column + 1];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, 7];
                    PidKuch[lin, 6] = MapState[line, 7];
                    PidKuch[lin, 7] = MapState[7, 7];
                }

                else if (line == 7 && column == 0)
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[0, column + 1];
                    PidKuch[lin, 4] = MapState[0, column];
                    PidKuch[lin, 5] = MapState[0, 7];
                    PidKuch[lin, 6] = MapState[line, 7];
                    PidKuch[lin, 7] = MapState[line - 1, 7];
                }
                else if (line == 0 && column == 7)
                {
                    PidKuch[lin, 0] = MapState[7, column];
                    PidKuch[lin, 1] = MapState[7, 0];
                    PidKuch[lin, 2] = MapState[line, 0];
                    PidKuch[lin, 3] = MapState[line + 1, 0];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[7, column - 1];
                }

                else if (line == 0)
                {
                    PidKuch[lin, 0] = MapState[7, column];
                    PidKuch[lin, 1] = MapState[7, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[line + 1, column + 1];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[7, column - 1];

                }
                else if (column == 0)
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[line + 1, column + 1];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, 7];
                    PidKuch[lin, 6] = MapState[line, 7];
                    PidKuch[lin, 7] = MapState[line - 1, 7];
                }
                else if (line == 7 && column == 7)
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, 0];
                    PidKuch[lin, 2] = MapState[line, 0];
                    PidKuch[lin, 3] = MapState[0, 0];
                    PidKuch[lin, 4] = MapState[0, column];
                    PidKuch[lin, 5] = MapState[0, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[line - 1, column - 1];
                }
                else if (line == 7)
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[0, column + 1];
                    PidKuch[lin, 4] = MapState[0, column];
                    PidKuch[lin, 5] = MapState[0, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[line - 1, column - 1];
                }
                else if (column == 7)
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, 0];
                    PidKuch[lin, 2] = MapState[line, 0];
                    PidKuch[lin, 3] = MapState[line + 1, 0];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[line - 1, column - 1];
                }
                else
                {
                    PidKuch[lin, 0] = MapState[line - 1, column];
                    PidKuch[lin, 1] = MapState[line - 1, column + 1];
                    PidKuch[lin, 2] = MapState[line, column + 1];
                    PidKuch[lin, 3] = MapState[line + 1, column + 1];
                    PidKuch[lin, 4] = MapState[line + 1, column];
                    PidKuch[lin, 5] = MapState[line + 1, column - 1];
                    PidKuch[lin, 6] = MapState[line, column - 1];
                    PidKuch[lin, 7] = MapState[line - 1, column - 1];
                }
                lin++;
            }

            return PidKuch;
        }
    }
}
