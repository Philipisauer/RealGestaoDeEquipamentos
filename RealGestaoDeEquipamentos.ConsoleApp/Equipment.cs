using System.Runtime.CompilerServices;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public class Equipment
    {
        public int Id;
        public string Name;
        public string Maker;
        public decimal ProductValue;
        public DateTime FabricationDate;

        public Equipment(string name, string maker, decimal productValue, DateTime fabricationDate) 
        {
            Name = name;
            Maker = maker;
            ProductValue = productValue;
            FabricationDate = fabricationDate;
        }

        
        public string ObterNumeroDeSerie()
        {
            string firstThreeLetters = Name.Substring(0, 3);

            return $"{firstThreeLetters}-{Id}";
        }
        
            
    }
}
