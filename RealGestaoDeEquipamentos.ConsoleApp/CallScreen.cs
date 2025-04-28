using RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public class CallScreen
    {
        public EquipmentScreen equipmentScreen;

        public CallScreen(EquipmentScreen equipmentScreen)
        {
            this.equipmentScreen = equipmentScreen;
        }

        public char ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|           Gestão de chamados           |");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("1 - Cadastrar chamados");
            Console.WriteLine("2 - Editar chamados");
            Console.WriteLine("3 - Excluir chamados");
            Console.WriteLine("4 - Visualizar chamados");
            Console.WriteLine("S - Voltar\n");
            Console.Write("Informe a operação desejda:");
            char chosenOption = Console.ReadLine()![0];

            return chosenOption;
        }

        public void registerCall()
        {
            Showheader();

            Console.WriteLine("cadastrando chamado...");

            Console.Write("informe o titulo do chamado: ");
            string title = Console.ReadLine()!.Trim();

            Console.Write("informe a descriçao do chamado: ");
            string description = Console.ReadLine()!.Trim();

            ViewEquipments();
        }

        internal void deletCall()
        {
            
        }

        internal void editCall()
        {
            
        }

        internal void ViewCall(bool v)
        {
            
        }

        public void ViewEquipments()
        {

            Console.Clear();
            Console.WriteLine("Gestão de equipamentos");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Visualizando equipamentos...");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                "Id", "Nome", "Num. serie", "Fabricante", "Preço", "Data de fabricação"
            );

            for (int i = 0; i < equipmentScreen.equipments.Length; i++)
            {
                Equipment e = equipmentScreen.equipments[i];

                if (e == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                e.Id, e.Name, e.ObterNumeroDeSerie(), e.Maker, e.ProductValue.ToString("C2"), e.FabricationDate.ToShortDateString());
            }
        }

        public void Showheader()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("|           Gestão de chamados           |");
            Console.WriteLine("-----------------------------------------\n");

            Console.WriteLine();
        }
    }
}
