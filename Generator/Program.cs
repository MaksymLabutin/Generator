using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Generator.Traektoriya;
using Generator.Karta_Staniv;
using System.IO;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int TrajecktSize =  0 ;
            int FileSize = 0;
            bool correctly = false;
            bool StopGeneration = false;
            while (!correctly)
            {
                EntetInfo(ref TrajecktSize, ref FileSize, ref correctly);
            }

            while (!StopGeneration) {
            // Генерация траектории
            GenerateTraektoriya newTraektoriya = new GenerateTraektoriya();
            var traektoriya = newTraektoriya.GeneratTraektoriya(TrajecktSize);

            // Генерация Карты
            GenerateKartaStaniv newKarta = new GenerateKartaStaniv();
            int[,] kartaStaniv = newKarta.GenKartaStaniv();

            //Карта станів
            AlgoritmFindKartaStaniv newPidKluch = new AlgoritmFindKartaStaniv();
            int[,] pidKluck = newPidKluch.FindKartaStaniv(traektoriya, kartaStaniv);
            //запись в файл
            WriteToFile.WriteMassToFille(pidKluck, FileSize, ref StopGeneration);           

            }
            Console.WriteLine("Генерация закончена");

            #region Test Info
            Console.WriteLine("**********************************************************\n\n");

                //Console.WriteLine("****Траектория****");
                //foreach (var item in traektoriya)
                //{
                //    Console.WriteLine("Cole: {0}, Line: {1}", item.colum, item.line);
                //}

                //Console.WriteLine("\n\n****Карта станив****");
                //showMas(kartaStaniv);


                //Console.WriteLine("\n\n****Последовательность Под ключь****");
                //showMas(pidKluck);
                #endregion           
            Console.ReadLine();
        }

       

        #region Сбор информации по размеру файла и траектории
        private static void EntetInfo(ref int TrajecktSize, ref int FileSize, ref bool correctly)
        {
            Console.WriteLine("******  Генерируем последовательность  ******\n\n");
            Console.WriteLine("Введите размер генерируемого файла: ");
            FileSize = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Введите длину траектории (одиниц): ");
            TrajecktSize = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Все верно?   y/n");
            Console.WriteLine("Размер файла: {0}", FileSize);
            Console.WriteLine("Длина траектории: {0}", TrajecktSize);

            var answer =  Console.ReadLine();

            if (answer == "y") correctly = true;
            

        }
        #endregion

        #region Тестова инфа
        static void showMas(int[,] p)
        {
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < 8; j++)
                {
                    Console.Write(" " + p[i, j] + "|");

                }
            }
        }
        #endregion
    }
}

