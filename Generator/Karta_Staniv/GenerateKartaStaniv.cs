using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator.Karta_Staniv
{
     public class GenerateKartaStaniv
     { 
        public int[,] GenKartaStaniv() 
        {
        int[,] KartaStaniv = new int[8, 8];
        Random r = new Random();

            for (int i = 0; i < 8; i++)
            {
             for (int j = 0; j < 8; j++)
             {
             KartaStaniv[i, j] = r.Next(0, 2);
             }
            }            
        return KartaStaniv;
        }
     }
}
