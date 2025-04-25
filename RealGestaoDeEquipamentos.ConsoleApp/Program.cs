namespace RealGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                    string fabricante = Console.ReadLine()!;

                    Console.WriteLine("Digite o preço do equipamento: ");
                    decimal valueOfProduct = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Digite a data de fabricação do equipamento");
                    DateTime fabricationDate = Convert.ToDateTime(Console.ReadLine());

                    Equipment equipamento = new Equipment(name, fabricante, valueOfProduct, fabricationDate);
                    break;

                default:
                    Console.WriteLine("saindo do programa...");
                        break;
                }
            Console.ReadLine();

        }
    }
}
