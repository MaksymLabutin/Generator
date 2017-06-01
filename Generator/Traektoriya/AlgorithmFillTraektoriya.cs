using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Traektoriya
{

     class AlgorithmFillTraektoriya
    {

        public void AlgorithmFillTraekt(ref List<PositionOfTraektoriya> listPositions, int sizeTraektoriya)
        {
            Random r = new Random();
                //sizeTraektoriya - длина траектории
                for (int i = 2; i <= sizeTraektoriya; i++) { 
                int randomNumber = r.Next(1, 9);
                int previousPositionColumn = listPositions.Last().colum;
                int previousPositionLine = listPositions.Last().line;
                int newCol, newLine;

                switch (randomNumber)
                {
                case 1:
                    newCol = previousPositionColumn;
                    newLine = (previousPositionLine == 0) ? 7 : previousPositionLine - 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 2:                        
                    newCol = (previousPositionColumn == 7) ? 0 :  previousPositionColumn + 1 ;
                    newLine = (previousPositionLine == 0) ? 7 : previousPositionLine - 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 3:
                    newCol = (previousPositionColumn == 7) ? 0 : previousPositionColumn + 1 ; 
                    newLine = previousPositionLine;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 4:
                    newCol = (previousPositionColumn == 7) ? 0 : previousPositionColumn + 1 ;
                    newLine = (previousPositionLine == 7 ) ? 0 : previousPositionLine + 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 5:
                    newCol = previousPositionColumn;
                    newLine = (previousPositionLine == 7) ? 0 : previousPositionLine + 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 6:
                    newCol = (previousPositionColumn == 0) ? 7 : previousPositionColumn - 1;
                    newLine = (previousPositionLine == 7) ? 0 : previousPositionLine + 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 7:
                    newCol = (previousPositionColumn == 0) ? 7 : previousPositionColumn - 1 ;
                    newLine = previousPositionLine ;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                case 8:
                    newCol = (previousPositionColumn == 0) ? 7 : previousPositionColumn - 1 ;
                    newLine = (previousPositionLine == 0) ? 7 : previousPositionLine - 1;
                    listPositions.Add(new PositionOfTraektoriya(newCol, newLine));
                    break;
                }
            }
        }
    }
}
