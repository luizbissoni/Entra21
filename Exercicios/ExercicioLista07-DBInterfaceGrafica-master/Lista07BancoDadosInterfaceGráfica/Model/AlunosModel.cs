using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista07BancoDadosInterfaceGráfica.Model
{
   public class AlunosModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Nota_1 { get; set; }
        public double Nota_2 { get; set; }
        public double Nota_3 { get; set; }
        public int Frequencia { get; set; }
        public short Matricula { get; set; }
        public double MediaNotas { get; set; }
        public string SituacaoAluno { get; set; }
         


    }
}
