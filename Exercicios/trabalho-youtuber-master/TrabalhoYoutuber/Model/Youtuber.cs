using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Youtuber
    {
        private string Nome;
        private string Apelido;
        private string NomeCanal;
        private string DescricaoVideo;
        private string Nacionalidade;
        private string Patrocinador;
        private string Plataforma;
        private string Streamers;
        private string Categoria;
        private string Link;
        private long QuantidadeInscritos;
        private long QuantidadeViews;
        private long QuantidadeLikes;
        private long QuantidadeVideo;
        private long QuantiadeStrike;
        private double Renda;
        private bool SimPatrocinador;
        private string Anuncio;

        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter no minimo 3 caracteres.");
            }
            if (nome.Trim().Count() > 30)
            {
                throw new Exception("Nome deve ter no maximo 30 caracteres.");
            }

            this.Nome = nome;
        }
        public void SetApelido(string apelido)
        {
            if (apelido.Trim().Count() < 4)
            {
                throw new Exception("Apelido deve conter no minimo 4 caracteres.");
            }
            if (apelido.Trim().Count() > 15)
            {
                throw new Exception("Apelido deve conter no maximo 15 caracteres.");
            }

            this.Apelido = apelido;
        }
        public void SetNomeCanal(string canal)
        {
            if (canal == string.Empty)
            {
                throw new Exception("Nome Canal obrigatório.");
            }
            this.NomeCanal = canal;
        }
        public void SetDescricao(string descricao)
        {
            if (descricao == string.Empty)
            {
                throw new Exception("Descrição é obrigadorio.");
            }
            if (descricao.Trim().Count() < 10)
            {
                throw new Exception("Descrição deve conter no minimo 10 caracteres.");
            }
            this.DescricaoVideo = descricao;
        }
        public void SetNacionalidade(string nacionalidade)
        {
            if (nacionalidade == string.Empty)
            {
                throw new Exception("Informe a nacionalidade.");
            }
            this.Nacionalidade = nacionalidade;
        }
        public void SetPatrocinador(string patrocinador)
        {
            if (patrocinador == string.Empty)
            {
                throw new Exception("Deve conter pelo menos um patrocinador.");
            }
            if (patrocinador.Trim().Count() <2)
            {
                throw new Exception("Patrocinador deve conter no minimo 5 caracteres.");
            }
            this.Patrocinador = patrocinador;
        }
        public void SetPlataforma(string plataforma)
        {
            if (plataforma == string.Empty)
            {
                throw new Exception("Deve conter pelo menos uma Plataforma.");
            }
            this.Plataforma = plataforma;
        }
        public void SetStreamer(string streamer)
        {
            if (streamer == string.Empty)
            {
                throw new Exception("O canal deve conter pelo menos um streamer.");
            }
            if (streamer.Trim().Count() < 3)
            {
                throw new Exception("Streamer deve conter pelo menos 3 caracteres.");
            }
            this.Streamers = streamer;
        }
        public void SetCategoria(string categoria)
        {
            if (categoria == string.Empty)
            {
                throw new Exception("Selecione uma categoria.");
            }
            this.Categoria = categoria;
        }
        public void SetLink(string link)
        {
            if (link == string.Empty)
            {
                throw new Exception("Informe um Link.");
            }
            this.Link = link;
        }
        public void SetInscritos(long inscritos) 
       {
           if (inscritos == 0)
           {
               throw new Exception("informe a quantidade de inscritos.");
           }
           this.QuantidadeInscritos = inscritos; 
       }
        public void SetViews(long views)
        {
            if (views == 0)
            {
                throw new Exception("Informe a quantiade de views.");
            }
            this.QuantidadeViews = views;
        }
        public void SetLikes(long likes)
       {
           if (likes == 0)
           {
               throw new Exception("Informe a quantidade de views.");
           }
           this.QuantidadeLikes = likes; 
       }
        public void SetVideos(long videos) 
       {
           if (videos == 0)
           {
               throw new Exception("Informe a quantidade de videos.");
           }
           this.QuantidadeVideo = videos; 
       }
        public void SetStrikes(long strikes) 
       {
           if (strikes == 0)
           {
               throw new Exception("Informe a quantiade de strikes.");
           }
           this.QuantiadeStrike = strikes; 
       }
        public void SetRenda(double renda)
        {
            if (renda == 0)
            {
                throw new Exception("Informe um renda.");
            }
            this.Renda = renda;
        }
        public void SetSimPatrocinador(bool patrocinador) { this.SimPatrocinador = patrocinador; }
        public void SetAnuncio(string anuncio) { this.Anuncio = anuncio; }

        public string GetNome() { return Nome; }
        public string GetApelido() { return Apelido; }
        public string GetNomeCanal() { return NomeCanal; }
        public string GetDescricao() { return DescricaoVideo; }
        public string GetNacionalidade() { return Nacionalidade; }
        public string GetPatrocinador() { return Patrocinador; }
        public string GetPlataforma() { return Plataforma; }
        public string GetStreamer() { return Streamers; }
        public string GetCategoria() { return Categoria; }
        public string GetLink() { return Link; }
        public long GetInscritos() { return QuantidadeInscritos; }
        public long GetViews() { return QuantidadeViews; }
        public long GetLikes() { return QuantidadeLikes; }
        public long GetVideos() { return QuantidadeVideo; }
        public long GetStrokers() { return QuantiadeStrike; }
        public double GetRenda() { return Renda; }
        public bool GetSimPatrocinador() { return SimPatrocinador; }
        public string GetAnuncio() { return Anuncio; }


    }
}
