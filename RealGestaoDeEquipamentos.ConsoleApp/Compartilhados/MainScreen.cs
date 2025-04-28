namespace RealGestaoDeEquipamentos.ConsoleApp.Compartilhados
{
    public class MainScreen
    {
        public MainScreen()
        {

        }

        public char ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Gestão de equipamentos");
            Console.WriteLine("-----------------------------------------\n");
            Console.WriteLine("1 - Gestão de equipamentos");
            Console.WriteLine("2 - Gestão de chamados");
            Console.WriteLine("S - Sair\n");
            Console.Write("Digite a opção desejada: ");
            char chosenOption = Console.ReadLine()![0];

            return chosenOption;
        }
    }
}