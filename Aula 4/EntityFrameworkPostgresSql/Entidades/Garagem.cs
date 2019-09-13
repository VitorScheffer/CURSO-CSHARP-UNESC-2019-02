using System;
using System.Collections.Generic;
using Projeto.Entidades.Interfaces;

namespace Projeto.Entidades
{
    public class Garagem:ICamposPadrao
    {
        public int Codigo { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataUltimaAlteracao { get; set; }
        public bool Ativo { get; set; }

        public string Endereco { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
