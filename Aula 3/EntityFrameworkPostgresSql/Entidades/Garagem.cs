using System.Collections.Generic;

namespace Projeto.Entidades
{
    class Garagem
    {
        public int GaragemId { get; set; }
        public string Endereco { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
