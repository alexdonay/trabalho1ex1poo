using System;
using System.Windows.Forms;

namespace trabalho1ex1poo
{
    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gpBox.Visible = false;
            gbPessado.Visible = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                gpBox.Visible = true;
                gbPessado.Visible = false;
            }
            else
            {
                gpBox.Visible = false;
                gbPessado.Visible = true;
            }
        }

        private void BtCadastraPasseio_Click(object sender, EventArgs e)
        {
            if (TxCorPasseio.Text == "" || TxAnoPasseio.Text == "" || TxPassageiros.Text == "" || TxPlacaPasseio.Text == "" || TxModeloPasseio.Text =="")
            {
                MessageBox.Show("Dados Incompletos");    

            }
            else
            {
                try
                {
                    Dados dados = Dados.getInstance();
                    int id = dados.passeios.Count;
                    VeiculosPasseio passeio = new VeiculosPasseio(id,TxCorPasseio.Text, TxModeloPasseio.Text, TxPlacaPasseio.Text, TxAnoPasseio.Text, int.Parse(TxPassageiros.Text),"Passeio");
                    passeio.addVeiculo();
                    MessageBox.Show("Veiculo cadastrado Com Sucesso");
                    TxCorPasseio.Text = "";
                    TxModeloPasseio.Text = "";
                    TxPlacaPasseio.Text = "";
                    TxAnoPasseio.Text = "";
                    TxPassageiros.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show("Algum erro ocorreu " + err);
                }
                
            }
        }

        private void BtConsultaPasseio_Click(object sender, EventArgs e)
        {
           consultaVeiculos formPasseio = new consultaVeiculos();
            formPasseio.Show();
        }

        private void BtnCadastraPessado_Click(object sender, EventArgs e)
        {
            if (TxCorPesado.Text == "" || TxAnoPesado.Text == "" || TxPlacaPesado.Text == "" || TxModeloPesado.Text == "" || int.Parse(TxEixos.Text) == 0)
            {
                MessageBox.Show("Dados Incompletos");

            }
            else
            {
                try
                {
                    Dados dados = Dados.getInstance();
                    int id = dados.pesados.Count;
                    VeiculosPesados pesados = new VeiculosPesados(id, TxCorPesado.Text, TxModeloPesado.Text, TxPlacaPesado.Text, TxAnoPesado.Text, int.Parse(TxEixos.Text), "Pesado");
                    pesados.addVeiculo();
                    MessageBox.Show("Veiculo cadastrado Com Sucesso");
                    TxCorPesado.Text = "";
                    TxModeloPesado.Text = "";
                    TxPlacaPesado.Text = "";
                    TxAnoPesado.Text = "";
                    TxEixos.Text = "";
                }
                catch (Exception err)
                {
                    MessageBox.Show("Algum erro ocorreu " + err);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultaVeiculos formPasseio = new consultaVeiculos();
            formPasseio.Show();
        }
    }
    
}
