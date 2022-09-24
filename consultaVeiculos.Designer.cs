namespace trabalho1ex1poo
{
    partial class consultaVeiculos
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
            this.GridLeves = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passageiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eixos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridLeves)).BeginInit();
            this.SuspendLayout();
            // 
            // GridLeves
            // 
            this.GridLeves.AllowUserToAddRows = false;
            this.GridLeves.AllowUserToDeleteRows = false;
            this.GridLeves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLeves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Cor,
            this.Modelo,
            this.Placa,
            this.Ano,
            this.Passageiros,
            this.Eixos,
            this.Tipo});
            this.GridLeves.Location = new System.Drawing.Point(12, 12);
            this.GridLeves.Name = "GridLeves";
            this.GridLeves.ReadOnly = true;
            this.GridLeves.Size = new System.Drawing.Size(843, 343);
            this.GridLeves.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Cor
            // 
            this.Cor.HeaderText = "Cor";
            this.Cor.Name = "Cor";
            this.Cor.ReadOnly = true;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Passageiros
            // 
            this.Passageiros.HeaderText = "Passageiros";
            this.Passageiros.Name = "Passageiros";
            this.Passageiros.ReadOnly = true;
            // 
            // Eixos
            // 
            this.Eixos.HeaderText = "Eixos";
            this.Eixos.Name = "Eixos";
            this.Eixos.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // consultaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 356);
            this.Controls.Add(this.GridLeves);
            this.Name = "consultaVeiculos";
            this.Text = "Consulta Veiculos";
            this.Load += new System.EventHandler(this.consultaPasseio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLeves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridLeves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passageiros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eixos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}