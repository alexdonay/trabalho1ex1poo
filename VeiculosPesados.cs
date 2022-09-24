using System.Collections.Generic;

namespace trabalho1ex1poo
{
    public class VeiculosPesados : Veiculos
    {
        public int id { get; set; }
        public int eixos { get; set; }
        public VeiculosPesados(int id,string cor, string modelo, string placa, string ano, int eixos, string tipo) : base(cor, modelo, placa, ano, tipo)
        {
            this.id = id;

            this.cor = cor;
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
            this.eixos = eixos;
            this.tipo = tipo;

        }

        public override void addVeiculo()
        {
            Dados dados = Dados.getInstance();
            dados.pesados.Add(this);
        }

        public override List<Veiculos> GetVeiculos()
        {
            return base.GetVeiculos();
        }
    }
}
