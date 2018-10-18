using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio16
    {
        public Exercicio16()
        {
            var DataEspecifica = new DateTime(2018, 12, 30, 23, 59, 59);

            while (DataEspecifica.Hour > 000000)
            {
                Console.WriteLine(DataEspecifica.ToString("HH:mm:ss"));
                DataEspecifica = DataEspecifica.AddSeconds(-1);
            }
            Console.ReadKey();
        }
    }
}
