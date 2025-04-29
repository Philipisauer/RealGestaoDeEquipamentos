using RealGestaoDeEquipamentos.ConsoleApp.Compartilhados;

namespace RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament
{
    public class EquipmentScreen
    {
        public EquipmentRepository EquipmentRepository;

        public EquipmentScreen()
        {
            EquipmentRepository = new EquipmentRepository();
        }

        public char ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Gestão de equipamentos");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("Informe a operação desejda:");
            Console.WriteLine("1 - Cadastrar equipamentos");
            Console.WriteLine("2 - Editar equipamentos");
            Console.WriteLine("3 - Excluir equipamentos");
            Console.WriteLine("4 - Visualizar equipamentos");
            char chosenOption = Console.ReadLine()![0];

            return chosenOption;
        }

        public void RegisterEquipment()
        {
            Console.Clear();

            Console.Write("Digite o nome do equipamento: ");
            string name = Console.ReadLine()!;

            Console.Write("Digite o fabricante do equipamento: ");
            string maker = Console.ReadLine()!;

            Console.Write("Digite o preço do equipamento R$: ");
            decimal valueOfProduct = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento (dd/mm/yyyy): ");
            DateTime fabricationDate = Convert.ToDateTime(Console.ReadLine());

            Equipment newEquipment = new Equipment(name, maker, valueOfProduct, fabricationDate);

            EquipmentRepository.RegisterEquipment(newEquipment);
        }

        public void editEquipment()
        {
            Console.Clear();
            Console.WriteLine("Editando equipamento...");
            Console.WriteLine("---------------------------------------");

            ViewEquipments(false);

            Console.WriteLine();
            Console.Write("digite o Id do equipamento que deseja editar: ");
            int chosenId = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine();

            Console.Write("Digite o nome do equipamento: ");
            string name = Console.ReadLine()!;

            Console.Write("Digite o fabricante do equipamento: ");
            string maker = Console.ReadLine()!;

            Console.Write("Digite o preço do equipamento: ");
            decimal valueOfProduct = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite a data de fabricação do equipamento: ");
            DateTime fabricationDate = Convert.ToDateTime(Console.ReadLine());

            Equipment newEquipment = new Equipment(name, maker, valueOfProduct, fabricationDate);
            newEquipment.Id = GeradorIds.CreateEquipmentId();

            bool couldEdit = EquipmentRepository.EditEquipment(chosenId, newEquipment);

            if (!couldEdit)
            {
                Console.WriteLine("Não foi possivel editar o equipamento...");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Equipamento editado!!!");

        }

        public void deletEquipment()
        {
            Console.Clear();
            Console.WriteLine("Excluindo equipamento...");
            Console.WriteLine("---------------------------------------\n");

            ViewEquipments(false);

            Console.WriteLine();
            Console.Write("Digite o Id do equipamento que deseja excluir: ");
            int chosenId = Convert.ToInt32(Console.ReadLine()!);

            bool couldDelet = EquipmentRepository.DeletEquipment(chosenId);

            if (!couldDelet)
            {
                Console.WriteLine("Não foi possivel excluir o equipamento");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("Equipamento excluido do sistema!!!");
        }

        public void ViewEquipments(bool showTitle)
        {
            if (showTitle)
            {
                Console.Clear();
                Console.WriteLine("Gestão de equipamentos");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Visualizando equipamentos...");
                Console.WriteLine("-----------------------------------------");
            }

            Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                "Id", "Nome", "Num. serie", "Fabricante", "Preço", "Data de fabricação"
            );

            //o que esta acontecendo aqui??

            Equipment[] registeredEquipment = EquipmentRepository.ChosenEquipment();

            for (int i = 0; i < registeredEquipment.Length; i++)
            {
                Equipment e = registeredEquipment[i];

                if (e == null) continue;

                Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                e.Id, e.Name, e.ObterNumeroDeSerie(), e.Maker, e.ProductValue.ToString("C2"), e.FabricationDate.ToShortDateString());
            }
            Console.ReadLine();
        }
    }
}
