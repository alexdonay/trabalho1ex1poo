using System.Collections.Generic;
namespace trabalho1ex1poo
{
    public class Veiculos
    {
        Dados dados = Dados.getInstance();
        public List<Veiculos> veiculo = new List<Veiculos>();
        public int id { get; set; }
        public string cor { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string ano { get; set; }
        public string tipo { get; set; }
        public Veiculos(string cor, string modelo, string placa, string ano, string tipo)
        {
            this.cor = cor;
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
            this.tipo = tipo;
        }
        public virtual void addVeiculo()
        {

        }
        public virtual List<Veiculos> GetVeiculos()
        {
            return null;
        }

    }

}
