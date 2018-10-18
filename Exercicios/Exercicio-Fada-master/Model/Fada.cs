using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fada
    {
        public string Nome;
        public string Familia;
        public string Cor;
        public bool Sexo;
        public string CorAsa;
        public double TamanhoAsa;
        public bool AsaQuebrada;
        public bool FazBarulho;
        public string Elemento;
        public bool CadastroRapido;


        public Fada(string nome, string familia, bool sexo, string cor, string corAsa, double tamanhoAsa, bool asaQuebrada, bool fazBarulho, string elemento)
        {
            Nome = nome; Familia = familia; Sexo = sexo; Cor = cor; CorAsa = corAsa; TamanhoAsa = tamanhoAsa;
            AsaQuebrada = asaQuebrada; FazBarulho = fazBarulho; Elemento = elemento;
        }
        public Fada(string nomeRapido, string familiaRapida, string elementoRapido, bool cadastroRapido) { Nome = nomeRapido; Familia = familiaRapida;
            Elemento = elementoRapido; CadastroRapido = cadastroRapido; }

        public Fada(string nome, string familia, bool asaQuebrada) { Nome = nome; Familia = familia; AsaQuebrada = asaQuebrada; }
   
    }
}