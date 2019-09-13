namespace Projeto.WindowsForm.Veiculo
{
    partial class VeiculoListagem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Marca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Placa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ano = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Marca,
            this.Modelo,
            this.Placa,
            this.Ano});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 109);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(754, 318);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(373, 80);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Pesquisar";
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(23, 80);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PromptText = "Pesquisa...";
            this.metroTextBox1.Size = new System.Drawing.Size(344, 23);
            this.metroTextBox1.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Marca
            // 
            this.Marca.Text = "Marca";
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            // 
            // Placa
            // 
            this.Placa.Text = "Placa";
            // 
            // Ano
            // 
            this.Ano.Text = "Ano";
            // 
            // VeiculoListagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.listView1);
            this.Name = "VeiculoListagem";
            this.Text = "Veiculos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Marca;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader Placa;
        private System.Windows.Forms.ColumnHeader Ano;
    }
}