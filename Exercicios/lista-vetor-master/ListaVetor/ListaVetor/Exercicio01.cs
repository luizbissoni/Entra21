using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio01
    {
        public Exercicio01()
        {
            int[] numero = new int[16];
            numero[0] = 1;
            numero[1] = 2;
            numero[2] = 3;
            numero[3] = 4;
            numero[4] = 5;
            numero[5] = 6;
            numero[6] = 7;
            numero[7] = 8;
            numero[8] = 9;
            numero[9] = 10;
            numero[10] = 11;
            numero[11] = 12;
            numero[12] = 13;
            numero[13] = 14;
            numero[14] = 15;
            numero[15] = 16;

            int somaTudo = numero[0] + numero[1] + numero[2] + numero[3] + numero[4] + numero[5] + numero[6] + numero[7] + numero[8] + numero[9] + numero[10] + numero[11] + numero[12] + numero[13] + numero[14] + numero[15];
            Console.WriteLine("A soma de todos os 16 vetore: "+somaTudo); 


        }
    }
}
