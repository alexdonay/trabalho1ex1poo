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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtIDVeiculo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPedagio = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.GridLeves.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridLeves_CellClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(882, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calcula Pedágio";
            // 
            // TxtIDVeiculo
            // 
            this.TxtIDVeiculo.Location = new System.Drawing.Point(924, 72);
            this.TxtIDVeiculo.Name = "TxtIDVeiculo";
            this.TxtIDVeiculo.Size = new System.Drawing.Size(100, 20);
            this.TxtIDVeiculo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(861, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(924, 98);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(100, 20);
            this.TxtTipo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pedagio";
            // 
            // TxtPedagio
            // 
            this.TxtPedagio.Location = new System.Drawing.Point(924, 124);
            this.TxtPedagio.Name = "TxtPedagio";
            this.TxtPedagio.Size = new System.Drawing.Size(100, 20);
            this.TxtPedagio.TabIndex = 6;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(867, 185);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(156, 109);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "Ao clicar no grid ao lado o sistema calcula o pedágio do veículo.";
            // 
            // consultaVeiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 356);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPedagio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtIDVeiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridLeves);
            this.Name = "consultaVeiculos";
            this.Text = "Consulta Veiculos";
            this.Load += new System.EventHandler(this.consultaPasseio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridLeves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIDVeiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPedagio;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}