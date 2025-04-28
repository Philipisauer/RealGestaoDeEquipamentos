namespace RealGestaoDeEquipamentos.ConsoleApp
{
    public static class GeradorIds
    {
        public static int EquipmentsId = 0;

        public static int createEquipmentId ()
        {
            EquipmentsId++;

            return EquipmentsId;
        }
    }
}
