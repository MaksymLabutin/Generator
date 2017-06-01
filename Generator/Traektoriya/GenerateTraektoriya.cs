using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator;
/// <summary>
/// Рандомная траектория
/// будем делать точку в матрице, и потом от той точки есть 8 возможных вариантов (тоже рандомно будем определять) 
/// и записывать траектория сразу в структуру.
/// </summary>


namespace Generator.Traektoriya
{
    class GenerateTraektoriya
    {
        Random r = new Random();
        int[,] Traektoriya;
        List<PositionOfTraektoriya> listPositions = new List<PositionOfTraektoriya>();
        AlgorithmFillTraektoriya algorythmFillTraektoriya = new AlgorithmFillTraektoriya();
        int _sizeTraektoria;
        public GenerateTraektoriya()
        {
            Traektoriya = new int[8, 8];

        }

        public List<PositionOfTraektoriya> GeneratTraektoriya(int sizeTraektoria)
        { 
            // получаем число последовательности траектории
            _sizeTraektoria = sizeTraektoria;
            Traektoriya[r.Next(0, 8), r.Next(0, 8)] = 1;
            FindFirstPoint();
            algorythmFillTraektoriya.AlgorithmFillTraekt(ref listPositions, _sizeTraektoria);
            //заполнить одиничками массив Traektoriya по списку рандомных позиций.
            //foreach (var t in listPositions)
            //{
            //    Traektoriya[t.colum, t.line] = 1;
            //    for (int aa = 0; aa < 8; aa++)
            //    {
            //        Console.WriteLine();

            //        for (int bb = 0; bb < 8; bb++)
            //        {
            //            Console.Write(" " + Traektoriya[aa, bb] + "|");

            //        }

            //    }
            //    Console.WriteLine("\n\n");
            //    Thread.Sleep(1000);
            //}
            return listPositions;
        }

            // находит рандомную одиницу в траектории.        
            private IEnumerable<PositionOfTraektoriya> FindFirstPoint()
        {
            bool endCycle = false;
            for (int col = 0; col < 8; col++)
            {
                if (endCycle) break;
                for (int line = 0; line < 8; line++)
                {
                    if (Traektoriya[col, line] == 1)
                    {
                        listPositions.Add(new PositionOfTraektoriya(col, line));
                        endCycle = true;
                        break;
                    }
                }
            }
            return listPositions;
        }



    }


    public struct PositionOfTraektoriya
    {
        public int colum, line;

        public PositionOfTraektoriya(int _colum, int _line)
        {
            colum = _colum;
            line = _line;
        }
    }

}