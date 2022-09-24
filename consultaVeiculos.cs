using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            List<VeiculosPasseio> passeio = dados.passeios;
            foreach (VeiculosPasseio veiculo in passeio)
            {
                GridLeves.Rows.Add(veiculo.id, veiculo.cor, veiculo.modelo, veiculo.placa, veiculo.ano, veiculo.quantidadePassageiros,"", veiculo.tipo);
            }
            List<VeiculosPesados> pesados = dados.pesados;
            foreach (VeiculosPesados veiculo in pesados)
            {
                GridLeves.Rows.Add(veiculo.id, veiculo.cor, veiculo.modelo, veiculo.placa, veiculo.ano, "",veiculo.eixos, veiculo.tipo);
            }

        }

       

        private void GridLeves_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(e.RowIndex.ToString());
        }
    }
}
