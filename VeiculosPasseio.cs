using System.Collections.Generic;
namespace trabalho1ex1poo
{
    public class VeiculosPasseio : Veiculos
    {
        public int quantidadePassageiros { get; set; }
        public VeiculosPasseio(int id, string cor, string modelo, string placa, string ano, int quantidadePassageiros, string tipo) : base(tipo, cor, modelo, placa, ano)
        {
            this.id = id;
            this.cor = cor;
            this.modelo = modelo;
            this.placa = placa;
            this.ano = ano;
            this.quantidadePassageiros = quantidadePassageiros;
            this.tipo = tipo;
        }
        public override void addVeiculo()
        {
            //sobrescrevendo o metodo addVeiculo() da classe pais, conforme pedido no exercicio
            Dados dados = Dados.getInstance();
            dados.passeios.Add(this);
        }
        public override List<Veiculos> GetVeiculos()
        {
            return base.GetVeiculos();
        }
    }
}
