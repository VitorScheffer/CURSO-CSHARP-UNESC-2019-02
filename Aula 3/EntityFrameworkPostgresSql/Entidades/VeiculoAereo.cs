using System;

namespace Projeto.Entidades
{
    public class VeiculoAereo : Veiculo, ITanqueCombustivel
    {
        public VeiculoAereo(string cor, int quantidadePortas, string marca, string modelo, double tamanhoAsa)
            : base(cor, quantidadePortas, marca, modelo)
        {
            TamanhoAsa = tamanhoAsa;
        }

        public double TamanhoAsa { get; set; }
        public string teste { get; set; }

        public void Abastecer()
        {
            throw new NotImplementedException();
        }

        public override void Acelerar()
        {
            Console.WriteLine("Ligando turbinas");
        }

        public override void Freiar()
        {
            Console.WriteLine("Desligando turbinas");
        }


    }
}
