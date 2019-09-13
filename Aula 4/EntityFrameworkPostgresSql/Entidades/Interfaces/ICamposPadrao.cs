using System;

namespace Projeto.Entidades.Interfaces
{
    public interface ICamposPadrao
    {
        int Codigo { get; set; }
        DateTime DataCriacao { get; set; }
        DateTime? DataUltimaAlteracao { get; set; }
        bool Ativo { get; set; }
    }
}