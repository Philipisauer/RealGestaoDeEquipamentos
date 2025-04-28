using RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament;
using System.Security.Cryptography.X509Certificates;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            EquipmentScreen equipmentScreen = new EquipmentScreen();
            while(true)
            {
                string chosenOption = equipmentScreen.ShowMenu();

                switch (chosenOption)
                {
                    case "1":
                        equipmentScreen.registerEquipment();
                        break;

                    case "2":
                        equipmentScreen.editEquipment();
                        break;

                    case "3":
                        equipmentScreen.deletEquipment();
                        break;

                    case "4":
                        equipmentScreen.ViewEquipments(true);
                        break;

                    default:
                        Console.WriteLine("Saindo do programa...");
                        break;
                }

                Console.ReadLine();
            }
           

        }
    }
}
