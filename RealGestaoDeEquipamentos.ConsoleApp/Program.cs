namespace RealGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static Equipment[] equipments = new Equipment[100];
        static int counterEquipament = 0;

        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("gestao de equipamentos");
                Console.WriteLine("-----------------------------------------\n");
                Console.WriteLine("informe a operação desejda:");
                Console.WriteLine("1 - cadastrar equipamentos");
                Console.WriteLine("4 - visualizar equipamentos");
                string chosenOption = Console.ReadLine()!;

                switch (chosenOption)
                {
                    case "1":
                        Console.Clear();

                        Console.WriteLine("Digite o nome do equipamento: ");
                        string name = Console.ReadLine()!;

                        Console.WriteLine("Digite o fabricante do equipamento: ");
                        string maker = Console.ReadLine()!;

                        Console.WriteLine("Digite o preço do equipamento: ");
                        decimal valueOfProduct = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Digite a data de fabricação do equipamento");
                        DateTime fabricationDate = Convert.ToDateTime(Console.ReadLine());

                        Equipment newEquipment = new Equipment(name, maker, valueOfProduct, fabricationDate);

                        equipments[counterEquipament++] = newEquipment;
                        break;

                    default:
                        Console.WriteLine("saindo do programa...");
                        break;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("gestao de equipamentos");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("visualizando equipamentos...");
                        Console.WriteLine("-----------------------------------------");

                        Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                            "id", "nome", "num. serie", "fabricante", "preço", "data de fabricaçao"
                    );

                        for (int i = 0; i < equipments.Length; i++)
                        {
                            Equipment e = equipments[i];

                            if (e == null) continue;

                            Console.WriteLine("{0, -10} | {1, -15} | {2, -11} | {3, -15} | {5, -10}",
                            e.Id, e.Name, e.ObterNumeroDeSerie(), e.Maker, e.ProductValue, e.FabricationDate);
                        }

                        break;
                }

                Console.ReadLine();
            }
           

        }
    }
}
