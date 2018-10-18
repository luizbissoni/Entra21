using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMercado
{
    public class Limpeza
    {

        string[] NomeProduto = new string[100];
        int[] Quantidade = new int[100];
        double[] ValorUnitario = new double[100];
        int contador = 0;

        public Limpeza()
        {
            NomeProduto[contador] = "Detergente";
            Quantidade[contador] = 50;
            ValorUnitario[contador] = 1.99;
            contador++;

            NomeProduto[contador] = "Sabão em barra";
            Quantidade[contador] = 15;
            ValorUnitario[contador] = 0.85;
            contador++;

            NomeProduto[contador] = "Sabão em pó";
            Quantidade[contador] = 70;
            ValorUnitario[contador] = 5.99;
            contador++;

            NomeProduto[contador] = "Desinfetante";
            Quantidade[contador] = 10;
            ValorUnitario[contador] = 6.82;
            contador++;

            NomeProduto[contador] = "Cloro";
            Quantidade[contador] = 13;
            ValorUnitario[contador] = 2.99;
            contador++;
        } //Vetor alimentado 
        public void EditarProdutoslimpeza()
        {
            Listarlimpeza();

            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para editar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > NomeProduto.Length || string.IsNullOrEmpty(NomeProduto[prodId]))
                return;

            Console.Write("Nome Produto: ");
            NomeProduto[prodId] = Console.ReadLine();

            Console.Write("Quantidade: ");
            Quantidade[prodId] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            ValorUnitario[prodId] = Convert.ToDouble(Console.ReadLine());
        }
        public void Listarlimpeza()
        {
            Console.Clear();

            Console.WriteLine("limpeza");
            Console.WriteLine();

                Console.WriteLine("ID    Produto        Quantidade           Preço");
            for (int i = 0; i < NomeProduto.Length; i++)
            {
                if (!string.IsNullOrEmpty(NomeProduto[i]))
                Console.WriteLine(string.Format("{3}     {0}          {1}               {2}", NomeProduto[i], Quantidade[i], ValorUnitario[i],i));

            }
        }
        public void Comprar()
        {
            Listarlimpeza();

            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para comprar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > NomeProduto.Length || string.IsNullOrEmpty(NomeProduto[prodId]))
                return;

            Console.WriteLine("Produto: " + NomeProduto[prodId]);

            Console.Write("Quantidade: ");
            int quantidadecompras = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));

            double valortotal = quantidadecompras * ValorUnitario[prodId];
            Quantidade[prodId] = Quantidade[prodId] - quantidadecompras;

            Listarlimpeza();

            Console.WriteLine();
            Console.WriteLine(string.Format("Quantidade de {0} = {1} com valor unitario de {2}", NomeProduto[prodId], quantidadecompras, ValorUnitario[prodId]));
            Console.WriteLine(string.Format("Valor total da compra: {0:c}", valortotal));
        }
        public void cadastro()
        {
             Console.WriteLine("Digite fim para sair/Enter continuar");
            string _fim = Console.ReadLine();

            for (int i = contador; i > 1; i++)
            {
                Listarlimpeza();
                Console.WriteLine("Nome do Produto: ");
                NomeProduto[i] = Console.ReadLine();
                contador++;

                Console.WriteLine("Quantidade: ");
                Quantidade[i] = Convert.ToInt32(Console.ReadLine());
                contador++;

                Console.WriteLine("Preço unitario: ");
                ValorUnitario[i] = Convert.ToDouble(Console.ReadLine());
                contador++;

                Console.WriteLine("Digite fim para sair/Enter continuar");
                _fim = Console.ReadLine();
                if (_fim == "fim")
                {
                    break;
                }
            }

            }
        }


    }
}