using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEstruturaCondicionalWhile
{
    class ExercicioAuxs
    {

        public ExercicioAuxs()
        {
            int Contador = -1;

            while (Contador < 12)
            {
                string Texto = "Lorem Ipsum";
                Contador = Contador + 1;
                Console.WriteLine(Texto.Substring(Contador, 1));
                
            }
            





        }
    }
}
