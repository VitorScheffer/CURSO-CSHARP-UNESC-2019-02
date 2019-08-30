using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Projeto.Entidades;

namespace Projeto.WindowsForm
{
    public partial class FormPrincipal : Form
    {
        public List<Veiculo> Veiculos { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Veiculos = new List<Veiculo>();
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            var list = new List<Veiculo>();
            var veiculo = new VeiculoAereo("Azul",4,"FIAT","UNO",1);
            list.Add(veiculo);


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var form = new CadastroVeiculo();
            form.ShowDialog();

            Veiculos.Add(form.Veiculo);
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(tbxFiltroMarca.Text))
            {
                foreach(var item in Veiculos)
                {
                    string[] row = { item.Cor, item.Marca, item.Modelo, item.QuantidadePortas.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
            else
            {
                foreach (var item in Veiculos.Where(veiculo => veiculo.Marca.Contains(tbxFiltroMarca.Text)))
                {
                    string[] row = { item.Cor, item.Marca, item.Modelo, item.QuantidadePortas.ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
    }
}
