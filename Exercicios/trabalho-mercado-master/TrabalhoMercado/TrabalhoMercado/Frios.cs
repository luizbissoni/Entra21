using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMercado
{
    class Frios
    {

        int contador = 0;
        string[] nomeProduto = new string[100];
        int[] quantidade = new int[100];
        double[] preco = new double[100];


        public Frios()
        {

            nomeProduto[contador] = "carne";
            quantidade[contador] = 12;
            preco[contador] = 19.90;
            contador++;

            nomeProduto[contador] = "iogurte";
            quantidade[contador] = 15;
            preco[contador] = 20;
            contador++;

            nomeProduto[contador] = "queijos";
            quantidade[contador] = 20;
            preco[contador] = 5.90;
            contador++;


        } //vetor alimentado
        public void ListarFrios()
        {

            Console.Clear();
            Console.WriteLine("Lista de produtos do frios.");
            Console.WriteLine("ID    Nome          Quantidade    Preço");
            for (int i = 0; i < nomeProduto.Length; i++)
            {
                if (!string.IsNullOrEmpty(nomeProduto[i]))
                    Console.WriteLine(string.Format("{3} - {0}        {1}         {2}", nomeProduto[i], quantidade[i], preco[i], i));
            }
        }
        public void EditarProdutosFrios()
        {
            ListarFrios();
            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para editar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > nomeProduto.Length || string.IsNullOrEmpty(nomeProduto[prodId]))
                return;

            Console.Write("Nome Produto: ");
            nomeProduto[prodId] = Console.ReadLine();

            Console.Write("Quantidade: ");
            quantidade[prodId] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            preco[prodId] = Convert.ToDouble(Console.ReadLine());
        }
        public void comprar()
        {
            ListarFrios();

            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para comprar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > nomeProduto.Length || string.IsNullOrEmpty(nomeProduto[prodId]))
                return;

            Console.WriteLine("Produto: " + nomeProduto[prodId]);

            Console.Write("Quantidade: ");
            int quantidadecompras = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));

            double valortotal = quantidadecompras * preco[prodId];
            quantidade[prodId] = quantidade[prodId] - quantidadecompras;

            ListarFrios();

            Console.WriteLine();
            Console.WriteLine(string.Format("Quantidade de {0} = {1} com valor unitario de {2}", nomeProduto[prodId], quantidadecompras, preco[prodId]));
            Console.WriteLine(string.Format("Valor total da compra: {0:c}", valortotal));
        }
        public void cadastroFrios()
        {
             Console.WriteLine("Digite fim para sair/Enter continuar");
            string _fim = Console.ReadLine();

            for (int i = contador; i > 1; i++)
            {
                ListarFrios();
                Console.WriteLine("Nome do Produto: ");
                nomeProduto[i] = Console.ReadLine();
                contador++;

                Console.WriteLine("Quantidade: ");
                quantidade[i] = Convert.ToInt32(Console.ReadLine());
                contador++;

                Console.WriteLine("Preço unitario: ");
                preco[i] = Convert.ToDouble(Console.ReadLine());
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


