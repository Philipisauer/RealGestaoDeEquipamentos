﻿using RealGestaoDeEquipamentos.ConsoleApp.Compartilhados;
using RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament;
using System.Security.Cryptography.X509Certificates;

namespace RealGestaoDeEquipamentos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EquipmentScreen equipmentScreen = new EquipmentScreen();

            EquipmentRepository equipmentRepositoty = equipmentScreen.EquipmentRepository;

            CallScreen callScreen = new CallScreen(equipmentScreen);

            MainScreen mainScreen = new MainScreen();

            while (true)
            {
                char mainOption = mainScreen.ShowMainMenu();

                if (mainOption == '1')
                {
                    char chosenOption = equipmentScreen.ShowMenu();

                    switch (chosenOption)
                    {
                        case '1':
                            equipmentScreen.RegisterEquipment(); break;

                        case '2':
                            equipmentScreen.editEquipment(); break;

                        case '3':
                            equipmentScreen.deletEquipment(); break;

                        case '4':
                            equipmentScreen.ViewEquipments(true); break;

                        default:
                            break;
                    }
                }

                if (mainOption == '2')
                {
                    char chosenOption = callScreen.ShowMenu();

                    switch (chosenOption)
                    {
                        case '1':
                            callScreen.RegisterCall(); break;

                        case '2':
                            callScreen.editCall(); break;

                        case '3':
                            callScreen.deletCall(); break;

                        case '4':
                            callScreen.ViewCall(true); break;

                        default:
                            break;
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
