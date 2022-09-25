using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace trabalho1ex1poo
{
    public partial class consultaVeiculos : Form
    {
        public consultaVeiculos()
        {
            InitializeComponent();
        }
        private void consultaPasseio_Load(object sender, EventArgs e)
        {
            Dados dados = Dados.getInstance();

            foreach (VeiculosPasseio veiculo in dados.passeios)
            {
                GridLeves.Rows.Add(veiculo.id, veiculo.cor, veiculo.modelo, veiculo.placa, veiculo.ano, veiculo.quantidadePassageiros, "", veiculo.tipo);
            }
            List<VeiculosPesados> pesados = dados.pesados;
            foreach (VeiculosPesados veiculo in pesados)
            {
                GridLeves.Rows.Add(veiculo.id, veiculo.cor, veiculo.modelo, veiculo.placa, veiculo.ano, "", veiculo.eixos, veiculo.tipo);
            }
        }

        private void GridLeves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewSelectedCellCollection cells = GridLeves.SelectedCells;
            int row = cells[0].RowIndex;
            int column = cells[0].ColumnIndex;

            TxtIDVeiculo.Text = GridLeves[0, row].Value.ToString();
            TxtTipo.Text = GridLeves[7, row].Value.ToString();

            if (GridLeves[7, row].Value.ToString() == "Passeio")
            {
                VeiculosPasseio passeio = new VeiculosPasseio((int)GridLeves[0, row].Value, GridLeves[1, row].Value.ToString(), GridLeves[2, row].Value.ToString(), GridLeves[3, row].Value.ToString(), GridLeves[4, row].Value.ToString(), 0, GridLeves[6, row].Value.ToString());
                TxtPedagio.Text = passeio.calculaPedagio().ToString();
            }
            else
            {
                VeiculosPesados pesados = new VeiculosPesados(0, "", "", "", "",(int)GridLeves[6, 0].Value, "");
                TxtPedagio.Text = pesados.calculaPedagio().ToString();

            }

        }
    }
}
