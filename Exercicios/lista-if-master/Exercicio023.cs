using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListaExercicios02
{
    class Exercicio023
    {
        public Exercicio023()
        {
            

            Console.Write("Nome Do Aluno: ");
            string NomeAluno = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("1 / 11");

            Console.Write("Nota 1 Portugues: ");
            double PortuguesNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Portugues: ");
            double PortuguesNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Portugues: ");
            double PortuguesNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Portugues: ");
            double PortuguesNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("2 / 11");

            Console.Write("Nota 1 Matemática: ");
            double MatematicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Matemática: ");
            double MatematicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Matemática: ");
            double MatematicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Matemática: ");
            double MatematicaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("3 / 11");

            Console.Write("Nota 1 Inglês: ");
            double InglesNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Inglês: ");
            double InglesNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Inglês: ");
            double InglesNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Inglês: ");
            double InglesNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("4 / 11");

            Console.Write("Nota 1 Biologia: ");
            double BiologiaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Biologia: ");
            double BiologiaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Biologia: ");
            double BiologiaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Biologia: ");
            double BiologiaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("5 / 11");

            Console.Write("Nota 1 Química: ");
            double QuimicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Química: ");
            double QuimicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Química: ");
            double QuimicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Química: ");
            double QuimicaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("6 / 11");

            Console.Write("Nota 1 Física: ");
            double FisicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Física: ");
            double FisicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Física: ");
            double FisicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Física: ");
            double FisicaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("7 / 11");

            Console.Write("Nota 1 Sociologia: ");
            double SociologiaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Sociologia: ");
            double SociologiaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Sociologia: ");
            double SociologiaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Sociologia: ");
            double SociologiaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("8 / 11");

            Console.Write("Nota 1 Filosofia: ");
            double FilosofiaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Filosofia: ");
            double FilosofiaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Filosofia: ");
            double FilosofiaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Filosofia: ");
            double FilosofiaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("9 / 11");

            Console.Write("Nota 1 Geografia: ");
            double GeografiaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Geografia: ");
            double GeografiaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Geografia: ");
            double GeografiaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Geografia: ");
            double GeografiaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("10 / 11");

            Console.Write("Nota 1 História: ");
            double HistoriaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 História: ");
            double HistoriaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 História: ");
            double HistoriaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 História: ");
            double HistoriaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("11 / 11");

            Console.Write("Nota 1 Educação Fisica: ");
            double EducacaoFisicaNota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 2 Educação Fisica: ");
            double EducacaoFisicaNota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 3 Educação Fisica: ");
            double EducacaoFisicaNota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota 4 Educação Fisica: ");
            double EducacaoFisicaNota4 = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            //Média de cada materia + Media das Medias

            double PortuguesMedia = (PortuguesNota1 + PortuguesNota2 + PortuguesNota3 + PortuguesNota4) / 4;
            double MatematicaMedia = (MatematicaNota1 + MatematicaNota2 + MatematicaNota3 + MatematicaNota4) / 4;
            double InglesMedia = (InglesNota1 + InglesNota2 + InglesNota3 + InglesNota4) / 4;
            double BiologiaMedia = (BiologiaNota1 + BiologiaNota2 + BiologiaNota3 + BiologiaNota4) / 4;
            double QuimicaMedia = (QuimicaNota1 + QuimicaNota2 + QuimicaNota3 + QuimicaNota4) / 4;
            double FisicaMedia = (FisicaNota1 + FisicaNota2 + FisicaNota3 + FisicaNota4) / 4;
            double SociologiaMedia = (SociologiaNota1 + SociologiaNota2 + SociologiaNota3 + SociologiaNota4) / 4;
            double FilosofiaMedia = (FilosofiaNota1 + FilosofiaNota2 + FilosofiaNota3 + FilosofiaNota4) / 4;
            double GeografiaMedia = (GeografiaNota1 + GeografiaNota2 + GeografiaNota3 + GeografiaNota4) / 4;
            double HistoriaMedia = (HistoriaNota1 + HistoriaNota2 + HistoriaNota3 + HistoriaNota4) / 4;
            double EducacaoFisicaMedia = (EducacaoFisicaNota1 + EducacaoFisicaNota2 + EducacaoFisicaNota3 + EducacaoFisicaNota4) / 4;
            double SituacaoMedia = (PortuguesMedia + MatematicaMedia + InglesMedia + BiologiaMedia + QuimicaMedia + FisicaMedia + SociologiaMedia + FilosofiaMedia + GeografiaMedia + HistoriaMedia + EducacaoFisicaMedia) / 11;
            string MediaDasMedias = "";
            string MediaTudo = "";

           

            //Diciplina com a maior média

            if ((PortuguesMedia > MatematicaMedia) && (PortuguesMedia > InglesMedia) && (PortuguesMedia > BiologiaMedia) && (PortuguesMedia > QuimicaMedia) && (PortuguesMedia > FisicaMedia) && (PortuguesMedia > SociologiaMedia) && (PortuguesMedia > FilosofiaMedia) && (PortuguesMedia > GeografiaMedia) && (PortuguesMedia > HistoriaMedia) && (PortuguesMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Português: {0} foi a maior media", PortuguesMedia);
            }
            if ((MatematicaMedia > PortuguesMedia) && (MatematicaMedia > InglesMedia) && (MatematicaMedia > BiologiaMedia) && (MatematicaMedia > QuimicaMedia) && (MatematicaMedia > FisicaMedia) && (MatematicaMedia > SociologiaMedia) && (MatematicaMedia > FilosofiaMedia) && (MatematicaMedia > GeografiaMedia) && (MatematicaMedia > HistoriaMedia) && (MatematicaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Matemática: {0} foi a maior media", MatematicaMedia);
            }
            if ((InglesMedia > PortuguesMedia) && (InglesMedia > MatematicaMedia) && (InglesMedia > BiologiaMedia) && (InglesMedia > QuimicaMedia) && (InglesMedia > FisicaMedia) && (InglesMedia > SociologiaMedia) && (InglesMedia > FilosofiaMedia) && (InglesMedia > GeografiaMedia) && (InglesMedia > HistoriaMedia) && (InglesMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Inglês: {0} foi a maior media", InglesMedia);
            }
            if ((BiologiaMedia > PortuguesMedia) && (BiologiaMedia > MatematicaMedia) && (BiologiaMedia > InglesMedia) && (BiologiaMedia > QuimicaMedia) && (BiologiaMedia > FisicaMedia) && (BiologiaMedia > SociologiaMedia) && (BiologiaMedia > FilosofiaMedia) && (BiologiaMedia > GeografiaMedia) && (BiologiaMedia > HistoriaMedia) && (BiologiaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Biologia: {0} foi a maior media", BiologiaMedia);
            }
            if ((QuimicaMedia > PortuguesMedia) && (QuimicaMedia > MatematicaMedia) && (QuimicaMedia > InglesMedia) && (QuimicaMedia > BiologiaMedia) && (QuimicaMedia > FisicaMedia) && (QuimicaMedia > SociologiaMedia) && (QuimicaMedia > FilosofiaMedia) && (QuimicaMedia > GeografiaMedia) && (QuimicaMedia > HistoriaMedia) && (QuimicaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Quimica: {0} foi a maior media", QuimicaMedia);
            }
            if ((SociologiaMedia > PortuguesMedia) && (SociologiaMedia > MatematicaMedia) && (SociologiaMedia > InglesMedia) && (SociologiaMedia > BiologiaMedia) && (SociologiaMedia > QuimicaMedia) && (SociologiaMedia > FisicaMedia) && (SociologiaMedia > FilosofiaMedia) && (SociologiaMedia > GeografiaMedia) && (SociologiaMedia > HistoriaMedia) && (SociologiaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Sociologia: {0} foi a maior media", SociologiaMedia);
            }
            if ((FisicaMedia > PortuguesMedia) && (FisicaMedia > MatematicaMedia) && (FisicaMedia > InglesMedia) && (FisicaMedia > BiologiaMedia) && (FisicaMedia > QuimicaMedia) && (FisicaMedia > SociologiaMedia) && (FisicaMedia > FilosofiaMedia) && (GeografiaMedia > FisicaMedia) && (FisicaMedia > HistoriaMedia) && (FisicaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Fisica: {0} foi a maior media", FisicaMedia);
            }
            if ((FilosofiaMedia > PortuguesMedia) && (FilosofiaMedia > MatematicaMedia) && (FilosofiaMedia > InglesMedia) && (FilosofiaMedia > BiologiaMedia) && (FilosofiaMedia > QuimicaMedia) && (FilosofiaMedia > SociologiaMedia) && (FilosofiaMedia > FisicaMedia) && (FilosofiaMedia > GeografiaMedia) && (FilosofiaMedia > HistoriaMedia) && (FilosofiaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Filosofia: {0} foi a maior media", FilosofiaMedia);
            }
            if ((GeografiaMedia > PortuguesMedia) && (GeografiaMedia > MatematicaMedia) && (GeografiaMedia > InglesMedia) && (GeografiaMedia > BiologiaMedia) && (GeografiaMedia > QuimicaMedia) && (GeografiaMedia > SociologiaMedia) && (GeografiaMedia > FisicaMedia) && (GeografiaMedia > FilosofiaMedia) && (GeografiaMedia > HistoriaMedia) && (GeografiaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("Geografia: {0} foi a maior media", GeografiaMedia);
            }
            if ((HistoriaMedia > PortuguesMedia) && (HistoriaMedia > MatematicaMedia) && (HistoriaMedia > InglesMedia) && (HistoriaMedia > BiologiaMedia) && (HistoriaMedia > QuimicaMedia) && (HistoriaMedia > SociologiaMedia) && (HistoriaMedia > FisicaMedia) && (HistoriaMedia > FilosofiaMedia) && (HistoriaMedia > GeografiaMedia) && (HistoriaMedia > EducacaoFisicaMedia))
            {
                Console.WriteLine("História: {0} foi a maior media", HistoriaMedia);
            }
            if ((EducacaoFisicaMedia > PortuguesMedia) && (EducacaoFisicaMedia > MatematicaMedia) && (EducacaoFisicaMedia > InglesMedia) && (EducacaoFisicaMedia > BiologiaMedia) && (EducacaoFisicaMedia > QuimicaMedia) && (EducacaoFisicaMedia > SociologiaMedia) && (EducacaoFisicaMedia > FisicaMedia) && (EducacaoFisicaMedia > FilosofiaMedia) && (EducacaoFisicaMedia > GeografiaMedia) && (EducacaoFisicaMedia > HistoriaMedia))
            {
                Console.WriteLine("Educação Fisica: {0} foi a maior media", EducacaoFisicaMedia);
            }

            //Disciplina com a menor média

            if ((PortuguesMedia < MatematicaMedia) && (PortuguesMedia < InglesMedia) && (PortuguesMedia < BiologiaMedia) && (PortuguesMedia < QuimicaMedia) && (PortuguesMedia < FisicaMedia) && (PortuguesMedia < SociologiaMedia) && (PortuguesMedia < FilosofiaMedia) && (PortuguesMedia < GeografiaMedia) && (PortuguesMedia < HistoriaMedia) && (PortuguesMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Português: {0} foi a menor media", PortuguesMedia);
            }
            if ((MatematicaMedia < PortuguesMedia) && (MatematicaMedia < InglesMedia) && (MatematicaMedia < BiologiaMedia) && (MatematicaMedia < QuimicaMedia) && (MatematicaMedia < FisicaMedia) && (MatematicaMedia < SociologiaMedia) && (MatematicaMedia < FilosofiaMedia) && (MatematicaMedia < GeografiaMedia) && (MatematicaMedia < HistoriaMedia) && (MatematicaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Matemática: {0} foi a menor media", MatematicaMedia);
            }
            if ((InglesMedia < PortuguesMedia) && (InglesMedia < MatematicaMedia) && (InglesMedia < BiologiaMedia) && (InglesMedia < QuimicaMedia) && (InglesMedia < FisicaMedia) && (InglesMedia < SociologiaMedia) && (InglesMedia < FilosofiaMedia) && (InglesMedia < GeografiaMedia) && (InglesMedia < HistoriaMedia) && (InglesMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Inglês: {0} foi a menor media", InglesMedia);
            }
            if ((BiologiaMedia < PortuguesMedia) && (BiologiaMedia < MatematicaMedia) && (BiologiaMedia < InglesMedia) && (BiologiaMedia < QuimicaMedia) && (BiologiaMedia < FisicaMedia) && (BiologiaMedia < SociologiaMedia) && (BiologiaMedia < FilosofiaMedia) && (BiologiaMedia < GeografiaMedia) && (BiologiaMedia < HistoriaMedia) && (BiologiaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Biologia: {0} foi a menor media", BiologiaMedia);
            }
            if ((QuimicaMedia < PortuguesMedia) && (QuimicaMedia < MatematicaMedia) && (QuimicaMedia < InglesMedia) && (QuimicaMedia < BiologiaMedia) && (QuimicaMedia < FisicaMedia) && (QuimicaMedia < SociologiaMedia) && (QuimicaMedia < FilosofiaMedia) && (QuimicaMedia < GeografiaMedia) && (QuimicaMedia < HistoriaMedia) && (QuimicaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Quimica: {0} foi a menor media", QuimicaMedia);
            }
            if ((SociologiaMedia < PortuguesMedia) && (SociologiaMedia < MatematicaMedia) && (SociologiaMedia < InglesMedia) && (SociologiaMedia < BiologiaMedia) && (SociologiaMedia < QuimicaMedia) && (SociologiaMedia < FisicaMedia) && (SociologiaMedia < FilosofiaMedia) && (SociologiaMedia < GeografiaMedia) && (SociologiaMedia < HistoriaMedia) && (SociologiaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Sociologia: {0} foi a menor media", SociologiaMedia);
            }
            if ((FisicaMedia < PortuguesMedia) && (FisicaMedia < MatematicaMedia) && (FisicaMedia < InglesMedia) && (FisicaMedia < BiologiaMedia) && (FisicaMedia < QuimicaMedia) && (FisicaMedia < SociologiaMedia) && (FisicaMedia < FilosofiaMedia) && (GeografiaMedia < FisicaMedia) && (FisicaMedia < HistoriaMedia) && (FisicaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Fisica: {0} foi a menor media", FisicaMedia);
            }
            if ((FilosofiaMedia < PortuguesMedia) && (FilosofiaMedia < MatematicaMedia) && (FilosofiaMedia < InglesMedia) && (FilosofiaMedia < BiologiaMedia) && (FilosofiaMedia < QuimicaMedia) && (FilosofiaMedia < SociologiaMedia) && (FilosofiaMedia < FisicaMedia) && (FilosofiaMedia < GeografiaMedia) && (FilosofiaMedia < HistoriaMedia) && (FilosofiaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Filosofia: {0} foi a menor media", FilosofiaMedia);
            }
            if ((GeografiaMedia < PortuguesMedia) && (GeografiaMedia < MatematicaMedia) && (GeografiaMedia < InglesMedia) && (GeografiaMedia < BiologiaMedia) && (GeografiaMedia < QuimicaMedia) && (GeografiaMedia < SociologiaMedia) && (GeografiaMedia < FisicaMedia) && (GeografiaMedia < FilosofiaMedia) && (GeografiaMedia < HistoriaMedia) && (GeografiaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("Geografia: {0} foi a menor media", GeografiaMedia);
            }
            if ((HistoriaMedia < PortuguesMedia) && (HistoriaMedia < MatematicaMedia) && (HistoriaMedia < InglesMedia) && (HistoriaMedia < BiologiaMedia) && (HistoriaMedia < QuimicaMedia) && (HistoriaMedia < SociologiaMedia) && (HistoriaMedia < FisicaMedia) && (HistoriaMedia < FilosofiaMedia) && (HistoriaMedia < GeografiaMedia) && (HistoriaMedia < EducacaoFisicaMedia))
            {
                Console.WriteLine("História: {0} foi a menor media", HistoriaMedia);
            }
            if ((EducacaoFisicaMedia < PortuguesMedia) && (EducacaoFisicaMedia < MatematicaMedia) && (EducacaoFisicaMedia < InglesMedia) && (EducacaoFisicaMedia < BiologiaMedia) && (EducacaoFisicaMedia < QuimicaMedia) && (EducacaoFisicaMedia < SociologiaMedia) && (EducacaoFisicaMedia < FisicaMedia) && (EducacaoFisicaMedia < FilosofiaMedia) && (EducacaoFisicaMedia < GeografiaMedia) && (EducacaoFisicaMedia < HistoriaMedia))
            {
                Console.WriteLine("Educação Fisica: {0} foi a menor media", EducacaoFisicaMedia);
            }

            //Diciplina com maior nota
            //Portugues
            if ((PortuguesNota1 > PortuguesNota2) && (PortuguesNota1 > PortuguesNota3) && (PortuguesNota1 > PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota1 maior nota", PortuguesNota1);
            }
            if ((PortuguesNota2 > PortuguesNota1) && (PortuguesNota2 > PortuguesNota3) && (PortuguesNota2 > PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota2 maior nota", PortuguesNota2);
            }
            if ((PortuguesNota3 > PortuguesNota1) && (PortuguesNota3 > PortuguesNota2) && (PortuguesNota3 > PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota3 maior nota", PortuguesNota3);
            }
            if ((PortuguesNota4 > PortuguesNota1) && (PortuguesNota4 > PortuguesNota2) && (PortuguesNota4 > PortuguesNota3))
            {
                Console.WriteLine("Porugues: {0} Nota4 maior nota", PortuguesNota4);
            }
            //Matematica
            if ((MatematicaNota1 > MatematicaNota2) && (MatematicaNota1 > MatematicaNota3) && (MatematicaNota1 > MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota1 maior nota", MatematicaNota1);
            }
            if ((MatematicaNota2 > MatematicaNota1) && (MatematicaNota2 > MatematicaNota3) && (MatematicaNota2 > MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota2 maior nota", MatematicaNota2);
            }
            if ((MatematicaNota3 > MatematicaNota1) && (MatematicaNota3 > MatematicaNota2) && (MatematicaNota3 > MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota3 maior nota", MatematicaNota3);
            }
            if ((MatematicaNota4 > MatematicaNota1) && (MatematicaNota4 > MatematicaNota2) && (MatematicaNota4 > MatematicaNota3))
            {
                Console.WriteLine("Matematica: {0} Nota4 maior nota", MatematicaNota4);
            }

            //Ingles
            if ((InglesNota1 > InglesNota2) && (InglesNota1 > InglesNota3) && (InglesNota1 > InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota1 maior nota", InglesNota1);
            }
            if ((InglesNota2 > InglesNota1) && (InglesNota2 > InglesNota3) && (InglesNota2 > InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota2 maior nota", InglesNota2);
            }
            if ((InglesNota3 > InglesNota1) && (InglesNota3 > InglesNota2) && (InglesNota3 > InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota3 maior nota", InglesNota3);
            }
            if ((InglesNota4 > InglesNota1) && (InglesNota4 > InglesNota2) && (InglesNota4 > InglesNota3))
            {
                Console.WriteLine("Ingles: {0} Nota4 maior nota", InglesNota4);
            }

            //Biologia
            if ((BiologiaNota1 > BiologiaNota2) && (BiologiaNota1 > BiologiaNota3) && (BiologiaNota1 > BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota1 maior nota", BiologiaNota1);
            }
            if ((BiologiaNota2 > BiologiaNota1) && (BiologiaNota2 > BiologiaNota3) && (BiologiaNota2 > BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota2 maior nota", BiologiaNota2);
            }
            if ((BiologiaNota3 > BiologiaNota1) && (BiologiaNota3 > BiologiaNota2) && (BiologiaNota3 > BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota3 maior nota", BiologiaNota3);
            }
            if ((BiologiaNota4 > BiologiaNota1) && (BiologiaNota4 > BiologiaNota2) && (BiologiaNota4 > BiologiaNota3))
            {
                Console.WriteLine("Biologia: {0} Nota4 maior nota", BiologiaNota4);
            }

            //Quimica

            if ((QuimicaNota1 > QuimicaNota2) && (QuimicaNota1 > QuimicaNota3) && (QuimicaNota1 > QuimicaNota4))
            {
                Console.WriteLine("Quimica: {0} Nota1 maior nota", QuimicaNota1);
            }
            if ((QuimicaNota2 > QuimicaNota1) && (QuimicaNota2 > QuimicaNota3) && (QuimicaNota2 > QuimicaNota4))
            {
                Console.WriteLine("Quimcia: {0} Nota2 maior nota", QuimicaNota2);
            }
            if ((QuimicaNota3 > QuimicaNota1) && (QuimicaNota3 > QuimicaNota2) && (QuimicaNota3 > QuimicaNota4))
            {
                Console.WriteLine("Quimica: {0} Nota3 maior nota", QuimicaNota3);
            }
            if ((QuimicaNota4 > QuimicaNota1) && (QuimicaNota4 > QuimicaNota2) && (QuimicaNota4 > QuimicaNota3))
            {
                Console.WriteLine("Quimica: {0} Nota4 maior nota", QuimicaNota4);
            }

            //Fisica
            if ((FisicaNota1 > FisicaNota2) && (FisicaNota1 > FisicaNota3) && (FisicaNota1 > FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota1 maior nota", FisicaNota1);
            }
            if ((FisicaNota2 > FisicaNota1) && (FisicaNota2 > FisicaNota3) && (FisicaNota2 > FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota2 maior nota", FisicaNota2);
            }
            if ((FisicaNota3 > FisicaNota1) && (FisicaNota3 > FisicaNota2) && (FisicaNota3 > FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota3 maior nota", FisicaNota3);
            }
            if ((FisicaNota4 > FisicaNota1) && (FisicaNota4 > FisicaNota2) && (FisicaNota4 > FisicaNota3))
            {
                Console.WriteLine("Fisica: {0} Nota4 maior nota", FisicaNota4);
            }

            //Sociologia
            if ((SociologiaNota1 > SociologiaNota2) && (SociologiaNota1 > SociologiaNota3) && (SociologiaNota1 > SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota1 maior nota", SociologiaNota1);
            }
            if ((SociologiaNota2 > SociologiaNota1) && (SociologiaNota2 > SociologiaNota3) && (SociologiaNota2 > SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota2 maior nota", SociologiaNota2);
            }
            if ((SociologiaNota3 > SociologiaNota1) && (SociologiaNota3 > SociologiaNota2) && (SociologiaNota3 > SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota3 maior nota", SociologiaNota3);
            }
            if ((SociologiaNota4 > SociologiaNota1) && (SociologiaNota4 > SociologiaNota2) && (SociologiaNota4 > SociologiaNota3))
            {
                Console.WriteLine("Sociologia: {0} Nota4 maior nota", SociologiaNota4);
            }

            //Filosofia
            if ((FilosofiaNota1 > FilosofiaNota2) && (FilosofiaNota1 > FilosofiaNota3) && (FilosofiaNota1 > FilosofiaNota4))
            {
                Console.WriteLine("Filosofia: {0} Nota1 maior nota", FilosofiaNota1);
            }
            if ((FilosofiaNota2 > FilosofiaNota1) && (FilosofiaNota2 > FilosofiaNota3) && (FilosofiaNota2 > FilosofiaNota4))
            {
                Console.WriteLine("filosofia: {0} Nota2 maior nota", FilosofiaNota2);
            }
            if ((FilosofiaNota3 > FilosofiaNota1) && (FilosofiaNota3 > FilosofiaNota2) && (FilosofiaNota3 > FilosofiaNota4))
            {
                Console.WriteLine("Filosofia: {0} Nota3 maior nota", FilosofiaNota3);
            }
            if ((FilosofiaNota4 > FilosofiaNota1) && (FilosofiaNota4 > FilosofiaNota2) && (FilosofiaNota4 > FilosofiaNota3))
            {
                Console.WriteLine("Filosofia: {0} Nota4 maior nota", FilosofiaNota4);
            }

            //Geografia
            if ((GeografiaNota1 > GeografiaNota2) && (GeografiaNota1 > GeografiaNota3) && (GeografiaNota1 > GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota1 maior nota", GeografiaNota1);
            }
            if ((GeografiaNota2 > GeografiaNota1) && (GeografiaNota2 > GeografiaNota3) && (GeografiaNota2 > GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota2 maior nota", GeografiaNota2);
            }
            if ((GeografiaNota3 > GeografiaNota1) && (GeografiaNota3 > GeografiaNota2) && (GeografiaNota3 > GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota3 maior nota", GeografiaNota3);
            }
            if ((GeografiaNota4 > GeografiaNota1) && (GeografiaNota4 > GeografiaNota2) && (GeografiaNota4 > GeografiaNota3))
            {
                Console.WriteLine("Geografia: {0} Nota4 maior nota", GeografiaNota4);
            }

            //História
            if ((HistoriaNota1 > HistoriaNota2) && (HistoriaNota1 > HistoriaNota3) && (HistoriaNota1 > HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota1 maior nota", HistoriaNota1);
            }
            if ((HistoriaNota2 > HistoriaNota1) && (HistoriaNota2 > HistoriaNota3) && (HistoriaNota2 > HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota2 maior nota", HistoriaNota2);
            }
            if ((HistoriaNota3 > HistoriaNota1) && (HistoriaNota3 > HistoriaNota2) && (HistoriaNota3 > HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota3 maior nota", HistoriaNota3);
            }
            if ((HistoriaNota4 > HistoriaNota1) && (HistoriaNota4 > HistoriaNota2) && (HistoriaNota4 > HistoriaNota3))
            {
                Console.WriteLine("Historia: {0} Nota4 maior nota", HistoriaNota4);
            }

            //Educação Fisica
            if ((EducacaoFisicaNota1 > EducacaoFisicaNota2) && (EducacaoFisicaNota1 > EducacaoFisicaNota3) && (EducacaoFisicaNota1 > EducacaoFisicaNota4))
            {
                Console.WriteLine("Educaçã0 Fisica: {0} Nota1 maior nota", EducacaoFisicaNota1);
            }
            if ((EducacaoFisicaNota2 > EducacaoFisicaNota1) && (EducacaoFisicaNota2 > EducacaoFisicaNota3) && (EducacaoFisicaNota2 > EducacaoFisicaNota4))
            {
                Console.WriteLine("Educção Fisica: {0} Nota2 maior nota", EducacaoFisicaNota2);
            }
            if ((EducacaoFisicaNota3 > EducacaoFisicaNota1) && (EducacaoFisicaNota3 > EducacaoFisicaNota2) && (EducacaoFisicaNota3 > EducacaoFisicaNota4))
            {
                Console.WriteLine("Educação Fisica: {0} Nota3 maior nota", EducacaoFisicaNota3);
            }
            if ((EducacaoFisicaNota4 > EducacaoFisicaNota1) && (EducacaoFisicaNota4 > EducacaoFisicaNota2) && (EducacaoFisicaNota4 > EducacaoFisicaNota3))
            {
                Console.WriteLine("Educação Fisica: {0} Nota4 maior nota", EducacaoFisicaNota4);
            }

            //Diciplina com menor nota
            //Portugues
            if ((PortuguesNota1 < PortuguesNota2) && (PortuguesNota1 < PortuguesNota3) && (PortuguesNota1 < PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota1 menor nota", PortuguesNota1);
            }
            if ((PortuguesNota2 < PortuguesNota1) && (PortuguesNota2 < PortuguesNota3) && (PortuguesNota2 < PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota2 menor nota", PortuguesNota2);
            }
            if ((PortuguesNota3 < PortuguesNota1) && (PortuguesNota3 < PortuguesNota2) && (PortuguesNota3 < PortuguesNota4))
            {
                Console.WriteLine("Portugues: {0} Nota3 menor nota", PortuguesNota3);
            }
            if ((PortuguesNota4 < PortuguesNota1) && (PortuguesNota4 < PortuguesNota2) && (PortuguesNota4 < PortuguesNota3))
            {
                Console.WriteLine("Porugues: {0} Nota4 menor nota", PortuguesNota4);
            }
            //Matematica
            if ((MatematicaNota1 < MatematicaNota2) && (MatematicaNota1 < MatematicaNota3) && (MatematicaNota1 < MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota1 menor nota", MatematicaNota1);
            }
            if ((MatematicaNota2 < MatematicaNota1) && (MatematicaNota2 < MatematicaNota3) && (MatematicaNota2 < MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota2 menor nota", MatematicaNota2);
            }
            if ((MatematicaNota3 < MatematicaNota1) && (MatematicaNota3 < MatematicaNota2) && (MatematicaNota3 < MatematicaNota4))
            {
                Console.WriteLine("Matematica: {0} Nota3 menor nota", MatematicaNota3);
            }
            if ((MatematicaNota4 < MatematicaNota1) && (MatematicaNota4 < MatematicaNota2) && (MatematicaNota4 < MatematicaNota3))
            {
                Console.WriteLine("Matematica: {0} Nota4 menor nota", MatematicaNota4);
            }

            //Ingles
            if ((InglesNota1 < InglesNota2) && (InglesNota1 < InglesNota3) && (InglesNota1 < InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota1 menor nota", InglesNota1);
            }
            if ((InglesNota2 < InglesNota1) && (InglesNota2 < InglesNota3) && (InglesNota2 < InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota2 menor nota", InglesNota2);
            }
            if ((InglesNota3 < InglesNota1) && (InglesNota3 < InglesNota2) && (InglesNota3 < InglesNota4))
            {
                Console.WriteLine("Ingles: {0} Nota3 menor nota", InglesNota3);
            }
            if ((InglesNota4 < InglesNota1) && (InglesNota4 < InglesNota2) && (InglesNota4 < InglesNota3))
            {
                Console.WriteLine("Ingles: {0} Nota4 menor nota", InglesNota4);
            }

            //Biologia
            if ((BiologiaNota1 < BiologiaNota2) && (BiologiaNota1 < BiologiaNota3) && (BiologiaNota1 < BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota1 menor nota", BiologiaNota1);
            }
            if ((BiologiaNota2 < BiologiaNota1) && (BiologiaNota2 < BiologiaNota3) && (BiologiaNota2 < BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota2 menor nota", BiologiaNota2);
            }
            if ((BiologiaNota3 < BiologiaNota1) && (BiologiaNota3 < BiologiaNota2) && (BiologiaNota3 < BiologiaNota4))
            {
                Console.WriteLine("Biologia: {0} Nota3 menor nota", BiologiaNota3);
            }
            if ((BiologiaNota4 < BiologiaNota1) && (BiologiaNota4 < BiologiaNota2) && (BiologiaNota4 < BiologiaNota3))
            {
                Console.WriteLine("Biologia: {0} Nota4 menor nota", BiologiaNota4);
            }

            //Quimica

            if ((QuimicaNota1 < QuimicaNota2) && (QuimicaNota1 < QuimicaNota3) && (QuimicaNota1 < QuimicaNota4))
            {
                Console.WriteLine("Quimica: {0} Nota1 menor nota", QuimicaNota1);
            }
            if ((QuimicaNota2 < QuimicaNota1) && (QuimicaNota2 < QuimicaNota3) && (QuimicaNota2 < QuimicaNota4))
            {
                Console.WriteLine("Quimcia: {0} Nota2 menor nota", QuimicaNota2);
            }
            if ((QuimicaNota3 < QuimicaNota1) && (QuimicaNota3 < QuimicaNota2) && (QuimicaNota3 < QuimicaNota4))
            {
                Console.WriteLine("Quimica: {0} Nota3 menor nota", QuimicaNota3);
            }
            if ((QuimicaNota4 < QuimicaNota1) && (QuimicaNota4 < QuimicaNota2) && (QuimicaNota4 < QuimicaNota3))
            {
                Console.WriteLine("Quimica: {0} Nota4 menor nota", QuimicaNota4);
            }

            //Fisica
            if ((FisicaNota1 < FisicaNota2) && (FisicaNota1 < FisicaNota3) && (FisicaNota1 < FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota1 menor nota", FisicaNota1);
            }
            if ((FisicaNota2 < FisicaNota1) && (FisicaNota2 < FisicaNota3) && (FisicaNota2 < FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota2 menor nota", FisicaNota2);
            }
            if ((FisicaNota3 < FisicaNota1) && (FisicaNota3 < FisicaNota2) && (FisicaNota3 < FisicaNota4))
            {
                Console.WriteLine("Fisica: {0} Nota3 menor nota", FisicaNota3);
            }
            if ((FisicaNota4 < FisicaNota1) && (FisicaNota4 < FisicaNota2) && (FisicaNota4 < FisicaNota3))
            {
                Console.WriteLine("Fisica: {0} Nota4 menor nota", FisicaNota4);
            }

            //Sociologia
            if ((SociologiaNota1 < SociologiaNota2) && (SociologiaNota1 < SociologiaNota3) && (SociologiaNota1 < SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota1 menor nota", SociologiaNota1);
            }
            if ((SociologiaNota2 < SociologiaNota1) && (SociologiaNota2 < SociologiaNota3) && (SociologiaNota2 < SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota2 menor nota", SociologiaNota2);
            }
            if ((SociologiaNota3 < SociologiaNota1) && (SociologiaNota3 < SociologiaNota2) && (SociologiaNota3 < SociologiaNota4))
            {
                Console.WriteLine("Sociologia: {0} Nota3 menor nota", SociologiaNota3);
            }
            if ((SociologiaNota4 < SociologiaNota1) && (SociologiaNota4 < SociologiaNota2) && (SociologiaNota4 < SociologiaNota3))
            {
                Console.WriteLine("Sociologia: {0} Nota4 menor nota", SociologiaNota4);
            }

            //Filosofia
            if ((FilosofiaNota1 < FilosofiaNota2) && (FilosofiaNota1 < FilosofiaNota3) && (FilosofiaNota1 < FilosofiaNota4))
            {
                Console.WriteLine("Filosofia: {0} Nota1 menor nota", FilosofiaNota1);
            }
            if ((FilosofiaNota2 < FilosofiaNota1) && (FilosofiaNota2 < FilosofiaNota3) && (FilosofiaNota2 < FilosofiaNota4))
            {
                Console.WriteLine("filosofia: {0} Nota2 menor nota", FilosofiaNota2);
            }
            if ((FilosofiaNota3 < FilosofiaNota1) && (FilosofiaNota3 < FilosofiaNota2) && (FilosofiaNota3 < FilosofiaNota4))
            {
                Console.WriteLine("Filosofia: {0} Nota3 menor nota", FilosofiaNota3);
            }
            if ((FilosofiaNota4 < FilosofiaNota1) && (FilosofiaNota4 < FilosofiaNota2) && (FilosofiaNota4 < FilosofiaNota3))
            {
                Console.WriteLine("Filosofia: {0} Nota4 menor nota", FilosofiaNota4);
            }

            //Geografia
            if ((GeografiaNota1 < GeografiaNota2) && (GeografiaNota1 < GeografiaNota3) && (GeografiaNota1 < GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota1 menor nota", GeografiaNota1);
            }
            if ((GeografiaNota2 < GeografiaNota1) && (GeografiaNota2 < GeografiaNota3) && (GeografiaNota2 < GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota2 menor nota", GeografiaNota2);
            }
            if ((GeografiaNota3 < GeografiaNota1) && (GeografiaNota3 < GeografiaNota2) && (GeografiaNota3 < GeografiaNota4))
            {
                Console.WriteLine("Geografia: {0} Nota3 menor nota", GeografiaNota3);
            }
            if ((GeografiaNota4 < GeografiaNota1) && (GeografiaNota4 < GeografiaNota2) && (GeografiaNota4 < GeografiaNota3))
            {
                Console.WriteLine("Geografia: {0} Nota4 menor nota", GeografiaNota4);
            }

            //História
            if ((HistoriaNota1 < HistoriaNota2) && (HistoriaNota1 < HistoriaNota3) && (HistoriaNota1 < HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota1 menor nota", HistoriaNota1);
            }
            if ((HistoriaNota2 < HistoriaNota1) && (HistoriaNota2 < HistoriaNota3) && (HistoriaNota2 < HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota2 menor nota", HistoriaNota2);
            }
            if ((HistoriaNota3 < HistoriaNota1) && (HistoriaNota3 < HistoriaNota2) && (HistoriaNota3 < HistoriaNota4))
            {
                Console.WriteLine("Historia: {0} Nota3 menor nota", HistoriaNota3);
            }
            if ((HistoriaNota4 < HistoriaNota1) && (HistoriaNota4 < HistoriaNota2) && (HistoriaNota4 < HistoriaNota3))
            {
                Console.WriteLine("Historia: {0} Nota4 menor nota", HistoriaNota4);
            }

            //Educação Fisica
            if ((EducacaoFisicaNota1 < EducacaoFisicaNota2) && (EducacaoFisicaNota1 < EducacaoFisicaNota3) && (EducacaoFisicaNota1 < EducacaoFisicaNota4))
            {
                Console.WriteLine("Educaçã0 Fisica: {0} Nota1 menor nota", EducacaoFisicaNota1);
            }
            if ((EducacaoFisicaNota2 < EducacaoFisicaNota1) && (EducacaoFisicaNota2 < EducacaoFisicaNota3) && (EducacaoFisicaNota2 < EducacaoFisicaNota4))
            {
                Console.WriteLine("Educção Fisica: {0} Nota2 menor nota", EducacaoFisicaNota2);
            }
            if ((EducacaoFisicaNota3 < EducacaoFisicaNota1) && (EducacaoFisicaNota3 < EducacaoFisicaNota2) && (EducacaoFisicaNota3 < EducacaoFisicaNota4))
            {
                Console.WriteLine("Educação Fisica: {0} Nota3 menor nota", EducacaoFisicaNota3);
            }
            if ((EducacaoFisicaNota4 < EducacaoFisicaNota1) && (EducacaoFisicaNota4 < EducacaoFisicaNota2) && (EducacaoFisicaNota4 < EducacaoFisicaNota3))
            {
                Console.WriteLine("Educação Fisica: {0} Nota4 menor nota", EducacaoFisicaNota4);
            }


            //Situação do aluno
            if (SituacaoMedia < 2.0)
            {
                MediaDasMedias = "Aluno deve se empenhar muito mais!";
            }
            else if (SituacaoMedia <= 5.0)
            {
                MediaDasMedias = "Aluno deve se empenhar mais!";
            }
            else if (SituacaoMedia <= 8.0)
            {
                MediaDasMedias = "Aluno deve se empenhar um pouco mais!";
            }
            else if (SituacaoMedia <= 10.0)
            {
                MediaDasMedias = "Aluno tem um dia de descanso!";
            }

            //Media total do Boletim
            if (SituacaoMedia < 5.5)
            {
                MediaTudo = "Reprovado";
            }
            else if (SituacaoMedia < 6.9)
            {
                MediaTudo = "Recuperação";
            }
            else if (SituacaoMedia > 6.9)
            {
                MediaTudo = "Aprovado";
            }

            Console.WriteLine(string.Format(" __________________________________________________________________________") +
                                string.Format("\n| Nome: {0}                                                                |", NomeAluno) +
                                string.Format("\n|--------------------------------------------------------------------------|") +
                                string.Format("\n|Disciplinas              | Nota 1 |  Nota 2 | Nota 3 | Nota 4 |     Média  |") +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Português                 | {0}    |   {1}   |  {2}   |  {3}   |       {4}    |", PortuguesNota1, PortuguesNota2, PortuguesNota3, PortuguesNota4, PortuguesMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Matemática                | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", MatematicaNota1, MatematicaNota2, MatematicaNota3, MatematicaNota4, MatematicaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Inglês                    | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", InglesNota1, InglesNota2, InglesNota3, InglesNota4, InglesMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Biologia                  | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", BiologiaNota1, BiologiaNota2, BiologiaNota3, BiologiaNota4, BiologiaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Química                   | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", QuimicaNota1, QuimicaNota2, QuimicaNota3, QuimicaNota4, QuimicaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Física                    | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", FisicaNota1, FisicaNota2, FisicaNota3, FisicaNota4, FisicaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Sociologia                | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", SociologiaNota1, SociologiaNota2, SociologiaNota3, SociologiaNota4, SociologiaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Filosofia                 | {0}    |   {1}   |  {2}   |  {3}   |     {4}    |", FilosofiaNota1, FilosofiaNota2, FilosofiaNota3, FilosofiaNota4, FilosofiaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Geografia                 | {0}    |   {1}   |   {2}  |  {3}   |     {4}    |", GeografiaNota1, GeografiaNota2, GeografiaNota3, GeografiaNota4, GeografiaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|História                  | {0}    |   {1}   |   {2}  |  {3}   |     {4}    |", HistoriaNota1, HistoriaNota2, HistoriaNota3, HistoriaNota4, HistoriaMedia) +
                                string.Format("\n|------------------------ |--------|---------|--------|--------|------------|") +
                                string.Format("\n|Educação Fisica           | {0}    |   {1}   |   {2}  |  {3}   |     {4}    |", EducacaoFisicaNota1, EducacaoFisicaNota2, EducacaoFisicaNota3, EducacaoFisicaNota4, EducacaoFisicaMedia) +
                                string.Format("\n|------------------------|--------|---------|--------|--------|------------|") +
                                string.Format("\n|           Situação:                    {0}                                  |", MediaTudo));

            Console.WriteLine("{0}", MediaDasMedias);

















































        }
    }
}
