using RealGestaoDeEquipamentos.ConsoleApp.ModuloChamados;
using RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament;
using System.Security.Cryptography.X509Certificates;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public class CallScreen
    {
        public EquipmentScreen equipmentScreen;

        public EquipmentRepository equipmentRepository;
        public CallsRepository callsRepository;
        public CallScreen(EquipmentScreen equipmentScreen)
        {
            this.equipmentScreen = equipmentScreen;
            callsRepository = new CallsRepository();
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

        public void RegisterCall()
        {
            Showheader();
            Console.WriteLine("Cadastrando Chamado...");

            Call newCall = GetCallsInformations();

            callsRepository.RegisterCall(newCall);

            Console.WriteLine("Chamado foi cadastrado!!");
        }

        public void editCall()
        {
            Showheader();

        }


        internal void deletCall()
        {
            
        }

        

        internal void ViewCall(bool v)
        {
            
        }

        public void ViewEquipments()
        {

            Console.Clear();
            Console.WriteLine("Gestão de chamados");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Visualizando chamados...");
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                "Id", "Nome", "Num. serie", "Fabricante", "Preço", "Data de fabricação"
            );

            Equipment[] equipments = equipmentRepository.ChosenEquipment();

            for (int i = 0; i < equipments.Length; i++)
            {
                Equipment e = equipments[i];

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
        public Call GetCallsInformations()
        {
            Console.WriteLine("cadastrando chamado...");

            Console.Write("informe o titulo do chamado: ");
            string title = Console.ReadLine()!.Trim();

            Console.Write("informe a descriçao do chamado: ");
            string description = Console.ReadLine()!.Trim();

            ViewEquipments();

            Console.Write("digite o Id do Equipamento que deseja selecionar: ");
            int equipmentId = Convert.ToInt32(Console.ReadLine()!.Trim());

            Equipment chosenEquipment = equipmentRepository.ChosenEquipmentById(equipmentId);

            Call newCall = new Call(title, description, chosenEquipment);

            return newCall;
        }
    }
}
