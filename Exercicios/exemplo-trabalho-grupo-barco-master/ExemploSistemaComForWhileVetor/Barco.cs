using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSistemaComForWhileVetor
{
    class Barco
    {
        string[] barcosNome = new string[100];
        string[] barcosCor = new string[100];
        double[] barcosPreco = new double[100];
        int atual = 0;

        public void CadastrarBarco()
        {
            Console.Clear();

            Console.Write("Nome do Barco: ");
            barcosNome[atual] = Console.ReadLine();
            Console.Write("Cor do Barco: ");
            barcosCor[atual] = Console.ReadLine();
            Console.Write("Preço do Barco: ");
            barcosPreco[atual] = Convert.ToDouble(Console.ReadLine());
            atual++;
        }
        public void ListarBarcos()
        {
            Console.WriteLine("Lista de barcos: ");
            for (int i = 0; i < atual; i++)
            {
                Console.WriteLine(string.Format("\nNome: {0} \nCor: {1} \nPreço: {2}", barcosNome[i],barcosCor[i],barcosPreco[i]));
            }
        }


        public void EditarBarco()
        {
            Console.Clear();

            Console.WriteLine("Digite um nome para pesquisa: ");
            string nomePesquisado = Console.ReadLine().ToLower().Trim();
            int posicao = -1;
            for (int i = 0; i < atual; i++)
            {
                if (nomePesquisado == barcosNome[i])
                {
                    posicao = i;
                }
                if (posicao != -1)
                {
                    //encontrou o registro procurado
                    Console.Write("Nome do barco: ");
                    barcosNome[posicao] = Console.ReadLine();
                    Console.Write("Cor do barco: ");
                    barcosCor[posicao] = Console.ReadLine();
                    Console.Write("Preço do barco ");
                    barcosPreco[posicao] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Dados alterados com sucesso ");
                }
                else
                {
                    Console.WriteLine("Regitro não encontrado ");
                }
            }
        }

        public void BuscaBarco()
        {
            Console.Clear();

            Console.Write("Digite o nome para busca: ");
            string nomeBusca = Console.ReadLine();
            bool achou = false;
            for (int i = 0; i < atual; i++)
            {
                if (nomeBusca == barcosNome[i])
                {
                    Console.WriteLine(string.Format("Nome: {0} cor: {1} Preço: {2}", barcosNome[i], barcosCor[i], barcosPreco[i]));
                }
                achou = true;
                break;
            }

            if (!achou)
            {
                Console.WriteLine("Nome não encontrado!");
            }
        }
    }
}
