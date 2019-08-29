using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Garagem
    {
        public int GaragemId { get; set; }
        public string Endereco { get; set; }
        public List<Veiculo> Veiculos { get; set; }
    }
}
