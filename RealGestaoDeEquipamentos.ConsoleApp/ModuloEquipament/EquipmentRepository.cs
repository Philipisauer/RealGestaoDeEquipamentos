

namespace RealGestaoDeEquipamentos.ConsoleApp.ModuloEquipament
{
    public class EquipmentRepository
    {
        public Equipment[] equipments = new Equipment[100];
        public int counterEquipment = 0;

        public void RegisterEquipment(Equipment newEquipment)
        {
            equipments[counterEquipment] = newEquipment;
            counterEquipment++;
            newEquipment.Id = counterEquipment;
        }

        public bool EditEquipment(int equipmentId, Equipment editedEquipment)
        {
            for (int i = 0; i < equipments.Length; i++)
            {
                if (equipments[i] == null) continue;

                else if (equipments[i].Id == equipmentId)
                {
                    equipments[i].Name = editedEquipment.Name;
                    equipments[i].Maker = editedEquipment.Maker;
                    equipments[i].ProductValue = editedEquipment.ProductValue;
                    equipments[i].FabricationDate = editedEquipment.FabricationDate;

                    return true;
                }
            }

            return false;
        }

        public bool DeletEquipment(int equipmentId)
        {
            for (int i = 0; i<equipments.Length; i++)
            {
                if (equipments[i] == null) continue;

                else if (equipments[i].Id == equipmentId)
                {
                    equipments[i] = null;

                    return true;
                }
            }
            return false;
        }
        public Equipment[] ChosenEquipment()
        {
            return equipments;
        }

        public Equipment ChosenEquipmentById(int equipmentId)
        {
            for (int i = 0; i < equipments.Length; i++)
            {
                Equipment e = equipments[i];

                if (e == null) continue;

                else if (e.Id == equipmentId)
                    return e;
            }
            return null;
        }
    }
}