using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaVetor
{
    class Exercicio03
    {
        public Exercicio03()
        {
            string[] nomes = new string[7];

            nomes[0] = "Banana";
            nomes[1] = "Abacaxi";
            nomes[2] = "Goiaba";
            nomes[3] = "Mamão";
            nomes[4] = "Limão";
            nomes[5] = "Melancia";
            nomes[6] = "Maracuja";

            double[] precos = new double[7];

            precos[0] = 2.45;
            precos[1] = 3.50;
            precos[2] = 1.99;
            precos[3] = 5.00;
            precos[4] = 2.44;
            precos[5] = 9.50;
            precos[6] = 3.66;

            Console.WriteLine(string.Format("\n{0} R${1}", nomes[0], precos[0]) +
                              string.Format("\n{0} R${1}", nomes[1], precos[1]) +
                              string.Format("\n{0} R${1}", nomes[2], precos[2]) +
                              string.Format("\n{0} R${1}", nomes[3], precos[3]) +
                              string.Format("\n{0} R${1}", nomes[4], precos[4]) +
                              string.Format("\n{0} R${1}", nomes[5], precos[5]) +
                              string.Format("\n{0} R${1}", nomes[6], precos[6])
                );
        }
    }
}
