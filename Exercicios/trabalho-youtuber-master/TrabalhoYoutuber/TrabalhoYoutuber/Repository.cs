using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Threading.Tasks;

namespace TrabalhoYoutuber
{
    [Serializable]
    class Repository
    {
        
        List<Youtuber> youtuberes = new List<Youtuber>();

        public Repository()
        {
            if (File.Exists(ADDYoutuber.NOME_ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(ADDYoutuber.NOME_ARQUIVO);
                youtuberes = ((Repository)binaryReader.Deserialize(stream)).ObterYoutube();
                stream.Close();
            }
        }

        public List<Youtuber> ObterYoutube()
        {
            return youtuberes;
        }

        private void EscreverNoArquivoDosYoutuber()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(ADDYoutuber.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }

        internal void ApagarPersonagem(string nome)
        {
             foreach (Youtuber youtube in youtuberes)
            {
                if (youtube.GetNome() == nome)
                {
                    youtuberes.Remove(youtube);
                    EscreverNoArquivoDosPersonagens();                    
                    return;
                }
            }
        }

        private void EscreverNoArquivoDosPersonagens()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(ADDYoutuber.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }

        public void AddYoutuber(Youtuber youtubers)
        {
            youtuberes.Add(youtubers);
            EscreverNoArquivoDosPersonagens();
        }

        internal void EditarYoutuber(Youtuber youtuber, int posicao)
        {
            youtuberes[posicao] = youtuber;
            EscreverNoArquivoDosPersonagens();
        }
    }
}
