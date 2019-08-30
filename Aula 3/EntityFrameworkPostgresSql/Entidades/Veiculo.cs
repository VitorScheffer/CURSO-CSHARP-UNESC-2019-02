namespace Projeto.Entidades
{
    public class Veiculo
    {
        public Veiculo(string cor, int quantidadePortas, string marca, string modelo)
        {
            Cor = cor;
            QuantidadePortas = quantidadePortas;
            Marca = marca;
            Modelo = modelo;
        }

        public int VeiculoId { get; set; }
        public string Cor { get; private set; }
        public int QuantidadePortas { get; set; }
        public int QuantidadeRodas { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public virtual void Acelerar()
        {

        }

        public virtual void Freiar()
        {

        }

        public void Pintar(string novaCor)
        {
            Cor = novaCor;
        }
    }
}
