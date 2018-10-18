using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMercado
{
    class Padaria
    {

        string[] NomeProduto = new string[100];
        int[] QuantidadeProduto = new int[100];
        double[] ValorUnitario = new double[100];
        int contador = 0;

        public Padaria()
        {
            NomeProduto[contador] = "Pão Frances";
            QuantidadeProduto[contador] = 100;
            ValorUnitario[contador] = 0.50;
            contador++;

            NomeProduto[contador] = "Pão de Forma";
            QuantidadeProduto[contador] = 50;
            ValorUnitario[contador] = 5.50;
            contador++;

            NomeProduto[contador] = "Bolo Ingles";
            QuantidadeProduto[contador] = 15;
            ValorUnitario[contador] = 10.65;
            contador++;

            NomeProduto[contador] = "Sanduiche atum";
            QuantidadeProduto[contador] = 6;
            ValorUnitario[contador] = 3.59;
            contador++;

            NomeProduto[contador] = "Sanduiche Natural";
            QuantidadeProduto[contador] = 6;
            ValorUnitario[contador] = 3.40;
            contador++;
        } //Vetor alimentado
        public void Listarpadaria()
        {

            Console.Clear();

            Console.WriteLine("Padaria");
            Console.WriteLine();

            Console.WriteLine("ID    Produto        Quantidade           Preço");
            for (int i = 0; i < NomeProduto.Length; i++)
            {
                if (!string.IsNullOrEmpty(NomeProduto[i]))
                    Console.WriteLine(string.Format("{3}     {0}            {1}          {2}", NomeProduto[i], QuantidadeProduto[i], ValorUnitario[i], i));

            }
        }
        public void EditarProdutosPadaria()
        {
            Listarpadaria();

            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para editar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > NomeProduto.Length || string.IsNullOrEmpty(NomeProduto[prodId]))
                return;

            Console.Write("Nome Produto: ");
            NomeProduto[prodId] = Console.ReadLine();

            Console.Write("Quantidade: ");
            QuantidadeProduto[prodId] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço unitário: ");
            ValorUnitario[prodId] = Convert.ToDouble(Console.ReadLine());
        }
        public void comprar()
        {
            Listarpadaria();

            Console.WriteLine();
            Console.WriteLine("Digite o número do produto para comprar");
            int prodId = Utils.ReturnPressKeyIntCode(Console.ReadLine());

            if (prodId > NomeProduto.Length || string.IsNullOrEmpty(NomeProduto[prodId]))
                return;

            Console.WriteLine("Produto: " + NomeProduto[prodId]);

            Console.Write("Quantidade: ");
            int quantidadecompras = Convert.ToInt32(Utils.ReturnPressKeyIntCode(Console.ReadLine()));

            double valortotal = quantidadecompras * ValorUnitario[prodId];
            QuantidadeProduto[prodId] = QuantidadeProduto[prodId] - quantidadecompras;

            Listarpadaria();

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
                Listarpadaria();
                Console.WriteLine("Nome do Produto: ");
                NomeProduto[i] = Console.ReadLine();
                contador++;

                Console.WriteLine("Quantidade: ");
                QuantidadeProduto[i] = Convert.ToInt32(Console.ReadLine());
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

