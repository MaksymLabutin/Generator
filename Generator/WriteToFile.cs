using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public static class WriteToFile
    {
        public static  void WriteMassToFille(int[,] bits, int sizeFile, ref bool StopGeneration)
        {
            bool flag = false;
            long currentSizeFile = 0;
            Directory.CreateDirectory("d:\\SEQUENCE_FOLDER");
            string path = @"d:\\SEQUENCE_FOLDER\\sequence.txt";
            FileInfo file = new FileInfo(path);
            using (StreamWriter sw = new StreamWriter(new FileStream(path, FileMode.Append, FileAccess.Write)))
                {
                currentSizeFile = file.Length;
                for (int col = 0; col < bits.Length / 8; col++)
                    {
                    

                    for (int line = 0; line < 8; line++)
                        {
                        currentSizeFile++;
                        if (currentSizeFile > sizeFile)
                        {
                            flag = true;
                            StopGeneration = true;
                            
                            break ;
                        }

                        #region Побитовый сдвиг
                        //    byte b = (byte)((bits[col, 0] << 7)
                        //       | (bits[col, 1] << 6)
                        //       | (bits[col, 2] << 5)
                        //       | (bits[col, 3] << 4)
                        //       | (bits[col, 4] << 3)
                        //       | (bits[col, 5] << 2)
                        //       | (bits[col, 6] << 1)
                        //       | (bits[col, 7] << 0));
                        //Console.WriteLine("Биты: {0}", b);
                        #endregion
                        sw.WriteAsync(String.Format("{0}", bits[col,line]));
                        }

                    if (flag) break;
                    
                    }

                sw.Close();
               }
        }

    }
}
