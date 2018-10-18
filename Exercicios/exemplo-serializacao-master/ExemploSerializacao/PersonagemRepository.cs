using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ExemploSerializacao
{
    [Serializable]
    class PersonagemRepository
    {
        
        List<Personagem> personagens = new List<Personagem>();

        public PersonagemRepository()
        {
            if (File.Exists(ListaPersonagem.NOME_ARQUIVO))
            {
                BinaryFormatter binaryRead = new BinaryFormatter();
                Stream stream = File.OpenRead(ListaPersonagem.NOME_ARQUIVO);

                personagens = ((PersonagemRepository)binaryRead.Deserialize(stream)).ObterPersonagens();
                stream.Close();
            }
        }

        public void AdicionarPersonagem(Personagem personagem)
        {
            personagens.Add(personagem);

            EscreverNoArquivoDosPersonagens();
        }

        private void EscreverNoArquivoDosPersonagens()
        {
            BinaryFormatter binaryWrite = new BinaryFormatter();
            Stream stream = new FileStream(ListaPersonagem.NOME_ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWrite.Serialize(stream, this);
            stream.Close();
        }

        public List<Personagem> ObterPersonagens() 
        {
            return personagens;
        }

        internal void ApagarPersonagem(string nome)
        {
            foreach (Personagem personagem in personagens)
            {
                if (personagem.GetNome() == nome)
                {
                    personagens.Remove(personagem);
                    EscreverNoArquivoDosPersonagens();
                    return;
                }
            }
        }

        internal void EditarPersonagem(Personagem personagem, int posicao)
        {
            personagens[posicao] = personagem;
            EscreverNoArquivoDosPersonagens();
        }
    }
}
