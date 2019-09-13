namespace Projeto.WindowsForm
{
    partial class FormPrincipal
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
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(23, 63);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(100, 100);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "Veiculos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile2
            // 
            this.metroTile2.Location = new System.Drawing.Point(23, 169);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(100, 100);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "Garagens";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroTile3
            // 
            this.metroTile3.Location = new System.Drawing.Point(129, 63);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(100, 100);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "Clientes";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Name = "FormPrincipal";
            this.Text = "Aluga Car";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}