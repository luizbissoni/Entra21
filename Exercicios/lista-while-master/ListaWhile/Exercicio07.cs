using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaEstruturaCondicionalWhile
{
    class Exercicio07
    {
        public Exercicio07()
        {
            int Contador = 0, NumeroJogadores = 2, Idade = 0, GolsMarcado = 0, CartaoAmarelo = 0, CartaoVermelho = 0, Peso = 0, QuantidadeF = 0, QuantidadeM = 0, MaiorPeso = 0, Menorpeso = 300, MaiorAmarelo = 0,MaiorVermelho = 0;
            var Nome = "";
            double Altura = 0, MaiorAltura = 0, MenorAltura = 999;
            var Nomemenorpeso = string.Empty;
            var Nomemaiorpeso = string.Empty;
            var NomemaiorAltura = string.Empty;
            var NomemenorAltura = string.Empty;
            var NomemenosAmarelo = string.Empty;
            var NomemaiorAmarelo = string.Empty;
            var NomemenosVermelho = string.Empty;
            var NomemaiorVermelho = string.Empty;
            var NomeMaior = string.Empty;
            var NomeMenor = string.Empty;

            int MenorAmarelo = 100;
            int MenorVermelho = 100;
            int MenorNome = 999;
            char Sexo = ' ';

            while (Contador < NumeroJogadores)
            {


                Console.Write("Nome: ");
                Nome = Console.ReadLine();

                Console.Write("Idade: ");
                Idade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Peso: ");
                Peso = Convert.ToInt32(Console.ReadLine());

                Console.Write("Sexo: ");
                Sexo = Convert.ToChar(Console.ReadLine()[0]);

                Console.Write("Altura: ");
                Altura = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de Gols: ");
                GolsMarcado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões Amarelos: ");
                CartaoAmarelo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Quantidade de cartões Vermelhos: ");
                CartaoVermelho = Convert.ToInt32(Console.ReadLine());


                if (Sexo == 'F')
                {
                    QuantidadeF++;
                }
                if (Sexo == 'M')
                {
                    QuantidadeM++;
                }
                if (Peso > MaiorPeso)
                {
                    MaiorPeso = Peso;
                    Nomemaiorpeso = Nome;
                }
                if (Peso < Menorpeso)
                {
                    Menorpeso = Peso;
                    Nomemenorpeso = Nome;
                }
                if (Altura > MaiorAltura)
                {
                    MaiorAltura = Altura;
                    NomemaiorAltura = Nome;
                }
                if (Altura < MenorAltura)
                {
                    MenorAltura = Altura;
                    NomemenorAltura = Nome;
                }
                if (CartaoAmarelo > MaiorAmarelo)
                {
                    MaiorAmarelo = CartaoAmarelo;
                    NomemaiorAmarelo = Nome;
                }
                if (CartaoAmarelo < MenorAmarelo)
                {
                    MenorAmarelo = CartaoAmarelo;
                    NomemenosAmarelo = Nome;
                }
                if (CartaoVermelho > MaiorVermelho)
                {
                    MaiorVermelho = CartaoVermelho;
                    NomemaiorVermelho = Nome;
                }
                if (CartaoVermelho < MenorVermelho)
                {
                    MenorVermelho = CartaoVermelho;
                    NomemenosVermelho = Nome;
                }
                if (Nome.Length > NomeMaior.Length)
                {
                    NomeMaior = Nome;
                }
                if (Nome.Length < MenorNome)
                {
                    NomeMenor = Nome;
                }

                Contador = Contador + 1;
            }
            Console.WriteLine("\n");
            Console.WriteLine("F "+QuantidadeF);
            Console.WriteLine("M "+QuantidadeM);
            Console.WriteLine(Nomemenorpeso + " Menor peso");
            Console.WriteLine(Nomemaiorpeso + " Maior peso");
            Console.WriteLine(NomemaiorAltura + " Maior Altura");
            Console.WriteLine(NomemenorAltura + " Menor Altura");
            Console.WriteLine(NomemenosAmarelo + " Menos Cartão Amarelo");
            Console.WriteLine(NomemaiorAmarelo + " Mais Cartão Amarelo");
            Console.WriteLine(NomemenosVermelho + " Menos Cartão Vermelho");
            Console.WriteLine(NomemaiorVermelho + " Mais Cartão Vermelho");
            Console.WriteLine(NomeMaior + " Maior Nome");
            Console.WriteLine(NomeMenor + " Menor Nome");
        }
    }
}





