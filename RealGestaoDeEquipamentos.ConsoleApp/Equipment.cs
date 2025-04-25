using System.Runtime.CompilerServices;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public class Equipment
    {
        public int Id;
        public string Nome;
        public string Fabricante;
        public decimal PrecoDoProduto;
        public DateTime DataDeFabricacao;

        public Equipment(string nome, string fabricante, decimal precoDoProduto, DateTime dataDeFabricacao) 
        {
            Nome = nome;
            Fabricante = fabricante;
            PrecoDoProduto = precoDoProduto;
            DataDeFabricacao = dataDeFabricacao;
        }

        
        public string ObterNumeroDeSerie()
        {
            string tresPrimeirosLetras = Nome.Substring(0, 3);

            return $"{tresPrimeirosLetras}-{Id}";
        }
        
            
    }
}
