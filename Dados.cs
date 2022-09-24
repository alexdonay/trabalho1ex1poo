using System.Collections.Generic;
//Pseudo banco de dados para testes
namespace trabalho1ex1poo
{
    sealed class Dados
    {
        public static readonly Dados instance = new Dados();
        public List<VeiculosPasseio> passeios = new List<VeiculosPasseio>();
        public List<VeiculosPesados> pesados = new List<VeiculosPesados>();
        private Dados() { }
        private static Dados _instance;
        public static Dados getInstance()
        {
            if (_instance == null)
            {
                _instance = new Dados();
            }
            return _instance;
        }

    }
}
