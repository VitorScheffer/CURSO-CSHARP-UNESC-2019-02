using System;
using Projeto.Entidades.Interfaces;

namespace Projeto.Entidades
{
    public class Veiculo:ICamposPadrao
    {
        public int Codigo { get; set; }
        public string Cor { get; private set; }
        public int QuantidadePortas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public int? GaragemId { get; set; }
        public virtual Garagem Garagem { get; set; }

        public DateTime? Fabricacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
