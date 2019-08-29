using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class CadastroVeiculo : Form
    {
        public Veiculo Veiculo { get; set; }
        public CadastroVeiculo()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var cor = tbxCor.Text;
            var marca = tbxMarca.Text;
            var qtdPortas = tbxQtdPortas.Text;
            var modelo = tbxModelo.Text;
            int quantidadePortas = 0;


            if (!int.TryParse(qtdPortas, out quantidadePortas))
            {
                MessageBox.Show("Informe um valor numerico na quantidade de portas!");
            }

            Veiculo = new Veiculo(cor, quantidadePortas, marca, modelo);

            Close();
        }
    }
}
